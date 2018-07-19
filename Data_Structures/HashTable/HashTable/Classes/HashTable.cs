using System;


namespace HashTable { 
/// <summary>
/// Summary description for Class1
/// </summary>
    public class HashT
    {
        /// <summary>
        /// gets and sets the value of head
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// gets and sets the value of current
        /// </summary>
        public Node Current { get; set; }

        public Node Next { get; set; }

        /// <summary>
        /// method to identify a node
        /// </summary>
        /// <param name="node">input paramter of node to set as head and current</param>
        public HashT(Node node)
        {
            Head = node;
            Current = node;
        }
        /// <summary>
        /// method to add new node in front of list, sets as head node
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;

        }

   
    }
}
