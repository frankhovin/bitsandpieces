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
        int startingrows        = 3;                    // The number of rows to show on startup.
        int minrows             = 1;                    // The minimum number of rows.
        int maxrows             = 10;                   // The maximum number of rows.

        public Form1 () {
            InitializeComponent();

            /* Populate the first panel (Page 1): */
            PopulatePanelOne();



        }

        /**
         *  The starting state of the panels (pages).
         */
        private void Form1_Load(object sender, EventArgs e) {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            panel1.BringToFront();
            panel2.SendToBack();

        }

        /**
         *  Button handlers for the main form -> Previous and Next page buttons.
         *  Here, the panels are sent to the back or brought to the front, depending
         *  on which panel we want to show.
         *  This is using an index to define which panel to show and which to hide,
         *  so it's easy to add more pages.
         */
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

        /**
         *  Populate panel 1 (Page 1).
         */
        private void PopulatePanelOne () {
            tableLayoutPanel1.RowCount = startingrows;

            for (int i = 0; i < startingrows; i++) {
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
                tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });
            }

            page1RowCountLbl.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRowButtonStateCheck();   // Not strictly necessary here, but it would be important if we saved the number of rows between sessions.
        }

        /**
         *  Button handlers for the add/remove row buttons on Page 1.
         */
        private void extAddRowBttn_Click(object sender, EventArgs e) {
            tableLayoutPanel1.RowCount++;

            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right), Size = new System.Drawing.Size(120, 17), CustomBackground = true, BackColor = System.Drawing.SystemColors.ControlLightLight });
            tableLayoutPanel1.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.Left), Size = new System.Drawing.Size(15, 17) });

            page1RowCountLbl.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRowButtonStateCheck();
        }
        private void extRemoveBttn_Click(object sender, EventArgs e) {
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 1);
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 2);
            tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.RowCount * 3 - 3);

            tableLayoutPanel1.RowCount--;

            page1RowCountLbl.Text = "Rowcount: " + tableLayoutPanel1.RowCount;

            extRowButtonStateCheck();
        }

        /**
         *  Button state check and handler for the add/remove row buttons on Page 1.
         *  Disables the add/remove button if the row count reaches the min or max values.
         */
        private void extRowButtonStateCheck() {
            if (tableLayoutPanel1.RowCount <= minrows)
                extRemoveRowBttn.Enabled = false;
            else
                extRemoveRowBttn.Enabled = true;

            if (tableLayoutPanel1.RowCount == maxrows)
                extAddRowBttn.Enabled = false;
            else
                extAddRowBttn.Enabled = true;
        }
    }
}