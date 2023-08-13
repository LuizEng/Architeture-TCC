package com.manager.service.autenticador.converter;

import org.springframework.stereotype.Component;

import com.manager.service.autenticador.dto.UsuarioGetDto;
import com.manager.service.autenticador.dto.UsuarioGetInternalDto;
import com.manager.service.autenticador.dto.UsuarioPostDto;
import com.manager.service.autenticator.entity.Usuario;

@Component
public class UsuarioConverter {

	public UsuarioGetDto mapEntToGetDto(Usuario ent) {
		UsuarioGetDto dto = new UsuarioGetDto();
		dto.setNome(ent.getNome());
		return dto;
	}
	
	public UsuarioGetInternalDto mapEntToGetInternalDto(Usuario ent) {
		UsuarioGetInternalDto dto = new UsuarioGetInternalDto();
		dto.setNome(ent.getNome());
		dto.setSenha(ent.getSenha());
		dto.setKey(ent.getKey());
		return dto;
	}
	
	public Usuario mapDtoToEnt(UsuarioPostDto dto) {
		Usuario ent = new Usuario();
		ent.setNome(dto.getNome());
		ent.setSenha(dto.getSenha());		
		return ent;
	}
}
