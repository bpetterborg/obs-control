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
var fs = require('fs');

// variables
const obs = new OBSWebSocket();

var obs_url = 'localhost:4444';
var obs_password = fs.readFileSync('obs_password', 'utf8');

// connect
obs.connect({ address: obs_url, password: obs_password }); 

// error handling
obs.on('error', err => {
    console.error('socket error:', err);
});
