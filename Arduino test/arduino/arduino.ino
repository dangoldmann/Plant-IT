void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  String i;
  char mystr[6]; //String data
  String txtHumedad = String(42);
  String txtLuz = String(32);
  i = "1" + txtHumedad + txtLuz;
  i.toCharArray(mystr,6);
  Serial.write(mystr,6); //Write the serial data
  //Serial.write(13);
  Serial.println();
  delay(10000);
}
