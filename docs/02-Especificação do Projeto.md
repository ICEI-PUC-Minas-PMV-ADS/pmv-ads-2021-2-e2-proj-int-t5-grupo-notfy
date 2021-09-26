# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

![img](img/Alice.PNG)

Alice Idade: 54 anos Gênero: Feminino Profissão: Tabeliã Instrução: Bacharel em Direito Estado civil: Casada Cidade: Jaboticatubas Mídias: Twitter, Facebook e Instagram

Biografia: Alice mineira nascida na região da serra do espinhaço, no município de Jaboticatubas, tem 54 anos, apaixonada por sua família e pela natureza, trabalhou por anos em um cartório em Belo Horizonte como escrevente, hoje trabalha em seu próprio cartório. É aficcionada por inovações tecnológicas. Também é simpática e muito influente na cidade. Seu hobby favorito são as caminhadas ao ar livre.

Desafios: Administrar melhor seu Cartório, procurar ferramentas e mecanismos que facilitem a rotina no trabalho de toda sua equipe. Otimização de processos.

![img](img/Bruno.PNG)

Bruno Idade: 27 anos Gênero: Masculino Profissão: Notificador Instrução: Graduando em Administração Estado civil: Solteiro Cidade: Belo Horizonte Mídias: Twitter, Facebook e Instagram

Biografia: Bruno Almeida, tem 27 anos, cursa Administração no período noturno e trabalha no período integral. Ele é fã de novas tecnologias, utiliza muitos apps para facilitar seu dia a dia bastante atarefado. É um homem bastante comunicativo, tem facilidade de relacionar com as pessoas. Bruno gosta de ouvir músicas eletrônicas e podcast, e tem hábito de praticar corridas de rua aos finais de semana. Fica muito tempo conectado na internet, utilização maior pelo celular.

Desafios: Por por não conseguir atender muitas demandas, perder muito tempo no deslocamento entre uma notificação e outra, além do alto custo financeiro para o deslocamento com pouca logística, Bruno acredita que poderia utilizar a tecnologia a seu favor para melhorar seu desempenho com as notificações. Otimizando seu trabalho, atenderia com mais eficácia suas demandas e aumentaria a segurança do processo referente às notificações extrajudiciárias.

![img](img/Cíntia.PNG)

Cíntia Idade: 45 anos Gênero: Feminino Profissão: Advogada e Notária de Cartório Instrução: Bacharel em Direito Estado civil: Casada Cidade: Contagem Mídias: Facebook e Instagram

Biografia: É advogada e notária em um cartório na região de Contagem. Casada e mãe de duas crianças, gosta de passar o tempo livre com sua família. Ela tem um perfil analítico e focada em conhecimento, obcecada com novidades e inovações. Quer sempre qualificar sua equipe, porém não dispõe de muito tempo e sua agenda está sempre apertada.

Desafios: Ela gostaria de aumentar seus resultados utilizando ferramentas tecnológicas que simplifiquem seus processos diários otimizando tempo e gerando melhores resultados - com estratégias inovadoras, ser líder referência para sua equipe. Seus principais obstáculos são o excesso de tarefas e a dificuldade de gestão de tempo, além da falta de incentivo e aprovação da direção para colocar em prática todas as suas ideias.

![img](img/Joana.PNG)
Joana Dark Idade: 47 anos Profissão: Notificadora Escolaridade: Ensino médio completo Estado civil: Casada. Cidade: Belo Horizonte - MG

Biografia: Joana é uma mulher de 47 anos, mãe de 2 filhos adultos e avó de 1 neto. Trabalha como notificadora há 20 anos. Não tem a pretensão de avançar nos estudos e está satisfeita com sua escolarização e profissão. Também não gosta de ferramentas complicadas. Após o expediente, Joana faz doces para a confeitaria que ele tem em casa com uma de suas filhas. Nos momentos de lazer, gosta de assistir novelas e ler revistas e ter um tempo livre com o seu neto.

