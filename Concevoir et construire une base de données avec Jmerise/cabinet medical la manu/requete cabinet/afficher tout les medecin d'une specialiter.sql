SELECT poiuy_doctors.firstname, poiuy_doctors.lastname, poiuy_specialities.name
FROM poiuy_doctors
INNER JOIN poiuy_specialities
ON poiuy_doctors.id_poiuy_specialities = poiuy_specialities.id
WHERE poiuy_specialities.id = 3