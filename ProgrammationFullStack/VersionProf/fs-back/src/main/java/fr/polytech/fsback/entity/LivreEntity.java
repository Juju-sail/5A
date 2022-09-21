package fr.polytech.fsback.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.List;

@Entity
@Table(name = "livre")
@Data
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class LivreEntity {

    @Id
    @GeneratedValue
    private int id;

    @Column(name = "titre")
    private String titre;

    @ManyToMany(mappedBy = "livres")
    private List<BibliothequeEntity> bibliotheques;

    @OneToMany(mappedBy = "livre")
    private List<CommentaireEntity> commentaires;

}
