/*
 *	This runs on the arduino running
 *	the macroboard. 
 *
 */

typedef struct {
    uint8_t pinNum;
    bool pinVal;
} pinInit_t

// variables
char incomingData; // might need to fix this later
int digitalInputPins[] =
{
	2, 3, 4, 5, 6, 7, 8, 9, 10, 11
};
int digitalOutputPins[] =
{
	12, 13, 14, 15, 16, 17	
};


// run once at start
void setup()
{
	Serial.begin(9600); // start serial
	Serial.write('Connected to Macroboard');
	
	// setup pins (digital inputs)
		
	
	
}
	
void main()
{
	
}
