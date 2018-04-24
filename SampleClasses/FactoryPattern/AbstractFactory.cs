using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClasses.FactoryPattern
{
    public interface ITicketHolder
    {

    }


    public interface IUser : ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
    }

    

    public class Person : IUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void SetIdentity(IUserIdentity identity)
        {
            // Does not work, the concrete Person class can't set identity on the abstract
            //  SetIdentity(IUserIdentity identity) - > IUserIdentity.SSN; 

        }
    }

    public class Machine : IUser
    {
        public string Producer { get; set; }
        public string Model { get; set; }

        public void SetIdentity(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }
    }


    //Factory
    public interface IUserFactory
    {
        IUser CreateUser();
    }
}
