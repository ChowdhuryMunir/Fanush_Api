# Fanush API

**Fanush API** is a comprehensive API designed for a modern **Human Resource Management and Payroll System**. Developed using .NET Core 8, this API provides extensive functionalities for HR management, payroll processing, and employee engagement. It features robust security, scalable architecture, and integrates various HR functionalities into a unified system.

## Features

### Employee Management
- **Employee Profiles**: Create, edit, and manage detailed profiles including contact details and demographics.
- **Job & Organization Structure**: Define job titles, departments, and visualize organizational charts.
- **Access Control & Security**: Secure login and role-based access control.
- **Employee Lifecycle Management**: Handle onboarding, transfers, promotions, terminations, and re-joining.
- **Data Import/Export**: Import and export employee data in CSV and XLSX formats.

### Recruitment Management
- **Job Postings**: Create and manage job postings with detailed descriptions.
- **Applicant Tracking System (ATS)**: Manage applications, including resume uploads and communication tools.
- **Interview Scheduling & Management**: Schedule interviews, track progress, and send offer letters.
- **Background Checks (Optional)**: Integrate background check services.

### Time and Attendance
- **Clock In/Out**: Clock in/out functionality via web, mobile app, or time clock integration.
- **Leave Management**: Manage leave types with customizable approval workflows.
- **Overtime Tracking & Management**: Track and manage overtime hours.
- **Absence Reporting & Analysis**: Generate reports and analyze absence trends.
- **Payroll Integration**: Integrate with payroll systems.
- **Learning and Development Integration**: Include training time in attendance records.

### Performance Management
- **Goal Setting & Tracking**: Set and monitor individual and team goals.
- **Performance Reviews**: Conduct performance reviews with feedback tools and self-evaluations.
- **Development Plans & Progress Tracking**: Create and track development plans.
- **Performance Reports & Analytics**: Generate performance reports with data visualization.

### Payroll Management
- **Payroll Integration or Calculation**: Integrate with payroll providers or use standalone calculation features.
- **Salary & Benefits Administration**: Manage salaries, benefits, and generate electronic pay stubs.
- **Payment Options**: Offer electronic pay stubs and multiple payment methods.
- **Tax Filing & Reporting (Optional)**: Integrate with tax filing services or provide reporting functionalities.

### Benefits Administration
- **Enrollment & Management**: Manage employee enrollment in benefits.
- **Provider Integrations**: Integrate with benefits providers.
- **Account Management**: Handle FSAs and DCAPs.
- **Communication & Education**: Communicate benefits information and educate employees.

### Learning and Development
- **LMS Integration or Training Management**: Integrate with LMS or manage training features.
- **Learning Paths & Assignments**: Create learning paths and assign courses.
- **Skill Gap Analysis & Training Needs**: Identify skill gaps and design targeted training.
- **Training Completion & Certification Tracking**: Track training completions and certifications.
- **Learning Content Delivery**: Deliver learning content in various formats.

### Employee Self Service
- **Personal Information & Pay Stubs**: Access personal information and view pay stubs.
- **Leave & Time Off Requests**: Request leave and time off.
- **Profile Updates**: Update personal details.
- **Training Materials & Progress**: Access training materials and track progress.
- **Feedback & Complaints**: Submit feedback or complaints electronically.

### Additional Features
- **Employee Engagement**: Enhance engagement through internal communication tools and recognition programs.
- **Compliance Management**: Automated compliance checks and updates.
- **Integration with Third-party Services**: Integrate with job boards, financial systems, and productivity tools.
- **Customizable Dashboards**: Dashboards for HR managers and employees.
- **Mobile Accessibility**: Mobile device access to all features.

## API Endpoints

### Employee Endpoints
- **GET /api/employees**: List all employees.
- **GET /api/employees/{id}**: Get details of a specific employee.
- **POST /api/employees**: Create a new employee record.
- **PUT /api/employees/{id}**: Update an existing employee.
- **DELETE /api/employees/{id}**: Delete an employee.

### Department Endpoints
- **GET /api/departments**: List all departments.
- **GET /api/departments/{id}**: Get details of a specific department.
- **POST /api/departments**: Create a new department.
- **PUT /api/departments/{id}**: Update an existing department.
- **DELETE /api/departments/{id}**: Delete a department.

### Payroll Endpoints
- **GET /api/payrolls**: List all payroll records.
- **GET /api/payrolls/{id}**: Get details of a specific payroll record.
- **POST /api/payrolls**: Create a new payroll record.
- **PUT /api/payrolls/{id}**: Update an existing payroll record.
- **DELETE /api/payrolls/{id}**: Delete a payroll record.

### Authentication Endpoints
- **POST /api/auth/login**: Authenticate a user and obtain a JWT token.
- **POST /api/auth/register**: Register a new user.

## Installation and Setup

### Prerequisites
- [.NET Core 8](https://dotnet.microsoft.com/download/dotnet/8.0) for API development.
- [Visual Studio](https://visualstudio.microsoft.com/) for development.
- [MSSQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or a compatible database system.

### Installation
1. **Clone the Repository**
   ```bash
   git clone https://github.com/ChowdhuryMunir/Fanush_Api.git
   cd Fanush_Api
   ```

2. **Install Dependencies**
   - Restore the project dependencies using:
     ```bash
     dotnet restore
     ```

3. **Update Configuration**
   - Update the database connection settings in the `appsettings.json` file.

4. **Apply Migrations**
   - Apply any pending migrations using:
     ```bash
     dotnet ef database update
     ```

5. **Run the Application**
   - Build and run the application using Visual Studio or the command line:
     ```bash
     dotnet run
     ```
   - The API will be available at `http://localhost:5000`.

## Usage

- **Access the API**: Use tools like Postman or cURL to interact with the API endpoints.
- **Authentication**: Obtain a JWT token using the `/api/auth/login` endpoint and include it in the Authorization header for protected endpoints.

## Contributing

Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push the branch (`git push origin feature/your-feature`).
5. Open a pull request with a description of your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributors

- **Munir Chowdhury** - [MunirChowdhurySaif](https://github.com/chowdhuryMunir)
- **Tausif Imtiaz** - [TausifImtiaz](https://github.com/TausifImtiaz)
- **Nazmul Haque** - [NazmulHaque](https://github.com/nazmulhqm)

## Contact

For questions or feedback, please contact [Munir Chowdhury](https://github.com/chowdhuryMunir).
