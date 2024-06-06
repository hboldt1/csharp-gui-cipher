namespace WinFormsApp1
{
    partial class Project10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project10));
            key_box = new TextBox();
            key_label = new Label();
            message_label = new Label();
            message_box = new TextBox();
            Clear = new Button();
            Go = new Button();
            label1 = new Label();
            label2 = new Label();
            encrypt_label = new Label();
            decrypt_label = new Label();
            SuspendLayout();
            // 
            // key_box
            // 
            key_box.Location = new Point(420, 71);
            key_box.Name = "key_box";
            key_box.Size = new Size(259, 39);
            key_box.TabIndex = 0;
            key_box.TextChanged += textBox1_TextChanged;
            // 
            // key_label
            // 
            key_label.AutoSize = true;
            key_label.Location = new Point(68, 71);
            key_label.Name = "key_label";
            key_label.Size = new Size(169, 32);
            key_label.TabIndex = 1;
            key_label.Text = "Enter key 1-25";
            key_label.Click += label1_Click;
            // 
            // message_label
            // 
            message_label.AutoSize = true;
            message_label.Location = new Point(68, 155);
            message_label.Name = "message_label";
            message_label.Size = new Size(285, 32);
            message_label.TabIndex = 2;
            message_label.Text = "Enter message to encrypt";
            message_label.Click += message_label_Click;
            // 
            // message_box
            // 
            message_box.Location = new Point(420, 155);
            message_box.Name = "message_box";
            message_box.Size = new Size(259, 39);
            message_box.TabIndex = 3;
            message_box.TextChanged += message_box_TextChanged;
            // 
            // Clear
            // 
            Clear.Location = new Point(68, 357);
            Clear.Name = "Clear";
            Clear.Size = new Size(150, 46);
            Clear.TabIndex = 4;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Go
            // 
            Go.Location = new Point(529, 357);
            Go.Name = "Go";
            Go.Size = new Size(150, 46);
            Go.TabIndex = 5;
            Go.Text = "Go";
            Go.UseVisualStyleBackColor = true;
            Go.Click += Go_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 234);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 6;
            label1.Text = "Encrypted";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 298);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 7;
            label2.Text = "Decrypted";
            label2.Click += label2_Click;
            // 
            // encrypt_label
            // 
            encrypt_label.AutoSize = true;
            encrypt_label.Location = new Point(233, 234);
            encrypt_label.Name = "encrypt_label";
            encrypt_label.Size = new Size(70, 32);
            encrypt_label.TabIndex = 8;
            encrypt_label.Text = "        ";
            encrypt_label.Click += label3_Click;
            // 
            // decrypt_label
            // 
            decrypt_label.AutoSize = true;
            decrypt_label.Location = new Point(233, 298);
            decrypt_label.Name = "decrypt_label";
            decrypt_label.Size = new Size(77, 32);
            decrypt_label.TabIndex = 9;
            decrypt_label.Text = "         ";
            decrypt_label.Click += label4_Click;
            // 
            // Project10
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(decrypt_label);
            Controls.Add(encrypt_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Go);
            Controls.Add(Clear);
            Controls.Add(message_box);
            Controls.Add(message_label);
            Controls.Add(key_label);
            Controls.Add(key_box);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Project10";
            Text = "Hudson's Cipher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox key_box;
        private Label key_label;
        private Label message_label;
        private TextBox message_box;
        private Button Clear;
        private Button Go;
        private Label label1;
        private Label label2;
        private Label encrypt_label;
        private Label decrypt_label;
    }
}
