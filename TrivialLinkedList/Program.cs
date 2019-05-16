using System;

namespace TrivialLinkedList
{
    class Program
    {
        public static int[] NodesValues;
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: TrivialLinkedList {Node Count} {Start Node Value} {Reverse at Node}");
                return;
            }

            var nodeCount = int.Parse(args[0]);
            var nodeStartValue= int.Parse(args[1]);
            var nodesToReverse = int.Parse(args[2])-1;
            Console.WriteLine("Values in: Node Length {0}"+" Initial Node Value {1}"+" Nodes to Reverse {2}",args[0],args[1], args[2]);
            InitializeNodes(nodeCount, nodeStartValue);
            ShowNodes();
            NodesValues = ReverseList(NodesValues, nodesToReverse);
            Console.WriteLine("Nodes Reversed");
            ShowNodes();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static void ShowNodes()
        {
            foreach (var s in NodesValues)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }


        public static int[] ReverseList(int[] Nodes,int startNode)
        {
            var nodeCount = Nodes.Length;
            var nodesToReverse = nodeCount - startNode;
            var nodesToStay = nodeCount - startNode-1;
            var retValue = new int[nodeCount];

            for (int i = startNode; i >-1 ; i--)
            {
                retValue[i] = Nodes[startNode-i];
            }

            for (int i = startNode+1; i < nodeCount; i++)
            {
                retValue[i] = Nodes[i];
            }
            return retValue;

        }

       public static void InitializeNodes(int nodeCount, int startValue)
       {
           NodesValues = new int[nodeCount];
           for (int i = 0; i < nodeCount; i++)
           {
               NodesValues[i] = i+startValue;
           }
           Console.WriteLine("Nodes Initialized");

        }
    }
}
 