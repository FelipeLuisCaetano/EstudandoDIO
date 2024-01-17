--1
--select 
--	Nome,
--	Ano
-- from Filmes

--2--
--SELECT nome, ano
--FROM filmes
--ORDER BY ano ASC;

----3
--SELECT nome, ano, duracao
--FROM filmes
--WHERE nome = 'De Volta Para o Futuro';

----4

--SELECT nome, ano
--FROM filmes
--WHERE ano = 1997;

--5
--SELECT nome, ano
--FROM filmes
--WHERE ano > 2000;

--6
--SELECT * FROM Filmes
--WHERE Duracao > 100 AND Duracao < 150
--ORDER BY Duracao ASC;

--7
--SELECT Ano, COUNT(*) as Quantidade
--FROM Filmes
--GROUP BY Ano
--ORDER BY Quantidade DESC;

----8
--SELECT PrimeiroNome, UltimoNome
--FROM Atores
--WHERE Genero = 'M';

--9
--SELECT PrimeiroNome, UltimoNome
--FROM Atores
--WHERE Genero = 'F'
--ORDER BY PrimeiroNome

--10

--SELECT f.Nome, G.Genero 
--FROM FilmesGenero fg
--INNER JOIN Filmes f ON f.Id = fg.IdFilme
--INNER JOIN Generos G ON G.Id = fg.IdGenero

--11
--SELECT f.Nome, g.Genero
--FROM Filmes f
--LEFT JOIN FilmesGenero fg ON fg.IdFilme = f.Id
--LEFT JOIN Generos g ON g.Id = fg.IdGenero
--where g.Genero = 'Mistério'

--12
--SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel
--FROM Filmes f
--inner JOIN ElencoFilme ef ON ef.IdFilme = f.Id
--LEFT JOIN Atores a ON a.Id = ef.IdAtor


