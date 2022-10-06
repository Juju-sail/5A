package fr.polytech.fsback.controllers;

import fr.polytech.fsback.dto.BibliothequeDto;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.services.BibliothequeService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RequiredArgsConstructor
@RestController
public class BibliothequeController {

    private final BibliothequeService bibliothequeService;

    @GetMapping("/bibliotheques/{id}")
    public @ResponseBody BibliothequeDto getBibliothequesById(@PathVariable final String id) {
        return this.bibliothequeService.getBibliothequeById(id);
    }

    @PostMapping("/bibliotheques/{bibliothequeId}/livres")
    public @ResponseBody LivreDto addLivreToBibliotheque(@PathVariable final String bibliothequeId, @RequestBody @Valid final LivreDto livre) {
        return this.bibliothequeService.addLivreToBibliotheque(bibliothequeId, livre.getId());
    }

}
