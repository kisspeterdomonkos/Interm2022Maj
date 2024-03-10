-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

-- 9. feladat:
CREATE DATABASE vedettmadarak DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

-- 11. feladat:
UPDATE faj SET ertek = 25 WHERE id = 352;

-- 12. feladat:
SELECT nev, latin FROM faj WHERE evszam IS NULL ORDER BY nev ASC;

-- 13. feladat:
SELECT evszam, COUNT(id) AS 'fajok száma' FROM faj WHERE evszam >= 2000 GROUP BY evszam;

-- 14. feladat:
SELECT faj.nev AS 'faj', csalad.nev AS 'család', rend.nev AS 'rend', faj.ertek*1000 AS 'eszmei érték' FROM faj INNER JOIN csalad ON faj.csaladId = csalad.id INNER JOIN rend ON rend.id = csalad.rendId WHERE faj.ertek>500;

-- 15. feladat:
SELECT csalad.nev, AVG(faj.ertek) AS 'átlag' FROM faj INNER JOIN csalad ON faj.csaladId = csalad.id GROUP BY csalad.nev;