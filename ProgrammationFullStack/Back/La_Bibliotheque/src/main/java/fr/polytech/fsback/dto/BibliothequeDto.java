package fr.polytech.fsback.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Builder;
import lombok.Data;

import java.util.List;

@Data
@Builder
public class BibliothequeDto {

    @JsonProperty("id")
    private String id;

    @JsonProperty("nom")
    private String nom;

    @JsonProperty("livres")
    private List<LivreDto> livres;

}
