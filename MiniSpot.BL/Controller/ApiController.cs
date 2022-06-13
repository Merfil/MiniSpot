using MiniSpot.BL.Model;
using Newtonsoft.Json;

namespace MiniSpot.BL.Controller
{
	public class ApiController
	{
		public async Task<Song> GetSongPreview(string track)
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://spotify-scraper.p.rapidapi.com/v1/track/download?track={track}"),
				Headers =
				{
					{ "X-RapidAPI-Key", "f3b51088fbmshbc1fd6b26d446b7p1bb312jsn60a3e13f0da1" },
					{ "X-RapidAPI-Host", "spotify-scraper.p.rapidapi.com" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				Song? song = JsonConvert.DeserializeObject<Song>(body);
				await Task.Delay(0);
				return song;
			}
		}
	}
}
