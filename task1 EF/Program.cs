using var context = new BookStoreContext();

context.Database.EnsureCreated();

Console.WriteLine(context.Database.CanConnect());