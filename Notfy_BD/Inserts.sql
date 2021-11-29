INSERT INTO Notificador (Nome,Celular,CPF,Email) VALUES ('Junio Grigório','17981133914','99999999999','junio@gmail.com')
INSERT INTO Notificador (Nome,Celular,CPF,Email) VALUES ('Luiza Jamarino','17999999999','88888888888','luiza@gmail.com')
INSERT INTO Notificador (Nome,Celular,CPF,Email) VALUES ('Bruce Dickinson','1776767676','77777777777','bruce@gmail.com')

Select * from Notificador

INSERT INTO Notificando (Nome,Celular,CPF,Email) VALUES ('Tirana','17121212121','33333333333','tirana@gmail.com')
INSERT INTO Notificando (Nome,Celular,CPF,Email) VALUES ('ZéBedeu','1713113131','44444444444','zebedeu@gmail.com')
INSERT INTO Notificando (Nome,Celular,CPF,Email) VALUES ('João','1713131313','55555555555','joao@gmail.com')

Select * from Notificando Where ID = 3

INSERT INTO Endereco (Logradouro,Numero,Complemento,Bairro,Cep,Cidade,Estado,NotificandoID) VALUES ('Rua A','191','','Solo Sagrado','15075060','Rio Preto','SP',1)
INSERT INTO Endereco (Logradouro,Numero,Complemento,Bairro,Cep,Cidade,Estado,NotificandoID) VALUES ('Rua B','181','','Jardim Nazareth','15075070','Rio Preto','SP',1)
INSERT INTO Endereco (Logradouro,Numero,Complemento,Bairro,Cep,Cidade,Estado,NotificandoID) VALUES ('Rua C','171','','Centro','15080650','Rio Preto','SP',2)
INSERT INTO Endereco (Logradouro,Numero,Complemento,Bairro,Cep,Cidade,Estado,NotificandoID) VALUES ('Rua D','151','','Floresta','31054080','Belo Horizonte','MG',3)

Select * from Endereco Where ID = 1

INSERT INTO Notificacao(MatriculaImovel,Data_1_Tentativa,Data_2_Tentativa,Data_3_Tentativa,StatusNotificacao,Sequencia,NotificadorID,NotificandoID) VALUES (125,'','','',0,'',1,2)
INSERT INTO Notificacao(MatriculaImovel,Data_1_Tentativa,Data_2_Tentativa,Data_3_Tentativa,StatusNotificacao,Sequencia,NotificadorID,NotificandoID) VALUES (954,'','','',0,'',2,3)
INSERT INTO Notificacao(MatriculaImovel,Data_1_Tentativa,Data_2_Tentativa,Data_3_Tentativa,StatusNotificacao,Sequencia,NotificadorID,NotificandoID) VALUES (888,'','','',0,'',1,3)

Select * from Notificacao

SELECT e.Bairro FROM Endereco e 
JOIN Notificando nd ON nd.ID = e.NotificandoID
JOIN Notificacao ao ON ao.NotificandoID = nd.ID
JOIN Notificador r ON r.ID = ao.NotificadorID
WHERE ao.MatriculaImovel = 125







