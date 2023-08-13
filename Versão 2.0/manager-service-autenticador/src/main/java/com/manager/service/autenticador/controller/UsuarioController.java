package com.manager.service.autenticador.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticador.service.UsuarioService;

@RestController
@RequestMapping("/api/usuarios")
public class UsuarioController {

	@Autowired
	private UsuarioService service;
	
	@PostMapping("")
	public ResponseEntity<String> RealizarPagamento(@RequestBody UsuarioPostDto dto) {
		return service.inserirUsuario(dto);
	}		
}
