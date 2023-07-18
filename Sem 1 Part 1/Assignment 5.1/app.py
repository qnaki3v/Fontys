from sqlite3 import DataError
from datetime import datetime
from flask import Flask, render_template
from fhict_cb_01.CustomPymata4 import CustomPymata4

app = Flask(__name__)

DHTPIN = 12
LDRPIN = 2

def initialize_statistics():
    # return fresh dictionairy
    return {
        "humidity": 0,
        "temperature": 0,
        "lightlevel": 0
    }
def current_time():
    time = datetime.now().strftime("%m/%d/%Y, %H:%M:%S")
    return "Timestamp: " + time

statistics_current = initialize_statistics()  # None

statistics_sum = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
statistics_count = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
statistics_min = {
    "humidity": 10000,
    "temperature": 10000,
    "lightlevel": 10000
}
statistics_max = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
statistics_average = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
statistics_data = {
    "Temperature": ("{:.1f}".format(statistics_current["temperature"]), "{:.1f}".format(statistics_average["temperature"])),
    "Humidity": ("{:.1f}".format(statistics_current["humidity"]), "{:.1f}".format(statistics_average["humidity"])),
    "Lightlevel": ("{:.1f}".format(statistics_current["lightlevel"]), "{:.1f}".format(statistics_average["lightlevel"]))
}


# def Measure(data):
#     global statistics_current
#     if (data[3] == 0):
#         if statistics_current == None:
#             statistics_current = initialize_statistics()
#         statistics_current["humidity"] = "{:.1f}".format(data[4])
#         statistics_sum["humidity"] += data[4]
#         statistics_count["humidity"] += 1

#         if statistics_min["humidity"] > data[4]:
#             statistics_min["humidity"] = data[4]

#         if statistics_max["humidity"] < data[4]:
#             statistics_max["humidity"] = data[4]

#         statistics_average["humidity"] = "{:.1f}".format(statistics_sum["humidity"] / statistics_count["humidity"])

#         statistics_current["temperature"] = "{:.1f}".format(data[5])
#         statistics_sum["temperature"] += data[5]
#         statistics_count["temperature"] += 1

#         if statistics_min["temperature"] > data[5]:
#             statistics_min["temperature"] = data[5]

#         if statistics_max["temperature"] < data[5]:
#             statistics_max["temperature"] = data[5]

#         statistics_average["temperature"] = "{:.1f}".format(statistics_sum["temperature"] / statistics_count["temperature"])


# def LDRChanged(data):
#     global statistics_current
#     if statistics_current == None:
#         statistics_current = initialize_statistics()

#     statistics_current["lightlevel"] = "{:.1f}".format(data[2])
#     statistics_sum["lightlevel"] += data[2]
#     statistics_count["lightlevel"] += 1

#     if statistics_min["lightlevel"] > data[2]:
#         statistics_min["lightlevel"] = data[2]

#     if statistics_max["lightlevel"] < data[2]:
#         statistics_max["lightlevel"] = data[2]

#     statistics_average["lightlevel"] = "{:.1f}".format(statistics_sum["lightlevel"] / statistics_count["lightlevel"])


# def setup():
#     global board
#     board = CustomPymata4(com_port="COM3")
#     board.set_pin_mode_dht(DHTPIN, sensor_type=11, differential=.05, callback=Measure)
#     board.set_pin_mode_analog_input(LDRPIN, callback=LDRChanged, differential=10)

# setup()

@app.route('/')
def home_page():
    return render_template('index.html')
@app.route('/contact')
def contact_page():
    return render_template('contact.html')
@app.route('/sensors')
def sensors():
    return render_template('sensors.html', statistics_current=statistics_current, statistics_min = statistics_min, statistics_max = statistics_max, statistics_average=statistics_average, time=current_time())
