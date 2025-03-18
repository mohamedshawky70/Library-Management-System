# BookHaven MVC Project

# Project Mind Map
![Image](https://github.com/user-attachments/assets/06bbdbdd-522a-4dc3-9943-8526af52bf4a)
![Image](https://github.com/user-attachments/assets/4f3fd1e3-8325-41d1-b714-941a524956e7)
## Glimpse of the working solution
![Image](https://github.com/user-attachments/assets/fcd75342-56d5-43d3-a6ed-c8217fc7ffbb)

![Image](https://github.com/user-attachments/assets/b0052b40-91e6-469e-8cea-ce320c8514bc)

![Image](https://github.com/user-attachments/assets/203515d1-8e1f-4720-bcfc-1bc9b216ab84)

![Image](https://github.com/user-attachments/assets/04379ed9-4b8e-4876-b3de-7d7e1d920fab)

![Image](https://github.com/user-attachments/assets/b64d7084-29cc-48e4-b04f-ffe0eed94fc1)

![Image](https://github.com/user-attachments/assets/d1c8ecd4-0033-4381-b7c5-8d526e71ea88)

![Image](https://github.com/user-attachments/assets/13982ca6-8343-4811-bfbf-a6443f3fd7fc)

![Image](https://github.com/user-attachments/assets/f7b1c331-6071-4a65-9819-75379d23f4f3)

![Image](https://github.com/user-attachments/assets/522a6c9b-0668-4b37-a483-19663aa3accf)

![Image](https://github.com/user-attachments/assets/097bd1ad-55f6-4b23-91cb-35d660472b9a)
![Image](https://github.com/user-attachments/assets/d357ed33-b9c2-4e31-b40e-cc46b1056b06)

![Image](https://github.com/user-attachments/assets/468df2b2-4845-4f9c-9c14-7e01e0967b7c)

![Image](https://github.com/user-attachments/assets/10d71b06-ab75-4525-b983-6a12157beb34)

![Image](https://github.com/user-attachments/assets/13bb6098-413d-44ae-9de2-a78446ba62f4)

![Image](https://github.com/user-attachments/assets/2bb8d7ce-3116-4b0a-9fdc-00fba3cf7a15)

![Image](https://github.com/user-attachments/assets/9f186473-600a-4cb5-8af1-7f6757314a49)

![Image](https://github.com/user-attachments/assets/265b381b-08e3-45da-a908-1b02305a51c0)

![Image](https://github.com/user-attachments/assets/7060cb45-75b0-4654-86f7-d6258a6029c9)

![Image](https://github.com/user-attachments/assets/4862cfc8-da85-4309-b2c1-a7592ab62939)

![Image](https://github.com/user-attachments/assets/5f2004f0-d373-490d-a84e-7910a9df3be2)

![Image](https://github.com/user-attachments/assets/c01f8e54-884c-4018-98d9-cec290abb8ab)

![Image](https://github.com/user-attachments/assets/82820eeb-a96c-41c3-bf6a-cc08aadd73fb)

![Image](https://github.com/user-attachments/assets/d99a463a-4911-4a86-bb80-e761ec21f72b)

![Image](https://github.com/user-attachments/assets/7feac322-7aba-47bf-b866-b729064e3ef2)

## Project Overview

**Objective:** This is a Library Management System (LMS) web application built with .NET Core, designed to streamline the process of managing books, users, and borrowing records in a library. The system allows librarians and administrators to track books, users, issue/return books, and manage user roles.

## Tech Stack
-Backend: .NET Core 8 
-Frontend: HTML, CSS (Bootstrap or other frameworks can be used)
-Database: SQL Server (or SQLite for local setup)
-Authentication: ASP.NET Core Identity for user authentication
-ORM: Entity Framework Core for database interactions

## Key Features
-**Clean Architecture**: design for building robust, maintainable, testable systems and separation of concerns, independence from frameworks,and a clear structure of dependencies.it’st suited for larger projects 
-**WhatsApp Integration**: Subscribers and Users can receive notifications and updates via WhatsApp (e.g., book availability, due dates, reminders).

-**Email notificatin**: Subscribers and Users can receive notifications like welcom notification and renew notification. 

-**background tasks**: operations that run asynchronously or in the background, typically without direct interaction with a user.

-**Export Reports**:Export Excel sheet and Pdf for books , rentals and delay in rentals.

-**Save Images**:Save images on cloud (Cloudinary).

-**User Authentication**: Admin and user login functionality.

-**Book Management**: Add, update, delete, and search books in the library.

-**Borrowing System**: Issue and return books with due dates.

-**User Management**: Manage user profiles and roles (Admin/User).

-**Search Functionality**: Search for books by title and search for subscriber by email ,notional id phon number.

-**Book Categories**: Organize books by genre/category.

-**Responsive UI**: A simple, clean, and responsive user interface.




## Development Focus

### 1. [Genaric Repository Pattern](#repository-pattern)
- **Description:** Implement the Repository Pattern to abstract data access logic, making the code more testable and maintainable. 
- **Functionality:**
  - **Genaric Repository Pattern:** Simplifies data access by providing a consistent API for CRUD operations.
  - **Unit of Work:** Manages transactions across multiple repositories, ensuring data integrity.


### 2. [Entity Framework Core](#entity-framework-core)
- **Description:** Handle database interactions using Entity Framework Core, allowing for seamless integration with the database. The use of code-first migrations ensures that the database schema is in sync with the application models.
- **Features:**
  - **Code-First Migrations:** Automatically generate database schema from your code.
  - **Entity Mapping:** Ensure proper mapping of domain entities to database tables.

### 3. [Theme Integration](#theme-integration)
- **Description:** Integrate a pre-built theme into the project. Customize the theme to match the project’s requirements, ensuring it works well with ASP.NET Core.
- **Customization:** Modify the theme to align with the branding and functional needs of the project, ensuring consistency across all pages.

### 4. [User and Role Management](#user-and-role-management)
- **Description:** Implement user and role management using Microsoft ASP.NET Identity. This includes functionalities for user registration, login, role assignment, and permissions management.

### 5. Admin Capabilities
- **Create, Update, Delete Books:** Manage the books inventory with full CRUD operations.
- **Manage Categories:** Add, edit, or remove categories.
- **Manage Books:** Add, edit, or remove books.
- **Manage Subscriber** Add ,renew Subscriber's subscribtion,delete Subscriber's subscribtion,check if subscription paid penality and check if return book that he rantal.
- **User Management:** Create users, assign roles, lock or unlock users, and delete users as needed.
- **Role Assignment:** Define and assign roles such as Admin, Achieve, and Reception, with specific permissions.

### 6. Auth Section
- **Login:** Secure user authentication.
- **Reset Password:** Provide password recovery options.
- **Confirm Email** Sent Email virefication to user to avoid fake emails.
- **Edit Profile:** Enable users to update their personal information and settings.

### 7. [JavaScript Libraries](#javascript-libraries)
- **Description:** Utilize JavaScript libraries to enhance the user interface and provide dynamic functionality.
- **Libraries:**
  - **jQuery DataTables:** For dynamic tables with features like sorting, searching, and pagination.
  - **Toaster JS:** For displaying user-friendly notifications throughout the application.
  - **TinyMCE:**  user-friendly To formattin description book input.
  -  **Select2:**  user-friendly To select book's category and book's author with search.
  - **DateRangPicker:**  user-friendly To select range date time.
  - **Countup.Js:**  user-friendly for numbers.
  - **Flightbox:**  user-friendly for dispblay images.
  - **Bootbox Js confirmed:**  user-friendly to suring action.
  - **TypeAhead:**  user-friendly to searching.

### 8. [Admin Dashboard](#admin-dashboard)
- **Description:** Develop an admin dashboard that allows system administrators to manage the project effectively.
- **Features:**
  - **User Management:** View, create, update, and delete users.
  - **Role Management:** Assign and manage user roles.
  - **Book Management:** Oversee book listings, including adding, editing, and deleting products.
  - **rentals Management:** Add ,renew Subscriber's subscribtion,delete Subscriber's subscribtion,check if subscription paid penality and check if return book that he rantal.
  - **Charts:** Rentals Per Day,Subscribers Per City.

### 9. [Pagination](#pagination)
- **Description:** Implement pagination to manage large sets of products across multiple pages, ensuring a user-friendly experience.
- **Functionality:** Pagination will be integrated with search and filter functionalities to allow users to easily navigate through products.

### 10. [Session Management](#session-management)
- **Description:** Manage user sessions effectively, ensuring data is maintained across user interactions with the site.
- **Session Features:** 
  - Maintain user state across different pages.
  - Secure sensitive session data.

### 12. [Publishing to Monester](#publishing-to-monester)
- **Description:** Deploy the project on Monester, ensuring the deployment process is smooth and the application is optimized for the platform.
- **Deployment Focus:** Ensure the application is configured for performance, security, and scalability in a cloud environment.

### 13. [Publishing locally on IIS (Internet Information Services)](#Publishing-locally-on-IIS-(Internet-Information-Services))
- **Isolated Environment:** Running your website locally on IIS allows you to test and debug in an environment
    that is isolated from your production server. This helps in identifying and fixing issues without affecting live users.

### 14. [Data Seeding](#data-seeding)
- **Description:** Seed initial data for the admin role and users to ensure the system starts with essential data, improving ease of testing and initial use.
- **Seeded Data:**
  - **Admin Role:** Pre-configured admin role with full access.
  - **Sample Users:** Initial users with different roles for testing purposes.
---

## Links
- **Video Demo:** https://www.linkedin.com/feed/update/urn:li:activity:7289225228549812224/
- **Live Demo:** https://bookhaven.runasp.net
- **Email:** MoAdmin@BookHaven.Com 
- **Password:** P@$$0Rd123
