
namespace My_Tip_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoofPeople = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttipperperson = new System.Windows.Forms.Label();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(49, 79);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(125, 27);
            this.txtBill.TabIndex = 1;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip";
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(49, 177);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(125, 27);
            this.txttip.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(473, 174);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(147, 29);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate Total";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(529, 260);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(15, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "-";
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Per Person";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(253, 367);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(50, 20);
            this.errorMessage.TabIndex = 7;
            this.errorMessage.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Of People";
            // 
            // NoofPeople
            // 
            this.NoofPeople.Location = new System.Drawing.Point(49, 319);
            this.NoofPeople.Name = "NoofPeople";
            this.NoofPeople.Size = new System.Drawing.Size(125, 27);
            this.NoofPeople.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tip per person";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txttipperperson
            // 
            this.txttipperperson.AutoSize = true;
            this.txttipperperson.Location = new System.Drawing.Point(575, 86);
            this.txttipperperson.Name = "txttipperperson";
            this.txttipperperson.Size = new System.Drawing.Size(15, 20);
            this.txttipperperson.TabIndex = 11;
            this.txttipperperson.Text = "-";
            this.txttipperperson.Click += new System.EventHandler(this.txttipperperson_Click);
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.Location = new System.Drawing.Point(427, 24);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(228, 29);
            this.calcTipBtn.TabIndex = 12;
            this.calcTipBtn.Text = "Calculate Tip(Per Person)";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            this.calcTipBtn.Click += new System.EventHandler(this.calcTipBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.txttipperperson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoofPeople);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoofPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txttipperperson;
        private System.Windows.Forms.Button calcTipBtn;
    }
}

