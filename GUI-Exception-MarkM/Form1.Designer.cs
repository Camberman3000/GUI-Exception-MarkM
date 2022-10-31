namespace GUI_Exception_MarkM
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
            this.btn_OpenWebpage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWebsiteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxNum = new System.Windows.Forms.ListBox();
            this.tbTextToAddToList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNight = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxBunch = new System.Windows.Forms.ComboBox();
            this.buttonGoHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenWebpage
            // 
            this.btn_OpenWebpage.Location = new System.Drawing.Point(106, 95);
            this.btn_OpenWebpage.Name = "btn_OpenWebpage";
            this.btn_OpenWebpage.Size = new System.Drawing.Size(130, 68);
            this.btn_OpenWebpage.TabIndex = 0;
            this.btn_OpenWebpage.Text = "Open Webpage";
            this.btn_OpenWebpage.UseVisualStyleBackColor = true;
            this.btn_OpenWebpage.Click += new System.EventHandler(this.btn_OpenBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "http://";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = ".com";
            // 
            // tbWebsiteName
            // 
            this.tbWebsiteName.Location = new System.Drawing.Point(99, 50);
            this.tbWebsiteName.Name = "tbWebsiteName";
            this.tbWebsiteName.Size = new System.Drawing.Size(148, 26);
            this.tbWebsiteName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type in a website, then click \'Open Webpage\'";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_OpenWebpage);
            this.panel1.Controls.Add(this.tbWebsiteName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 183);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxNum);
            this.panel2.Controls.Add(this.tbTextToAddToList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnClearList);
            this.panel2.Controls.Add(this.btnAddtoList);
            this.panel2.Location = new System.Drawing.Point(394, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 237);
            this.panel2.TabIndex = 6;
            // 
            // listBoxNum
            // 
            this.listBoxNum.FormattingEnabled = true;
            this.listBoxNum.ItemHeight = 20;
            this.listBoxNum.Location = new System.Drawing.Point(192, 109);
            this.listBoxNum.Name = "listBoxNum";
            this.listBoxNum.Size = new System.Drawing.Size(148, 84);
            this.listBoxNum.TabIndex = 9;
            // 
            // tbTextToAddToList
            // 
            this.tbTextToAddToList.Location = new System.Drawing.Point(192, 53);
            this.tbTextToAddToList.Name = "tbTextToAddToList";
            this.tbTextToAddToList.Size = new System.Drawing.Size(148, 26);
            this.tbTextToAddToList.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type in a number > 0, then click \'Add to list\'";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(41, 127);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(130, 68);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Location = new System.Drawing.Point(41, 53);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(130, 68);
            this.btnAddtoList.TabIndex = 7;
            this.btnAddtoList.Text = "Add to list";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNight);
            this.groupBox1.Controls.Add(this.radioButtonDay);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // radioButtonNight
            // 
            this.radioButtonNight.AutoSize = true;
            this.radioButtonNight.Location = new System.Drawing.Point(21, 68);
            this.radioButtonNight.Name = "radioButtonNight";
            this.radioButtonNight.Size = new System.Drawing.Size(71, 24);
            this.radioButtonNight.TabIndex = 1;
            this.radioButtonNight.TabStop = true;
            this.radioButtonNight.Text = "Night";
            this.radioButtonNight.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(21, 38);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(62, 24);
            this.radioButtonDay.TabIndex = 0;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Day";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonGoHome);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(111, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 172);
            this.panel3.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxBunch);
            this.groupBox2.Location = new System.Drawing.Point(164, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bunch";
            // 
            // comboBoxBunch
            // 
            this.comboBoxBunch.FormattingEnabled = true;
            this.comboBoxBunch.Items.AddRange(new object[] {
            "6 Foot",
            "7 Foot",
            "8 Foot"});
            this.comboBoxBunch.Location = new System.Drawing.Point(6, 49);
            this.comboBoxBunch.Name = "comboBoxBunch";
            this.comboBoxBunch.Size = new System.Drawing.Size(176, 28);
            this.comboBoxBunch.TabIndex = 0;
            // 
            // buttonGoHome
            // 
            this.buttonGoHome.Location = new System.Drawing.Point(399, 48);
            this.buttonGoHome.Name = "buttonGoHome";
            this.buttonGoHome.Size = new System.Drawing.Size(142, 65);
            this.buttonGoHome.TabIndex = 9;
            this.buttonGoHome.Text = "Go Home?";
            this.buttonGoHome.UseVisualStyleBackColor = true;
            this.buttonGoHome.Click += new System.EventHandler(this.buttonGoHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenWebpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWebsiteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxNum;
        private System.Windows.Forms.TextBox tbTextToAddToList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNight;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonGoHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxBunch;
    }
}

