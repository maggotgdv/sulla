using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHS
{
    class Doctor:IDoctor
    {
        string nombredoc;
        public void SetNombreDoc(string inombredoc)
        {
            nombredoc = inombredoc;
        }
    }
}
