namespace GetSetGenerator
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.InputTxtBox = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.OutputTxtBox = new System.Windows.Forms.TextBox();
            this.PrefixTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadOnlyChkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JavaRdBtn = new System.Windows.Forms.RadioButton();
            this.CSharpRdBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTxtBox
            // 
            this.InputTxtBox.Location = new System.Drawing.Point(12, 25);
            this.InputTxtBox.Multiline = true;
            this.InputTxtBox.Name = "InputTxtBox";
            this.InputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTxtBox.Size = new System.Drawing.Size(280, 277);
            this.InputTxtBox.TabIndex = 1;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(191, 308);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(101, 43);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // OutputTxtBox
            // 
            this.OutputTxtBox.Location = new System.Drawing.Point(298, 25);
            this.OutputTxtBox.Multiline = true;
            this.OutputTxtBox.Name = "OutputTxtBox";
            this.OutputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputTxtBox.Size = new System.Drawing.Size(282, 326);
            this.OutputTxtBox.TabIndex = 2;
            // 
            // PrefixTxtBox
            // 
            this.PrefixTxtBox.Location = new System.Drawing.Point(106, 331);
            this.PrefixTxtBox.Name = "PrefixTxtBox";
            this.PrefixTxtBox.Size = new System.Drawing.Size(74, 20);
            this.PrefixTxtBox.TabIndex = 6;
            this.PrefixTxtBox.Text = "Prop";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "C# Property Prefix:";
            // 
            // ReadOnlyChkBox
            // 
            this.ReadOnlyChkBox.AutoSize = true;
            this.ReadOnlyChkBox.Location = new System.Drawing.Point(109, 308);
            this.ReadOnlyChkBox.Name = "ReadOnlyChkBox";
            this.ReadOnlyChkBox.Size = new System.Drawing.Size(76, 17);
            this.ReadOnlyChkBox.TabIndex = 7;
            this.ReadOnlyChkBox.Text = "Read Only";
            this.ReadOnlyChkBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instance Variables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Properties";
            // 
            // JavaRdBtn
            // 
            this.JavaRdBtn.AutoSize = true;
            this.JavaRdBtn.Location = new System.Drawing.Point(10, 308);
            this.JavaRdBtn.Name = "JavaRdBtn";
            this.JavaRdBtn.Size = new System.Drawing.Size(48, 17);
            this.JavaRdBtn.TabIndex = 9;
            this.JavaRdBtn.Text = "Java";
            this.JavaRdBtn.UseVisualStyleBackColor = true;
            this.JavaRdBtn.CheckedChanged += new System.EventHandler(this.JavaRdBtn_CheckedChanged);
            // 
            // CSharpRdBtn
            // 
            this.CSharpRdBtn.AutoSize = true;
            this.CSharpRdBtn.Checked = true;
            this.CSharpRdBtn.Location = new System.Drawing.Point(64, 308);
            this.CSharpRdBtn.Name = "CSharpRdBtn";
            this.CSharpRdBtn.Size = new System.Drawing.Size(39, 17);
            this.CSharpRdBtn.TabIndex = 10;
            this.CSharpRdBtn.TabStop = true;
            this.CSharpRdBtn.Text = "C#";
            this.CSharpRdBtn.UseVisualStyleBackColor = true;
            this.CSharpRdBtn.CheckedChanged += new System.EventHandler(this.CSharpRdBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(563, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "v0.8";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 360);
            this.Controls.Add(this.CSharpRdBtn);
            this.Controls.Add(this.JavaRdBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadOnlyChkBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrefixTxtBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.OutputTxtBox);
            this.Controls.Add(this.InputTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "GetSetGo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxtBox;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox OutputTxtBox;
        private System.Windows.Forms.TextBox PrefixTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ReadOnlyChkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton JavaRdBtn;
        private System.Windows.Forms.RadioButton CSharpRdBtn;
        private System.Windows.Forms.Label label4;
    }
}

