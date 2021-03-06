# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

![img](img/Alice.PNG)

**Alice** <br/> Idade: 54 anos <br/>  Gênero: Feminino <br/> Profissão: Tabeliã e Proprietária de Cartório <br/> Instrução: Bacharel em Direito <br/>  Estado civil: Casada <br/> Cidade: Jaboticatubas-MG <br/>  Mídias: Twitter, Facebook e Instagram

Biografia: Alice mineira nascida na região da serra do espinhaço, no município de Jaboticatubas, tem 54 anos, apaixonada por sua família e pela natureza, trabalhou por anos em um cartório em Belo Horizonte como escrevente, hoje trabalha em seu próprio cartório. É aficionada por inovações tecnológicas. Também é simpática e muito influente na cidade. Seu hobby favorito são as caminhadas ao ar livre.

Desafios: Administrar melhor seu Cartório, procurar ferramentas e mecanismos que facilitem a rotina no trabalho de toda sua equipe. Otimização de processos.<br/> 

--

![img](img/Bruno.PNG)

**Bruno** <br/> 
Idade: 27 anos <br/>  Gênero: Masculino<br/>  Profissão: Notificador <br/> Instrução: Graduando em Administração<br/>  Estado civil: Solteiro <br/> Cidade: Belo Horizonte-MG<br/>  Mídias: Twitter, Facebook e Instagram

Biografia: Bruno Almeida, tem 27 anos, cursa Administração no período noturno e trabalha no período integral. Ele é fã de novas tecnologias, utiliza muitos apps para facilitar seu dia a dia bastante atarefado. É um homem bastante comunicativo, tem facilidade de relacionar com as pessoas. Bruno gosta de ouvir músicas eletrônicas e podcast, e tem hábito de praticar corridas de rua aos finais de semana. Fica muito tempo conectado na internet, utilização maior pelo celular.

Desafios: Por não conseguir atender muitas demandas, perder muito tempo no deslocamento entre uma notificação e outra, além do alto custo financeiro para o deslocamento com pouca logística, Bruno acredita que poderia utilizar a tecnologia a seu favor para melhorar seu desempenho com as notificações. Otimizando seu trabalho, atenderia com mais eficácia suas demandas e aumentaria a segurança do processo referente às notificações extrajudiciárias.
<br/> 

--

![img](img/Cíntia.PNG)

**Cíntia** <br/> Idade: 45 anos <br/> Gênero: Feminino <br/> Profissão: Advogada e Notária de Cartório <br/> Instrução: Bacharel em Direito<br/>  Estado civil: Casada <br/> Cidade: Contagem-MG <br/> Mídias: Facebook e Instagram

Biografia: É advogada e notária em um cartório na região de Contagem. Casada e mãe de duas crianças, gosta de passar o tempo livre com sua família. Ela tem um perfil analítico e focada em conhecimento, obcecada com novidades e inovações. Quer sempre qualificar sua equipe, porém não dispõe de muito tempo e sua agenda está sempre apertada.

Desafios: Ela gostaria de aumentar seus resultados utilizando ferramentas tecnológicas que simplifiquem seus processos diários otimizando tempo e gerando melhores resultados - com estratégias inovadoras, ser líder referência para sua equipe. Seus principais obstáculos são o excesso de tarefas e a dificuldade de gestão de tempo, além da falta de incentivo e aprovação da direção para colocar em prática todas as suas ideias.

--

![img](img/Joana.PNG)

**Joana Dark** <br/> Idade: 47 anos <br/> Profissão: Notificadora <br/> Escolaridade: Ensino médio completo <br/> Estado civil: Casada <br/>  Cidade: Belo Horizonte - MG

Biografia: Joana é uma mulher de 47 anos, mãe de 2 filhos adultos e avó de 1 neto. Trabalha como notificadora há 20 anos. Não tem a pretensão de avançar nos estudos e está satisfeita com sua escolarização e profissão. Também não gosta de ferramentas complicadas. Após o expediente, Joana faz doces para a confeitaria que ele tem em casa com uma de suas filhas. Nos momentos de lazer, gosta de assistir novelas e ler revistas e ter um tempo livre com o seu neto.

