package fr.polytech.fsback.controllers;

import java.util.List;
import java.util.stream.Collectors;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

//import fr.polytech.fsback.Livres;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.services.LivreService;

@RestController()
//@RequiredArgsConstructors
public class LivresController {
	public final LivreService livreService; //final : indiq pour dire que ça change pas plus tard (constante et pas variable)
	
	public LivresController(LivreService lservice) {
		this.livreService = lservice;
	}

	@GetMapping("/livres/{id}")
	public @ResponseBody LivreDto getLivre(@PathVariable int id) {
		//log.info("retourne un livre par son titre");
		System.out.println("retourne un livre par son id");
		//return this.listeDeLivres.get(id); //Attention, on filtre pas à l'id là mais on prend de xème element de la liste
		return LivreDto.fromEntity(this.livreService.getLivreById(id));
	}
	
	@GetMapping("/livres")
    public @ResponseBody List<LivreDto> getLivres() {
        System.out.println("retourne tous les livres");
        return this.livreService.getAllLivres().stream().map(entity -> LivreDto.fromEntity(entity)).collect(Collectors.toList());
    }

	/*@GetMapping("/livres")
	public @ResponseBody List<LivreDto> getLivres(){
		System.out.println("retourne tous les livres");
		return this.livreService.listeDeLivres;
	}
	
	@PostMapping("/livres")
	public void postLivre(@Valid @RequestBody LivreDto l) { //valid : prend le dto et verrifie que tout match avec les regles
		this.livreService.addLivre(l.getTitre());
		System.out.println("creer un livre : "+ l.getTitre());
		
	}
	
	@DeleteMapping("/livres/{id}")
	public @ResponseBody void deleteLivre(@PathVariable int id) {
		System.out.println("suppression livre "+ id);
		this.livreService.deleteLivre(id);
	}*/
}
