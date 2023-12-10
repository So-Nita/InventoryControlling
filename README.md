# Inventory Controlling System

  ## Project Structure
   1. ** InventoryConsole (Client - Console): **
        - Project responsible for the console-based user interface for interacting with the inventory management system.
   
   2. ** InventoryLib (Business Logic Layer): **
        - Project containing the core business logic for the inventory management system.

   3. ** InventoryWebApi (API Layer): **
        - Web API project serving as an interface to access business logic from InventoryLib.
        - Handles requests from client applications (such as InventoryConsole) and interacts with the business logic in InventoryLib.

   4. ** InventoryWinForm (Client - Windows Forms): **
        - Project responsible for the Windows Forms-based user interface for interacting with the inventory management system.

 ## Architecture Overview

  This project follows a simplified three-tier architecture with an additional API layer:
   1. **Client Side - Console UI and Windows Forms UI:**
        - Interacts with the inventory management system through respective user interfaces.
        - Implemented in InventoryConsole and InventoryWinForm.

   2. **Business Logic Layer:**
        - Core business logic resides in InventoryLib, handling inventory-related rules and operations.

   3. **API Layer:**
        - InventoryWebApi serves as the API layer connecting the client applications to the business logic layer.
        - Manages communication between client applications (such as InventoryConsole and InventoryWinForm) and InventoryLib.

## How to Run the Project

**Note: The API is already hosted, so there's no need to perform database migrations. However, if you want to use your own database, follow these steps:**

1. **Change Connection String:**
   - Open the "WebApi" project and navigate to `InventoryWebApi/appsettings.json`.
   - Locate the connection string in the `appsettings.json` file of the "WebApi" project.
   - Update the connection string with your database instance details, including the user and password.

   - Open the "Library" project and navigate to `InventoryLib/DataConfiguration/DbContextFactory.cs`.
   - Locate the connection string in the `DbContextFactory.cs` file of the "Library" project.
   - Update the connection string with your database instance details, including the user and password.

2. **Run Migrations:**
   - Open a terminal or command prompt.
   - Navigate to the project directory. For example:
     ```bash
     cd InventoryControlling/InventoryLib
     ```
   - Run the following commands to perform migrations and update the database:
     ```bash
     dotnet ef migrations add Migrations
     dotnet ef database update
     ```
   - This will apply the necessary changes to your database based on the code-first migrations.

3. **Run the Application:**
   - Once the migrations are applied successfully, you can run the "WebApi" and "WindowForm" projects to start the application.
  
