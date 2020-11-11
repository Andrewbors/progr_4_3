namespace WindowsFormsApp1
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
            this.rozm = new System.Windows.Forms.Label();
            this.oneC = new System.Windows.Forms.RadioButton();
            this.twoC = new System.Windows.Forms.RadioButton();
            this.sklpk = new System.Windows.Forms.Label();
            this.pidv = new System.Windows.Forms.CheckBox();
            this.sh = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.mat = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.cost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rozm
            // 
            this.rozm.AutoSize = true;
            this.rozm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rozm.Location = new System.Drawing.Point(51, 40);
            this.rozm.Name = "rozm";
            this.rozm.Size = new System.Drawing.Size(140, 28);
            this.rozm.TabIndex = 1;
            this.rozm.Text = "Розміри вікна";
            this.rozm.Click += new System.EventHandler(this.label2_Click);
            // 
            // oneC
            // 
            this.oneC.AutoSize = true;
            this.oneC.Checked = true;
            this.oneC.Location = new System.Drawing.Point(549, 95);
            this.oneC.Name = "oneC";
            this.oneC.Size = new System.Drawing.Size(109, 19);
            this.oneC.TabIndex = 2;
            this.oneC.TabStop = true;
            this.oneC.Text = "Однокамерний";
            this.oneC.UseVisualStyleBackColor = true;
            // 
            // twoC
            // 
            this.twoC.AutoSize = true;
            this.twoC.Location = new System.Drawing.Point(549, 129);
            this.twoC.Name = "twoC";
            this.twoC.Size = new System.Drawing.Size(101, 19);
            this.twoC.TabIndex = 3;
            this.twoC.Text = "Двокамерний";
            this.twoC.UseVisualStyleBackColor = true;
            this.twoC.CheckedChanged += new System.EventHandler(this.twoC_CheckedChanged);
            // 
            // sklpk
            // 
            this.sklpk.AutoSize = true;
            this.sklpk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sklpk.Location = new System.Drawing.Point(549, 40);
            this.sklpk.Name = "sklpk";
            this.sklpk.Size = new System.Drawing.Size(107, 28);
            this.sklpk.TabIndex = 4;
            this.sklpk.Text = "Склопакет";
            this.sklpk.Click += new System.EventHandler(this.label3_Click);
            // 
            // pidv
            // 
            this.pidv.AutoSize = true;
            this.pidv.Location = new System.Drawing.Point(549, 206);
            this.pidv.Name = "pidv";
            this.pidv.Size = new System.Drawing.Size(86, 19);
            this.pidv.TabIndex = 5;
            this.pidv.Text = "Підвіконня";
            this.pidv.UseVisualStyleBackColor = true;
            // 
            // sh
            // 
            this.sh.AutoSize = true;
            this.sh.Location = new System.Drawing.Point(51, 97);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(78, 15);
            this.sh.TabIndex = 6;
            this.sh.Text = "Ширина(см):";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(51, 129);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(71, 15);
            this.v.TabIndex = 6;
            this.v.Text = "Висота(см):";
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Location = new System.Drawing.Point(51, 206);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(61, 15);
            this.mat.TabIndex = 6;
            this.mat.Text = "Матеріал:";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(146, 94);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 23);
            this.width.TabIndex = 7;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(146, 126);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 23);
            this.height.TabIndex = 7;
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(549, 332);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(150, 50);
            this.count.TabIndex = 10;
            this.count.Text = "Розрахувати";
            this.count.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(146, 203);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMaterial.TabIndex = 11;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost.ForeColor = System.Drawing.Color.Red;
            this.cost.Location = new System.Drawing.Point(51, 343);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(94, 28);
            this.cost.TabIndex = 12;
            this.cost.Text = "Вартість: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.count);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.v);
            this.Controls.Add(this.sh);
            this.Controls.Add(this.pidv);
            this.Controls.Add(this.sklpk);
            this.Controls.Add(this.twoC);
            this.Controls.Add(this.oneC);
            this.Controls.Add(this.rozm);
            this.Name = "Form1";
            this.Text = "Склопакет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rozm;
        private System.Windows.Forms.RadioButton oneC;
        private System.Windows.Forms.RadioButton twoC;
        private System.Windows.Forms.Label sklpk;
        private System.Windows.Forms.CheckBox pidv;
        private System.Windows.Forms.Label sh;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label mat;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label cost;
    }
}

