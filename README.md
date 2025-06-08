# cmpg323project2
# project-2
# subject:IT Development
The IT-environment changes at a fast pace. That is why we have a module with content regularly updated to keep up with newer developments in the IT-environment. The module is presented at the end of the degree to allow students to integrate their knowledge from other modules into this module. In the module, a series of projects are undertaken. Self-study and teamwork are important parts of these projects. These projects' goal is to expose the student to new IT challenges and appropriate technology to address these challenges. The development of soft skills is also part of the primary goal of this module.
# University project:
This project involved creating a web API with REST, the project is developed with Visual Studio and C# as the core programming language. Mark I received for this project was 109%, as I received extra credit.
Feel free to download the project to your machine and have a look
# Overview:
This project is to develop an web application using and API and how API's work. The basis of the project is that we have a database with 3 tables (Categories, Zones and Devices), these 3 tables contains information on Internet-of-Thing devices. A web application is then used to access the 3 tables on the database, this web application will be used to monitor the devices, zones and categories. With this web app you can create, read, update and delete records. All this is done through an API.
The database is hosted in the Cloud on Azure and I have developed an API that will also be hosted on Azure to access the data on the database through a RESTful API. The API is developed using .NET EntityFrameworkCore. To test that the API works and that it can access the database I have used swagger to be the interface to the API to test that we can Create, Read, Update and Delete data in the database.
# How to use API:
Upon accessing the API, the user must register an account. Then the user may proceed to login. The user should request a token when accessing tables and manipulating data contained in those tables. The account that should be registered is the admin one because it is the only one that is authorized to access the tables.

# Registering an account:
The user must register an admin user because it is the only role that is authorized to access he tables and table manipulation.

# Logging in:
The user must click on the login button and insert the newly registered credentials.After logging in the user will receive the token. That token must be saved as will be used to access the tables since this system uses a tokeen based security.

# Working with tables:
Before doing anything the user must click on the lock logo to get authorization to access the tables. A window will appear where they will need to type "Bearer" followed by the token they received when logging in. Thereafter the user can use the POST, GET, PUSH and more funtionalities of the system.

![Screenshot 2024-08-12 161424](https://github.com/user-attachments/assets/7b33d2aa-3465-4b61-a26f-1953f34c04de)
![Screenshot 2024-08-12 161437](https://github.com/user-attachments/assets/f4898218-34da-49df-ba93-b379dab9d35f)
![Screenshot 2024-08-12 161449](https://github.com/user-attachments/assets/f6bf026e-1a81-435f-a87f-50b3480a260b)
![Screenshot 2024-08-12 161518](https://github.com/user-attachments/assets/2c9de18e-48eb-4f9e-835c-a2fd03e83ca8)
![Screenshot 2024-08-12 161531](https://github.com/user-attachments/assets/d448b98e-2437-41f3-97d1-bcf69101a115)
