#
# Program to remotely access and control OBS
#
# TODO:
#
#

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



# main things

# gtk gui
window = Gtk.Window(title='OBS Control v '+ version) 
