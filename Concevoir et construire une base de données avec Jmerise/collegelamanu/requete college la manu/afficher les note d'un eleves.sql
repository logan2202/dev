SELECT wxcvb_students.firstname, wxcvb_students.lastname, wxcvb_note.note
FROM wxcvb_note
INNER JOIN wxcvb_students 
ON wxcvb_note.id_wxcvb_students = wxcvb_students.id
INNER JOIN wxcvb_subjects
ON wxcvb_note.id_wxcvb_subjects = wxcvb_subjects.id
WHERE wxcvb_students.firstname = 'abbot';
