Baza dinozaurów / wymarłych zwierząt
 Aplikacja okienkowa napisana w C# z wykorzystaniem Windows Forms, której celem jest zarządzanie bazą wymarłych zwierząt 
 oraz demonstracja przepływu danych pomiędzy oknami aplikacji.
Opis projektu
Projekt został przygotowany jako aplikacja wielookienkowa. Program umożliwia:
- wyświetlanie listy wymarłych zwierząt w oknie głównym,
- dodawanie nowych wpisów do bazy,
- filtrowanie wpisów według epoki,
- wyświetlanie szczegółów wybranego zwierzęcia.

Założenie, że dane przepływają pomiędzy oknami w zależności od działań użytkownika.

- okno główne z tabelą wszystkich zwierząt,
- okno dodawania nowego wpisu,
- okno filtrowania i podglądu szczegółów,
- filtrowanie zwierząt według wybranej epoki.

Struktura aplikacji

### `Program.cs`

Punkt startowy aplikacji. Odpowiada za uruchomienie programu od formularza głównego `MainForm`.

### `ExtinctAnimal.cs`

Klasa modelu danych opisująca pojedyncze wymarłe zwierzę.  
Zawiera podstawowe właściwości:
- Nazwa
- Epoka
- Miejsce_wystepowania

MainForm - Główne okno aplikacji.  
Odpowiada za:
- przechowywanie listy obiektów ExtinctAnimal,
- wyświetlanie danych w kontrolce DataGridView,
- otwieranie formularzy podrzędnych,
- odświeżanie widoku po zmianie danych.

Form1
Formularz dodawania nowego zwierzęcia.  
Użytkownik wprowadza:
- nazwę,
- epokę,
- miejsce występowania.

FormFilter
Formularz filtrowania i przeglądania szczegółów.  
Umożliwia:
- filtrowanie listy według epoki,
- wyświetlanie wyników w ListBox,
Komunikacja między oknami

Projekt wykorzystuje dwa różne sposoby przekazywania danych pomiędzy formularzami:

1. Przekazywanie przez konstruktor 
   Lista zwierząt jest przekazywana z MainForm do Form1 przez konstruktor formularza.
2. Przekazywanie przez właściwość publiczną
   Lista zwierząt jest przekazywana z MainForm do FormFilter przez właściwość Animals.
Zastosowane kontrolki
MainForm
- DataGridView
- Button
Form1
- TextBox
- ComboBox
- Button
FormFilter
- RadioButton
- ListBox
- Label
- Button
Po uruchomieniu aplikacji otwierane jest okno główne MainForm, które zawiera przykładowe wpisy.  
Użytkownik może:
- otworzyć formularz dodawania i dodać nowe zwierzę do bazy,
- otworzyć formularz filtrowania i zawęzić listę wyników według epoki,



