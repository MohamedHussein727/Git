using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using System.IO;

namespace Bus_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void make_new_network()
        {
            FileStream fs = new FileStream("dataset.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //double[][] myData = new double[][];
            string[] invector;
            string invec;
            List<List<double>> our_dat = new List<List<double>>();
            List<double> temp;
            while (sr.Peek() != -1)
            {
                temp = new List<double>();
                invec = sr.ReadLine();
                invector =  invec.Split(',');
                for(int i = 0; i < invector.Length; i++)
                {
                    temp.Add(Convert.ToDouble(invector[i]));
                }
                our_dat.Add(temp);
            }
            AForge.Neuro.ActivationNetwork bus = new AForge.Neuro.ActivationNetwork(new AForge.Neuro.BipolarSigmoidFunction(2), our_dat.Count, 10);
            bus.Randomize();
            AForge.Neuro.Learning.BackPropagationLearning learn = new AForge.Neuro.Learning.BackPropagationLearning(bus);
            learn.LearningRate = 0.4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_new_network();
            // add new btngan just for test
        }
    }
}
