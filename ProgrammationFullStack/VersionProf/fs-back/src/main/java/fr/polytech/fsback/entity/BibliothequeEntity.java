package fr.polytech.fsback.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.List;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
@Table(name = "Bibliotheque")
public class BibliothequeEntity {

    @Id
    @GeneratedValue
    private int id;

    @Column(name = "nom")
    private String nom;

    @ManyToMany
    @JoinTable(
            name = "biblio_jn_livre",
            joinColumns = @JoinColumn(name = "id_livre"),
            inverseJoinColumns = @JoinColumn(name = "id_biblio"))
    private List<LivreEntity> livres;

}
