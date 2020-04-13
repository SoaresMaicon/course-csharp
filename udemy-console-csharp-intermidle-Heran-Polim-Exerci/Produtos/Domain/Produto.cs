using System.Globalization;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Enumeradores;

namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public EnumTipoProduto TipoProduto { get; set; }

        public Produto(string name, double price, EnumTipoProduto tipoProduto)
        {
            Name = name;
            Price = price;
            TipoProduto = tipoProduto;
        }

        public virtual void ImpressaoEtiqueta()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine($"Produto: {Name}; Tipo: {TipoProduto}; Valor: R$ {Price} ");
        }

    }

    
}
