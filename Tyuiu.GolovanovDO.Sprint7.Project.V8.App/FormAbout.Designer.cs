namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.App
{
    partial class FormAbout_GDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GDO));
            labelAbout_GDO = new Label();
            pictureBox_GDO = new PictureBox();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GDO).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_GDO
            // 
            labelAbout_GDO.AutoSize = true;
            labelAbout_GDO.Location = new Point(283, 9);
            labelAbout_GDO.Name = "labelAbout_GDO";
            labelAbout_GDO.Size = new Size(387, 300);
            labelAbout_GDO.TabIndex = 0;
            labelAbout_GDO.Text = resources.GetString("labelAbout_GDO.Text");
            labelAbout_GDO.Click += labelAbout_GDO_Click;
            // 
            // pictureBox_GDO
            // 
            pictureBox_GDO.Location = new Point(27, 25);
            pictureBox_GDO.Name = "pictureBox_GDO";
            pictureBox_GDO.Size = new Size(185, 201);
            pictureBox_GDO.TabIndex = 1;
            pictureBox_GDO.TabStop = false;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(570, 222);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout_GDO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 258);
            Controls.Add(buttonOK);
            Controls.Add(pictureBox_GDO);
            Controls.Add(labelAbout_GDO);
            Name = "FormAbout_GDO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_GDO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_GDO;
        private PictureBox pictureBox_GDO;
        private Button buttonOK;
    }
}