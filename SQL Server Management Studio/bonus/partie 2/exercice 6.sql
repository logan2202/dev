SELECT villes.dep, COUNT(villes.ville) AS ville
FROM villes
GROUP BY villes.dep;