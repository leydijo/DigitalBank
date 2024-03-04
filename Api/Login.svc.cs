using Business;
using System;
using System.Data;
using System.ServiceModel;

namespace Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Login.svc or Login.svc.cs at the Solution Explorer and start debugging.
    public class Login : ILogin
    {
        private readonly BusinessUser _user;

        public Login()
        {
            _user = new BusinessUser();
        }


        public DataTable GetUser(string name)
        {
            User user = null;
            DataTable userTable = BusinessUser.ShowUSer();
            if (string.IsNullOrEmpty(name))
            {
                throw new FaultException("El nombre del usuario no puede estar vacío.");
            }
            try
            {
  
                if (user != null && userTable.Rows.Count > 0)
                {

                    user = new User
                    {

                        Name = userTable.Rows[0]["Name"].ToString(),
                        DateBirth = DateTime.Parse(userTable.Rows[2]["DateBirth"].ToString()),
                        Gender = Convert.ToChar(userTable.Rows[3]["Gender"].ToString()),

                    };
                }
                else
                {

                    throw new FaultException($"No se encontró el usuario con el nombre: {name}");
                }

            }
            catch (Exception ex)
            {

                throw new FaultException("Ocurrió un error al intentar obtener el usuario: " + ex.Message);
            }
            return userTable;
        }

        public void Insert(string Name, DateTime DateBirth, char Gender)
        {
            string userTable = BusinessUser.InsertUser(Name, DateBirth, Gender);
        }

       

       
    }
}
