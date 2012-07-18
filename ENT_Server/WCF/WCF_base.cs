using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

namespace ENT_Server.WCF {

    [ServiceContract]
    public interface IENT_Service {
        [OperationContract]
        string SayHello(string name);
        }

    public class ENT_Service : IENT_Service {
        public string SayHello(string name) {
            return string.Format("Hello, {0}", name);
            }
        }

    class WCF_base {
        }

    }
