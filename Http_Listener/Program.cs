using System.Net;


using var listener = new HttpListener();

listener.Prefixes.Add(@"http://localhost:27001/");
listener.Prefixes.Add(@"http://localhost:27002/");

listener.Start();

Console.WriteLine("Listener...");

while (true)
{
    var context = await listener.GetContextAsync();

    var request = context.Request;
    var response = context.Response;

    // for (int i = 0; i < request.QueryString.Count; i++)
    // {
    //     var value = request.QueryString[i];
    //     var key = request.QueryString.Keys[i];
    //     Console.WriteLine($"{key} = {value}");
    // }


    response.ContentType = "application/json";
    //response.Headers.Add("Content-Type", "text/plain");
    response.Headers.Add("Content-Type", "text/html");
    response.StatusCode = 200;


    var writer = new StreamWriter(response.OutputStream);
    await writer.WriteLineAsync("<h1 style='color:blue;'>Hello World</h1>");

    writer.Close();    
}