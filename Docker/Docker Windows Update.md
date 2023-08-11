[[_TOC_]]

## **Docker para Windows**

PowerShell ADMIN 

**Atualizar o subsistema:** 

`dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart`


**Ativar VM**

`dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart`



**Baixar pacote de atualização**`https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi`



**Definir WSL 2 como padrão**

`wsl --set-default-version 2`



Baixar versão linux

`https://apps.microsoft.com/store/detail/ubuntu-1804-on-windows/9N9TNGVNDL3Q?hl=pt-br&gl=br&rtc=1`
