var downloader = new Downloader.Library.Downloader();

Uri uri = new Uri("https://example.com/");
await downloader.Download(uri, System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));

// using var httpClient = new HttpClient();
// byte[] imageBytes = await httpClient.GetByteArrayAsync("https://www.youtube.com/5642ae3e-8ce0-4b87-bf18-3e41fa3f9b0c");
// 
// string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
// 
// string localFilename = "video.mp4";
// string localPath = Path.Combine(documentsPath, localFilename);
// 
// File.WriteAllBytes(localPath, imageBytes);

// 
// Ресурс
// Если стоит галочка добавлять расширение для файла
// Файл
// Получить ресурс на скачку
// Получить заголовок ресурса
// Если ресурс 
// Скачать страницу
