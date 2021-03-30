SELECT *
FROM frameworks
FULL JOIN languages ON frameworks.languagesId = languages.id;