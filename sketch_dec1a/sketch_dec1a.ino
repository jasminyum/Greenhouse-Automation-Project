#include <LiquidCrystal.h>
#include <DHT.h>
LiquidCrystal lcd(8, 7, 6, 5, 4, 3);
#define DHTPIN 2
#define DHTTYPE DHT11
#define MQ2pin (8)

float gasvalue;

DHT dht(DHTPIN, DHTTYPE);
int esik1 = 700;
int esik2 = 950;
int esik3 = 300;
int buttonfan = A4;
int buttonfanDurum = 0;
int buttonled = A3;
int buttonledDurum = 0;
int buttonnem = A5;
int buttonnemDurum = 0;
int switch1 = 11;
int switch1Durum = 0;
int switch2 = 12;
int switch2Durum = 0;
int ldr = A2;
int ldrDurum;
int suseviye = A1;
int suveri;
int topraknem = A0;
int toprakveri;
int fan = 9;
int led = 10;
int sumotoru = 13;
int fanhiz = 0;
int ledparlaklik = 0;
int yesilLed = 14;
int sariLed = 15;
int kirmiziLed = 16;
int a = 0;
bool iskullanici = true;

void setup() {
  pinMode(sumotoru, INPUT_PULLUP);
  Serial.begin(9600);
  dht.begin();
  lcd.begin(16, 2);
  pinMode(buttonfan, INPUT);
  pinMode(buttonled, INPUT);
  pinMode(buttonnem, INPUT);
  pinMode(switch1, INPUT_PULLUP);
  pinMode(switch2, INPUT_PULLUP);
  pinMode(ldr, INPUT);
  pinMode(suseviye, INPUT);
  pinMode(topraknem, INPUT);
  pinMode(fan, OUTPUT);
  pinMode(led, OUTPUT);
  pinMode(sumotoru, OUTPUT);
  pinMode(yesilLed, OUTPUT);
  pinMode(sariLed, OUTPUT);
  pinMode(kirmiziLed, OUTPUT);
}

