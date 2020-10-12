using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IEmailAFriend : ISendAMessageModel
    {
        string RecipientEmail { get; set; }
    }
}
