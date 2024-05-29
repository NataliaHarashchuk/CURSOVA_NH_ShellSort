using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURSOVA_NH
{
    public partial class SortingVisualizer : Form
    {
        private int[] array;
        private Graphics graph;
        private const int rectangleGap = 5;
        private int sortOrder;
        private int sortSequence;

        public SortingVisualizer(int[] array, int sortOrder, int sortSequence)
        {
            InitializeComponent();
            this.array = array;
            this.sortOrder = sortOrder;
            this.sortSequence = sortSequence;
        }
        private void SortingVisualizer_Shown(object sender, EventArgs e)
        {
            VisualizeSorting();
        }
        private void VisualizeSorting()
        {
            graph = panelGraph.CreateGraphics();
            int numOfElements = array.Length;
            int panelWidth = panelGraph.Width;
            int panelHeight = panelGraph.Height;            
            
            graph.FillRectangle(new SolidBrush(Color.Black), 0, 0, panelWidth, panelHeight);

            float rectWidth = (float)panelWidth / numOfElements;
            int zeroLine = panelHeight / 2;

            for (int i = 0; i < numOfElements; i++)
            {
                float rectHeight = (float)Math.Abs(array[i]) / array.Max() * (panelHeight / 2 - rectangleGap);
                float rectY = array[i] >= 0 ? zeroLine - rectHeight : zeroLine;
                graph.FillRectangle(new SolidBrush(Color.White), i * rectWidth, rectY, rectWidth, rectHeight);
            }

            Sort SortingVisualization =new Sort();
            SortingVisualization.Animate(array, graph, panelHeight, sortOrder, sortSequence,zeroLine,rectWidth,rectangleGap);
        }
    }
}
