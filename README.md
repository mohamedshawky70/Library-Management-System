# BookHaven MVC Project

# Project Mind Map
![Image](https://github.com/user-attachments/assets/06bbdbdd-522a-4dc3-9943-8526af52bf4a)
![Image](https://github.com/user-attachments/assets/906edc1a-5417-4aca-8c61-991755696c28)
## Glimpse of the working solution
![Image](https://github.com/user-attachments/assets/2d3a2595-1fd1-4489-a536-7f4a48434907)
![Image](https://github.com/user-attachments/assets/7c0cfba3-aac0-429c-b008-832a05131624)
![Image](https://github.com/user-attachments/assets/8a25ee7d-d454-4030-9c33-deb6aee8f03e)
![Image](https://github.com/user-attachments/assets/d00db187-177d-427a-939c-086615418653)
![Image](https://github.com/user-attachments/assets/b5125a8f-7ecd-4291-90ae-b24b4527e56c)
![Image](https://github.com/user-attachments/assets/c439c239-b0a6-4fd4-bf06-f9f3fa0e5888)
![image](https://github.com/user-attachments/assets/1ec5c8a7-566c-44cc-99ce-2bda66a6abc0)
![Image](https://github.com/user-attachments/assets/d95e1c9c-53a1-4831-99c1-7da26770c81d)
![Image](https://github.com/user-attachments/assets/5c1e7c4c-73b9-4cbd-9ce7-9fc52b1ab785)
![Image](https://github.com/user-attachments/assets/3493267c-4f73-463c-b186-c9ed2f0f4aa6)
![Image](https://github.com/user-attachments/assets/d44227fb-3d10-4a7c-9e67-7097be9cc5a8)
![Image](https://github.com/user-attachments/assets/2a754ff5-4b63-49c1-b3c3-c73cd0b2824b)
![Image](https://github.com/user-attachments/assets/9e0f2393-120e-4129-99c2-9f52c653fe7a)
![Image](https://github.com/user-attachments/assets/cf176936-ac78-4372-9061-bc636247b5b6)
![Image](https://github.com/user-attachments/assets/5e0705e2-2587-43c9-a31f-323cadd797ac)
![Image](https://github.com/user-attachments/assets/77088c6d-60da-47f6-9eca-cc32ce9eced5)
![Image](https://github.com/user-attachments/assets/4f5f185b-a373-4ab5-b9bd-25fe951f64b9)
![Image](https://github.com/user-attachments/assets/b4ac8e31-d0ab-4d02-9e6a-d6ec06eb52af)
![Image](https://github.com/user-attachments/assets/3317268b-046f-4c09-af24-a5d513f2285a)
![Image](https://github.com/user-attachments/assets/f4f16420-e3b1-495a-bcdc-df617aee26fe)
![Image](https://github.com/user-attachments/assets/907be52a-d1b3-4fb0-a9f1-5f1c4271ea7d)
![Image](https://github.com/user-attachments/assets/68901163-15de-41b0-b09e-8fb8ec467a35)
![Image](https://github.com/user-attachments/assets/e32bdb9f-8e1b-4f8a-b02b-f68c98df39c4)
![image](https://github.com/user-attachments/assets/1b2f7084-5103-4a67-9666-64f0ad30a02d)

## Project Overview

**Objective:** This is a Library Management System (LMS) web application built with .NET Core, designed to streamline the process of managing books, users, and borrowing records in a library. The system allows librarians and administrators to track books, users, issue/return books, and manage user roles.

## Tech Stack
-Backend: .NET Core 8 
-Frontend: HTML, CSS (Bootstrap or other frameworks can be used)
-Database: SQL Server (or SQLite for local setup)
-Authentication: ASP.NET Core Identity for user authentication
-ORM: Entity Framework Core for database interactions

## Key Features
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
