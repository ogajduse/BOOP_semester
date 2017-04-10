using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv8 {
    class Program {
        static void Main(string[] args) {
            ArchivTeplot archiv = new ArchivTeplot();
            archiv.Load("teploty.txt");
            archiv.TiskTeplot();
            archiv.TiskPrumernychMesicnichTeplot(2015,1);
            archiv.TiskPrumernychRocnichTeplot(2014);
            archiv.Kalibrace(-0.1);
            archiv.Save("archiv.txt");
            ArchivTeplot archiv2 = new ArchivTeplot();
            archiv2.Load("teploty.txt");


            Console.ReadLine();
        }
    }
}
