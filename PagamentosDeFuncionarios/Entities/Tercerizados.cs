using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentosDeFuncionarios.Entities
{
    public class Tercerizados : Funcionarios
    {
        public double CobrancaAdicional { get; set; }
        public Tercerizados()
        {
        }

        public Tercerizados(string nome, int horasTrabalhadas, double valorHorasTrabalhadas, double cobrancaAdicional)
         : base(nome, horasTrabalhadas, valorHorasTrabalhadas)
        {
            CobrancaAdicional = cobrancaAdicional;
        }
        public virtual double Pagamento()
        {
            return base.Pagamento() + 1.1 * CobrancaAdicional;
        }

    }
}
