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
obs.connect({
        address: obs_url,
        password: obs_password
    })
    
    .then(() => {
        console.log(`OBSWS: Successfully connected and authenticated`);

        return obs.send('GetSceneList');
    })
    
    .catch(err => { // Promise convention dicates you have a catch on every chain.
        console.log(err);
    });


obs.on('SwitchScenes', data => {
    console.log(`OBSWS: New Active Scene: ${data.sceneName}`);
});

// for handling uncaught exceptions
obs.on('error', err => {
    console.error('OBSWS: socket error:', err);
});




