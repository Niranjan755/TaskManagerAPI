# Task Manager API

This project is a RESTful API for managing tasks, built with ASP.NET Core and JWT authentication. It allows users to register, log in, and then perform CRUD operations on their tasks.

## Features

* User registration and login with JWT authentication
* Create, read, update, and delete tasks
* User-specific task management (users can only access their own tasks)
* Secure storage of JWT secret key (using environment variables or user secrets)
* Basic HTML, CSS, and JavaScript frontend for interacting with the API

## Technologies Used

* ASP.NET Core 6+
* Entity Framework Core (with InMemory database or SQL Server)
* JWT (JSON Web Tokens)
* ASP.NET Core Identity
* HTML, CSS, JavaScript

## Getting Started

1. **Clone the repository:** `git clone https://github.com/Niranjan755/TaskManagerAPI.git`
2. **Install .NET SDK:** Download and install the latest .NET SDK from the official Microsoft website.
3. **Set up the database:**
    * **InMemory:** No setup needed (used by default).
    * **SQL Server:**
        * Install SQL Server (if you haven't already).
        * Update the connection string in `appsettings.json`.
        * Run database migrations: `dotnet ef database update`
4. **Generate a JWT secret key:**
    * Use the `JwtHelper.GenerateJwtSecretKey()` method in `JwtHelper.cs` to generate a secure key.
    * Store the key securely in environment variables or user secrets (see instructions in `Program.cs`).
5. **Run the application:** `dotnet run`
6. **Access the API:**
    * **Frontend:** Open `index.html` in your browser.
    * **API testing tool:** Use Postman, Insomnia, or similar tools to interact with the API endpoints.

## API Endpoints

* **Authentication:**
    * `POST /api/auth/register`: Register a new user
    * `POST /api/auth/login`: Log in a user
* **Tasks:**
    * `GET /api/tasks`: Get all tasks for the logged-in user
    * `POST /api/tasks`: Create a new task
    * `GET /api/tasks/{id}`: Get a specific task by ID
    * `PUT /api/tasks/{id}`: Update a task
    * `DELETE /api/tasks/{id}`: Delete a task

## Future Enhancements

* Implement task completion status
* Add task filtering and sorting
* Integrate a more advanced frontend framework (e.g., React, Vue, Angular)
* Implement user roles and permissions
* Generate API documentation with Swagger/OpenAPI
* Add unit and integration tests
* Deploy to a cloud platform (e.g., Azure, AWS, Google Cloud)

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

## License

This project is licensed under the MIT License.
