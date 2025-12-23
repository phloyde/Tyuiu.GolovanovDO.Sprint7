namespace Tyuiu.GolovanovDO.Sprint7.Project.V8.App
{
    partial class FormHowToUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowToUse));
            labelHowToUse_GDO = new Label();
            buttonOK_GDO = new Button();
            SuspendLayout();
            // 
            // labelHowToUse_GDO
            // 
            labelHowToUse_GDO.AutoSize = true;
            labelHowToUse_GDO.Location = new Point(12, 9);
            labelHowToUse_GDO.Name = "labelHowToUse_GDO";
            labelHowToUse_GDO.Size = new Size(825, 220);
            labelHowToUse_GDO.TabIndex = 0;
            labelHowToUse_GDO.Text = resources.GetString("labelHowToUse_GDO.Text");
            // 
            // buttonOK_GDO
            // 
            buttonOK_GDO.Location = new Point(709, 211);
            buttonOK_GDO.Name = "buttonOK_GDO";
            buttonOK_GDO.Size = new Size(94, 29);
            buttonOK_GDO.TabIndex = 1;
            buttonOK_GDO.Text = "OK";
            buttonOK_GDO.UseVisualStyleBackColor = true;
            buttonOK_GDO.Click += buttonOK_GDO_Click;
            // 
            // FormHowToUse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 250);
            Controls.Add(buttonOK_GDO);
            Controls.Add(labelHowToUse_GDO);
            Name = "FormHowToUse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Как пользоваться программой";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHowToUse_GDO;
        private Button buttonOK_GDO;
    }
}