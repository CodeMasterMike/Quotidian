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
        public List<Vertex<T>> vertices; 
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

        //combination of breadth first search and a weighted shortest path algorithm
        public List<WeightedEdge<T>> TagFinder(Vertex<T> start, List<WeightedEdge<T>> final, List<Vertex<T>> visited, List<Vertex<T>> seen, List<WeightedEdge<T>> sortedNeighbors)
        {
            //Start with new queue. We start with new one each time because sortedNeighbors will just be transformed to queue and that persists across function calls
            Queue<WeightedEdge<T>> queue = new Queue<WeightedEdge<T>>();
            //Console.WriteLine("At Node: " + start.Value);
            //need visited node list
            //start at start list
            //add neighbors to queue of nodes to visit next based on their weight
            //as you visit node, add it to final list
            
            foreach (WeightedEdge<T> e in start.edges)
            {
                //if edge is not already in sortedNeighbors (i.e. it has been 'seen')
                //and if the target of the edge has not already been visited
                if(!sortedNeighbors.Contains(e) && !visited.Contains(e.End))
                {
                    sortedNeighbors.Add(e);
                    //seen.Add(e.End);
                }
            }

            //sort neighbors(edges) based on link strength
            //This sorting doesn't take into account proximity to start node
            sortedNeighbors.Sort(); //default sort is based on link

            //print out sortedNeighbors for debug purposes
            //Console.WriteLine("sortedNeighbors length:" + sortedNeighbors.Count());
            foreach (WeightedEdge<T> e in sortedNeighbors)
            {
                Console.WriteLine(e.ToString());
            }
            
            //added sortedNeighbors to queue
            foreach(WeightedEdge<T> e in sortedNeighbors)
            {
                queue.Enqueue(e);
            }

            //if queue is empty, return final
            if(queue.Count() == 0)
            {
                return final;
            }

            //dequeue first element and visit that
            WeightedEdge<T> next = queue.Dequeue();

            //do similar operation to sortedNeighbors
            if (sortedNeighbors.Count() > 0)
            {
                sortedNeighbors.RemoveAt(0);
            }

            //visit node
            visited.Add(next.End);
            //add to list
            final.Add(next);//maybe add something else?
            return TagFinder(next.End, final, visited, seen, sortedNeighbors);
        }
        

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
        public List<Vertex<T>> neighbors;
        public List<WeightedEdge<T>> edges;
        ReadingTag value;

        public List<Vertex<T>> Neighbors { get { return neighbors; } }
        public List<WeightedEdge<T>> Edges { get { return edges; } }
        //public Location Location { get; set; }
        public ReadingTag Value { get { return value; } set { this.value = value; } }
        public bool IsVisited { get; set; }
        public int NeighborsCount { get { return neighbors.Count; } }
        public double Cost { get; set; }
        public int tagId { get; set; }

        public Vertex(ReadingTag value)
        {
            this.value = value;
            this.tagId = value.tagId;
            IsVisited = false;
            neighbors = new List<Vertex<T>>();
            edges = new List<WeightedEdge<T>>();
        }

        public Vertex(ReadingTag value, List<Vertex<T>> neighbors)
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

    class WeightedEdge<T> : IComparable<WeightedEdge<T>>
    {
        int weight;

        public List<int> ReadingIds = new List<int>();

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
            end.AddEdge(this);
        }

        public int CompareTo(WeightedEdge<T> e)
        {
            if(e.weight > weight)
            {
                return 1;
            }
            else if (e.weight < weight)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}--{1}-->{2}", start.Value, weight, end.Value);
        }
    }
}
