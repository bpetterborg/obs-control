#   Utility for managing an OBS Stream
#   
#   This uses OBS-Websockets, in conjunction with OBS-WS-RC,
#   to interface with an OBS server.
#
#	TODO:
#   

# imports
import asyncio
import logging
import sys

from obswsrc import OBSWS       # talking to the obs server
from obswsrc.logs import logger

# set logging level, some stuff makes errors on creation
logger.setLevel(logging.Error)
logger.addHandler(logging.StreamHandler(stream=sys.stdout))

# variables
OBS_PASSWORD = open('token', 'r') # read file that has the open password

# main stuff
async def main():

	async with OBSWS('localhost', 4444, OBS_PASSWORD) as obsws:

		print('Connection Established.')

		event = await obsws.event() # receive events here

		while event is not None:
			print("Awaited for '{}' event!".format(event.type_name))
			event = await obsws.event()

		print('Conneciton Terminated.')

