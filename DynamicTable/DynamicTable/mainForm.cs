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

namespace DynamicTable {
    public partial class mainForm : Form {
        MetroFramework.Controls.MetroButton addRowButton,
                                            removeRowButton;

        public mainForm() {
            InitializeComponent();

            //if (Properties.Settings.Default.rowcount == 0) { // Temp removed, to make sure we start fresh when needed.
            //Properties.Settings.Default.rowcount = 3;
            //}
            //
            // column1Label
            //

            // Add 2 rows: Labels (top) and buttons (bottom)
            TableLayoutPanel.RowCount = 2;
            AddLabels();

            // Add rows and increase the row count accordingly:
            for (int i = 0; i <3; i++) {
                TableLayoutPanel.RowCount++;
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.None) });
            }

            // Add the +/- rows buttons:
            AddRowsButtons();

            // Check if the button should be disabled (the total row count is below 4 - one login row)
            RemoveRowButtonStatusCheck();

        }

        private void AddLabels () {
            MetroFramework.Controls.MetroLabel column1Label = new MetroFramework.Controls.MetroLabel();
            TableLayoutPanel.Controls.Add(column1Label);
            column1Label.TabIndex = 1;
            column1Label.Text = "Column 1";
            //
            // column2Label
            //
            MetroFramework.Controls.MetroLabel column2Label = new MetroFramework.Controls.MetroLabel();
            TableLayoutPanel.Controls.Add(column2Label);
            column2Label.TabIndex = 2;
            column2Label.Text = "Column 2";
            //
            // column3Label
            //
            MetroFramework.Controls.MetroLabel column3Label = new MetroFramework.Controls.MetroLabel();
            TableLayoutPanel.Controls.Add(column3Label);
            column3Label.TabIndex = 4;
            column3Label.Text = "?";
        }


        private void AddRowsButtons() {
            // addRowButton
            addRowButton = new MetroFramework.Controls.MetroButton();
            TableLayoutPanel.Controls.Add(addRowButton);
            addRowButton.Size = new System.Drawing.Size(20, 20);
            addRowButton.Text = "+";
            addRowButton.Click += new System.EventHandler(addRowButton_Click);
            // removeRowButton
            removeRowButton = new MetroFramework.Controls.MetroButton();
            TableLayoutPanel.Controls.Add(removeRowButton);
            removeRowButton.Size = new System.Drawing.Size(20, 20);
            removeRowButton.Text = "-";
            removeRowButton.Click += new System.EventHandler(removeRowButton_Click);
            // Placeholder label:
            TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroLabel());
        }


        private void addRowButton_Click(object sender, EventArgs e) {
            TableLayoutPanel.RowCount++;

            // First, maybe remove the row with the buttons?

            // Add a new row, up to 6 total:
            if (TableLayoutPanel.RowCount < 9) {
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                TableLayoutPanel.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.None) });

            }

            // Update the row count in the settings:
            //Properties.Settings.Default.rowcount++;

            // If the number of rows reaches 6, disable the button:
            if (TableLayoutPanel.RowCount > 8) {
                addRowButton.Enabled = false;
            }

            MessageBox.Show(TableLayoutPanel.RowCount.ToString());

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            TableLayoutPanel.RowCount--;

            // Remove the last row (the 3 last controls - , TextBox, TextBox, CheckBox):
            TableLayoutPanel.Controls.RemoveAt(/*Properties.Settings.Default.rowcount*/ TableLayoutPanel.RowCount * 3 - 1);
            TableLayoutPanel.Controls.RemoveAt(/*Properties.Settings.Default.rowcount*/ TableLayoutPanel.RowCount * 3 - 2);
            TableLayoutPanel.Controls.RemoveAt(/*Properties.Settings.Default.rowcount*/ TableLayoutPanel.RowCount * 3 - 3);

            // Update the row count in the settings:
            //Properties.Settings.Default.rowcount--;
            TableLayoutPanel.RowCount--;

            MessageBox.Show(TableLayoutPanel.RowCount.ToString());

            // Check if the button should be disabled (the total row count is below 4 - one login row)
            RemoveRowButtonStatusCheck();

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }


        private void RemoveRowButtonStatusCheck() {
            if (TableLayoutPanel.RowCount < 4) {
                removeRowButton.Enabled = false;
            }
        }

        /* APPLICATION EXIT */

        /**
         * Handler for performing actions when the application quits.
         */
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                /*SetStatus("Closing and tidying up...");
                try {
                    if (instances.Count > 0)
                        killChromeProcesses();
                }
                catch (NullReferenceException) { }*/
                SaveEntries();
                Dispose(true);
                Application.ExitThread();
            }
            else {
                e.Cancel = true;
            }
        }

        /**
         * Quit confirmation dialog.
         */
        private DialogResult PreClosingConfirmation() {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "Do you want to quit?",
                "Quit Chrome Multiple Logins", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        /**
        * Save the data in the text fields to the application.settings file.
        */
        private void SaveEntries() {
            //Properties.Settings.Default.lasturl = addr1Textbox.Text;

            // Clear the existing collection of usernames/passwords:
            // If the users StringCollection exists, just clear it of all contents. If it doesn't exist, create it.
            /*if (Properties.Settings.Default.users != null) {
                Properties.Settings.Default.users.Clear();
            }
            else {
                Properties.Settings.Default.users = new System.Collections.Specialized.StringCollection();
            }*/

            // Save the contents of the username/password rows (including blank entries):
            /*for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                if (Properties.Settings.Default.users != null) {
                    Properties.Settings.Default.users.Add(loginsTable.GetControlFromPosition(0, i).Text);
                    Properties.Settings.Default.users.Add(loginsTable.GetControlFromPosition(1, i).Text);
                }
            }*/

            // For troubleshooting: Show a message box with the state of the users StringCollection (null or not):
            // ShowRowsAndEntries();
            //if (Properties.Settings.Default.users == null)
            //    ShowMessageBox("NULL");
            //if (Properties.Settings.Default.users != null)
            //    ShowMessageBox("NOT NULL");

            // Save the settings file:
            Properties.Settings.Default.Save();
        }

        /**
         * Show the stored row count and number of usernames/passwords in the Properties.Settings.Default file.
         */
        private void ShowRowsAndEntries() {
            //SetStatus("Stored row count: " + Properties.Settings.Default.rowcount.ToString());

            //if (Properties.Settings.Default.users != null)
            //AppendStatus(" Stored u/p count: " + Properties.Settings.Default.users.Count.ToString());
            //else
            //AppendStatus(" No stored u/p");
        }
    }
}
