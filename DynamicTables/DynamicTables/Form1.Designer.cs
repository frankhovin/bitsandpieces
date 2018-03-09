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
            this.page1label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.extAddRowBttn = new MetroFramework.Controls.MetroButton();
            this.page2label = new System.Windows.Forms.Label();
            this.extRemoveBttn = new MetroFramework.Controls.MetroButton();
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
            this.panel1.Controls.Add(this.extRemoveBttn);
            this.panel1.Controls.Add(this.extAddRowBttn);
            this.panel1.Controls.Add(this.page1label);
            this.panel1.Location = new System.Drawing.Point(40, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 515);
            this.panel1.TabIndex = 2;
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
            // extAddRowBttn
            // 
            this.extAddRowBttn.Location = new System.Drawing.Point(299, 15);
            this.extAddRowBttn.Name = "extAddRowBttn";
            this.extAddRowBttn.Size = new System.Drawing.Size(90, 23);
            this.extAddRowBttn.TabIndex = 1;
            this.extAddRowBttn.Text = "Add Row";
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
            // extRemoveBttn
            // 
            this.extRemoveBttn.Location = new System.Drawing.Point(408, 15);
            this.extRemoveBttn.Name = "extRemoveBttn";
            this.extRemoveBttn.Size = new System.Drawing.Size(90, 23);
            this.extRemoveBttn.TabIndex = 2;
            this.extRemoveBttn.Text = "Remove Row";
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
        private MetroFramework.Controls.MetroButton extRemoveBttn;
    }
}

