using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
    class ValidacaoService
    {
        // Padrão
        //- Minimo de 3 caracteres
        //- Não pode ter 3 letras repetidas
        //- Não permitir multiplo espaço
        private readonly string padraoNome = @"^(?!.*([A-Za-zÀ-ÖØ-öø-ÿ])\1\1)(?!.* {2,})(?=.{3,}).+$";
        // Padrão
        //- Valida nota de 0-10
        //- Aceita decimais , aceitando ponto( ) ou virgula
        private readonly string padraoNota = @"^(?:10(?:[.,]0+)?|[0-9](?:[.,][0-9]+)?)$";

        private string ValidacaoNome(string nome, out string menssagemErro)
        {
            menssagemErro = string.Empty;
            if(string.IsNullOrEmpty(nome))
            {
                menssagemErro = "Nome vazio";
                return false;
            }

            if (!Regex.IsMatch(nome.Trim(), padraoNome))
            {
                menssagemErro = "Minímo 3 caracteres\n-Não pode ter 3 letras iguais seguidas\n Não pode ter espaços multiplos"
                return false;
            }
            return true;
        }

        public bool ConverteNota(string notaEntrada, out double nota)
        {
            nota = -1;

            if( string.IsNullOrEmpty(notaEntrada) ) return false;

            //Substitui a vírgula por ponto
            var notaDecimalVirgula = notaEntrada.Trim().Replace(".", ".");

            if( !Regex.IsMatch(notaDecimalVirgula, padraoNota)) return false;

            if( double.TryParse(notaDecimalVirgula,System.Globalization.NumberStyles.Number,System.Globalization.CultureInfo.InvariantCulture, out nota))
            {
                if(nota < 0 || nota > 10)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
}
