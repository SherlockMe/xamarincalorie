using System;
using System.Collections.Generic;
using System.Text;
using Ornek_2.Models;
using SQLite;

namespace Ornek_2.DatabaseHelper
{
    public class DatabaseAccess
    {
        private SQLiteConnection conn;

        public DatabaseAccess(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Besin>();
        }

        public List<Besin> Listele()
        {
            return conn.Table<Besin>().ToList();
        }

        public int Sil(Besin besin)
        {
            return conn.Delete(besin);
        }

        public int Sil(int id)
        {
            return conn.Delete<Besin>(id);
        }

        public int EkleGuncelle(Besin besin)
        {
            if (besin.Id == 0)
                return conn.Insert(besin);
            else
                return conn.Update(besin);
        }
    }
}
