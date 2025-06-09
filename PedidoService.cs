using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Pedidos_Loja_virtual
{
    public class PedidoService
    {
        private readonly ILogger _logger:

        public PedidoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RegistrarPedido(Pedido pedido, Pedido_P repo)
        {
            repo.Adicionar(pedido);
            _logger.Log($"Pedido {pedido.id} registrado para {pedido.Cliente.Nome}");
        }
	}
}
