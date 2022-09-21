package fr.polytech.DS.services;

import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.DS.entity.EvaluationEntity;
import fr.polytech.DS.entity.RestaurantEntity;
import fr.polytech.DS.repository.EvaluationRepository;
import lombok.RequiredArgsConstructor;

@Service
@RequiredArgsConstructor
public class EvaluationService {
	private final EvaluationRepository evaluationRepository;
	private final RestaurantService restaurantService;
	
	public EvaluationEntity addEvaluation(int restaurantId, String commentaireEvaluation) {
		final RestaurantEntity restaurant = restaurantService.getRestaurantById(restaurantId);
		final EvaluationEntity nouvelleEvaluation = EvaluationEntity.builder().commentaire(commentaireEvaluation).restaurant(restaurant).build();
		
		return this.evaluationRepository.save(nouvelleEvaluation);
	}
	
	public List<EvaluationEntity> getAllEvaluations(){
		return this.evaluationRepository.findAll();
	}
}
