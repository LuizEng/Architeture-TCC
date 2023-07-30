CREATE TABLE `atendimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tipo_atendimento` int NOT NULL,
  `observacao` varchar(64) DEFAULT NULL,
  `data_abertura` date NOT NULL,
  `usuario` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tipo_atendimento_idx` (`tipo_atendimento`),
  KEY `fk_usuario_idx` (`usuario`),
  CONSTRAINT `fk_tipo_atendimento` FOREIGN KEY (`tipo_atendimento`) REFERENCES `tipo_atendimento` (`id`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci