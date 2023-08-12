using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerService.Model.Dto;
using Newtonsoft.Json;
using ManagerService.Controller;
using ManagerService.Service;
using System.Windows.Forms;

namespace ManagerService.RabbitMQ
{
    internal class RabbitMQListenerCliente : RabbitMQService
    {
        public void ListenForMessages()
        {   
            string retorno = ReceiveMessage("fila_cliente");
            if (retorno != null)
            {
                ClientePostDto cliente = JsonConvert.DeserializeObject<ClientePostDto>(retorno);
                ClienteService clienteService = new ClienteService();
                clienteService.InserirCliente(cliente);
            }
        }
    }
}
