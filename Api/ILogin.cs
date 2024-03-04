using System;
using System.Data;
using System.ServiceModel;

namespace Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogin" in both code and config file together.
    [ServiceContract]
    public interface ILogin
    {
       // [OperationContract]
      // bool ValidateLogin(string username, string password);
        [OperationContract]
        DataTable GetUser(string name);
        [OperationContract]
        void Insert(string Name, DateTime DateBirth, char Gender);
    }
}