Desafios: Joana se perde muito por não ter uma rota pré-definida. Perde muito tempo tentando planejar um roteiro de entrega e ainda assim, acaba fazendo um trajeto ineficiente. Precisa otimizar as atividades como notificadora para se dedicar mais à confeitaria, considerando que demora para concluir suas atividades diárias. Tem muita dificuldade com tecnologias e coisas novas, também não se interessa em aprender porque se julga incapaz.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Escolher como informar o ponto de partida para iniciar o dia. Se por minha localidade atual ou se por um ponto específico            | Eu posso querer iniciar agora ou a partir de um lugar que estou indo para outro compromisso pessoal.               |
|-------------|------------------------------------|----------------------------------------|
|Notificador         | Pausar rota em paradas longas para atividades que não sejam relacionadas à atividade cartorária               | Pausa para almoço ou descanso |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Incluir um endereço para alguma atividade pessoal na lista de endereços e notificações, desde que essa tarefa não tenha um horário específico para ser realizada durante o dia                 | Se eu preciso passar no cartório para pegar algum documento para o dia seguinte ou realizar alguma tarefa pessoal em determinado endereço sem um horário fixo, eu posso incluir o endereço na rota normal |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Alterar rota para reiniciar a partir de um ponto em outra localidade e voltar com os endereços já roteados que não couberem mais na nova rota para fila dos próximos dias                 | Caso eu esteja em um ponto A e precise ir para um ponto fora da rota não previsto, a rota pode ser reiniciada a partir do ponto que estou indo. |
|-------------|------------------------------------|----------------------------------------|
|Notificador       |Selecionar quantos endereços pretendo ir durante o dia ou quando pretendo parar  quando eu  iniciar ou reiniciar uma rota              | Para que a rota conste apenas a quantidade prevista de notificações no dia ou quantidade suportada dentro do volume de horas trabalhado no dia |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Voltar endereços não visitados para fila de endereços não visitado quando não der tempo de ir em todos os endereços roteados ou eu precisar parar por qualquer motivo                 | Não perder de vista estes endereços que não foram visitados |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Informar tentativa de notificação sem êxito e a razão de não ter conseguido entregar a notificação.                 | iniciar a geração de comprovação de que a tentativa foi feita |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Gravar local/endereço de visita no informativo de tentativa de notificação                | Gerar comprovação de que eu estava no endereço correto no momento da tentativa
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Colher a assinatura do notificado confirmando ter recebido e ter ciência dos que foi informado                 | Gerar comprovação da entrega da notificação |
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Imprimir notificação assinada pelo notificado                 | Entregar o documento ao notificado e para possível arquivo físico se necessário |
|-------------|------------------------------------|----------------------------------------|
|Novo Notificador       | Me cadastrar no sistema Notfy                | Cadastro do notificador |
|-------------|------------------------------------|----------------------------------------|
|Notificador  e Novo notificador     | Solicitar autorização aos cartórios para os quais eu presto serviço, para vincular meu perfil às demandas que o cartório repassa para mim                 | Manter a segurança dos dados das notificações, garantindo que apenas notificadores que realmente prestam serviço para o cartório tem acesso às demandas|
|-------------|------------------------------------|----------------------------------------|
|Notificador       | Fazer login com meu usuário e senha                | Para garantir segurança nos dados  |
|-------------|------------------------------------|----------------------------------------|
|Usuário      | Quero que a a aplicação seja responsiva para que seja acessado via mobile ou tablet para uso durante o trabalho                 | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Ter visibilidade do status do sistema, tal qual a primeira heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Que haja correspondência entre o sistema e o mundo real, tal qual a segunda heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Ter liberdade de controle das minhas ações, como a terceira heurística de Nielsen recomenda          | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Que haja consistência e Padronização no sistema, como a quarta heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Ser prevenido dos meus erros no sistema, como a quinta heurística de Nielsen recomenda          | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Reconhecer ao invés de memorizar, como a sexta heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Ter flexibilidade e eficiência para utilizar o sistema, tal qual a sétima heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário       | Receber ajuda e ter documentação disponível, tal qual a décima heurística de Nielsen recomenda           | Promover usabilidade e boa experiência do usuário |
|-------------|------------------------------------|----------------------------------------|
|Usuário com deficiência visual     | Conseguir utilizar o sistema usando o leitor de telas           | Promover acessibilidade, segundo diretrizes do W3C|
|-------------|------------------------------------|----------------------------------------|
|Usuário com deficiência auditiva       | Que o sistema fale a minha língua, libras           | Promover acessibilidade, segundo diretrizes do W3C |
|-------------|------------------------------------|----------------------------------------|
|Dono do Sistema     | Que meu sistema seja escalável com capacidade para lidar com níveis crescentes de carga           | Produto escalável |
|-------------|------------------------------------|----------------------------------------|
|Dono do Sistema       | Ter segurança de que meu sistema consegue lidar com problemas de concorrência, já que fornece demandas para diferentes notificadores           | Evitar erros relacionados à concorrência de dados, como por exemplo enviar a mesma demanda para mais de um notificador |
|-------------|------------------------------------|----------------------------------------|
|Dono do sistema       | Que a seção dos usuários expire por inatividade após determinado tempo, ou após fechar o browser            | Manter segurança da plataforma |
|-------------|------------------------------------|----------------------------------------|

