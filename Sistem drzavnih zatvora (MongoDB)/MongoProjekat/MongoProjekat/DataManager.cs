using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoProjekat.Entiteti;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Windows.Forms;

namespace MongoProjekat
{
    public class DataManager
    {

        #region Logovanje

        public static Radnik PrijaviRadnika(String korisnicko, String sifra)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");

            var query = Query.And(
                          Query.EQ("Korisnicko", korisnicko),
                          Query.EQ("Sifra", sifra)
                          );

            Radnik rad = collection1.Find(query).FirstOrDefault();

            if (rad == null) { 
                return null;
            }
            return rad;
        }

        #endregion

        #region Zatvor

        public static void kreirajCelije()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Celija>("celije");

            Celija c1 = new Celija { Blok = "A", Broj = 123, Kapacitet = 3, Popunjenost = 0, ZatvorID = "5c609bde28d5b30f60daba9e" };
            Celija c2 = new Celija { Blok = "B", Broj = 233, Kapacitet = 2, Popunjenost = 0, ZatvorID = "5c609bde28d5b30f60daba9e" };
            Celija c3 = new Celija { Blok = "C", Broj = 341, Kapacitet = 4, Popunjenost = 0, ZatvorID = "5c609bde28d5b30f60daba9e" };
            Celija c4 = new Celija { Blok = "D", Broj = 82, Kapacitet = 2, Popunjenost = 0, ZatvorID = "5c609bde28d5b30f60daba9e" };

