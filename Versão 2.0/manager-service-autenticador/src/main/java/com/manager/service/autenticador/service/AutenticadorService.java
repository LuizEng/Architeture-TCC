package com.manager.service.autenticador.service;

import java.util.Date;

import org.mindrot.jbcrypt.BCrypt;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticador.entity.Usuario;
import com.manager.service.autenticador.repository.UsuarioRepository;

import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;

@Service
public class AutenticadorService {

	private static final String SECRET_KEY = "XrtQm3gC9qgnxcwOib/24Ml9iC5YTg0lL//CSQK2iMSxsHWs7yedxO3/dkxuoOrqwDB6x5unOlaLvDrj3dkaUA==";
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
		
		if (!BCrypt.checkpw(dto.getSenha(), usuario.getSenha())) {
			return ResponseEntity.badRequest().body("Senha incorreta!");
		}
		
		return ResponseEntity.status(HttpStatus.CREATED).body(genenateToken(usuario));
	}

	private String genenateToken(Usuario usuario) {				
		return Jwts.builder().setSubject(usuario.getNome())
				.setExpiration(new Date(System.currentTimeMillis() + 300000))
				.signWith(SignatureAlgorithm.HS512, SECRET_KEY).compact();
	}
}
