using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface ISendAMessageModel : IStandardFormInputs, IListingDetails, IDealerDetails
    {
        string Subject { get; set; }
    }
}
