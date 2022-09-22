# Lern-Bericht
Giovanni
## Einleitung

Ich habe einen Numberguessing Game programmiert.
## Was habe ich gelernt?

Ich habe bei der Programmierung viele Switch-cases benutzt, deshalb geht es in diesem Lernbericht um Switch-case.
## Beschreibung

Mit Switch-cases kann man verschiedenen Audgangslagen für einen Wert einfach bestimmen.
Ein Switch-case hat mehrere Funktionen;
### Zum Beispiel:
* Kann man mehrere cases zusammenführen, welche das gleiche ergebniss ergeben.
* falls es keinem Case entspricht gibt es "default".
* nach jedem Case kommt ein "break;" dies weisst das Programm darauf hin, dass der Case fertig ist und das es nicht nach andere Cases untersuchen soll.


```csharp
//Hier wird eine zufällige Zahl zwischen 1 und 100 Generiert
Random zufälligGenerierteZahl = new Random();
int zufälligeZahl = zufälligGenerierteZahl.Next(1, 100);

//Mit einem Switch case kann man für den Wert der Zahl verschiedene Ausgangslagen bestimmen
switch (zufälligeZahl)
{
//Ein "case" ist ein Fall, dass ausgeführt wird falls der Wert die erwartungen erfüllt.
case int n when (n < 11):
//Falls die Zahl kleiner als 11 ist, landet man in diesem Case.
Console.WriteLine("Die Zahl befindet sich zwischen 1 und 10.");
break;

case int n when (n < 51):
//Falls die Zahl kleiner als 31 ist, landet man in diesem Case.
Console.WriteLine("Die Zahl befindet sich zwischen 11 und 50.");
break;

case 69:
//Falls die Zahl 69 ist, landet man in diesem Case.
Console.WriteLine("Die Zahl beträgt 69");
break;

case int n when (n < 100):
//Falls die Zahl kleiner als 31 ist, landet man in diesem Case.
Console.WriteLine("Die Zahl befindet sich zwischen 51 und 100.");
break;

//Falls die Zahl keinem case entspricht kann man default benutzen
default:
Console.WriteLine("Die Zahl befindet sich nicht zwischen 1 und 100");
break;

````
✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Ich konnte gut und fleissig schaffen, zuhause und in der Schule ging es Problemlos. Das Arbeiten zuhause ging teilweise besser als in der Schule, denn so konnte ich richtig ausschlafen und mit voller konzentration Programmieren. Bei Problemen konnte ich au recht schnell eine lösung finden, indem ich entweder im Internet recherchierte, bei Kollegen auskunft holte oder, indem ich meinen Bruder der bereits Applikationsentwickler ist fragte.

👎 Ich hatte am Anfang ein paar Schwierigkeiten mit dem Programmieren, weil ich mir zu viel auf einmal vorgenommen habe und nicht Etappe für Etappe geschafft habe. Dies führte dazu, dass ich in den ersten zwei wochen des Programmierens die Motivation verloren hatte, weil das Programm nicht funktionierte.

**VBV**: 
Beim nächsten Projekt werde ich versuchen mich so gut wie möglich an die Arbeitspakete zu halten und einen Schritt nach dem anderen vorzugehen, damit ich schon früher kleine Erfolgserlebnisse habe, damit ich die Motivation nicht verliere.

