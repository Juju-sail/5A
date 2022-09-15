package fr.polytech.fsback.services;

import fr.polytech.fsback.dto.BibliothequeDto;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.exception.ResourceDoesntExist;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@RequiredArgsConstructor
@Service
public class BibliothequeService {

    private final List<BibliothequeDto> listeDeBibliotheque = new ArrayList<>();

    private final LivreService livreService;

    public BibliothequeDto getBibliothequeById(final String id) {
        return this.listeDeBibliotheque.stream().filter(bibliothequeDto -> bibliothequeDto.getId().equals(id))
                .findFirst()
                .orElseThrow(() -> new ResourceDoesntExist("Bibliotheque with id " + id + " doesn't exists"));
    }

    public LivreDto addLivreToBibliotheque(final String bibliothequeId, final int livreId) {
        final BibliothequeDto bibliotheque = this.getBibliothequeById(bibliothequeId);

        return null;
    }

}
