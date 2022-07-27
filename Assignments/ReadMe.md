# Assignments
1. John is Azure developer in company. He need to implement a solution where he need to process the files as they are stored in the Azure Storage Account. He is planning to create an Azure Function which will be triggered whenever a new file is uploaded to the storage account and process that file to get the size of the file. If the size is > 1 MB then delete the file from storage account else send a JSON message to the queue with details like - file name, file size, date of process.

1. You need to create a storage account which should have soft delete enabled. Now connect storage account using storage explorer and upload files to container. Store the file as cold storage tier to save the cost.

1. Create an Azure App service and deploy the application which is available on GitHub. Now modify the application on GitHub and make sure that changes are reflected to web app or now. Also open the logs in App Service to understand the auto deployment events. Form below GitHub repo for this.
	- https://github.com/atingupta2005/core-web-app-docker

1. Create Azure Function which can be called via HTTP trigger. Upon calling this function, it should store the output in Azure Storage table. You can take any static data which should be sample as table entries in Azure Storage Table.

1. Write a dot net azure project which will connect to the azure storage blob container and process all the files in it. In case the size of the file is more than 1 MB then change the storage tier to Cold. And if the size of the file > 10 MB then change storage tier to Archive. Also set the metadata properties to store the information like - date of processing, file size

1. Create Azure Web App with 2 deployment slots. Whenever any change is to be done in the app then first deploy to the staging slot. Test the application deployed to staging slot. If test results are positive then swap the slot with production slot for deployment.
	- https://github.com/atingupta2005/core-web-app-docker

1. Amit needs to have the read access to a blob stored in storage container. He need access only for 3 days starting from next week. How will you make sure that the access to Amit should be given only the read only access on the days he needs to work on that Blob?

1. Akansha is the developer and her team is now using containerized deployment. So she need to create a docker image of her dot net application she has developer and she also need to upload image to Azure Container Registry. How she can do this?
