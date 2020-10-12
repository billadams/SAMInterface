using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IDealerDetails
    {
        int DealerCRMID { get; set; }
        int DSCompanyID { get; set; }
        int DealerGroupID { get; set; }
        string BranchName { get; set; }
    }
}
