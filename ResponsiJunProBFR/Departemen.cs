using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunProBFR
{
    internal class Departemen
    {
        private int _id_dep;
        private string _nama_dep;

        public int Id_dep { get => _id_dep; set => _id_dep = value; }
        public string Nama_dep { get => _nama_dep; set => _nama_dep = value; }
    }
}
