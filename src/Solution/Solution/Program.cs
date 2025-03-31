using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();
        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        history.Kembali();
        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        history.TampilkanHistory();
        Console.WriteLine();

        // Bracket validator
        var validator = new BracketValidator();

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        bool isValidValid = validator.ValidasiEkspresi(ekspresiValid);
        bool isValidInvalid = validator.ValidasiEkspresi(ekspresiInvalid);

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {isValidValid}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {isValidInvalid}");
        Console.WriteLine();

        //Palindrome Checker
        string kata1 = "Kasur ini rusak";
        string kata2 = "Ibu Ratna antar ubi";
        string kata3 = "Hello World";

        bool hasil1 = PalindromeChecker.CekPalindrom(kata1);
        bool hasil2 = PalindromeChecker.CekPalindrom(kata2);
        bool hasil3 = PalindromeChecker.CekPalindrom(kata3);

        Console.WriteLine($"{kata1} : {hasil1}");
        Console.WriteLine($"{kata2} : {hasil2}");
        Console.WriteLine($"{kata3} : {hasil3}");
    }
}
