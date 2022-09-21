package fr.polytech.fsback.service;

import fr.polytech.fsback.entity.LivreEntity;
import fr.polytech.fsback.exception.InvalidValueException;
import fr.polytech.fsback.exception.ResourceDoesntExistException;
import fr.polytech.fsback.repository.LivreRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
@RequiredArgsConstructor
public class LivreService {

    private final LivreRepository livreRepository;

    public LivreEntity getLivreById(int id) {
        return this.livreRepository.findById(id)
                .orElseThrow(() -> new ResourceDoesntExistException("livre with id " + id + " doesn't exists"));
    }

    public List<LivreEntity> getAllLivres() {
        return this.livreRepository.findAll();
    }

    public LivreEntity addLivre(final String titre) {
    	final LivreEntity nouveauLivre = LivreEntity.builder().titre(titre).commentaires(new ArrayList<>()).build();
    	return this.livreRepository.save(nouveauLivre);
    }

    public LivreEntity updateLivre(int id, String nouveauNom) {
        if (nouveauNom == null) {
            throw new InvalidValueException("le nouveau nom ne doit pas être null");
        }
        final LivreEntity livreToUpdate = this.livreRepository.findById(id).orElseThrow(() -> new ResourceDoesntExistException("le livre d'id " + id + " n'existe pas"));
        livreToUpdate.setTitre(nouveauNom);
        livreRepository.save(livreToUpdate);
        return livreToUpdate;
    }


}
