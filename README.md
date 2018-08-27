# Urban.Sharp
Basic c# wrapper Around [UrbanDictionary API](https://github.com/zdict/zdict/wiki/Urban-dictionary-API-documentation)

Example 
```cs
using System;
using System.Threading.Tasks;
using Urban.Sharp;
using Urban.Sharp.Response;

namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
             UrbanObject urban = await UrbanClient.GetDefinitionAsync("loli");
             Console.WriteLine(urban.List[0].Definition);
             await Task.Delay(-1);
        }
    }
}
```
