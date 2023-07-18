from os import listdir
from flask import Flask, request, render_template
from datetime import datetime

app = Flask(__name__)

fullData = []

@app.route("/post_data", methods = ['POST'])
def Receive_data():
    json_data = request.json
    fullData.append(json_data)
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
    listData=[]
    for i in fullData:
        listData.append(list(i.values()))

    return render_template('sensors.html', statistics_current=listData,  statistics_min = statistics_min, statistics_max = statistics_max, statistics_average=statistics_average, time=datetime.now().strftime("%m/%d/%Y, %H:%M:%S"))