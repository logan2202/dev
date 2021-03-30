SELECT languages.name, COUNT(frameworks.languagesId) AS frameworks
FROM frameworks
LEFT JOIN languages ON frameworks.languagesId = languages.id
GROUP BY languages.name;