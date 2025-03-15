public class Store {
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Game> Games { get; set; } = new List<Game>();

    public void AddBook(Book book) {
        Books.Add(book);
    }

    public void AddGame(Game game) {
        Games.Add(game);
    }

    public Book? FindBookByName(string name) {
        return Books.Find(book => book.Name == name);
    }

    public Game? FindGameByName(string name) {
        return Games.Find(game => game.Name == name);
    }

    public Book? RemoveBook(string name) {
        Book bookToRemove = Books.Find(book => book.Name == name);
        if (bookToRemove != null) {
            Books.Remove(bookToRemove);
        }
        return bookToRemove;
    }

    public Game? RemoveGame(string name) {
        Game gameToRemove = Games.Find(game => game.Name == name);
        if (gameToRemove != null) {
            Games.Remove(gameToRemove);
        }
        return gameToRemove;
    }

    public decimal GetTotalValueOfBooks() {
        return Books.Sum(book => book.Price);
    }

    public decimal GetTotalValueOfGames() {
        return Games.Sum(game => game.Price);
    }

    public decimal GetTotalValueOfAllInventory() {
        return GetTotalValueOfBooks() + GetTotalValueOfGames();
    }
}