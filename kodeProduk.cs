using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal4
{
    class kodeProduk
    {
        public string nama;
        private String kode;

        public kodeProduk(string nama, String kode)
        {
            this.nama = nama;
            this.kode = kode;
        }

        public string getKodeProduk() {
            return kode;
        }
    }
}
