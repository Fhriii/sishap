using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cobachart
{
    public class authService
    {
        public static readonly HttpClient client = new HttpClient();

        public async Task<(bool, string)> LoginAsync(string username, string password)
        {
            var logininfo = new
            {
                username = username,
                password = password
            };
            var json = JsonConvert.SerializeObject(logininfo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:3000/api/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(responseContent);

                // Asumsikan bahwa API mengembalikan sebuah JSON dengan field 'id'
                string userId = jsonResponse["userId"]?.ToString();

                return (true, userId); // Login berhasil dan mengembalikan true beserta userId
            }

            return (false, null); // Login gagal
        }
    }
}