## API Documentation
Explore the API endpoints and learn how to use them by checking the [API documentation](http://sonitab-001-site1.atempurl.com/swagger/index.html).

## API Endpoints

### I Product

1.1. **<span style="color:green">Read All Products</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/product`
   - Method: GET
   - Response:
     ```json
     {
         "status": 200,
         "total": 1,
         "result": [
             {
                 "id": "07af13cf-8c15-46cd-b38b-82f40dd13103",
                 "code": "GF001",
                 "name": "Schar Gluten Free Crackers 210g",
                 "price": 3.99,
                 "cost": 2.49,
                 "qty": 11,
                 "image": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT885cxlgzOFHZzztvIO0uxPh368p29bgmzNw&usqp=CAU",
                 "description": null,
                 "createdAt": "2023-12-04T15:00:48.897",
                 "categoryId": "d350f0c2-33a4-4f63-bf61-7582b88bb9d1",
                 "categoryName": "Sneaker"
             }
         ]
     }
     ```

1.2. **<span style="color:green">Create a Product</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/product`
   - Method: POST
   - Request Body:
     ```json
     {
       "code": "string",
       "name": "string",
       "cost": 0,
       "price": 0,
       "image": "string",
       "description": "string",
       "createdAt": "2023-12-04T08:48:13.236Z",
       "categoryId": "string"
     }
     ```

1.3. **<span style="color:green">Update a Product</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/product`
   - Method: PUT
   - Request Body:
     ```json
     {
       "id": "string",
       "code": "string",
       "name": "string",
       "cost": 0,
       "price": 0,
       "image": "string",
       "description": "string"
     }
     ```

1.4. **<span style="color:green">Delete a Product</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/product`
   - Method: DELETE
   - Request Body:
     ```json
     {
       "id": "string",
       "code": "string"
     }
     ```

1.5. **<span style="color:green">Read a Product</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/product`
   - Method: POST
   - Request Body:
     ```json
     {
       "id": "string",
       "code": "string"
     }
     ```
### II Category

2.1. **<span style="color:green">Read All Categories</span>**
   - Endpoint: `https://localhost:44341/api/category`
   - Method: GET
   - Response:
     ```json
     {
       "status": 200,
       "total": 5,
       "result": [
         {
           "id": "63c9840b-e57d-4852-9c90-6a8f4e71f74f",
           "name": "Shampoo",
           "image": "https://static.spacecrafted.com/dbe4e3ceec5049d281a85658fae6e3e7/i/bd417b71101b4618b3288e5a715fd9f3/1/4SoifmQp45JMgBnHp7ed2/Loreal%20Pro%20Blondie%20Serie%20Expert%201.png",
           "description": null
         },
         {
           "id": "8a83a4a0-5f18-4ed0-8b4a-4f56b23f7a53",
           "name": "Coffee",
           "image": "https://images.squarespace-cdn.com/content/v1/541e22dde4b0fcd826d4d5a1/1526672830446-8MWSDEWIS8GDRNC2Y3RE/HolyKombucha_Hero_3_WEB.jpg",
           "description": null
         }
       ]
     }
     ```

2.2. **<span style="color:green">Create a Category</span>**
   - Endpoint: `https://localhost:44341/api/category`
   - Method: POST
   - Request Body:
     ```json
     {
       "name": "string",
       "image": "string",
       "description": "string",
       "createdAt": "2023-12-07T05:31:51.003Z"
     }
     ```

2.3. **<span style="color:green">Update a Category</span>**
   - Endpoint: `https://localhost:44341/api/category`
   - Method: PUT
   - Request Body:
     ```json
     {
       "id": "string",
       "name": "string",
       "image": "string",
       "description": "string",
       "isDeleted": true
     }
     ```

2.4. **<span style="color:green">Delete a Category</span>**
   - Endpoint: `https://localhost:44341/api/category`
   - Method: DELETE
   - Request Body:
     ```json
     {
       "id": "string"
     }
     ```

2.5. **<span style="color:green">Read a Category by Id</span>**
   - Endpoint: `https://localhost:44341/api/category/getById`
   - Method: POST
   - Request Body:
     ```json
     {
       "Id": "d350f0c2-33a4-4f63-bf61-7582b88bb9d1"
     }
     ```


### III Stocking

3.1. **<span style="color:green">Read All Stockings</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/stocking`
   - Method: GET
   - Response:
     ```json
     {
       "status": 200,
       "total": 2,
       "result": [
         {
           "productId": "07af13cf-8c15-46cd-b38b-82f40dd13103",
           "productName": "Schar Gluten Free Crackers 210g",
           "price": 3.99,
           "qty": 5,
           "stockings": [
             {
               "id": "8b8ec8c2-a558-4c1b-a2ca-670280e2b28a",
               "productId": "07af13cf-8c15-46cd-b38b-82f40dd13103",
               "status": 1,
               "qty": 11,
               "transactionDate": "0001-01-01T00:00:00",
               "note": null,
               "product": null
             },
             {
               "id": "5287c911-265c-436d-a189-da7c6fca4ef1",
               "productId": "07af13cf-8c15-46cd-b38b-82f40dd13103",
               "status": 2,
               "qty": 5,
               "transactionDate": "0001-01-01T00:00:00",
               "note": null,
               "product": null
             }
           ]
         },
         {
           "productId": "0c2e9b78-7be8-4782-b866-a57fefd84bdd",
           "productName": "NesCafe Gold 7 sachets",
           "price": 5.99,
           "qty": 100,
           "stockings": [
             {
               "id": "371334ee-9652-444a-8cc8-4af1d391f720",
               "productId": "0c2e9b78-7be8-4782-b866-a57fefd84bdd",
               "status": 1,
               "qty": 100,
               "transactionDate": "0001-01-01T00:00:00",
               "note": null,
               "product": null
             }
           ]
         }
       ]
     }
     ```

3.2. **<span style="color:green">Create a Stocking</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/stocking`
   - Method: POST
   - Request Body:
     ```json
     {
       "productId": "0c2e9b78-7be8-4782-b866-a57fefd84bdd",
       "status": 1,
       "qty": 100,
       "note": "string"
     }
     ```

3.3. **<span style="color:green">Update a Stocking</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/stocking`
   - Method: PUT
   - Request Body:
     ```json
     {
       "id": "string",
       "qty": 0,
       "status": 1
     }
     ```

3.4. **<span style="color:green">Delete a Stocking</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/stocking`
   - Method: DELETE
   - Request Body:
     ```json
     {
       "id": "string"
     }
     ```

3.5. **<span style="color:green">Get Stockings By ProductId</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/stocking/getByProductId`
   - Method: POST
   - Request Body:
     ```json
     {
       "id": "0c2e9b78-7be8-4782-b866-a57fefd84bdd"
     }
     ```
### VI Order

4.1. **<span style="color:green">Read All Orders</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order`
   - Method: GET
   - Response:
     ```json
     {
       "status": 200,
       "total": 2,
       "result": [
         {
           "id": "2ec2b5d5-2e6e-4c30-bd13-c2452b76b801",
           "totalPrice": 19.95,
           "orderDate": "2023-12-06T00:00:00",
           "orderDetails": [
             {
               "id": "60863418-3926-4399-b3fc-f680dc80630b",
               "productId": "07af13cf-8c15-46cd-b38b-82f40dd13103",
               "productName": "Schar Gluten Free Crackers 210g",
               "categoryname": "Sneaker",
               "orderId": null,
               "qty": 5,
               "price": 3.99,
               "grandTotal": 19.95
             }
           ]
         },
         {
           "id": "bc0e2743-f306-409e-9a59-cac29e4ee405",
           "totalPrice": 3.99,
           "orderDate": "2023-12-06T00:00:00",
           "orderDetails": [
             {
               "id": "8424af7f-5ef9-4074-9a50-4e0f67a2e6a8",
               "productId": "07af13cf-8c15-46cd-b38b-82f40dd13103",
               "productName": "Schar Gluten Free Crackers 210g",
               "categoryname": "Sneaker",
               "orderId": null,
               "qty": 1,
               "price": 3.99,
               "grandTotal": 3.99
             }
           ]
         }
       ]
     }
     ```

4.2. **<span style="color:green">Create Order</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order`
   - Method: POST
   - Request Body:
     ```json
     {
       "orderDetails": [
         {
           "productId": "0c2e9b78-7be8-4782-b866-a57fefd84bdd",
           "qty": 10
         }
       ]
     }
     ```

4.3. **<span style="color:green">Update Order</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order`
   - Method: PUT
   - Request Body:
     ```json
     {
       "orderDetails": [
         {
           "id": "string",
           "qty": 0
         }
       ]
     }
     ```

4.4. **<span style="color:green">Delete Order</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order`
   - Method: DELETE
   - Request Body:
     ```json
     {
       "id": "string"
     }
     ```

4.5. **<span style="color:green">Get Order By OrderId</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order/getById`
   - Method: POST
   - Request Body:
     ```json
     {
       "id": "2ec2b5d5-2e6e-4c30-bd13-c2452b76b801"
     }
     ```

4.6. **<span style="color:green">Delete Order Detail</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/order/deleteOrderDetail`
   - Method: DELETE
   - Request Body:
     ```json
     {
       "id": "string"
     }
     ```
 ### V User

5.1. **<span style="color:green">Read All Users</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/user`
   - Method: GET
   - Response:
     ```json
     {
       "status": 200,
       "total": 2,
       "result": [
         {
           "id": "5e25cc94-424f-4b29-8729-cbc55c09e5a3",
           "userName": "Admin",
           "image": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlvcJSJgrLlqVEQ1XNM3GzT0qGSyBX5jg1nd5Xn7_krVmMVL3gXR5u6TaU1q8xS4FNV6k&usqp=CAU",
           "role": "Admin",
           "contact": "015558811",
           "password": "Admin@123"
         },
         {
           "id": "d675e5a1-c86c-46af-a926-e4e8e49f8690",
           "userName": "Sellman",
           "image": "https://www.shutterstock.com/image-vector/avatar-girls-icon-vector-woman-260nw-433429546.jpg",
           "role": "Seller",
           "contact": "098885558",
           "password": "Sell@123"
         }
       ]
     }
     ```

5.2. **<span style="color:green">Get User By UserName and Password</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/user/getById`
   - Method: POST
   - Request Body:
     ```json
     {
       "userName": "string",
       "password": "string"
     }
     ```
 ### VI PriceHistory

6.1. **<span style="color:green">Read All Price History</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/priceHistory`
   - Method: GET
   - Response:
     ```json
     {
       "status": 200,
       "total": 0,
       "result": []
     }
     ```

6.2. **<span style="color:green">Get Price History By ProductId</span>**
   - Endpoint: `http://sonitab-001-site1.atempurl.com/api/priceHistory/getByProductId`
   - Method: POST
   - Request Body:
     ```json
     {
       "id": "string"
     }
     ```
 



