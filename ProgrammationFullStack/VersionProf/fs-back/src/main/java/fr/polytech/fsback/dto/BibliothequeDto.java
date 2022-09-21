package fr.polytech.fsback.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import fr.polytech.fsback.entity.BibliothequeEntity;
import lombok.Builder;
import lombok.Data;

import java.util.List;
import java.util.stream.Collectors;

@Data
@Builder
public class BibliothequeDto {

    @JsonProperty("id")
    private int id;

    @JsonProperty("nom")
    private String nom;

    @JsonProperty("livres")
    private List<LivreDto> livres;

    public static BibliothequeDto fromEntity(BibliothequeEntity entity) {
        return BibliothequeDto.builder()
                .id(entity.getId())
                .nom(entity.getNom())
                .livres(entity.getLivres().stream().map(livre -> LivreDto.fromEntity(livre)).collect(Collectors.toList()))
                .build();
    }

}
