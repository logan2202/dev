SELECT wxcvb_class.level, wxcvb_class.name, wxcvb_class.id, AVG(wxcvb_note.note)
FROM wxcvb_class, wxcvb_note
INNER JOIN wxcvb_subjects
ON wxcvb_note.id_wxcvb_subjects = wxcvb_subjects.id
GROUP BY wxcvb_class.level, wxcvb_class.name, wxcvb_class.id
HAVING wxcvb_class.id = 1