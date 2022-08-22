namespace AreaAndPerimeter
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_pmeter = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_dmeter = new System.Windows.Forms.TextBox();
            this.lbl_pmeter = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_dmeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(152, 188);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 26);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(46, 188);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(88, 26);
            this.btn_calc.TabIndex = 22;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_pmeter
            // 
            this.txt_pmeter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pmeter.Location = new System.Drawing.Point(139, 122);
            this.txt_pmeter.Name = "txt_pmeter";
            this.txt_pmeter.ReadOnly = true;
            this.txt_pmeter.Size = new System.Drawing.Size(100, 23);
            this.txt_pmeter.TabIndex = 21;
            this.txt_pmeter.TabStop = false;
            // 
            // txt_area
            // 
            this.txt_area.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.Location = new System.Drawing.Point(139, 84);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(100, 23);
            this.txt_area.TabIndex = 20;
            this.txt_area.TabStop = false;
            // 
            // txt_dmeter
            // 
            this.txt_dmeter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dmeter.Location = new System.Drawing.Point(139, 46);
            this.txt_dmeter.Name = "txt_dmeter";
            this.txt_dmeter.Size = new System.Drawing.Size(100, 23);
            this.txt_dmeter.TabIndex = 19;
            // 
            // lbl_pmeter
            // 
            this.lbl_pmeter.AutoSize = true;
            this.lbl_pmeter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pmeter.Location = new System.Drawing.Point(54, 125);
            this.lbl_pmeter.Name = "lbl_pmeter";
            this.lbl_pmeter.Size = new System.Drawing.Size(67, 15);
            this.lbl_pmeter.TabIndex = 18;
            this.lbl_pmeter.Text = "Perimeter :";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area.Location = new System.Drawing.Point(54, 87);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(38, 15);
            this.lbl_area.TabIndex = 17;
            this.lbl_area.Text = "Area :";
            // 
            // lbl_dmeter
            // 
            this.lbl_dmeter.AutoSize = true;
            this.lbl_dmeter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dmeter.Location = new System.Drawing.Point(54, 49);
            this.lbl_dmeter.Name = "lbl_dmeter";
            this.lbl_dmeter.Size = new System.Drawing.Size(64, 15);
            this.lbl_dmeter.TabIndex = 16;
            this.lbl_dmeter.Text = "Diameter :";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_pmeter);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_dmeter);
            this.Controls.Add(this.lbl_pmeter);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_dmeter);
            this.Name = "Form1";
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_pmeter;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_dmeter;
        private System.Windows.Forms.Label lbl_pmeter;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_dmeter;
    }
}

