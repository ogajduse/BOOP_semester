using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cv8 {
    class ArchivTeplot {
        SortedDictionary<int, RocniTeplota> _archiv = new SortedDictionary<int, RocniTeplota>();

        public void Load(string path) {
            _archiv.Clear();
            StreamReader reader = File.OpenText(path);
            string line = null;
            while ((line = reader.ReadLine()) != null) {
                var polozky = line.Split(':');
                if (polozky.Length == 2) {
                    RocniTeplota rocniTeplota = new RocniTeplota();
                    rocniTeplota.Rok = Convert.ToInt32(polozky[0]);
                    polozky[1] = polozky[1].Replace(',', '.');
                    var strTeploty = polozky[1].Split(';');
                    List<double> teploty = new List<double>();

                    foreach (string stringTeplota in strTeploty) {
                        teploty.Add(Convert.ToDouble(stringTeplota));
                    }
                    rocniTeplota.MesicniTeploty = teploty;
                    _archiv.Add(rocniTeplota.Rok, rocniTeplota);
                }
            }
            reader.Close();
        }

        public void Save(string path) {
            StreamWriter writer = File.CreateText(path);
            foreach (RocniTeplota rocniTeplota in _archiv.Values) {
                writer.Write(rocniTeplota.Rok);
                writer.Write(':');
                List<string> teplotyStr = new List<string>();
                foreach (double teplota in rocniTeplota.MesicniTeploty) {
                    teplotyStr.Add(teplota.ToString());
                }
                writer.WriteLine(string.Join(";", teplotyStr));
            }
        }

        public void Kalibrace(double offset) {
            foreach (RocniTeplota rocniTeplota in _archiv.Values) {
                for (int i = 0; i < 11; i++) {
                    rocniTeplota.MesicniTeploty[i] += offset;
                }
            }

        }

        public RocniTeplota Vyhledej(int rok) {
            return _archiv[rok];
        }
        
        public void TiskTeplot() {


        }

        public void TiskPrumernychRocnichTeplot(int rok) {


        }

        public void TiskPrumernychMesicnichTeplot(int rok, int mesic) {

        }
    }
}
