using Data;
using System;
using System.Data;

namespace Business
{
    public class BusinessUser
    {
        public static DataTable ShowUSer()
        {
            DataUser dataUser = new DataUser();
            return dataUser.ShowUSer();
        }

        public static DataTable SearchUser(string data)
        {
            DataUser dataUser = new DataUser();
            return dataUser.SearchUser(data);
        }
        public static string InsertUser(string Name, DateTime DateBirth, char Gender)
        {  /* referencia la clase DataUser y  User
            * asigno las variables del metodo insertar de la capa negocios y las asigno a las variables de user
            */

            DataUser dataUser = new DataUser();
            User user = new User();
            user.Name = Name;
            user.DateBirth = DateBirth;
            user.Gender = Gender;
            return dataUser.InsertUser(user);
        }

        public static string UpdateUser(int Id,string Name, DateTime DateBirth, char Gender)
        { 
            DataUser dataUser = new DataUser();
            User user = new User();
            user.Id = Id;
            user.Name = Name;
            user.DateBirth = DateBirth;
            user.Gender = Gender;
            return dataUser.UpdatetUser(user);
        }

        public static string DeleteUser(int Id)
        {
            DataUser dataUser = new DataUser();
            User user = new User();
            user.Id = Id;
            return dataUser.DeletetUser(Id);
        }
    }
}
