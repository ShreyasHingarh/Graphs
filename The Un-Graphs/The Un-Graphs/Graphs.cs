using System;
using System.Collections.Generic;
using System.Text;

namespace The_Un_Graphs
{
    public class Vertex<T>
    {
        public T value { get; set; }
        public List<Vertex<T>> Neighbors { get; set; }

        public int NeighborCount => Neighbors.Count;

        public Vertex(T value) {}
    }

    public class Graphs
    {
        public List<Vertex<T>> Vertices { get; private set; }

        public int VertexCount => Vertices.Count;

        public Graph() { }

    }
}
