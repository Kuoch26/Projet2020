using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projet2020
{
    public partial class Décomposition : Form
    {
        public static readonly float MIDDLE_LIMIT = .5f;
        public static readonly float RANGE_MIN = -400f;
        public static readonly float RANGE_MAX = 400f;

        public static readonly int BUTTON_POS_X = 1225;
        public static readonly int BUTTON_POS_Y = 450;
        public static readonly int BUTTON_SIZE_X = 75;
        public static readonly int BUTTON_SIZE_Y = 25;
        public static readonly int BUTTON_SPACE_Y = 10;

        private static Dictionary<Button, int> imfButtons;
       

        public Décomposition()
        {
            InitializeComponent();
            imfButtons = new Dictionary<Button, int>();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart4_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DeleteAllButtons();
            var allValues = cartesianChart1.Series[0].Values.Cast<float>().ToArray();
            if (allValues.Length < 2)
                return;
            List<float> contentMiddle;
            int nbSpikes;
            int imfCount = 1;
            List<LineSeries> allImfs = new List<LineSeries>();
            do
            {
                contentMiddle = new List<float>();
                List<float> contentUp = new List<float>();
                List<float> contentDown = new List<float>();
                nbSpikes = 0;
                float first = allValues[0];
                float last = first;
                bool nextIsUp = allValues[1] > last;
                int i = 1;
                foreach (int val in allValues.Skip(1))
                {
                    if (nextIsUp)
                    {
                        if (val < last)
                        {
                            contentUp.Add(last);
                            nextIsUp = false;
                            nbSpikes++;
                        }
                        else
                        {
                            contentUp.Add(contentUp.Count > 0 ? contentUp.Last() : 0f);
                        }
                        contentDown.Add(contentDown.Count > 0 ? contentDown.Last() : 0f);
                    }
                    else
                    {
                        if (val > last)
                        {
                            contentDown.Add(last);
                            nextIsUp = true;
                        }
                        else
                        {
                            contentDown.Add(contentDown.Count > 0 ? contentDown.Last() : 0f);
                        }
                        contentUp.Add(contentUp.Count > 0 ? contentUp.Last() : 0f);
                    }
                    last = val;
                    i++;
                }
                contentUp.Add(0f);
                contentDown.Add(0f);
                for (int y = 0; y < contentUp.Count; y++)
                    contentMiddle.Add((contentUp[y] + contentDown[y]) / 2f);
                List<float> imf = new List<float>();
                List<float> residue = new List<float>();
                for (int y = 0; y < contentMiddle.Count; y++)
                {
                    var tmp = allValues[y] - contentMiddle[y];
                    imf.Add(tmp);
                    residue.Add(allValues[y] - tmp);
                }
                allImfs.Add(new LineSeries
                {
                    Values = new ChartValues<float>(imf),
                    Title = "IMF n°" + imfCount
                });
                Button b = new Button();
                Controls.Add(b);
                b.Text = "IMF n°" + imfCount;
                b.Location = new Point(BUTTON_POS_X, BUTTON_POS_Y + ((BUTTON_SIZE_Y + BUTTON_SPACE_Y) * imfCount));
                b.Size = new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y);
                b.Click += (object obj, EventArgs ___) =>
                {
                    SeriesCollection tmp = new SeriesCollection();
                    var imfs = cartesianChart3.Series.ToList();
                    var button = (Button)obj;
                    var deleted = imfButtons[button];
                    button.Dispose();
                    imfs.RemoveAt(deleted);
                    tmp.AddRange(imfs);
                    cartesianChart3.Series = tmp;
                    List<Button> toModify = new List<Button>();
                    foreach (var bt in imfButtons)
                    {
                        if (bt.Value > deleted)
                            toModify.Add(bt.Key);
                    }
                    foreach (var bt in toModify)
                    {
                        imfButtons[bt] -= 1;
                    }
                };
                imfButtons.Add(b, imfCount - 1);
                cartesianChart2.Series = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<float>(residue),
                            Title = "Résidu"
                        }
                    };
                allValues = residue.ToArray();
                imfCount++;
            } while (contentMiddle.Any(v => Math.Abs(v) > MIDDLE_LIMIT));// while (nbSpikes >= 4);
            SeriesCollection sc = new SeriesCollection();
            sc.AddRange(allImfs);
            cartesianChart3.Series = sc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormSignal = new Signal();
            FormSignal.Show();
            this.Hide();
        }
        private static void DeleteAllButtons()
        {
            foreach (var b in imfButtons)
            {
                b.Key.Dispose();
            }
            imfButtons.Clear();
        }
        private void Décomposition_Load(object sender, EventArgs e)
        {
            var values = new[] { 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, 0f, 0, 2f, 0, 4f, 0, 6f, 0, 8f, 0, 6f, 0f, -0, 6f, -1f, -1, 8f, -1f, -0, 6f, 0f, 1f, 1, 6f, };
            //numbers.values = cartesianChart1.Series[0].Values.Cast<float>().ToArray();
            ChartValues<float> content = new ChartValues<float>();
            foreach (var v in values) content.Add(v);
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = content
                }
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FormRecomposition = new Recomposition();
            FormRecomposition.Show();
            this.Hide();
        }
    }
}
