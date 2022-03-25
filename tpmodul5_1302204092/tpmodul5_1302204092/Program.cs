using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVidio video = new SayaTubeVidio("Tutorial Design By Contract - Muhammad Hazim Abubakar");
            video.IncreasePlayCount(10);
            video.PrintVideoDetails();
            Console.WriteLine();
            video.IncreasePlayCount(8);
            video.PrintVideoDetails();
            Console.WriteLine();
            video.IncreasePlayCount(3);
            video.PrintVideoDetails();
        }
    }
}
