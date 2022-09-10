package fr.polytech.fsback.controllers;

import java.util.List;

import javax.validation.Valid;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

//import fr.polytech.fsback.Livres;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.services.LivreService;
import lombok.extern.slf4j.Slf4j;

@RestController()
//@RequiredArgsConstructor
@Slf4j
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
		return this.livreService.getLivreById(id);
	}
	
	

	@GetMapping("/livres")
	public @ResponseBody List<LivreDto> getLivres(){
		System.out.println("retourne tous les livres");
		return this.livreService.listeDeLivres;
	}
	
	@PostMapping("/livres")
	public void postLivre(@Valid @RequestBody LivreDto l) { //valid : prend le dto et verrifie que tout match avec les regles
		l.setId((int) (Math.random()*100));
		livreService.listeDeLivres.add(l);
	}
}