using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ProiectMDS
{
    public class ParkingPlace
    {
        public string Name { get; set; }
        public PointLatLng Location { get; set; }

        public ParkingPlace(string name, PointLatLng location)
        {
            Name = name;
            Location = location;
        }
    }
    public partial class MapForm : Form
    {
        private GMapControl mapControl;
        private List<ParkingPlace> parkingPlaces;

        private Form1 form1;

        public MapForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            InitializeMap();
        }

        private void InitializeMap()
        {
            mapControl = new GMapControl();
            mapControl.Dock = DockStyle.Fill;
            mapControl.MapProvider = GMapProviders.GoogleMap;
            mapControl.Position = new PointLatLng(44.435506, 26.102497); 
            mapControl.MinZoom = 1;
            mapControl.MaxZoom = 20;
            mapControl.Zoom = 15;
            mapControl.MouseClick += new MouseEventHandler(MapControl_MouseClick);

            this.Controls.Add(mapControl);

            parkingPlaces = new List<ParkingPlace>
            {
                new ParkingPlace("ParcareA", new PointLatLng(44.436188, 26.096496)),
                new ParkingPlace("ParcareB", new PointLatLng(44.437904, 26.106281)),
                new ParkingPlace("ParcareC", new PointLatLng(44.433821, 26.106255))
            };

            foreach (var place in parkingPlaces)
            {
                AddMarker(place);
            }
        }

        private void AddMarker(ParkingPlace place)
        {
            var marker = new GMarkerGoogle(place.Location, GMarkerGoogleType.green_dot);
            var markers = new GMapOverlay("markers");
            marker.ToolTipText = place.Name;
            marker.ToolTipMode = MarkerTooltipMode.Always;
            markers.Markers.Add(marker);
            mapControl.Overlays.Add(markers);
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = mapControl.FromLocalToLatLng(e.X, e.Y);
                CalculateDistances(point);
            }
        }

        private void CalculateDistances(PointLatLng userPoint)
        {
            double shortestDistance = double.MaxValue;
            ParkingPlace nearestPlace = null;

            foreach (var place in parkingPlaces)
            {
                double distance = GetDistance(userPoint, place.Location);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestPlace = place;
                }
            }

            if (nearestPlace != null)
            {
                switch (nearestPlace.Name)
                {
                    case "ParcareA":
                        form1.GA--;
                        form1.RA++;
                        break;
                    case "ParcareB":
                        form1.GB--;
                        form1.RB++;
                        break;
                    case "ParcareC":
                        form1.GB--;
                        form1.RC++;
                        break;
                }

                MessageBox.Show($"The nearest parking place is {nearestPlace.Name} at {nearestPlace.Location.Lat}, {nearestPlace.Location.Lng} with a distance of {shortestDistance} meters.");
            }
        }





        private double GetDistance(PointLatLng point1, PointLatLng point2)
        {
            var rlat1 = Math.PI * point1.Lat / 180;
            var rlat2 = Math.PI * point2.Lat / 180;
            var theta = point1.Lng - point2.Lng;
            var rtheta = Math.PI * theta / 180;
            var dist = Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) * Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;
            dist = dist * 1609.344; // Convertire in metri
            return dist;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
        }
    }
}
