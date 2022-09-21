package service;

import fr.polytech.fsback.entity.LivreEntity;
import fr.polytech.fsback.exception.InvalidValueException;
import fr.polytech.fsback.exception.ResourceDoesntExistException;
import fr.polytech.fsback.repository.LivreRepository;
import fr.polytech.fsback.service.LivreService;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.junit.jupiter.MockitoExtension;

import java.util.Optional;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertThrows;
import static org.mockito.ArgumentMatchers.any;
import static org.mockito.Mockito.when;

@ExtendWith(MockitoExtension.class)
public class LivreServiceTest {

    @InjectMocks
    private LivreService livreService;

    @Mock
    private LivreRepository livreRepository;

    @Test()
    public void shouldThrowAInvalidValueException() {
        assertThrows(InvalidValueException.class, () -> this.livreService.updateLivre(1, null));
    }

    @Test()
    public void shouldThrownAResourceDoesntExist() {
        when(livreRepository.findById(any())).thenReturn(Optional.empty());
        assertThrows(ResourceDoesntExistException.class, () -> this.livreService.updateLivre(1, "nouveau nom"));
    }

    @Test()
    public void shouldReturnALivreEntity() {
        LivreEntity expected = LivreEntity.builder().id(3).build();
        when(livreRepository.findById(any())).thenReturn(Optional.of(expected));
        LivreEntity result = this.livreService.getLivreById(3);
        assertEquals(expected, result);
    }

}
