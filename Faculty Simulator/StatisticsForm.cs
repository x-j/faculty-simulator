using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Simulator {
    public partial class StatisticsForm : Form {
        public StatisticsForm(MainForm mf) {
            InitializeComponent();

            //this nice piece of code below gets all the ListViewItems from MainFrame and adds them here
            //and then to each assigns the appropiate click count.
            for (int i = 0; i < mf.listViews.Count; i++) {
                var lv = mf.listViews[i];
                for (int j = 0; j < lv.Items.Count; j++) {
                    var item = lv.Items[j];
                    var stat = new ListViewItem(item.Text);
                    stat.SubItems.Add(""+mf.clickCounts[i][j]);
                    listView.Items.Add(stat);
                }
            }
        }
    }
}
