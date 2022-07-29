# Microsoft Graph API
## Getting User and Group Information
- Open Postman tool
- Need to generate access token first
- Register Service Principal named - postman
- We need to give access to SP onto the AAD.
- For this we need to open SP and refer to tab - API Permissions
- Be default is permission is given
- We can add more permissions
- Click add permission to add more permission and chose Microsoft Graph -> Application Permissions
- Scroll down to Users section and chose Users.Read.All
- Click "Grand admin consent"
- Open Postman tool
- Create POST request in Postman to get access token
- To get the access token we need to get URL from SP -> Endpoints -> OAuth 2.0 token endpoint (v2)
- Copy the URL and paste in Postman
- Open Body section in Postman
- Chose "x-www-form-urlencoded"
  - Key: grant_type / value: client_credentials
  - Key: client_id / value: <app id of sp>
  - Key: client_secret / value: <secret of sp>
  - Key: scope / value: https://graph.microsoft.com/.default
- Click Send
- Copy the access_token from output
- Open a new tab in Postman
  - GET type request
  - URL: https://graph.microsoft.com/v1.0/users
  - Open Headers and add details as below:
    - Authorization: Bearer <token-value>
  - Click Send
  - Review the output


## Updating user info
- Add API permission to SP - User.ReadWrite.All
- Grant Admin Consent
- Generate token again in Postman
- Open a new tab
- PATCH type request
- URL: https://graph.microsoft.com/v1.0/users/<user-id>
- Open Headers and add details as below:
  - Authorization: Bearer <token-value>
- Body -> Row -> JSON
  ```
  {
    "givenName": "updated-by-postman"
  }
  ```
- Click Send
- Open the user profile in AAD and notice the changes
