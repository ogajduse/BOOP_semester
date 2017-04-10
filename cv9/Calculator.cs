using System;

namespace cv9 {
    internal class Calculator {
        private enum Stav {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };
        private Stav _stav;

        private string _prvnicislo;
        private string _druhecislo;
        private string _pametcislo;
        private char _operace;
        private bool _pamet;

        public Calculator() {
            _stav = Stav.PrvniCislo;
            _prvnicislo = "";
            _druhecislo = "";
        }

        public void Tlacitko(string tlacitko) {
            char buttonChar = tlacitko[0];
            if (char.IsDigit(buttonChar) || buttonChar == ',') {
                switch (_stav) {
                    case Stav.PrvniCislo:
                        _prvnicislo += buttonChar;
                        break;
                    case Stav.Operace:
                        _stav = Stav.DruheCislo;
                        _druhecislo = buttonChar.ToString();
                        break;
                    case Stav.DruheCislo:
                        _druhecislo += buttonChar;
                        break;
                    case Stav.Vysledek:
                        _stav = Stav.PrvniCislo;
                        _prvnicislo += buttonChar;
                        break;
                }
            }
            else if (buttonChar == '+' || buttonChar == '-' || buttonChar == '*' || buttonChar == '/') {
                _operace = buttonChar;
                _stav = Stav.Operace;
            }
            else if (buttonChar == '=') {
                _stav = Stav.Vysledek;
            }
            else if (buttonChar == 'C') {
                _stav = Stav.PrvniCislo;
                _prvnicislo = "";
                _druhecislo = "";
            }
            else if (buttonChar == '±') {
                switch (_stav) {
                    case Stav.PrvniCislo:
                        _prvnicislo = ChangeOperand(PrvniCislo.ToString());
                        break;
                    case Stav.Operace:
                        _druhecislo = ChangeOperand(DruheCislo.ToString());
                        break;
                    case Stav.DruheCislo:
                        _druhecislo = ChangeOperand(DruheCislo.ToString());
                        break;
                    case Stav.Vysledek:
                        break;
                }
            }
            else if (tlacitko == "CE") {
                switch (_stav) {
                    case Stav.PrvniCislo:
                        _prvnicislo = "";
                        break;
                    case Stav.Operace:
                        _druhecislo = "";
                        break;
                    case Stav.DruheCislo:
                        _druhecislo = "";
                        break;
                    case Stav.Vysledek:
                        _stav = Stav.PrvniCislo;
                        _prvnicislo = "";
                        _druhecislo = "";
                        break;
                }
            }
            else if (tlacitko == "MS") {
            }
            else if (tlacitko == "MR") {
            }
            else if (tlacitko == "MC") {

            }
            else if (tlacitko == "M+") {
                _stav = Stav.PrvniCislo;
                _prvnicislo = "";
                _druhecislo = "";
            }
            else if (tlacitko == "M-") {
                _stav = Stav.PrvniCislo;
                _prvnicislo = "";
                _druhecislo = "";
            }
            else if (tlacitko == "⟵") {
                switch (_stav) {
                    case Stav.PrvniCislo:
                        _prvnicislo = Backspace(PrvniCislo.ToString());
                        break;
                    case Stav.Operace:
                        break;
                    case Stav.DruheCislo:
                        _druhecislo = Backspace(DruheCislo.ToString());
                        break;
                    case Stav.Vysledek:
                        break;
                }
            }
        }

        private string ChangeOperand(string cislo) {
            if (cislo[0] == '-') {
                return cislo.Substring(1);
            }
            else {
                return "-" + cislo;
            }
        }

        private string Backspace(string cislo) {
            return cislo = cislo.Remove(cislo.Length - 1);
        }

        public string Display {
            get {
                switch (_stav) {
                    case Stav.PrvniCislo:
                    case Stav.Operace:
                        return PrvniCislo.ToString();
                    case Stav.DruheCislo:
                        return DruheCislo.ToString();
                    case Stav.Vysledek:
                        return SpocitejVysledek().ToString();
                    default:
                        return "";
                }
            }
            set {

            }
        }

        public string Pamet {
            get {
                return _pamet ? "M" : "";
            }
            set {
                _pametcislo = value;
                _pamet = true;
            }
        }
        public decimal PrvniCislo {
            get {
                return _prvnicislo.Length == 0 ? 0m : Convert.ToDecimal(_prvnicislo);
            }
            set {

            }
        }
        public decimal DruheCislo {
            get {
                return _druhecislo.Length == 0 ? 0m : Convert.ToDecimal(_druhecislo);
            }
            set {

            }
        }
        public decimal PametCislo {
            get {
                return _pametcislo.Length == 0 ? 0m : Convert.ToDecimal(_pametcislo);
            }
            set {

            }
        }
        private decimal SpocitejVysledek() {
            switch (_operace) {
                case '+': return PrvniCislo + DruheCislo;
                case '-': return PrvniCislo - DruheCislo;
                case '*': return PrvniCislo * DruheCislo;
                case '/': return PrvniCislo / DruheCislo;
            }

            return 0m;
        }
    }
}