const int buttonPin1 = 5;
const int buttonPin2 = 8;
const int buttonPin3 = 13;
int buttonState1 = 0;
int buttonState2 = 0;
int buttonState3 = 0;

void setup() {
  Serial.begin(115200);
  pinMode(buttonPin1, INPUT_PULLUP); // Inputモードでプルアップ抵抗を有効に
  pinMode(buttonPin2, INPUT_PULLUP);
  pinMode(buttonPin3, INPUT_PULLUP);
}
 
void loop() {
  buttonState1 = digitalRead(buttonPin1);
  buttonState2 = digitalRead(buttonPin2);
  buttonState3 = digitalRead(buttonPin3);
  if (buttonState1 == LOW||buttonState2 == LOW||buttonState3 == LOW) {     // ボタンが押されていたら、ピンの値はLOW
    
    Serial.println("HIGH");  
  } 
  else {
    
    Serial.println("LOW"); 
  }
  delay(50);
}
