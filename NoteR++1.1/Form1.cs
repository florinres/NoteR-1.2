using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NoteR__1._1
{
    public partial class NoteR : Form
    {
        AlteBaze Baze;
        C__ C;
        bool Modificat = false;
        string Cale;
        int PozitieCaret = 0;
        
        public NoteR()
        {
            Cale = string.Empty;
            Baze = new AlteBaze();
            C = new C__();
            InitializeComponent();
        }

        private void DropDown_Deschidere_Click(object sender, EventArgs e)
        {
            Cale = string.Empty;
            OpenFileDialog Fisier = new OpenFileDialog();
            Fisier.Title = "Deschidere";
            Fisier.Filter = "Document text(*.txt)|*.txt|Toate fisierele(*.*)|*.*";
            if (Fisier.ShowDialog() == DialogResult.OK)
            {
                CutieText.LoadFile(Fisier.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = Fisier.FileName.Substring(Fisier.FileName.LastIndexOf("\\") + 1);
            Modificat = false;
        }

        private void DropDown_Salvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog Fisier = new SaveFileDialog();
            Fisier.Title = "Salvare";
            Fisier.Filter = "Document text(*.txt)|*.txt";
            if (Modificat)
            {
                if (Fisier.CheckPathExists)
                {
                    if (Fisier.ShowDialog() == DialogResult.OK)
                    {
                        CutieText.SaveFile(Fisier.FileName, RichTextBoxStreamType.PlainText);
                        Cale = Fisier.FileName;
                        this.Text = Fisier.FileName.Substring(Fisier.FileName.LastIndexOf('\\') + 1);
                    }
                }
                else
                {
                    Cale = Fisier.FileName.Substring(Fisier.FileName.LastIndexOf('\\') + 1);
                    CutieText.SaveFile(Cale, RichTextBoxStreamType.PlainText);
                }
            }
            this.Text = Fisier.FileName;
            Modificat = false;
        }


        private void DropDown_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog Fisier = new SaveFileDialog();
            Fisier.Title = "Salvare";
            Fisier.Filter = "Toate fisierele(*.*)|*.*";
            if (Fisier.ShowDialog() == DialogResult.OK)
            {
                CutieText.SaveFile(Fisier.FileName, RichTextBoxStreamType.PlainText);
            }
            Modificat = false;
            this.Text = Fisier.FileName;
        }

        private void DropDown_Iesi_Click(object sender, EventArgs e)
        {
            MessageBoxButtons Buttons = new MessageBoxButtons();
            Buttons = MessageBoxButtons.YesNo;
            DialogResult RezultatCaseta = MessageBox.Show("Ai salvat?", "Alerta", Buttons);
            if (RezultatCaseta == DialogResult.Yes)
            {
                Close();
            }
            if (RezultatCaseta == DialogResult.No)
            {
                SaveFileDialog Save = new SaveFileDialog();
                Save.Title = "Salvare";
                Save.Filter = "Document text(*.txt)|*.txt|Toate fisierele(*.*)|*.*";
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    CutieText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void DropDown_Copiere_Click(object sender, EventArgs e)
        {
            CutieText.Copy();
        }

        private void DropDown_Decupare_Click(object sender, EventArgs e)
        {
            CutieText.Cut();
        }

        private void DropDown_Refa_Click(object sender, EventArgs e)
        {
            CutieText.Redo();
        }

        private void DropDown_ConvertHexa_Click(object sender, EventArgs e)
        {
            string path = null;
            FolderBrowserDialog Director = new FolderBrowserDialog();
            Director.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = Director.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = Director.SelectedPath;
            }
            else if (result == DialogResult.Cancel)
            {
                path = Directory.GetCurrentDirectory();
            }
            path += "\\" + "Hexa.txt";

            File.WriteAllText(path, Baze.ConvertToHexa(CutieText.Text));
        }

        private void DropDown_ConvertToOctal_Click(object sender, EventArgs e)
        {
            string path = null;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            else if (result == DialogResult.Cancel)
            {
                path = Directory.GetCurrentDirectory();
            }
            path += "\\" + "Octal.txt";

            File.WriteAllText(path, Baze.ConvertToOctal(CutieText.Text));
            
        }

        private void CutieText_TextChanged(object sender, EventArgs e)
        {
            //C.IncarcaText(CutieText.Text);
            Modificat = true;
            //foreach (string Cuvant in CutieText.Text.Split(' '))
            //{
            //    //Daca cuvantul din text se potriveste in lista de cuvinte
            //    //atunci coloram cuvantul
            //    if (C.VerificaLista(Cuvant))
            //    {
            //        Color CuloareCuvant = C.CuloarePotrivita(Cuvant);
            //       int IndexSelectie = CutieText.Find(Cuvant);
            //        int Length = Cuvant.Length;
            //        CutieText.SelectionColor = CuloareCuvant;
            //        CutieText.SelectionStart = CutieText.TextLength;
            //    }
            //    CutieText.SelectionColor = Color.Black;
            //    CutieText.SelectionLength = 0;
            //}
            int OldCaretPosition;
            CutieText.SelectionStart = PozitieCaret;
            TabelaDeCautare Tabela = new TabelaDeCautare(CutieText.Text, C.CuvinteDinDictionar());
            for (   int i = 0; i < Tabela.Length(); i++)
            {
                string cuv; int lungime; int pozitie;
                Tabela.ReturnData(out cuv, out lungime, out pozitie,i);
                Color c = C.CuloarePotrivita(cuv);
                CutieText.Select(pozitie, lungime);
                CutieText.SelectionColor = c;
                OldCaretPosition = PozitieCaret;
                CutieText.SelectionStart = OldCaretPosition;
                CutieText.SelectionColor = Color.Black;
            }
            //rezolvam problema cu caretul
        }
        private void DropDown_Nou_Click(object sender, EventArgs e)
        {
            MessageBoxButtons AlertaMesaj = MessageBoxButtons.YesNo;
            DialogResult RezultatDialog = MessageBox.Show("Ai salvat?", "Alerta", AlertaMesaj);
            if (RezultatDialog == DialogResult.Yes)
            {
                CutieText.Text = string.Empty;
            }
            else
            {
                SaveFileDialog Save = new SaveFileDialog();
                Save.Title = "Salvare";
                Save.Filter = "Document text(*.txt)|*.txt|Toate fisierele(*.*)|*.*";
                if (Save.ShowDialog() == DialogResult.OK)
                {
                    CutieText.SaveFile(Save.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void DropDown_Documentatie_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\rares\\source\\repos\\NoteR++1.1\\NoteR++1.1\\Resources\\Documentatie.pdf");
        }

        private void CutieText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != ' ')
            {
                PozitieCaret++;
            }
            if(e.KeyCode == Keys.Back && PozitieCaret !=0)
            {
                PozitieCaret--;
            }
            
        }

        private void CutieText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                PozitieCaret++;
                if (Baze.EsteText(PozitieCaret, CutieText.Text))
                {//daca exista text dupa caret atunci mutam tot textul la dreapta
                    CutieText.Text.PadRight(1, ' ');
                }
            }
        }
    }
}
