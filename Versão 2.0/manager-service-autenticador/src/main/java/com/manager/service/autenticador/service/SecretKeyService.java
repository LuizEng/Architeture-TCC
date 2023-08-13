package com.manager.service.autenticador.service;

import org.springframework.stereotype.Service;

@Service
public class SecretKeyService {

	public String GenerateSecretKey(String usuario, String senha) {
        StringBuilder resultado = new StringBuilder();

        int usuarioIndex = usuario.length() - 1;
        int senhaIndex = 0;

        while (usuarioIndex >= 0 && senhaIndex < senha.length()) {
            resultado.append(usuario.charAt(usuarioIndex));
            resultado.append(senha.charAt(senhaIndex));
            usuarioIndex--;
            senhaIndex++;
        }
        // 
        while (usuarioIndex >= 0) {
            resultado.append(usuario.charAt(usuarioIndex));
            usuarioIndex--;
        }

        while (senhaIndex < senha.length()) {
            resultado.append(senha.charAt(senhaIndex));
            senhaIndex++;
        }
        
        return resultado.toString();
	}
}
