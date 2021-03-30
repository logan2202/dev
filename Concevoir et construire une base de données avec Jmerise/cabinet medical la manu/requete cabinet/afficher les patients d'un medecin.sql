SELECT poiuy_doctors.firstname, poiuy_doctors.lastname, poiuy_patients.lastname, poiuy_patients.firstname
FROM poiuy_patients
INNER JOIN poiuy_doctors
ON poiuy_patients.id_poiuy_doctors = poiuy_doctors.id
WHERE poiuy_doctors.id = 1