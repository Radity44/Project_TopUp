using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_SewaKamera.App.Context;
using Project_SewaKamera.App.Core;

namespace Project_SewaKamera.App.Model
{
    public class M_Sewa
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Barang { get; set; }
        public string Durasi { get; set; }
        public DateTime TanggalSewa { get; set; }
    }

}
