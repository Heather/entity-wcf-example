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

using System.Data.Services;
using System.Data.Services.Common;

namespace ENT_Server.WCF {
    class WCF_base {
        private Uri baseAddress;
        private Uri[] addressList;
        private void createHost() {
            /// Create the ServiceHost.
            /*using (ServiceHost host = new ServiceHost(typeof(ENT), baseAddress)) {
                /// Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);*/
            using (DataServiceHost host = new DataServiceHost(typeof(ENT_Service), addressList)) {
                ///<Summary>
                /// Open the ServiceHost to start listening for messages. Since
                /// no endpoints are explicitly configured, the runtime will create
                /// one endpoint per base address for each service contract implemented
                /// by the service.
                ///</Summary>
                host.Open();
                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();
                host.Close();
                }
            }
        public WCF_base() {
            addressList = new Uri[1];
            baseAddress = new Uri("http://localhost:8080/ENT_Server");
            addressList[0] = baseAddress;
            createHost();
            }
        }
    }