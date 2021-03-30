SELECT poiuy_Appointments.dated, poiuy_timeslot.timeslot, poiuy_patients.lastname,  poiuy_patients.firstname, poiuy_doctors.lastname, poiuy_doctors.firstname, poiuy_specialities.name
FROM poiuy_Appointments
INNER JOIN poiuy_timeslot 
ON poiuy_Appointments.id_poiuy_timeslot =  poiuy_timeslot.id
INNER JOIN poiuy_patients
ON poiuy_Appointments.id_poiuy_patients = poiuy_patients.id
INNER JOIN poiuy_doctors
ON poiuy_Appointments.id_poiuy_doctors = poiuy_doctors.id
INNER JOIN poiuy_specialities
ON poiuy_doctors.id_poiuy_specialities = poiuy_specialities.id
WHERE poiuy_specialities.id = 4
ORDER BY poiuy_Appointments.dated
