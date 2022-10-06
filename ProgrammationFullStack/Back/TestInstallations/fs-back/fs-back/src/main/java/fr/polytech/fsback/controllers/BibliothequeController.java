package fr.polytech.fsback.controllers;

import javax.validation.Valid;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import fr.polytech.fsback.dto.BibliothequeDto;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.services.BibliothequeService;

@RestController
public class BibliothequeController {
	public final BibliothequeService bibliService;
	
	public BibliothequeController(BibliothequeService bibliService) {
		super();
		this.bibliService = bibliService;
	}

	@GetMapping("/bibliothques")
	public @ResponseBody BibliothequeDto getBibliById(@PathVariable int id) {
		//log.info("retourne un livre par son titre");
		System.out.println("retourne une bibliothque par son id");
		//return this.listeDeLivres.get(id); //Attention, on filtre pas à l'id là mais on prend de xème element de la liste
		return this.bibliService.getbibliByID(id);
	}
	
	@PostMapping("/bibliotheques/{bibliothequeId}/livres")
    public @ResponseBody LivreDto addLivreToBibliotheque(@PathVariable final int bibliothequeId, @RequestBody @Valid final LivreDto livre) {
        return this.bibliService.addLivreBibli(bibliothequeId, livre.getId());
    }
}