namespace WindowsFormsApp1
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lb_name2 = new System.Windows.Forms.Label();
            this.tb_guess = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.Location = new System.Drawing.Point(202, 199);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(110, 33);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lb_name2
            // 
            this.lb_name2.AutoSize = true;
            this.lb_name2.Location = new System.Drawing.Point(72, 153);
            this.lb_name2.Name = "lb_name2";
            this.lb_name2.Size = new System.Drawing.Size(0, 13);
            this.lb_name2.TabIndex = 1;
            // 
            // tb_guess
            // 
            this.tb_guess.Location = new System.Drawing.Point(60, 93);
            this.tb_guess.Name = "tb_guess";
            this.tb_guess.Size = new System.Drawing.Size(403, 20);
            this.tb_guess.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(55, 28);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(408, 29);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Guess a random number from 0 to 10";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your guess here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_answer
            // 
            this.lb_answer.AutoSize = true;
            this.lb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_answer.ForeColor = System.Drawing.Color.Red;
            this.lb_answer.Location = new System.Drawing.Point(177, 163);
            this.lb_answer.Name = "lb_answer";
            this.lb_answer.Size = new System.Drawing.Size(165, 20);
            this.lb_answer.TabIndex = 5;
            this.lb_answer.Text = "Enter your guess here";
            this.lb_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_answer.Visible = false;
            this.lb_answer.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(521, 254);
            this.Controls.Add(this.lb_answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_guess);
            this.Controls.Add(this.lb_name2);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random guess game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lb_name2;
        private System.Windows.Forms.TextBox tb_guess;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_answer;
    }
}

