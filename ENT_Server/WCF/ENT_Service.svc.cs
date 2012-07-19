using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Services;
using System.Data.Services.Common;

using ENT_Server.Entity;

namespace ENT_Server.WCF {
    public class ENT_Service : DataService<ENTEntities> {
        public static void InitializeService(DataServiceConfiguration config) {
            config.SetEntitySetAccessRule("Good", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Shop", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Cash", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("CashHeading", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Customer", EntitySetRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
            }
        }
    }
/*
 * | EntitySetRights.WriteMerge
 * | EntitySetRights.WriteReplace
 * | EntitySetRights.AllWrite
*/