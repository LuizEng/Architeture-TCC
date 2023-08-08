CREATE TABLE enum_tipo_pagamento (
  id int NOT NULL AUTO_INCREMENT,
  nome_enum varchar(25) NOT NULL,
  descricao varchar(25) NOT NULL,  
  PRIMARY KEY (id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_DINHEIRO", "Dinheiro");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_PIX", "Pix");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_CARTAO_CREDITO", "Cartao de Credito");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_CARTAO_DEBITO", "Cartao de Debito");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_PICPAY", "PicPay");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_PAYPAL", "PayPal");
INSERT INTO enum_tipo_pagamento (nome_enum,descricao) VALUES ("TP_A_PRAZO", "A Prazo");




