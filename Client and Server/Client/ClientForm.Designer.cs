namespace Client
{
    partial class ClientForm
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
            this.MessageWindow = new System.Windows.Forms.TextBox();
            this.InputField = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nButton = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.TextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.themeBox = new System.Windows.Forms.TextBox();
            this.vaporWaveBtn = new System.Windows.Forms.Button();
            this.themeLabel = new System.Windows.Forms.Label();
            this.polygonBtn = new System.Windows.Forms.Button();
            this.amongBtn = new System.Windows.Forms.Button();
            this.duskBtn = new System.Windows.Forms.Button();
            this.alohaBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageWindow
            // 
            this.MessageWindow.BackColor = System.Drawing.Color.Violet;
            this.MessageWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageWindow.ForeColor = System.Drawing.Color.White;
            this.MessageWindow.Location = new System.Drawing.Point(12, 33);
            this.MessageWindow.Multiline = true;
            this.MessageWindow.Name = "MessageWindow";
            this.MessageWindow.ReadOnly = true;
            this.MessageWindow.Size = new System.Drawing.Size(776, 387);
            this.MessageWindow.TabIndex = 0;
            this.MessageWindow.TextChanged += new System.EventHandler(this.MessageWindow_TextChanged);
            // 
            // InputField
            // 
            this.InputField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputField.Location = new System.Drawing.Point(13, 437);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(638, 33);
            this.InputField.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitButton.Location = new System.Drawing.Point(657, 437);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 32);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nTextBox.Location = new System.Drawing.Point(821, 451);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(134, 20);
            this.nTextBox.TabIndex = 3;
            this.nTextBox.TextChanged += new System.EventHandler(this.nTextBox_TextChanged);
            // 
            // nButton
            // 
            this.nButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.nButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nButton.Location = new System.Drawing.Point(971, 426);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(94, 44);
            this.nButton.TabIndex = 4;
            this.nButton.Text = "Submit Nickname";
            this.nButton.UseVisualStyleBackColor = false;
            this.nButton.Click += new System.EventHandler(this.nButton_Click);
            // 
            // clientList
            // 
            this.clientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clientList.Enabled = false;
            this.clientList.Location = new System.Drawing.Point(971, 33);
            this.clientList.Multiline = true;
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(94, 387);
            this.clientList.TabIndex = 5;
            this.clientList.TextChanged += new System.EventHandler(this.clientList_TextChanged);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.Transparent;
            this.clientLabel.Location = new System.Drawing.Point(967, 10);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(89, 20);
            this.clientLabel.TabIndex = 6;
            this.clientLabel.Text = "Client List";
            // 
            // themeBox
            // 
            this.themeBox.BackColor = System.Drawing.Color.Violet;
            this.themeBox.Enabled = false;
            this.themeBox.Location = new System.Drawing.Point(821, 33);
            this.themeBox.Multiline = true;
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(134, 387);
            this.themeBox.TabIndex = 7;
            // 
            // vaporWaveBtn
            // 
            this.vaporWaveBtn.BackgroundImage = global::Client.Properties.Resources.vapor;
            this.vaporWaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vaporWaveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.vaporWaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaporWaveBtn.ForeColor = System.Drawing.Color.White;
            this.vaporWaveBtn.Location = new System.Drawing.Point(832, 59);
            this.vaporWaveBtn.Name = "vaporWaveBtn";
            this.vaporWaveBtn.Size = new System.Drawing.Size(112, 37);
            this.vaporWaveBtn.TabIndex = 8;
            this.vaporWaveBtn.Text = "VaporWave";
            this.vaporWaveBtn.UseVisualStyleBackColor = true;
            this.vaporWaveBtn.Click += new System.EventHandler(this.vaporWaveBtn_Click);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.themeLabel.Location = new System.Drawing.Point(817, 10);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(72, 20);
            this.themeLabel.TabIndex = 9;
            this.themeLabel.Text = "Themes";
            this.themeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // polygonBtn
            // 
            this.polygonBtn.BackgroundImage = global::Client.Properties.Resources.polygon;
            this.polygonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polygonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polygonBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.polygonBtn.Location = new System.Drawing.Point(832, 128);
            this.polygonBtn.Name = "polygonBtn";
            this.polygonBtn.Size = new System.Drawing.Size(112, 40);
            this.polygonBtn.TabIndex = 10;
            this.polygonBtn.Text = "Polygon";
            this.polygonBtn.UseVisualStyleBackColor = true;
            this.polygonBtn.Click += new System.EventHandler(this.polygonBtn_Click);
            // 
            // amongBtn
            // 
            this.amongBtn.BackgroundImage = global::Client.Properties.Resources.AmongUs;
            this.amongBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.amongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amongBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.amongBtn.Location = new System.Drawing.Point(832, 200);
            this.amongBtn.Name = "amongBtn";
            this.amongBtn.Size = new System.Drawing.Size(112, 40);
            this.amongBtn.TabIndex = 11;
            this.amongBtn.Text = "Among Us";
            this.amongBtn.UseVisualStyleBackColor = true;
            this.amongBtn.Click += new System.EventHandler(this.amongBtn_Click);
            // 
            // duskBtn
            // 
            this.duskBtn.BackgroundImage = global::Client.Properties.Resources.dusk;
            this.duskBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duskBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duskBtn.Location = new System.Drawing.Point(832, 277);
            this.duskBtn.Name = "duskBtn";
            this.duskBtn.Size = new System.Drawing.Size(112, 40);
            this.duskBtn.TabIndex = 12;
            this.duskBtn.Text = "Dusk";
            this.duskBtn.UseVisualStyleBackColor = true;
            this.duskBtn.Click += new System.EventHandler(this.duskBtn_Click);
            // 
            // alohaBtn
            // 
            this.alohaBtn.BackgroundImage = global::Client.Properties.Resources.Aloha;
            this.alohaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alohaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alohaBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alohaBtn.Location = new System.Drawing.Point(832, 352);
            this.alohaBtn.Name = "alohaBtn";
            this.alohaBtn.Size = new System.Drawing.Size(112, 40);
            this.alohaBtn.TabIndex = 13;
            this.alohaBtn.Text = "Aloha";
            this.alohaBtn.UseVisualStyleBackColor = true;
            this.alohaBtn.Click += new System.EventHandler(this.alohaBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(8, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 25);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "The Chatroom";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Client.Properties.Resources.vapor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 478);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.alohaBtn);
            this.Controls.Add(this.duskBtn);
            this.Controls.Add(this.amongBtn);
            this.Controls.Add(this.polygonBtn);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.vaporWaveBtn);
            this.Controls.Add(this.themeBox);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.nButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.MessageWindow);
            this.Name = "ClientForm";
            this.Text = "The Chatroom";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageWindow;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button nButton;
        private System.Windows.Forms.TextBox clientList;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.TextBox themeBox;
        private System.Windows.Forms.Button vaporWaveBtn;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Button polygonBtn;
        private System.Windows.Forms.Button amongBtn;
        private System.Windows.Forms.Button duskBtn;
        private System.Windows.Forms.Button alohaBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}