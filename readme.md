# LibraLend Library System

## 🚀 Overview

LibraLend is a modern, feature-rich library management system built in C# for Windows. Designed with an intuitive interface and robust backend, it streamlines the process of managing books, users, and transactions for libraries of any size. Whether you're a librarian, student, or administrator, LibraLend makes library operations efficient and enjoyable.

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET Framework (WinForms)
- **IDE:** Visual Studio
- **Database:** MySQL (via MySql.Data)
- **UI Library:** Guna.UI2 for sleek, modern WinForms controls
- **Other Libraries:**
  - BouncyCastle (security/cryptography)
  - Google.Protobuf (data serialization)
  - K4os.Compression.LZ4 (fast compression)
  - System.Configuration.ConfigurationManager (config management)

## ✨ Key Features

- 🔒 Secure user authentication (Login/Sign Up)
- 📚 Comprehensive book catalog management (add, view, categorize, and search books)
- 📖 Real-time book borrowing and reservation tracking
- 👤 User management (borrower records, profiles, and history)
- 📊 Dashboard with statistics and quick actions
- 🖼️ Organized book images and resources
- 💡 Clean, modern, and responsive Windows Forms interface
- 🛡️ Data integrity and error handling

## 📂 Project Structure

```
FInalLibrarySystem-ken5/
├── App.config                  # Application configuration
├── FInalLibrarySystem.csproj   # Project file
├── FInalLibrarySystem.sln      # Solution file
├── Program.cs                  # Main entry point
├── readme.md                   # Project documentation
├── Book List/                  # Book lists and images
│   ├── Book List.txt
│   ├── Academic Books/
│   ├── Fictional Books/
│   └── Non-Fictional Books/
├── Database/                   # Database models and connection
│   ├── BookBorrows.cs
│   ├── BookReserved.cs
│   ├── Books.cs
│   ├── MyDB.cs
│   └── Users.cs
├── Forms/                      # WinForms UI and panels
│   ├── Login.cs
│   ├── Main Page.cs
│   ├── SignUp.cs
│   ├── Book Borrowing/
│   ├── Booklist Panels/
│   ├── BorrowerList/
│   ├── Main Page Panels/
│   └── SignUp Panels/
├── Icons/                      # App icons
├── Images/                     # UI and book images
├── Properties/                 # Project properties
├── Resources/                  # Embedded resources
├── bin/                        # Build output
├── obj/                        # Build intermediates
└── packages/                   # NuGet and external packages
```

## 🏁 Getting Started

1. **Clone or download** this repository.
2. Open `FInalLibrarySystem.sln` in Visual Studio.
3. Restore NuGet packages if prompted.
4. Build the solution (Ctrl+Shift+B).
5. Ensure MySQL is running and configured as per `Database/MyDB.cs`.
6. Run the application (F5) and start managing your library!

## 📄 Sample Database SQL (Excerpt)
Below is an excerpt from the included `csharp_lms_db.sql` file, which you can find in this repository. Use this file to set up your MySQL database for LibraLend.

```sql
-- Database: `csharp_lms_db`
CREATE DATABASE IF NOT EXISTS `csharp_lms_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `csharp_lms_db`;

-- Table structure for table `app_users`
CREATE TABLE `app_users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `email` varchar(100) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `middle_initial` char(5) DEFAULT NULL,
  `role` varchar(20) DEFAULT NULL,
  `department` varchar(100) DEFAULT NULL,
  `studentID` varchar(20) DEFAULT NULL,
  `employeeID` varchar(20) DEFAULT NULL,
  `section` varchar(50) DEFAULT NULL,
  `year` varchar(10) DEFAULT NULL,
  `picture` longblob DEFAULT NULL,
  `money` int(11) NOT NULL DEFAULT 0,
  `debt` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci COMMENT='Users table for FinalLibrarySystem';

-- Sample data for `app_users`
INSERT INTO `app_users` (`id`, `username`, `password`, `email`, `first_name`, `last_name`, `middle_initial`, `role`, `department`, `studentID`, `employeeID`, `section`, `year`, `picture`, `money`, `debt`) VALUES
(1, 'kenjoy', '123', 'kenpatrickgarcia123@gmail.com', 'Ken Patrick', 'Garcia', 'A.', 'Student', 'N/A', '123', 'N/A', 'ACSAD', 'IV', NULL, 123, 0);
```

> The full SQL file contains all tables, indexes, and sample data. Please refer to `csharp_lms_db.sql` for the complete schema and data setup.

## 🗄️ Database Schema

The SQL file `csharp_lms_db.sql` is included in this repository. It contains the full database schema for LibraLend, including sample data for users. To set up the database:

1. Open your MySQL client (such as phpMyAdmin, MySQL Workbench, or command line).
2. Run the `csharp_lms_db.sql` script to create the required database and tables, and insert sample data.
3. Update your connection settings in `Database/MyDB.cs` if needed.

> **Note:** The SQL file also contains tables for related systems (such as shop and student management) and sample data for demonstration purposes. You may customize or remove these as needed for your deployment.

## 💡 Notes & Tips

- All dependencies are included in the `packages/` folder for easy setup.
- Book images and resources are organized under `Book List/` and `Images/`.
- For customization, update the database connection in `Database/MyDB.cs`.
- The UI is fully customizable using Guna.UI2 controls for a modern look.
- For troubleshooting, check the `bin/Debug/` folder for logs and outputs.

## 📸 Screenshots

> _Add screenshots of the login page, main dashboard, and book management panels here to showcase the UI._

## 🤝 Contributing

Contributions are welcome! Feel free to fork this repository, submit issues, or open pull requests to improve LibraLend.

## 📄 License

This project is for educational and demonstration purposes. For other uses, please contact the author.

## 👥 Collaborators

This project was developed by the following team:

- **Ken Patrick Garcia** — Project Leader & Lead Developer
- Sebastian Baluyut
- Brian Papa
- Timothy Forte
- Lanz Corpuz
- Mars Maguddayao

We worked together to design, develop, and refine LibraLend for an optimal library management experience.

## 🌐 Repository

This is the official development repository for LibraLend:
[https://github.com/KpG782/FInalLibrarySystem/tree/ken5#](https://github.com/KpG782/FInalLibrarySystem/tree/ken5#)
