﻿namespace DynamicTable2 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.extAddRowButton = new MetroFramework.Controls.MetroButton();
            this.extRemoveRowButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // extAddRowButton
            // 
            this.extAddRowButton.Location = new System.Drawing.Point(391, 26);
            this.extAddRowButton.Name = "extAddRowButton";
            this.extAddRowButton.Size = new System.Drawing.Size(85, 23);
            this.extAddRowButton.TabIndex = 0;
            this.extAddRowButton.Text = "Add Row";
            this.extAddRowButton.Click += new System.EventHandler(this.extAddRowButton_Click);
            // 
            // extRemoveRowButton
            // 
            this.extRemoveRowButton.Location = new System.Drawing.Point(498, 26);
            this.extRemoveRowButton.Name = "extRemoveRowButton";
            this.extRemoveRowButton.Size = new System.Drawing.Size(85, 23);
            this.extRemoveRowButton.TabIndex = 1;
            this.extRemoveRowButton.Text = "Remove Row";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(4, 2);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(329, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Example 1: 3 row autosize table directly in the frame";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 446);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.extRemoveRowButton);
            this.Controls.Add(this.extAddRowButton);
            this.Name = "MainForm";
            this.Text = "Dynamic Table 2 (MetroFramework)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton extAddRowButton;
        private MetroFramework.Controls.MetroButton extRemoveRowButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
