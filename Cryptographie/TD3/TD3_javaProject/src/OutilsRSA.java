import java.math.BigInteger;
import java.util.Random;
import java.util.Vector;

public class OutilsRSA {
	 public static BigInteger mod(BigInteger x,  BigInteger n) {
		 BigInteger result = x.subtract(x.divide(n).multiply(n));
		 if (result.compareTo(BigInteger.ZERO) ==-1) {
			 result =result.add(n);
		 }
		 return result;
	 }
	 public static BigInteger puissanceModNaive(BigInteger x, BigInteger y,  BigInteger n) {

		 if (y.compareTo(BigInteger.ZERO) ==0) {
			 return BigInteger.ONE;
		 }
		 else {
			return mod(x.multiply(puissanceModNaive(x,y.subtract(BigInteger.ONE),n)),n) ;
		 }
	 }
	 public static BigInteger puissanceMod(BigInteger x, BigInteger y,  BigInteger n) {

		 if (y.compareTo(BigInteger.ZERO) ==0) {
			 return BigInteger.ONE;
		 }
		 else {
			 BigInteger base = puissanceMod(x,y.divide(BigInteger.TWO),n); 	//On calcule x^(y/2) mod n
			 if (mod(y,BigInteger.TWO).compareTo(BigInteger.ZERO)==1){ 		//Si y est impair
				 return mod(base.multiply(base.multiply(x)),n); 			//renvoie x*x^(y/2)*x^(y/2) mod n
			 }
			 else {
				 return mod(base.multiply(base),n); 						//renvoie x^(y/2)*x^(y/2) mod n
			 }
		 }
	 }
	 public static BigInteger pgcd(BigInteger a, BigInteger b) {
		 if (a.compareTo(b)==-1) {
			 return pgcd(b,a);										//On met le plus petit des deux à droite.
		 }
		 else if(b.compareTo(BigInteger.ZERO)==0) {
			 return a;												// cas d'arrêt
		 }
		 else {
			 return pgcd(b, mod(a, b));
		 }
	 }
	 public static BigInteger randomBigInt() {
		 BigInteger result = new BigInteger(512, new Random());
		 return result;
	 }
	 public static String IntToString(BigInteger a) {
		 String result = new String(a.toByteArray());
		 return result;
	 }
	 public static BigInteger StringToInt(String s) {
		 BigInteger result = new BigInteger(s.getBytes());
		 return result;
	 }

	 public static BigInteger[] extendedEculid(BigInteger a, BigInteger b) {
		 BigInteger[] result = new BigInteger[3];
		 if(b.compareTo(BigInteger.ZERO)==0) {
			 result[0]=a;
			 result[1]=BigInteger.ONE;
			 result[2]=BigInteger.ZERO;
		 }
		 else {
			 //à compléter
		 }
		 return result;
	 }
	 
	 public static BigInteger inverseMod(BigInteger a, BigInteger b) {
		 return BigInteger.ZERO; //Placeholder à compléter
	 }
	 
	 public static Boolean isPseudoPrime(BigInteger a) {
		 return false; //Placeholder à compléter
	 }
	 
	 public static BigInteger inverseModPrime(BigInteger a, BigInteger b) {
		 return BigInteger.ZERO; //Placeholder à compléter
	 }
	 
	 
}
