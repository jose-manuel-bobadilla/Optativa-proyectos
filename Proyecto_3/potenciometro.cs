int LED=3;  //LED conectado al pin digital 3 
int BRILLO; //variable para guardar el brillo calculado
int POT=0;  //pin del potenciometro

void setup(){
  pinMode(LED,OUTPUT); //LED como salida 
}
void loop(){
  BRILLO= analogRead(POT)/4;  
  analogWrite(LED, BRILLO);  
}

//Tinker: https://www.tinkercad.com/things/igiqIMbOkB4-copy-of-laboratori2?sharecode=_MxkhghpA7QQsaWZhNvvU3DRdB1JOoY1tWrVfGJBht4