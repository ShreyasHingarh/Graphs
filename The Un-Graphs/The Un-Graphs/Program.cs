using System;

namespace The_Un_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphs<int> graph = new Graphs<int>();
            Vertex<int> b = new Vertex<int>(2);
            Vertex<int> c = new Vertex<int>(3);

            Vertex<int> a = new Vertex<int>(1);
            graph.AddVertex(a);
            Vertex<int> b = a;
            graph.AddVertex(b);
            Console.WriteLine(graph.VertexCount);

            graph.AddVertex(b);
            graph.AddVertex(c);
            graph.AddEdge(a, b);
            graph.AddEdge(b, c);
            graph.AddEdge(c, a);

        }
    }
}
