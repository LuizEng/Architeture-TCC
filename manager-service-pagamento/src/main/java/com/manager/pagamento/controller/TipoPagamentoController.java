package com.manager.pagamento.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.manager.pagamento.service.TipoPagamentoService;

@RestController
@RequestMapping("/api/tipos-pagamentos")
public class TipoPagamentoController {

	@Autowired
	private TipoPagamentoService tipoPagamentoService;

	@GetMapping("")
	public ResponseEntity<List<String> > getTiposPagamentos(){
		return ResponseEntity.ok(tipoPagamentoService.GetTiposPagamentos());		
	}
}
