package fr.polytech.DS.controllers;

import javax.validation.Valid;

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
	
	@PostMapping("restaurants/{restaurantId}/evaluations")
	public @ResponseBody EvaluationDto addEvaluation(@Valid @RequestBody EvaluationDto dto, @PathVariable int restaurantId) {
		return EvaluationDto.fromEntity(this.evaluationService.addEvaluation(restaurantId, dto.getCommentaire()));
	}
}
