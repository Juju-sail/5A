package fr.polytech.fsback.services;

import fr.polytech.fsback.entity.CommentaireEntity;
import fr.polytech.fsback.entity.LivreEntity;
import fr.polytech.fsback.repository.CommentaireRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class CommentaireService {

    private final CommentaireRepository commentaireRepository;

    private final LivreService livreService;

    public CommentaireEntity addCommentaire(int livreId, String messageDuCommentaire) {
        final LivreEntity livre = livreService.getLivreById(livreId);
        final CommentaireEntity nouveauCommentaire = CommentaireEntity.builder().message(messageDuCommentaire).livre(livre).build();

        return this.commentaireRepository.save(nouveauCommentaire);
    }

}
