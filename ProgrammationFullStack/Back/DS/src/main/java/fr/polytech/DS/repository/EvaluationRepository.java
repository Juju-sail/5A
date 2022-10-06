package fr.polytech.DS.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import fr.polytech.DS.entity.EvaluationEntity;

@Repository
public interface EvaluationRepository extends JpaRepository<EvaluationEntity, Integer> {
}
