# WebApiCoderbyte
My .NET Core 7 Web API Project
Description

This project is a Web API built using .NET Core 7. Here, you can provide a detailed description of your API, what it does, what problem it solves, the methodology used, and the reason you chose .NET Core 7.

Getting Started

The following instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
Prerequisites

List what things you need to install the software and how to install them.

    .NET Core 7.0 SDK
    An IDE of your choice (Visual Studio 2023, VS Code, etc.)
    Git

Elevator API Documentation

This API manages the movements of an elevator system.
Endpoints
POST /api/elevators/call

Description: This endpoint is for calling the elevator to a specified floor.

Request Body: A JSON object containing a CurrentFloor property.

Example:

    json

    {
        "CurrentFloor": 5
    }

Response: Returns HTTP 200 (OK) with a success message if the elevator is successfully called, or HTTP 400 (Bad Request) if the request body is null.

Example Success:

    json
    
    {
        "statusCode": 200,
        "message": "The elevator is headed to 5 floor."
    }

Example Error:

    json
    
    {
        "statusCode": 400,
        "message": "Please provide current floor argument."
    }

POST /api/elevators/travel

Description: This endpoint is for requesting the elevator to travel to a specified floor.

Request Body: A JSON object containing a DestinationFloor property.

Example:

    json
    
    {
        "DestinationFloor": 7
    }

Response: Returns HTTP 200 (OK) with a success message if the elevator is successfully directed to travel, or HTTP 400 (Bad Request) if the request body is null.

Example Success:

    json
    
    {
        "statusCode": 200,
        "message": "The elevator is headed to 7 floor."
    }

Example Error:

    json
    
    {
        "statusCode": 400,
        "message": "Please provide destination floor argument."
    }
    
GET /api/elevators/get-servicing-floors

Description: This endpoint retrieves a list of all floors that the elevator is currently servicing.

Response: Returns HTTP 200 (OK) with a list of all servicing floors, or HTTP 404 (Not Found) if the list is null.

Example Success:

    json

    [1, 2, 3, 7]

GET /api/elevators/get-next-floor

Description: This endpoint retrieves the next floor the elevator needs to service.

Response: Returns HTTP 200 (OK) with the next floor the elevator is going to service, or HTTP 404 (Not Found) if the next floor is not found (0).

Example Success:

    json
    
    {
        "message": "Elevator's next floor is 3"
    }
