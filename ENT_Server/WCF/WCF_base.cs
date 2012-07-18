using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Description;

using ENT_Interface;

namespace ENT_Server.WCF {
    class WCF_base {
        private Uri baseAddress;
        private void createHost() {
            /// Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(ENT), baseAddress)) {
                /// Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

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
                /// Close the ServiceHost.
                host.Close();
                }
            }
        public WCF_base() {
            baseAddress = new Uri("http://localhost:8080/ENT_Server");
            createHost();
            }
        }
    }
