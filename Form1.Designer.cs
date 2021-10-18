
namespace UtilizandoDiamante
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
            this.ucDiamantee1 = new BotonDiamante.UCDiamantee();
            this.SuspendLayout();
            // 
            // ucDiamantee1
            // 
            this.ucDiamantee1.Location = new System.Drawing.Point(48, 12);
            this.ucDiamantee1.Name = "ucDiamantee1";
            this.ucDiamantee1.Size = new System.Drawing.Size(300, 250);
            this.ucDiamantee1.TabIndex = 0;
            this.ucDiamantee1.Load += new System.EventHandler(this.ucDiamantee1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.ucDiamantee1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonDiamante.UCDiamantee ucDiamantee1;
    }
}

