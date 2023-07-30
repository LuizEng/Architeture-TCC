CREATE TABLE `caixa` (
  `id` int NOT NULL AUTO_INCREMENT,
  `atendimento` int NOT NULL,
  `usuario` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_caixa_atendimento_idx` (`atendimento`),
  KEY `fk_caixa_usuario_idx` (`usuario`),
  CONSTRAINT `fk_caixa_atendimento` FOREIGN KEY (`atendimento`) REFERENCES `atendimento` (`id`),
  CONSTRAINT `fk_caixa_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci