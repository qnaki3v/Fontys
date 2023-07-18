from datetime import datetime
from operator import methodcaller
from flask import Flask, request, render_template


def current_time():
    time = datetime.now().strftime("%m/%d/%Y, %H:%M:%S")
    return "Timestamp: " + time

datalist = []
def initialize_statistics():
    # return fresh dictionairy
    return {
        "humidity": 0,
        "temperature": 0,
        "lightlevel": 0
    }

statistics_current = initialize_statistics() 
datalist.append(statistics_current)
statistics_min = {
    "humidity": 10000,
    "temperature": 10000,
    "lightlevel": 10000
}
datalist.append(statistics_min)
statistics_max = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
datalist.append(statistics_max)
statistics_average = {
    "humidity": 0,
    "temperature": 0,
    "lightlevel": 0
}
datalist.append(statistics_average)


app = Flask(__name__)

@app.route("/post_data", methods=['POST']) # Receive data from both CSV reader and Arduino Clients
def receive_data():
    json_data = request.json
    datalist.append(json_data)
    print(json_data)
    return "OK", 200
    

@app.route('/')
def home_page():
    return render_template('index.html')
@app.route('/contact')
def contact_page():
    return render_template('contact.html')
@app.route('/sensors')
def sensors():
    statistics_current = datalist[0]
    statistics_min = datalist[1]
    statistics_max = datalist[2]
    statistics_average = datalist[3]
    return render_template('sensors.html', statistics_current=statistics_current, statistics_min = statistics_min, 
    statistics_max = statistics_max, statistics_average=statistics_average, time=current_time())
