using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Trabalho_AED2
{
    public partial class Form1 : Form
    {
        private EditorDeTexto editor;

        public Form1()
        {
            InitializeComponent();
            editor = new EditorDeTexto();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
                caixaDeTexto.Text = editor.LerArquivo(caminhoArquivo);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;
                editor.SalvarArquivo(caminhoArquivo, caixaDeTexto.Text);
            }
        }

        private void abrirDicionarioToolStripMenuItem_Click(object sender, EventArgs e){

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
            
            editor.CarregarPalavrasDoArquivo(caminhoArquivo);
            }
        }

        private void verificarPalavraToolStripMenuItem_Click(object sender, EventArgs e){

            string[] palavras = caixaDeTexto.Text.Split(new char[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string palavra in palavras)
            {
                if (!editor.ValidarPalavra(palavra))
                {
                    DialogResult result = MessageBox.Show($"A palavra '{palavra}' não está no dicionário. Deseja adicioná-la?", "Palavra não encontrada", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        editor.AdicionarPalavraAoDicionario(palavra);
                        editor.SalvarDicionario("dicionario.txt");
                        MessageBox.Show($"A palavra '{palavra}' foi adicionada ao dicionário.", "Palavra Adicionada", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show($"A palavra '{palavra}' já está no dicionário.", "Palavra já existente", MessageBoxButtons.OK);
                }
            }

        }


}
}