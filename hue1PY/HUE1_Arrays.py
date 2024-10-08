import math

class Arrays: # Klassenstruktur und Main für Vergleichbarkeit mit C# Code
    def main(self):
        zahlen = [0] * 3                     # Array(Liste) mit 3 Elementen
        zahlen[0] = math.pi  # PI 
        zahlen[1] = 2.718281828  # e
        zahlen[2] = 42  

        summe = zahlen[0] + zahlen[1] + zahlen[2]
        print("Summe Zahlen: " + str(summe))
        print(f"Summe Zahlen: {summe}")

        ganzeZahlen = [5, 7, 12]
        summe2 = ganzeZahlen[0] + ganzeZahlen[1] + ganzeZahlen[2]
        print(f"Summe ganze Zahlen: {summe2}")

        beispiel = "Hallo GDI"
        print(f"1. Buchstabe = {beispiel[0]}")
        print(f"Letzter Buchstabe = {beispiel[-1]}")

if __name__ == "__main__": # Main als Einstiegspunkt, sonst Zeile für Zeile ausführen
   Arrays().main()

