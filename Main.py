from flask import Flask, request
#Need to work with ConfigFile
from configparser import ConfigParser

import os
#Need to load and parse incoming JSON`s
import json
#need to request for external API
import requests

#Get environmental variable with port-number
neededport = os.environ.get('SERV_PORT')

app = Flask(__name__)
#run server on specified port
app.run(port=neededport)
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
    #check if returns error code
    if result.status_code != 200:
        return cfg['Err']['400'], 400
    currweather = json.loads(result.content)
    temp = currweather['current']['temp_c']   
    # takes current temperature for city
    return json.dumps({"city": city, "unit": 'celsius', "temperature": temp })

@app.route('/v1/weather/')
def getweather():
    city = request.args.get('city')
    tstp = request.args.get('dt')
    Link = cfg['URLS']['FC']
    result = requests.get(Link)
    #check if returns error code
    if result.status_code != 200:
        return cfg['Err']['400'], 400
    #configure paremeters of the returned file
    mas = json.loads(result.content)
    forecasts_massive = mas['forecast']['forecastday']
    temp = forecasts_massive[int(tstp)-1]['day']['avgtemp_c']
    return json.dumps({"city": city, "unit": 'celsius', "temperature": temp })

