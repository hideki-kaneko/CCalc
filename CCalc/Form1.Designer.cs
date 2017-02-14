namespace CCalc
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_MolWeight = new System.Windows.Forms.TextBox();
            this.textBox_TargetVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TargetConc = new System.Windows.Forms.TextBox();
            this.comboBox_TargetVolume = new System.Windows.Forms.ComboBox();
            this.comboBox_TargetConc = new System.Windows.Forms.ComboBox();
            this.button_Convert = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Reverse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_solution_Solute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_solution_MaximumWeight = new System.Windows.Forms.TextBox();
            this.textBox_solution_Solubility = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_dilution_TargetConc = new System.Windows.Forms.ComboBox();
            this.button_dilution_convert = new System.Windows.Forms.Button();
            this.label_dilution_solvent = new System.Windows.Forms.Label();
            this.label_dilution_Solute = new System.Windows.Forms.Label();
            this.comboBox_dilution_TargetVolume = new System.Windows.Forms.ComboBox();
            this.comboBox_dilution_SouceConc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_dilution_SolventVolume = new System.Windows.Forms.TextBox();
            this.textBox_dilution_SoluteVolume = new System.Windows.Forms.TextBox();
            this.textBox_dilution_TargetConc = new System.Windows.Forms.TextBox();
            this.textBox_dilution_SourceConc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_dilution_TargetVolume = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_MolWeight
            // 
            this.textBox_MolWeight.Location = new System.Drawing.Point(12, 37);
            this.textBox_MolWeight.Name = "textBox_MolWeight";
            this.textBox_MolWeight.Size = new System.Drawing.Size(47, 19);
            this.textBox_MolWeight.TabIndex = 0;
            // 
            // textBox_TargetVolume
            // 
            this.textBox_TargetVolume.Location = new System.Drawing.Point(113, 37);
            this.textBox_TargetVolume.Name = "textBox_TargetVolume";
            this.textBox_TargetVolume.Size = new System.Drawing.Size(68, 19);
            this.textBox_TargetVolume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Molecular Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "g/mol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Target volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target concentration";
            // 
            // textBox_TargetConc
            // 
            this.textBox_TargetConc.Location = new System.Drawing.Point(252, 37);
            this.textBox_TargetConc.Name = "textBox_TargetConc";
            this.textBox_TargetConc.Size = new System.Drawing.Size(68, 19);
            this.textBox_TargetConc.TabIndex = 3;
            // 
            // comboBox_TargetVolume
            // 
            this.comboBox_TargetVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TargetVolume.FormattingEnabled = true;
            this.comboBox_TargetVolume.Items.AddRange(new object[] {
            "mL",
            "μL"});
            this.comboBox_TargetVolume.Location = new System.Drawing.Point(189, 36);
            this.comboBox_TargetVolume.Name = "comboBox_TargetVolume";
            this.comboBox_TargetVolume.Size = new System.Drawing.Size(45, 20);
            this.comboBox_TargetVolume.TabIndex = 2;
            // 
            // comboBox_TargetConc
            // 
            this.comboBox_TargetConc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TargetConc.FormattingEnabled = true;
            this.comboBox_TargetConc.Items.AddRange(new object[] {
            "M",
            "mM"});
            this.comboBox_TargetConc.Location = new System.Drawing.Point(328, 36);
            this.comboBox_TargetConc.Name = "comboBox_TargetConc";
            this.comboBox_TargetConc.Size = new System.Drawing.Size(45, 20);
            this.comboBox_TargetConc.TabIndex = 4;
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(433, 35);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(37, 23);
            this.button_Convert.TabIndex = 7;
            this.button_Convert.Text = ">>";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(482, 37);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(68, 19);
            this.textBox_Result.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount to be solved";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Reverse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBox_TargetConc);
            this.groupBox1.Controls.Add(this.button_Convert);
            this.groupBox1.Controls.Add(this.comboBox_TargetVolume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label_solution_Solute);
            this.groupBox1.Controls.Add(this.textBox_TargetConc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_solution_MaximumWeight);
            this.groupBox1.Controls.Add(this.textBox_Result);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_solution_Solubility);
            this.groupBox1.Controls.Add(this.textBox_MolWeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_TargetVolume);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution";
            // 
            // button_Reverse
            // 
            this.button_Reverse.Location = new System.Drawing.Point(390, 35);
            this.button_Reverse.Name = "button_Reverse";
            this.button_Reverse.Size = new System.Drawing.Size(37, 23);
            this.button_Reverse.TabIndex = 6;
            this.button_Reverse.Text = "<<";
            this.button_Reverse.UseVisualStyleBackColor = true;
            this.button_Reverse.Click += new System.EventHandler(this.button_Reverse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "g/100mL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "g";
            // 
            // label_solution_Solute
            // 
            this.label_solution_Solute.AutoSize = true;
            this.label_solution_Solute.Location = new System.Drawing.Point(558, 40);
            this.label_solution_Solute.Name = "label_solution_Solute";
            this.label_solution_Solute.Size = new System.Drawing.Size(11, 12);
            this.label_solution_Solute.TabIndex = 1;
            this.label_solution_Solute.Text = "g";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maximum amount";
            // 
            // textBox_solution_MaximumWeight
            // 
            this.textBox_solution_MaximumWeight.Location = new System.Drawing.Point(482, 83);
            this.textBox_solution_MaximumWeight.Name = "textBox_solution_MaximumWeight";
            this.textBox_solution_MaximumWeight.Size = new System.Drawing.Size(68, 19);
            this.textBox_solution_MaximumWeight.TabIndex = 9;
            // 
            // textBox_solution_Solubility
            // 
            this.textBox_solution_Solubility.Location = new System.Drawing.Point(12, 83);
            this.textBox_solution_Solubility.Name = "textBox_solution_Solubility";
            this.textBox_solution_Solubility.Size = new System.Drawing.Size(47, 19);
            this.textBox_solution_Solubility.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Solubility (optional)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_dilution_TargetConc);
            this.groupBox2.Controls.Add(this.button_dilution_convert);
            this.groupBox2.Controls.Add(this.label_dilution_solvent);
            this.groupBox2.Controls.Add(this.label_dilution_Solute);
            this.groupBox2.Controls.Add(this.comboBox_dilution_TargetVolume);
            this.groupBox2.Controls.Add(this.comboBox_dilution_SouceConc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_dilution_SolventVolume);
            this.groupBox2.Controls.Add(this.textBox_dilution_SoluteVolume);
            this.groupBox2.Controls.Add(this.textBox_dilution_TargetConc);
            this.groupBox2.Controls.Add(this.textBox_dilution_SourceConc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_dilution_TargetVolume);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dilution";
            // 
            // comboBox_dilution_TargetConc
            // 
            this.comboBox_dilution_TargetConc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dilution_TargetConc.FormattingEnabled = true;
            this.comboBox_dilution_TargetConc.Items.AddRange(new object[] {
            "M",
            "mM"});
            this.comboBox_dilution_TargetConc.Location = new System.Drawing.Point(328, 36);
            this.comboBox_dilution_TargetConc.Name = "comboBox_dilution_TargetConc";
            this.comboBox_dilution_TargetConc.Size = new System.Drawing.Size(45, 20);
            this.comboBox_dilution_TargetConc.TabIndex = 5;
            // 
            // button_dilution_convert
            // 
            this.button_dilution_convert.Location = new System.Drawing.Point(390, 35);
            this.button_dilution_convert.Name = "button_dilution_convert";
            this.button_dilution_convert.Size = new System.Drawing.Size(80, 23);
            this.button_dilution_convert.TabIndex = 6;
            this.button_dilution_convert.Text = ">>";
            this.button_dilution_convert.UseVisualStyleBackColor = true;
            this.button_dilution_convert.Click += new System.EventHandler(this.button_dilution_Convert_Click);
            // 
            // label_dilution_solvent
            // 
            this.label_dilution_solvent.AutoSize = true;
            this.label_dilution_solvent.Location = new System.Drawing.Point(558, 67);
            this.label_dilution_solvent.Name = "label_dilution_solvent";
            this.label_dilution_solvent.Size = new System.Drawing.Size(11, 12);
            this.label_dilution_solvent.TabIndex = 1;
            this.label_dilution_solvent.Text = "L";
            // 
            // label_dilution_Solute
            // 
            this.label_dilution_Solute.AutoSize = true;
            this.label_dilution_Solute.Location = new System.Drawing.Point(558, 32);
            this.label_dilution_Solute.Name = "label_dilution_Solute";
            this.label_dilution_Solute.Size = new System.Drawing.Size(11, 12);
            this.label_dilution_Solute.TabIndex = 1;
            this.label_dilution_Solute.Text = "L";
            // 
            // comboBox_dilution_TargetVolume
            // 
            this.comboBox_dilution_TargetVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dilution_TargetVolume.FormattingEnabled = true;
            this.comboBox_dilution_TargetVolume.Items.AddRange(new object[] {
            "mL",
            "μL"});
            this.comboBox_dilution_TargetVolume.Location = new System.Drawing.Point(203, 36);
            this.comboBox_dilution_TargetVolume.Name = "comboBox_dilution_TargetVolume";
            this.comboBox_dilution_TargetVolume.Size = new System.Drawing.Size(45, 20);
            this.comboBox_dilution_TargetVolume.TabIndex = 3;
            // 
            // comboBox_dilution_SouceConc
            // 
            this.comboBox_dilution_SouceConc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dilution_SouceConc.FormattingEnabled = true;
            this.comboBox_dilution_SouceConc.Items.AddRange(new object[] {
            "M",
            "mM"});
            this.comboBox_dilution_SouceConc.Location = new System.Drawing.Point(68, 36);
            this.comboBox_dilution_SouceConc.Name = "comboBox_dilution_SouceConc";
            this.comboBox_dilution_SouceConc.Size = new System.Drawing.Size(45, 20);
            this.comboBox_dilution_SouceConc.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "Target concentration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "Amount of the solvent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Amount of the solute";
            // 
            // textBox_dilution_SolventVolume
            // 
            this.textBox_dilution_SolventVolume.Location = new System.Drawing.Point(482, 64);
            this.textBox_dilution_SolventVolume.Name = "textBox_dilution_SolventVolume";
            this.textBox_dilution_SolventVolume.Size = new System.Drawing.Size(68, 19);
            this.textBox_dilution_SolventVolume.TabIndex = 8;
            // 
            // textBox_dilution_SoluteVolume
            // 
            this.textBox_dilution_SoluteVolume.Location = new System.Drawing.Point(482, 29);
            this.textBox_dilution_SoluteVolume.Name = "textBox_dilution_SoluteVolume";
            this.textBox_dilution_SoluteVolume.Size = new System.Drawing.Size(68, 19);
            this.textBox_dilution_SoluteVolume.TabIndex = 7;
            // 
            // textBox_dilution_TargetConc
            // 
            this.textBox_dilution_TargetConc.Location = new System.Drawing.Point(254, 37);
            this.textBox_dilution_TargetConc.Name = "textBox_dilution_TargetConc";
            this.textBox_dilution_TargetConc.Size = new System.Drawing.Size(68, 19);
            this.textBox_dilution_TargetConc.TabIndex = 4;
            // 
            // textBox_dilution_SourceConc
            // 
            this.textBox_dilution_SourceConc.Location = new System.Drawing.Point(11, 37);
            this.textBox_dilution_SourceConc.Name = "textBox_dilution_SourceConc";
            this.textBox_dilution_SourceConc.Size = new System.Drawing.Size(47, 19);
            this.textBox_dilution_SourceConc.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Target volume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Source concentration";
            // 
            // textBox_dilution_TargetVolume
            // 
            this.textBox_dilution_TargetVolume.Location = new System.Drawing.Point(127, 37);
            this.textBox_dilution_TargetVolume.Name = "textBox_dilution_TargetVolume";
            this.textBox_dilution_TargetVolume.Size = new System.Drawing.Size(68, 19);
            this.textBox_dilution_TargetVolume.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 245);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Reverse;
        private System.Windows.Forms.Button button_Convert;
        private System.Windows.Forms.Label label_solution_Solute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_dilution_convert;
        private System.Windows.Forms.Label label_dilution_Solute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_dilution_SoluteVolume;
        public System.Windows.Forms.TextBox textBox_MolWeight;
        public System.Windows.Forms.TextBox textBox_TargetVolume;
        public System.Windows.Forms.TextBox textBox_TargetConc;
        public System.Windows.Forms.TextBox textBox_Result;
        public System.Windows.Forms.ComboBox comboBox_TargetVolume;
        public System.Windows.Forms.ComboBox comboBox_TargetConc;
        public System.Windows.Forms.ComboBox comboBox_dilution_SouceConc;
        public System.Windows.Forms.TextBox textBox_dilution_SourceConc;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboBox_dilution_TargetConc;
        public System.Windows.Forms.ComboBox comboBox_dilution_TargetVolume;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox_dilution_TargetConc;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox_dilution_TargetVolume;
        private System.Windows.Forms.TextBox textBox_dilution_SolventVolume;
        private System.Windows.Forms.Label label_dilution_solvent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox_solution_Solubility;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_solution_MaximumWeight;
        private System.Windows.Forms.Label label14;
    }
}

