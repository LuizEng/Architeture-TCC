package com.manager.pagamento.repository;

import java.math.BigDecimal;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.manager.pagamento.entity.Pagamento;

@Repository
public interface PagamentoRepository extends JpaRepository<Pagamento, Long>{
	@Query("SELECT SUM(p.valor) FROM Pagamento p WHERE p.agenda = :agendaId")
	BigDecimal sumValorByAgendaId(@Param("agendaId")int agendaId);
}
