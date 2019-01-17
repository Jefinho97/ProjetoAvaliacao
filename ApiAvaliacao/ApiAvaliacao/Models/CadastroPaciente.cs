using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAvaliacao.Models
{
    public class CadastroPaciente
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private DateTime Nascimento { get; set; }
        private string CEP { get; set; }
        private string Rua { get; set; }
        private string NumCasa { get; set; }
        private string Bairro { get; set; }
        private string UF { get; set; }
        private string Telefone { get; set; }
        private string EstCivil { get; set; }
        private string Sexo { get; set; }
        private string Escolaridade { get; set; }
        private string Profissao { get; set; }
        private string OpcaoProf { get; set; }
        private string Raca { get; set; }
        private string Diagnostico { get; set; }
    }
}
