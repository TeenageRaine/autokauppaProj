using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        private int id;
        private decimal hinta;
        private DateTime rekisteri_paivamaara;
        private decimal moottorin_tilavuus;
        private int mittarilukeema;
        private int autonMerkkiID;
        private int autonMalliID;
        private int varitID;
        private int polttoaineID;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal Hinta
        {
            get { return hinta; }
            set { hinta = value; }
        }

        public DateTime RekisteriPaivamaara
        {
            get { return rekisteri_paivamaara; }
            set { rekisteri_paivamaara = value; }
        }

        public decimal MoottorinTilavuus
        {
            get { return moottorin_tilavuus; }
            set { moottorin_tilavuus = value; }

        }

        public int Mittarilukeema
        {
            get { return mittarilukeema; }
            set { mittarilukeema = value; }
        }

        public int AutonMerkkiID
        {
            get { return autonMerkkiID; }
            set { autonMerkkiID = value; }
        }

        public int AutonMalliID
        {
            get { return autonMalliID; }
            set { autonMalliID = value; }
        }

        public int VaritID
        {
            get { return varitID; }
            set { varitID = value; }
        }

        public int PolttoAineID
        {
            get { return polttoaineID; }
            set { polttoaineID = value; }
        }
    }
}
