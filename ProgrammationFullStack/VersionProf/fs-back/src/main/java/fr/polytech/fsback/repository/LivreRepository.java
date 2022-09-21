package fr.polytech.fsback.repository;

import fr.polytech.fsback.entity.LivreEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface LivreRepository extends JpaRepository<LivreEntity, Integer> {
}
