using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunProBFR
{
    internal class Karyawan: Departemen
    {
        private string _id_karyawan;
        private string _nama;
        private int _id_dep;

        public string Id_karyawan { get => _id_karyawan; set => _id_karyawan = value; }
        public string Nama { get => _nama; set => _nama = value; }
    }
}
