using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ornek_2.Models
{
    [Table("tblBesinler")]
    public class Besin
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Ener { get; set; }
        public string Protein { get; set; }
        public string Khidrat { get; set; }
        public string Kalsiyum { get; set; }
        public string Demir { get; set; }
        public string Aciklama { get; set; }

    }
}
