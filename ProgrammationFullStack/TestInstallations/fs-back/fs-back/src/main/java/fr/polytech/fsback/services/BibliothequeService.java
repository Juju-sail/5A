package fr.polytech.fsback.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import fr.polytech.fsback.dto.BibliothequeDto;
import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.exceptions.LivresNotFoundException;

@Service
public class BibliothequeService {
	private List<BibliothequeDto> listeDeBibli = new ArrayList<BibliothequeDto>();
	private LivreService livreService;
	
	public BibliothequeService(List<BibliothequeDto> listeDeBibli, LivreService livreService) {
		super();
		this.listeDeBibli = listeDeBibli;
		this.livreService = livreService;
	}
	
	public BibliothequeService() {
		super();
	}


	public BibliothequeDto getbibliByID(int id) {
		return this.listeDeBibli.stream().filter(bibliothequeDto -> bibliothequeDto.getId()==id)
				.findFirst() // Trouve le premier livre avec id identique à celui mit dans le filter
				.orElseThrow(() -> new LivresNotFoundException("livre n°" + id + " n'existe pas"));//si tu trouve pas, message d'erreur perso
	}
	
	public LivreDto addLivreBibli(int bibliID, int livreId) {
		BibliothequeDto bibli = this.getbibliByID(bibliID);
		LivreDto livreToAdd = this.livreService.getLivreById(livreId);
		
		bibli.getListeLivres().add(livreToAdd);
		
		return livreToAdd;
	}
}
