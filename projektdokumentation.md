# Projekt-Dokumentation

Giovanni Innamorato


| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Numberguessing Game

Ich ertselle ein Programm, dieses ersellt eine Geheimzahl zwischen 1-100. Der User muss die Zahl zwischen 1-100 erraten. Das Programm hilft dem User indem es sagt "Die Geheimzahl ist tiefer/höher als die erratene Zahl".

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                      |
| ---- | ----------------| ---------- | ------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional | Es muss eine Zahl Generieren können                                                               |
| 2    | Muss            | Funktional | Es muss ein Eingabefeld für die Zahl des Users                                                    |
| 3    | Muss            | Funktional | Es muss entscheiden können ob die Zahl höher/tiefer als die Zufallszahl ist                       |
| 4    | Muss            | Funktional | Es muss erkennen können ob die geratene Zahl gültig oder ungültig(Wörter,Buchstaben) ist          |
| 5    | Muss            | Funktional | Es muss erkennen können ob die geratene Zahl richtig oder Falsch ist                              |
| 6    | Kann            | Qualität   | Wenn man Im Eingabefeld etwas anderes als eine Zahl zwischen 1-100 eingibt, dann wird das Feld rot|
| 7    | Kann            | Qualität   | Wenn man Im Eingabefeld eine Zahl zwischen 1-100 eingibt, dann wird das Feld grün                 |



✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage                           | Eingabe      | Erwartete Ausgabe                               |
| ---- | -------------------------------------- | ------------ | ----------------------------------------------- |
| 1.1  | Programm wurde gestartet               |              | Eine zufällige Zahl wurde generiert             |
| 2.2  | Ein Eingabefeld ist vorhanden          | Eine Zahl    | Die Zahl soll vom Programm verwendet werden     |
| 3.3  | Eine Zahl wurde eingegeben             | 46           | Die Zufallszahl liegt unter 46                  |
| 4.4  | Programm wurde gestartet               | Sucuk mit Ei | Bitte geben sie eine Zahl zwischen 1-100 ein    |
| 5.5  | Programm wurde gestartet               | 40           | Super! Sie haben die die richtige Zahl erraten  |
| 6.6  | Programm wurde gestartet               | Ketchup      | Das Eingabefeld wird rot                        |
| 7.7  | Programm wurde gestartet               | 69           | Das Eingabefeld wird grün                       |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/111045802/186607289-4db19a2c-5eea-485e-9d7e-f3f3cacd9c42.png)

![grafik](https://user-images.githubusercontent.com/111045802/186615697-abf5f68c-680e-4a07-9f2c-cfc6b7b02b81.png)      
## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung                                                                                     | geplante Zeit |
| ---- | ----- | --------- | ------------------------------------------------------------------------------------------------ | ------------- |
| 1.A  |       | Giovanni  | Herausfinden wie man Zahlen generiert                                                            | 45'           |
| 1.B  |       | Giovanni  | Programmieren, Zahlengenerator                                                                   | 45'           |
| 2.C  |       | Giovanni  | Eingabefeld ertsellen                                                                            | 30'           |
| 3.D  | ----- | Giovanni  | Das Programm entscheiden lassen ob die eingegebene Zahl höher oder tiefer als die Geheimzahl ist | 45'           |
| 3.E  | ----- | Giovanni  | Falls Zahl höher oder tiefer ist eine Meldung geben                                              | 45'           |
| 4.F  | ----- | Giovanni  | Das Programm muss erkennen ob es eine Zahl oder buchstaben sind                                  | 30'           |
| 4.G  | ----- | Giovani   | Falls nicht eine Zahl zwischen 1-100 eingegeben wurden, eine Meldung geben                       | 45'           |
| 5.H  | ----- | Giovanni  | Programm muss erkennen können ob es die richtige Zahl oder die falsche ist                       | 20'           |
| 5.I  | ----- | Giovanni  | Falls die Zahl nicht erraten wurde, soll der User nochmals versuchen                             | 45'           |
| 5.J  | ----- | Giovanni  | Falls die Richtige Zahl gefunden wurde, soll eine Meldung gegeben werden                         | 30'           |
| 6.K  | ----- | Giovanni  | Herausfinden wie man eingabefelder farbig machen kann                                            | 45'           |
| 6.L  | ----- | Giovanni  | Das Eingabefeld bei einer falschen Eingabe rot werden lassen                                     | 45'           |
| 7.M  | ----- | Giovanni  | Das Eingabefeld bei einer richtigen Eingabe Grün werden lassen                                   | 30'           |


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden
✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

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
