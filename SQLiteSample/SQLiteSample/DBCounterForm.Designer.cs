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
            this.UpdateDBBt = new System.Windows.Forms.Button();
            this.CountLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateDBBt
            // 
            this.UpdateDBBt.Location = new System.Drawing.Point(146, 124);
            this.UpdateDBBt.Name = "UpdateDBBt";
            this.UpdateDBBt.Size = new System.Drawing.Size(417, 34);
            this.UpdateDBBt.TabIndex = 0;
            this.UpdateDBBt.Text = "Update Database";
            this.UpdateDBBt.UseVisualStyleBackColor = true;
            // 
            // CountLb
            // 
            this.CountLb.AutoSize = true;
            this.CountLb.Location = new System.Drawing.Point(303, 79);
            this.CountLb.Name = "CountLb";
            this.CountLb.Size = new System.Drawing.Size(79, 25);
            this.CountLb.TabIndex = 1;
            this.CountLb.Text = "Count: 0";
            // 
            // DBCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 214);
            this.Controls.Add(this.CountLb);
            this.Controls.Add(this.UpdateDBBt);
            this.Name = "DBCounter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateDBBt;
        private Label CountLb;
    }
}