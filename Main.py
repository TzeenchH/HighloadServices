from flask import Flask, request
from configparser import ConfigParser

import os
import json
import requests

app = Flask(__name__)
#read configfile
cfg = ConfigParser()
cfg.read('configs.ini')
@app.route('/')
def home():
    return 'for current weather'

@app.route('/v1/current/')
def getcurrent():
    city = request.args.get('city')
    #configure link to call for API
    Link = cfg['URLS']['CW'].format(city = city)
    result = requests.get(Link)
    #check if return error code
    if result.status_code == 400:
        return ['Err']['400'], 400
    mas = json.loads(result.content)
    temp = mas['current']['temp_c']   
    # returns current temperature for city
    return json.dumps({"city": city, "unit": 'celsius', "temperature": temp })

@app.route('/v1/weather/')
def getweather():
    city = request.args.get('city')
    tst = request.args.get('dt')
    Link = cfg['URLS']['FC']
    result = requests.get(Link)
    if result.status_code == 400:
        return ['Err']['400'], 400
    mas = json.loads(result.content)


    