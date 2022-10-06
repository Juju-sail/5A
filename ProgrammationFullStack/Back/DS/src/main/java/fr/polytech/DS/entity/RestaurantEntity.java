package fr.polytech.DS.entity;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.OneToMany;

import fr.polytech.DS.dto.EvaluationDto;
import fr.polytech.DS.dto.RestaurantDto;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
public class RestaurantEntity {
	@Id
	@GeneratedValue
	private int id;
	
	@Column(name = "nom")
	private String nom;
	
	@Column(name = "adresse")
	private String adresse;
	
	@OneToMany(mappedBy = "restaurant")
	private List<EvaluationEntity> evaluations;
	
	
}
