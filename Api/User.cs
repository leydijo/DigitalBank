using System;
using Business;
using System.Runtime.Serialization;

namespace Api
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public char Gender { get; set; }

        //public static implicit operator DataTable(User v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}