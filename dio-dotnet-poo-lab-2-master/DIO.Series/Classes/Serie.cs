using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
       // Atributos
       private Genero Genero {get; set;} 
       private string Titulo {get; set;}
       private string Descricao {get; set; }
       private int Ano {get; set; }
       private bool Excluido {get; set; }

       // Métodos
       public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;   
            this.Excluido = false; 
        } 
        public override string ToString()
        {
            // Enviroment.NewLine
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Environment.NewLine;
            retorno += "Título:" + this.Titulo + Environment.NewLine;
            retorno += "Ano de Início:" + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
        public int retornaID() {
            return this.Id;
        }
    }
}