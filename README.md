# Fanush API

Fanush is a robust API built with ASP.NET Core 8 designed to facilitate Human Resource Management and Payroll Systems. It provides comprehensive functionalities for managing employee data, payroll processing, and various HR operations.

## Features

- **Employee Management:** Add, update, delete, and retrieve employee records.
- **Payroll Processing:** Calculate and manage employee salaries, deductions, and benefits.
- **Attendance Tracking:** Record and monitor employee attendance and working hours.
- **Leave Management:** Handle leave requests and track leave balances.
- **Reporting:** Generate detailed reports on employee performance, payroll, and attendance.

## Getting Started

To set up and run the Fanush API locally, follow these steps:

### Prerequisites

Ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any compatible database
- [Postman](https://www.postman.com/downloads/) (optional, for API testing)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/ChowdhuryMunir/Fanush_.git
   ```

2. **Navigate to the project directory:**

   ```bash
   cd Fanush_
   ```

3. **Install dependencies:**

   The project dependencies are managed via NuGet. Restore them using:

   ```bash
   dotnet restore
   ```

4. **Configure the database connection:**

   Update the `appsettings.json` file with your database connection string:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
   }
   ```

5. **Apply database migrations:**

   ```bash
   dotnet ef database update
   ```

6. **Run the API:**

   ```bash
   dotnet run
   ```

   The API will be available at `http://localhost:5000` (or the port specified in `launchSettings.json`).

## API Endpoints

### Employee Management

- **GET** `/api/employees` - Retrieve a list of employees.
- **POST** `/api/employees` - Add a new employee.
- **GET** `/api/employees/{id}` - Retrieve a specific employee by ID.
- **PUT** `/api/employees/{id}` - Update an employee's details.
- **DELETE** `/api/employees/{id}` - Delete an employee.

### Payroll Processing

- **POST** `/api/payrolls/calculate` - Calculate payroll for employees.
- **GET** `/api/payrolls/{id}` - Retrieve payroll details for a specific employee.

### Attendance Tracking

- **POST** `/api/attendance` - Record attendance.
- **GET** `/api/attendance/{employeeId}` - Retrieve attendance records for an employee.

### Leave Management

- **POST** `/api/leaves` - Request leave.
- **GET** `/api/leaves/{employeeId}` - Retrieve leave records for an employee.

### Reporting

- **GET** `/api/reports/employee-performance` - Generate performance reports.
- **GET** `/api/reports/payroll-summary` - Generate payroll summary reports.

## Usage

You can use tools like [Postman](https://www.postman.com/downloads/) to interact with the API endpoints. Below is an example of how to use the API:

```http
# Example POST request to add a new employee
POST /api/employees
Content-Type: application/json

{
  "name": "John Doe",
  "position": "Software Developer",
  "salary": 60000
}
```

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push the branch (`git push origin feature/your-feature`).
5. Open a pull request with a description of your changes.

For detailed guidelines, please refer to our [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for more details.

## Contact

For questions or feedback, please contact [Munir Chowdhury](mailto:munir.idb@gmail.com).

---

Feel free to modify or expand this template based on additional features or specific setup instructions for your project.
