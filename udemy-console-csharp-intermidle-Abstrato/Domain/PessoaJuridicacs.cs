using System;
using System.Collections.Generic;
using System.Text;
using udemy_console_csharp_intermidle_Abstrato.Domain;

namespace udemy_console_csharp_intermidle_Abstrato.Domain
{
    class PessoaJuridica: Contribuinte
    {

        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string name, int rendaAnual, enumTipoPessoa tipoPessoa, int numeroFuncionarios) : base(name, rendaAnual, tipoPessoa)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        protected override double TotalImpostoPago()
        {
            double impostoTotal = 0.00;

            if (NumeroFuncionarios > 15)
            {
                impostoTotal = RendaAnual * 0.20;
            }
            else
            {
                impostoTotal = RendaAnual * 0.15;
            }

            return impostoTotal;
        }
    }
}
