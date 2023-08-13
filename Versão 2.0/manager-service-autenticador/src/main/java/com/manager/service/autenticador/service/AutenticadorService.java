package com.manager.service.autenticador.service;

import java.util.Date;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticador.repository.UsuarioRepository;
import com.manager.service.autenticator.entity.Usuario;

import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;


@Service
public class AutenticadorService {

	private final UsuarioRepository repository;
	
	@Autowired
	public AutenticadorService(UsuarioRepository repository) {
		this.repository = repository;	
	}
	
	public ResponseEntity<String> gerarToken(UsuarioPostDto dto) {
		Usuario usuario = repository.findByNome(dto.getNome());
		if (usuario == null) {			
			return ResponseEntity.notFound().build();
		}
		return ResponseEntity.status(HttpStatus.CREATED).body(genenateToken(usuario));		
	}
	
	private String genenateToken(Usuario usuario) {							
        return Jwts.builder()
                .setSubject(usuario.getNome())
                .setSubject(usuario.getSenha())
                .setExpiration(new Date(System.currentTimeMillis() + 300000))
                .signWith(SignatureAlgorithm.HS512, "manager-service")
                .compact(); 
		
	}
}
