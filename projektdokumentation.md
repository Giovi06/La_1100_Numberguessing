# Projekt-Dokumentation

Giovanni Innamorato


| Datum | Version | Zusammenfassung                                                                                               |
| ----- | ------- | ------------------------------------------------------------------------------------------------------------- |
| 01.09 | 1.0.1   | Es kann eine zufällige Zahl generieren und es erkennt Zahlen grösser als 100 oder kleiner als 1 als ungültig  |
| 08.09 | 1.0.2   | Es erkennt ob die geraten Zahl grösser/kleiner als die zufällige Zahl ist|
| 15.09 | 1.0.3   | Es gibt verschiede Antworten auf verschiedene Anzahlversuche                                                  |

## 1 Informieren

### 1.1 Numberguessing Game

Ich ertselle ein Programm, dieses ersellt eine Geheimzahl zwischen 1-100. Der User muss die Zahl zwischen 1-100 erraten. Das Programm hilft dem User indem es sagt "Die Geheimzahl ist tiefer/höher als die erratene Zahl".

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                                     |
| ---- | ----------------| ---------- | ---------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional | Als Spieler möchte ich, dass das Programm eine zufällige Zahl generiert                                          |
| 2    | Muss            | Funktional | Als Spieler möchte ich eine Zahl eingeben können, damit ich spielen kann                                         |
| 3    | Muss            | Funktional | Als Spieler möchte ich wissen ob miene Zahl tiefer/höher las die Zufallszahl ist                                 |
| 4    | Muss            | Funktional | Als Spieler möchte ich das es erkennt ob ich eine Gültige oder Ungültige Zahl eingebe, damit ich spielen  kann   |
| 5    | Muss            | Funktional | Als Spieler möchte ich das es erkennt ob meine Zahl richtig oder falsch ist, damit ich weiss ob ich gewonnen habe|
| 6    | Kann            | Qualität   | Als Spieler möchte ich, dass mich das Programm fragt ob ich bereit bin                                           |
| 7    | Kann            | Qualität   | Als spieler möchte ich, dass nachdem ich gewonnen habe, mir gesagt wird wie viele Versuche ich gebraucht habe    |
| 8    | Kann            | Qualität   | Als spieler möchte ich, dass ich so oft spielen kann wie ich will.                                               |
| 9    | Kann            | Qualität   | Als spieler möchte ich, wenn ich weiter spielen möchte oder nicht eine Reaktion erfolgt.                         |
| 10   | Kann            | Qualität   | Als spieler möchte ich, dass bei verschiedenen Anzahl Versuchen, eine andere Antwort bekomme                     |
| 11   | Kann            | Qualität   | Als spieler möchte ich, dass wenn ich weniger als 6 versuche brauchte, mir ein Spielmodus von 1-1000 freigeschltet wird|                     



### 1.3 Testfälle

| TC-№ | Ausgangslage                           | Eingabe      | Erwartete Ausgabe                               |
| ---- | -------------------------------------- | ------------ | ----------------------------------------------- |
| 1.1  | Programm wurde gestartet               |              | Eine zufällige Zahl wurde generiert             |
| 2.2  | Ein Eingabefeld ist vorhanden          | Eine Zahl    | Die Zahl soll vom Programm verwendet werden     |
| 3.3  | Eine Zahl wurde eingegeben             | 46           | Die Zufallszahl liegt unter 46                  |
| 4.4  | Programm wurde gestartet               | Sucuk mit Ei | Fehlermeldung                                   |
| 5.5  | User hat die richtige Zahl eingegeben  | 40           | Super! Sie haben die die richtige Zahl erraten  |
| 6.6  | Programm fragt True/false              | true         | Zahl wird erwartet                              |
| 6.7  | Programm fragt True/false              | false        | Programm wird unterbrochen                      |


### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/111045802/186607289-4db19a2c-5eea-485e-9d7e-f3f3cacd9c42.png)

