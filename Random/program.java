public class TenDigitIncrement {
    public static void main(String[] args) {

        long start = 1000000000L;  // smallest 10-digit number
        long end = 1000001000L;    // you can change this range

        for (long i = start; i <= end; i += 100) {
            System.out.println(i);
        }
    }
}