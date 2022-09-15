package fr.polytech.fsback.controllers;

import fr.polytech.fsback.dto.CommentaireDto;
import fr.polytech.fsback.services.CommentaireService;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@Slf4j
@RequiredArgsConstructor
public class CommentaireController {

    private final CommentaireService commentaireService;

    @PostMapping("livres/{livreId}/commentaires")
    public @ResponseBody CommentaireDto addCommentaire(@Valid @RequestBody CommentaireDto dto, @PathVariable int livreId) {
        return CommentaireDto.fromEntity(this.commentaireService.addCommentaire(livreId, dto.getMessage()));
    }

}
