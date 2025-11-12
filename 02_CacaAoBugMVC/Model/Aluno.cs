namespace _02_CacaAoBugMVC.Model
{
   public class Aluno
    {
        //private string nome = string.Empty;
        ////Métodos acessadores
        //public string getNome()
        //{ 
        //    return nome;
        //}

        //public void getNome(string nome)
        //{
        //    this.nome = nome;
        //}

        //Declaração de propriedades

        public string Nome { get; set; } = string.Empty;
        public string Nota1 { get; set; }
        public string Nota2 { get; set; }
        public string Nota3 { get; set; }
        public string Situacao { get; set; } = string.Empty;
    }
}
