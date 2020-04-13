using System;
using System.Collections.Generic;
using System.Text;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Enumeradores;

namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain
{
    class ProdutoUsado : Produto
    {

        public DateTime Date { get; set; }

        public ProdutoUsado(string name, double price, EnumTipoProduto tipoProduto, DateTime date) :
            base(name, price, tipoProduto)
        {
            Date = date;
        }

        public override void ImpressaoEtiqueta()
        {
            base.ImpressaoEtiqueta();
            System.Console.WriteLine($"; Data Fabricação: {Date.ToString("dd/MM/yyyy")}");
        }
    }
}
