using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Forms;
using GraphX;
using GraphX.Controls;
using GraphX.PCL.Common.Models;
using GraphX.PCL.Logic.Algorithms.OverlapRemoval;
using GraphX.PCL.Logic.Models;
using QuickGraph;
using static RandomizerTracker.RandomizerTracker;
using static RandomizerTracker.RandomizerData;
using static RandomizerTracker.XmlData;

namespace RandomizerTracker
{
    public static class Grapher
    {
        public static GraphArea CreateTransitionGraph()
        {
            Graph graph = new Graph();
            Dictionary<string, DataVertex> vertices = new Dictionary<string, DataVertex>();
            int i = 0;
            foreach (string s in areaRandomizer ? areas : roomRandomizer ? rooms : new HashSet<string>())
            {
                i++;
                DataVertex v = new DataVertex() { ID = i, Name = s, uiName = AltRoomNames.TryGetValue(s, out string altName) ? altName : null };
                vertices[s] = v;
                graph.AddVertex(v);
            }
            List<string> sourceTransitions = new List<string>();
            foreach (var kvp in FoundTransitions)
            {
                //DataEdge e = new DataEdge(vertices[pair.Item1], vertices[pair.Item2]);
                string source;
                string target;

                if (areaRandomizer)
                {
                    source = transitionToArea[kvp.Key];
                    target = transitionToArea[kvp.Value];
                }
                else
                {
                    source = transitionToRoom[kvp.Key];
                    target = transitionToRoom[kvp.Value];
                }

                DataEdge e = new DataEdge(vertices[source], vertices[target])
                {
                    SourceTransition = kvp.Key,
                    TargetTransition = kvp.Value,
                    Label = !sourceTransitions.Contains(kvp.Value)
                };
                sourceTransitions.Add(kvp.Key);
                graph.AddEdge(e);
            }

            var LogicCore = new GXLogicCore() { Graph = graph };

            if (!Enum.TryParse<GraphX.PCL.Common.Enums.LayoutAlgorithmTypeEnum>(RandomizerTracker.instance.vertAlgo, out var vertAlgo))
            {
                vertAlgo = GraphX.PCL.Common.Enums.LayoutAlgorithmTypeEnum.LinLog;
            }
            if (!Enum.TryParse<GraphX.PCL.Common.Enums.EdgeRoutingAlgorithmTypeEnum>(RandomizerTracker.instance.edgeAlgo, out var edgeAlgo))
            {
                edgeAlgo = GraphX.PCL.Common.Enums.EdgeRoutingAlgorithmTypeEnum.SimpleER;
            }

            LogicCore.DefaultLayoutAlgorithm = vertAlgo;
            LogicCore.DefaultLayoutAlgorithmParams = LogicCore.AlgorithmFactory.CreateLayoutParameters(vertAlgo);
            LogicCore.DefaultOverlapRemovalAlgorithm = GraphX.PCL.Common.Enums.OverlapRemovalAlgorithmTypeEnum.FSA;
            LogicCore.DefaultOverlapRemovalAlgorithmParams = LogicCore.AlgorithmFactory.CreateOverlapRemovalParameters(GraphX.PCL.Common.Enums.OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)LogicCore.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 30;
            ((OverlapRemovalParameters)LogicCore.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 30;
            LogicCore.DefaultEdgeRoutingAlgorithm = edgeAlgo;
            //LogicCore.AsyncAlgorithmCompute = false;
            GraphArea GA = new GraphArea();
            GA.LogicCore = LogicCore;
            return GA;
        }

        public static void RecolorVertices(GraphArea GA)
        {
            if (areaRandomizer)
            {
                foreach (var kvp in GA.VertexList)
                {
                    if (AreaToColor.TryGetValue(kvp.Key.Name, out Color col))
                    {
                        kvp.Value.Background = new SolidColorBrush(col);
                    }
                }
            }
            else if (roomRandomizer)
            {
                foreach (var kvp in GA.VertexList)
                {
                    if (roomToArea.TryGetValue(kvp.Key.Name, out string areaName))
                    {
                        if (AreaToColor.TryGetValue(areaName, out Color col))
                        {
                            kvp.Value.Background = new SolidColorBrush(col);
                        }
                    }
                }
            }
        }

        //Layout visual class
        public class GraphArea : GraphArea<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>> { }

        //Graph data class
        public class Graph : BidirectionalGraph<DataVertex, DataEdge> { }

        //Logic core class
        public class GXLogicCore : GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>> { }

        //Vertex data object
        public class DataVertex : VertexBase
        {
            public string Name;
            public string uiName;

            public string CleanName()
            {
                if (!areaRandomizer) return Name;
                string newName = Name.Replace('_', ' ');
                switch (newName)
                {
                    case "Kings Pass":
                        newName = "King's Pass";
                        break;
                    case "Queens Station":
                        newName = "Queen's Station";
                        break;
                    case "Kings Station":
                        newName = "King's Station";
                        break;
                    case "Queens Gardens":
                        newName = "Queen's Gardens";
                        break;
                    case "Hallownests Crown":
                        newName = "Hallownest's Crown";
                        break;
                    case "Kingdoms Edge":
                        newName = "Kingdom's Edge";
                        break;
                    case "Weavers Den":
                        newName = "Weaver's Den";
                        break;
                    case "Beasts Den":
                        newName = "Beast's Den";
                        break;
                    case "Spirits Glade":
                        newName = "Spirit's Glade";
                        break;
                    case "Ismas Grove":
                        newName = "Isma's Grove";
                        break;
                    case "Teachers Archives":
                        newName = "Teacher's Archives";
                        break;
                }
                return newName;
            }

            public int UncheckedLocations => 
                areaRandomizer ? randomizedItems.Count(location => itemToArea[location] == Name && !CheckLocationFound(location) && !checkIfShopItem[location]) : 
                roomRandomizer ? randomizedItems.Count(location => itemToRoom[location] == Name && !CheckLocationFound(location) && !checkIfShopItem[location]) : 0;

            public int UncheckedTransitions =>
                areaRandomizer ? areaTransitions.Count(t => transitionToArea[t] == Name && !FoundTransitions.ContainsKey(t) && !FoundTransitions.ContainsValue(t)) :
                roomRandomizer ? roomTransitions.Count(t => transitionToRoom[t] == Name && !FoundTransitions.ContainsKey(t) && !FoundTransitions.ContainsValue(t)) : 0;

            public override string ToString()
            {
                if (string.IsNullOrEmpty(uiName)) uiName = CleanName();
                return $"{uiName}" +
                    $"{(UncheckedLocations != 0 ? $"\nRemaining locations: {UncheckedLocations}" : string.Empty)}" +
                    $"{(UncheckedTransitions != 0 ? $"\nRemaining transitions: {UncheckedTransitions}" : string.Empty)}";
            }
        }

        //Edge data object
        public class DataEdge : EdgeBase<DataVertex>
        {
            public DataEdge(DataVertex source, DataVertex target, double weight = 1)
                : base(source, target, weight)
            {
            }

            public string SourceTransition { get; set; }

            public string TargetTransition { get; set; }

            public bool Label;

            public override string ToString()
            {
                return Label ? $"{SourceTransition}---{TargetTransition}" : String.Empty;
            }
        }
    }
}
