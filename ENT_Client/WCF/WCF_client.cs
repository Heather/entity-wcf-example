using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

using ENT_Interface;

namespace ENT_Client.WCF {
    class WCF_client {
        public string name { get; private set; }
        public int count { get; private set; }
        private void connect() {
            using (ChannelFactory<IENT> customersFactory =
                        new ChannelFactory<IENT>("ENT_Client")) {
                IENT customersProxy = customersFactory.CreateChannel();
                name = customersProxy.GetRandomCustomerName();
                count = customersProxy.GetCustomersCount();
                }
            }
        public WCF_client() {
            connect();
            }
        }
    }
