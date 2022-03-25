using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Debug.Assert(title != null && title.Length <= 100, "title tidak boleh null dan maksimal 100 karakter");
            this.title = title;
        }

        public void IncreasePlayCount(int jumlah)
        {
            //prefetch pengkondisian
            Debug.Assert(jumlah <= 10000000, "Maksimal memasukkan 10.000.000 pemanggilan");
            
            //exception
            try
            {
                this.playCount = checked(this.playCount + jumlah);
                Console.WriteLine("Berhasil menambahkan jumlah angka baru");
            }
            catch (OverflowException e)
            {
                //Message untuk menampilkan masalah yang terjadi
                Console.WriteLine("Terjadi masalah saat melakukan penambahan jumlah angka: " + e.Message);
                //menerima jumlah angka
                this.playCount += jumlah;
            }
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
