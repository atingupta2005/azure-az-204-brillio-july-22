# Azure Service Bus
  - What is the Azure Service Bus
  - Azure Service Bus - Queue - .Net
  - Azure Service Bus - Queue Properties
  - Azure Service Bus - Message Properties
  - Azure Service Bus - Message properties - .Net
  - Azure Service Bus Queue - Receive and Delete Mode
  - Azure Service Bus - Topics
  - Azure Service Bus topic - filters
  - Azure Service Bus - Dead letter queues
  - Azure Service Bus - Duplicate Detection
  - Azure Service Bus - Correlation Id
  - Azure Service Bus - Best Practices
    - Don't close the client object connection multiple times after sending or receiving a message. It's an expensive operation
    - Hence use the same client object for multiple operation
    - Batched store access is when the queue itself batches multiple messages before it is written to the internal store. This helps in better throughput.
    - Enable Prefetch – Here the receiver quietly acquires more messages from the queue or topic subscription. This is up to a value defined by the PrefetchCount limit.
    - When a receiver wants to receive messages, the messages are received from the buffer based on the number of prefetched messages. Then additional messages are prefetched again in the background.
      ```
        QueueClient.PrefetchCount
      ```

  - Azure Service Bus - Creating a queue - .Net
  - Azure Service Bus - Azure CLI
    - You can use the following commands to work with the Azure Service Bus service

    - You can set the following variables for your script
      ```
          $namespace="appnamespace4000"
          $resourcegrp="demogrp1"
          $location="Central US"
          $queuename="appqueue"
          $topicname="apptopic"
          $subscriptionName="SubscriptionA"
      ```

    - You can use the following command to create a service bus namespace
      ```
          az servicebus namespace create --name $namespace --resource-group $resourcegrp --location $location --sku Standard
      ```
    - You can use the following command to create a service bus queue
      ```
          az servicebus queue create --resource-group $resourcegrp --namespace-name $namespace --name $queuename --max-size 1024
      ```
    - You can use the following command to create a service bus topic
      ```
          az servicebus topic create --resource-group $resourcegrp --namespace-name $namespace --name $topicname --max-size 1024
      ```
    - You can use the following command to create a service bus subscription
      ```
          az servicebus topic subscription create --resource-group $resourcegrp --namespace-name $namespace --topic-name $topicname --name $subscriptionName
      ```
