using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.SqlClient;

namespace HSServicios
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ClaseHS : InterfazHS
    {
        /*Dictionary<string, bool> Videos = new Dictionary<string, bool>()
	    {
	        {"Spider Man", false},
	        {"dog", false},
	        {"llama", false},
	        {"iguana", false}
	    };*/
        public void GuardarDatos(string nombre, string tiempo, string enfermera, string numcam)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SoftwareHSBD;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TCAM (NOMBPAC,NOMBEMF,TIMEACT,NUMCAM)values(@NOMBPAC,@NOMBEMF,@TIMEACT,@NUMCAM)", con);
            cmd.Parameters.AddWithValue("@NOMBPAC", nombre);
            cmd.Parameters.AddWithValue("@TIMEACT", tiempo);
            cmd.Parameters.AddWithValue("@NOMBEMF", enfermera);
            cmd.Parameters.AddWithValue("@NUMCAM", numcam);
            cmd.ExecuteNonQuery();
        }

        void InterfazHS.GuardarDatos(string nombre, string tiempo, string efermera, string numcam)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SoftwareHSBD;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TCAM (NOMBPAC,NOMBEMF,TIMEACT,NUMCAM)values(@NOMBPAC,@NOMBEMF,@TIMEACT,@NUMCAM)", con);
            cmd.Parameters.AddWithValue("@NOMBPAC", nombre);
            cmd.Parameters.AddWithValue("@TIMEACT", tiempo);
            cmd.Parameters.AddWithValue("@NOMBEMF", efermera);
            cmd.Parameters.AddWithValue("@NUMCAM", numcam);
            cmd.ExecuteNonQuery();
        }
    }
}
