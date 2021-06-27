/*
 *  This is a website to remotely manage
 *	an OBS server
 * 	
 * 	TODO:
 * 		-
 * 	
 */

// imports
const OBSWebSocket = require('obs-websocket-js');
var fs = require('fs');

// variables
const obs = new OBSWebSocket();

var obs_url = 'localhost:4444';
var obs_password_file; // may need to set this to be a string
var obs_password = fs.open(obs_password_file, 'r'); // unsure if this is correct

// connect
obs.connect({ address: obs_url, password: obs_password });
