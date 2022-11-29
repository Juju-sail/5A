import java.io.UnsupportedEncodingException;
import java.math.BigInteger;
import java.util.Random;

public class FonctionsDeBase {


    public static BigInteger modulo(BigInteger nb1, BigInteger nb2){
        BigInteger modulo = nb1.subtract(nb1.divide(nb2).multiply(nb2));
        if(modulo.compareTo(BigInteger.ZERO)==-1){
            modulo = modulo.add(nb2);
        }
        return modulo;
    }

    public BigInteger puissanceModulo(BigInteger nb1, BigInteger nb2, int nb3){
        BigInteger nombreEleve = nb1;
        for (int puiss = 1; puiss <= nb3; puiss++){
            nombreEleve = nombreEleve.multiply(nb1);
        }
        BigInteger puiss = modulo(nombreEleve, nb2);
        return puiss;
    }

    public BigInteger generateBigIntAleat() {
        Random random = new Random();
        BigInteger BigInteger = new BigInteger(512, random);
        return BigInteger;
    }

    /*public BigInteger stringToInt(String s) throws UnsupportedEncodingException {
        byte[] code = s.getBytes(s);
        return code;
    }*/
}
