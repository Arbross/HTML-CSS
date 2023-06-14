using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView._WF
{
    public class CmpProducts : IComparer
    {
        private int column;
        private SortOrder sortOrder;
        public CmpProducts(int column, SortOrder sortOrder = SortOrder.Ascending)
        {
            this.column = column;
            this.sortOrder = sortOrder;
        }
        public int Compare(object x, object y)
        {
            ListViewItem li1 = x as ListViewItem;
            ListViewItem li2 = y as ListViewItem;
            int result = 0;
            if (column == 0)
            {
                string prod1 = li1.Text;
                string prod2 = li2.Text;
                result = prod1.CompareTo(prod2);
            }
            else
            {
                decimal value1 = Convert.ToDecimal(li1.SubItems[column].Text);
                decimal value2 = Convert.ToDecimal(li2.SubItems[column].Text);
                result = value1.CompareTo(value2);
            }
            return result;
        }
    }
}
