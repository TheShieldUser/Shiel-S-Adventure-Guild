namespace Shiel_S_Adventure_Guild
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
            label1 = new Label();
            label2 = new Label();
            UsernameTexbox = new TextBox();
            PasswordTextbox = new TextBox();
            button1 = new Button();
            RUsernametextbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            rpasswordtextbox = new TextBox();
            label5 = new Label();
            ClassTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // UsernameTexbox
            // 
            UsernameTexbox.Location = new Point(80, 6);
            UsernameTexbox.Name = "UsernameTexbox";
            UsernameTexbox.Size = new Size(272, 23);
            UsernameTexbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(80, 34);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(272, 23);
            PasswordTextbox.TabIndex = 3;
            PasswordTextbox.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(80, 63);
            button1.Name = "button1";
            button1.Size = new Size(272, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RUsernametextbox
            // 
            RUsernametextbox.Location = new Point(458, 6);
            RUsernametextbox.Name = "RUsernametextbox";
            RUsernametextbox.Size = new Size(272, 23);
            RUsernametextbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 37);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // button2
            // 
            button2.Location = new Point(453, 93);
            button2.Name = "button2";
            button2.Size = new Size(277, 40);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rpasswordtextbox
            // 
            rpasswordtextbox.Location = new Point(458, 34);
            rpasswordtextbox.Name = "rpasswordtextbox";
            rpasswordtextbox.Size = new Size(272, 23);
            rpasswordtextbox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 67);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Class";
            label5.Click += label5_Click;
            // 
            // ClassTextBox
            // 
            ClassTextBox.Location = new Point(458, 64);
            ClassTextBox.Name = "ClassTextBox";
            ClassTextBox.Size = new Size(272, 23);
            ClassTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 155);
            Controls.Add(ClassTextBox);
            Controls.Add(label5);
            Controls.Add(rpasswordtextbox);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RUsernametextbox);
            Controls.Add(button1);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTexbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTexbox;
        private TextBox PasswordTextbox;
        private Button button1;
        private TextBox RUsernametextbox;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox rpasswordtextbox;
        private Label label5;
        private TextBox ClassTextBox;
    }
}
