
namespace TypingSoftware
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
            this.components = new System.ComponentModel.Container();
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.textBoxTyper = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelBiblio = new System.Windows.Forms.Label();
            this.labelWordsCount = new System.Windows.Forms.Label();
            this.labelWPM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.Location = new System.Drawing.Point(12, 12);
            this.textBoxTexto.Multiline = true;
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(370, 258);
            this.textBoxTexto.TabIndex = 0;
            // 
            // textBoxTyper
            // 
            this.textBoxTyper.Location = new System.Drawing.Point(12, 316);
            this.textBoxTyper.Name = "textBoxTyper";
            this.textBoxTyper.Size = new System.Drawing.Size(369, 23);
            this.textBoxTyper.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // labelBiblio
            // 
            this.labelBiblio.AutoSize = true;
            this.labelBiblio.Location = new System.Drawing.Point(12, 277);
            this.labelBiblio.Name = "labelBiblio";
            this.labelBiblio.Size = new System.Drawing.Size(0, 15);
            this.labelBiblio.TabIndex = 3;
            // 
            // labelWordsCount
            // 
            this.labelWordsCount.AutoSize = true;
            this.labelWordsCount.Location = new System.Drawing.Point(12, 346);
            this.labelWordsCount.Name = "labelWordsCount";
            this.labelWordsCount.Size = new System.Drawing.Size(0, 15);
            this.labelWordsCount.TabIndex = 4;
            // 
            // labelWPM
            // 
            this.labelWPM.AutoSize = true;
            this.labelWPM.Location = new System.Drawing.Point(12, 365);
            this.labelWPM.Name = "labelWPM";
            this.labelWPM.Size = new System.Drawing.Size(0, 15);
            this.labelWPM.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 410);
            this.Controls.Add(this.labelWPM);
            this.Controls.Add(this.labelWordsCount);
            this.Controls.Add(this.labelBiblio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTyper);
            this.Controls.Add(this.textBoxTexto);
            this.Name = "Form1";
            this.Text = "Typing Software v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTexto;
        private System.Windows.Forms.TextBox textBoxTyper;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBiblio;
        private System.Windows.Forms.Label labelWordsCount;
        private System.Windows.Forms.Label labelWPM;
    }
}

