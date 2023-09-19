using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polytech.DAL.Model;
using Polytech.DAL;


namespace Polytech.Online.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.CreateDate = DateTime.Now;
            client.Dob = new DateTime(1988, 11, 01);
            client.Email = "gersen.e.a@gmail.com";

            client.Password = "123";
            client.FName = "Yevgeniy";
            client.SName = "Yevgeniy";
            client.LName = "";

            ServiceClient serviceClient = new ServiceClient();
            serviceClient.CreateClient(client);

        }
    }
}
