# Azure API Management
  - Azure API Management Overview

  - Azure API Management - The purpose of the service
  - Azure API Management - Deployment
    - Chose Developer Pricing Tier
  - Create a API Web APP
    - Reference: 366-building-the-web-api-part-1-WebApi
    - Create an storage account to store data - courses.json
    - Create container named - data and upload - courses.json
    - Add connection string to storage account in CourseService.cs
    - Run App in browser
    - Visit <url>/api/Course
    - Publish to Web APP
    - Once publish is done visit - <url>/api/Course

  - Azure API Management - Setting up the API
    - Open APIs from API Management Service
    - Delete EchoAPI
    - Add Blank API
    - Specify Web App URL. It will be treated as Base URL
    - Add Operation
      - getcourses, Get, /api/Course
    - Test the operation from Test link
    - If we test the API using Postman it will throw security error.
    - We need to add a subscription key in header. subscription key is available in Test section in API Management service
        - Ocp-Apim-Subscription-Key: <>
    - Now lets add more operations
      - Add Operation Get
      - get-course, Get, /api/Course/{id}
      - Save and Test
      - Add Operation Post
        - AddCourse, Post, /api/Course
      - Let's add a course via Postman
        - Change to Post Request
        - Change URL to /api/Course
        - Body: raw, JSON, Add text in Body
          ```
          {
            "CourseID": "C0005",
            "CourseName": "AZ-204",
            "Rating": 4.9
          }
          ```
  - Azure API Management - Policies
    - Can be used to execute an operation on the request or the response of the API
  - Azure API Management - Policy - Rewrite URL's
    - To change the URL request received
      - /api/Course?courseID=C001  -> /api/Course/C001
      - Open operation - Get Courses
      - Edit Inbound Processing
        - Refer: 375-api-management-policy-rewrite-urls.txt
      -
  - Azure API Management - Policies - Conditions
    - To check the incoming request. If specified condition is satisfied then only serve the request
    - Refer: 376-api-management-policies-conditions.txt
    - Add Head in Postman request so that condition can be satisfied - Customer-Key

  - Azure API Management - Policy - Outbound Rule
    - To change the outbound response
    - Refer: 377-api-management-policies-return-responses.txt
  -
  - Azure API Management - OpenAPI Specification
    - An easier way to import the API
    - We can use Library in our C# Project - Swashbuckle.AspNetCore
    - Modify the code so that Swagger Documentation can be generated
      - In Startup class\ConfigureServices, add below line:
        ```
        services.AddSwaggerGen();
        ```
      - In Configure method add below lines of code:
      ```
      app.UseSwagger();
      app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Course v1"));
      ```
    - Run Project
    - Specify URL - /swagger
    - Notice documentation
    - We can add this API easily in API Management. Chose OpenAPI
    - Specify URL - /swagger/v1/swagger.json
