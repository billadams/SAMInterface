using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IInquiryTypes
    {
        bool AddWarranty { get; set; }
        bool CheckAvailability { get; set; }
        bool EmailAFriend { get; set; }
        bool EmailSeller { get; set; }
        bool IsMakeAnOffer { get; set; }
        bool IsShowroom { get; set; }
        bool VideoChatRequest { get; set; }
    }
}
