
-- create
CREATE TABLE employee (
  empId INTEGER PRIMARY KEY,
  name TEXT NOT NULL,
  age TEXT NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO employee VALUES (1, 'Иван', '18', 'Москва');
INSERT INTO employee VALUES (2, 'Сергей', '24', 'Москва');
INSERT INTO employee VALUES (3, 'Маша', '20', 'Нижний Новгород');
INSERT INTO employee VALUES (4, 'Лена', '29', 'Москва');
INSERT INTO employee VALUES (5, 'Ринат', '30', 'Санкт Петербург');
INSERT INTO employee VALUES (6, 'Марат', '45', 'Ува');
INSERT INTO employee VALUES (7, 'Ильдар', '60', 'Казань');
INSERT INTO employee VALUES (8, 'Владимир', '35', 'Москва');

-- fetch 
SELECT name FROM employee WHERE age BETWEEN 19 AND 30 AND address = 'Москва';
