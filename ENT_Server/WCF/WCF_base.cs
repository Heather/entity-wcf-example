using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Services;
using System.Data.Services.Common;

namespace ENT_Server.WCF {
    class WCF_base {
        private Uri baseAddress;
        private Uri[] addressList;
        private void createHost() {
            using (DataServiceHost host = new DataServiceHost(typeof(ENT_Service), addressList)) {
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