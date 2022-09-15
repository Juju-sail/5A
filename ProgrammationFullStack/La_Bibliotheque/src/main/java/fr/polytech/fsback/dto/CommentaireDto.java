package fr.polytech.fsback.dto;

import com.fasterxml.jackson.annotation.JsonProperty;
import fr.polytech.fsback.entity.CommentaireEntity;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotBlank;

@Data
@NoArgsConstructor
@Builder
@AllArgsConstructor
public class CommentaireDto {

    @JsonProperty("id")
    private int id;

    @NotBlank
    @JsonProperty("message")
    private String message;

    public static CommentaireDto fromEntity(CommentaireEntity entity) {
        return CommentaireDto.builder().id(entity.getId()).message(entity.getMessage()).build();
    }

}
