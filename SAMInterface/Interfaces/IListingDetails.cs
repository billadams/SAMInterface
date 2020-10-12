using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IListingDetails
    {
        int BaseCategoryID { get; set; }
        int ListingCategoryID { get; set; }
        int ListingID { get; set; }
        string ListingURL { get; set; }
    }
}
