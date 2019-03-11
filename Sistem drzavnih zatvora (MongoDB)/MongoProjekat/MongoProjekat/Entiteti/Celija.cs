using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProjekat.Entiteti
{
    public class Celija
    {
        public ObjectId Id { get; set; }
        public String Blok { get; set; }
        public int Broj { get; set; }
        public int Kapacitet { get; set; }
        public int Popunjenost { get; set; }
        public String ZatvorID { get; set; }




    }
}
