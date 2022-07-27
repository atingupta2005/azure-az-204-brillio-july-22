# Build Docker Image and Push to ACR
- Open Azure Cloud Shell
- Run below commands
```
az account list
```

```
az account set --subscription "31c5e63f-c5a3-4b49-a624-ecea04e21d42"
```

```
ACR_NAME=acrag$(echo $RANDOM | md5sum | head -c 10;)
```

```
az group create --location eastus --resource-group  rgbrillioacr
```

```
az acr create -n $ACR_NAME -g rgbrillioacr --sku Basic
```

```
cd ~
git clone https://github.com/atingupta2005/core-web-app-docker
cd ~/core-web-app-docker/core-web-app-docker
```

```
TOKEN=$(az acr login --name $ACR_NAME --expose-token --output tsv --query accessToken)
```

```
echo $TOKEN
echo $ACR_NAME
```

```
docker login $ACR_NAME.azurecr.io --username 00000000-0000-0000-0000-000000000000 --password $TOKEN
```

```
az acr build --image webapp/core-web-app-docker:v1 --registry $ACR_NAME --file Dockerfile .
```

- Open Azure Portal
- Create ACI using this image
