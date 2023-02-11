// using Microsoft.AspNetCore.Mvc;
// using Newtonsoft.Json;
// using cbb_learn.Models;

// namespace cbb_learn.Controllers;

// [ApiController]
// [Route("CbbLearnRoute")]
// public class CbbLearnRouteController : ControllerBase
// {
//     private readonly ILogger<CbbLearnRouteController> _logger;
//     private static readonly HttpClient client = new HttpClient();

//     public CbbLearnRouteController(ILogger<CbbLearnRouteController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet(Name = "GetAllTeams")]
//     public async Task<IEnumerable<int>> GetAllTeams()
//     {
//         string url = "http://sports.core.api.espn.com/" +
//             "v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/types/2/groups/50/teams" +
//             "?lang=en&region=us&limit=400";

//         JsonSerializerSettings settings = new JsonSerializerSettings();
//         settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;

//         string response = await client.GetStringAsync(url);
//         var teams = JsonConvert.DeserializeObject<Teams>(response, settings);
//         // var items = json?["items"];

//         if (teams == null)
//         {
//             _logger.LogError("ESPN response was null.");
//             return new List<int>();
//         }

//         if (teams.Items == null)
//         {
//             _logger.LogError("ESPN response did not include any items.");
//             return new List<int>();
//         }

//         // foreach(var i in teams.Items)
//         // {
//         //     if (i != null)
//         //     {
//         //         Console.WriteLine(i.Ref);
//         //     }
//         //     // Console.WriteLine(i.ToString());
//         // }

//         var ids = teams.Items.Select(item => {
//             return item;
//         });
        

//         // foreach(var item in json?.Items)
//         // {
//             // Console.WriteLine(item);
//             // int i = itemUrl.LastIndexOf("/") + 1;
            
//             // try
//             // {
//             //     string a = itemUrl.Substring(i);
//             //     Console.WriteLine(a);
//             //     int j = a.LastIndexOf("?");
//             //     string b = a.Substring(0, j);
//             //     Console.WriteLine(b);
                
//             // }
//             // catch(Exception ex)
//             // {
             
//             // }
//         // }
// // http://sports.core.api.espn.com/v2/sports/basketball/leagues/mens-college-basketball/seasons/2022/teams/2934?lang=en&region=us
//      // Console.WriteLine(json?["items"]);

//     return new List<int>();
//     }
// }
