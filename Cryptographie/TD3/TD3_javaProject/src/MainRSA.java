import java.math.BigInteger;

public class MainRSA {


    public static void main(String[] args) {
        UserRSA user = new UserRSA("juju");
        user.genereClefs();
        System.out.println(user.clefPublic);
        System.out.println(user.clefPrivee);
    }

}
