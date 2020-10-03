using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRF
{
    public class Medlemmar
    {
        private int id;
        private string namn;
        private string efternamn;
        private string adress;
        private string epost;
        private int telnr;
        private int mobilnr;
        private string tigernamn;
        private int tigeralder;
        private string lOrd;
        private string typ;

        public int Id
        {
            get { return id;}
            set { id = value;}
        }

        public string Namn
        {
            get{return namn;}
            set{namn = value;}
        }

        public string Efternamn
        {
            get{return efternamn;}
            set {efternamn = value;}
        }

        public string Adress
        {
            get{return adress;}
            set {adress = value;}
        }

        public string Epost
        {
            get{return epost;}
            set{epost = value;}
        }

        public int Telnr
        {
            get{return telnr;}
            set{telnr = value;}
        }

        public int Mobilnr
        {
            get{return mobilnr;}
            set{mobilnr = value;}
        }
        public string Tigernamn
        {
            get{return tigernamn;}
            set{tigernamn = value;}
        }
        public int Tigeralder
        {
            get{return tigeralder;}
            set{tigeralder = value;}
        }

        public string Typ
        {
            get{return typ;}
            set{ typ = value; }
        }

        public string LOrd
        {
            get{return lOrd; }
            set{lOrd = value;}
        }
    }
    }

