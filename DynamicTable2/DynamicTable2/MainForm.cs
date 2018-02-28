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
        int startingrows    = 3;
        int minrows         = 1;
        int maxrows         = 10;
        public MainForm() {
            InitializeComponent();

            InitialContents();
        }

        private void InitialContents () {
            tableLayoutPanel1.RowCount = startingrows;

            for (int i = 0; i < startingrows; i++) {
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });
            }

            metroLabel2.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRemoveRowButtonStateCheck();
        }

        private void extAddRowButton_Click(object sender, EventArgs e) {
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });

            metroLabel2.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRemoveRowButtonStateCheck();
        }

        private void extRemoveRowButton_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 1);
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 2);
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 3);

            tableLayoutPanel1.RowCount--;

            metroLabel2.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRemoveRowButtonStateCheck();
        }

        private void extRemoveRowButtonStateCheck () {
            if (tableLayoutPanel1.RowCount == minrows)
                extRemoveRowButton.Enabled = false;
            else
                extRemoveRowButton.Enabled = true;
        }
    }
}
