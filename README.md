

## 🚀 ASP.NET MVC CRUD Application – ZesTec Assignment Submission

 ✅ Project Overview

This project is a **CRUD web application** developed using **ASP.NET CORE MVC** and follows modern software engineering principles such as:

* Repository Pattern
* Dependency Injection (DI)
* Data Abstraction via DAL
* ASP.NET Identity Framework for secure authentication
* Google OAuth for external login
* Entity Framework Core (Code First approach)
* Clean, modular architecture (MVC + ViewModels)
* Responsive Grid View display for data interaction

---

 🧩 Key Features Implemented

 1. 🔁 CRUD Operations for Employee Entity

* Create, Read, Update, Delete operations implemented for an `Employee` model.
* Grid View using Razor views (Index.cshtml) for listing employee records.
* Validation and clean UI for all forms.

 2. 🏗 Repository & Data Access Layer

* **`IEmployeeDal` interface** abstracts the data operations.
* **`EmployeeSqlDal` class** provides SQL-based implementation.
* Loose coupling enables easier testing and future refactoring.

3. 🧬 Dependency Injection

* DAL injected into the controllers using built-in DI container in .NET.
* Promotes maintainability and testability.

4. 🔐 Authentication & Authorization

* Fully integrated **ASP.NET Core Identity Framework**.
* Users can register/login using their email-password.
* Roles/claims can be added as required.

 5. 🌐 Google OAuth Integration

* Secure **external login using Google** configured in `Startup.cs` and via Identity.
* Promotes flexibility and modern login options.

6. 📁 Entity Framework Core (Code First)

* Code-first approach with clear entity definitions (`Employee`, `ApplicationUser`).
* Migration history is tracked in the `Migrations` folder.
* DB context is `EmpDbContext`.

 7. 🧪 Validation and Error Handling

* ViewModels (`LoginViewModel`, `RegisterViewModel`) used for form handling.
* Strong validation attributes for better UX.
* Global error handling via shared error views.

8. 📊 User Interface

* Razor Views (cshtml) for every operation.
* Consistent layout using `_Layout.cshtml`.
* `_ValidationScriptsPartial.cshtml` for unobtrusive client-side validation.

---

📂 Folder Structure

```
Controllers/
  - HomeController.cs
  - AccountController.cs
  - EmployeeController.cs

Models/
  - Employee.cs
  - EmpDbContext.cs
  - ApplicationUser.cs
  - IEmployeeDal.cs
  - EmployeeSqlDal.cs

ViewModels/
  - LoginViewModel.cs
  - RegisterViewModel.cs

Views/
  - Account/
  - Employee/
  - Shared/
  - Home/
```

---

 ✅ How to Run This Project

1. Clone this repository.
2. Add your Google OAuth credentials in `appsettings.json`.
3. Update the DB connection string in `EmpDbContext`.
4. Run migrations:

   ```bash
   dotnet ef database update
   ```
5. Run the app using IIS Express / Kestrel from Visual Studio.

---

📌 Submission Info

* Task approved by trainer ✅
* Code pushed to GitHub ✅
* GitHub link submitted via email ✅
* Deadline Met: **22nd May 2025, 3:00 PM** ⏰

---

📧 Contact

Feel free to contact me for any clarifications or walkthrough of the codebase:
**\[Your Name] - .NET Developer**
📧 Email: Prasadmohite0302@gmail.com
📞 Phone: +91-9325213404

---
![image](https://github.com/user-attachments/assets/d48c4021-7d57-42f9-b392-af4350f75ad7)


