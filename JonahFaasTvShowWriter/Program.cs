using System.Text.Json;

Console.WriteLine("=================== PROMPT 1 BEGIN ===================");

TvShowWriter writer = new TvShowWriter{BaseDirPath = "./", WriteDirPath = "./TvShows"};
// TvShow? tvShowA
//     = JsonSerializer.Deserialize<TvShow>(File.ReadAllText("TvShowInfo.json"));

// TvShow singleTvShow = tvShowA.TvShows[0];

// writer.Write(singleTvShow);
Console.WriteLine($"Specific Directory: {writer.WriteDirPath}");
writer.Write();
Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 1 END ===================\n");


Console.WriteLine("=================== PROMPT 2 BEGIN ===================");

TvShow? tvShowA
    = JsonSerializer.Deserialize<TvShow>(File.ReadAllText("TvShowInfo.json"));

TvShow singleTvShow = tvShowA.Id[0];

writer.Write(singleTvShow);
/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 2 END ===================\n");


Console.WriteLine("=================== PROMPT 3 BEGIN ===================");

/* TODO: Write your code here. */
// WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");

Console.WriteLine("=================== PROMPT 3 END ===================\n");


Console.WriteLine("=================== PROMPT 4 BEGIN ===================");

/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 4 END ===================\n");


Console.WriteLine("=================== PROMPT 5 BEGIN ===================");

/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 5 END ===================\n");


Console.WriteLine("=================== PROMPT 6 BEGIN ===================");

/* TODO: Write your code here. */

Console.WriteLine("=================== PROMPT 6 END ===================\n");