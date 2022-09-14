package fr.polytech.fsback.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.exceptions.NotFoundException;

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
				.findFirst()
				.orElseThrow(() -> new NotFoundException("livre n°" + id + " n'existe pas"));
	}

	
	
	
}
