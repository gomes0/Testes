using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Controller
{
    class AlunoController
    {
        private readonly ValidacaoService validaService;
        private readonly AlunoService alunoService;
        private readonly List<Aluno> alunos;

        //Construtor
        public AlunoController()
        {
            validaService = new ValidacaoService();
            alunoService = new AlunoService();
            alunos = new List<Aluno>();
        }

        public bool AdicionaAluno(Aluno aluno, out string menssagemErro)
        {
            menssagemErro = string.Empty;
            return true;
        }
    }
}
