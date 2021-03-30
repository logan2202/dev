SELECT villes.dep, villes.region, COUNT(villes.ville) AS ville
FROM villes
GROUP BY villes.dep, villes.region;