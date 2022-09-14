package fr.polytech.fsback.dto;

import java.util.List;

public class BibliothequeDto {
	private List<LivreDto> listeLivres;
	private int id;
	private String nom;
	
	

	public BibliothequeDto(List<LivreDto> listeLivres, int id, String nom) {
		super();
		this.listeLivres = listeLivres;
		this.id = id;
		this.nom = nom;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public List<LivreDto> getListeLivres() {
		return listeLivres;
	}

	public void setListeLivres(List<LivreDto> listeLivres) {
		this.listeLivres = listeLivres;
	}
	
	
}
