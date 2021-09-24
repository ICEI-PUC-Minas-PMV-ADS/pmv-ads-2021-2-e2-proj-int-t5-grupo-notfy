# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

![](img/Alice.png)
Alice Idade: 54 anos Gênero: Feminino Profissão: Tabeliã Instrução: Bacharel em Direito Estado civil: Casada Cidade: Jaboticatubas Mídias: Twitter, Facebook e Instagram

Biografia: Alice mineira nascida na região da serra do espinhaço, no município de Jaboticatubas, tem 54 anos, apaixonada por sua família e pela natureza, trabalhou por anos em um cartório em Belo Horizonte como escrevente, hoje trabalha em seu próprio cartório. É aficcionada por inovações tecnológicas. Também é simpática e muito influente na cidade. Seu hobby favorito são as caminhadas ao ar livre.

Desafios: Administrar melhor seu Cartório, procurar ferramentas e mecanismos que facilitem a rotina no trabalho de toda sua equipe. Otimização de processos.


Bruno Idade: 27 anos Gênero: Masculino Profissão: Notificador Instrução: Graduando em Administração Estado civil: Solteiro Cidade: Belo Horizonte Mídias: Twitter, Facebook e Instagram

Biografia: Bruno Almeida, tem 27 anos, cursa Administração no período noturno e trabalha no período integral. Ele é fã de novas tecnologias, utiliza muitos apps para facilitar seu dia a dia bastante atarefado. É um homem bastante comunicativo, tem facilidade de relacionar com as pessoas. Bruno gosta de ouvir músicas eletrônicas e podcast, e tem hábito de praticar corridas de rua aos finais de semana. Fica muito tempo conectado na internet, utilização maior pelo celular.

Desafios: Por por não conseguir atender muitas demandas, perder muito tempo no deslocamento entre uma notificação e outra, além do alto custo financeiro para o deslocamento com pouca logística, Bruno acredita que poderia utilizar a tecnologia a seu favor para melhorar seu desempenho com as notificações. Otimizando seu trabalho, atenderia com mais eficácia suas demandas e aumentaria a segurança do processo referente às notificações extrajudiciárias.


Cíntia Idade: 45 anos Gênero: Feminino Profissão: Advogada e Notária de Cartório Instrução: Bacharel em Direito Estado civil: Casada Cidade: Contagem Mídias: Facebook e Instagram

Biografia: É advogada e notária em um cartório na região de Contagem. Casada e mãe de duas crianças, gosta de passar o tempo livre com sua família. Ela tem um perfil analítico e focada em conhecimento, obcecada com novidades e inovações. Quer sempre qualificar sua equipe, porém não dispõe de muito tempo e sua agenda está sempre apertada.

Desafios: Ela gostaria de aumentar seus resultados utilizando ferramentas tecnológicas que simplifiquem seus processos diários otimizando tempo e gerando melhores resultados - com estratégias inovadoras, ser líder referência para sua equipe. Seus principais obstáculos são o excesso de tarefas e a dificuldade de gestão de tempo, além da falta de incentivo e aprovação da direção para colocar em prática todas as suas ideias.


Joana Dark Idade: 47 anos Profissão: Notificadora Escolaridade: Ensino médio completo Estado civil: Casada. Cidade: Belo Horizonte - MG

Biografia: Joana é uma mulher de 47 anos, mãe de 2 filhos adultos e avó de 1 neto. Trabalha como notificadora há 20 anos. Não tem a pretensão de avançar nos estudos e está satisfeita com sua escolarização e profissão. Também não gosta de ferramentas complicadas. Após o expediente, Joana faz doces para a confeitaria que ele tem em casa com uma de suas filhas. Nos momentos de lazer, gosta de assistir novelas e ler revistas e ter um tempo livre com o seu neto.

Desafios: Joana se perde muito por não ter uma rota pré-definida. Perde muito tempo tentando planejar um roteiro de entrega e ainda assim, acaba fazendo um trajeto ineficiente. Precisa otimizar as atividades como notificadora para se dedicar mais à confeitaria, considerando que demora para concluir suas atividades diárias. Tem muita dificuldade com tecnologias e coisas novas, também não se interessa em aprender porque se julga incapaz.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

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
|02| Não pode ser desenvolvido um módulo de backend        |


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