> **Referências**:
> - [Heurísticas de Nielsen ](https://www.nngroup.com/)
> - [Guia de acessibilidade](https://w3c.br/Home/WebHome/)


> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                                                          | Prioridade |
|------|-----------------------------------------                                                        |----|
|RF-001| Permitir cadastrar os notificadores.                                                            | ALTA | 
|RF-002| Permitir alterar cadastro notiicadores.                                                         | ALTA |
|RF-003| Permitir cadastrar notificandos.                                                                | MÉDIA|
|RF-004| Permitir alterar cadastro notificandos.                                                         | ALTA |
|RF-005| Permitir cadastrar notificações.                                                                | MÉDIA|
|RF-006| Incluir lista de notificaçoes diarias.                                                          | MÉDIA|
|RF-007| Permitir alterar lista.                                                                         | MÉDIA|
|RF-008| Permitir definir ponto de partida e finalização.                                                | MÉDIA|
|RF-009| Permitir definir sequencia de entrega notificações.                                             | MÉDIA|
|RF-010| Gerar rota de acordo com a sequencia.                                                           | MÉDIA|
|RF-011| Permitir Realizar pausas e alterar rotas e sequencias.                                          | MÉDIA|
|RF-012| Permitir realizar checkin no endereço do notificando.                                           | MÉDIA|
|RF-013| No checkin, permitir informar tentativa de notificação sem exito.                               | MÉDIA|
|RF-014| Permitir registrar até 3 tentativas de entrega em cada endereço do notificando.                 | MÉDIA|
|RF-015| Permitir incluir notificação em listas de outros dias em caso de negativa da notificação.       | MÉDIA|
|RF-016| Permitir registrar conclusão da diligencia se efetivada a notificação.                          | MÉDIA|
|RF-017| Se diligencia efetivada, permitir gerar certidão de conlusão.                                   | MÉDIA|
|RF-018| Permitir alterar certidão de conclusão.                                                         | BAIXA|
|RF-019| Realizar baixa da notificação após emissão da certidão.                                         | MÉDIA|



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel.                             | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 5s.                                         | BAIXA | 
|RNF-003| Validar senha de acesso.                                                                       | MÉDIA | 
|RNF-004| O sistema deve ser responsivo para rodar em um dispositivos móvel.                              | MÉDIA | 
|RNF-005| O sistema deve se comunicar com o SQL Server.                                                  | MÉDIA | 
|RNF-006| O sistema deve ser responsivo para rodar em um dispositivos móvel.                              | MÉDIA | 
|RNF-007| O sistema deve ser escalável para integração com rotas do google.                              | MÉDIA | 


Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O Sistema não tem integração nativa com outros softwares do cartório.|
|03| O Sistema não mantém comunicação com outros bancos de dados além do SQL Server.|



Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

Para o diagrama de casos de uso, utilizamos a ferramenta [Lucidchart](https://www.lucidchart.com/)
<br/>

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
