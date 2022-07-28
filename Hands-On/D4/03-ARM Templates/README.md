# Create Azure Resources using ARM templates

```
git clone https://github.com/atingupta2005/azure-az-204-brillio-july-22
cd azure-az-204-brillio-july-22/Hands-On/D4/03-ARM\ Templates/
cat storage1.arm.json
```

```
az deployment group create   --resource-group rgarmbrillio  --template-file storage1.arm.json
```

```
az deployment sub create --location northeurope --template-file storage1.arm.json
```

```
az deployment group create --resource-group new-grp --template-uri https://raw.githubusercontent.com/atingupta2005/azure-az-204-brillio-july-22/main/Hands-On/D4/03-ARM%20Templates/storage-arm-template-3-copies.json
```
