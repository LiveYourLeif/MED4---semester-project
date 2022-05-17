
#include "Keyboard.h"

// set pin numbers for the five buttons:
const int upButton = 2;
const int downButton = 3;
const int leftButton = 5;
const int rightButton = 4;

void setup() { // initialize the buttons' inputs:
  pinMode(upButton, INPUT);
  pinMode(downButton, INPUT);
  pinMode(leftButton, INPUT);
  pinMode(rightButton, INPUT);

  Serial.begin(9600);
  // initialize mouse control:
  Keyboard.begin();
}

void loop() {

  // use the pushbuttons to control the keyboard:
  if (digitalRead(upButton) == HIGH) {
    Keyboard.write('w');
  }
  if (digitalRead(downButton) == HIGH) {
    Keyboard.write('s');
    
  }  if (digitalRead(leftButton) == HIGH) {
    Keyboard.write('a');
    delay(250);
  }
  if (digitalRead(rightButton) == HIGH) {
    Keyboard.write('d');
    delay(250);
  }
}
