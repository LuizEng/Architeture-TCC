package com.manager.pagamento.service;

import java.util.List;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.manager.pagamento.entity.TipoPagamento;
import com.manager.pagamento.repository.TipoPagamentoRepository;

@Service
public class TipoPagamentoService {

	private TipoPagamentoRepository tipoPagamentoRepository;

	@Autowired
	public TipoPagamentoService(TipoPagamentoRepository tipoPagamentoRepository) {
		this.tipoPagamentoRepository = tipoPagamentoRepository;
	}

	public List<String> GetTiposPagamentos() {
		List<TipoPagamento> listaTipoPagamento = tipoPagamentoRepository.findAll();

		List<String> retorno = listaTipoPagamento.stream().map(tipoPagamento -> tipoPagamento.getDescricao())
				.collect(Collectors.toList());
		return retorno;
	}

}
