using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotecah
{
    class MiClaseMagica
    {
        public class Variables_Globales
        {
            admin_bibliotecahEntities A = new admin_bibliotecahEntities();

            public static String RUTA_SERVIDOR;
            public static String SMTP_SERVER;
            public static String SMTP_USER;
            public static String SMTP_PASS;
            public static int ACTIVE_USER;
            public static String ACTIVE_USER_EMAIL;
            public static String CALIDAD_EMAIL;


            public void updateData()
            {
                try
                {
                    string value = "rutaServidor";
                    var tblRuta = A.Configuraciones.FirstOrDefault(x => x.Idconfig == value);
                    RUTA_SERVIDOR = tblRuta.Value;

                    value = "smtpPass";
                    tblRuta = A.Configuraciones.FirstOrDefault(x => x.Idconfig == value);
                    SMTP_PASS = tblRuta.Value;

                    value = "smtpServer";
                    tblRuta = A.Configuraciones.FirstOrDefault(x => x.Idconfig == value);
                    SMTP_SERVER = tblRuta.Value;

                    value = "smtpUser";
                    tblRuta = A.Configuraciones.FirstOrDefault(x => x.Idconfig == value);
                    SMTP_USER = tblRuta.Value;

                    value = "correoCalidad";
                    tblRuta = A.Configuraciones.FirstOrDefault(x => x.Idconfig == value);
                    CALIDAD_EMAIL = tblRuta.Value;

                }
                catch (Exception x)
                {

                    MessageBox.Show(x.Message);
                }

            }



        public Variables_Globales()
            {
                updateData();
            }

        }



    
    }
}