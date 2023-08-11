package com.manager.pagamento.controller;

import java.math.BigDecimal;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.manager.pagamento.dto.PagamentoPostDto;
import com.manager.pagamento.service.PagamentoService;

@RestController
@RequestMapping("/api/pagamentos")
public class PagamentoController {

	@Autowired 
	private PagamentoService service;
	
	@PostMapping("")
	public ResponseEntity<?> RealizarPagamento(@RequestBody PagamentoPostDto dto) {
		return ResponseEntity.ok(service.salvarPagamento(dto));
	}	
	
	@GetMapping("/totais")
	public ResponseEntity<BigDecimal> GetValorPago(@RequestParam("agenda") int agenda){
		return ResponseEntity.ok(service.GetTotalPago(agenda));		
	}
	
}
