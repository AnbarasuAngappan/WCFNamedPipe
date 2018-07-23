using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFNamedPipe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFNamedPipe" in both code and config file together.
    [ServiceContract]
    public interface IWCFNamedPipe
    {
        [OperationContract]
        int calculateDays(int day, int Month, int year);
    }
}
