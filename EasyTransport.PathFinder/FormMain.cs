using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTransport.Data;

namespace EasyTransport.PathFinder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var routesThroughStop1 = new List<int>() {2, 3};
            //var routesThroughStop2 = new List<int>() {4, 5};
            //var addRoutes = new List<List<int>> { new List<int>() };
            //var additionPoints = new List<List<int>>()
            //{
            //    new List<int>() {6, 7, 8},
            //    new List<int>() {1, 2, 3},
            //    new List<int>() {5, 11}
            //};
            //foreach (var additionPoint in additionPoints)
            //{
            //    var tempRoutes = new List<List<int>>();
            //    foreach (var addRoute in addRoutes)
            //    {
            //        var pointRoutes = additionPoint;
            //        foreach (var route in pointRoutes)
            //        {
            //            var tempRoute = new List<int>(addRoute) { route };
            //            tempRoutes.Add(tempRoute);
            //        }
            //    }
            //    addRoutes = tempRoutes;
            //}
            //var a = 0;
        }
    }
}
