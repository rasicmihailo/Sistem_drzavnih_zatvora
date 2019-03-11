using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProjekat.Entiteti
{
    public class Zatvorenik
    {
        public ObjectId Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String JMBG { get; set; }
        public String DatumRodjenja { get; set; }
        public String DatumUlaska { get; set; }
        public String DatumIzlaska { get; set; }
        public String CelijaID { get; set; }
        public String ZatvorID { get; set; }
        internal List<KrivicnaDela> Dela { get; set; }
        

    }
}
