```markdown
# Konwerter Jednostek

Prosty program do konwersji różnych jednostek długości, wagi i odległości. Pozwala na łatwe przeliczanie między powszechnie używanymi jednostkami, takimi jak:

- Centymetry na stopy i cale oraz odwrotnie
- Metry na jardy oraz odwrotnie
- Kilometry na mile oraz odwrotnie
- Funty na kilogramy oraz odwrotnie

## Spis treści

- [Funkcje](#funkcje)
- [Instalacja](#instalacja)
- [Użycie](#użycie)
- [Przykłady konwersji](#przykłady-konwersji)
- [Obsługa błędów](#obsługa-błędów)

## Funkcje

Program oferuje następujące możliwości:

1. Konwersja jednostek długości:
   - Centymetry na stopy i cale
   - Stopy i cale na centymetry

2. Konwersja jednostek odległości:
   - Metry na jardy
   - Jardy na metry

3. Konwersja jednostek wagi:
   - Kilogramy na funty
   - Funty na kilogramy

4. Obsługa błędnych danych wejściowych oraz możliwość ponownego wyboru konwersji.

## Instalacja

### Dla systemów Windows i Linux

Aby uruchomić ten projekt lokalnie, wykonaj następujące kroki:

1. **Sklonuj repozytorium:**
   ```bash
   git clone https://github.com/therealcrispin/scaling-waffle.git
   cd scaling-waffle
   ```

2. **Zainstaluj .NET SDK** (jeśli jeszcze go nie masz). Instrukcje instalacji znajdziesz [tutaj](https://dotnet.microsoft.com/download).

3. **Zbuduj projekt:**
   ```bash
   dotnet build
   ```

4. **Uruchom program:**
   ```bash
   dotnet run
   ```

## Użycie

Po uruchomieniu programu użytkownik zobaczy menu wyboru. Wybierz konwersję, którą chcesz wykonać:

1. Wprowadź liczbę dla wybranej jednostki.
2. Program wyświetli wynik z przeliczeniem.
3. Masz możliwość wyboru innej konwersji lub wyjścia z programu.

### Menu główne:

```bash
Wybierz konwersję:
1: Centymetry na stopy i cale
2: Stopy i cale na centymetry
3: Metry na jardy
4: Jardy na metry
5: Kilogramy na funty
6: Funty na kilogramy
7: Zamknij program
```

## Przykłady konwersji

### Przykład 1: Konwersja centymetrów na stopy i cale

```bash
Podaj wartość w centymetrach: 180
Wynik: 180 cm to 5'11''
```

### Przykład 2: Konwersja mil na kilometry

```bash
Podaj wartość w milach: 5
Wynik: 5 mil to 8.05 km
```

## Obsługa błędów

Program jest wyposażony w obsługę błędnych danych wejściowych, co oznacza, że jeśli użytkownik wprowadzi niepoprawne dane (np. litery zamiast liczb), program wyświetli komunikat o błędzie i umożliwi ponowny wybór.

## Kontakt

Projekt został stworzony przez [Kryspin Kuc](https://github.com/therealcrispin). W razie pytań, sugestii lub problemów, proszę o kontakt.
```
