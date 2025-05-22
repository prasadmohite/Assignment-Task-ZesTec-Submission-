

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

* Secure **external login using Google** configured in `Program.cs` and via Identity.
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


📧 Contact

Feel free to contact me for any clarifications or walkthrough of the codebase:
**\[Your Name] - .NET Developer**
📧 Email: Prasadmohite0302@gmail.com
📞 Phone: +91-9325213404

---
Dashoard!

![image](https://github.com/user-attachments/assets/d48c4021-7d57-42f9-b392-af4350f75ad7)

Login Requre!

![image](https://github.com/user-attachments/assets/5c593c8c-a07a-4f44-86f1-50e0884109ae)

Login Page With Google login integration

![image](https://github.com/user-attachments/assets/682db49e-b867-4678-9bf9-ea772bd0d91a)

Register Page With Google singup intergration

![image](https://github.com/user-attachments/assets/71bd6286-a066-45b5-9bb6-9fa342520121)


After Login only u can perform task,External/Google Login Also Added[OAuth}//Due to Privecy the client id and secreat cannot share in app.jason

![image](https://github.com/user-attachments/assets/ec018770-f177-435d-8cfc-97feac69728c)

Created with full Validation

![image](https://github.com/user-attachments/assets/84aef5e4-7f53-4b0c-a4d9-fa4d9466a1b3)

Edit

![image](https://github.com/user-attachments/assets/90a3579b-37ee-426b-9c80-c8c5d1180cc0)

Details

![image](https://github.com/user-attachments/assets/e2848e4d-3a3c-4481-b6f6-ceb335322527)

Delete

![image](https://github.com/user-attachments/assets/062549e3-ec40-4b85-ab5d-034e131983d4)






