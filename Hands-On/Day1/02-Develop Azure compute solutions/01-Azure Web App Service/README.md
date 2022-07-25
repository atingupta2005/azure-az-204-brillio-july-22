# Azure Web App Service
- Azure Web App Service
  - Azure App Service Plan
  - Azure Web App - Linux App Service Plan
  - Azure Web App - Docker container
  - Azure Web Apps - App Service Logs
    - Refer web app/Monitoring
      - App Service Logs
        - Enable different type logs
      - Log Streams
        - To view the real-time logs
        - Visit app on Browser and view logs in Log Stream


  - Azure Web App - Publishing from GitHub
    - While creating web app, enable continous deployment to publish directly from GitHub. Specify any ASP.Net Core project deployed on Github
    - Notice Sync button in Web App for manual sync or do changes in Gihub repo for auto deploy
  - Azure Web App - Custom domains
    - Web App/Custom Domain
    - Click "+Add Custom Domain"

  - Azure Web App - CORS
    - Method of restring access to resources on a web when it is requested from another domain
    - Refer 45-azure-web-app-cors-building-the-api
      - Publish to Azure and open /api/Course
    - Refer 46-azure-web-app-cors-implementation
      - Change the URL of API Web app in demo.html
      - Publish to Azure
    - Once publish is done:
      - Take URL of Web App Consumer and open - /demo.html
      - Open Chrome/Developer Tools
      - Open the URL
      - Notice the error in Developer tools
    - Resolve:
      - Open API Web App/CORS
      - Enable checkbox and in textbox, specify URL of Web App Consumer

      -
  - Azure Web Apps - Deployment Slots

  - Azure App Service Plan - Linux
