import json
import csv
import requests
input_file = '/server/stats.csv'
url = "http://localhost:5000/post_data"

with open(input_file, newline='') as csvfile: # Open the CSV file and upload it to the server line by line.
    reader = csv.DictReader(csvfile)
    for row in reader:
        response = requests.post(url, json=row)
        if response.status_code!=200:
            print(response.text)
