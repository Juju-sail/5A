package services;

import static org.junit.jupiter.api.Assertions.assertThrows;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.when;

import java.util.Optional;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import fr.polytech.fsback.exception.InvalidValueException;
import fr.polytech.fsback.exception.ResourceDoesntExist;
import fr.polytech.fsback.repository.LivreRepository;
import fr.polytech.fsback.services.LivreService;

@ExtendWith(MockitoExtension.class)
public class livreServiceTest {
	@InjectMocks
	private LivreService livreService;
	
	@Mock
	private LivreRepository livreRepo;
	
	@Test()
	public void shouldThrowInvalidException() {
		InvalidValueException thrown = assertThrows(InvalidValueException.class, () -> this.livreService.updateLivre(1, null));
	}
	
	@Test()
	public void shouldThrowARessourceDoesntExist() {
		when(livreRepo.findById(any())).thenReturn(Optional.empty());
		assertThrows(ResourceDoesntExist.class, () -> this.livreService.updateLivre(1, "rtty"));
	}
}
