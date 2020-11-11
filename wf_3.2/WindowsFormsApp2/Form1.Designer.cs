namespace WindowsFormsApp2
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
            this.zag = new System.Windows.Forms.Label();
            this.summer = new System.Windows.Forms.RadioButton();
            this.winter = new System.Windows.Forms.RadioButton();
            this.country = new System.Windows.Forms.ComboBox();
            this.gid = new System.Windows.Forms.CheckBox();
            this.cost = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zag
            // 
            this.zag.AutoSize = true;
            this.zag.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zag.ForeColor = System.Drawing.Color.Coral;
            this.zag.Location = new System.Drawing.Point(70, 41);
            this.zag.Name = "zag";
            this.zag.Size = new System.Drawing.Size(105, 28);
            this.zag.TabIndex = 0;
            this.zag.Text = "Подорожі";
            this.zag.Click += new System.EventHandler(this.label1_Click);
            // 
            // summer
            // 
            this.summer.AutoSize = true;
            this.summer.Checked = true;
            this.summer.Location = new System.Drawing.Point(70, 104);
            this.summer.Name = "summer";
            this.summer.Size = new System.Drawing.Size(48, 19);
            this.summer.TabIndex = 1;
            this.summer.TabStop = true;
            this.summer.Text = "Літо";
            this.summer.UseVisualStyleBackColor = true;
            // 
            // winter
            // 
            this.winter.AutoSize = true;
            this.winter.Location = new System.Drawing.Point(148, 104);
            this.winter.Name = "winter";
            this.winter.Size = new System.Drawing.Size(54, 19);
            this.winter.TabIndex = 2;
            this.winter.TabStop = true;
            this.winter.Text = "Зима";
            this.winter.UseVisualStyleBackColor = true;
            // 
            // country
            // 
            this.country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.country.Location = new System.Drawing.Point(70, 161);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(114, 23);
            this.country.TabIndex = 3;
            // 
            // gid
            // 
            this.gid.AutoSize = true;
            this.gid.Location = new System.Drawing.Point(70, 213);
            this.gid.Name = "gid";
            this.gid.Size = new System.Drawing.Size(41, 19);
            this.gid.TabIndex = 4;
            this.gid.Text = "Гід";
            this.gid.UseVisualStyleBackColor = true;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cost.ForeColor = System.Drawing.Color.Coral;
            this.cost.Location = new System.Drawing.Point(70, 363);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(94, 28);
            this.cost.TabIndex = 0;
            this.cost.Text = "Вартість: ";
            this.cost.Click += new System.EventHandler(this.label1_Click);
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(70, 274);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(159, 35);
            this.count.TabIndex = 5;
            this.count.Text = "Розрахувати";
            this.count.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.gid);
            this.Controls.Add(this.country);
            this.Controls.Add(this.winter);
            this.Controls.Add(this.summer);
            this.Controls.Add(this.zag);
            this.Name = "Form1";
            this.Text = "Подорожі";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zag;
        private System.Windows.Forms.RadioButton summer;
        private System.Windows.Forms.RadioButton winter;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.CheckBox gid;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button count;
    }
}

