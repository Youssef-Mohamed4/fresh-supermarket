# Fresh Supermarket

Fresh Supermarket is a modern web application built with ASP.NET Core MVC (.NET 10). It provides an online storefront where users can browse products, add items to their shopping cart, and manage their orders.

## Features

- **Product Catalog**: Browse a wide selection of supermarket products.
- **Shopping Cart**: Add, update, and remove items from your cart before checkout.
- **User Authentication**: Secure registration and login using ASP.NET Core Identity.
- **Role-based Authorization**: Separation of privileges between regular Users and Administrators.
- **Admin Dashboard**: Manage products, users, and overall store configurations (Restricted to Admin role).

## Tech Stack

- **Framework**: ASP.NET Core MVC (.NET 10.0)
- **Database**: SQLite (via Entity Framework Core)
- **Authentication**: ASP.NET Core Identity
- **Styling**: HTML/CSS & Bootstrap (Default ASP.NET MVC template)

## Getting Started

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
- A code editor or IDE (Visual Studio, Visual Studio Code, or JetBrains Rider)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Youssef-Mohamed4/fresh-supermarket.git
   cd WebProject
   ```

2. **Apply Database Migrations:**
   The project uses SQLite and Entity Framework Core. The database migrations and seeding are applied automatically on startup in `Program.cs`. Alternatively, you can apply them manually:
   ```bash
   dotnet ef database update
   ```

3. **Run the Application:**
   ```bash
   dotnet run
   ```

4. **Access the Application:**
   Open your browser and navigate to the local URL provided in the console output (usually `https://localhost:5001` or `http://localhost:5000`).

## Default Accounts

On the first run, the database is automatically seeded with default roles and an administrator account:

- **Email:** `admin@supermarket.com`
- **Password:** `Admin123!`

## Project Structure

- `Controllers/`: Handles incoming HTTP requests and application logic.
- `Models/`: Contains domain entities (`Product`, `CartItem`, `ApplicationUser`).
- `Views/`: Razor views for the user interface.
- `Data/`: Entity Framework Core context and database configuration.
- `wwwroot/`: Static files (CSS, JS, images).

