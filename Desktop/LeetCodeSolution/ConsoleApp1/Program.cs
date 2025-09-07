namespace ConsoleApp1
{
    internal class Program
    {
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
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummy = new ListNode();
                ListNode current = dummy;
                int carry = 0;

                while (l1 != null || l2 != null || carry != 0)
                {
                    int val1 = (l1 != null) ? l1.val : 0;
                    int val2 = (l2 != null) ? l2.val : 0;

                    int sum = val1 + val2 + carry;
                    carry = sum / 10;

                    current.next = new ListNode(sum % 10);
                    current = current.next;

                    if (l1 != null) l1 = l1.next;
                    if (l2 != null) l2 = l2.next;
                }

                return dummy.next;
            }
        }

        static void Main(string[] args)
        {
            // Test input: l1 = [2 -> 4 -> 3], l2 = [5 -> 6 -> 4]
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            Solution solution = new Solution();
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Çap et: [7 -> 0 -> 8]
            Console.Write("Nəticə: ");
            while (result != null)
            {
                Console.Write(result.val);
                if (result.next != null)
                    Console.Write(" -> ");
                result = result.next;
            }
            Console.WriteLine();
        }
    } 
}