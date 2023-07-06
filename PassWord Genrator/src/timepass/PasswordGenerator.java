package timepass;

import java.security.SecureRandom;
import java.util.Random;

public class PasswordGenerator {
    
    private static final String CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    private static final String NUMBERS = "0123456789";
    private static final String SPECIAL_CHARS = "!@#$%^&*()_+-=[]{}|;:,.<>?";
    private static final String ALL_CHARS = CHARACTERS + NUMBERS + SPECIAL_CHARS;
    
    private static SecureRandom random = new SecureRandom();

    public static String generatePassword() {
        StringBuilder password = new StringBuilder();
        for (int i = 0; i < 8; i++) {
            int randomIndex = random.nextInt(ALL_CHARS.length());
            password.append(ALL_CHARS.charAt(randomIndex));
        }
        return password.toString();
    }

    public static void main(String[] args) {
        String password = generatePassword();
        System.out.println("Generated Password: " + password);
    }
}
