namespace PhoneBookProj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNamein = new System.Windows.Forms.TextBox();
            this.LastNameIn = new System.Windows.Forms.TextBox();
            this.PhoneNumIn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddNum = new System.Windows.Forms.Button();
            this.Quitbutt = new System.Windows.Forms.Button();
            this.ErrorPhone = new System.Windows.Forms.Label();
            this.ErrorExist = new System.Windows.Forms.Label();
            this.ToLongError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number: ";
            // 
            // FirstNamein
            // 
            this.FirstNamein.BackColor = System.Drawing.Color.White;
            this.FirstNamein.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNamein.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamein.Location = new System.Drawing.Point(172, 187);
            this.FirstNamein.Name = "FirstNamein";
            this.FirstNamein.Size = new System.Drawing.Size(327, 37);
            this.FirstNamein.TabIndex = 4;
            // 
            // LastNameIn
            // 
            this.LastNameIn.BackColor = System.Drawing.Color.White;
            this.LastNameIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameIn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameIn.Location = new System.Drawing.Point(174, 255);
            this.LastNameIn.Name = "LastNameIn";
            this.LastNameIn.Size = new System.Drawing.Size(325, 37);
            this.LastNameIn.TabIndex = 5;
            // 
            // PhoneNumIn
            // 
            this.PhoneNumIn.BackColor = System.Drawing.Color.White;
            this.PhoneNumIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumIn.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumIn.Location = new System.Drawing.Point(221, 323);
            this.PhoneNumIn.Name = "PhoneNumIn";
            this.PhoneNumIn.Size = new System.Drawing.Size(278, 37);
            this.PhoneNumIn.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(22, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 3);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(19, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 3);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(19, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 3);
            this.panel3.TabIndex = 8;
            // 
            // AddNum
            // 
            this.AddNum.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNum.Location = new System.Drawing.Point(153, 375);
            this.AddNum.Name = "AddNum";
            this.AddNum.Size = new System.Drawing.Size(205, 55);
            this.AddNum.TabIndex = 9;
            this.AddNum.Text = "Add Number";
            this.AddNum.UseVisualStyleBackColor = true;
            this.AddNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quitbutt
            // 
            this.Quitbutt.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbutt.Location = new System.Drawing.Point(189, 452);
            this.Quitbutt.Name = "Quitbutt";
            this.Quitbutt.Size = new System.Drawing.Size(130, 55);
            this.Quitbutt.TabIndex = 10;
            this.Quitbutt.Text = "Quit";
            this.Quitbutt.UseVisualStyleBackColor = true;
            this.Quitbutt.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorPhone
            // 
            this.ErrorPhone.AutoSize = true;
            this.ErrorPhone.BackColor = System.Drawing.Color.White;
            this.ErrorPhone.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorPhone.Location = new System.Drawing.Point(130, 137);
            this.ErrorPhone.Name = "ErrorPhone";
            this.ErrorPhone.Size = new System.Drawing.Size(277, 26);
            this.ErrorPhone.TabIndex = 11;
            this.ErrorPhone.Text = "The Phone number doesnt exist";
            this.ErrorPhone.Visible = false;
            // 
            // ErrorExist
            // 
            this.ErrorExist.AutoSize = true;
            this.ErrorExist.BackColor = System.Drawing.Color.White;
            this.ErrorExist.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorExist.Location = new System.Drawing.Point(113, 137);
            this.ErrorExist.Name = "ErrorExist";
            this.ErrorExist.Size = new System.Drawing.Size(308, 26);
            this.ErrorExist.TabIndex = 12;
            this.ErrorExist.Text = "The Phone number is already taken";
            this.ErrorExist.Visible = false;
            // 
            // ToLongError
            // 
            this.ToLongError.AutoSize = true;
            this.ToLongError.BackColor = System.Drawing.Color.White;
            this.ToLongError.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLongError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToLongError.Location = new System.Drawing.Point(148, 137);
            this.ToLongError.Name = "ToLongError";
            this.ToLongError.Size = new System.Drawing.Size(253, 26);
            this.ToLongError.TabIndex = 13;
            this.ToLongError.Text = "The phone number is to long";
            this.ToLongError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(154, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Please enter a full name";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(167, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone number added";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToLongError);
            this.Controls.Add(this.ErrorExist);
            this.Controls.Add(this.ErrorPhone);
            this.Controls.Add(this.Quitbutt);
            this.Controls.Add(this.AddNum);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PhoneNumIn);
            this.Controls.Add(this.LastNameIn);
            this.Controls.Add(this.FirstNamein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNamein;
        private System.Windows.Forms.TextBox LastNameIn;
        private System.Windows.Forms.TextBox PhoneNumIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddNum;
        private System.Windows.Forms.Button Quitbutt;
        private System.Windows.Forms.Label ErrorPhone;
        private System.Windows.Forms.Label ErrorExist;
        private System.Windows.Forms.Label ToLongError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

