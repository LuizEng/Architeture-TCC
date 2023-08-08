package com.manager.pagamento.service;

import java.math.BigDecimal;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.manager.pagamento.converter.PagamentoConverter;
import com.manager.pagamento.dto.PagamentoPostDto;
import com.manager.pagamento.entity.Pagamento;
import com.manager.pagamento.repository.PagamentoRepository;

@Service
public class PagamentoService {

	private final PagamentoRepository repository;

	private final PagamentoConverter converter;

	@Autowired
	public PagamentoService(PagamentoRepository repository, PagamentoConverter converter) {
		this.repository = repository;
		this.converter = converter;
	}

	public Pagamento salvarPagamento(PagamentoPostDto dto) {
		return repository.save(converter.mapToEntPost(dto));
	}

	public BigDecimal GetTotalPago(int idAgenda) {		
		return repository.sumValorByAgendaId(idAgenda);
	}
}
