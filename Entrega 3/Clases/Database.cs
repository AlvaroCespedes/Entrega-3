using System;
using System.Collections.Generic;

namespace Entrega_3.Clases


{



    public class DataBase
    {

        // Diccionario para guardar todos los registros
        // Los datos de cada registro se guardan en List<string> con formato [usuario, correo, password, linkVerificacion, fecha, numero]
        private Dictionary<int, List<string>> registered;

        // Constructor
        public DataBase()
        {
            registered = new Dictionary<int, List<string>>();
        }

        // Metodo para cambiar la contrasena de usr por newpsswds
        public void ChangePassword(string usr, string newpsswd)
        {
            foreach (List<string> user in this.registered.Values)
            {
                if (user[0] == usr)
                {
                    user[2] = newpsswd;
                }
            }
        }

        public void ChangeEmail(string usr, string newpsswd)
        {
            foreach (List<string> user in this.registered.Values)
            {
                if (user[0] == usr)
                {
                    user[1] = newpsswd;
                }
            }
        }
    }
}
