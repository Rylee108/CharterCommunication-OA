
There is a transaction repository and a transaction service in the core, the interface from core were implemented in the infrastructure to implement get all the transaction of customer and calculate the rewardpoints for each customer in each month, and the reward points for three months.
To see the previous 3 months statements and the awards point for each month's implementation,can go to url:” https://github.com/Rylee108/CharterCommunication-OA/blob/main/CharterCommunicationInfrastructure/Services/CCTransactionServices.cs“

Controllers in API implement that get record of each transaction for three-month period and get the reward points for each month by using HttpGet the customer's Id.