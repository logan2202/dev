SELECT wxcvb_students.firstname, wxcvb_teacher.firstname
FROM wxcvb_teacherperclass
INNER JOIN wxcvb_teacher
ON wxcvb_teacherperclass.id_wxcvb_teacher = wxcvb_teacher.id
INNER JOIN wxcvb_class
ON wxcvb_teacherperclass.id_wxcvb_class = wxcvb_class.id
INNER JOIN wxcvb_students 
ON wxcvb_students.id_wxcvb_class = wxcvb_class.id
WHERE wxcvb_teacher.firstname = 'McKenzie'
