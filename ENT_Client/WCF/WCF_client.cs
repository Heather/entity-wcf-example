using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///<Summary>
/// Deprecated because of switching to WCF Data Service
///</Summary>
/*
 * using System.ServiceModel;
 * using System.ServiceModel.Description;
 * using ENT_Interface;
 */
using System.Data.Services.Client;
using ENT_Client.ENT_Server;

namespace ENT_Client.WCF {
    class WCF_client {
        public ENTEntities context;
        private Uri baseAddress = new Uri("http://localhost:8080/ENT_Server");
        ///<Summary>
        /// Deprecated because of switching to WCF Data Service
        ///</Summary>
        /*
         * public string name { get; private set; }
         * public int count { get; private set; }
         */
        private void connect() {
            ///<Summary>
            /// Deprecated because of switching to WCF Data Service
            ///</Summary>
            /*using (ChannelFactory<IENT> customersFactory =
                        new ChannelFactory<IENT>("ENT_Client")) {
                IENT customersProxy = customersFactory.CreateChannel();
                name = customersProxy.GetRandomCustomerName();
                count = customersProxy.GetCustomersCount();
                }*/
            context = new ENTEntities(baseAddress);
            }
        public WCF_client() {
            connect();
            }
        }
    }


/*var query = 
    from o in context.Orders.Expand("Order_Details")
                  where o.Customer.CustomerID == customerId
                  select o;*/