            collection1.Insert(c1);
            collection1.Insert(c2);
            collection1.Insert(c3);
            collection1.Insert(c4);

        }

        public static void kreirajZatvorenike()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Zatvorenik>("zatvorenici");


            Zatvorenik c1 = new Zatvorenik { Ime = "Zoran", Prezime = "Jovanovic",  JMBG= "0709985743312", DatumRodjenja = "07.09.1985", DatumUlaska="01.03.2015", DatumIzlaska="01.03.2020", CelijaID = "5c60bb1628d5b32578b0528f", ZatvorID = "5c609bde28d5b30f60daba9e" };
            Zatvorenik c2 = new Zatvorenik { Ime = "Jovan", Prezime = "Stojmenovic", JMBG = "0205980743211", DatumRodjenja = "02.05.1980", DatumUlaska = "01.08.2011", DatumIzlaska = "01.05.2025", CelijaID = "5c60bb1628d5b32578b0528f", ZatvorID = "5c609bde28d5b30f60daba9e" };
            Zatvorenik c3 = new Zatvorenik { Ime = "Milos", Prezime = "Milosavljevic", JMBG = "0301988743515", DatumRodjenja = "03.01.1988", DatumUlaska = "01.07.2013", DatumIzlaska = "01.01.2024", CelijaID = "5c60bb1628d5b32578b0528f", ZatvorID = "5c609bde28d5b30f60daba9e" };
            Zatvorenik c4 = new Zatvorenik { Ime = "Nemanja", Prezime = "Stefanovic", JMBG = "1211976741232", DatumRodjenja = "12.11.1976", DatumUlaska = "01.02.2014", DatumIzlaska = "01.06.2021", CelijaID = "5c60bb1628d5b32578b0528f", ZatvorID = "5c609bde28d5b30f60daba9e" };



            collection1.Insert(c1);
            collection1.Insert(c2);
            collection1.Insert(c3);
            collection1.Insert(c4);
        }

        public static void az()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");
            var query = Query.EQ("_id", ObjectId.Parse("5c60abec28d5b336c041e9cf"));
            var update = MongoDB.Driver.Builders.Update.Set("ZatvorID", BsonValue.Create("5c609bde28d5b30f60daba9e"));

            collection1.Update(query, update);
        }

        public static void kreirajRadnike()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");


            Radnik c1 = new Radnik { Ime = "Zoran", Prezime = "Jovanovic", Korisnicko = "zoran1", Sifra = "zoran1", Smena = "prva", Tip = 1, JMBG = "0709985743312", DatumRodjenja = "07.09.1985", ZatvorID = "5c609bde28d5b30f60daba9b" };
            Radnik c2 = new Radnik { Ime = "Jovan", Prezime = "Stojmenovic", Korisnicko = "jovan1", Sifra = "jovan1", Smena = "druga", Tip = 0, JMBG = "0205980743211", DatumRodjenja = "02.05.1980", ZatvorID = "5c609bde28d5b30f60daba9b", Blokovi = new List<string> { "B", "C" } };
            Radnik c3 = new Radnik { Ime = "Milos", Prezime = "Milosavljevic", Korisnicko = "milos1", Sifra = "milos1", Smena = "treca", Tip = 0,  JMBG = "0301988743515", DatumRodjenja = "03.01.1988", ZatvorID = "5c609bde28d5b30f60daba9b", Blokovi = new List<string> { "D" } };
            Radnik c4 = new Radnik { Ime = "Nemanja", Prezime = "Stefanovic", Korisnicko = "nemanja1", Sifra = "nemanja1", Smena = "prva", Tip = 1, JMBG = "1211976741232", DatumRodjenja = "12.11.1976", ZatvorID = "5c609bde28d5b30f60daba9b" };



            collection1.Insert(c1);
            collection1.Insert(c2);
            collection1.Insert(c3);
            collection1.Insert(c4);
        }

        public static void azur(String id)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");
            var query = Query.EQ("_id", ObjectId.Parse(id));
            var update = MongoDB.Driver.Builders.Update.Set("Blokovi", BsonValue.Create(new List<string> { "A", "C" }));

            collection1.Update(query, update);
        }

        #endregion

        #region Radnik
        internal static void AzurirajSmenu(Radnik radnik, string text)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");

            var query = Query.EQ("_id", radnik.Id);
            var update = MongoDB.Driver.Builders.Update.Set("Smena", BsonValue.Create(text));

            collection1.Update(query, update);
        }
       
        public static List<Radnik> PregledajRadnike(String zatvorID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");
            var query = Query.And(
                      (Query.EQ("ZatvorID", zatvorID)),
                      (Query.Not(Query.EQ("Tip", 1)))
                      );
            return collection1.Find(query).ToList();
        }

        public static Radnik VratiRadnika(String rID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Radnik>("radnici");

            var query = Query.EQ("_id", ObjectId.Parse(rID));

            Radnik r = collection1.FindOne(query);

            return r;
        }

        #endregion

        #region Osudjenik
        public static List<Zatvorenik> VratiZatvorenikePoBloku(String blok, String zatvorID)
        {
            List<Zatvorenik> zatvorenici = new List<Zatvorenik>();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Zatvorenik>("zatvorenici");

            //svi zatvorenici u tom zatvoru
            var query = Query.EQ("ZatvorID", zatvorID);

            foreach(Zatvorenik z in collection1.Find(query).ToList())
            {
                Celija c = VratiCeliju(z.CelijaID);
                
                    if (c.Blok == blok)
                        zatvorenici.Add(z);
                
            }
            return zatvorenici;
        }
        public static Celija VratiCeliju(String ID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Celija>("celije");

            var query = Query.EQ("_id", ObjectId.Parse(ID));

            Celija c = collection1.FindOne(query);

            return c;
        }
        public static List<Zatvorenik> VratiSveZatvorenike(String zatvorID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Zatvorenik>("zatvorenici");

            //svi zatvorenici u tom zatvoru
            var query = Query.EQ("ZatvorID", zatvorID);

            return collection1.Find(query).ToList();
        }
        public static Zatvorenik VratiZatvorenika(String id)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Zatvorenik>("zatvorenici");

            var query = Query.EQ("_id", ObjectId.Parse(id));

            Zatvorenik c = collection1.FindOne(query);

            return c;
        }
        public static String VratiSlobodnuCeliju(String zatvorID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Celija>("celije");

            var query = Query.EQ("ZatvorID", zatvorID);

            foreach(Celija c in collection1.Find(query).ToList())
            {
                if (c.Popunjenost < c.Kapacitet)
                    return c.Id.ToString();
            }
            return null;
        }
        public static void AzurirajBrojPopunjenostiCelije(String celijaID)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection1 = database.GetCollection<Celija>("celije");

            //pronalazi zadatu celiju
            var query = Query.EQ("_id", ObjectId.Parse(celijaID));
            Celija c = collection1.FindOne(query);

            c.Popunjenost += 1;
            var update = MongoDB.Driver.Builders.Update.Set("Popunjenost", BsonValue.Create(c.Popunjenost));

            collection1.Update(query, update);
        }
        public static void AddZatvorenik(Zatvorenik z)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<Zatvorenik>("zatvorenici");

            collection.Insert(z);
        }
        public static Zatvorenik GetZatvorenik(String jmbg)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<Zatvorenik>("zatvorenici");
            Zatvorenik z = collection.FindOne(Query.EQ("JMBG", BsonValue.Create(jmbg)));

            return z;
        }

        #endregion

        #region Dela

        public static KrivicnaDela GetDelo(String id)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<KrivicnaDela>("krivicnadela");
            KrivicnaDela d = collection.Find(Query.EQ("_id", ObjectId.Parse(id))).FirstOrDefault();

            return d;
        }

        public static void AddDela(List<KrivicnaDela> dela)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<KrivicnaDela>("krivicnadela");

            foreach (KrivicnaDela k in dela)
            {
                collection.Insert(new KrivicnaDela
                {
                    BrojDana = k.BrojDana,
                    DatumOsudjivanja = k.DatumOsudjivanja,
                    NazivDela = k.NazivDela,
                    OpisDela = k.OpisDela,
                    ZatvorenikID = k.ZatvorenikID
                });
            }

        }

        public static void DeleteDela(Zatvorenik z)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<KrivicnaDela>("krivicnadela");

            var query = Query.EQ("ZatvorenikID", BsonValue.Create(z.Id.ToString()));

            collection.Remove(query);
        }

        public static List<KrivicnaDela> GetDela(Zatvorenik z)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("sistemzatvora");

            var collection = database.GetCollection<KrivicnaDela>("krivicnadela");


            List<KrivicnaDela> kdl = collection.Find(Query.EQ("ZatvorenikID", BsonValue.Create(z.Id.ToString()))).ToList();
            return kdl;
        }

        #endregion

    }
}
