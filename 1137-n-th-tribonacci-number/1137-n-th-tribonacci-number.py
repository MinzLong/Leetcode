class Solution(object):
    def tribonacci(self, n):
        """
        :type n: int
        :rtype: int
        """
        a = 0
        b = 1
        c = 1
        if n == 0 :
            return a
        for i in range (3,n+1):
            d= a+b+c
            a = b
            b = c
            c = d
        return c