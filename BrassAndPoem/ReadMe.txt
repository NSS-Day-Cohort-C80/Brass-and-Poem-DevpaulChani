🎺 📃 Brass & Poem Console Application
Introduction

In this self-assessment, you will be working on a console application named "Brass & Poem." The application represents a business that sells poetry books and brass musical instruments. Your task is to write the business logic in Program.cs and create two modules, Product.cs and ProductType.cs, with their respective class definitions. The Product class will define the properties for a product, while the ProductType class will define the properties for a product type. Additionally, you will implement a menu system in Program.cs to interact with the application.
Instructions

    🧨 At any point during development, you can run the dotnet test command in your terminal to run the suite of tests for this program and see how you're doing.

Create the Project

    Request the Github Classroom link for the assignment from your instructor.
    Clone your new repo that Github classroom created to your local computer and open it in VS Code.
    For the rest of these instructions, the files will be referring to files inside the BrassAndPoem folder. You can look at the BrassAndPoem.Tests folder if you wish, but you do not need to modify any code there.

Console.Clear and Console.ReadKey

Do not use Console.Clear or Console.ReadKey in this assessment. You also do not need to include try/catch or other error handling.
Define the ProductType Class

a. Inside the ProductType.cs file, create a class named ProductType. b. Add the following property to the ProductType class:

    Title (string): Represents the title of the product type.
    Id (int) : Represents a unique Id for the product type

Define the Product Class

a. Inside the Product.cs file, create a class named Product. b. Add the following properties to the Product class:

    Name (string): Represents the name of the product.
    Price (decimal): Represents the price of the product.
    ProductTypeId (int): Represents the id for the product's product type

Create the program loop

    Declare a list of product types and a list of products. When creating the lists, add at least two product types and five products.
    Display a welcome message for the application
    Create a loop that asks the user to choose an option, and will continue running until the use selects 5, at which point the program will finish.

Implement the Menu System in Program.cs

Inside the Program.cs file , you will implement the following methods underneath the loop (detailed instructions for each below).

All of the methods should accept two parameters, in this order:

    The list of products
    The list of product types

To test whether these methods work, add logic to the program loop to call the appropriate method when a user chooses an option:

    DisplayMenu

    DisplayAllProducts

    DeleteProduct

    AddProduct

    UpdateProduct

Now run dotnet test to see if the tests for this feature pass.
Implement the DisplayMenu Method

    The DisplayMenu method should display the following options to the console:

    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit

Now run dotnet test to see if the tests for this feature pass.
Implement the DisplayAllProducts Method

    Iterate over the products and display each product's name and price on a new line in the console. Start the line with the number of that product in the List (have the list start with 1, not 0).
    Add the product type title to the product display. HINT: You will need to use a Linq method to get the product type for each product.

Now run dotnet test to see if the tests for this feature pass.
Implement the DeleteProduct Method

    Display the products and prompt the user to enter the number of the product they want to delete.
    Remember that the list should start from 1.
    Find the product with the provided number and remove it from the list of products.

Now run dotnet test to see if the tests for this feature pass.
Implement the AddProduct Method

    Prompt the user to enter the name and price of the new product (in this order).
    Display the ProductTypes and prompt the user to choose a type for the new product.
    Create a new instance of the Product class using the provided information.
    Add the newly created product to the list of products.

Now run dotnet test to see if the tests for this feature pass.
Implement the UpdateProduct Method

    Display the products and prompt the user to enter the number of the product they want to update.
    Find the product with the provided number and retrieve its reference.
    Remember that the list should start from 1.
    Prompt the user to enter the updated name, price and product type for the product (in that order). If the user presses enter without typing anything, leave the property unchanged.
    Update the product's properties with the provided information.

Now run dotnet test to see if the tests for this feature pass.