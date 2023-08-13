package com.manager.service.autenticador.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticador.service.AutenticadorService;

@RestController
@RequestMapping("/autenticador")
public class AutenticadorController {

	@Autowired
	AutenticadorService service;
	
	@PostMapping("/token")
	public ResponseEntity<String> gerarToken(@RequestBody UsuarioPostDto dto) {
		return service.gerarToken(dto);
	}
}
