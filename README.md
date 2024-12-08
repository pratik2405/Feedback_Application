# Employee Feedback Application
## Project Description :-

The Employee Feedback Application is built using ASP.NET Core MVC with Entity Framework and SQL Server as the database. 
The application provides an intuitive platform for employees to submit anonymous feedback, view their feedback history, and share feedback links with specific departments or colleagues.


The application is fully responsive for enhanced user experience.


## Features :-

**1.User Authentication**

**2.Registration Form with Validation:** Users can register using email and password.

**3.Login Form with Validation:** Validates email and password on login.

**4.Feedback Management**

5.Anonymous Feedback Submission:
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

## Technology used:

Framework: ASP.NET Core MVC

Frontend: Razor Views, Bootstrap5

Backend: Entity Framework Core

Database: SQL Server

# Tables and Database Design

**1. Users Table:-**
Stores user details:

UserID (Primary Key)

Email

Password


**2. Feedbacks Table :-**
Stores feedback details:

FeedbackID (Primary Key)

UserID (Foreign Key)

UniqueLink

Timestamp


**3. FeedbackResponses Table :-**
Stores feedback responses:


ResponseID (Primary Key)

FeedbackID (Foreign Key)

PositiveEmotions

ImprovementAreas

PositiveComments

ImprovementFeedback



## Screenshots
**1.Home Page**


**2. Registration Page**


**3. Login Pag**e


**4. Dashboard**


**5. Feedback Form**


## Assumptions

Users generate unique feedback links manually for specific recipients.

Feedback responses remain anonymous.


