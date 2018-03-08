using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTables {
    public partial class Form1 : Form {
        List<Panel> listPanel   = new List<Panel>();
        int index               = 0;
        int startingrows        = 3;
        int minrows             = 1;
        int maxrows             = 10;

        public Form1 () {
            InitializeComponent();

            PopulatePanelOne();
        }

        private void bttnPrevious_Click(object sender, EventArgs e) {
            if (index > 0) {
                listPanel[index].SendToBack();
                listPanel[--index].BringToFront();
            }
        }

        private void bttnNext_Click_1(object sender, EventArgs e) {
            if (index < listPanel.Count - 1) {
                listPanel[index].SendToBack();
                listPanel[++index].BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            panel1.BringToFront();
            panel2.SendToBack();
        }

        private void PopulatePanelOne () {
            //panel1.RowCount = startingrows;

            for (int i = 0; i < startingrows; i++) {
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });
            }

            //table1label.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            //extRemoveRowButtonStateCheck();
        }

        private void extAddRowBttn_Click(object sender, EventArgs e) {

        }

        private void extRemoveRowBttn_Click(object sender, EventArgs e) {

        }
    }
}