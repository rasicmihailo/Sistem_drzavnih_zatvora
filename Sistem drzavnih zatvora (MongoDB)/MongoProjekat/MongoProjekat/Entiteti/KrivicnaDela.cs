using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProjekat.Entiteti
{
    public class KrivicnaDela
    {
        public ObjectId Id { get; set; }
        public String NazivDela { get; set; }
        public String OpisDela { get; set; }
        public int BrojDana { get; set; }
        public String DatumOsudjivanja { get; set; }
        public String ZatvorenikID { get; set; }



    }
}
