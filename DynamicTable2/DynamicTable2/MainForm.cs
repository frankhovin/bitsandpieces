using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DynamicTable2 {
    public partial class MainForm : Form {
        int startingrows = 3;
        public MainForm() {
            InitializeComponent();

            InitialContents();
        }

        private void InitialContents () {
            for (int i = 0; i < startingrows; i++) {
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });
            }
        }

        private void extAddRowButton_Click(object sender, EventArgs e) {
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });


        }
    }
}
