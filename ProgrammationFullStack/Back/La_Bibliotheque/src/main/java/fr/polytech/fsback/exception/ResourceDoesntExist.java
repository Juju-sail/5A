package fr.polytech.fsback.exception;

public class ResourceDoesntExist extends RuntimeException {

    public ResourceDoesntExist(String message) {
        super(message);
    }
}
