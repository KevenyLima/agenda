using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace agenda
{
    public static class classgeral
    {
        public static string versao="v 1.0.0";
        public static List<cl_contactos> LISTA_DE_CONTACTOS;

        public static void costrutor_DE_lista()
        {
        string local_documentos =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string ficheiro_criado=local_documentos + @"\contatos.txt";
        LISTA_DE_CONTACTOS = new List<cl_contactos>();
            if (File.Exists(ficheiro_criado))
            { 
                StreamReader ficheiro = new StreamReader(ficheiro_criado ,Encoding.Default);
             
                while (!ficheiro.EndOfStream)
                {
                    string nome = ficheiro.ReadLine();
                    string numero = ficheiro.ReadLine();
                    cl_contactos novo = new cl_contactos();
                    novo.nome = nome;
                    novo.numero = numero;
                    LISTA_DE_CONTACTOS.Add(novo);
                }
                ficheiro.Dispose();
            }
        }
        public static void gravador_de_contatos(string _nome, string _numero)
        {
            LISTA_DE_CONTACTOS.Add(new cl_contactos() { nome = _nome, numero = _numero });
            atualizar_ficheiro();
        }
        public static void atualizar_ficheiro()
        {
            string local_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ficheiro_criado = local_documentos + @"\contatos.txt";
            StreamWriter ficheiro = new StreamWriter(ficheiro_criado,false, Encoding.Default);
            foreach(cl_contactos cl_ in LISTA_DE_CONTACTOS)
            {
                ficheiro.WriteLine(cl_.nome);
                ficheiro.WriteLine(cl_.numero);
            }

            ficheiro.Dispose();
        }
    }
   
}
