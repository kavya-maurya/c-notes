using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program

{
    public static async Task SendNtfyNotification(string title, string message)
    {
        using (var httpClient = new HttpClient())
        {
            var topic = "helloWorld"; // Replace with your ntfy topic name
            var url = $"https://ntfy.sh/{topic}";

            var content = new StringContent(message, Encoding.UTF8, "text/plain");

            // Optional: Add a title using headers
            httpClient.DefaultRequestHeaders.Add("Title", title);

            try
            {
                var response = await httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending notification: " + ex.Message);
            }
        }
    }

    static async Task Main()
    {

        int marks = 50;
        if(marks>=60)
        {
            Console.WriteLine("pass");
             await SendNtfyNotification("marks", "congratulations you are passed");
        Console.WriteLine("Notification sent.");
        }
        else 
        {
             Console.WriteLine("fail");
             await SendNtfyNotification("marks", "failed");
        Console.WriteLine("Notification sent.");
        }


       
        // string topic = "helloWorld"; // Replace with your ntfy topic name
        // string message = "Hello from C#";
        // string url = $"https://ntfy.sh/{topic}";

        // using (HttpClient client = new HttpClient())
        // {
        //     var content = new StringContent(message, Encoding.UTF8, "text/plain");

        //     try
        //     {
        //         HttpResponseMessage response = await client.PostAsync(url, content);
        //         Console.WriteLine($"Status: {response.StatusCode}");
        //         string responseBody = await response.Content.ReadAsStringAsync();
        //         Console.WriteLine(responseBody);
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine($"Error sending notification: {ex.Message}");
        //     }
        //}
    }
}