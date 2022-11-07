CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)

BEGIN
	RETURN @Preco - @Preco / 100 * @Porcentagem
END

SELECT
Nome, 
Preco,
dbo.CalcularDesconto(preco, 10) PrecoDesconto
FROM Produtos WHERE Tamanho = 'M'

