package fr.polytech.DS.controllers;

import java.util.List;
import java.util.stream.Collector;
import java.util.stream.Collectors;

import javax.validation.Valid;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import fr.polytech.DS.dto.RestaurantDto;
import fr.polytech.DS.services.RestaurantService;

@RestController()
public class RestaurantController {
	public final RestaurantService restaurantService;
	
	public RestaurantController(RestaurantService restoService) {
		this.restaurantService = restoService;
	}
	
	@GetMapping("/restaurants/{id}")
	public @ResponseBody RestaurantDto getRestaurantById(@PathVariable int id) {
		System.out.println("retourne resto n°" + id);
		return RestaurantDto.fromEntity(this.restaurantService.getRestaurantById(id));
	}
	
	@GetMapping("/restaurants")
	public @ResponseBody List<RestaurantDto> getRestaurants(){
		System.out.println("retourne tous les restos");
		return this.restaurantService.getAllRestaurants().stream().map(entity -> RestaurantDto.fromEntity(entity)).collect(Collectors.toList());
	}
	
	@PostMapping("/restaurants")
	public RestaurantDto postRestaurant(@Valid @RequestBody RestaurantDto resto) {
		System.out.println("j'ai ajouté un resto : " + resto);
		return RestaurantDto.fromEntity(this.restaurantService.addRestaurant(resto.getNom()));
	}
}
