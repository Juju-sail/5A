import java.math.BigInteger;

public class Main {
    public static BigInteger nb1 = new BigInteger("8");
    public static BigInteger nb2 = new BigInteger("672");
    public static int nb3 = 5;

    public static void main(String[] args) {
        FonctionsDeBase fct = new FonctionsDeBase();
        System.out.println(nb1 + " modulo " + nb2 + " = " + fct.modulo(nb1, nb2));
        System.out.println(nb1 + " puissance " + nb3 + " modulo " + nb2 + " = " + fct.puissanceModulo(nb1, nb2, nb3));
        System.out.println("generation BigInteger : " + fct.generateBigIntAleat());
    }
}