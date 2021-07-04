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
var http = require('http');


// variables
const obs = new OBSWebSocket();
const port = 3000; // may need to change this

// for web interface
const webserver = http.createServer((req, res) => {
	res.writeHead(200, { 'content-type': 'text/html' });
	fs.createReadStream('index.html').pipe(res);	
});

var obs_url = 'localhost:4444'; // have this set in webapp
var obs_password = fs.readFileSync('obs_password', 'utf8'); // also have the set in webapp

// start web interface
webserver.listen(process.env.PORT || 3000)

// connect to obs server
function connectToServer() {
	
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
}

// notify user about scene changes
obs.on('SwitchScenes', data => {
	console.log(`OBSWS: New Active Scene: ${data.sceneName}`);
});

// for handling uncaught exceptions
obs.on('error', err => {
	console.error('OBSWS: socket error:', err);
});

connectToServer();