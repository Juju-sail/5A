package fr.polytech.fsback.repository;

import fr.polytech.fsback.entity.CommentaireEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface CommentaireRepository extends JpaRepository<CommentaireEntity, Integer> {
}
