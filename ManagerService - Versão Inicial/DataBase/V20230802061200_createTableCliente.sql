CREATE TABLE cliente (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(120) NOT NULL,
  telefone varchar(11) DEFAULT NULL,
  email varchar(80) DEFAULT NULL,
  fk_usuario int,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci