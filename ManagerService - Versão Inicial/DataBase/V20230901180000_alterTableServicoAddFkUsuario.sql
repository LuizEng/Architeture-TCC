ALTER TABLE `managerservice`.`servico` 
ADD INDEX `fk_servico_usuario_idx` (`fk_usuario` ASC) VISIBLE;
ALTER TABLE `managerservice`.`servico` 
ADD CONSTRAINT `fk_servico_usuario`
  FOREIGN KEY (`fk_usuario`)
  REFERENCES `managerservice`.`usuario` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;