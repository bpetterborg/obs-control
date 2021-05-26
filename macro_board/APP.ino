/*
 *	This runs on the arduino running
 *	the macroboard. 
 *
 */


// not sure what this does, it's a stackoverflow paste
/*typedef struct {
    uint8_t pinNum;
    bool pinVal;
} pinInit_t
*/

// variables
char incomingData; // might need to fix this later

// array of input pins
int digitalInputPins[] =
{
	2, 3, 4, 5, 6, 7, 8, 9, 10, 11
};

// array of output pins
int digitalOutputPins[] =
{
	12, 13, 14, 15, 16, 17	
};


// run once at start
void setup()
{
	Serial.begin(9600); // start serial
	Serial.write('CONNECTED);
	
	// setup pins (digital inputs)
	for(int i = 0; i < sizeof(digitalInputPins) / sizeof(digitalInputPins[0]); i++)
	{
		pinMode(digitalInputPins[i], INPUT);
	}
	
	// setup pins (digital outputs)
	for(int i = 0; i < sizeof(digitalOutputPins) / sizeof(digitalOutputPins[0]); i++)
	{
		pinMode(digitalOutputPins[i], INPUT);
		digitalWrite(digitalOutputPins[i], HIGH);
	}
	
	delay(5000);
	
	for(int i = 0; i < sizeof(digitalOutputPins) / sizeof(digitalOutputPins[0]); i++)
	{
		digitalWrite(digitalOutputPins[i], LOW);
	}
	
	Serial.write('READY');
	
}
	
void main()
{
	
}
