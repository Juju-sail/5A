package fr.polytech.fsback.entity;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity
@Builder
@Data
@NoArgsConstructor
@AllArgsConstructor
@Table(name = "Commentaire")
public class CommentaireEntity {

    @Id
    @GeneratedValue
    private int id;

    @Column(name = "message")
    private String message;

    @ManyToOne
    @JoinColumn(name = "livre_id", referencedColumnName = "id")
    private LivreEntity livre;

}
