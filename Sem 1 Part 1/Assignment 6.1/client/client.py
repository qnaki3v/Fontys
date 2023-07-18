import requests
from fhict_cb_01.CustomPymata4 import CustomPymata4
from flask import request

DHTPIN = 12
LDRPIN = 2

def Initialize_statistics():
    return {
        "humidity": 0,
        "temperature": 0,
        "lightlevel": 0
    }

statistics_current = Initialize_statistics()

def Measure(data):
    global statistics_current
    if (data[3] == 0):
        if (statistics_current == None):
            statistics_current = Initialize_statistics()
    statistics_current["humidity"] = "{:.1f}".format(data[4])
    statistics_current["temperature"] = "{:.1f}".format(data[5])
def LDRChanged(data):
    global statistics_current
    if (statistics_current == None):
        statistics_current = Initialize_statistics()
    statistics_current["lightlevel"] = "{:.1f}".format(data[2])


def Setup():
    global board
    board = CustomPymata4(com_port="COM3")
    board.set_pin_mode_dht(DHTPIN, sensor_type=11, differential=.05, callback=Measure)
    board.set_pin_mode_analog_input(LDRPIN, callback=LDRChanged, differential=10)

sensorData=[]
sensorID="sensor_FIXIT"
input_file = 'server/stats.csv'
url = "http://localhost:5000/post_data"

def AppendStatistics():
    sensorData.append(statistics_current)

def Upload():
    AppendStatistics()
    for row in sensorData:
        response = requests.post(url, json=row)
        if response.status_code != 200:
            print(response.text)

Upload()
