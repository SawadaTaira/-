namespace 職業性ストレス簡易調査
{
    partial class FrmEmployee
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
            txtEmpID = new TextBox();
            txtEmpName = new TextBox();
            label_ID = new Label();
            label_Name = new Label();
            groupBox1 = new GroupBox();
            rbtGenderF = new RadioButton();
            rbtGenderM = new RadioButton();
            btnClose = new Button();
            btnAnswer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(347, 55);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(100, 23);
            txtEmpID.TabIndex = 0;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(347, 122);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(100, 23);
            txtEmpName.TabIndex = 1;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(242, 58);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(60, 15);
            label_ID.TabIndex = 2;
            label_ID.Text = "従業員 ID ";
            // 
            // label_Name
            // 
            label_Name.Location = new Point(255, 122);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(60, 23);
            label_Name.TabIndex = 0;
            label_Name.Text = "氏名";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGenderF);
            groupBox1.Controls.Add(rbtGenderM);
            groupBox1.Location = new Point(255, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "性別";
            // 
            // rbtGenderF
            // 
            rbtGenderF.AutoSize = true;
            rbtGenderF.Location = new Point(81, 66);
            rbtGenderF.Name = "rbtGenderF";
            rbtGenderF.Size = new Size(49, 19);
            rbtGenderF.TabIndex = 1;
            rbtGenderF.TabStop = true;
            rbtGenderF.Text = "女性";
            rbtGenderF.UseVisualStyleBackColor = true;
            // 
            // rbtGenderM
            // 
            rbtGenderM.AutoSize = true;
            rbtGenderM.Location = new Point(81, 22);
            rbtGenderM.Name = "rbtGenderM";
            rbtGenderM.Size = new Size(49, 19);
            rbtGenderM.TabIndex = 0;
            rbtGenderM.TabStop = true;
            rbtGenderM.Text = "男性";
            rbtGenderM.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(501, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "終了";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(169, 315);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(75, 23);
            btnAnswer.TabIndex = 5;
            btnAnswer.Text = "回答";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnswer);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(label_Name);
            Controls.Add(label_ID);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpID);
            Name = "FrmEmployee";
            Text = "職業性ストレス簡易調査";
            Load += FrmEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmpID;
        private TextBox txtEmpName;
        private Label label_ID;
        private Label label_Name;
        private GroupBox groupBox1;
        private RadioButton rbtGenderF;
        private RadioButton rbtGenderM;
        private Button btnClose;
        private Button btnAnswer;
    }
}
