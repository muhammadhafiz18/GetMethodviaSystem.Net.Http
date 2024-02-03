using System;
using System.Net.Http;

public class GetFromServer
{
    static async Task Main(string[] args)
    {
        using (var client = new HttpClient()) 
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/10");

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: => {response.StatusCode}");
            }

        }
    }
}
