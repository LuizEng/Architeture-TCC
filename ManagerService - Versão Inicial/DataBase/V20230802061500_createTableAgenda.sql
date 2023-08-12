CREATE TABLE agenda (
  id int NOT NULL AUTO_INCREMENT,
  fk_cliente int NOT NULL,
  data date NOT NULL,
  hora decimal(3,1) NOT NULL,
  fk_usuario int,
  PRIMARY KEY (id),
  KEY fk_agenda_cliente_idx (fk_cliente),
  CONSTRAINT fk_agenda_cliente FOREIGN KEY (fk_cliente) REFERENCES cliente (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci