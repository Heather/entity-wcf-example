using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENT_Client {
    public class ComboboxItem {
        public string Text { get; set; }
        public object Value { get; set; }
        public ComboboxItem(string text, int value) {
            Text = text;
            Value = value;
            }
        public override string ToString() {
            return Text;
            }
        }
    }

public class CustomerOrderResult {
    public int CustomerID { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
    }