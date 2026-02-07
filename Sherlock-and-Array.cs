import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    /*
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static String balancedSums(List<Integer> arr) {
        int totalSum = arr.stream().mapToInt(Integer::intValue).sum();

        int leftSum = 0;
        for (int x : arr) {
            int rightSum = totalSum - leftSum - x;
            if (leftSum == rightSum) {
                return "YES";
            }
            leftSum += x;
        }
        return "NO";
    }
}

