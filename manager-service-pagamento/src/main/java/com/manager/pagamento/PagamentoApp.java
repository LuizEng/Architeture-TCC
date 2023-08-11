package com.manager.pagamento;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
@ComponentScan("com.manager.pagamento.*")
public class PagamentoApp {
    public static void main(String[] args) {
    	SpringApplication.run(PagamentoApp.class, args);
    }
}
