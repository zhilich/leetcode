/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            var l = new ListNode(0);
            var r = l;

            while (l1 != null || l2 != null)
            {
                while (l1 != null && (l2 == null || l1.val <= l2.val))
                {
                    l.next = new ListNode(l1.val);
                    l = l.next;
                    l1 = l1.next;
                }
                while (l2 != null && (l1 == null || l2.val <= l1.val))
                {
                    l.next = new ListNode(l2.val);
                    l = l.next;
                    l2 = l2.next;
                }
            }

            return r.next;
    }
}
