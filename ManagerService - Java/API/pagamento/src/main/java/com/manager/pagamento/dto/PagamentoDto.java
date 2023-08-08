package com.manager.pagamento.dto;

import java.math.BigDecimal;

public class PagamentoDto {

	private int id;

	private int agenda;

	private int tipoPagamento;

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
