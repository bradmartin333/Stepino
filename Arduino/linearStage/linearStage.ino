// MOTOR SETUP
#include <AccelStepper.h>
#define dirPin 4
#define stepPin 5
#define motorInterfaceType 1
AccelStepper stepper = AccelStepper(motorInterfaceType, stepPin, dirPin);

// SPEEDS
int fast = 800;
int med = 400;
int slow = 100;

// HOMING
int sensor = 10;
int range = 4750;

// COMMS
long pos = 0;
bool CMD_G = false;

void setup()
{
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  establishContact();  // send a byte to establish contact until receiver responds
  Serial.println("HELLO");

  pinMode(sensor, INPUT_PULLUP); // INIT HALL SENSOR
  stepper.setMaxSpeed(1000); // MOTOR CONFIG
}

void loop()
{
  int bytes = Serial.available();
  if (bytes > 0) {
    int inByte = Serial.read();
    if (inByte == 72) // H
    {
      homeStage();
    }
    else if (inByte == 71) // G
    {
      CMD_G = true;
    }
    else if (CMD_G)
    {
      pos += (long(inByte - '0') * (pow(10, bytes)) + 1) / 10;
    }
  }
  else if (CMD_G)
  {
    moveStage();
    pos = 0;
    CMD_G = false;
  }
}

void establishContact() {
  while (Serial.available() <= 0) {
    Serial.println("CONNECTING...");
    delay(300);
  }
}

void homeStage()
{
  Serial.println("HOMING");
  
  int homing = 1;
  while (homing == 1)
  {
    stepper.setSpeed(-med);
    stepper.runSpeed();
    homing = digitalRead(10);
  }
  stepper.setCurrentPosition(0);

  while (stepper.currentPosition() != range / 2)
  {
    stepper.setSpeed(fast);
    stepper.runSpeed();
  }

  Serial.println("HOMED");
}

void moveStage()
{
  if (0 <= pos <= range)
  {
    int dir = 1;
    if (stepper.currentPosition() > pos)
    {
      dir = -1;
    }
    while (stepper.currentPosition() != pos)
    {
      stepper.setSpeed(dir * fast);
      stepper.runSpeed();
    }
  }

  Serial.println("OK");
}
