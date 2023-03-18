using System.IO;
using System.Net;
using System.Net.Http.Json;

using var client = new HttpClient();

//var content = await client.GetStringAsync("https://www.google.com/");
//Console.WriteLine(content);

var requestMessage = new HttpRequestMessage
{
    // RequestUri = new Uri("https://www.google.com/"),
    // RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts/1"),
    RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts"),
    Method = HttpMethod.Get,
};

var responseMessage = await client.SendAsync(requestMessage);

// client.GetAsync("https://www.google.com/");
// client.PostAsync();
// client.PutAsync();
// client.PatchAsync();
// client.DeleteAsync();



//var content = await responseMessage.Content.ReadAsStringAsync();
//Console.WriteLine(content);





// var post = await responseMessage.Content.ReadFromJsonAsync<Post>();
// Console.WriteLine(post?.Title);





// var posts = await responseMessage.Content.ReadFromJsonAsync<List<Post>>();
// 
// foreach (var post in posts ?? Enumerable.Empty<Post>())
// {
//     Console.WriteLine(post.Id);
//     Console.WriteLine(post.UserId);
//     Console.WriteLine(post.Title);
//     Console.WriteLine(post.Body);
//     Console.WriteLine();
// }



















// HttpWebRequest request = HttpWebRequest.CreateHttp("https://www.google.com/");
// var response  = request.GetResponse();
// 
// using var responseStream = response.GetResponseStream();
// using var reader = new StreamReader(responseStream);
// 
// Console.WriteLine(reader.ReadToEnd());





// var client = new WebClient();
// var responseString = client.DownloadString("https://www.google.com/");
// Console.WriteLine(responseString);