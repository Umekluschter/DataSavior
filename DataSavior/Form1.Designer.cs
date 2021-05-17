
namespace DataSavior
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lbl_title = new System.Windows.Forms.Label();
            this.pic_box_logo = new System.Windows.Forms.PictureBox();
            this.pnl_encrypt = new System.Windows.Forms.Panel();
            this.pnl_decrypt = new System.Windows.Forms.Panel();
            this.lbl_message_decrypt = new System.Windows.Forms.Label();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.lbl_password_decrypt = new System.Windows.Forms.Label();
            this.txt_password_decrypt = new System.Windows.Forms.TextBox();
            this.btn_choose_file_decrypt = new System.Windows.Forms.Button();
            this.lbl_warning_password = new System.Windows.Forms.Label();
            this.btn_method_3_encrypt = new System.Windows.Forms.Button();
            this.btn_method_2_encrypt = new System.Windows.Forms.Button();
            this.lbl_data_encrypt = new System.Windows.Forms.Label();
            this.lbl_input_encrypt = new System.Windows.Forms.Label();
            this.lbl_password_encrypt = new System.Windows.Forms.Label();
            this.txt_password_encrypt = new System.Windows.Forms.TextBox();
            this.btn_choose_file_encrypt = new System.Windows.Forms.Button();
            this.btn_tab_decrypt = new System.Windows.Forms.Button();
            this.btn_tab_encrypt = new System.Windows.Forms.Button();
            this.pnl_tabs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_logo)).BeginInit();
            this.pnl_encrypt.SuspendLayout();
            this.pnl_decrypt.SuspendLayout();
            this.pnl_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(448, 63);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(368, 77);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "DataSavior";
            // 
            // pic_box_logo
            // 
            this.pic_box_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_box_logo.Image")));
            this.pic_box_logo.Location = new System.Drawing.Point(292, 22);
            this.pic_box_logo.Name = "pic_box_logo";
            this.pic_box_logo.Size = new System.Drawing.Size(150, 150);
            this.pic_box_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box_logo.TabIndex = 5;
            this.pic_box_logo.TabStop = false;
            // 
            // pnl_encrypt
            // 
            this.pnl_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.pnl_encrypt.Controls.Add(this.pnl_decrypt);
            this.pnl_encrypt.Controls.Add(this.lbl_warning_password);
            this.pnl_encrypt.Controls.Add(this.btn_method_3_encrypt);
            this.pnl_encrypt.Controls.Add(this.btn_method_2_encrypt);
            this.pnl_encrypt.Controls.Add(this.lbl_data_encrypt);
            this.pnl_encrypt.Controls.Add(this.lbl_input_encrypt);
            this.pnl_encrypt.Controls.Add(this.lbl_password_encrypt);
            this.pnl_encrypt.Controls.Add(this.txt_password_encrypt);
            this.pnl_encrypt.Controls.Add(this.btn_choose_file_encrypt);
            this.pnl_encrypt.Location = new System.Drawing.Point(67, 211);
            this.pnl_encrypt.Name = "pnl_encrypt";
            this.pnl_encrypt.Size = new System.Drawing.Size(1026, 480);
            this.pnl_encrypt.TabIndex = 11;
            // 
            // pnl_decrypt
            // 
            this.pnl_decrypt.Controls.Add(this.lbl_message_decrypt);
            this.pnl_decrypt.Controls.Add(this.btn_decrypt);
            this.pnl_decrypt.Controls.Add(this.lbl_password_decrypt);
            this.pnl_decrypt.Controls.Add(this.txt_password_decrypt);
            this.pnl_decrypt.Controls.Add(this.btn_choose_file_decrypt);
            this.pnl_decrypt.Location = new System.Drawing.Point(10, 64);
            this.pnl_decrypt.Name = "pnl_decrypt";
            this.pnl_decrypt.Size = new System.Drawing.Size(1002, 404);
            this.pnl_decrypt.TabIndex = 21;
            // 
            // lbl_message_decrypt
            // 
            this.lbl_message_decrypt.AutoSize = true;
            this.lbl_message_decrypt.Font = new System.Drawing.Font("Century Gothic", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_message_decrypt.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_message_decrypt.Location = new System.Drawing.Point(414, 358);
            this.lbl_message_decrypt.Name = "lbl_message_decrypt";
            this.lbl_message_decrypt.Size = new System.Drawing.Size(0, 36);
            this.lbl_message_decrypt.TabIndex = 21;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.btn_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt.Location = new System.Drawing.Point(401, 281);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(200, 46);
            this.btn_decrypt.TabIndex = 20;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // lbl_password_decrypt
            // 
            this.lbl_password_decrypt.AutoSize = true;
            this.lbl_password_decrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_password_decrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_password_decrypt.Location = new System.Drawing.Point(291, 211);
            this.lbl_password_decrypt.Name = "lbl_password_decrypt";
            this.lbl_password_decrypt.Size = new System.Drawing.Size(161, 38);
            this.lbl_password_decrypt.TabIndex = 17;
            this.lbl_password_decrypt.Text = "Password";
            // 
            // txt_password_decrypt
            // 
            this.txt_password_decrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password_decrypt.Location = new System.Drawing.Point(476, 215);
            this.txt_password_decrypt.Name = "txt_password_decrypt";
            this.txt_password_decrypt.PasswordChar = '*';
            this.txt_password_decrypt.Size = new System.Drawing.Size(200, 37);
            this.txt_password_decrypt.TabIndex = 16;
            // 
            // btn_choose_file_decrypt
            // 
            this.btn_choose_file_decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(199)))), ((int)(((byte)(185)))));
            this.btn_choose_file_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose_file_decrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_choose_file_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_choose_file_decrypt.Location = new System.Drawing.Point(384, 96);
            this.btn_choose_file_decrypt.Name = "btn_choose_file_decrypt";
            this.btn_choose_file_decrypt.Size = new System.Drawing.Size(236, 46);
            this.btn_choose_file_decrypt.TabIndex = 15;
            this.btn_choose_file_decrypt.Text = "Choose File";
            this.btn_choose_file_decrypt.UseVisualStyleBackColor = false;
            this.btn_choose_file_decrypt.Click += new System.EventHandler(this.btn_choose_file_encrypt_Click);
            // 
            // lbl_warning_password
            // 
            this.lbl_warning_password.AutoSize = true;
            this.lbl_warning_password.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_warning_password.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_warning_password.Location = new System.Drawing.Point(354, 325);
            this.lbl_warning_password.Name = "lbl_warning_password";
            this.lbl_warning_password.Size = new System.Drawing.Size(0, 32);
            this.lbl_warning_password.TabIndex = 20;
            // 
            // btn_method_3_encrypt
            // 
            this.btn_method_3_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.btn_method_3_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_method_3_encrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_method_3_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_method_3_encrypt.Location = new System.Drawing.Point(714, 171);
            this.btn_method_3_encrypt.Name = "btn_method_3_encrypt";
            this.btn_method_3_encrypt.Size = new System.Drawing.Size(200, 46);
            this.btn_method_3_encrypt.TabIndex = 19;
            this.btn_method_3_encrypt.Text = "DES";
            this.btn_method_3_encrypt.UseVisualStyleBackColor = false;
            this.btn_method_3_encrypt.Click += new System.EventHandler(this.btn_method_3_encrypt_Click);
            // 
            // btn_method_2_encrypt
            // 
            this.btn_method_2_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.btn_method_2_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_method_2_encrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_method_2_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_method_2_encrypt.Location = new System.Drawing.Point(714, 119);
            this.btn_method_2_encrypt.Name = "btn_method_2_encrypt";
            this.btn_method_2_encrypt.Size = new System.Drawing.Size(200, 46);
            this.btn_method_2_encrypt.TabIndex = 18;
            this.btn_method_2_encrypt.Text = "AES";
            this.btn_method_2_encrypt.UseVisualStyleBackColor = false;
            this.btn_method_2_encrypt.Click += new System.EventHandler(this.btn_method_2_encrypt_Click);
            // 
            // lbl_data_encrypt
            // 
            this.lbl_data_encrypt.AutoSize = true;
            this.lbl_data_encrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data_encrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_data_encrypt.Location = new System.Drawing.Point(354, 422);
            this.lbl_data_encrypt.Name = "lbl_data_encrypt";
            this.lbl_data_encrypt.Size = new System.Drawing.Size(100, 38);
            this.lbl_data_encrypt.TabIndex = 16;
            this.lbl_data_encrypt.Text = "Data:";
            // 
            // lbl_input_encrypt
            // 
            this.lbl_input_encrypt.AutoSize = true;
            this.lbl_input_encrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_input_encrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_input_encrypt.Location = new System.Drawing.Point(350, 370);
            this.lbl_input_encrypt.Name = "lbl_input_encrypt";
            this.lbl_input_encrypt.Size = new System.Drawing.Size(104, 38);
            this.lbl_input_encrypt.TabIndex = 15;
            this.lbl_input_encrypt.Text = "Input:";
            // 
            // lbl_password_encrypt
            // 
            this.lbl_password_encrypt.AutoSize = true;
            this.lbl_password_encrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_password_encrypt.ForeColor = System.Drawing.Color.White;
            this.lbl_password_encrypt.Location = new System.Drawing.Point(529, 271);
            this.lbl_password_encrypt.Name = "lbl_password_encrypt";
            this.lbl_password_encrypt.Size = new System.Drawing.Size(161, 38);
            this.lbl_password_encrypt.TabIndex = 13;
            this.lbl_password_encrypt.Text = "Password";
            // 
            // txt_password_encrypt
            // 
            this.txt_password_encrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password_encrypt.Location = new System.Drawing.Point(714, 275);
            this.txt_password_encrypt.Name = "txt_password_encrypt";
            this.txt_password_encrypt.PasswordChar = '*';
            this.txt_password_encrypt.Size = new System.Drawing.Size(200, 37);
            this.txt_password_encrypt.TabIndex = 12;
            // 
            // btn_choose_file_encrypt
            // 
            this.btn_choose_file_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(199)))), ((int)(((byte)(185)))));
            this.btn_choose_file_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose_file_encrypt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_choose_file_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_choose_file_encrypt.Location = new System.Drawing.Point(97, 119);
            this.btn_choose_file_encrypt.Name = "btn_choose_file_encrypt";
            this.btn_choose_file_encrypt.Size = new System.Drawing.Size(236, 46);
            this.btn_choose_file_encrypt.TabIndex = 11;
            this.btn_choose_file_encrypt.Text = "Choose File";
            this.btn_choose_file_encrypt.UseVisualStyleBackColor = false;
            this.btn_choose_file_encrypt.Click += new System.EventHandler(this.btn_choose_file_encrypt_Click);
            // 
            // btn_tab_decrypt
            // 
            this.btn_tab_decrypt.FlatAppearance.BorderSize = 0;
            this.btn_tab_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_decrypt.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tab_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_tab_decrypt.Location = new System.Drawing.Point(173, 0);
            this.btn_tab_decrypt.Name = "btn_tab_decrypt";
            this.btn_tab_decrypt.Size = new System.Drawing.Size(180, 58);
            this.btn_tab_decrypt.TabIndex = 13;
            this.btn_tab_decrypt.Text = "Decrypt";
            this.btn_tab_decrypt.UseVisualStyleBackColor = true;
            this.btn_tab_decrypt.Click += new System.EventHandler(this.btn_tab_decrypt_Click);
            // 
            // btn_tab_encrypt
            // 
            this.btn_tab_encrypt.FlatAppearance.BorderSize = 0;
            this.btn_tab_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tab_encrypt.Font = new System.Drawing.Font("Century Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tab_encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_tab_encrypt.Location = new System.Drawing.Point(0, 0);
            this.btn_tab_encrypt.Name = "btn_tab_encrypt";
            this.btn_tab_encrypt.Size = new System.Drawing.Size(180, 58);
            this.btn_tab_encrypt.TabIndex = 12;
            this.btn_tab_encrypt.Text = "Encrypt";
            this.btn_tab_encrypt.UseVisualStyleBackColor = true;
            this.btn_tab_encrypt.Click += new System.EventHandler(this.btn_tab_encrypt_Click);
            // 
            // pnl_tabs
            // 
            this.pnl_tabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(147)))), ((int)(((byte)(193)))));
            this.pnl_tabs.Controls.Add(this.btn_tab_decrypt);
            this.pnl_tabs.Controls.Add(this.btn_tab_encrypt);
            this.pnl_tabs.Location = new System.Drawing.Point(67, 211);
            this.pnl_tabs.Name = "pnl_tabs";
            this.pnl_tabs.Size = new System.Drawing.Size(1026, 58);
            this.pnl_tabs.TabIndex = 3;
            // 
            // Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.pnl_tabs);
            this.Controls.Add(this.pnl_encrypt);
            this.Controls.Add(this.pic_box_logo);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form";
            this.Text = "Form";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_logo)).EndInit();
            this.pnl_encrypt.ResumeLayout(false);
            this.pnl_encrypt.PerformLayout();
            this.pnl_decrypt.ResumeLayout(false);
            this.pnl_decrypt.PerformLayout();
            this.pnl_tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pic_box_logo;
        private System.Windows.Forms.Panel pnl_encrypt;
        private System.Windows.Forms.Button btn_method_3_encrypt;
        private System.Windows.Forms.Button btn_method_2_encrypt;
        private System.Windows.Forms.Label lbl_data_encrypt;
        private System.Windows.Forms.Label lbl_input_encrypt;
        private System.Windows.Forms.Label lbl_password_encrypt;
        private System.Windows.Forms.TextBox txt_password_encrypt;
        private System.Windows.Forms.Button btn_choose_file_encrypt;
        private System.Windows.Forms.Button btn_tab_decrypt;
        private System.Windows.Forms.Button btn_tab_encrypt;
        private System.Windows.Forms.Panel pnl_tabs;
        private System.Windows.Forms.Label lbl_warning_password;
        private System.Windows.Forms.Panel pnl_decrypt;
        private System.Windows.Forms.Label lbl_password_decrypt;
        private System.Windows.Forms.TextBox txt_password_decrypt;
        private System.Windows.Forms.Button btn_choose_file_decrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label lbl_message_decrypt;
    }
}

