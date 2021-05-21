#
# Program to remotely access and control OBS
#
# TODO:
#   - build a gui w/ glade
#   - testing
#   - maybe separate gui into separate file
#   - serial macros setup

# imports
# libraries
import requests		# communicate w/ esp32 remotes

import gi # 
gi.require_version('Gtk','3.0') # set proper version?
from gi.repository import Gtk   # ui

import obspython as obs         # communicate w/ obs
# files where other stuff is
import macro_board				# use a arduino-based macro board


# variables
VERSION = '0.0.1 alpha'
baudrate = 9600
serial_timeout = 0.1

# main things

# gtk gui stuff
window = Gtk.Window(title='OBS Control v '+ version) 
window.show()
window.connnect('destroy', Gtk.main_quit)
Gtk.main()

