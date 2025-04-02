using System;
using System.IO;
using System.Text.Json;

public class TvShowWriter{
	/* 
		BaseDirPath is the directory that your program should always
		return to after traversing into other directories. This should
		be the absolute path of the root directory of this project.
	*/
	public required string BaseDirPath {get; set;}
	/*
		WriteDirPath is the path (relative or absolute) to the directory
		that you want this program to be writing to.
	*/
	public required string WriteDirPath {get; set;}
	
	/*
		ALL WRITE METHODS WRITE TO THE WriteDirPath UNLESS OTHERWISE SPECIFIED.
	*/

	public void MoveToBaseDir(){

        Directory.SetCurrentDirectory(BaseDirPath);
        
		/*
			Sets the current working directory to the BaseDirPath.
		*/
	}

	public void Write(TvShow tvShow){

        Directory.CreateDirectory(this.WriteDirPath);
        Directory.SetCurrentDirectory(this.WriteDirPath);
        string fileName = $"{tvShow.Id}_id.txt";
        string content = $"Id: {tvShow.Id}\nBackdrop Path: {tvShow.BackdropPath}\nName: {tvShow.Name}\nOrigin Country: {tvShow.OriginCountry}\nOriginal Language: {tvShow.OriginalLanguage}\nOriginal Name: {tvShow.OriginalName}\nOverview: {tvShow.Overview}\nPopularity: {tvShow.Popularity}\nPoster Path: {tvShow.PosterPath}\nVote Average: {tvShow.VoteAverage}\nVote Count: {tvShow.VoteCount}";
        File.WriteAllText(fileName, content);
        MoveToBaseDir();


		/* 
			Writes out all of the properties of the passed tvShow
			to a txt file which is named <tvShow_id>.txt
						
		*/			
	}

	public int CreateCountryDirectories(List<TvShow> tvShows, string countryDirName, bool returnToBasePath = true){
		int count = 0;
		/*
			Inside of the WritePathDir, create a new directory named {countryDirName}
			if one does not already exist. Traverse into this directory. Then, create
			a directory for each country that appears in the tvShows list in the tvShow's
			OriginCountry property. There should only be one directory per country.
			
			If the returnToBasePath is set to true, then return to the BaseDirPath.

			Returns the total number of directories that were created.
		*/

		return count;
	}
	
	public void WriteShowsByCountry(List<TvShow> tvShows, string countryDirName, bool returnToBasePath = true){
		/*
			Inside of the WriteDirPath directory, create a new directory named
			{countryDirName} if one does not already exist. Traverse into this directory
			and create a directory for each country. Inside of each country directory,
			write only those tvShows that have their OriginCountry equal to that country.
		*/
	}

}