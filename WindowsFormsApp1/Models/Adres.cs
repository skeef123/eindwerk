using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public int StraatID { get; set; }

        public int huisnummer { get; set; }
        public int appartementnummer { get; set; }
        public int busnummer { get; set; }
        public string huisnummerlabel { get; set; }
        public int adreslocatieID { get; set; }
        public int postcode { get; set; }

        //public Adres(int id, int straatID, int huisnummer, int appartementnummer, int busnummer, string huisnummerlabel, int adreslocatieID, int postcode)
        //{
        //    this.Id = id;
        //    this.straatID = straatID;
        //    this.huisnummer = huisnummer;
        //    this.appartementnummer = appartementnummer;
        //    this.busnummer = busnummer;
        //    this.huisnummerlabel = huisnummerlabel;
        //    this.adreslocatieID = adreslocatieID;
        //    this.postcode = postcode;
        //}

    }
}
