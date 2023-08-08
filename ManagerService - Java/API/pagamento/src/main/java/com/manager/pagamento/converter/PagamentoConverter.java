package com.manager.pagamento.converter;

import org.springframework.stereotype.Component;

import com.manager.pagamento.dto.PagamentoDto;
import com.manager.pagamento.dto.PagamentoPostDto;
import com.manager.pagamento.entity.Pagamento;

@Component
public class PagamentoConverter {

	public PagamentoDto mapToDto(Pagamento ent) {
		PagamentoDto dto = new PagamentoDto();
		dto.setId(ent.getId());
		dto.setAgenda(ent.getAgenda());
		dto.setTipoPagamento(ent.getTipoPagamento());
		dto.setValor(ent.getValor());
			
		return dto;			
	}
	
	public Pagamento mapToEnt(PagamentoDto dto) {
		Pagamento ent = new Pagamento();
		ent.setId(dto.getId());
		ent.setAgenda(dto.getAgenda());
		ent.setTipoPagamento(dto.getTipoPagamento());
		ent.setValor(dto.getValor());		
		
		return ent;
	}
	
	public Pagamento mapToEntPost(PagamentoPostDto dto) {
		Pagamento ent = new Pagamento();		
		ent.setAgenda(dto.getAgenda());
		ent.setTipoPagamento(dto.getTipoPagamento());
		ent.setValor(dto.getValor());		
		
		return ent;		
	}
}
