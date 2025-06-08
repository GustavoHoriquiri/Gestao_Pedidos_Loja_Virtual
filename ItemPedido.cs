using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class ItemPedido
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
