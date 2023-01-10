• This is a N tier architecture application with our repositories using repository pattern in the Data access layer, then our contracts, the services and repositories, are implemented in the business logic layer, and finally we have our API layer which exposes the endpoints for our client side application to make requests to. 

• The data access layer will interact with database, it contains repository classes talk to database.

• The Service layer has service process, interfaces which deal with business logic.

• The transaction function in the business logic layer are implemented to get all the transaction of customer, calculate the reward points for each customers in each month and the record of every 3-month transaction.

• Creating the Entity in the application core which contains two data table: Customer and Transaction.

• The API hold controller, and inside the controller it has several methods to call the service layer. 

• Controllers in API implement that get record of each transaction for three-month period and get the reward points for each month by using HttpGet the customer's Id. 

• The Router Module in controllers to develop custom routes to the application and using the Http Request to read data from the web servers.

• Architecture of Project:
  1 Application Core
  2 Infrastructure
  3 Web API

• Built With:
  1 Develop the project by using ASP.NET Core Web API
  2 .NET Core
  3 Dependency Injection
  4 .Net 6
  5 Entity Framework Core

• Usage:
![361015d13eaf0fb985437636dee7a75](https://user-images.githubusercontent.com/107888822/211622886-ce18c063-4e71-4ae5-b57f-917e1d1cae8b.png)
To see the reward points for each customer:
![cd14bab316c8d11a5b06a3d17f4889d](https://user-images.githubusercontent.com/107888822/211623938-6b064588-3e87-42cb-a485-e5e91b0f5982.png)
To see the reward points for each custoemr for three months:
![a1ddb13e22cbed36ea059c4399c926c](https://user-images.githubusercontent.com/107888822/211624051-0818e65f-486f-4c39-ab24-4252742360cc.png)

