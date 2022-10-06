package fr.polytech.DS.controllers;

import java.util.List;
import java.util.stream.Collectors;

import javax.validation.Valid;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import fr.polytech.DS.dto.EvaluationDto;
import fr.polytech.DS.services.EvaluationService;
import lombok.RequiredArgsConstructor;

@RestController
@RequiredArgsConstructor
public class EvaluationController {
	private final EvaluationService evaluationService;
	
	@GetMapping("/restaurants/{id}/evaluations")
	public @ResponseBody List<EvaluationDto> getEvaluations(){
		System.out.println("retourne les evaluations d'un resto");
		return this.evaluationService.getAllEvaluations().stream().map(entity -> EvaluationDto.fromEntity(entity)).collect(Collectors.toList());
	}
	
	@PostMapping("restaurants/{restaurantId}/evaluations")
	public @ResponseBody EvaluationDto addEvaluation(@Valid @RequestBody EvaluationDto dto, @PathVariable int restaurantId) {
		System.out.println("ajout evaluation à resto n°" + restaurantId);
		return EvaluationDto.fromEntity(this.evaluationService.addEvaluation(restaurantId, dto.getCommentaire()));
	}
}
