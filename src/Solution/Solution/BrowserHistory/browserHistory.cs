using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; }
        public Halaman? Prev { get; set; }

        public Halaman(string url)
        {
            URL = url;
            Prev = null;
        }
    }
    public class Browser
    {
        private Halaman? top;
        public Browser()
        {
            top = null;
        }
        public void KunjungiHalaman(string url)
        {
            Halaman newPage = new Halaman(url);
            newPage.Prev = top;
            top = newPage;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }
        public string? Kembali()
        {
            if (top == null || top.Prev == null)
            {
                Console.WriteLine("Tidak ada halaman sebelumnya.");
                return null;
            }
            top = top.Prev;
            Console.WriteLine("Kembali ke halaman sebelumnya...");
            return top.URL;
        }
        public string? LihatHalamanSaatIni()
        {
            return top?.URL;
        }
        public void TampilkanHistory()
        {
            Console.WriteLine("Menampilkan history:");
            Halaman? current = top;
            int index = 1;
            while (current != null)
            {
                Console.WriteLine($"{index}. {current.URL}");
                current = current.Prev;
                index++;
            }
        }
    }
}