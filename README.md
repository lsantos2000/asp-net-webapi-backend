# GameStore - Backend

GameStore Backend is an ASP.NET Core application that manages a collection of games and genres. This project demonstrates the use of Entity Framework Core for database operations.

An optional, corresponding frontend (using Blazor) is available at https://github.com/lsantos2000/asp-net-webapi-blazor-frontend

## Features

- Manage games and genres
- Seed initial data into the database
- Perform CRUD operations on games and genres

## Getting Started

### Prerequisites

To run the GameStore API project, ensure you have the following prerequisites installed:

1. .NET SDK 8.0: This project targets .NET 8.0. You can download the .NET SDK from the official .NET website.

2. Entity Framework Core Tools: The project uses Entity Framework Core for data access. Ensure you have the EF Core tools installed.

3. SQLite: The project uses SQLite as the database provider. Ensure you have SQLite installed on your system. You can download it from the official SQLite website.

4. Minimal APIs Extensions: The project uses Minimal APIs Extensions. This package is included in the project dependencies and will be restored automatically.

5. Swashbuckle.AspNetCore: This package is used for generating Swagger documentation. It is included in the project dependencies and will be restored automatically.

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/lsantos2000/sap-net-webapi-backend.git
   cd GameStore
   ```

2. Navigate to the project directory:

   ```sh
   cd GameStore
   ```

3. The demo uses SQLite, if you use a different provider, update the database connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=GameStoreDb;User Id=your_user;Password=your_password;"
   }
   ```

4. Apply migrations and seed the database:

   ```sh
   dotnet tool install --global dotnet-ef
   dotnet ef database update
   ```

   Note:

   - the code is prrepared to apply all migrations at startup, if does not find a database or they are not applied yet.
   - the migrations are already in the Data\Migrations folder. To get them, these commands were executed:

   ```sh
   dotnet ef migrations add InitialCreate --output-dir Data\Migrations
   dotnet ef database update
   ```

5. Run the application:

   ```sh
   dotnet restore
   dotnet run
   ```

This will start the API server, and you can access it at http://localhost:5000 by default.

### Usage

- Access the application at `https://localhost:5001` or `http://localhost:5000`.

## Project Structure

- `Controllers/`: Contains the API controllers.
- `Data/`: Contains the database context and seed data.
- `Models/`: Contains the entity models.
- `Migrations/`: Contains the EF Core migrations.

## Database Seeding

The `GameStoreContext` class seeds initial data into the `Genres` and `Games` tables. This is done in the `OnModelCreating` method.

## More details

The provided code defines a class GameStoreContext that inherits from DbContext, which is part of the Entity Framework Core (EF Core) library. This class is responsible for managing the database context for a game store application. The constructor of the GameStoreContext class takes DbContextOptions<GameStoreContext> as a parameter and passes it to the base DbContext class. This allows the configuration of the database context to be specified externally, such as the connection string and other options.

Within the GameStoreContext class, two properties are defined: Games and Genres. These properties are of type DbSet<T>, where T is the entity type. DbSet<Game> and DbSet<Genre> represent collections of Game and Genre entities, respectively. These properties enable CRUD (Create, Read, Update, Delete) operations on the Game and Genre tables in the database.

The OnModelCreating method is overridden to configure the model using the ModelBuilder instance. This method is called by the Entity Framework when the model for the context is being created. Inside this method, the HasData method is used to seed initial data into the Genre and Game tables. The HasData method takes an array of anonymous objects that represent the initial data to be inserted into the database.

For the Genre entity, five records are seeded with predefined Id and Name values. Similarly, for the Game entity, five records are seeded with predefined values for Id, Title, GenreId, Name, Price, and ReleaseDate. The ReleaseDate is specified using the DateOnly struct, which represents a date without a time component.

Overall, this code sets up the database context for a game store application, defines the Game and Genre entities, and seeds initial data into the database tables. This setup is essential for the application to interact with the database and perform operations on the Game and Genre entities.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

### License

This project is licensed under the MIT License.

Code based, and modified for demo purposes, on the source code of the YouTube video "ASP.NET Core Full Course For Beginners" by Julio Casal.

Check out Julio at https://dotnetacademy.io
Watch the video at https://www.youtube.com/watch?v=AhAxLiGC7Pc and https://www.youtube.com/watch?v=RBVIclt4sOo
I encourage you to visit the above links and follow the original author.
