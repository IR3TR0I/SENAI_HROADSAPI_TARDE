USE SENAI_HROADSAPI_TARDE;


SELECT * FROM Personagem;


SELECT * FROM Classe;

SELECT NomeClasse From Classe;

SELECT * FROM Habilidade;

SELECT COUNT(idHabilidade) AS Numero_de_Habilidades_Cadastradas FROM Habilidade;

SELECT idHabilidade FROM Habilidade
ORDER BY idHabilidade ASC;

SELECT * FROM TipoHabilidade;

SELECT Habilidade.NomeHabilidade, TipoHabilidade.TipoHabilidade FROM Habilidade
INNER JOIN TipoHabilidade
ON Habilidade.idTipoHabilidade = TipoHabilidade.idTipoHabilidade;

SELECT Personagem.NomePersonagem, Classe.NomeClasse FROM Personagem
INNER JOIN Classe
ON Personagem.idClasse = Classe.idClasse;

SELECT Personagem.NomePersonagem, Classe.NomeClasse FROM Personagem
RIGHT JOIN Classe
ON Classe.idClasse = Personagem.idClasse
ORDER BY Personagem.NomePersonagem DESC;

SELECT Classe.NomeClasse, Habilidade.NomeHabilidade FROM Classe
LEFT JOIN HabilidadesClasse
ON Classe.idClasse = HabilidadesClasse.idClasse
LEFT JOIN Habilidade
ON HabilidadesClasse.idHabilidade = Habilidade.idHabilidade;

SELECT Habilidade.NomeHabilidade, Classe.NomeClasse FROM Habilidade
LEFT JOIN HabilidadesClasse
ON Habilidade.idHabilidade = HabilidadesClasse.idHabilidade
LEFT JOIN Classe
ON HabilidadesClasse.idClasse = Classe.idClasse;

SELECT Habilidade.NomeHabilidade, Classe.NomeClasse FROM Habilidade
RIGHT JOIN HabilidadesClasse
ON Habilidade.idHabilidade = HabilidadesClasse.idHabilidade
RIGHT JOIN Classe
ON HabilidadesClasse.idClasse = Classe.idClasse
ORDER BY NomeHabilidade DESC;