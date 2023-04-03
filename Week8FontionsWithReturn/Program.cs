string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };

string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };

string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

//Random rnd = new Random(); 
 
//int randomIndex = rnd .Next(0, tvShows.Length);
//string randomMovie = tvShows[randomIndex];
//Console.WriteLine(randomMovie);

//randomIndex = rnd .Next(0, food.Length);
//string randomFood = food[randomIndex];
//Console.WriteLine(randomFood);

//randomIndex = rnd.Next(0, food.Length);
//string randomDrinks = drinks[randomIndex];
//Console.WriteLine(randomDrinks);


//PickRandomFromArray(tvShows);
//PickRandomFromArray(food);
//PickRandomFromArray(drinks);

string RandomMovie = PickRandomFromArray(tvShows);
string RandomFood = PickRandomFromArray(food);
string RandomDrinks = PickRandomFromArray(drinks);

Console.WriteLine($"I recommand you to watch {RandomMovie} to night");
Console.WriteLine($" Order some {RandomFood} and {RandomDrinks}.");

static string PickRandomFromArray(string[] someArray)
{
    Random rnd = new Random();

    int randomIndex = rnd .Next(0, someArray. Length);
    string randomElements = someArray[randomIndex];
    //Console.WriteLine(randomElements);
    return randomElements;
}