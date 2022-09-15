package fr.polytech.fsback.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import fr.polytech.fsback.entity.LivreEntity;

@Repository
public class LivreRepository implements JpaRepository<LivreEntity, Integer>{
	
}
