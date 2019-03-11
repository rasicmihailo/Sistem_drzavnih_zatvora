using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProjekat.Entiteti
{
    public class Radnik
    {
        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int Tip { get; set; } //0 = strazar, 1 = admin
        public String Smena { get; set; }
        public String JMBG { get; set; }
        public String DatumRodjenja { get; set; }
        public String ZatvorID { get; set; }
        public String Korisnicko { get; set; }
        public String Sifra { get; set; }
        public List<String> Blokovi { get; set; }
        
    }
}
