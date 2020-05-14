using System;
using System.Collections.Generic;
using System.Text;
using udemy_console_csharp_intermidle_Abstrato.Domain;

namespace udemy_console_csharp_intermidle_Abstrato.Domain
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string name, int rendaAnual, enumTipoPessoa tipoPessoa, double gastoSaude) : base(name, rendaAnual, tipoPessoa)
        {
            GastoSaude = gastoSaude;
        }

        protected override double TotalImpostoPago()
        {
            double impostoTotal = 0.00;
            if (RendaAnual > 20000)
            {
                impostoTotal = RendaAnual * 0.25;

                impostoTotal = impostoTotal - (GastoSaude * 0.50);
            }
            return impostoTotal;

            throw new NotImplementedException();
        }
    }
}
