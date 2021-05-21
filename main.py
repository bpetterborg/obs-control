#
# Program to remotely access and control OBS
#
# TODO:
#   - build a gui w/ glade
#   - testing
#   - maybe separate obs into separate file
#   - serial macros setup


# imports
# libraries
import gi
gi.require_version('Gtk','3.0') # set proper version?
from gi.repository import Gtk   # ui

import obspython as obs         # communicate w/ obs
# files where other stuff is
import macro_board              # use a arduino-based macro board
import esp32_remote_control		# use a esp32-based remote control

# variables
VERSION = '0.0.1 alpha'
baudrate = 9600
serial_timeout = 0.1
serial_port = 'COM5'
	

# main stuff


