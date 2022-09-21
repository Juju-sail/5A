package fr.polytech.DS.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.DS.entity.EvaluationEntity;
import fr.polytech.DS.entity.RestaurantEntity;
import fr.polytech.DS.exeption.RessourceDoesntExist;
import fr.polytech.DS.repository.RestaurantRepository;
import lombok.RequiredArgsConstructor;

@Service
@RequiredArgsConstructor
public class RestaurantService {
	
	private final RestaurantRepository restaurantRepository;
	
	public RestaurantEntity getRestaurantById(int id) {
		return this.restaurantRepository.findById(id).orElseThrow(() -> new RessourceDoesntExist("restaurant n°" + id + " n'exite pas"));
	}
	
	public List<RestaurantEntity> getAllRestaurants(){
		return this.restaurantRepository.findAll();
	}
	
	public RestaurantEntity addRestaurant(final String nom, final String adresse) {
		EvaluationEntity comm = EvaluationEntity.builder().build();
		List<EvaluationEntity> nouvelleEval = new ArrayList<EvaluationEntity>();
		nouvelleEval.add(comm);
		final RestaurantEntity nouveauRestaurant = RestaurantEntity.builder().nom(nom).adresse(adresse).evaluations(nouvelleEval).build();
		return this.restaurantRepository.save(nouveauRestaurant);
	}
}
