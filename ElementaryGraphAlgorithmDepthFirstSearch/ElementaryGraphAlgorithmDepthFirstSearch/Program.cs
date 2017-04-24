using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryGraphAlgorithmDepthFirstSearch
{
    class Program
    {
        public static int currentTime = 0;
        static void Main(string[] args)
        {
            List<Node> Graph = new List<Node>();

            Node u = new Node("u");
            Node v = new Node("v");
            Node y = new Node("y");
            Node x = new Node("x");
            Node w = new Node("w");
            Node z = new Node("z");
            u.addChild(v);
            u.addChild(x);
            Graph.Add(u);
            v.addChild(y);
            Graph.Add(v);
            y.addChild(x);
            Graph.Add(y);
            x.addChild(v);
            Graph.Add(x);
            w.addChild(z);
            Graph.Add(w);
            Graph.Add(z);

            Console.WriteLine("Depth First Traversal");
            DFS(Graph);
            Console.Read();
        }
        static void DFS(List<Node> Graph)
        {
            foreach (Node i in Graph)
            {
                if (i.color == 0)
                {
                    DFSVisit(Graph, i);
                }
            }
        }
        static void DFSVisit(List<Node> Graph, Node currentNode)
        {
            Console.Write(currentNode.nodeName + " ");
            currentNode.time = ++currentTime;
            currentNode.color = 1;
            foreach (var i in currentNode.children)
            {
                if (i.color == 0)
                {
                    i.previousNode = currentNode;
                    DFSVisit(Graph, i);
                }
            }
            currentNode.color = 2;
            currentNode.finishTime = ++currentTime;
        }
        
    }
    public class Node
    {
        //color 0 = white, 1 = gray, 2 = black
        public int time = -1;
        public int finishTime = -1;
        public String nodeName = "null";
        public int color = 0;
        public Node previousNode;
        public List<Node> children = new List<Node>();
        
        public Node(String name)
        {
            nodeName = name;
        }
        public void addChild(Node childToAdd)
        {
            children.Add(childToAdd);
        }
    }
}
