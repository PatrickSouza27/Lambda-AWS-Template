<img src="https://www.ibm.com/content/dam/adobe-cms/instana/media_logo/AWS-Lambda.png/_jcr_content/renditions/cq5dam.web.1280.1280.png" min-width="400px" max-width="400px" width="400px" align="right" alt="Computador iuriCode">

# Lambda AWS Template <img alt="amazon" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/amazonwebservices/amazonwebservices-original.svg" height="80">

<p align="left"> 
  Template padrão pronto para aplicações utilizando lambda.<br>
  A function foi criada para a região us-east-1.<br>
  Para conseguir criar novas lambdas, dar um deploy e testar, deve ter o aws credentials configurado na sua maquina
</p>

packages
``` Amazon.Lambda.Core ```
``` AWSSDK.Lambda ```

* [AWS CLI](https://balta.io/blog/docker-instalacao-configuracao-e-primeiros-passos?utm_source=github&utm_medium=2805-repo&utm_campaign=readme).

#### para a criação da lambda
```
  dotnet new lambda.EmptyFunction --name NOMEDAFUNÇÃO --profile default --region us-east-1
										   REGIÃO
```
Adicionar na sln a nova função criada e xunit
```
  dotnet sln add NOMEDAFUNÇÃO/src/NOMEDAFUNÇÃO/NOMEDAFUNÇÃO.csproj
  dotnet sln add NOMEDAFUNÇÃO/test/NOMEDAFUNÇÃO.Tests/NOMEDAFUNÇÃO.Tests.csproj
```

#### Deploy

```https
  dotnet lambda deploy-function
```
Ele irá te pedir para dar um nome para sua função
NameLambda: NomeDaSuaLambdaDeploy, em Invoke coloque o nome dela para conseguir debbugar localmente a função, defina o projeto console "Invoke" como de inicialização


![image](https://github.com/PatrickSouza27/Lambda-AWS-Template/assets/77933748/01396158-ea1d-4e92-bc0f-e64a1291baaf)   

Exemplo de resposta:

![image](https://github.com/PatrickSouza27/Lambda-AWS-Template/assets/77933748/82713b95-7ad5-4e85-80d4-ddd07aafa8c3)

