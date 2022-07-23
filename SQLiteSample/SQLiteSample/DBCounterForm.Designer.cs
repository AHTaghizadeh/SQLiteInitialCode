namespace SQLiteSample
{
    partial class DBCounterForm
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
            this.RandomBt = new System.Windows.Forms.Button();
            this.CountLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RandomBt
            // 
            this.RandomBt.Location = new System.Drawing.Point(23, 64);
            this.RandomBt.Name = "RandomBt";
            this.RandomBt.Size = new System.Drawing.Size(417, 34);
            this.RandomBt.TabIndex = 0;
            this.RandomBt.Text = "Create Random";
            this.RandomBt.UseVisualStyleBackColor = true;
            this.RandomBt.Click += new System.EventHandler(this.UpdateDBBt_Click);
            // 
            // CountLb
            // 
            this.CountLb.AutoSize = true;
            this.CountLb.Location = new System.Drawing.Point(23, 25);
            this.CountLb.Name = "CountLb";
            this.CountLb.Size = new System.Drawing.Size(79, 25);
            this.CountLb.TabIndex = 1;
            this.CountLb.Text = "Count: 0";
            // 
            // DBCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 119);
            this.Controls.Add(this.CountLb);
            this.Controls.Add(this.RandomBt);
            this.Name = "DBCounterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RandomBt;
        private Label CountLb;
    }
}