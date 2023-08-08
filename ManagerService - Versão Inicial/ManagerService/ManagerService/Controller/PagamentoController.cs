using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using ManagerService.Service;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerService.Controller
{
    public class PagamentoController
    {
        private PagamentoService _service;

        public PagamentoController() => _service = new PagamentoService();

        public Pagamento GetPagamento(int id) => _service.GetPagamento(id);

        public void RealizarPagamentoAsync(int agenda, int tipoPagamento, float valor)
        {
            PagamentoPostDto dto = new PagamentoPostDto();         
            dto.agenda = agenda;
            dto.tipoPagamento = tipoPagamento;
            dto.valor = valor;
            
            string apiUrl = "http://localhost:8080/api/pagamentos";

            string requestData = JsonConvert.SerializeObject(dto);

            StringContent content = new StringContent(requestData, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseBody);
                MessageBox.Show("Pagamento Processado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao processar pagamento: $Erro: "+response.StatusCode);              
            }
        }

        public List<string> GetTiposPagamentos()
        {
            List<string> retorno = new List<string>();
            string apiUrl = "http://localhost:8080/api/tipos-pagamentos"; 

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    retorno = JsonConvert.DeserializeObject<List<string>>(responseBody);
                }
            }

            return retorno;
        }

        public float GetValorPago(int idAgenda)
        {
            float retorno = 0;
            string apiUrl = "http://localhost:8080/api/pagamentos/totais?agenda="+idAgenda.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    if (responseBody.ToString().Length > 0)
                        retorno = float.Parse(responseBody.Replace(".", ","));
                }
            }

            return retorno;
        }



    }
}
