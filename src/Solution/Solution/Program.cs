using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        Browser history = new Browser();
        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");

        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        history.Kembali();
        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        history.TampilkanHistory();
        Console.WriteLine();

        // Bracket validator
        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {BracketValidator.ValidasiEkspresi(ekspresiInvalid)}");
        Console.WriteLine();

        //Palindrome Checker
        string[] testcases = { "Kasur ini rusak", "Ibu ratna antar ubi", "Hello World" };

        foreach ( string testcase in testcases)
        {
            Console.WriteLine($"Input: \"{testcase}\" -> Palindrome ? {PalindromeChecker.CekPalindrom(testcase)}");
        }
    }
}
