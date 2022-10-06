package fr.polytech.DS.dto;

import java.util.List;

import javax.validation.constraints.Size;

import com.fasterxml.jackson.annotation.JsonProperty;

import fr.polytech.DS.entity.RestaurantEntity;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;


@Data
@NoArgsConstructor
@Builder
@AllArgsConstructor
public class RestaurantDto {
	
	@JsonProperty("id")
	private int id;
	
	@JsonProperty("nom")
	@Size(max=90)
	private String nom;
	
	@JsonProperty("adresse")
	@Size(max=255)
	private String adresse;
	
	@JsonProperty("evaluations")
	private List<EvaluationDto> evaluations;
	
	public static RestaurantDto fromEntity(RestaurantEntity restaurantEntity) {
		return RestaurantDto.builder()
				.id(restaurantEntity.getId())
				.nom(restaurantEntity.getNom())
				.adresse(restaurantEntity.getAdresse())
				.evaluations(restaurantEntity.getEvaluations().stream().map(evaluation -> EvaluationDto.fromEntity(evaluation)).toList())
				.build();
	}
}
