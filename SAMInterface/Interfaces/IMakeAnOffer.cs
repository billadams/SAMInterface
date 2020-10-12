using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IMakeAnOffer : ISendAMessageModel
    {
        string OfferAmount { get; set; }
    }
}
