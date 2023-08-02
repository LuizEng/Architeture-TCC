CREATE TABLE pagamento (
  id int NOT NULL AUTO_INCREMENT,
  fk_agenda int NOT NULL,
  tipo_pagamento int NOT NULL,
  valor decimal(6,2) NOT NULL,
  PRIMARY KEY (id),
  KEY fk_pagamento_agenda_idx (fk_agenda),
  CONSTRAINT fk_pagamento_agenda FOREIGN KEY (fk_agenda) REFERENCES agenda (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci