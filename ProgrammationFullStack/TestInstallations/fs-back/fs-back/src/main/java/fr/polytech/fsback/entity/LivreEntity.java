package fr.polytech.fsback.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;

@Entity
@Table(name="livres")
@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
@EqualsAndHashCode
public class LivreEntity {
	@Id
	@GeneratedValue
	int id;
	
	@Column(name = "titre", columnDefinition = "varchar(10)")
	String titre;
	
	
	/*@ManyToMany
	List<BibliothequeEntity> bibliotheques;*/
}
