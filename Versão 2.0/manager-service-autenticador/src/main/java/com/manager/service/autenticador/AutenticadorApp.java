package com.manager.service.autenticador;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
@ComponentScan("com.manager.service.autenticador.*")
public class AutenticadorApp {
	public static void main(String[] args) {
		SpringApplication.run(AutenticadorApp.class, args);
	}
}
