## Create VM
 - Image Name: Visual Studio 2019 - Community on Windows Server 2019
 - Size: Standard_D8s_v3

## Install chocolatey
```
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
```

## Install Softwares
```
choco install -y googlechrome
choco install -y microsoft-edge
choco install -y microsoftazurestorageexplorer
choco install -y postman
```

## Clone Git Repo
```
cd \
git clone https://github.com/atingupta2005/azure-az-204-brillio-july-22
cd azure-az-204-brillio-july-22
explorer .
```

## Change default web browser to Chrome

## Open Visual Studio

## Sign in with your Azure Login ID
