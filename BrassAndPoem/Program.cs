using BrassAndPoem;

//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>
{
    new Product { Name = "brass1", Price = 150.99M,   ProductTypeId = 1 },
    new Product { Name = "brass2", Price = 246.99M,   ProductTypeId = 1 },
    new Product { Name = "brass3", Price = 1250.99M,  ProductTypeId = 1 },
    new Product { Name = "poem1", Price = 12350.99M, ProductTypeId = 2 },
    new Product { Name = "poem2", Price = 15650.99M, ProductTypeId = 2 }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.

List<ProductType> productTypes = new List<ProductType>
{
    new ProductType { Id = 1, Title = "Brass" },
    new ProductType { Id = 2, Title = "Poem" }
};

//put your greeting here

Console.WriteLine("Welcome to Brass & Poem!");
Console.WriteLine("Your one-stop shop for brass instruments and poetry.");
Console.WriteLine();

//implement your loop here

string choice = "";
while (choice != "5")
{
    DisplayMenu();
    Console.Write("Choose an option: ");
    choice = Console.ReadLine();

    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye!");
    }
    else
    {
        Console.WriteLine("Please choose a valid option (1-5).");
    }
}

void DisplayMenu()
{
    Console.WriteLine("1. Display all products");
    Console.WriteLine("2. Delete a product");
    Console.WriteLine("3. Add a new product");
    Console.WriteLine("4. Update product properties");
    Console.WriteLine("5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Product p = products[i];
        ProductType type = productTypes.FirstOrDefault(pt => pt.Id == p.ProductTypeId);
        string typeTitle = type != null ? type.Title : "Unknown";
        Console.WriteLine($"{i + 1}. {p.Name} ({typeTitle}) - ${p.Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.Write("Enter the number of the product to delete: ");
    string input = Console.ReadLine();
 
    if (int.TryParse(input, out int number) && number >= 1 && number <= products.Count)
    {
        Product toRemove = products[number - 1];
        products.Remove(toRemove);
        Console.WriteLine($"{toRemove.Name} has been deleted.");
    }
    else
    {
        Console.WriteLine("Invalid selection.");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Write("Enter the name of the new product: ");
    string name = Console.ReadLine();
 
    Console.Write("Enter the price of the new product: ");
    string priceInput = Console.ReadLine();
    decimal.TryParse(priceInput, out decimal price);
 
    Console.WriteLine("Choose a product type:");
    foreach (ProductType pt in productTypes)
    {
        Console.WriteLine($"{pt.Id}. {pt.Title}");
    }
    Console.Write("Enter the product type id: ");
    string typeInput = Console.ReadLine();
    int.TryParse(typeInput, out int typeId);
 
    Product newProduct = new Product
    {
        Name = name,
        Price = price,
        ProductTypeId = typeId
    };
    products.Add(newProduct);
    Console.WriteLine($"{newProduct.Name} has been added.");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.Write("Enter the number of the product to update: ");
    string input = Console.ReadLine();
 
    if (!int.TryParse(input, out int number) || number < 1 || number > products.Count)
    {
        Console.WriteLine("Invalid selection.");
        return;
    }
 
    Product product = products[number - 1];
 
    Console.Write($"Enter a new name (press enter to keep \"{product.Name}\"): ");
    string newName = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newName))
    {
        product.Name = newName;
    }
 
    Console.Write($"Enter a new price (press enter to keep {product.Price}): ");
    string newPriceInput = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newPriceInput) && decimal.TryParse(newPriceInput, out decimal newPrice))
    {
        product.Price = newPrice;
    }
 
    Console.WriteLine("Available product types:");
    foreach (ProductType pt in productTypes)
    {
        Console.WriteLine($"{pt.Id}. {pt.Title}");
    }
    Console.Write($"Enter a new product type id (press enter to keep {product.ProductTypeId}): ");
    string newTypeInput = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newTypeInput) && int.TryParse(newTypeInput, out int newTypeId))
    {
        product.ProductTypeId = newTypeId;
    }
 
    Console.WriteLine($"Product updated.");
}

// don't move or change this!
public partial class Program { }