Desafios: Joana se perde muito por não ter uma rota pré-definida. Perde muito tempo tentando planejar um roteiro de entrega e ainda assim, acaba fazendo um trajeto ineficiente. Precisa otimizar as atividades como notificadora para se dedicar mais à confeitaria, considerando que demora para concluir suas atividades diárias. Tem muita dificuldade com tecnologias e coisas novas, também não se interessa em aprender porque se julga incapaz.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--|--|--|
|Tabelião       | Quero cadastrar notificandos e alterar estes cadastros.            | Fornecer dados para o sistema.               |
|--|--|--|
|Funcionário do cartório       | Aprovar vínculo do notificador que tiver solicitado e realmente pertencer ao quadro de notificadores do cartório.            | permitir que o notificador tenha acesso às demandas.               |
|--|--|--|
|Notificador       | Escolher como informar o ponto de partida para iniciar o dia. Se por minha localidade atual ou se por um ponto específico.            | Eu posso querer iniciar agora ou a partir de um lugar que estou indo para outro compromisso pessoal.               |
|--|--|--|
|Notificador         | Pausar rota em paradas longas para atividades que não sejam relacionadas à atividade cartorária.               | Pausa para almoço ou descanso. |
|--|--|--|
|Notificador       | Incluir um endereço para alguma atividade pessoal na lista de endereços e notificações, desde que essa tarefa não tenha um horário específico para ser realizada durante o dia.                 | Se eu preciso passar no cartório para pegar algum documento para o dia seguinte ou realizar alguma tarefa pessoal em determinado endereço sem um horário fixo, eu posso incluir o endereço na rota normal. |
|--|--|--|
|Notificador       | Alterar rota para reiniciar a partir de um ponto em outra localidade e voltar com os endereços já roteados que não couberem mais na nova rota para fila dos próximos dias.                 | Caso eu esteja em um ponto A e precise ir para um ponto fora da rota não previsto, a rota pode ser reiniciada a partir do ponto que estou indo. |
|--|--|--|
|Notificador       |Selecionar quantos endereços pretendo ir durante o dia ou quando pretendo parar no momento em que eu iniciar ou reiniciar uma rota.              | Para que a rota conste apenas a quantidade prevista de notificações no dia ou quantidade suportada dentro do volume de horas trabalhadas no dia. |
|--|--|--|
|Notificador       | Voltar endereços não visitados para fila de endereços não visitados quando não der tempo de ir em todos os endereços roteados ou eu precisar parar por qualquer motivo.                 | Não perder de vista estes endereços que não foram visitados. |
||--|--|--|
|Notificador       | Informar tentativa de notificação sem êxito e a razão de não ter conseguido entregar a notificação.                 | iniciar a geração de comprovação de que a tentativa foi feita. |
|--|--|--|
|Notificador       | Gravar local/endereço de visita no informativo de tentativa de notificação.                | Gerar comprovação de que eu estava no endereço correto no momento da tentativa.
|--|--|--|
|Notificador       | Colher a assinatura do notificado confirmando ter recebido e ter ciência dos que foi informado.                 | Gerar comprovação da entrega da notificação. |
|--|--|--|
|Notificador       | Dar baixa na notificação.                 | Encerrar demanda e enviá-la para lista de impressão.  |
|--|--|--|
|Notificador       | Imprimir notificação assinada pelo notificado.                 | Entregar o documento ao notificado e para possível arquivo físico, se necessário. |
|--|--|--|
|Novo Notificador       | Me cadastrar no sistema Notfy.                | Cadastro do notificador. |
|--|--|--|
|Notificador  e Novo notificador     | Solicitar autorização aos cartórios para os quais eu presto serviço, para vincular meu perfil às demandas que o cartório repassa para mim.                 | Manter a segurança dos dados das notificações, garantindo que apenas notificadores que realmente prestam serviço para o cartório tenham acesso às demandas.|
|--|--|--|
|Notificador       | Fazer login com meu usuário e senha.                | Para garantir segurança nos dados.  |
|--|--|--|
|Usuário      | Quero que a a aplicação seja responsiva para que seja acessado via mobile ou tablet para uso durante o trabalho.                 | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Ter visibilidade do status do sistema, tal qual a primeira heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Que haja correspondência entre o sistema e o mundo real, tal qual a segunda heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Ter liberdade de controle das minhas ações, como a terceira heurística de Nielsen recomenda.          | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Que haja consistência e Padronização no sistema, como a quarta heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Ser prevenido dos meus erros no sistema, como a quinta heurística de Nielsen recomenda.          | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Reconhecer ao invés de memorizar, como a sexta heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Ter flexibilidade e eficiência para utilizar o sistema, tal qual a sétima heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário       | Receber ajuda e ter documentação disponível, tal qual a décima heurística de Nielsen recomenda.           | Promover usabilidade e boa experiência do usuário. |
|--|--|--|
|Usuário com deficiência visual.     | Conseguir utilizar o sistema usando o leitor de telas.           | Promover acessibilidade, segundo diretrizes do W3C.|
|--|--|--|
|Usuário com deficiência auditiva.       | Que o sistema fale a minha língua, libras.           | Promover acessibilidade, segundo diretrizes do W3C. |
|--|--|--|
|Dono do Sistema     | Que meu sistema seja escalável com capacidade para lidar com níveis crescentes de carga.           | Produto escalável. |
|--|--|--|
|Dono do Sistema       | Ter segurança de que meu sistema consegue lidar com problemas de concorrência, já que fornece demandas para diferentes notificadores.           | Evitar erros relacionados à concorrência de dados, como por exemplo enviar a mesma demanda para mais de um notificador. |
|--|--|--|
|Dono do sistema       | Que a seção dos usuários expire por inatividade após determinado tempo, ou após fechar o browser.            | Manter segurança da plataforma. |
|--|--|--|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                                                          | Prioridade |
|------|-----------------------------------------                                                        |----|
|RF-001| Permitir cadastrar os notificadores com login e senha                                           | ALTA | 
|RF-002| Permitir notificadores solicitarem vínculo em cartórios utilizando e-mail coorporativo como dado validador | ALTA | 
|RF-003| Permitir alterar cadastro notificadores.                                                          | ALTA |
|RF-004| Permitir cadastrar notificandos.                                                                | MÉDIA|
|RF-005| Permitir alterar cadastro notificandos.                                                         | ALTA |
|RF-006| Permitir cadastrar notificações.                                                                | MÉDIA|
|RF-007| Incluir lista de notificações diárias.                                                          | MÉDIA|
|RF-008| Permitir alterar lista de notificações.                                                         | MÉDIA|
|RF-009| Permitir definir ponto de partida e finalização.                                                | MÉDIA|
|RF-010| Permitir definir sequencia de entrega notificações.                                             | MÉDIA|
|RF-011| Gerar rota de acordo com a sequência.                                                           | MÉDIA|
|RF-012| Permitir Realizar pausas e alterar rotas e sequencias.                                          | MÉDIA|
|RF-013| Permitir realizar check-in no endereço do notificando.                                           | MÉDIA|
|RF-014| No check-in, permitir informar tentativa de notificação sem êxito.                               | MÉDIA|
|RF-015| Permitir registrar até 3 tentativas de entrega em cada endereço do notificando.                 | MÉDIA|
|RF-016| Permitir incluir notificação em listas de outros dias em caso de negativa da notificação.       | MÉDIA|
|RF-017| Permitir registrar conclusão da diligencia se efetivada a notificação.                          | MÉDIA|
|RF-018| Se diligencia efetivada, permitir gerar certidão de conclusão.                                   | MÉDIA|
|RF-019| Permitir imprimir certidão                                                                      | MÉDIA|
|RF-020| Permitir imprimir notificações                                                                  | MÉDIA|
|RF-021| Permitir alterar certidão de conclusão.                                                         | BAIXA|
|RF-022| Realizar baixa da notificação após emissão da certidão.                                         | MÉDIA|



