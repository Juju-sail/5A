package fr.polytech.fsback.entity;

import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.Table;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.EqualsAndHashCode;
import lombok.NoArgsConstructor;

@Entity
@Table
@Data
@NoArgsConstructor
@AllArgsConstructor
@EqualsAndHashCode
public class BibliothequeEntity {
	@Id
	@GeneratedValue
	int id;
	
	@Column(name="nom")
	String nom;
	
	@ManyToMany
	@JoinTable(
		name = "join_bibli_livre",
		joinColumns = @JoinColumn(name="id_biblio"),
		inverseJoinColumns = @JoinColumn(name = "id_livre")
	)
	List<LivreEntity> livres;	
}
