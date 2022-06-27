namespace Task1;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{

    /*
    
    Временная сложность: O(n+m) 
    Поскольку ровно один из l1 и l2 увеличивается на каждой итерации цикла, 
    цикл while выполняется в течение количества итераций, равного сумме длин двух списков. 
    Вся остальная работа ограничивается констанкой, поэтому общая сложность является линейной.

    Пространственная сложность: O(1) 
    Итеративный подход выделяет только несколько указателей, поэтому он имеет постоянный общий объем памяти.
    */

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        // поддерживаем неизменную ссылку на узел перед возвращаемым узлом.
        ListNode prehead = new ListNode(-1);

        ListNode prev = prehead;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                prev.next = l1;
                l1 = l1.next;
            }
            else
            {
                prev.next = l2;
                l2 = l2.next;
            }
            prev = prev.next;
        }

        // По крайней мере, один из l1 и l2 может все еще иметь узлы в этой точке, так что соединим
        // ненулевой список в концe объединенного списка.
        prev.next = l1 == null ? l2 : l1;

        return prehead.next;
    }
}