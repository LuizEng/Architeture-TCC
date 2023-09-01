CREATE TABLE agenda_servico (
  id int NOT NULL AUTO_INCREMENT,
  fk_servico int NOT NULL,
  fk_agenda int NOT NULL,
  PRIMARY KEY (id),
  KEY fk_agenda_servico_agenda_idx (fk_agenda),
  KEY fk_agenda_servico_servico_idx (fk_servico),
  CONSTRAINT fk_agenda_servico_agenda FOREIGN KEY (fk_agenda) REFERENCES agenda (id),
  CONSTRAINT fk_agenda_servico_servico FOREIGN KEY (fk_servico) REFERENCES servico (id)
)