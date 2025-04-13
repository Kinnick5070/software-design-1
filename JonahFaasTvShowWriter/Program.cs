using System.Text.Json;

Console.WriteLine("=================== PROMPT 1 BEGIN ===================");

TvShowWriter writer = new TvShowWriter{BaseDirPath = Directory.GetCurrentDirectory(), WriteDirPath = "./TvShows"};

Console.WriteLine($"Specific Directory: {writer.WriteDirPath}");
Directory.CreateDirectory(writer.WriteDirPath);
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 1 END ===================\n");


Console.WriteLine("=================== PROMPT 2 BEGIN ===================");

List <TvShow> tvShows
    = JsonSerializer.Deserialize<List<TvShow>>(File.ReadAllText("./TvShowInfo.json"));

TvShow singleTvShow = tvShows[0];

writer.Write(singleTvShow);
/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 2 END ===================\n");


Console.WriteLine("=================== PROMPT 3 BEGIN ===================");

/* TODO: Write your code here. */
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
writer.MoveToBaseDir();
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

Console.WriteLine("=================== PROMPT 3 END ===================\n");


Console.WriteLine("=================== PROMPT 4 BEGIN ===================");
writer.CreateCountryDirectories(tvShows, "Countries", false);
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 4 END ===================\n");


Console.WriteLine("=================== PROMPT 5 BEGIN ===================");

/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 5 END ===================\n");


Console.WriteLine("=================== PROMPT 6 BEGIN ===================");
writer.WriteShowsByCountry(tvShows, "Countries", false);
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 6 END ===================\n");