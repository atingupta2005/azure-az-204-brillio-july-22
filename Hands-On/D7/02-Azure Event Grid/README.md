# Azure Event Grid
  - What is the Azure Event Grid Service
  - Azure Event Grid - Azure Functions
      - Create function with trigger type - Event Grid Trigger
      - In Storage account Subscribe to Event Grid
        - Create new event subscription
          - This subscription will listed to events emitted by Storage account and send events to an end point
          - Event will be sent to a topic. We need to specify topic name while creating event subscription
          - Filter event types
          - Select Endpoint - Azure Function

      - This event subscription we created will send event onto that topic and events will then be taken from the topic onto azure function
      - Now upload a file to storage account.
      - Notice the logs of the function

  - Azure Event Grid Schema
    - When an event is sent to Event Grid, it pertains to a particular schema
    - There are some common properties for all events either emitted via any resource type


  - Azure Event Grid - Service Bus Handler
    - Another example to send event to azure storage queue
    - In Storage account, create a new queue
    - Delete any event subscript from storage account
    - In Azure Storage account: Add a new event subscription
    - Filter on Azure Storage blob creation
    - Endpoint type- Storage Queues and select the queue from Storage account
    - Upload a file in the container in storage account
    - Notice that a message is received in the queue

  - Azure Event Grid - Webhook
    - Create a HTTP trigger azure function which will act as a webhook to receive the event
    - Need to do a handshake between the function and the azure event grid
    - This is to confirm that the function / webhook is owned by you
    - Create an HTTP Triggered function. Can Publish from Visual Studio - 348-using-an-http-endpoint
    - Create Event Subscription in Azure Storage Account
    - Endpoint Type: Webhook
    - Select Endpoint: Specify HTTP URL of the function
    - Notice that it does hand shake
