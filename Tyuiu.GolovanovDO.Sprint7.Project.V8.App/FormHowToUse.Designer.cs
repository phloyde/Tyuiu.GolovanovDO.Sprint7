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
            SuspendLayout();
            // 
            // labelHowToUse_GDO
            // 
            labelHowToUse_GDO.AutoSize = true;
            labelHowToUse_GDO.Location = new Point(12, 9);
            labelHowToUse_GDO.Name = "labelHowToUse_GDO";
            labelHowToUse_GDO.Size = new Size(1000, 240);
            labelHowToUse_GDO.TabIndex = 0;
            labelHowToUse_GDO.Text = resources.GetString("labelHowToUse_GDO.Text");
            // 
            // FormHowToUse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 280);
            Controls.Add(labelHowToUse_GDO);
            Name = "FormHowToUse";
            Text = "Как пользоваться программой";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHowToUse_GDO;
    }
}