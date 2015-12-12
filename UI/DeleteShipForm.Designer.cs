namespace UI
{
    partial class DeleteShipForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteShipForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delErrorLabel = new System.Windows.Forms.Label();
            this.CancelButtonDel = new System.Windows.Forms.Button();
            this.OkButtonDel = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delErrorLabel);
            this.groupBox1.Controls.Add(this.CancelButtonDel);
            this.groupBox1.Controls.Add(this.OkButtonDel);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Укажите ID корабля";
            // 
            // delErrorLabel
            // 
            this.delErrorLabel.AutoSize = true;
            this.delErrorLabel.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.delErrorLabel.Location = new System.Drawing.Point(87, 27);
            this.delErrorLabel.Name = "delErrorLabel";
            this.delErrorLabel.Size = new System.Drawing.Size(0, 14);
            this.delErrorLabel.TabIndex = 4;
            // 
            // CancelButtonDel
            // 
            this.CancelButtonDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonDel.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.CancelButtonDel.Location = new System.Drawing.Point(179, 73);
            this.CancelButtonDel.Name = "CancelButtonDel";
            this.CancelButtonDel.Size = new System.Drawing.Size(75, 23);
            this.CancelButtonDel.TabIndex = 3;
            this.CancelButtonDel.Text = "ОТМЕНА";
            this.CancelButtonDel.UseVisualStyleBackColor = true;
            this.CancelButtonDel.Click += new System.EventHandler(this.CancelButtonDel_Click);
            // 
            // OkButtonDel
            // 
            this.OkButtonDel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButtonDel.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.OkButtonDel.Location = new System.Drawing.Point(11, 73);
            this.OkButtonDel.Name = "OkButtonDel";
            this.OkButtonDel.Size = new System.Drawing.Size(53, 23);
            this.OkButtonDel.TabIndex = 2;
            this.OkButtonDel.Text = "OK";
            this.OkButtonDel.UseVisualStyleBackColor = true;
            this.OkButtonDel.Click += new System.EventHandler(this.OkButtonDel_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(39, 24);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(42, 26);
            this.IdTextBox.TabIndex = 1;
            this.IdTextBox.Click += new System.EventHandler(this.IdTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeleteShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление корабля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteShipForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButtonDel;
        private System.Windows.Forms.Button CancelButtonDel;
        private System.Windows.Forms.Label delErrorLabel;


    }
}