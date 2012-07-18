using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

using ENT_Interface;

namespace ENT_Server.WCF {
    public class ENT : IENT {
        #region IENT Members
        public string GetRandomCustomerName() {
            return "Random Name";
            }
        public int GetCustomersCount() {
            return 100;
            }
        #endregion
        }
    }
