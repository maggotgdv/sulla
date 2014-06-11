using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HSServicios
{
    [ServiceContract]
    interface InterfazHS
    {
        [OperationContract]
        void GuardarDatos(string nombre, string tiempo, string efermera, string numcam);
    }
}
