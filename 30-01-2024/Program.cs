using _30_01_2024;
using _30_01_2024.Exceptions;

//string productCountStr;
//int productCount;
//do
//{
//    Console.Write("Mehsul sayını daxil edin: ");
//    productCountStr = Console.ReadLine();

//} while (!int.TryParse(productCountStr, out productCount));

//Product[] products = new Product[productCount];

//for (int i = 0; i < productCount; i++)
//{
//    string name;
//    do
//    {
//        Console.WriteLine("Mehsul adını daxil edin: ");
//        name = Console.ReadLine();
//    } while (string.IsNullOrWhiteSpace(name));


//    string priceStr;
//    decimal price;
//    do
//    {
//        Console.WriteLine("Mehsulun qiymetini daxil edin: ");
//        priceStr = Console.ReadLine();
//    } while (!decimal.TryParse(priceStr, out price));

//    string typeStr;
//    ProductType type;
//    do
//    {
//        Console.WriteLine("Mehsul novunu secin (Baker,Drink,Meat,Dairy): ");
//        typeStr = Console.ReadLine();
//    } while(!Enum.TryParse(typeStr, out type));

//    Array.Resize(ref products, products.Length+1);
//    products[products.Length - 1] = new Product(name, price, type);
//}



// Indexer:

string productCountStr;
int productCount;
do
{
    Console.Write("Mehsul sayını daxil edin: ");
    productCountStr = Console.ReadLine();

} while (!int.TryParse(productCountStr, out productCount));

Product[] products = new Product[productCount];

for (int i = 0; i < productCount; i++)
{
    string name;
    do
    {
        Console.WriteLine("Mehsul adını daxil edin: ");
        name = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(name));


    string priceStr;
    decimal price;
    do
    {
        Console.WriteLine("Mehsulun qiymetini daxil edin: ");
        priceStr = Console.ReadLine();
    } while (!decimal.TryParse(priceStr, out price));

    string typeStr;
    ProductType type;
    do
    {
        Console.WriteLine("Mehsul novunu secin (Baker,Drink,Meat,Dairy): ");
        typeStr = Console.ReadLine();
    } while (!Enum.TryParse(typeStr, out type));


    Product product = new Product(name, price, type);

    try
    {
        products[i] = product;
    }
    catch (ProductAlreadyExistsException)
    {
        Console.WriteLine("Mehsul Siyahida Movcuddur!");
    }

    for (int j = 0; j < products.Length; j++)
    {
        Console.WriteLine($"No: {products[i].No}\nName: {products[i].Name}\nPrice: {products[i].Price}\nType: {products[i].Type}");
    }
}

