# Architeture - TCC
Uma POC para um projeto de TCC que  inclui os seguintes conceitos:
  - Integração de um "Sistema" legado com uma aplicação web envolvendo API Rest e microsserviços para manter a compatibilidade entre as 2 versões, de modo que o usuário possa utilizar a aplicação "legado" e a aplicação web sem a necessidade de migrações;
  - Legado utilizando C#;
  - API Rest em Java com conceitos de MVC, Microsserviços e RabbitMq;
  - Docker para a interação com o ambiente e o Banco de dados;
  - Hospedagem do Banco de Dados e das API's em nuvem;

Divisão
  - ManagerService - Versão Inicial: Versão do sistema legado em C#, já com a implementação do RabbitMq.
  - Versão 2.0: Inclui a implementação da API de autenticação e futuras API's que representam a aplicação web.
  - manager-service-pagamento: Representa uma API externa à aplicação web, para demonstrar a compatibilidade.
  - Docker: itens de configuração do docker e instalação local para ambiente de desenvolvimento.
