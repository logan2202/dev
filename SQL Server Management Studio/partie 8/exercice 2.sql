SELECT *
FROM frameworks
INNER JOIN languages ON frameworks.languagesId = languages.id;