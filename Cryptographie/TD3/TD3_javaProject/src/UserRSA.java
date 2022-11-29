import java.math.BigInteger;

public class UserRSA {
    public String nomUser;
    public BigInteger clefPublic;
    public BigInteger clefPrivee;

    public UserRSA(String nomUser, BigInteger clefPublic, BigInteger clefPrivee) {
        this.nomUser = nomUser;
        this.clefPublic = clefPublic;
        this.clefPrivee = clefPrivee;
    }
    public UserRSA(String nomUser) {
        this.nomUser = nomUser;
        this.clefPublic = BigInteger.ZERO;
        this.clefPrivee = BigInteger.ZERO;
    }

    public void genereClefs(){
        BigInteger p = OutilsRSA.randomBigInt();
        while(!OutilsRSA.isPseudoPrime(p)){
            p = OutilsRSA.randomBigInt();
        }
        BigInteger q = OutilsRSA.randomBigInt();
        while(!OutilsRSA.isPseudoPrime(q)){
            q = OutilsRSA.randomBigInt();
        }

        BigInteger n = p.multiply(q);

        BigInteger e = OutilsRSA.randomBigInt();
        while (OutilsRSA.pgcd(e, (p.subtract(BigInteger.ONE)).multiply(q.subtract(BigInteger.ONE))).compareTo(BigInteger.ONE) != 0){
            e = OutilsRSA.randomBigInt();
        }

        this.clefPublic = e;

        BigInteger d = OutilsRSA.inverseMod(e, (p.subtract(BigInteger.ONE)).multiply(q.subtract(BigInteger.ONE)));

        this.clefPrivee = d;
    }
}
