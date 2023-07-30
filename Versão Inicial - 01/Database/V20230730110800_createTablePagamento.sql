CREATE TABLE `pagamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `valor` decimal(16,8) NOT NULL,
  `descricao` varchar(45) DEFAULT NULL,
  `tipo_pagamento` int NOT NULL,
  `caixa` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tipo_pagamento_idx` (`tipo_pagamento`),
  KEY `fk_pagamento_caixa_idx` (`caixa`),
  CONSTRAINT `fk_pagamento_caixa` FOREIGN KEY (`caixa`) REFERENCES `caixa` (`id`),
  CONSTRAINT `fk_tipo_pagamento` FOREIGN KEY (`tipo_pagamento`) REFERENCES `tipo_pagamento` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci