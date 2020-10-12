using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IStandardFormInputs
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string PostalCode { get; set; }
        string Comments { get; set; }
    }
}
