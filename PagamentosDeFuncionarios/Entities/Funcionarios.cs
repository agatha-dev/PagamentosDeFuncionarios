using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosDeFuncionarios.Entities
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHorasTrabalhadas { get; set; }


        public Funcionarios()
        {
        }

        public Funcionarios(string nome, int horasTrabalhadas, double valorHorasTrabalhadas)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHorasTrabalhadas = valorHorasTrabalhadas;
        }
        public virtual double Pagamento()
        {
            return HorasTrabalhadas * ValorHorasTrabalhadas;
        }
            

    }
}
