//zdefiniuj string do zaszyfrowania
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia";
//zmieniamy na wielkie litery
clearText= clearText.ToUpper();
//literuj przez cały tekst litera po literze
//deklarujemy string wynikowy
string encryptedText = "";
foreach (char c in clearText)
{
    //wyciągamy kod ascii danej litery
    //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
    int asciiCode = (int)c;
    //dodajemy wartość klucza
    asciiCode += 3;
    //zmieniamy kod z powrotem na znak
    char encryptedChar = (char)asciiCode;
    //dopisujemy do szyfru
    encryptedText+= encryptedChar;
}

Console.WriteLine("Zaszyfrowany tekst: " + encryptedText);
