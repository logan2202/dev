SELECT wxcvb_students.firstname, wxcvb_students.lastname, AVG(wxcvb_note.note)
FROM wxcvb_note
INNER JOIN wxcvb_students 
ON wxcvb_note.id_wxcvb_students = wxcvb_students.id
GROUP BY wxcvb_students.firstname, wxcvb_students.lastname
HAVING wxcvb_students.firstname = 'abbot'
