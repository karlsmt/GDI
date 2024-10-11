import logging

# Variablendeklaration und Initialisierung
integer_variable = 10
float_variable = 7.18
double_variable = 3.14
string_variable = "Hallo"
boolean_variable = True

type1= type(integer_variable) 
# Ausgabe von Variablen
print(f"Integer: {integer_variable}")
print(f"Float: {float_variable}")
print(f"Double: {double_variable}")
print(f"String: {string_variable}")
print(f"Boolean: {boolean_variable}\n\n")

# Logische Operatoren
stimmtDas = 5 > 4.5
print(f"Die Aussage 5 > 4.5 ist {stimmtDas}")

stimmtDas = (5 > 4.5) and (116.4 < int(116.999))
print(f"Die Aussage (5 > 4.5) && (116.4 < (int)116.999) ist {stimmtDas}\n\n")

# Typenkonvertierung in Python
# Dynamisch typisiert!
# In Python erfolgt die Typenkonvertierung in vielen Fällen automatisch (implizit),
# aber manchmal wird eine explizite Umwandlung durch einfache Funktionen wie int(), float() usw. durchgeführt.
# Anders als in C# sind keine komplexen Hilfsmethoden nötig.

# Implizite Umwandlung (automatisch)
"""Python ist dynamisch typisiert. Das bedeutet, dass Variablen ihren Typ ändern können,
und Python kümmert sich automatisch um die Typumwandlung, wenn nötig."""
float_variable = 7.18  
integer_variable = 10  

# Hier wird der Wert von `float_variable` ohne weitere Aktion verwendet,
# da Python dynamisch typisiert ist.
new_float_variable = float_variable
print(f"Implizite Umwandlung von Float {float_variable} zu Double: {new_float_variable}")
# In Python gibt es keinen Unterschied zwischen Float und Double. Beide werden als float behandelt.

# Wenn wir explizit von int zu float konvertieren wollen (obwohl Python dies oft automatisch macht):
new_integer_variable = float(integer_variable)
print(f"Explizite Umwandlung von Integer {integer_variable} zu Float: {new_integer_variable}")

# Explizite Umwandlung (Casting)
# Wenn wir eine explizite Umwandlung vornehmen wollen, zum Beispiel von einem float zu einem int,
# können wir die eingebaute Funktion int() verwenden.
double_variable = 3.14  # float
d_neu = int(double_variable)  # explizite Umwandlung von float zu int
print(f"Explizite Umwandlung (Casting) von Float {double_variable} zu Integer: {d_neu}")

# Konvertierung mit "Hilfsmethoden"
# Anders als in C#, wo Methoden wie Convert.ToInt32() verwendet werden, benutzt Python einfache Funktionen.
eingabe = input("Bitte eine Gleitkommazahl eingeben: ")
logging.debug(f"1. Eingabe: {eingabe}")

# Hier wird die Eingabe von einem String in einen Float konvertiert
double_zahl = float(eingabe)
# Anschließend wird der Float in einen Integer konvertiert
int_zahl = int(double_zahl)

logging.debug(int_zahl)
print(f"Double: {double_zahl}")
print(f"Integer: {int_zahl}")

# Explizites Casting kann hier erneut gezeigt werden:
int_zahl = int(double_zahl)
logging.debug(int_zahl)
print(f"Double: {double_zahl}")
print(f"Integer: {int_zahl}")

# Konvertierung von Int zu Float
# Wenn wir eine ganze Zahl eingeben, können wir diese einfach in einen float umwandeln,
# ohne eine Hilfsmethode wie in C# zu benötigen.
eingabe = input("Bitte eine ganze Zahl eingeben: ")
logging.debug(f"2. Eingabe: {eingabe}")
int_zahl = int(eingabe)  # Umwandlung von Eingabe (String) zu int
double_zahl = float(int_zahl)  # Umwandlung von int zu float
logging.debug(double_zahl)

# Implizite Umwandlung
# Da Python dynamisch typisiert ist, kann eine Variable einfach den Typ ändern,
# ohne explizit eine Umwandlung durchzuführen.
double_zahl = int_zahl  # int wird automatisch in float verwendet, wenn nötig
print(f"Double: {double_zahl}")
