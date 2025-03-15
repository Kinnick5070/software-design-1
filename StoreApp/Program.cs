
// Create a Store
Store myStore = new Store { Name = "Game & Book Haven" };

/***************************************************************
************************* ADDING ITEMS *************************
***************************************************************/
Console.WriteLine("=== Adding Books and Games to Store ===");

Book book1 = new Book { Name = "C# Programming", Price = 49.99m };
Book book2 = new Book { Name = "Godel, Escher, Bach", Price = 39.99m };
Book book3 = new Book { Name = "Artificial Intelligence", Price = 59.99m };
Book book4 = new Book { Name = "Cybersecurity Basics", Price = 29.99m };

Game game1 = new Game { Name = "The Witcher 3", Price = 29.99m };
Game game2 = new Game { Name = "Cyberpunk 2077", Price = 59.99m };
Game game3 = new Game { Name = "Elden Ring", Price = 49.99m };
Game game4 = new Game { Name = "Pacman", Price = 39.99m };

myStore.AddBook(book1);
myStore.AddBook(book2);
myStore.AddBook(book3);
myStore.AddBook(book4);
myStore.AddGame(game1);
myStore.AddGame(game2);
myStore.AddGame(game3);
myStore.AddGame(game4);

/** 
    Expected Output: "Books in Store: C# Programming - $49.99, Godel, Escher, Bach - $39.99, Artificial Intelligence - $59.99, Cybersecurity Basics - $29.99"
*/
Console.WriteLine($"Books in Store: {string.Join(", ", myStore.Books)}");

/** 
    Expected Output: "Games in Store: The Witcher 3 - $29.99, Cyberpunk 2077 - $59.99, Elden Ring - $49.99, Pacman - $39.99"
*/
Console.WriteLine($"Games in Store: {string.Join(", ", myStore.Games)}");

/***************************************************************
************************ FINDING ITEMS ************************
***************************************************************/
Console.WriteLine("\n=== Finding Books and Games ===");

Book? foundBook = myStore.FindBookByName("C# Programming");
/** 
    Expected Output: "Found Book: C# Programming - $49.99"
*/
Console.WriteLine(foundBook != null ? $"Found Book: {foundBook}" : "Book not found");

Game? foundGame = myStore.FindGameByName("Cyberpunk 2077");
/** 
    Expected Output: "Found Game: Cyberpunk 2077 - $59.99"
*/
Console.WriteLine(foundGame != null ? $"Found Game: {foundGame}" : "Game not found");

Book? notFoundBook = myStore.FindBookByName("Python Programming");
/** 
    Expected Output: "Book not found"
*/
Console.WriteLine(notFoundBook != null ? $"Found Book: {notFoundBook}" : "Book not found");

/***************************************************************
************************ REMOVING ITEMS ************************
***************************************************************/
Console.WriteLine("\n=== Removing Books and Games ===");

Book? removedBook = myStore.RemoveBook("C# Programming");
/** 
    Expected Output: "Removed Book: C# Programming - $49.99"
*/
Console.WriteLine(removedBook != null ? $"Removed Book: {removedBook}" : "Book not found");

Game? removedGame = myStore.RemoveGame("The Witcher 3");
/** 
    Expected Output: "Removed Game: The Witcher 3 - $29.99"
*/
Console.WriteLine(removedGame != null ? $"Removed Game: {removedGame}" : "Game not found");

Book? nonExistentBook = myStore.RemoveBook("JavaScript Basics");
/** 
    Expected Output: "Book not found"
*/
Console.WriteLine(nonExistentBook != null ? $"Removed Book: {nonExistentBook}" : "Book not found");

/** 
    Expected Output: "Books in Store after removal: Godel, Escher, Bach - $39.99, Artificial Intelligence - $59.99, Cybersecurity Basics - $29.99"
*/
Console.WriteLine($"Books in Store after removal: {string.Join(", ", myStore.Books)}");

/** 
    Expected Output: "Games in Store after removal: Cyberpunk 2077 - $59.99, Elden Ring - $49.99, Pacman - $39.99"
*/
Console.WriteLine($"Games in Store after removal: {string.Join(", ", myStore.Games)}");

/***************************************************************
********************** TOTAL VALUE CHECKS **********************
***************************************************************/
Console.WriteLine("\n=== Checking Inventory Value ===");

decimal totalBooksValue = myStore.GetTotalValueOfBooks();
/** 
    Expected Output: "Total Book Value: $129.97"
*/
Console.WriteLine($"Total Book Value: ${totalBooksValue}");

decimal totalGamesValue = myStore.GetTotalValueOfGames();
/** 
    Expected Output: "Total Game Value: $149.97"
*/
Console.WriteLine($"Total Game Value: ${totalGamesValue}");

decimal totalInventoryValue = myStore.GetTotalValueOfAllInventory();
/** 
    Expected Output: "Total Store Inventory Value: $279.94"
*/
Console.WriteLine($"Total Store Inventory Value: ${totalInventoryValue}");

Console.WriteLine("\n=== All Tests Completed! ===");