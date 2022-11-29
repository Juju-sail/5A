import java.math.BigInteger;

public class Main {
    public static BigInteger nb1 = new BigInteger("8");
    public static BigInteger nb2 = new BigInteger("672");
    public static BigInteger nb3 = new BigInteger("5");

    public static void main(String[] args) {
        OutilsRSA fct = new OutilsRSA();
        System.out.println(nb1 + " modulo " + nb2 + " = " + fct.mod(nb1, nb2));
        System.out.println(nb1 + " puissance " + nb3 + " modulo " + nb2 + " = " + fct.puissanceModNaive(nb1, nb2, nb3));
        System.out.println(nb1 + " puissance " + nb3 + " modulo " + nb2 + " = " + fct.puissanceMod(nb1, nb2, nb3));
        System.out.println("generation BigInteger : " + fct.randomBigInt());
        System.out.println("pgcd de " + nb1 + " et " + nb2 + " : " + fct.pgcd(nb1, nb2));
    }
}