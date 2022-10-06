package fr.polytech.fsback.controllers;

import fr.polytech.fsback.dto.LivreDto;
import fr.polytech.fsback.services.LivreService;
import lombok.extern.slf4j.Slf4j;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;
import java.util.stream.Collectors;

@RestController()
//@RequiredArgsConstructor
@Slf4j
public class LivresController {
    public final LivreService livreService; //final : indiq pour dire que ça change pas plus tard (constante et pas variable)

    public LivresController(LivreService lservice) {
        this.livreService = lservice;
    }

    @GetMapping("/livres/{id}")
    public @ResponseBody LivreDto getLivreById(@PathVariable int id) {
        return LivreDto.fromEntity(this.livreService.getLivreById(id));
    }


    @GetMapping("/livres")
    public @ResponseBody List<LivreDto> getLivres() {
        System.out.println("retourne tous les livres");
        return this.livreService.getAllLivres().stream().map(entity -> LivreDto.fromEntity(entity)).collect(Collectors.toList());
    }

    @PostMapping("/livres")
    public LivreDto postLivre(@Valid @RequestBody LivreDto l) {
        return LivreDto.fromEntity(this.livreService.addLivre(l.getTitre()));
    }
}
