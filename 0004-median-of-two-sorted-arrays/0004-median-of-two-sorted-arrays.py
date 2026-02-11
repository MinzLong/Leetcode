class Solution(object):
    def findMedianSortedArrays(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: float
        """
        # Đảm bảo nums1 là mảng nhỏ hơn để giảm độ phức tạp khi tìm kiếm nhị phân \U0001f44d
        if len(nums1) > len(nums2):
            nums1, nums2 = nums2, nums1

        m, n = len(nums1), len(nums2)
        imin, imax = 0, m
        half_len = (m + n + 1) // 2  # Phần tử bên trái cần có ít nhất (m+n+1)//2 phần tử

        while imin <= imax:
            i = (imin + imax) // 2  # Chọn vị trí phân chia cho nums1
            j = half_len - i      # Và tự động xác định vị trí phân chia cho nums2

            # Nếu i quá nhỏ, nghĩa là nums2[j-1] > nums1[i] => cần tăng i lên \U0001f680
            if i < m and nums2[j-1] > nums1[i]:
                imin = i + 1

            # Nếu i quá lớn, nghĩa là nums1[i-1] > nums2[j] => cần giảm i xuống \U0001f525
            elif i > 0 and nums1[i-1] > nums2[j]:
                imax = i - 1

            # Nếu đúng thì tìm được phân chia hoàn hảo! \U0001f389
            else:
                # Tìm giá trị max bên trái
                if i == 0:
                    max_of_left = nums2[j-1]
                elif j == 0:
                    max_of_left = nums1[i-1]
                else:
                    max_of_left = max(nums1[i-1], nums2[j-1])

                # Nếu tổng số phần tử lẻ, median chính là max_of_left \U0001f31f
                if (m + n) % 2 == 1:
                    return float(max_of_left)

                # Tìm giá trị min bên phải
                if i == m:
                    min_of_right = nums2[j]
                elif j == n:
                    min_of_right = nums1[i]
                else:
                    min_of_right = min(nums1[i], nums2[j])

                # Nếu tổng số phần tử chẵn, median là trung bình của max_of_left và min_of_right \U0001f680
                return (max_of_left + min_of_right) / 2.0

