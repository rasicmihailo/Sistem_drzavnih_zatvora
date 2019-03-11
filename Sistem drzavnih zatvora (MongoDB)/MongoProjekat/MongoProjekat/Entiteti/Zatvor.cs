using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProjekat.Entiteti
{
    public class Zatvor
    {
        public ObjectId Id { get; set; }
        public String Naziv { get; set; }
        public String Lokacija { get; set; }
        public int Kapacitet { get; set; }
        internal List<Radnik> Radnici { get; set; }


    }
}
