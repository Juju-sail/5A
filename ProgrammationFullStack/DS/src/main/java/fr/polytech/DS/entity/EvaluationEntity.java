package fr.polytech.DS.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
@Table(name = "Evaluation")
public class EvaluationEntity {
	
	@Id
	@GeneratedValue
	private int id;
	
	@Column(name = "commentaire")
	private String commentaire;
	
	@ManyToOne
	@JoinColumn(name = "restaurant_id", referencedColumnName = "id")
	private RestaurantEntity restaurant;
	
}
