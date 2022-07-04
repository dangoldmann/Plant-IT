void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  char mystr[6]; //Initialized variable to store recieved data
  String entrada;
  if (Serial.available() ){
    //Serial.readBytes(mystr,6); //Read the serial data and store in var
    //Serial.println(mystr); //Print data on Serial Monitor
    entrada = Serial.readString();
    Serial.println(entrada);
    delay(100); 
  }
}
