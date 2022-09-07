package fr.polytech.fsback.dto;

import javax.validation.constraints.Size;

import com.fasterxml.jackson.annotation.JsonProperty;

import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@Builder
public class LivreDto {
	@JsonProperty("id")
    private int id;
    @JsonProperty("titre")
    @Size(max = 10)
    private String titre;
	
    public LivreDto(int id, String titre) {
		super();
		this.id = id;
		this.titre = titre;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	

    
}
