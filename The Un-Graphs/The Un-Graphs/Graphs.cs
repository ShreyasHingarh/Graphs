using System;
using System.Collections.Generic;
using System.Text;

namespace The_Un_Graphs
{
    public class Vertex<T>
    {
        public T Value { get; set; }
        public List<Vertex<T>> Neighbors { get; set; }

        

        public Vertex(T value) 
        {
            Neighbors = new List<Vertex<T>>();
            Value = value;
        }
        public int NeighborCount => Neighbors.Count;
    }

    public class Graphs<T>
    {
        public List<Vertex<T>> Vertices { get; private set; }

        public int VertexCount => Vertices.Count;
        public Graphs()
        {
            Vertices = new List<Vertex<T>>();
        }

        public void AddVertex(Vertex<T> vertex)
        {
            if(vertex != null && vertex.NeighborCount == 0 && !Vertices.Contains(vertex))
            {
                Vertices.Add(vertex);
            }
        }  
        public bool RemoveVertex(Vertex<T> vertex)
        {
            if(Vertices.Contains(vertex))
            {
                vertex.Neighbors = new List<Vertex<T>>();
                Vertices.Remove(vertex);
                foreach (var vert in Vertices)
                {
                    if(vert.Neighbors.Contains(vertex))
                    {
                        vert.Neighbors.Remove(vertex);
                    }
                }
                return true;
            }
            return false;
        }
        public bool AddEdge(Vertex<T> a, Vertex<T> b)
        {
            if(a != null && b != null && Vertices.Contains(a) && Vertices.Contains(b))
            {
                a.Neighbors.Add(b);
                b.Neighbors.Add(a);
                return true;
            }
            return false;
        }
        public bool RemoveEdge(Vertex<T> a, Vertex<T> b)
        {
            if(a != null && b != null && a.Neighbors.Contains(b) && b.Neighbors.Contains(a))
            {
                a.Neighbors.Remove(b);
                b.Neighbors.Remove(a);
                return true;
            }
            return false;
        }
        public Vertex<T> Search(T value)
        {
            int index = -1;
            for (int i = 0; i < Vertices.Count; i++)
            {
                if(Vertices[i].Value.Equals(value))
                {
                    index = i;
                    break; 
                }
            }
            if (index == -1)
            {
                return null;
            }
            return Vertices[index];
        }

    }
}
