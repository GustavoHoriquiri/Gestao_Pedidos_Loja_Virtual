using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class DescontoCategoria : Desconto_P
    {
        public double AplicarDesconto(List<ItemPedido> itens, double total)
        {
            if (itens.Any(item => item.Produto.Categoria.ToLower() == "eletronico"))
                return total * 0.9;

            return total;
        }
    }
}