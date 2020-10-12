using SAMInterface.Interfaces;
using SAMInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new SendAMessageModel();

            BuildSAMFormInput(model);
        }

        static void BuildSAMFormInput(IEmailAFriend model)
        {
            model.FirstName = "Bill";
            model.LastName = "Adams";
            model.Email = "testemail@testing.com";
            model.DSCompanyID = 1234;
            model.RecipientEmail = "test@gmail.com";

        }
    }
}
