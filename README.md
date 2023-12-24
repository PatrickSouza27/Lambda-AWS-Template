<img src="https://www.ibm.com/content/dam/adobe-cms/instana/media_logo/AWS-Lambda.png/_jcr_content/renditions/cq5dam.web.1280.1280.png" min-width="400px" max-width="400px" width="400px" align="right" alt="Computador iuriCode">

# Lambda AWS Template <img alt="amazon" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/amazonwebservices/amazonwebservices-original.svg" height="80">

<p align="left"> 
  Template padrão pronto para aplicações utilizando lambda.<br>
  A function foi criada para a região us-east-1<br>.
  Para conseguir criar novas lambdas, dar um deploy e testar, deve ter o aws credentials configurado na sua maquina
</p>

#### Documentação swagger

```https
  https://localhost:{0000}/swagger/index.html
```

#### Valor
```https
  https://localhost:{0000}/{NumeroPlaca}
```

| string placa   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| IZO1880 | `string` | Coloque uma placa valida |

#### Sucesso
```json
  {
  "data": {
    "marca": "RENAULT",
    "modelo": "MEGANEGT DYN 16",
    "importado": "Não",
    "ano": "2011",
    "anoModelo": "2011",
    "cor": "Prata",
    "cilindrada": "1598 cc",
    "potencia": "115 cv",
    "combustivel": "Álcool / Gasolina",
    "chassi": "*****J762015",
    "motor": "*****Q031861",
    "passageiros": "5",
    "uf": "RS",
    "municipio": "SARANDI"
  },
  "erros": []
}
```
#### Falha
```json
  {
  "data": null,
  "erros": [
    "Carro Não Encontrado, Verifica o Numero da Placa"
  ]
}
```


