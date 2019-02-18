using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TrelloTest
{
    class TrelloService
    {

        private async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        internal async Task<List<TrelloList>> GetAllListsForBoard(string v)
        {
            string result = await Get("https://api.trello.com/1/boards/"+ v + "/lists?key=b9ad404b6ac4d408963b68169cb450a6&token=274de7272d50f7eb475bec5f03f8bfcb2cd6fc9eeeab24547147f3df3f83e93a");
            
            return JsonConvert.DeserializeObject<List<TrelloList>>(result);

        }

        internal async Task CreateAcardOnAlist(string v1, string v2, string v3)
        {

            string result = await Post("https://api.trello.com/1/cards?name=" + v2 +"&desc=" + v3 + "&idList=" + v1 + "&key=b9ad404b6ac4d408963b68169cb450a6&token=274de7272d50f7eb475bec5f03f8bfcb2cd6fc9eeeab24547147f3df3f83e93a");


        }

        internal async Task<List<TrelloBoard>> GetAllBoards()
        {
            string result = await Get("https://api.trello.com/1/members/me/boards?key=b9ad404b6ac4d408963b68169cb450a6&token=274de7272d50f7eb475bec5f03f8bfcb2cd6fc9eeeab24547147f3df3f83e93a");

            return JsonConvert.DeserializeObject<List<TrelloBoard>>(result);

        }

        private async Task<string> Post(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync(url, null))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }


    }
}
