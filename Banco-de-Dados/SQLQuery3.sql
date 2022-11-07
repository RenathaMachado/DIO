CREATE TABLE Endereco(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL, 
	Rua varchar(255) NULL,
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Endereco_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)
)

SELECT * FROM Endereco
INSERT INTO Endereco VALUES(
4, 'Rua Campo Maior', 'Campo Grande', 'Rio de janeiro', 'SP'
)


UPDATE Endereco
SET Estado = 'RJ'
WHERE IdCliente = 4

SELECT * FROM CLientes
INNER JOIN Endereco ON Clientes.Id = Endereco.IdCliente
WHERE Clientes.Id = 4

SELECT * FROM Produtos

ALTER TABLE Produtos
ADD DEFAULT GETDATE() FOR DataCadastro



