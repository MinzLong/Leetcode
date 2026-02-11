public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;

        // Duyệt từ phải sang trái
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits; // xong ngay
            }
            digits[i] = 0; // gặp 9 thì reset
        }

        // Nếu toàn bộ đều là 9
        int[] result = new int[n + 1];
        result[0] = 1;
        return result;
    }
}
