package fr.polytech.fsback.controllers;

import fr.polytech.fsback.dto.BibliothequeDto;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.service.BibliothequeService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RequiredArgsConstructor
@RestController
public class BibliothequeController {

    private final BibliothequeService bibliothequeService;

    @GetMapping("/bibliotheques/{id}")
    public @ResponseBody BibliothequeDto getBibliothequesById(@PathVariable final int id) {
        return BibliothequeDto.fromEntity(this.bibliothequeService.getBibliothequeById(id));
    }

    @PostMapping("/bibliotheques/{bibliothequeId}/livres")
    public void addLivreToBibliotheque(@PathVariable final int bibliothequeId, @RequestBody @Valid final LivreDto livre) {
        this.bibliothequeService.addLivreToBibliotheque(bibliothequeId, livre.getId());
    }

}
