class ListNode(object):
     def __init__(self, val=0, next=None):
         self.val = val
         self.next = next

    # Временная сложность: O(n+m) 
    # Поскольку ровно один из l1 и l2 увеличивается на каждой итерации цикла, 
    # цикл while выполняется в течение количества итераций, равного сумме длин двух списков. 
    # Вся остальная работа ограничивается констанкой, поэтому общая сложность является линейной.
      
    # Пространственная сложность: O(1) 
    # Итеративный подход выделяет только несколько указателей, поэтому он имеет постоянный общий объем памяти.

class Solution:
    def mergeTwoLists(self, l1, l2):
        prehead = ListNode(-1)

        prev = prehead
        while l1 and l2:
            if l1.val <= l2.val:
                prev.next = l1
                l1 = l1.next
            else:
                prev.next = l2
                l2 = l2.next            
            prev = prev.next

        prev.next = l1 if l1 is not None else l2

        return prehead.next
