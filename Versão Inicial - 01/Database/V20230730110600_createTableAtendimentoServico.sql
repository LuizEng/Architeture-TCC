CREATE TABLE `atendimento_servico` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fk_atendimento` int NOT NULL,
  `fk_servico` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_atendimento_servico_atendimento_idx` (`fk_atendimento`),
  KEY `fk_atendimento_servico_servico_idx` (`fk_servico`),
  CONSTRAINT `fk_atendimento_servico_atendimento` FOREIGN KEY (`fk_atendimento`) REFERENCES `atendimento` (`id`),
  CONSTRAINT `fk_atendimento_servico_servico` FOREIGN KEY (`fk_servico`) REFERENCES `servico` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci