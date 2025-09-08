# 🗂️ Task Manager

A sleek, responsive task management dashboard built with **Blazor**, **.NET**, and **Entity Framework Core**.
Designed for productivity, clarity, and scalability, this app empowers users to manage tasks efficiently with robust authentication, intuitive UI, and real-time feedback.

## 🚀 Features

- 🔐 **Authentication & Session Management**
  - Secure login/logout flow
  - Multi-user support
  - Session persistence with Blazored libraries

- 📝 **Task CRUD Operations**
  - Create, edit, delete tasks with validation
  - Overdue task highlighting
  - Modular forms with loading states and feedback

- 🔍 **Advanced Filtering & Search**
  - Filter by status, due date, or keyword
  - Real-time search

- 📊 **Dashboard UX**
  - Responsive layout with Bootstrap
  - Icon-based action buttons
  - Pagination and modular report generation

- ⚙️ **Architecture Highlights**
  - Clean separation of concerns
  - EF Core-backed data modeling with composite keys
  - Caching and async patterns for performance

## 🛠️ Technologies Used

| Layer            | Stack                          |
|------------------|--------------------------------|
| Frontend         | Blazor WebAssembly             |
| Backend          | ASP.NET Core                   |
| Database         | Entity Framework Core + SQL    |
| State Management | Blazored.LocalStorage / Session|
| Styling          | Bootstrap + Custom CSS         |

## 📦 Getting Started

1. **Clone the repo**
   ```bash
   git clone https://github.com/FadyTawadrous/TaskManager.git

2. **Set up the database**
- Update appsettings.json with your connection string
- Run EF Core migrations:
  
- dotnet ef migrations add InitialMigration
- dotnet ef database update

3. **Run the app**
- dotnet run

✅ Validation & Feedback
- Form-level validation using
- Real-time error/success messages
- Accessibility-first design


📌 Roadmap
- 🔄 Task reminders & notifications
- 📱 Mobile-friendly layout
