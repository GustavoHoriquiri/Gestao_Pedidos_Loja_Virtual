using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class Pedido_P
    {
        public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens, IDescontoStrategy desconto)
        {
            return new Pedido(id, cliente, itens, desconto);
        }
    }
}
