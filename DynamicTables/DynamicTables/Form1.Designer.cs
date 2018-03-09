namespace DynamicTables {
    partial class Form1 {
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
            this.bttnPrevious = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.page1RowCountLbl = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.extRemoveRowBttn = new MetroFramework.Controls.MetroButton();
            this.extAddRowBttn = new MetroFramework.Controls.MetroButton();
            this.page1label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.page2label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnPrevious
            // 
            this.bttnPrevious.Location = new System.Drawing.Point(402, 40);
            this.bttnPrevious.Name = "bttnPrevious";
            this.bttnPrevious.Size = new System.Drawing.Size(75, 23);
            this.bttnPrevious.TabIndex = 0;
            this.bttnPrevious.Text = "Previous";
            this.bttnPrevious.UseVisualStyleBackColor = true;
            this.bttnPrevious.Click += new System.EventHandler(this.bttnPrevious_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Location = new System.Drawing.Point(490, 40);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(75, 23);
            this.bttnNext.TabIndex = 1;
            this.bttnNext.Text = "Next";
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.page1RowCountLbl);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.extRemoveRowBttn);
            this.panel1.Controls.Add(this.extAddRowBttn);
            this.panel1.Controls.Add(this.page1label);
            this.panel1.Location = new System.Drawing.Point(40, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 515);
            this.panel1.TabIndex = 2;
            // 
            // page1RowCountLbl
            // 
            this.page1RowCountLbl.FontSize = MetroFramework.MetroLabelSize.Small;
            this.page1RowCountLbl.Location = new System.Drawing.Point(299, 46);
            this.page1RowCountLbl.Name = "page1RowCountLbl";
            this.page1RowCountLbl.Size = new System.Drawing.Size(199, 20);
            this.page1RowCountLbl.TabIndex = 4;
            this.page1RowCountLbl.Text = "metroLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // extRemoveRowBttn
            // 
            this.extRemoveRowBttn.Location = new System.Drawing.Point(408, 15);
            this.extRemoveRowBttn.Name = "extRemoveRowBttn";
            this.extRemoveRowBttn.Size = new System.Drawing.Size(90, 23);
            this.extRemoveRowBttn.TabIndex = 2;
            this.extRemoveRowBttn.Text = "Remove Row";
            this.extRemoveRowBttn.Click += new System.EventHandler(this.extRemoveBttn_Click);
            // 
            // extAddRowBttn
            // 
            this.extAddRowBttn.Location = new System.Drawing.Point(299, 15);
            this.extAddRowBttn.Name = "extAddRowBttn";
            this.extAddRowBttn.Size = new System.Drawing.Size(90, 23);
            this.extAddRowBttn.TabIndex = 1;
            this.extAddRowBttn.Text = "Add Row";
            this.extAddRowBttn.Click += new System.EventHandler(this.extAddRowBttn_Click);
            // 
            // page1label
            // 
            this.page1label.AutoSize = true;
            this.page1label.Location = new System.Drawing.Point(20, 15);
            this.page1label.Name = "page1label";
            this.page1label.Size = new System.Drawing.Size(219, 51);
            this.page1label.TabIndex = 0;
            this.page1label.Text = "Example 1: \r\nExternal buttons adding/removing\r\nrows in a TableLayoutPanel";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.page2label);
            this.panel2.Location = new System.Drawing.Point(40, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 515);
            this.panel2.TabIndex = 3;
            // 
            // page2label
            // 
            this.page2label.AutoSize = true;
            this.page2label.Location = new System.Drawing.Point(20, 15);
            this.page2label.Name = "page2label";
            this.page2label.Size = new System.Drawing.Size(53, 17);
            this.page2label.TabIndex = 0;
            this.page2label.Text = "Page 2\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnNext);
            this.Controls.Add(this.bttnPrevious);
            this.Name = "Form1";
            this.Text = "Dynamic Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPrevious;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label table1label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label page2label;
        private System.Windows.Forms.Label page1label;
        private MetroFramework.Controls.MetroButton extAddRowBttn;
        private MetroFramework.Controls.MetroButton extRemoveRowBttn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel page1RowCountLbl;
    }
}

