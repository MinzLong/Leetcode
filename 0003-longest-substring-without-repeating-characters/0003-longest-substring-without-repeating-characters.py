class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        only = set()
        loop =0
        longest = 0

        for length in range(len(s)):
            while s[length] in only:
                only.remove(s[loop])
                loop+=1
            
            only.add(s[length])

            longest = max (longest, length - loop +1)
        return longest
        