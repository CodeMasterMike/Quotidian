using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotidian.HelperObjects
{
    //prewritten code gotten from https://codereview.stackexchange.com/questions/138475/weighted-graph-and-pathfinding-implementation-in-c
    class WeightedGraph<T>
    {
        List<WeightedEdge<T>> edges;
        List<Vertex<T>> vertices;
        public List<WeightedEdge<T>> Edges { get { return edges; } }

        public WeightedGraph(List<Vertex<T>> vertices, List<WeightedEdge<T>> edges)
        {
            this.vertices = vertices;
            this.edges = edges;
        }
        public void AddEdge(WeightedEdge<T> newEdge)
        {
            edges.Add(newEdge);
        }
        public void RemoveEdge(WeightedEdge<T> edge)
        {
            edges.Remove(edge);
        }

        /// <summary>
        /// Pathfinding algorithms available: Dijkstra and AStar
        /// </summary>
        //public List<Vertex<T>> Pathfinder(Vertex<T> start, Vertex<T> end, string algorithm)
        //{
        //    Func<Vertex<T>, Vertex<T>, List<Vertex<T>>> pathfinder;

        //    if (algorithm == "Dijkstra")
        //    {
        //        pathfinder = DijkstraSearch;
        //    }
        //    else if (algorithm == "AStar")
        //    {
        //        pathfinder = AStarSearch;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Pathfinding algorithm not available.");
        //    }
        //    return pathfinder(start, end);
        //}


        //public List<Vertex<T>> DijkstraSearch(Vertex<T> start, Vertex<T> end)
        //{
        //    Dictionary<Vertex<T>, Vertex<T>> parentMap = new Dictionary<Vertex<T>, Vertex<T>>();
        //    PriorityQueue<Vertex<T>> priorityQueue = new PriorityQueue<Vertex<T>>();

        //    InitializeCosts(start);
        //    priorityQueue.Enqueue(start, start.Cost);

        //    Vertex<T> current;

        //    while (priorityQueue.Count > 0)
        //    {
        //        current = priorityQueue.Dequeue();

        //        if (!current.IsVisited)
        //        {
        //            current.IsVisited = true;

        //            if (current.Equals(end))
        //            {
        //                break;
        //            }

        //            foreach (WeightedEdge<T> edge in current.Edges)
        //            {
        //                Vertex<T> neighbor = edge.End;

        //                double newCost = current.Cost + edge.Weight;
        //                double neighborCost = neighbor.Cost;

        //                if (newCost < neighborCost)
        //                {
        //                    neighbor.Cost = newCost;
        //                    parentMap.Add(neighbor, current);
        //                    double priority = newCost;
        //                    priorityQueue.Enqueue(neighbor, priority);
        //                }
        //            }
        //        }
        //    }
        //    List<Vertex<T>> path = ReconstructPath(parentMap, start, end);
        //    return path;
        //}

        //public List<Vertex<T>> AStarSearch(Vertex<T> start, Vertex<T> end)
        //{
        //    Dictionary<Vertex<T>, Vertex<T>> parentMap = new Dictionary<Vertex<T>, Vertex<T>>();
        //    PriorityQueue<Vertex<T>> priorityQueue = new PriorityQueue<Vertex<T>>();

        //    InitializeCosts(start);
        //    priorityQueue.Enqueue(start, start.Cost);

        //    Vertex<T> current;

        //    while (priorityQueue.Count > 0)
        //    {
        //        current = priorityQueue.Dequeue();

        //        if (!current.IsVisited)
        //        {
        //            current.IsVisited = true;

        //            if (current.Equals(end))
        //            {
        //                break;
        //            }

        //            foreach (WeightedEdge<T> edge in current.Edges)
        //            {
        //                Vertex<T> neighbor = edge.End;

        //                double newCost = current.Cost + edge.Weight;
        //                double neighborCost = neighbor.Cost;

        //                if (newCost < neighborCost)
        //                {
        //                    neighbor.Cost = newCost;
        //                    parentMap.Add(neighbor, current);
        //                    double priority = newCost + Heuristic(neighbor, end);
        //                    priorityQueue.Enqueue(neighbor, priority);
        //                }
        //            }
        //        }
        //    }
        //    List<Vertex<T>> path = ReconstructPath(parentMap, start, end);
        //    return path;
        //}

        //public double Heuristic(Vertex<T> vertexA, Vertex<T> vertexB)
        //{
        //    return vertexA.Location.DistanceTo(vertexB.Location);
        //}

        public void InitializeCosts(Vertex<T> start)
        {
            foreach (Vertex<T> vertex in vertices)
            {
                vertex.Cost = int.MaxValue;
            }

            start.Cost = 0;
        }

        public List<Vertex<T>> ReconstructPath(Dictionary<Vertex<T>, Vertex<T>> parentMap, Vertex<T> start, Vertex<T> end)
        {
            List<Vertex<T>> path = new List<Vertex<T>>();
            Vertex<T> current = end;

            while (current != start)
            {
                path.Add(current);
                current = parentMap[current];
            }

            path.Add(start);

            path.Reverse();
            return path;
        }

    }

    class Vertex<T>
    {
        List<Vertex<T>> neighbors;
        List<WeightedEdge<T>> edges;
        T value;

        public List<Vertex<T>> Neighbors { get { return neighbors; } }
        public List<WeightedEdge<T>> Edges { get { return edges; } }
        //public Location Location { get; set; }
        public T Value { get { return value; } set { this.value = value; } }
        public bool IsVisited { get; set; }
        public int NeighborsCount { get { return neighbors.Count; } }
        public double Cost { get; set; }

        public Vertex(T value)
        {
            this.value = value;
            IsVisited = false;
            neighbors = new List<Vertex<T>>();
            edges = new List<WeightedEdge<T>>();
        }

        public Vertex(T value, List<Vertex<T>> neighbors)
        {
            this.value = value;
            IsVisited = false;
            this.neighbors = neighbors;
        }

        public void AddNeighbor(Vertex<T> vertex)
        {
            neighbors.Add(vertex);
        }
        public void AddEdge(WeightedEdge<T> edge)
        {
            edges.Add(edge);
        }

        public override string ToString()
        {
            StringBuilder allNeighbors = new StringBuilder("");
            allNeighbors.Append(value + ": ");

            foreach (Vertex<T> neighbor in neighbors)
            {
                allNeighbors.Append(neighbor.value + "  ");
            }

            return allNeighbors.ToString();
        }

    }

    class WeightedEdge<T>
    {
        int weight;

        Vertex<T> start;
        Vertex<T> end;

        public int Weight { get { return weight; } }

        public Vertex<T> Start { get { return start; } }
        public Vertex<T> End { get { return end; } }

        public WeightedEdge(Vertex<T> start, Vertex<T> end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
            start.AddNeighbor(end);
            start.AddEdge(this);
        }

        public override string ToString()
        {
            return string.Format("{0}--{1}-->{2}", start.Value, weight, end.Value);
        }
    }
}
