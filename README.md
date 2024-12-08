# Employee Feedback Application
## Project Description :-

The Employee Feedback Application is built using ASP.NET Core MVC with Entity Framework and SQL Server as the database. 
The application provides an intuitive platform for employees to submit anonymous feedback, view their feedback history, and share feedback links with specific departments or colleagues.


The application is fully responsive for enhanced user experience and use **DI Pattern** for remove more dependency from classes .


## Features :-

**1.User Authentication**

**2.Registration Form with Validation:** Users can register using email and password.

**3.Login Form with Validation:** Validates email and password on login.

**4.Feedback Management**

**5.Anonymous Feedback Submission:**
Employees can submit feedback anonymously via a unique link.

**6.Feedback includes :-**

                     Positive emotions

                     Improvement areas

                     Positive comments

                     Feedback on improvement areas

**7.Feedback Viewing:**
Logged-in users can view their submitted feedback history.

**8.Unique Feedback Links :**
Employees can generate unique feedback links for specific departments or individuals.

**9. Logout :** Clear all Session Data and redirect to home page.

## Technology used:

                     Framework: ASP.NET Core MVC

                     Frontend: Razor Views, Bootstrap5

                     Backend: Entity Framework Core

                     Database: SQL Server


## Screenshots
**1.Home Page**
![Screenshot 2024-12-09 012514](https://github.com/user-attachments/assets/d5b0a93d-2670-45db-858f-99f592e7c58f)


**2. Registration Page**
![Screenshot 2024-12-09 012530](https://github.com/user-attachments/assets/e5061237-f272-456e-b538-a1c503cb6bf9)

![Screenshot 2024-12-09 012703](https://github.com/user-attachments/assets/20806132-2826-4bc0-ab96-3b62ce9973d4)


**3. Login Pag**e
![Screenshot 2024-12-09 012548](https://github.com/user-attachments/assets/dc4e425c-73d8-4655-bc4f-f6beeffad66c)


**4. Dashboard**
![Screenshot 2024-12-09 012612](https://github.com/user-attachments/assets/58d486be-c63a-4c86-a356-215a3a4ddb97)


**5. Feedback Form**
![Screenshot 2024-12-09 014300](https://github.com/user-attachments/assets/97ea7e9a-31c4-466a-91cc-e94322a8865e)

6. Feedback Link Create
   ![Screenshot 2024-12-09 013019](https://github.com/user-attachments/assets/ac253393-14cc-44dc-b748-4e86bb258b2c)

7. View Own Feedbacks
   ![Screenshot 2024-12-09 013044](https://github.com/user-attachments/assets/44949d9c-7ea0-4196-bbd2-70acf6f89fce)


# Tables and Database Design

**1. Users Table:-**
Stores user details:

                     UserID (Primary Key)

                     Email

                     Password
![Screenshot 2024-12-09 020533](https://github.com/user-attachments/assets/23ccddd7-2dec-4da6-9d4f-946986543d05)


**2. Feedbacks Table :-**
Stores feedback details:

                     FeedbackID (Primary Key)

                     UserID (Foreign Key)

                     UniqueLink

                     CreatedAt
![Screenshot 2024-12-09 020550](https://github.com/user-attachments/assets/d75e6986-c5c1-4516-975d-fe0085fd4ac6)


**3. FeedbackResponses Table :-**
Stores feedback responses:

                     Id (Primary Key)

                     FeedbackID (Foreign Key)

                     PositiveEmotions

                     ImprovementAreas

                     PositiveComments

                     ImprovementFeedback
![Screenshot 2024-12-09 023505](https://github.com/user-attachments/assets/5b713651-52e1-4b4b-ae8c-5b455adeb04d)


## Assumptions

Users generate unique feedback links manually for specific recipients.

Feedback responses remain anonymous.


