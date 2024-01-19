namespace NoteR__1._1
{
    partial class NoteR
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
            this.CutieText = new System.Windows.Forms.RichTextBox();
            this.BaraButoane = new System.Windows.Forms.MenuStrip();
            this.DropDownBtn_Fisier = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Nou = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Deschidere = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Salvare = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Iesi = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDownBtn_Editare = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Copiere = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Decupare = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Refa = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_ConvertHexa = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_ConvertToOctal = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Ajutor = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDown_Documentatie = new System.Windows.Forms.ToolStripMenuItem();
            this.BaraButoane.SuspendLayout();
            this.SuspendLayout();
            // 
            // CutieText
            // 
            this.CutieText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CutieText.Location = new System.Drawing.Point(0, 24);
            this.CutieText.Name = "CutieText";
            this.CutieText.Size = new System.Drawing.Size(433, 273);
            this.CutieText.TabIndex = 0;
            this.CutieText.Text = "";
            this.CutieText.TextChanged += new System.EventHandler(this.CutieText_TextChanged);
            this.CutieText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CutieText_KeyDown);
            this.CutieText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CutieText_KeyPress);
            // 
            // BaraButoane
            // 
            this.BaraButoane.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDownBtn_Fisier,
            this.DropDownBtn_Editare,
            this.DropDown_Ajutor});
            this.BaraButoane.Location = new System.Drawing.Point(0, 0);
            this.BaraButoane.Name = "BaraButoane";
            this.BaraButoane.Size = new System.Drawing.Size(433, 24);
            this.BaraButoane.TabIndex = 1;
            this.BaraButoane.Text = "menuStrip1";
            // 
            // DropDownBtn_Fisier
            // 
            this.DropDownBtn_Fisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown_Nou,
            this.DropDown_Deschidere,
            this.DropDown_Salvare,
            this.DropDown_SaveAs,
            this.DropDown_Iesi});
            this.DropDownBtn_Fisier.Name = "DropDownBtn_Fisier";
            this.DropDownBtn_Fisier.Size = new System.Drawing.Size(46, 20);
            this.DropDownBtn_Fisier.Text = "Fisier";
            // 
            // DropDown_Nou
            // 
            this.DropDown_Nou.Name = "DropDown_Nou";
            this.DropDown_Nou.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.DropDown_Nou.Size = new System.Drawing.Size(247, 22);
            this.DropDown_Nou.Text = "Nou";
            this.DropDown_Nou.Click += new System.EventHandler(this.DropDown_Nou_Click);
            // 
            // DropDown_Deschidere
            // 
            this.DropDown_Deschidere.Name = "DropDown_Deschidere";
            this.DropDown_Deschidere.Size = new System.Drawing.Size(247, 22);
            this.DropDown_Deschidere.Text = "Deschidere";
            this.DropDown_Deschidere.Click += new System.EventHandler(this.DropDown_Deschidere_Click);
            // 
            // DropDown_Salvare
            // 
            this.DropDown_Salvare.Name = "DropDown_Salvare";
            this.DropDown_Salvare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.DropDown_Salvare.Size = new System.Drawing.Size(247, 22);
            this.DropDown_Salvare.Text = "Salvare";
            this.DropDown_Salvare.Click += new System.EventHandler(this.DropDown_Salvare_Click);
            // 
            // DropDown_SaveAs
            // 
            this.DropDown_SaveAs.Name = "DropDown_SaveAs";
            this.DropDown_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.DropDown_SaveAs.Size = new System.Drawing.Size(247, 22);
            this.DropDown_SaveAs.Text = "Salvare in alta locatie";
            this.DropDown_SaveAs.Click += new System.EventHandler(this.DropDown_SaveAs_Click);
            // 
            // DropDown_Iesi
            // 
            this.DropDown_Iesi.Name = "DropDown_Iesi";
            this.DropDown_Iesi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.DropDown_Iesi.Size = new System.Drawing.Size(247, 22);
            this.DropDown_Iesi.Text = "Iesi";
            this.DropDown_Iesi.Click += new System.EventHandler(this.DropDown_Iesi_Click);
            // 
            // DropDownBtn_Editare
            // 
            this.DropDownBtn_Editare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown_Copiere,
            this.DropDown_Decupare,
            this.DropDown_Refa,
            this.DropDown_ConvertHexa,
            this.DropDown_ConvertToOctal});
            this.DropDownBtn_Editare.Name = "DropDownBtn_Editare";
            this.DropDownBtn_Editare.Size = new System.Drawing.Size(55, 20);
            this.DropDownBtn_Editare.Text = "Editare";
            // 
            // DropDown_Copiere
            // 
            this.DropDown_Copiere.Name = "DropDown_Copiere";
            this.DropDown_Copiere.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.DropDown_Copiere.Size = new System.Drawing.Size(173, 22);
            this.DropDown_Copiere.Text = "Copiere";
            this.DropDown_Copiere.Click += new System.EventHandler(this.DropDown_Copiere_Click);
            // 
            // DropDown_Decupare
            // 
            this.DropDown_Decupare.Name = "DropDown_Decupare";
            this.DropDown_Decupare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.DropDown_Decupare.Size = new System.Drawing.Size(173, 22);
            this.DropDown_Decupare.Text = "Decupare";
            this.DropDown_Decupare.Click += new System.EventHandler(this.DropDown_Decupare_Click);
            // 
            // DropDown_Refa
            // 
            this.DropDown_Refa.Name = "DropDown_Refa";
            this.DropDown_Refa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.DropDown_Refa.Size = new System.Drawing.Size(173, 22);
            this.DropDown_Refa.Text = "Refa";
            this.DropDown_Refa.Click += new System.EventHandler(this.DropDown_Refa_Click);
            // 
            // DropDown_ConvertHexa
            // 
            this.DropDown_ConvertHexa.Name = "DropDown_ConvertHexa";
            this.DropDown_ConvertHexa.Size = new System.Drawing.Size(173, 22);
            this.DropDown_ConvertHexa.Text = "Convertire in Hexa";
            this.DropDown_ConvertHexa.Click += new System.EventHandler(this.DropDown_ConvertHexa_Click);
            // 
            // DropDown_ConvertToOctal
            // 
            this.DropDown_ConvertToOctal.Name = "DropDown_ConvertToOctal";
            this.DropDown_ConvertToOctal.Size = new System.Drawing.Size(173, 22);
            this.DropDown_ConvertToOctal.Text = "Convertire in Octal";
            this.DropDown_ConvertToOctal.Click += new System.EventHandler(this.DropDown_ConvertToOctal_Click);
            // 
            // DropDown_Ajutor
            // 
            this.DropDown_Ajutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropDown_Documentatie});
            this.DropDown_Ajutor.Name = "DropDown_Ajutor";
            this.DropDown_Ajutor.Size = new System.Drawing.Size(52, 20);
            this.DropDown_Ajutor.Text = "Ajutor";
            // 
            // DropDown_Documentatie
            // 
            this.DropDown_Documentatie.Name = "DropDown_Documentatie";
            this.DropDown_Documentatie.Size = new System.Drawing.Size(149, 22);
            this.DropDown_Documentatie.Text = "Documentatie";
            this.DropDown_Documentatie.Click += new System.EventHandler(this.DropDown_Documentatie_Click);
            // 
            // NoteR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 297);
            this.Controls.Add(this.CutieText);
            this.Controls.Add(this.BaraButoane);
            this.MainMenuStrip = this.BaraButoane;
            this.Name = "NoteR";
            this.Text = "NoteR++";
            this.BaraButoane.ResumeLayout(false);
            this.BaraButoane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CutieText;
        private System.Windows.Forms.MenuStrip BaraButoane;
        private System.Windows.Forms.ToolStripMenuItem DropDownBtn_Fisier;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Nou;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Deschidere;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Salvare;
        private System.Windows.Forms.ToolStripMenuItem DropDown_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Iesi;
        private System.Windows.Forms.ToolStripMenuItem DropDownBtn_Editare;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Copiere;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Decupare;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Refa;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Ajutor;
        private System.Windows.Forms.ToolStripMenuItem DropDown_Documentatie;
        private System.Windows.Forms.ToolStripMenuItem DropDown_ConvertHexa;
        private System.Windows.Forms.ToolStripMenuItem DropDown_ConvertToOctal;
    }
}

