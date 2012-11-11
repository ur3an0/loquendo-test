namespace LoquendoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_voice = new System.Windows.Forms.ComboBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_voice
            // 
            this.cb_voice.FormattingEnabled = true;
            this.cb_voice.Location = new System.Drawing.Point(22, 12);
            this.cb_voice.Name = "cb_voice";
            this.cb_voice.Size = new System.Drawing.Size(121, 21);
            this.cb_voice.TabIndex = 0;
            this.cb_voice.SelectedIndexChanged += new System.EventHandler(this.cb_persons_SelectedIndexChanged);
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Location = new System.Drawing.Point(159, 12);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(121, 21);
            this.cb_language.TabIndex = 1;
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_voice_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(22, 39);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(258, 133);
            this.txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "hablar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.cb_voice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_voice;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
    }
}

