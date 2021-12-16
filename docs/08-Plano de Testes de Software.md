# Plano de Testes de Software
BackGround: Login
Cenário 1
Dado que eu insiro dados (e-mail e senha) válidos para login
Quando eu clicar em entrar
Então eu devo ver uma mensagem "Bem vindo <usuário>"

Cenário 2
Dado que eu insiro um e-mail válido
E informo uma senha errada
Quando eu clico em entrar
Então o sistema deve retornar uma mesnagem de falha "Usuário e/ou senha inexistentes"

Cenário 3
Dado que eu loguei corretamente
Quando recebo mensagem de login com sucesso
E aguardo o sistema terminar de processar
Então eu devo visualizar a tela inicial com a lista de notificações

Background: Tela de notificações
Eu como administrador
Quero incluir/editar uma notificação

Cenário 4
Dado que eu estou na tela de notificações
Quando eu clico no ícone (+) de inclusão
Então eu devo ver a tela de cadastro de notificações

Cenário 5
Dado que eu preenchi todos os dados obrigatórios do formulário de cadastro de notificação 
Quando eu clico em Salvar
Então a notificação deve ser acrescentada na lista de notificações

Cenário 6
Dado que eu deixei de preencher algum campo obrigatório no formulário de cadastro de notificações
Quando eu clico em salvar
Então o sistema deve retornar uma mensagem de erro "É obrigatório informar <campo x>"
 
 Background: Tela de notificações
 Eu como notificador
 Quero registrar as tentativas de entrega da notificação
 
 Cenário 7
 Dado que eu realizei a primeira tentativa
 Quando eu informo a data
 E clico em Salvar
 Então uma mensagem de confirmação deve surgir na tela "Tem certeza que deseja registrar a tentativa"
 
 Cenário 8
 Dado que eu recebi uma mesagem de confirmação de registro de tentativa de notificação
 Quando eu confirmo a opção
 Então o sistema deve exibir uma mensagem de sucesso "Tentativa registrada com sucesso"
 
 Cenário 9
 Dado que eu quero registrar a segunda tentativa de entega de notificação
 Quando eu informo uma data anterior a data da primeira tentativa
 Então o sistema deve exibir uma mensagem de falha "A data da tentativa não pode ser inferior a data anterior"
 
 Background: Eu como notificador
 Consegui entregar uma notificação
 
 Cenário 10
 Dado que eu entreguei uma notificação
 Quando eu altero o status da notificação para "Sim"
 Então o status deve ser alterado na lista de notificões
 E tentativas não registradas devem ser bloqueadas
 E uma mensagem deve ser exibida "Status da notificação alterado com sucesso"
 
 Cenário 11
 Dado que eu alterei um status para sim 
 E ainda restam tentativas sem registro
 Quando eu tento registrar mais uma tentativa
 Então o campo de registro deve estar bloqueado
 
 Background: Cadastro, edição e exclusão de notificadores
 Eu como administrador
 Quero gerenciar os notificadores da minha base
 
 
 
## Ferramentas de Testes (Opcional)

Comente sobre as ferramentas de testes utilizadas.
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
