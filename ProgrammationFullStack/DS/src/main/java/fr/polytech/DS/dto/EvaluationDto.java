package fr.polytech.DS.dto;

import javax.validation.constraints.Size;

import com.fasterxml.jackson.annotation.JsonProperty;

import fr.polytech.DS.entity.EvaluationEntity;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@Builder
@AllArgsConstructor
public class EvaluationDto {
	
	@JsonProperty("id")
	private int id;
	
	@JsonProperty("nomEvaluateur")
	@Size(max=50)
	private String nomEvaluateur;
	
	@JsonProperty("commentaire")
	@Size(max=255)
	private String commentaire;
	
	@JsonProperty("note")
	//@Size(max=3)
	private int note; // pas de maxi à 3...
	
	public static EvaluationDto fromEntity(EvaluationEntity entity) {
		return EvaluationDto.builder().id(entity.getId()).commentaire(entity.getCommentaire()).build();
	}
}
