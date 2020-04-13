using System.Collections;
using System.Collections.Generic;
using udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Domain;

namespace udemy_console_csharp_intermidle_Heran_Polim_Exerci.Produtos.Repository
{
    class ProdutoRepository
    {
        public static List<Produto> ListaProdutos(List<Produto> lista)
        {
            lista.Add(new Produto("Teclado", 180.00, Enumeradores.EnumTipoProduto.Comum));
            lista.Add(new ProdutoImportado("SmartPhone Xiame", 1230.40, Enumeradores.EnumTipoProduto.Importado, 348.34));
            lista.Add(new ProdutoUsado("Monitor 15p", 100.00, Enumeradores.EnumTipoProduto.Usado, System.DateTime.Parse(string.Format("dd/MM/yyyy", 01 - 01 - 2020))));

            return lista;
        }
    }
}
    
