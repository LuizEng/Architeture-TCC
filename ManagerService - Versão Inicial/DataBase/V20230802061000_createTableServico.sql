CREATE TABLE servico (
  id int NOT NULL AUTO_INCREMENT,
  descricao varchar(250) NOT NULL,
  valor decimal(6,2) NOT NULL,
  custoMedio decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci