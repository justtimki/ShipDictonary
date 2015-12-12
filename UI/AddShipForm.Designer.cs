namespace UI
{
    partial class AddShipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShipForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKBbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.displacementTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.displacementLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addErrorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OKBbutton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.displacementTextBox);
            this.groupBox1.Controls.Add(this.typeTextBox);
            this.groupBox1.Controls.Add(this.countryLabel);
            this.groupBox1.Controls.Add(this.displacementLabel);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные о корабле";
            // 
            // OKBbutton
            // 
            this.OKBbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBbutton.Location = new System.Drawing.Point(6, 179);
            this.OKBbutton.Name = "OKBbutton";
            this.OKBbutton.Size = new System.Drawing.Size(75, 23);
            this.OKBbutton.TabIndex = 0;
            this.OKBbutton.Text = "ОК";
            this.OKBbutton.UseVisualStyleBackColor = true;
            this.OKBbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(178, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "ОТМЕНА";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTextBox.Location = new System.Drawing.Point(140, 145);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(113, 22);
            this.countryTextBox.TabIndex = 7;
            this.countryTextBox.Click += new System.EventHandler(this.countryTextBox_Click);
            // 
            // displacementTextBox
            // 
            this.displacementTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displacementTextBox.Location = new System.Drawing.Point(140, 95);
            this.displacementTextBox.Name = "displacementTextBox";
            this.displacementTextBox.Size = new System.Drawing.Size(113, 22);
            this.displacementTextBox.TabIndex = 6;
            this.displacementTextBox.Click += new System.EventHandler(this.displacementTextBox_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTextBox.Location = new System.Drawing.Point(100, 61);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(153, 22);
            this.typeTextBox.TabIndex = 5;
            this.typeTextBox.Click += new System.EventHandler(this.typeTextBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.countryLabel.Location = new System.Drawing.Point(6, 133);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(113, 34);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Страна-\r\nпроизводитель";
            // 
            // displacementLabel
            // 
            this.displacementLabel.AutoSize = true;
            this.displacementLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.displacementLabel.Location = new System.Drawing.Point(6, 96);
            this.displacementLabel.Name = "displacementLabel";
            this.displacementLabel.Size = new System.Drawing.Size(122, 17);
            this.displacementLabel.TabIndex = 3;
            this.displacementLabel.Text = "Водоизмещение";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.typeLabel.Location = new System.Drawing.Point(6, 61);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(36, 17);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Тип";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(6, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(100, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            // 
            // addErrorLabel
            // 
            this.addErrorLabel.AutoSize = true;
            this.addErrorLabel.Location = new System.Drawing.Point(13, 227);
            this.addErrorLabel.Name = "addErrorLabel";
            this.addErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.addErrorLabel.TabIndex = 1;
            // 
            // AddShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addErrorLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый корабль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddShipForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OKBbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label displacementLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox displacementTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label addErrorLabel;
    }
}