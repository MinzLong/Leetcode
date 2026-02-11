class Solution(object):
    def addTwoNumbers(self, l1, l2):
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """
        dummy = ListNode()  # Nút giả để bắt đầu danh sách kết quả
        current = dummy  # Con trỏ để duyệt danh sách kết quả
        carry = 0  # Biến lưu trữ số dư khi tổng lớn hơn 9

        # Duyệt qua cả hai danh sách liên kết cho đến khi không còn phần tử nào
        while l1 or l2 or carry:
            val1 = l1.val if l1 else 0  # Giá trị của l1, nếu không có thì lấy 0
            val2 = l2.val if l2 else 0  # Giá trị của l2, nếu không có thì lấy 0
            total = val1 + val2 + carry  # Tổng của hai giá trị và số dư
            carry = total // 10  # Lấy số dư cho bước tiếp theo
            total = total % 10  # Lấy phần còn lại cho giá trị của nút hiện tại
            
            # Tạo một nút mới với giá trị tính được và thêm vào danh sách kết quả
            current.next = ListNode(total)
            current = current.next
            
            # Di chuyển tới nút tiếp theo trong l1 và l2 nếu có
            if l1:
                l1 = l1.next
            if l2:
                l2 = l2.next

        return dummy.next  # Trả về danh sách kết quả, bỏ qua nút giả ban đầu

# Hàm chuyển list Python thành danh sách liên kết
def to_linked_list(lst):
    dummy = ListNode()  # Nút giả để bắt đầu danh sách
    current = dummy  # Con trỏ để duyệt và tạo danh sách liên kết
    for number in lst:
        current.next = ListNode(number)  # Tạo nút mới cho mỗi phần tử
        current = current.next
    return dummy.next  # Trả về danh sách liên kết, bỏ qua nút giả
