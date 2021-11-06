namespace Downloader.Library
{
    public class Downloader
    {
        private HttpClient client = new HttpClient();
        private HttpRequestMessage message = new HttpRequestMessage();


        public Downloader()
        {
            message.Method = HttpMethod.Get;

            message.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            message.Headers.Add("Accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            message.Headers.Add("User-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
            message.Headers.Add("Cache-control", "max-age=0");
        }

        public async void Download(string uri, string path)
        {
           
        }

        public async Task Download(Uri uri, string path)
        {
            message.RequestUri = uri;

            var response = await client.SendAsync(message);

            var type = response.Content.Headers.ContentType;

            if (type != null && type.ToString().ToLower().Contains("text"))
            {
                // Получить название файла из пути
                // Записать файл в папку
                var text = await response.Content.ReadAsStringAsync();
                Directory.CreateDirectory(Path.GetDirectoryName(path + "/content/test.html"));
                Console.WriteLine(Path.GetDirectoryName(path + "/content/test.html"));
                File.WriteAllText(path + "/content/test.html", text);
            }
        }
    }
}