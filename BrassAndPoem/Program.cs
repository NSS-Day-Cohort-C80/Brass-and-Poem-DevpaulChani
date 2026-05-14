using BrassAndPoem;

//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>
{
    new Product {Name = "Trumpet", Price = 150.99M, ProductTypeId = 1},
    new Product {Name = "Trombone", Price = 246.99M, ProductTypeId = 1},
    new Product {Name = "Tuba", Price = 1250.99M, ProductTypeId = 1},
    new Product {Name = "Ozymandias", Price = 12350.99M, ProductTypeId = 2},
    new Product {Name = "Leaves of Grass", Price = 15650.99M, ProductTypeId = 2}
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
        ProductType type = productTypes.Find(productType => productType.Id == p.ProductTypeId);
        Console.WriteLine($"{i + 1}. {p.Name} ({type.Title}) - ${p.Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.Write("Enter the number of the product to delete: ");
    int number = int.Parse(Console.ReadLine());

    Product toRemove = products[number - 1];
    products.Remove(toRemove);
    Console.WriteLine($"{toRemove.Name} has been deleted.");
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Write("Enter the name of the new product: ");
    string name = Console.ReadLine();

    Console.Write("Enter the price of the new product: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Choose a product type:");
    foreach (ProductType productType in productTypes)
    {
        Console.WriteLine($"{productType.Id}. {productType.Title}");
    }
    Console.Write("Enter the product type id: ");
    int typeId = int.Parse(Console.ReadLine());

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
    int number = int.Parse(Console.ReadLine());

    Product product = products[number - 1];

    Console.Write($"Enter a new name (press enter to keep \"{product.Name}\"): ");
    string newName = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newName))
    {
        product.Name = newName;
    }

    Console.Write($"Enter a new price (press enter to keep {product.Price}): ");
    string newPriceInput = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newPriceInput))
    {
        product.Price = decimal.Parse(newPriceInput);
    }

    Console.WriteLine("Available product types:");
    foreach (ProductType productType in productTypes)
    {
        Console.WriteLine($"{productType.Id}. {productType.Title}");
    }
    Console.Write($"Enter a new product type id (press enter to keep {product.ProductTypeId}): ");
    string newTypeInput = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newTypeInput))
    {
        product.ProductTypeId = int.Parse(newTypeInput);
    }

    Console.WriteLine($"Product updated.");
}

// don't move or change this!
public partial class Program { }