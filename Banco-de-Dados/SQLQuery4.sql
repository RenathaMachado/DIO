--SELECT * FROM Produtos

--SELECT COUNT(*) QuantidadeProdutos FROM Produtos

--SELECT COUNT(*) QuantidadeTamanho FROM Produtos 
--WHERE Tamanho = 'p'

--SELECT SUM(Preco) PrecoTotal FROM Produtos
--SELECT SUM(Preco) PrecoTamM FROM Produtos 
--WHERE Tamanho = 'M'

--SELECT
--Nome + ', Cor:' + Cor + '-'+ Preco NomeProdutos 
--FROM Produtos 

SELECT * FROM Produtos

UPDATE Produtos SET DataCadastro = GETDATE()

SELECT 
FORMAT (DataCadastro, 'dd/MM/yyyy HH:mm')
FROM Produtos

SELECT
Tamanho,
COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Tamanho









