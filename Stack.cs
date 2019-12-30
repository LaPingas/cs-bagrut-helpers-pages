using System;
using Unit4.CollectionsLib;

namespace Stack
{
        /// <summary>
        /// Copies a stack to an additional stack
        /// Time complexity: O(n), n = the number of items in the source stack
        /// </summary>
        /// <param name="source"> The source stack </param>
        /// <returns> A new stack with the same content as the given stack </returns>
        public static Stack<T> CopyStack<T>(Stack<T> source, Stack<T> destination = null)
        {
            if (destination == null)
                destination = new Stack<T>();
            Stack<T> temp = new Stack<T>();
            while (!source.IsEmpty())
            {
                temp.Push(source.Top());
                destination.Push(source.Pop());
            }
            SpillStack(temp, source);
            return destination;
        }

        /// <summary>
        /// Takes a stack and putting its content in a different stack
        /// Time complexity: O(n), n = the number of items in the source stack
        /// </summary>
        /// <param name="from"> The source stack </param>
        /// <param name="to"> The target stack </param>
        /// <returns> A new stack with the same content as the given stack </returns>
        public static Stack<T> SpillStack<T>(Stack<T> source, Stack<T> destination = null)
        {
            if (destination == null)
                destination = new Stack<T>();
            while (!source.IsEmpty())
                destination.Push(source.Pop());
            return destination;
        }
        
        /// <summary>
        /// Find the minimum value in a stack
        /// Time complexity: O(n), n = the number of items in the source stack
        /// </summary>
        /// <param name="source"> The source stack </param>
        /// <returns> The minimum value in the stack </returns>
        public static int FindMin(Stack<int> source)
        {
            Stack<int> workingStack = CopyStack(source);
            int min = Int32.MaxValue;
            while (!workingStack.IsEmpty())
            {
                int current = workingStack.Pop();
                if (current < min)
                    min = current;
            }
            return min;
        }

        /// <summary>
        /// Makes a circular movement in a stack
        /// Time complexity: O(n), n = the number of items in the source stack
        /// </summary>
        /// <param name="source"> The source stack </param>
        public static void CircularStackMovement<T>(Stack<T> source)
        {
            T top = source.Pop();
            Stack<T> temp = SpillStack(source);
            source.Push(top);
            SpillStack(temp, source);
        }

        /// <summary>
        /// Checks if two stacks have the same items
        /// Time complexity: O(n * m), n = number of items in s1, m = number of items in s2
        /// </summary>
        /// <param name="s1"> The first source stack </param>
        /// <param name="s2"> The second source stack </param>
        /// <returns> True if both stacks have the same items, otherwise false </returns>
        public static bool DeepEqual<T>(Stack<T> s1, Stack<T> s2)
        {
            Stack<T> temp = CopyStack(s1);
            while (!temp.IsEmpty())
                if (SearchStack(s2, temp.Pop()))
                    return true;
            return false;
        }

        /// <summary>
        /// Searches an item in a given stack
        /// Time complexity: O(n), n = the number of items in the source stack
        /// </summary>
        /// <param name="source"> The source stack </param>
        /// <param name="item"> The item to search </param>
        /// <returns> True if the item exists in the stack, otherwise false </returns>
        public static bool SearchStack<T>(Stack<T> source, T item)
        {
            if (source.IsEmpty())
                return false;
            T top = source.Top();
            if (item.Equals(top))
                return true;
            source.Pop();
            bool found = SearchStack(source, item);
            source.Push(top);
            return found;
        }
}
