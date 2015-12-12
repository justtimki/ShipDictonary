namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addShipButtonMemory = new System.Windows.Forms.Button();
            this.outputForMemory = new System.Windows.Forms.TextBox();
            this.showButtonMemory = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.memoryTabPage = new System.Windows.Forms.TabPage();
            this.nameRadio = new System.Windows.Forms.RadioButton();
            this.typeRadio = new System.Windows.Forms.RadioButton();
            this.displacementRadio = new System.Windows.Forms.RadioButton();
            this.sortButtonMemory = new System.Windows.Forms.Button();
            this.DeleteButtonMemory = new System.Windows.Forms.Button();
            this.infoLabelMem = new System.Windows.Forms.Label();
            this.TextfileTabPage2 = new System.Windows.Forms.TabPage();
            this.nameRadioFile = new System.Windows.Forms.RadioButton();
            this.typeRadioFile = new System.Windows.Forms.RadioButton();
            this.displacementRadioFile = new System.Windows.Forms.RadioButton();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.sortButtonFile = new System.Windows.Forms.Button();
            this.DeleteButtonText = new System.Windows.Forms.Button();
            this.infoLabelFile = new System.Windows.Forms.Label();
            this.addShipButtonFile = new System.Windows.Forms.Button();
            this.showButtonFile = new System.Windows.Forms.Button();
            this.outputForFile = new System.Windows.Forms.TextBox();
            this.binaryFileTabPage3 = new System.Windows.Forms.TabPage();
            this.nameRadioBinary = new System.Windows.Forms.RadioButton();
            this.typeRadioBinary = new System.Windows.Forms.RadioButton();
            this.displacementRadioBinary = new System.Windows.Forms.RadioButton();
            this.binaryChoseFileButton = new System.Windows.Forms.Button();
            this.binarySortButton = new System.Windows.Forms.Button();
            this.binaryDeleteButton = new System.Windows.Forms.Button();
            this.binaryInfoLabel = new System.Windows.Forms.Label();
            this.binaryAddButton = new System.Windows.Forms.Button();
            this.showButtonBinary = new System.Windows.Forms.Button();
            this.outputForBinary = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxMemory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterMem = new System.Windows.Forms.TextBox();
            this.textBoxFilterFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.textBoxFilterBin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBin = new System.Windows.Forms.ComboBox();
            this.buttonFilterMem = new System.Windows.Forms.Button();
            this.buttonFilterFile = new System.Windows.Forms.Button();
            this.buttonFilterBin = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.memoryTabPage.SuspendLayout();
            this.TextfileTabPage2.SuspendLayout();
            this.binaryFileTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addShipButtonMemory
            // 
            this.addShipButtonMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addShipButtonMemory.Location = new System.Drawing.Point(649, 297);
            this.addShipButtonMemory.Name = "addShipButtonMemory";
            this.addShipButtonMemory.Size = new System.Drawing.Size(119, 23);
            this.addShipButtonMemory.TabIndex = 1;
            this.addShipButtonMemory.Text = "Добавить корабль";
            this.addShipButtonMemory.UseVisualStyleBackColor = true;
            this.addShipButtonMemory.Click += new System.EventHandler(this.addShipButtonMemory_Click);
            // 
            // outputForMemory
            // 
            this.outputForMemory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputForMemory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputForMemory.ForeColor = System.Drawing.Color.White;
            this.outputForMemory.Location = new System.Drawing.Point(6, 6);
            this.outputForMemory.Multiline = true;
            this.outputForMemory.Name = "outputForMemory";
            this.outputForMemory.ReadOnly = true;
            this.outputForMemory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputForMemory.Size = new System.Drawing.Size(762, 256);
            this.outputForMemory.TabIndex = 2;
            // 
            // showButtonMemory
            // 
            this.showButtonMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButtonMemory.Location = new System.Drawing.Point(649, 268);
            this.showButtonMemory.Name = "showButtonMemory";
            this.showButtonMemory.Size = new System.Drawing.Size(119, 23);
            this.showButtonMemory.TabIndex = 3;
            this.showButtonMemory.Text = "Обновить";
            this.showButtonMemory.UseVisualStyleBackColor = true;
            this.showButtonMemory.Click += new System.EventHandler(this.showButtonMemory_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.memoryTabPage);
            this.tabs.Controls.Add(this.TextfileTabPage2);
            this.tabs.Controls.Add(this.binaryFileTabPage3);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabs.HotTrack = true;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(784, 377);
            this.tabs.TabIndex = 4;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // memoryTabPage
            // 
            this.memoryTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.memoryTabPage.Controls.Add(this.buttonFilterMem);
            this.memoryTabPage.Controls.Add(this.textBoxFilterMem);
            this.memoryTabPage.Controls.Add(this.label1);
            this.memoryTabPage.Controls.Add(this.comboBoxMemory);
            this.memoryTabPage.Controls.Add(this.nameRadio);
            this.memoryTabPage.Controls.Add(this.typeRadio);
            this.memoryTabPage.Controls.Add(this.displacementRadio);
            this.memoryTabPage.Controls.Add(this.sortButtonMemory);
            this.memoryTabPage.Controls.Add(this.DeleteButtonMemory);
            this.memoryTabPage.Controls.Add(this.infoLabelMem);
            this.memoryTabPage.Controls.Add(this.outputForMemory);
            this.memoryTabPage.Controls.Add(this.addShipButtonMemory);
            this.memoryTabPage.Controls.Add(this.showButtonMemory);
            this.memoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.memoryTabPage.Name = "memoryTabPage";
            this.memoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.memoryTabPage.Size = new System.Drawing.Size(776, 351);
            this.memoryTabPage.TabIndex = 0;
            this.memoryTabPage.Text = "Память";
            // 
            // nameRadio
            // 
            this.nameRadio.AutoSize = true;
            this.nameRadio.Location = new System.Drawing.Point(129, 321);
            this.nameRadio.Name = "nameRadio";
            this.nameRadio.Size = new System.Drawing.Size(47, 17);
            this.nameRadio.TabIndex = 9;
            this.nameRadio.TabStop = true;
            this.nameRadio.Text = "Имя";
            this.nameRadio.UseVisualStyleBackColor = true;
            this.nameRadio.CheckedChanged += new System.EventHandler(this.nameRadio_CheckedChanged);
            // 
            // typeRadio
            // 
            this.typeRadio.AutoSize = true;
            this.typeRadio.Location = new System.Drawing.Point(129, 297);
            this.typeRadio.Name = "typeRadio";
            this.typeRadio.Size = new System.Drawing.Size(44, 17);
            this.typeRadio.TabIndex = 8;
            this.typeRadio.TabStop = true;
            this.typeRadio.Text = "Тип";
            this.typeRadio.UseVisualStyleBackColor = true;
            this.typeRadio.CheckedChanged += new System.EventHandler(this.typeRadio_CheckedChanged);
            // 
            // displacementRadio
            // 
            this.displacementRadio.AutoSize = true;
            this.displacementRadio.Location = new System.Drawing.Point(129, 273);
            this.displacementRadio.Name = "displacementRadio";
            this.displacementRadio.Size = new System.Drawing.Size(109, 17);
            this.displacementRadio.TabIndex = 7;
            this.displacementRadio.TabStop = true;
            this.displacementRadio.Text = "Водоизмещение";
            this.displacementRadio.UseVisualStyleBackColor = true;
            this.displacementRadio.CheckedChanged += new System.EventHandler(this.displacementRadio_CheckedChanged);
            // 
            // sortButtonMemory
            // 
            this.sortButtonMemory.Location = new System.Drawing.Point(12, 267);
            this.sortButtonMemory.Name = "sortButtonMemory";
            this.sortButtonMemory.Size = new System.Drawing.Size(97, 24);
            this.sortButtonMemory.TabIndex = 6;
            this.sortButtonMemory.Text = "Отсортировать";
            this.sortButtonMemory.UseVisualStyleBackColor = true;
            this.sortButtonMemory.Click += new System.EventHandler(this.sortButtonMemory_Click);
            // 
            // DeleteButtonMemory
            // 
            this.DeleteButtonMemory.Location = new System.Drawing.Point(649, 325);
            this.DeleteButtonMemory.Name = "DeleteButtonMemory";
            this.DeleteButtonMemory.Size = new System.Drawing.Size(119, 23);
            this.DeleteButtonMemory.TabIndex = 5;
            this.DeleteButtonMemory.Text = "Удалить корабль";
            this.DeleteButtonMemory.UseVisualStyleBackColor = true;
            this.DeleteButtonMemory.Click += new System.EventHandler(this.DeleteButtonMemory_Click);
            // 
            // infoLabelMem
            // 
            this.infoLabelMem.AutoSize = true;
            this.infoLabelMem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoLabelMem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabelMem.ForeColor = System.Drawing.Color.White;
            this.infoLabelMem.Location = new System.Drawing.Point(8, 19);
            this.infoLabelMem.Name = "infoLabelMem";
            this.infoLabelMem.Size = new System.Drawing.Size(281, 19);
            this.infoLabelMem.TabIndex = 4;
            this.infoLabelMem.Text = "Здесь будет информация о кораблях...";
            // 
            // TextfileTabPage2
            // 
            this.TextfileTabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.TextfileTabPage2.Controls.Add(this.buttonFilterFile);
            this.TextfileTabPage2.Controls.Add(this.textBoxFilterFile);
            this.TextfileTabPage2.Controls.Add(this.label2);
            this.TextfileTabPage2.Controls.Add(this.comboBoxFile);
            this.TextfileTabPage2.Controls.Add(this.nameRadioFile);
            this.TextfileTabPage2.Controls.Add(this.typeRadioFile);
            this.TextfileTabPage2.Controls.Add(this.displacementRadioFile);
            this.TextfileTabPage2.Controls.Add(this.chooseFileButton);
            this.TextfileTabPage2.Controls.Add(this.sortButtonFile);
            this.TextfileTabPage2.Controls.Add(this.DeleteButtonText);
            this.TextfileTabPage2.Controls.Add(this.infoLabelFile);
            this.TextfileTabPage2.Controls.Add(this.addShipButtonFile);
            this.TextfileTabPage2.Controls.Add(this.showButtonFile);
            this.TextfileTabPage2.Controls.Add(this.outputForFile);
            this.TextfileTabPage2.Location = new System.Drawing.Point(4, 22);
            this.TextfileTabPage2.Name = "TextfileTabPage2";
            this.TextfileTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TextfileTabPage2.Size = new System.Drawing.Size(776, 351);
            this.TextfileTabPage2.TabIndex = 1;
            this.TextfileTabPage2.Text = "Файл .csv";
            // 
            // nameRadioFile
            // 
            this.nameRadioFile.AutoSize = true;
            this.nameRadioFile.Location = new System.Drawing.Point(129, 321);
            this.nameRadioFile.Name = "nameRadioFile";
            this.nameRadioFile.Size = new System.Drawing.Size(47, 17);
            this.nameRadioFile.TabIndex = 15;
            this.nameRadioFile.TabStop = true;
            this.nameRadioFile.Text = "Имя";
            this.nameRadioFile.UseVisualStyleBackColor = true;
            this.nameRadioFile.CheckedChanged += new System.EventHandler(this.nameRadioFile_CheckedChanged);
            // 
            // typeRadioFile
            // 
            this.typeRadioFile.AutoSize = true;
            this.typeRadioFile.Location = new System.Drawing.Point(129, 297);
            this.typeRadioFile.Name = "typeRadioFile";
            this.typeRadioFile.Size = new System.Drawing.Size(44, 17);
            this.typeRadioFile.TabIndex = 14;
            this.typeRadioFile.TabStop = true;
            this.typeRadioFile.Text = "Тип";
            this.typeRadioFile.UseVisualStyleBackColor = true;
            this.typeRadioFile.CheckedChanged += new System.EventHandler(this.typeRadioFile_CheckedChanged);
            // 
            // displacementRadioFile
            // 
            this.displacementRadioFile.AutoSize = true;
            this.displacementRadioFile.Location = new System.Drawing.Point(129, 273);
            this.displacementRadioFile.Name = "displacementRadioFile";
            this.displacementRadioFile.Size = new System.Drawing.Size(109, 17);
            this.displacementRadioFile.TabIndex = 13;
            this.displacementRadioFile.TabStop = true;
            this.displacementRadioFile.Text = "Водоизмещение";
            this.displacementRadioFile.UseVisualStyleBackColor = true;
            this.displacementRadioFile.CheckedChanged += new System.EventHandler(this.displacementRadioFile_CheckedChanged);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(338, 267);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(115, 23);
            this.chooseFileButton.TabIndex = 12;
            this.chooseFileButton.Text = "Выбрать файл...";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // sortButtonFile
            // 
            this.sortButtonFile.Location = new System.Drawing.Point(12, 267);
            this.sortButtonFile.Name = "sortButtonFile";
            this.sortButtonFile.Size = new System.Drawing.Size(97, 24);
            this.sortButtonFile.TabIndex = 8;
            this.sortButtonFile.Text = "Отсортировать";
            this.sortButtonFile.UseVisualStyleBackColor = true;
            this.sortButtonFile.Click += new System.EventHandler(this.sortButtonFile_Click);
            // 
            // DeleteButtonText
            // 
            this.DeleteButtonText.Location = new System.Drawing.Point(649, 325);
            this.DeleteButtonText.Name = "DeleteButtonText";
            this.DeleteButtonText.Size = new System.Drawing.Size(119, 23);
            this.DeleteButtonText.TabIndex = 7;
            this.DeleteButtonText.Text = "Удалить корабль";
            this.DeleteButtonText.UseVisualStyleBackColor = true;
            this.DeleteButtonText.Click += new System.EventHandler(this.DeleteButtonText_Click);
            // 
            // infoLabelFile
            // 
            this.infoLabelFile.AutoSize = true;
            this.infoLabelFile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoLabelFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabelFile.ForeColor = System.Drawing.Color.White;
            this.infoLabelFile.Location = new System.Drawing.Point(8, 19);
            this.infoLabelFile.Name = "infoLabelFile";
            this.infoLabelFile.Size = new System.Drawing.Size(281, 19);
            this.infoLabelFile.TabIndex = 6;
            this.infoLabelFile.Text = "Здесь будет информация о кораблях...";
            // 
            // addShipButtonFile
            // 
            this.addShipButtonFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addShipButtonFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addShipButtonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addShipButtonFile.Location = new System.Drawing.Point(649, 297);
            this.addShipButtonFile.Name = "addShipButtonFile";
            this.addShipButtonFile.Size = new System.Drawing.Size(119, 23);
            this.addShipButtonFile.TabIndex = 4;
            this.addShipButtonFile.Text = "Добавить корабль";
            this.addShipButtonFile.UseVisualStyleBackColor = true;
            this.addShipButtonFile.Click += new System.EventHandler(this.addShipButtonFile_Click);
            // 
            // showButtonFile
            // 
            this.showButtonFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showButtonFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.showButtonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButtonFile.ForeColor = System.Drawing.Color.Black;
            this.showButtonFile.Location = new System.Drawing.Point(649, 268);
            this.showButtonFile.Name = "showButtonFile";
            this.showButtonFile.Size = new System.Drawing.Size(119, 23);
            this.showButtonFile.TabIndex = 5;
            this.showButtonFile.Text = "Обновить";
            this.showButtonFile.UseVisualStyleBackColor = true;
            this.showButtonFile.Click += new System.EventHandler(this.showButtonFile_Click);
            // 
            // outputForFile
            // 
            this.outputForFile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputForFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputForFile.ForeColor = System.Drawing.Color.White;
            this.outputForFile.Location = new System.Drawing.Point(6, 6);
            this.outputForFile.Multiline = true;
            this.outputForFile.Name = "outputForFile";
            this.outputForFile.ReadOnly = true;
            this.outputForFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputForFile.Size = new System.Drawing.Size(762, 256);
            this.outputForFile.TabIndex = 3;
            // 
            // binaryFileTabPage3
            // 
            this.binaryFileTabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.binaryFileTabPage3.Controls.Add(this.buttonFilterBin);
            this.binaryFileTabPage3.Controls.Add(this.textBoxFilterBin);
            this.binaryFileTabPage3.Controls.Add(this.label3);
            this.binaryFileTabPage3.Controls.Add(this.comboBoxBin);
            this.binaryFileTabPage3.Controls.Add(this.nameRadioBinary);
            this.binaryFileTabPage3.Controls.Add(this.typeRadioBinary);
            this.binaryFileTabPage3.Controls.Add(this.displacementRadioBinary);
            this.binaryFileTabPage3.Controls.Add(this.binaryChoseFileButton);
            this.binaryFileTabPage3.Controls.Add(this.binarySortButton);
            this.binaryFileTabPage3.Controls.Add(this.binaryDeleteButton);
            this.binaryFileTabPage3.Controls.Add(this.binaryInfoLabel);
            this.binaryFileTabPage3.Controls.Add(this.binaryAddButton);
            this.binaryFileTabPage3.Controls.Add(this.showButtonBinary);
            this.binaryFileTabPage3.Controls.Add(this.outputForBinary);
            this.binaryFileTabPage3.Location = new System.Drawing.Point(4, 22);
            this.binaryFileTabPage3.Name = "binaryFileTabPage3";
            this.binaryFileTabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.binaryFileTabPage3.Size = new System.Drawing.Size(776, 351);
            this.binaryFileTabPage3.TabIndex = 3;
            this.binaryFileTabPage3.Text = "Бинарный файл";
            // 
            // nameRadioBinary
            // 
            this.nameRadioBinary.AutoSize = true;
            this.nameRadioBinary.Location = new System.Drawing.Point(129, 321);
            this.nameRadioBinary.Name = "nameRadioBinary";
            this.nameRadioBinary.Size = new System.Drawing.Size(47, 17);
            this.nameRadioBinary.TabIndex = 18;
            this.nameRadioBinary.TabStop = true;
            this.nameRadioBinary.Text = "Имя";
            this.nameRadioBinary.UseVisualStyleBackColor = true;
            this.nameRadioBinary.CheckedChanged += new System.EventHandler(this.nameRadioBinary_CheckedChanged);
            // 
            // typeRadioBinary
            // 
            this.typeRadioBinary.AutoSize = true;
            this.typeRadioBinary.Location = new System.Drawing.Point(129, 297);
            this.typeRadioBinary.Name = "typeRadioBinary";
            this.typeRadioBinary.Size = new System.Drawing.Size(44, 17);
            this.typeRadioBinary.TabIndex = 17;
            this.typeRadioBinary.TabStop = true;
            this.typeRadioBinary.Text = "Тип";
            this.typeRadioBinary.UseVisualStyleBackColor = true;
            this.typeRadioBinary.CheckedChanged += new System.EventHandler(this.typeRadioBinary_CheckedChanged);
            // 
            // displacementRadioBinary
            // 
            this.displacementRadioBinary.AutoSize = true;
            this.displacementRadioBinary.Location = new System.Drawing.Point(129, 273);
            this.displacementRadioBinary.Name = "displacementRadioBinary";
            this.displacementRadioBinary.Size = new System.Drawing.Size(109, 17);
            this.displacementRadioBinary.TabIndex = 16;
            this.displacementRadioBinary.TabStop = true;
            this.displacementRadioBinary.Text = "Водоизмещение";
            this.displacementRadioBinary.UseVisualStyleBackColor = true;
            this.displacementRadioBinary.CheckedChanged += new System.EventHandler(this.displacementRadioBinary_CheckedChanged);
            // 
            // binaryChoseFileButton
            // 
            this.binaryChoseFileButton.Location = new System.Drawing.Point(338, 267);
            this.binaryChoseFileButton.Name = "binaryChoseFileButton";
            this.binaryChoseFileButton.Size = new System.Drawing.Size(115, 23);
            this.binaryChoseFileButton.TabIndex = 12;
            this.binaryChoseFileButton.Text = "Выбрать файл...";
            this.binaryChoseFileButton.UseVisualStyleBackColor = true;
            this.binaryChoseFileButton.Click += new System.EventHandler(this.binaryChoseFileButton_Click);
            // 
            // binarySortButton
            // 
            this.binarySortButton.Location = new System.Drawing.Point(12, 267);
            this.binarySortButton.Name = "binarySortButton";
            this.binarySortButton.Size = new System.Drawing.Size(97, 24);
            this.binarySortButton.TabIndex = 8;
            this.binarySortButton.Text = "Отсортировать";
            this.binarySortButton.UseVisualStyleBackColor = true;
            this.binarySortButton.Click += new System.EventHandler(this.binarySortButton_Click);
            // 
            // binaryDeleteButton
            // 
            this.binaryDeleteButton.Location = new System.Drawing.Point(649, 325);
            this.binaryDeleteButton.Name = "binaryDeleteButton";
            this.binaryDeleteButton.Size = new System.Drawing.Size(119, 23);
            this.binaryDeleteButton.TabIndex = 7;
            this.binaryDeleteButton.Text = "Удалить корабль";
            this.binaryDeleteButton.UseVisualStyleBackColor = true;
            this.binaryDeleteButton.Click += new System.EventHandler(this.binaryDeleteButton_Click);
            // 
            // binaryInfoLabel
            // 
            this.binaryInfoLabel.AutoSize = true;
            this.binaryInfoLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.binaryInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binaryInfoLabel.ForeColor = System.Drawing.Color.White;
            this.binaryInfoLabel.Location = new System.Drawing.Point(8, 19);
            this.binaryInfoLabel.Name = "binaryInfoLabel";
            this.binaryInfoLabel.Size = new System.Drawing.Size(281, 19);
            this.binaryInfoLabel.TabIndex = 6;
            this.binaryInfoLabel.Text = "Здесь будет информация о кораблях...";
            // 
            // binaryAddButton
            // 
            this.binaryAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.binaryAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.binaryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binaryAddButton.Location = new System.Drawing.Point(649, 297);
            this.binaryAddButton.Name = "binaryAddButton";
            this.binaryAddButton.Size = new System.Drawing.Size(119, 23);
            this.binaryAddButton.TabIndex = 4;
            this.binaryAddButton.Text = "Добавить корабль";
            this.binaryAddButton.UseVisualStyleBackColor = true;
            this.binaryAddButton.Click += new System.EventHandler(this.binaryAddButton_Click);
            // 
            // showButtonBinary
            // 
            this.showButtonBinary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.showButtonBinary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.showButtonBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButtonBinary.ForeColor = System.Drawing.Color.Black;
            this.showButtonBinary.Location = new System.Drawing.Point(649, 268);
            this.showButtonBinary.Name = "showButtonBinary";
            this.showButtonBinary.Size = new System.Drawing.Size(119, 23);
            this.showButtonBinary.TabIndex = 5;
            this.showButtonBinary.Text = "Обновить";
            this.showButtonBinary.UseVisualStyleBackColor = true;
            this.showButtonBinary.Click += new System.EventHandler(this.showButtonBinary_Click);
            // 
            // outputForBinary
            // 
            this.outputForBinary.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.outputForBinary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputForBinary.ForeColor = System.Drawing.Color.White;
            this.outputForBinary.Location = new System.Drawing.Point(6, 6);
            this.outputForBinary.Multiline = true;
            this.outputForBinary.Name = "outputForBinary";
            this.outputForBinary.ReadOnly = true;
            this.outputForBinary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputForBinary.Size = new System.Drawing.Size(762, 256);
            this.outputForBinary.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxMemory
            // 
            this.comboBoxMemory.FormattingEnabled = true;
            this.comboBoxMemory.Items.AddRange(new object[] {
            "Имя",
            "Тип",
            "Водоизмещение",
            "Страна-производитель"});
            this.comboBoxMemory.Location = new System.Drawing.Point(274, 273);
            this.comboBoxMemory.Name = "comboBoxMemory";
            this.comboBoxMemory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMemory.TabIndex = 10;
            this.comboBoxMemory.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Критерий";
            // 
            // textBoxFilterMem
            // 
            this.textBoxFilterMem.Location = new System.Drawing.Point(462, 274);
            this.textBoxFilterMem.Name = "textBoxFilterMem";
            this.textBoxFilterMem.Size = new System.Drawing.Size(118, 20);
            this.textBoxFilterMem.TabIndex = 12;
            // 
            // textBoxFilterFile
            // 
            this.textBoxFilterFile.Location = new System.Drawing.Point(415, 300);
            this.textBoxFilterFile.Name = "textBoxFilterFile";
            this.textBoxFilterFile.Size = new System.Drawing.Size(118, 20);
            this.textBoxFilterFile.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Критерий";
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.FormattingEnabled = true;
            this.comboBoxFile.Items.AddRange(new object[] {
            "Имя",
            "Тип",
            "Водоизмещение",
            "Страна-производитель"});
            this.comboBoxFile.Location = new System.Drawing.Point(227, 299);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFile.TabIndex = 16;
            this.comboBoxFile.Text = "Имя";
            // 
            // textBoxFilterBin
            // 
            this.textBoxFilterBin.Location = new System.Drawing.Point(415, 300);
            this.textBoxFilterBin.Name = "textBoxFilterBin";
            this.textBoxFilterBin.Size = new System.Drawing.Size(118, 20);
            this.textBoxFilterBin.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Критерий";
            // 
            // comboBoxBin
            // 
            this.comboBoxBin.FormattingEnabled = true;
            this.comboBoxBin.Items.AddRange(new object[] {
            "Имя",
            "Тип",
            "Водоизмещение",
            "Страна-производитель"});
            this.comboBoxBin.Location = new System.Drawing.Point(227, 299);
            this.comboBoxBin.Name = "comboBoxBin";
            this.comboBoxBin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBin.TabIndex = 19;
            this.comboBoxBin.Text = "Имя";
            // 
            // buttonFilterMem
            // 
            this.buttonFilterMem.Location = new System.Drawing.Point(462, 300);
            this.buttonFilterMem.Name = "buttonFilterMem";
            this.buttonFilterMem.Size = new System.Drawing.Size(118, 23);
            this.buttonFilterMem.TabIndex = 13;
            this.buttonFilterMem.Text = "Применить фильтр";
            this.buttonFilterMem.UseVisualStyleBackColor = true;
            this.buttonFilterMem.Click += new System.EventHandler(this.buttonFilterMem_Click);
            // 
            // buttonFilterFile
            // 
            this.buttonFilterFile.Location = new System.Drawing.Point(415, 326);
            this.buttonFilterFile.Name = "buttonFilterFile";
            this.buttonFilterFile.Size = new System.Drawing.Size(118, 23);
            this.buttonFilterFile.TabIndex = 19;
            this.buttonFilterFile.Text = "Применить фильтр";
            this.buttonFilterFile.UseVisualStyleBackColor = true;
            this.buttonFilterFile.Click += new System.EventHandler(this.buttonFilterFile_Click);
            // 
            // buttonFilterBin
            // 
            this.buttonFilterBin.Location = new System.Drawing.Point(415, 326);
            this.buttonFilterBin.Name = "buttonFilterBin";
            this.buttonFilterBin.Size = new System.Drawing.Size(118, 23);
            this.buttonFilterBin.TabIndex = 22;
            this.buttonFilterBin.Text = "Применить фильтр";
            this.buttonFilterBin.UseVisualStyleBackColor = true;
            this.buttonFilterBin.Click += new System.EventHandler(this.buttonFilterBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.tabs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник кораблей";
            this.tabs.ResumeLayout(false);
            this.memoryTabPage.ResumeLayout(false);
            this.memoryTabPage.PerformLayout();
            this.TextfileTabPage2.ResumeLayout(false);
            this.TextfileTabPage2.PerformLayout();
            this.binaryFileTabPage3.ResumeLayout(false);
            this.binaryFileTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addShipButtonMemory;
        private System.Windows.Forms.TextBox outputForMemory;
        internal System.Windows.Forms.Button showButtonMemory;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage memoryTabPage;
        private System.Windows.Forms.TabPage TextfileTabPage2;
        private System.Windows.Forms.Button addShipButtonFile;
        internal System.Windows.Forms.Button showButtonFile;
        private System.Windows.Forms.TextBox outputForFile;
        private System.Windows.Forms.Label infoLabelMem;
        private System.Windows.Forms.Label infoLabelFile;
        private System.Windows.Forms.Button DeleteButtonMemory;
        private System.Windows.Forms.Button DeleteButtonText;
        private System.Windows.Forms.Button sortButtonMemory;
        private System.Windows.Forms.Button sortButtonFile;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage binaryFileTabPage3;
        private System.Windows.Forms.Button binaryChoseFileButton;
        private System.Windows.Forms.Button binarySortButton;
        private System.Windows.Forms.Button binaryDeleteButton;
        private System.Windows.Forms.Label binaryInfoLabel;
        private System.Windows.Forms.Button binaryAddButton;
        internal System.Windows.Forms.Button showButtonBinary;
        private System.Windows.Forms.TextBox outputForBinary;
        private System.Windows.Forms.RadioButton typeRadio;
        private System.Windows.Forms.RadioButton displacementRadio;
        private System.Windows.Forms.RadioButton nameRadio;
        private System.Windows.Forms.RadioButton nameRadioFile;
        private System.Windows.Forms.RadioButton typeRadioFile;
        private System.Windows.Forms.RadioButton displacementRadioFile;
        private System.Windows.Forms.RadioButton nameRadioBinary;
        private System.Windows.Forms.RadioButton typeRadioBinary;
        private System.Windows.Forms.RadioButton displacementRadioBinary;
        private System.Windows.Forms.ComboBox comboBoxMemory;
        private System.Windows.Forms.TextBox textBoxFilterMem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFile;
        private System.Windows.Forms.TextBox textBoxFilterBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBin;
        private System.Windows.Forms.Button buttonFilterMem;
        private System.Windows.Forms.Button buttonFilterFile;
        private System.Windows.Forms.Button buttonFilterBin;
    }
}