### Requisitos não Funcionais (incluindo Usabilidade e acessibilidade)

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móveis.                             | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 10s.                                         | BAIXA | 
|RNF-003| Validar senha de acesso.                                                                       | MÉDIA | 
|RNF-004| Para recurso de impressão deve utilizar um ícone de impressora, conforme lista de ícones definidos pelo design  (usar sempre o mesmo ícone mesmo que o recurso esteja em outra tela)                          | MÉDIA | 
|RNF-005| Todas as telas devem possuir botão voltar e sair                          | MÉDIA | 
|RNF-006| Os botões Voltar e Sair devem utilizar um ícone de Seta para direita e esquerda respectivamente, conforme lista de ícones definidos pelo design  (usar sempre o mesmo ícone mesmo que o recurso esteja em outra tela)                          | MÉDIA | 
|RNF-007| No topo da tela, é preciso ter marcadores direcionadores para partes importantes do sistema                          | MÉDIA | 
|RNF-008| Todos os ícones devem ser implementados utilizado o recurso 'alt' para inclusão de tootip                          | MÉDIA | 
|RNF-009| Toda e qualquer imagem deve ser implementada utilizando o recurso 'alt' para descrição da imagem                          | MÉDIA | 
|RNF-010| Em caso de imagens decorativas, implementar o recurso 'alt' de modo que o leitor de tela ignore a imagem                          | MÉDIA | 
|RNF-011| O sistema deve utilizar-se do recurso VLibras ( ferramenta gratuita e de implementação no front-end para renderização de um avatar que traduz textos e mídia de áudio para Libras                          | MÉDIA | 
|RNF-012| Para ações definitivas no sistema, como dar baixa, fazer check-in ou check-out por exemplo, o sistema deve abrir uma caixa de diálogo perguntando se o cliente tem certeza da ação e pedindo confirmação                          | MÉDIA | 
|RNF-013| Os lables para preenchimento devem conter uma máscara com exemplo de como o usuário deve inserir a informação                          | MÉDIA | 
|RNF-014| Para dados que exigem alguma formatação específica, além da máscara, caso o usuário digite errado, o sistema precisa lançar um alerta debaixo do lable preenchido errado, em cor vermelha.                           | MÉDIA | 
|RNF-015| Se apesar do alerta, o usuário prosseguir com a ação, o botão de finalização da atividade em percurso deve ser mantido desabilitado e ao tentar clicar, um modal com informação exata do erro deve ser lançado.                         | MÉDIA | 
|RNF-016| O sistema deve permitir utilização de atalhos no teclado como ctrlX, ctrlC, ctrlZ, ctrlV entre outros que possibilitem a otimização do uso ou a não utilização do mouse                          | MÉDIA | 
|RNF-017| O sistema deve se comunicar com o SQL Server.                                                  | MÉDIA | 
|RNF-018| A Seção do usuário deve expirar por inatividade após 30 minutos                              | MÉDIA | 
|RNF-019| A Seção do usuário deve expirar por ao fechar o browser                             | MÉDIA | 
|RNF-018| A Seção do usuário deve expirar se o usuário clicar em sair                              | MÉDIA | 
|RNF-019| O sistema deve ser escalável para integração com rotas do google.                              | MÉDIA | 


Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

> **Ajuda**:
- [Podemos encontrar a documentação do VLibras aqui](https://www.gov.br/governodigital/pt-br/vlibras/)


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


O diagrama contempla as principais ligações previstas entre casos de uso e atores e permite detalhar os Requisitos Funcionais identificados na etapa anterior.

O diagrama de caso de uso resume os detalhes dos usuários do seu sistema, também conhecidos como atores, e as interações deles com o sistema. 
Para o Diagrama de Casos de Uso, utilizamos a ferramenta [Lucidchart](https://www.lucidchart.com/)
<br/>

![img](img/casoDeUsoUML.jpeg)


## Diagrama de Classes

O diagrama de Classes é a representação da estrutura e relações das classes. <br/>
Para o Diagrama de Classes, utilizamos a ferramenta [Lucidchart](https://www.lucidchart.com/)
<br/>


![img](img/novoDiagramaDeClasses.jpeg)

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
