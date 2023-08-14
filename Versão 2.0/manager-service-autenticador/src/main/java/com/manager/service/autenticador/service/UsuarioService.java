package com.manager.service.autenticador.service;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DuplicateKeyException;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import com.manager.service.autenticador.converter.UsuarioConverter;
import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticador.entity.Usuario;
import com.manager.service.autenticador.repository.UsuarioRepository;

@Service
public class UsuarioService {

	private final UsuarioConverter converter;

	private final UsuarioRepository repository;

	@Autowired
	public UsuarioService(UsuarioConverter converter, UsuarioRepository repository) {
		this.converter = converter;
		this.repository = repository;

	}

	public ResponseEntity<String> inserirUsuario(UsuarioPostDto dto) {
		Usuario usuario = repository.findByNome(dto.getNome());
		if (usuario != null) {
			throw new DuplicateKeyException("Usuário já cadastrado");
		}
			
		usuario = converter.mapDtoToEnt(dto);
		try {
			repository.save(usuario);			
			// Envio para o Rabbit
			// dto.getSenha() para manter a retrocompatibilidade
			return ResponseEntity.status(HttpStatus.CREATED).body("Usuario criado com sucesso.");
		} catch (Exception e) {
			return ResponseEntity.badRequest().body(e.getMessage());
		}
	}

}
