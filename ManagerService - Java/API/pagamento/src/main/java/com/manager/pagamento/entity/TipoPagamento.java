package com.manager.pagamento.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "enum_tipo_pagamento")
public class TipoPagamento {
	@Column(name ="id")
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;

	@Column(name ="nome_enum")
	private String nomeEnum;
	
	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNomeEnum() {
		return nomeEnum;
	}

	public void setNomeEnum(String nomeEnum) {
		this.nomeEnum = nomeEnum;
	}

	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	@Column(name ="descricao")
	private String descricao;
}
