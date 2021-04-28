// MOTOR SETUP
#include <AccelStepper.h>
#define dirPin 4
#define stepPin 5
#define motorInterfaceType 1
AccelStepper stepper = AccelStepper(motorInterfaceType, stepPin, dirPin);
int range = 4750;

// SPEEDS
int fast = 800;
int med = 400;
int slow = 100;

// HOMING
bool homed = false;
int LED = 6;
int sensor = 10;

// MUSIC
bool playIt = true;
int coun;
bool dir = 0;
int del;
int c = 1912;
int cf = 1805;
int d = 1703;
int df = 1607;
int e = 1517;
int f = 1431;
int ff = 1351;
int g = 1275;
int gf = 1203;
int a = 1136;
int af = 1072;
int b = 1012;
int c1 = floor(c / 2);
int cf1 = floor(cf / 2);
int d1 = floor(d / 2);
int df1 = floor(df / 2);
int e1 = floor(e / 2);
int f1 = floor(1431 / 2);
int ff1 = floor(1351 / 2);
int g1 = floor(1275 / 2);
int gf1 = floor(1203 / 2);
int a1 = floor(1136 / 2);
int af1 = floor(1072 / 2);
int b1 = floor(1012 / 2);
int e0 = e * 2;
int g0 = g * 2;
int b0 = b * 2;
int af0 = af * 2;
int a0 = a * 2;
int f0 = f * 2;
int use = 180;
int tempo = 120;
int oct = 5;

void setup()
{
  // INIT HALL SENSOR
  pinMode(sensor, INPUT_PULLUP);

  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);

  // MOTOR CONFIG
  stepper.setMaxSpeed(1000);
}

void loop()
{
  if (not homed)
    homeStage();

  if (playIt)
  {
    play();
    playIt = false;
    homeStage();
  }
}

void homeStage()
{
  for (int i = 1; i <= 3; i++) {
    int homing = 1;
    while (homing == 1)
    {
      stepper.setSpeed(int(-fast / (i * 2)));
      stepper.runSpeed();
      homing = digitalRead(10);
    }
    stepper.setCurrentPosition(0);

    if (i == 3)
      break;

    while (stepper.currentPosition() != 100)
    {
      stepper.setSpeed(fast);
      stepper.runSpeed();
    }
  }
  
  stepper.setCurrentPosition(0);
  homed = true;

  while (stepper.currentPosition() != range / 2)
  {
    stepper.setSpeed(fast);
    stepper.runSpeed();
  }
}

void play() {
  oct = 5;
  for (int i = 0; i < 3; i++) {
    note(d, 100);
    pa(use);
    note(f, 100);
    pa(use);
    note(c1, 100);
    pa(use);
    note(f, 100);
    pa(use);
  }
  note(c1, 100);
  pa(use);
  note(c1, 100);
  pa(use);
  note(af, 100);
  pa(use);
  note(a, 100);
  pa(use);
  for (int i = 0; i < 3; i++) {
    note(c, 100);
    pa(use);
    note(e, 100);
    pa(use);
    note(af, 100);
    pa(use);
    note(e, 100);
    pa(use);
  }
  note(af, 100);
  pa(use);
  note(af, 100);
  pa(use);
  note(a, 100);
  pa(use);
  note(f, 100);
  pa(use);
  for (int i = 0; i < 3; i++) {
    note(d, 100);
    pa(use);
    note(f, 100);
    pa(use);
    note(af, 100);
    pa(use);
    note(f, 100);
    pa(use);
  }
  for (int i = 0; i < 3; i++) {
    note(af0, 100);
    pa(use);
    note(d, 100);
    pa(use);
    note(f, 100);
    pa(use);
    note(a, 100);
    pa(use);
  }
}

void note(int num, long dur) {
  del = (num * oct) / 10;
  dir = !dir;
  digitalWrite(dirPin, dir);
  coun = floor((dur * 5 * tempo) / del);
  for (int x = 0; x < coun; x++) {
    digitalWrite(stepPin, HIGH);
    delayMicroseconds(del);
    digitalWrite(stepPin, LOW);
    delayMicroseconds(del);
  }
}

void pa(int durp) {
  int ker = floor(durp / 100) * tempo;
  delay(ker);
}
