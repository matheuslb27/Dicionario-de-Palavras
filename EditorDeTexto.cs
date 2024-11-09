using System;
using System.Collections.Generic;
using System.IO;

public class EditorDeTexto
{
    private List<string> Dicionario;

    public EditorDeTexto()
    {
        this.Dicionario = new List<string>();
    }

    

    public void CarregarPalavrasDoArquivo(string caminhoArquivo)
    {
        try
        {
            var palavras = File.ReadAllLines(caminhoArquivo);
            foreach (var palavra in palavras)
            {
                AdicionarPalavraAoDicionario(palavra);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao carregar o arquivo: " + ex.Message);
        }
    }

    public void AdicionarPalavraAoDicionario(string palavra)
    {
        if (!Dicionario.Contains(palavra, StringComparer.OrdinalIgnoreCase))
        {
            Dicionario.Add(palavra);
        }
    }

    public string LerArquivo(string caminhoArquivo)
    {
        try
        {
            return File.ReadAllText(caminhoArquivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            return string.Empty;
        }
    }

    public void SalvarArquivo(string caminhoArquivo, string conteudo)
    {
        try
        {
            File.WriteAllText(caminhoArquivo, conteudo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao salvar o arquivo: " + ex.Message);
        }
    }

    public bool ValidarPalavra(string palavra)
    {
        return Dicionario.Contains(palavra, StringComparer.OrdinalIgnoreCase);
    }

    public void SalvarDicionario(string caminhoArquivo)
    {
        try
        {
            File.WriteAllLines(caminhoArquivo, Dicionario);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao salvar o dicionário: " + ex.Message);
        }
    }
    
}
