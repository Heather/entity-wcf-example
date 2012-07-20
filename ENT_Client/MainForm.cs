using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ENT_Client.WCF;

namespace ENT_Client {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            }
        private void OK_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Customer"));
            var cquery = from c in Client.wcf.context.Customer select c;
            int customern = 0;
            var query = //from cc in Client.wcf.context.Customer
                        from ch in Client.wcf.context.CashHeading
                        where ch.Id_customer == customern//cc.Id
                        from cs in Client.wcf.context.Cash
                        where cs.Id_cashheading == ch.Id
                        where Shop.SelectedIndex == 0
                            || ch.Id_shop == (int)Shop.SelectedValue
                        from gg in Client.wcf.context.Good
                        where gg.Id == cs.Id_good
                        select new {
                            gg.Price,
                            ch.Date
                        };
                        /*new CustomerOrderResult {
                            CustomerID = customern,//cc.Id,
                            Price = gg.Price.HasValue ? gg.Price.Value : 0,
                            Date = ch.Date.HasValue ? ch.Date.Value : DateTime.Now
                        };*/
            if (Period_Month.Checked) {
                for (DateTime date = Date_Start.Value; date <= Date_End.Value; date = date.AddMonths(1)) {
                    dt.Columns.Add(new DataColumn(date.ToString("MMMM yyyy")));
                    }
                dt.Columns.Add(new DataColumn("total"));
                foreach (ENT_Server.Customer c in cquery) {
                    customern = c.Id;
                    DataRow customRow = dt.NewRow();
                    customRow[0] = c.Name;
                    int j = 0;
                    double total = 0;
                    for (DateTime date = Date_Start.Value; date <= Date_End.Value; date = date.AddMonths(1)) {
                        var q = from x in query
                                where x != null && c!= null
                                //where x.CustomerID == c.Id
                                where x.Date > date && x.Date < date.AddMonths(1)
                                select (x.Price.HasValue? x.Price.Value : 0);
                        try {
                            j++;
                            double val = (q.Count() == 0) ? 0.0 : q.Average(qi => qi);
                            customRow[j] = val;
                            total += val;
                        } catch (Exception) {
                            ; //TODO: (Error translating Linq expression to URI: Can only specify query options (orderby, where, take, skip) 
                            }
                        }
                    customRow[j+1] = total;
                    dt.Rows.Add(customRow);
                    }
                }
            else {
                int wk = 0;
                for (DateTime date = Date_Start.Value; date <= Date_End.Value; date = date.AddDays(7)) {
                    dt.Columns.Add(new DataColumn(date.ToString("MMMM yyyy") + " Week:" + wk.ToString() ));
                    wk++;
                    }
                dt.Columns.Add(new DataColumn("total"));
                foreach (ENT_Server.Customer c in cquery) {
                    customern = c.Id;
                    DataRow customRow = dt.NewRow();
                    customRow[0] = c.Name;
                    int j = 0;
                    double total = 0;
                    for (DateTime date = Date_Start.Value; date <= Date_End.Value; date = date.AddDays(7)) {
                        var q = from x in query
                                    //where x.CustomerID == c.Id
                                    where x.Date > date && x.Date < date.AddMonths(1)
                                select (x.Price.HasValue ? x.Price.Value : 0);
                        try {
                            j++;
                            double val = (q.Count() == 0) ? 0.0 : q.Average(qi => qi);
                            customRow[j] = val;
                            total += val;
                        } catch (Exception) {
                            ; //TODO: (Error translating Linq expression to URI: Can only specify query options (orderby, where, take, skip) 
                            }
                        }
                    customRow[j+1] = total;
                    dt.Rows.Add(customRow);
                    }
                }
                MainGreed.DataSource = dt;
            }
        ///<Summary>
        /// Fill all the things
        ///</Summary>
        private void MainForm_Load(object sender, EventArgs e) {
            Client.wcf = new WCF_client();
            Shop.Items.Add(new ComboboxItem("All", 0));
            Shop.SelectedIndex = 0;
            var query = from s in Client.wcf.context.Shop select s;
            foreach (ENT_Server.Shop shop in query) {
                Shop.Items.Add(new ComboboxItem(shop.Shop1, shop.Id));
                }
            Date_Start.Value = System.DateTime.Now.AddMonths(-5);
            Period_Month.Checked = true;
            }
        }
    }
