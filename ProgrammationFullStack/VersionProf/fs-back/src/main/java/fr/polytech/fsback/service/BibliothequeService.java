package fr.polytech.fsback.service;

import fr.polytech.fsback.entity.BibliothequeEntity;
import fr.polytech.fsback.entity.LivreEntity;
import fr.polytech.fsback.exception.ResourceDoesntExistException;
import fr.polytech.fsback.repository.BibliothequeRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@RequiredArgsConstructor
@Service
public class BibliothequeService {

    private final LivreService livreService;
    private final BibliothequeRepository bibliothequeRepository;

    public BibliothequeEntity getBibliothequeById(final int id) {
        return this.bibliothequeRepository.findById(id)
                .orElseThrow(() -> new ResourceDoesntExistException("Bibliotheque with id " + id + " doesn't exists"));
    }

    public void addLivreToBibliotheque(final int bibliothequeId, final int livreId) {
        final BibliothequeEntity bibliotheque = this.getBibliothequeById(bibliothequeId);
        final LivreEntity livreToAdd = this.livreService.getLivreById(livreId);

        bibliotheque.getLivres().add(livreToAdd);
        this.bibliothequeRepository.save(bibliotheque);
    }

}
