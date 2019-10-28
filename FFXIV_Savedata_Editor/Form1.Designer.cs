namespace FFXIV_Savedata_Editor
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.CD1 = new System.Windows.Forms.ColorDialog();
            this.cmbSelectChatType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Common File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CD1
            // 
            this.CD1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))));
            // 
            // cmbSelectChatType
            // 
            this.cmbSelectChatType.Enabled = false;
            this.cmbSelectChatType.FormattingEnabled = true;
            this.cmbSelectChatType.Location = new System.Drawing.Point(89, 50);
            this.cmbSelectChatType.Name = "cmbSelectChatType";
            this.cmbSelectChatType.Size = new System.Drawing.Size(222, 21);
            this.cmbSelectChatType.TabIndex = 1;
            this.cmbSelectChatType.SelectedIndexChanged += new System.EventHandler(this.cmbSelectChatType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat Channel:";
            // 
            // txtPreview
            // 
            this.txtPreview.BackColor = System.Drawing.Color.Black;
            this.txtPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(12, 77);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(415, 266);
            this.txtPreview.TabIndex = 3;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(317, 46);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(110, 27);
            this.btnChangeColor.TabIndex = 4;
            this.btnChangeColor.Text = "Change color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Unxor File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectChatType);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "FFXIV Chatlog Color Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog CD1;
        private System.Windows.Forms.ComboBox cmbSelectChatType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button button2;
    }
}

