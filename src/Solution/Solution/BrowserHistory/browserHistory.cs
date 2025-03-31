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
    public class HistoryManager
    {
        private Halaman? top;

        public HistoryManager()
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

        public string Kembali()
        {
            if (top == null || top.Prev == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            top = top.Prev;
            return top.URL;
        }

        public string? LihatHalamanSaatIni()
        {
            return top?.URL;
        }

        public string TampilkanHistory()
        {
            if (top == null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            Halaman? current = top;
            while (current != null)
            {
                sb.Insert(0, current.URL + Environment.NewLine);
                current = current.Prev;
            }

            return sb.ToString();
        }
    }
}