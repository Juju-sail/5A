package fr.polytech.fsback.services;

import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.fsback.entity.LivreEntity;
import fr.polytech.fsback.exceptions.LivresNotFoundException;
import fr.polytech.fsback.repository.LivreRepository;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

@Service
@Builder
@Data
@RequiredArgsConstructor
public class LivreService {
	private final LivreRepository livreRepository;
	
	
	public LivreEntity getLivreById(int id) {
		return this.livreRepository.findById(id).orElseThrow(() -> new LivresNotFoundException("livre n°" + id + " n'existe pas"));//si tu trouve pas, message d'erreur perso
	}


	public List<LivreEntity> getAllLivres() {
		return this.livreRepository.findAll();
	}
	
	public LivreEntity addLivre(String titre) {
		final LivreEntity newlivre = LivreEntity.builder().titre(titre).build();
		this.livreRepository.save(newlivre);
		return newlivre;
	}

	/*public LivreDto addLivre(String titre) {
		LivreDto livre = new LivreDto((int) (Math.random()*100), titre);
		this.listeDeLivres.add(livre);
		return livre;
	}
	
	public void deleteLivre(int id) {
		//LivreDto livreSupprime = this.listeDeLivres.get(id);
		this.listeDeLivres.remove(this.getLivreById(id));
		//return livreSupprime;
	}*/
}
