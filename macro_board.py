#	This part of it receives the serial data from the Arduinos
#	that control the macro board. 
#	
#	TODO:
#		- Use try-catch for connection
#		- testing

# imports
import serial	# communicate with arduino
import time

# connect to arduino
def connect_serial():
	print(f'Connecting to Arduino over Serial @ {baudrate} Baud...')
	
	# connect
	arduino = serial.Serial(port, baudrate, timeout)

	arduino.write('CONNECTED')
	print('Connected')
	return 'CONNECTED'
	
def read_input():
	time.sleep(0.05)
	serial_input = arduino.readline()[:2] # :2 thing strips line endings
	return serial_input
