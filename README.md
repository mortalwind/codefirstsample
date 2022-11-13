# CodeFirstSample

Hello everyone,

This project is a sample of the <strong>Code-First</strong> approach for database creation strategy.

Code-First is mainly useful in Domain Driven Design.

<strong>About this project</strong>

You can imagine that you've got a web application that lists your books and their authors.  Maybe you're a bookseller :)
  
And this application lists your books with prices. You can get about of book details. 

<strong>How does it work?</strong>

This project is very simple. It shows how can use EF Core Code-First approach in Docker container.

Requirements:
  
- You should have Docker Desktop on your PC.
  
- Visual Studio Code, Visual Studio, or a similar application must be installed on your PC.
  
- You better know Git commands.
  
- You should know C#, you better know Dockerfile and docker-compose commands.
  
If you don't know Docker containers and their command, it's no problem, I'll explain below.

<strong>Let's start!</strong>

Open your Command Prompt,Terminal or Powershell then go to your projects directory.
Type <code>git clone https://github.com/mortalwind/codefirstsample.git</code> code, press Enter.
Wait while Git is cloning the project in your project directory. 

And you can edit it with VS Code using this code <code>code -r CodeFirstSample</code> or you can open it in your editor directly.

After this moment, I'll continue with VS Code.

<strong>Run the project</strong>

If it's closed then you can open a new terminal in VS Code. You can do that clicking Terminal menu and click New Terminal.

Next, ensure Docker Desktop is running. Run this command <code>docker-compose build</code> . This command runs your docker-compose.yaml file where in the project root folder.

After finish the build,  you can run your container like that <code>docker-compose up -d</code> .

Open your Docker Desktop and goto Containers tab. You can find a container that is named "codefirstsample" which contains two images inside. 
"CodeFirstSampleAPI" and "mssqldb" images will be created. And both of them are running. 

<strong>Initialize the database</strong>

There is a little issue with database migrations. Because it's about container lifecycle. Our API project runs up quickly. But our mssql database image needs some installation and configuration processes. And, when we would try to migrate the database when API's startup we would get errors.
Because our MSSQL database is not ready yet.

We will wait until the database image is ready. You can view docker image logs by click on mssldb image.

Our API project port is 55099. Open your browser and paste this <code>http://localhost:55099/api/books</code> . You will get an error about that login failed as 'sa' for 'bookstore' database. And open new tab, paste this <code>http://localhost:55099/api/initialize</code> then go. A few moments later it writes "Database migration is finished.". After that go back your books page and refresh page. 
Note: I'm sure that Postman will be better than your browser for these actions.

Yeay! The error is disappered. But there is no data. I told you this is a simple project:) We will add books and authors manually. 

<strong>Let's take a look at the project</strong>

Structure:
- Abstractions: It contains interfaces and other abstract classes.
- Controllers: It contains Controllers.
- Data: It contains database configurations.
- Models: It contains DTOs and database models
- Extensions: It contains extension methods.
- Profiles: It contains Automapper profiles.
- Repositories: It contains generic repository pattern
- Services: It containes services what business between api and database
- docker-compose.yml: the configuration file for dockerize process.


