using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204092
{
    internal class SayaTubeVidio
    {
        private int id;
        private string title;
        private int playCount = 0;
        
        public SayaTubeVidio(string title)
        {
            //generate kode random 5 digit
            Random random = new Random();
            this.id = random.Next(0, 10000);
            
            this.title = title;
        }

        public void IncreasePlayCount(int jumlah)
        {
            //menerima jumlah angka
            this.playCount += jumlah;
        }

        public void PrintVideoDetails()
        {
            //menampilkan output
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Judul: " + title);
            Console.WriteLine("Jumlah: " + playCount);
        } 
    }
}
