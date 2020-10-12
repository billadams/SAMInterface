using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMInterface.Interfaces
{
    interface IVideoChatRequest : ISendAMessageModel
    {
        string VideoChatDevice { get; set; }
        string VideoChatDay { get; set; }
        string VideoChatTime { get; set; }
    }
}
