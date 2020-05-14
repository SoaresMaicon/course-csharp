using System;
using System.Collections.Generic;
using System.Text;

     enum enumTipoPessoa
{
    Fisica,
    Juridica
}


namespace udemy_console_csharp_intermidle_Abstrato.Domain
{
    abstract class Contribuinte
    {


        protected String Name { get; set; }
        protected int RendaAnual { get; set; }
        protected enumTipoPessoa TipoPessoa { get; set; }


        protected Contribuinte(string name, int rendaAnual, enumTipoPessoa tipoPessoa)
        {
            Name = name;
            RendaAnual = rendaAnual;
            TipoPessoa = tipoPessoa;
        }

        protected abstract double TotalImpostoPago();



    }
}



