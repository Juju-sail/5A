package fr.polytech.fsback.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.exceptions.LivresNotFoundException;

@Service
public class LivreService {
	public List<LivreDto> listeDeLivres = new ArrayList<LivreDto>();
	
	
	public LivreService() {
		LivreDto l1 = new LivreDto((int) (Math.random()*100), "gtr");
		LivreDto l2 = new LivreDto((int) (Math.random()*100), "fghj");
		this.listeDeLivres.add(l1);
		this.listeDeLivres.add(l2);
	}
	
	
	
	public LivreDto getLivreById(int id) {
		return this.listeDeLivres.stream().filter(livreDto -> livreDto.getId()==id)
				.findFirst() // Trouve le premier livre avec id identique à celui mit dans le filter
				.orElseThrow(() -> new LivresNotFoundException("livre n°" + id + " n'existe pas"));//si tu trouve pas, message d'erreur perso
	}

	public LivreDto addLivre(String titre) {
		LivreDto livre = new LivreDto((int) (Math.random()*100), titre);
		this.listeDeLivres.add(livre);
		return livre;
	}
	
	public void deleteLivre(int id) {
		//LivreDto livreSupprime = this.listeDeLivres.get(id);
		this.listeDeLivres.remove(this.getLivreById(id));
		//return livreSupprime;
	}
}
