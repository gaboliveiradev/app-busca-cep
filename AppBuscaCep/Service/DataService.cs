using System;
using System.Collections.Generic;
using System.Text;
using AppBuscaCep.Model;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppBuscaCep.Service
{
    public class DataService
    {

        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=");

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    end = JsonConvert.DeserializeObject<Endereco>(json);
                } 
                else throw new Exception(response.RequestMessage.Content.ToString());
            }

            return end;
        }
    }
}
