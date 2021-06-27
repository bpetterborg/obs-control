/*
 *  This is a website to remotely manage
 *	an OBS server
 * 	
 * 	TODO:
 * 		- figure out connections
 * 	
 */

// imports
const OBSWebSocket = require('obs-websocket-js');
const express = require('express');
var fs = require('fs');

// variables
const obs = new OBSWebSocket();
const app = express();
const port = 3000; // may need to change this

var obs_url = 'localhost:4444';
var obs_password = fs.readFileSync('obs_password', 'utf8');

// connect to obs server
obs.connect({ address: obs_url, password: obs_password }); 

// webapp stuff
app.get('/', (req, res) => {
	res.send('Stream Controller');
});

app.listen(port, () => {
	console.log(`Listening at localhost:${port}`);
});