namespace OPPAdv3
{

	internal class Program
	{
		#region Question1
		//implement a function to reverse the elements of a queue using a stack.Given a Queue,
		public static Queue<int> Reverse(Queue<int> Q)
		{
			Stack<int> S = new Stack<int>();
			while (Q.Count > 0)
			{
				S.Push(Q.Dequeue());
			}
			while (S.Count > 0)
			{
				Q.Enqueue(S.Pop());
			}
			return Q;
		}
		#endregion
		#region Question2
		//Given a Stack, implement a function to check if a string of parentheses is balanced using a stack
		public static void balanced(String str) {
			Stack<char> stack = new Stack<char>();
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if ((stack.Count > 0) && ((c == ']') || (c == '}') || (c == ')')))
				{
					if ((c == ']' && stack.Peek() == '[') || (c == '}' && stack.Peek() == '{') || (c == ')' && stack.Peek() == '('))
					{
						stack.Pop();
					}
					else
					{
						stack.Push(c);
					}
				}
				else {
					stack.Push(c);
				}
			}
			if (stack.Count == 0)
			{
				Console.WriteLine("Balanced");
				return;
			}
			else
			{
				Console.WriteLine("Not Balanced");
				return;
			}
		}
		#endregion

		static void Main(string[] args)
		{
			#region TestQuestion1
			Queue<int> queue = new Queue<int>() {  };
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);
			Queue<int> reversedQueue = Reverse(queue);
			Console.WriteLine("Reversed Queue:");
			while (reversedQueue.Count > 0)
			{
				Console.WriteLine(reversedQueue.Dequeue());
			}
            #endregion
            #region TestQuestion2
            Console.WriteLine("plz enter word to check it");
			string input = Console.ReadLine();
			balanced(input);
			#endregion
		}
	}
}
