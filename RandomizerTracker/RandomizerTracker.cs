using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using System.Reflection;
using QuickGraph;
using GraphX;
using GraphX.Controls;
using System.Windows;
using static RandomizerTracker.RandomizerData;
using static RandomizerTracker.XmlData;

namespace RandomizerTracker
{
    public partial class RandomizerTracker : Form
    {
        public static RandomizerTracker instance;

        public RandomizerTracker()
        {
            instance = this;
            InitializeComponent();
            filepathBox.Text = LogFilepath;
            Translator.Initialize();
            ProcessXmls();
            GetRandomizerData();
            Load += (obj, e) => MasterRefresh();
            trackerLogViewer.VisibleChanged += ConstructManualInputPage;
        }

        #region Map setup and controls

        private ZoomControl zoom;
        private Grapher.GraphArea graph;

        private void buttonRefreshMap_Click(object sender, EventArgs e)
        {
            graph.Dispose();
            graph = Grapher.CreateTransitionGraph();
            zoom.Content = graph;
            graph.GenerateGraph(true);
            Grapher.RecolorVertices(graph);
        }

        private void MasterRefresh()
        {
            GetRandomizerData();

            if (graph != null) graph.Dispose();
            graph = Grapher.CreateTransitionGraph();

            if (zoom == null)
            {
                zoom = new ZoomControl();
                ZoomControl.SetViewFinderVisibility(zoom, Visibility.Visible);
                elementHost1.Child = zoom;
            }
            zoom.Content = graph;
            zoom.Zoom = 0.01f;

            zoomToVertexSelect.Items.Clear();
            zoomToVertexSelect.Items.AddRange(roomRandomizer ? rooms.ToArray() : areas.ToArray());

            graph.GenerateGraph(true);
            Grapher.RecolorVertices(graph);
            edgeLabelsToggled = false;
            zoom.ZoomToFill();
        }

        private void masterRefreshButton_Click(object sender, EventArgs e) => MasterRefresh();

        
        private void ToggleEdgeLabels_Click(object sender, EventArgs e)
        {
            edgeLabelsToggled = !edgeLabelsToggled;
            graph.ShowAllEdgesLabels(edgeLabelsToggled);
        }

        private static bool edgeLabelsToggled = false;
        #endregion

        #region Manual input

        private void ConstructManualInputPage(object sender, EventArgs e)
        {
            if (!trackerLogViewer.Visible || !File.Exists(LogFilepath)) return;

            GetRandomizerData();
            RefreshTrackerLogViewer();

            itemSelectBox.Items.Clear();
            itemSelectBox.Items.AddRange(randomizedItems.ToArray());

            locationSelectBox.Items.Clear();
            locationSelectBox.Items.AddRange(randomizedItems.ToArray());

            sourceTransitionSelect.Items.Clear();
            targetTransitionSelect.Items.Clear();

            if (areaRandomizer)
            {
                sourceTransitionSelect.Items.AddRange(areaTransitions.ToArray());
                targetTransitionSelect.Items.AddRange(areaTransitions.ToArray());
            }
            else if (roomRandomizer)
            {
                sourceTransitionSelect.Items.AddRange(roomTransitions.ToArray());
                targetTransitionSelect.Items.AddRange(roomTransitions.ToArray());
            }
        }

        private void RefreshTrackerLogViewer()
        {
            trackerLogViewer.Items.Clear();
            if (!File.Exists(Properties.Settings.Default.filepath))
            {
                System.Windows.Forms.MessageBox.Show("Error: No tracker log found at the specified filepath.");
                return;
            }

            string[] data = File.ReadAllLines(Properties.Settings.Default.filepath);
            trackerLogViewer.Items.AddRange(data);
        }

        private void FastRefreshTrackerLogViewer(string[] data)
        {
            trackerLogViewer.Items.Clear();
            trackerLogViewer.Items.AddRange(data);
        }

        private void AddToTrackerLog(params string[] lines)
        {
            if (!File.Exists(Properties.Settings.Default.filepath))
            {
                System.Windows.Forms.MessageBox.Show("Error: No tracker log found at the specified filepath.");
                return;
            }

            File.AppendAllLines(LogFilepath, lines);
            RefreshTrackerLogViewer();
        }

        private void RemoveFromTrackerLog(string line)
        {
            if (!File.Exists(Properties.Settings.Default.filepath))
            {
                System.Windows.Forms.MessageBox.Show("Error: No tracker log found at the specified filepath.");
                return;
            }

            List<string> data = File.ReadAllLines(LogFilepath).ToList();
            data.RemoveAll(l => l == line);
            File.WriteAllLines(LogFilepath, data);
            FastRefreshTrackerLogViewer(data.ToArray());
        }

        private void addItemLine_Click(object sender, EventArgs e)
        {
            AddToTrackerLog($"ITEM --- {{{itemSelectBox.SelectedItem}}} at {{{locationSelectBox.SelectedItem}}}");
        }

        private void addTransitionLine_Click(object sender, EventArgs e)
        {
            if (areaRandomizer)
            {
                AddToTrackerLog($"TRANSITION --- {{{sourceTransitionSelect.SelectedItem.ToString()}}}-->{{{targetTransitionSelect.SelectedItem.ToString()}}}",
                    $"                ({transitionToArea[sourceTransitionSelect.SelectedItem.ToString()]} to {transitionToArea[sourceTransitionSelect.SelectedItem.ToString()]})");
            }
            else
            {
                AddToTrackerLog($"TRANSITION --- {{{sourceTransitionSelect.SelectedItem.ToString()}}}-->{{{targetTransitionSelect.SelectedItem.ToString()}}}");
            }
        }

        private void removeLineButton_Click(object sender, EventArgs e)
        {
            RemoveFromTrackerLog(trackerLogViewer.SelectedItem.ToString());
        }
        #endregion

        #region Settings
        public static string LogFilepath
        {
            get
            {
                if (Properties.Settings.Default.filepath is string path && File.Exists(path))
                {
                    return Properties.Settings.Default.filepath;
                }
                else
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\Team Cherry\Hollow Knight\RandomizerTrackerLog.txt";
                    LogFilepath = path;
                    return path;
                }
            }
            set
            {
                Properties.Settings.Default.filepath = value;
                Properties.Settings.Default.Save();
            }
        }

        private void filepathBox_TextChanged(object sender, EventArgs e)
        {
            LogFilepath = filepathBox.Text;
        }
        public string vertAlgo => (string)listBoxVertexAlgo.SelectedItem;
        public string edgeAlgo => (string)listBoxEdgeAlgo.SelectedItem;
        #endregion

        private void zoomToVertexButton_Click(object sender, EventArgs e)
        {
            var kvp = graph.VertexList.FirstOrDefault(v => v.Key.Name == (string)zoomToVertexSelect.SelectedItem);
            if (kvp.Value is VertexControl vertex)
            {
                System.Windows.Point pos = vertex.GetPosition();
                var rect = new Rect(pos.X - 150f, pos.Y - 150f, vertex.ActualWidth + 300f, vertex.ActualHeight + 450f);
                zoom.ZoomToContent(rect);
            }
        }
    }
}
