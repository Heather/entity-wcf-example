using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

using ENT_Interface;

namespace ENT_Client.WCF {
    class WCF_client {
        private void connect() {
            using (ChannelFactory<IENT> customersFactory =
                        new ChannelFactory<IENT>("ENT_Client")) {
                IENT customersProxy = customersFactory.CreateChannel();
                string name = customersProxy.GetRandomCustomerName();
                int count = customersProxy.GetCustomersCount();
                //Console.WriteLine(name);
                //Console.WriteLine(count);
                }
            }
        public WCF_client() {
            connect();
            }
        }
    }
