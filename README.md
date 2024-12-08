#Employee Feedback Application
**Project Description**
The Employee Feedback Application is built using ASP.NET Core MVC with Entity Framework and SQL Server as the database. The application provides an intuitive platform for employees to submit anonymous feedback, view their feedback history, and share feedback links with specific departments or colleagues.

The application is fully responsive and employs dynamic color grading for enhanced user experience.

Features
User Authentication
Registration Form: Users can register using email and password.
Login Form with Validation: Validates email and password on login.
Feedback Management
Anonymous Feedback Submission:
Employees can submit feedback anonymously via a unique link.
Feedback includes:
Positive emotions
Improvement areas
Positive comments
Feedback on improvement areas
Feedback Viewing:
Logged-in users can view their submitted feedback history.
Unique Feedback Links
Employees can generate unique feedback links for specific departments or individuals.


Tables and Database Design
1. Users Table:-
Stores user details:

UserID (Primary Key)
Email
Password

2. Feedbacks Table :-
Stores feedback details:

FeedbackID (Primary Key)
UserID (Foreign Key)
UniqueLink
Timestamp

3. FeedbackResponses Table :-
Stores feedback responses:

ResponseID (Primary Key)
FeedbackID (Foreign Key)
PositiveEmotions
ImprovementAreas
PositiveComments
ImprovementFeedback


Screenshots
1. Registration Page
Screenshot of the registration form with validations.

2. Login Page
Screenshot of the login page with validation messages.

3. Dashboard
Screenshot showing submitted feedback history.

4. Feedback Form
Screenshot of the feedback form with anonymous submission options.

Assumptions
Users generate unique feedback links manually for specific recipients.
Feedback responses remain anonymous.
Additional Information
Framework: ASP.NET Core MVC
Frontend: Razor Views, Bootstrap, Dynamic Color Grading
Backend: Entity Framework Core
Database: SQL Server
