package com.manager.pagamento.dto;

import java.math.BigDecimal;

public class PagamentoPostDto {
	private int agenda;
	
	private int tipoPagamento;
	
	private BigDecimal valor;

	public int getAgenda() {
		return agenda;
	}

	public void setAgenda(int agenda) {
		this.agenda = agenda;
	}

	public int getTipoPagamento() {
		return tipoPagamento;
	}

	public void setTipoPagamento(int tipoPagamento) {
		this.tipoPagamento = tipoPagamento;
	}

	public BigDecimal getValor() {
		return valor;
	}

	public void setValor(BigDecimal valor) {
		this.valor = valor;
	}
}
