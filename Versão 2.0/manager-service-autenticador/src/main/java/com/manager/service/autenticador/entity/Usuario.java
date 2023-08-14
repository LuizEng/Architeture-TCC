package com.manager.service.autenticador.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

import org.mindrot.jbcrypt.BCrypt;
import org.springframework.lang.NonNull;

@Entity
@Table(name = "aut_usuario")
public class Usuario {
	@Column(name ="id")
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int id;
	
	@Column(name ="nome")
	@NonNull
	private String nome;
	
	@Column(name ="senha")
	@NonNull
	private String senha;	
		
	public int getId() {
		return id;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getSenha() {
		return senha;
	}

	public void setSenha(String senha) {
		String salt = BCrypt.gensalt();
		this.senha =  BCrypt.hashpw(senha, salt);
	}
}
