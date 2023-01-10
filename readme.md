
This is a N tier architecture application with our repositories using repository pattern in the Data access layer, then our contracts, the services and repositories, are implemented in the business logic layer, and finally we have our API layer which exposes the endpoints for our client side application to make requests to. 
The data access layer will interact with database, it contains repository classes talk to database.
The Service layer has service process, interfaces which deal with business logic.
The transaction function in the business logic layer are implemented to get all the transaction of customer, calculate the reward points for each customers in each month and the record of every 3-month transaction.
Creating the Entity in the application core which contains two data table: Customer and Transaction.
The API hold controller, and inside the controller it has several methods to call the service layer. 
Controllers in API implement that get record of each transaction for three-month period and get the reward points for each month by using HttpGet the customer's Id. 
The Router Module in controllers to develop custom routes to the application and using the Http Request to read data from the web servers.

Architecture of Project:
1.Application Core
2.Infrastructure
3.Web API

Build With:
1 Develop the project by using ASP.NET Core Web API
2 .NET Core
3 Dependency Injection
4 .Net 6
5 Entity Framework Core

