using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class Pedido
    {
        public int Id { get; }
        public Cliente Cliente { get; }
        public List<ItemPedido> Itens { get; }
        public DateTime Data { get; }
        public IDescontoStrategy DescontoStrategy { get; }

        public Pedido(int id, Cliente cliente, List<ItemPedido> itens, IDescontoStrategy desconto)
        {
            Id = id;
            Cliente = cliente;
            Itens = itens;
            Data = DateTime.Now;
            DescontoStrategy = desconto;
        }

        public double ValorTotal()
        {
            double total = 0;
            foreach (var item in Itens)
                total += item.ValorTotal();

            return DescontoStrategy.AplicarDesconto(Itens, total);
        }
    }
}
