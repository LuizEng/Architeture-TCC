CREATE TABLE usuario (
  id int NOT NULL AUTO_INCREMENT,
  nome varchar(32) NOT NULL,
  token varchar(64) NOT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

insert into usuario (nome, token) VALUES ("admin", "admin");