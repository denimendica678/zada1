using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Sport
    {

        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(string naziv)
        {

            Naziv = naziv;

        }

        public Sport(string naziv, bool igraLiSeLoptom)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
        }

        public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
            BrojIgraca = brojIgraca;
        }

        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public bool IgraLiSeLoptom1 { get => IgraLiSeLoptom; set => IgraLiSeLoptom = value; }
        public byte BrojIgraca1 { get => BrojIgraca; set => BrojIgraca = value; }
    }
}
