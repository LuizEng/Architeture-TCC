package com.manager.service.autenticador.controller;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.manager.service.autenticador.dto.UsuarioPostDto;

@RestController
@RequestMapping("/autenticador")
public class AutenticadorController {

	@PostMapping("/token")
	public ResponseEntity<String> RealizarPagamento(@RequestBody UsuarioPostDto dto) {
		return null;
	}
}
