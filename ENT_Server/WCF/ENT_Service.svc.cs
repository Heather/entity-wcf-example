using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Services;
using System.Data.Services.Common;

using ENT_Server.Entity;

namespace ENT_Server.WCF {
    public class WcfDataService1 : DataService<ENTEntities> {
        public static void InitializeService(DataServiceConfiguration config) {
            config.SetEntitySetAccessRule("Good", EntitySetRights.AllRead
                 | EntitySetRights.WriteMerge
                 | EntitySetRights.WriteReplace);
            config.SetEntitySetAccessRule("Shop", EntitySetRights.AllRead
                | EntitySetRights.AllWrite);
            config.SetEntitySetAccessRule("Cash", EntitySetRights.AllRead);

            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
            }
        }
    }
