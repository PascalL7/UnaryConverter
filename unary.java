import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        String message = in.nextLine();
        String binaryResult = "";
        String unaryResult = "";

        // To debug: System.err.println("Debug messages...");

        for (int i = 0; i < message.length(); i++)
        {
            String charInBinary = Integer.toBinaryString((int)message.charAt(i));
            charInBinary = "0000000".substring(charInBinary.length()) + charInBinary;
            binaryResult += charInBinary;
        }

        char lastChar = ' ';
        String[] encodedBits = new String[] { " 00 0", " 0 0" };
        
        for (int i = 0; i < binaryResult.length(); i++)
        {
            if (binaryResult.charAt(i) != lastChar)
            {
                lastChar = binaryResult.charAt(i);
                unaryResult += encodedBits[lastChar - '0'];
            }
            else
            {
                unaryResult += "0";
            }
        }
        
        System.out.println(unaryResult.substring(1));

    }
}
