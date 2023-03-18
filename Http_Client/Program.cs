using var client = new HttpClient();

//var responseMessage = await client.GetAsync(@"http://localhost:27001/");
var responseMessage = await client.GetAsync(@"http://localhost:27001/?id=1&name=Leyla");

var content = await responseMessage.Content.ReadAsStringAsync();

Console.WriteLine(content);
