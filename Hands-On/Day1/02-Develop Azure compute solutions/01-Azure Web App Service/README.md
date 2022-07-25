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

  - Azure Web App - SSL
    - Open Web App/TLS SSL Setting
    - Open Tab - "Private Key Certifiates"
    - Click - "+ Create App Service Managed Certificate" and click Save
    - Back on page, click "Bindings"
    - Click "+ Add TLS/SSL Binding"
      - TLS/SSL Type: IP Based SSL
    - Visit Website using HTTPS and notice site is now secure
  - Azure Web App - CORS
    - Method of restring access to resources on a web when it is requested from another domain
    - Create Visual Studio Project - "ASP.Net Core Empty"
      - Refer 45-azure-web-app-cors-building-the-api
        - API Publisher
    - Create ASP.Net Project - "ASP.Net Core"
    - Publish to Azure
      - Refer 46-azure-web-app-cors-implementation
        - Change the URL of API Web app in demo.html
        - API Consumer
      - Publish to Azure
    - Once publish is done:
      - Take URL of Web App Consumer
      - Open Chrome/Developer Tools
      - Open the URL
      - Notice the error in Developer tools
    - Resolve:
      - Open API Web App/CORS
      - Enable checkbox and in textbox, specify URL of Web App Consumer

      -
  - Azure Web Apps - Deployment Slots

  - Azure App Service Plan - Linux