void loop() {
  gasvalue = analogRead(MQ2pin);
  int temp = dht.readTemperature();
  int hum = dht.readHumidity();

  if (gasvalue > 300 && iskullanici) {
    lcd.setCursor(0, 1);
    lcd.print("air is bad");
    analogWrite(fan, 200);
  }

  buttonledDurum = digitalRead(buttonled);
  buttonfanDurum = digitalRead(buttonfan);
  buttonnemDurum = digitalRead(buttonnem);
  switch1Durum = digitalRead(switch1);
  switch2Durum = digitalRead(switch2);
  ldrDurum = analogRead(ldr);
  suveri = analogRead(suseviye);
  toprakveri = analogRead(topraknem);

  // Su Seviyesi ve LED Durumları
  if (suveri > 400) {
    digitalWrite(yesilLed, HIGH);
    digitalWrite(sariLed, LOW);
    digitalWrite(kirmiziLed, LOW);
  } else if (suveri > 200) {
    digitalWrite(yesilLed, LOW);
    digitalWrite(sariLed, HIGH);
    digitalWrite(kirmiziLed, LOW);
  } else {
    digitalWrite(yesilLed, LOW);
    digitalWrite(sariLed, LOW);
    digitalWrite(kirmiziLed, HIGH);
  }

  // Kullanıcı Modu
  if (switch1Durum == LOW && switch2Durum == LOW) {
    iskullanici = true;
    analogWrite(led, LOW);
    analogWrite(fan, 0);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("temp:");
    lcd.print(temp);
    lcd.print("c");
    lcd.setCursor(9, 0);
    lcd.print("Hum:%");
    lcd.print(hum);
    lcd.setCursor(0, 1);
    lcd.print("L:");
    lcd.print(ledparlaklik);
    lcd.setCursor(5, 1);
    lcd.print("F:");
    lcd.print(fanhiz);
    lcd.setCursor(10, 1);
    lcd.print("T:");
    lcd.print(esik1);

    // Verileri gönderme işlemi
    if (Serial.available() > 0) {
      String command = Serial.readStringUntil('\n');
      command.trim();  // Gereksiz boşlukları temizle

      if (command == "LED_ON") {
        analogWrite(led, 200);  // LED'i aç
        ledparlaklik = 100;
      }
      if (command == "LED_OFF") {
        analogWrite(led, 0);  // LED'i kapat
        ledparlaklik = 0;
      }
      if (command == "FAN_ON") {
        analogWrite(fan, 200);  // Fan'ı aç
        fanhiz = 100;
      }
      if (command == "FAN_OFF") {
        analogWrite(fan, 0);  // Fan'ı kapat
        fanhiz = 0;
      }
      if (command.startsWith("SET_THRESHOLD:")) {
        String value = command.substring(14); // Komuttan eşik değerini al
        int newThreshold = value.toInt();
        if (newThreshold > 0) {
          esik1 = newThreshold;
        } else {
          Serial.println("Invalid threshold value");
        }
      }
    }
  }

  // LED Parlaklık Kontrolü
  if (buttonledDurum == HIGH && iskullanici) {
    ledparlaklik = ledparlaklik + 10;
    if (ledparlaklik > 255) {
      ledparlaklik = 255;
    }
    analogWrite(led, ledparlaklik);
  }
  if (buttonledDurum == LOW && ledparlaklik > 0 && iskullanici) {
    ledparlaklik = ledparlaklik - 1;
    analogWrite(led, ledparlaklik);
  }

  // Fan Hızı Kontrolü
  if (buttonfanDurum == HIGH && iskullanici) {
    fanhiz = fanhiz + 10;
    if (fanhiz > 255) {
      fanhiz = 255;
    }
    analogWrite(fan, fanhiz);
  }
  if (buttonfanDurum == LOW && fanhiz > 0 && iskullanici) {
    fanhiz = fanhiz - 10;
    analogWrite(fan, fanhiz);
  }

  if (ldrDurum < 300 && iskullanici) {
    analogWrite(led, 50);
  }

  // Sulama Kontrolü
  if (buttonnemDurum == HIGH && iskullanici) {
    delay(10);
    esik1 = esik1 + 100;
  }
  if (esik1 == 1100) {
    esik1 = 600;
  }
  if (toprakveri <= esik1 && iskullanici) {
    digitalWrite(sumotoru, HIGH);
    delay(5000);
    digitalWrite(sumotoru, LOW);
    delay(5000);
  }
  if (toprakveri > esik1 && iskullanici) {
    digitalWrite(sumotoru, LOW);
  }

  // Yağmur Ormanı Durumu
  if (switch1Durum == HIGH && switch2Durum == LOW || switch1Durum == LOW && switch2Durum == HIGH) {
    iskullanici = false;
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Yagmur ormani");
    lcd.setCursor(0, 1);
    lcd.print("temp:");
    lcd.print(temp);
    lcd.print("C");
    lcd.setCursor(9, 1);
    lcd.print("Hum:%");
    lcd.print(hum);
    delay(100);
    analogWrite(fan, 200);
    analogWrite(led, 50);
    fanhiz = 80;
    ledparlaklik = 50;

    // Sulama Kontrolü
    if (toprakveri <= esik2) {
      digitalWrite(sumotoru, HIGH);
      delay(5000);
      digitalWrite(sumotoru, LOW);
      delay(500);
    }
    if (toprakveri > esik2) {
      digitalWrite(sumotoru, LOW);
    }
  }

  // Çöl Durumu
  if (switch1Durum == HIGH && switch2Durum == HIGH) {
    iskullanici = false;
    lcd.clear();
    lcd.setCursor(5, 0);
    lcd.print("Col");
    lcd.setCursor(0, 1);
    lcd.print("temp:");
    lcd.print(temp);
    lcd.print("C");
    lcd.setCursor(9, 1);
    lcd.print("Hum:%");
    lcd.print(hum);
    delay(100);
    analogWrite(fan, 0);
    analogWrite(led, 250);
    ledparlaklik = 100;

    // Sulama Kontrolü
    if (toprakveri <= esik3) {
      digitalWrite(sumotoru, HIGH);
      delay(5000);
      digitalWrite(sumotoru, LOW);
      delay(500);
    }
    if (toprakveri > esik3) {
      digitalWrite(sumotoru, LOW);
    }
  }

  Serial.print(temp);
  Serial.print(",");
  Serial.print(hum);
  Serial.print(",");
  Serial.print(toprakveri);
  Serial.print(",");
  Serial.print(suveri);
  Serial.print(",");
  Serial.print(gasvalue);
  Serial.print(",");
  Serial.print(fanhiz);
  Serial.print(",");
  Serial.println(ledparlaklik);
  delay(500);
}