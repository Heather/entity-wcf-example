using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ENT_Interface {
    [ServiceContract]
    public interface IENT {
        [OperationContract]
        string GetRandomCustomerName();
        [OperationContract]
        int GetCustomersCount();
        }
    }
