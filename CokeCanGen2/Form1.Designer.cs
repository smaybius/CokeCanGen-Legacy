namespace CokeCanGen2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExportButton = new System.Windows.Forms.Button();
            this.CanName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(337, 469);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(163, 39);
            this.ExportButton.TabIndex = 11;
            this.ExportButton.Text = "Export as Image";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click_1);
            // 
            // CanName
            // 
            this.CanName.Font = new System.Drawing.Font("Serif Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanName.ForeColor = System.Drawing.SystemColors.Window;
            this.CanName.Location = new System.Drawing.Point(126, 58);
            this.CanName.Name = "CanName";
            this.CanName.Size = new System.Drawing.Size(405, 201);
            this.CanName.TabIndex = 10;
            this.CanName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CanName.Click += new System.EventHandler(this.CanName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate can";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter name here";
            // 
            // NameBox
            // 
            this.NameBox.AcceptsReturn = true;
            this.NameBox.Location = new System.Drawing.Point(235, 423);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(185, 26);
            this.NameBox.TabIndex = 7;
            this.NameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameBox_KeyDown);
            this.NameBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Namebox_PreviewKeyDown);
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(-1, -1);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(640, 354);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 6;
            this.Picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 514);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.CanName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label CanName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox Picture;


    }
}

