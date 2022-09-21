package fr.polytech.fsback.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import fr.polytech.fsback.entity.LivreEntity;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.Size;
import java.util.List;
import java.util.stream.Collectors;

@Data
@NoArgsConstructor
@Builder
@AllArgsConstructor
public class LivreDto {

    @JsonProperty("id")
    private int id;

    @JsonProperty("titre")
    @Size(max = 10)
    private String titre;

    @JsonProperty("commentaires")
    private List<CommentaireDto> commentaires;

    public static LivreDto fromEntity(LivreEntity livreEntity) {
        return LivreDto.builder().
                id(livreEntity.getId())
                .titre(livreEntity.getTitre())
                .commentaires(livreEntity.getCommentaires().stream().map(commentaire -> CommentaireDto.fromEntity(commentaire)).collect(Collectors.toList()))
                .build();
    }

}
