package com.manager.pagamento.entity;

import java.math.BigDecimal;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "pagamento")
public class Pagamento {
	@Column(name ="id")
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;

	@Column(name ="fk_agenda")
	private int agenda;

	@Column(name ="tipo_pagamento")
	private int tipoPagamento;
	
	@Column(name ="valor")
	private BigDecimal valor;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getAgenda() {
		return agenda;
	}

	public void setAgenda(int agenda) {
		this.agenda = agenda;
	}

	public BigDecimal getValor() {
		return valor;
	}

	public void setValor(BigDecimal valor) {
		this.valor = valor;
	}

	public int getTipoPagamento() {
		return tipoPagamento;
	}

	public void setTipoPagamento(int tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}
}
