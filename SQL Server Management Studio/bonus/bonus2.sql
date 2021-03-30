CREATE TABLE clients(
id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
  lastname nvarchar(50),
  firstname nvarchar(50),
  birthDate date,
  address nvarchar(50),
  firstPhoneNumber int,
  secondPhoneNumber int,
  mail nvarchar(50)
);