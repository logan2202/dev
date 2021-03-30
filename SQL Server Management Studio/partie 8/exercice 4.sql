SELECT *
FROM languages
INNER JOIN frameworks ON languages.id = frameworks.languagesId
WHERE languages.name in ('PHP', 'JavaScript', 'CSS');