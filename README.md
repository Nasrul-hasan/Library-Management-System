
# 📚 Library Management System (.NET Framework)

A Windows-based Library Management System developed using the .NET Framework and C#. This application enables librarians to manage books, users, and book borrowing/returning efficiently through a user-friendly interface.

## 🚀 Features

- 📖 Add, edit, and delete books  
- 👤 Register and manage library members  
- 📆 Issue and return books with due date tracking  
- 🔍 Search for books and users  
- ❌ Prevent double-issuing of books  
- 🖥️ Windows Forms-based GUI  

## 🛠️ Technologies Used

- **.NET Framework**
- **C#**
- **Windows Forms**
- **SQL Server**
- **ADO.NET** (for database interaction)

## 📂 Project Structure

```
LibraryManagementSystem/
│
├── Forms/                    # User Interface (Windows Forms)
│   ├── MainForm.cs
│   ├── BookForm.cs
│   ├── MemberForm.cs
│   └── IssueReturnForm.cs
│
├── Models/                   # C# classes for data representation
│   ├── Book.cs
│   ├── Member.cs
│   └── Transaction.cs
│
├── Data/                     # Database connection and queries
│   └── DatabaseHelper.cs
│
├── LibraryManagementSystem.sln  # Visual Studio Solution
└── README.md                 # Project documentation
```

## ⚙️ Getting Started

### Prerequisites

- Visual Studio (2019 or later)
- SQL Server (Express or full version)
- .NET Framework (4.7.2 or compatible)

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/Nasrul-hasan/Library-Management-System.git
   ```

2. **Open the Project**

   - Open the solution file `LibraryManagementSystem.sln` in Visual Studio.

3. **Set Up the Database**

   - Run the SQL script (if provided) to create the `LibraryDB` database.
   - Update the connection string in `DatabaseHelper.cs` with your SQL Server credentials.

4. **Run the Application**

   - Press `F5` in Visual Studio to build and launch the application.

## 📌 Future Improvements

- ✅ Add reporting features (e.g., most borrowed books, overdue reports)
- 🌐 Web version using ASP.NET Core
- 📧 Email notifications for due books
- 🧑‍🤝‍🧑 Role-based access (Admin, Librarian)

## 📃 License

This project is licensed under the **MIT License**.

## 🤝 Contributing

Contributions are welcome! Feel free to fork the project and submit a pull request.

---

**Developed with ❤️ by [Nasrul Hasan](https://github.com/Nasrul-hasan)**