![grafik](https://user-images.githubusercontent.com/111045802/186615697-abf5f68c-680e-4a07-9f2c-cfc6b7b02b81.png)      
## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung                                                                                     | geplante Zeit |
| ---- | ----- | --------- | ------------------------------------------------------------------------------------------------ | ------------- |
| 1.A  |       | Giovanni  | Herausfinden wie man Zahlen generiert                                                            | 45'           |
| 1.B  |       | Giovanni  | Programmieren, Zahlengenerator                                                                   | 45'           |
| 2.C  |       | Giovanni  | Eingabefeld ertsellen                                                                            | 20'           |
| 3.D  | ----- | Giovanni  | Das Programm entscheiden lassen ob die eingegebene Zahl höher oder tiefer als die Geheimzahl ist | 45'           |
| 3.E  | ----- | Giovanni  | Falls Zahl höher oder tiefer ist eine Meldung geben                                              | 45'           |
| 4.F  | ----- | Giovanni  | Das Programm muss erkennen ob es eine Zahl oder buchstaben sind                                  | 30'           |
| 4.G  | ----- | Giovani   | Falls nicht eine Zahl zwischen 1-100 eingegeben wurden, eine Meldung geben                       | 45'           |
| 5.H  | ----- | Giovanni  | Programm muss erkennen können ob es die richtige Zahl oder die falsche ist                       | 20'           |
| 5.I  | ----- | Giovanni  | Falls die Zahl nicht erraten wurde, soll der User nochmals versuchen                             | 45'           |
| 5.J  | ----- | Giovanni  | Falls die Richtige Zahl gefunden wurde, soll eine Meldung gegeben werden                         | 30'           |
| 6.K  | ----- | Giovanni  | Falls Spieler True eingibt soll programm fortlaufen                                              | 30'           |
| 6.L  | ----- | Giovanni  | Falls Spieler True eingibt soll programm anhalten                                                | 30'           |
| 7.M  | ----- | Giovanni  | Versuche Zähler einbauen                                                                         | 15'           |
| 8.N  | ----- | Giovanni  | Schleife erstellen um Programm nach wunshc des Users zu wiederholen                              | 45'           |
| 9.O  | ----- | Giovanni  | Falls Spieler weiter will oder nicht, eine kurze Reaktion darauf folgen lassen                   | 10'           |
| 10.P | ----- | Giovanni  | Mit Switch case, verschiedene Antwort auf verschiedene Anzahlversuchen zu geben                  | 30'           |
| 11.Q | ----- | Giovanni  | Neues Spielmodus von 1-1000 erstellen, dass nur bei <6 versuche freigeschltet wird               | 45'           |



Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden
✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum    | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | -------- | --------- | ------------- | ----------------- |
| 1.A  | 01.09.22 | Giovanni  |45'            | 15'               |
| 1.B  | 01.09.22 | Giovanni  |45'            | 15'               |
| 2.C  | 01.09.22 | Giovanni  |20'            | 15'               |
| 4.G  | 01.09.22 | Giovanni  |45'            | 45'               |
| 5.H  | 01.09.22 | Giovanni  |45'            | 45'               |
| 5.I  | 01.09.22 | Giovanni  |45'            | 40'               |
| 5.J  | 01.09.22 | Giovanni  |45'            | 30'               |
| 3.D  | 08.09.22 | Giovanni  |45'            | 45'               |
| 3.E  | 08.09.22 | Giovanni  |45'            | 30'               |
| 4.F  | 08.09.22 | Giovanni  |20'            | 30'               |
| 6.K  | 08.09.22 | Giovanni  |30'            | 30'               |
| 6.L  | 08.09.22 | Giovanni  |30'            | 30'               |
| 7.M  | 15.09.22 | Giovanni  |15'            | 10'               |
| 8.N  | 15.09.22 | Giovanni  |45'            | 45'               |
| 9.O  | 15.09.22 | Giovanni  |10'            | 10'               |
| 10.P | 15.09.22 | Giovanni  |30'            | 30'               |
| 11.Q | 15.09.22 | Giovanni  |45'            | 50'               |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
