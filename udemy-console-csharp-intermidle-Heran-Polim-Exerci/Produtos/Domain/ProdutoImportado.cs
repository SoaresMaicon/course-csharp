using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Enumeradores;

namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain
{
    class ProdutoImportado : Produto
    {
        

        public double TaxaAlfandega { get; set; }

        public ProdutoImportado(string name, double price, EnumTipoProduto tipoProduto,double taxaAlfandega):
            base(name,price,tipoProduto)
        {
            TaxaAlfandega = taxaAlfandega;
        }


        public override void ImpressaoEtiqueta()
        {
            base.ImpressaoEtiqueta();
            System.Console.WriteLine($"Taxa Alfandega:{TaxaAlfandega}; Preço Total: {PrecoTotal()}");
        }

        public double PrecoTotal()
        {
            return base.Price + TaxaAlfandega;
        }

    }
}
