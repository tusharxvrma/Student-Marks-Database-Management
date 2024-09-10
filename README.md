# Student-Marks-Database-Management
**Summary:**  
A C# Windows Forms application using an **SQL database** to manage and display student marks. The project includes:

- **Form 1: Main Form**  
  - Displays Seneca logo and the application name.  
  - Contains three buttons:  
    - **Input Data**: Opens a form for entering student details into an SQL database via a GridView.  
    - **Display Data**: Opens a form to view filtered student data from the database using DetailView.  
    - **Exit**: Closes the application.

- **Form 2: Data Entry Form**  
  - Allows input of student details (Student Number, Name, Quiz, Lab, Lecture, Research, Final Project Marks) into the SQL database.
  - Automatically calculates and fills the **Average** when data is entered.
  - Includes buttons to calculate and display:
    - **Class Average**
    - **Class Standard Deviation**

- **Form 3: Data Display Form**  
  - Shows the **DetailView** of student data from the database.  
  - Features a **ListBox** of student numbers and two **ComboBoxes** to filter data by:  
    - Primary filter: Quiz, Lab Test, Lecture Test, Research Project, Final Project.  
    - Secondary filter: Greater than 80, Less than 50, Between 60 and 70.

The application integrates with an SQL database for storing, querying, and managing student data, with calculations for averages and standard deviations. Proper data handling and filtering ensure efficient management of student records.
