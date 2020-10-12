using SAMInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Models
{
    class SendAMessageModel : ISendAMessageModel, IMakeAnOffer, IEmailAFriend, IVideoChatRequest, IInquiryTypes
    {
        public string Subject { get; set; }

        //Standard Form Inputs
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string Comments { get; set; }

        //Listing Details
        public int BaseCategoryID { get; set; }
        public int DSCompanyID { get; set; }
        public int ListingCategoryID { get; set; }
        public int ListingID { get; set; }
        public string ListingURL { get; set; }

        //Dealer Details
        public int DealerCRMID { get; set; }
        public int DealerGroupID { get; set; }
        public string BranchName { get; set; }

        //Inquiry Types
        public bool AddWarranty { get; set; }
        public bool CheckAvailability { get; set; }
        public bool EmailAFriend { get; set; }
        public bool EmailSeller { get; set; }
        public bool IsMakeAnOffer { get; set; }
        public bool IsShowroom { get; set; }
        public bool VideoChatRequest { get; set; }

        //Email A Friend
        public string RecipientEmail { get; set; }

        //Make An Offer
        public string OfferAmount { get; set; }

        //Video Chat Request
        public string VideoChatDevice { get; set; }
        public string VideoChatDay { get; set; }
        public string VideoChatTime { get; set; }
    }
}
