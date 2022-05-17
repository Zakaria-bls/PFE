
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        
        int IDb = 1;
        int IDv =-1;
        int IDG = 0;
        public Form1()
        {
            InitializeComponent();
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.MinZoom = 6;
            map.MaxZoom = 100;
            map.Zoom = 6;
            map.Position = new PointLatLng(28.2026, 2.4878);

            map.OnMarkerClick += new MarkerClick(gOnMarkerClick);
            showdata.Hide();
            panel1.Hide();

        }


        //Function create point
        void createPoint(double x, double y, int id,GMarkerGoogleType z)
        {
            PointLatLng point = new PointLatLng(x, y);

            GMapMarker marker = new GMarkerGoogle(point, z);

            marker.Tag=id;

            GMapOverlay overlay = new GMapOverlay();

            overlay.Markers.Add(marker);

            map.Overlays.Add(overlay);

            marker.ToolTipText = String.Format("Marker ID = {0}", id);

            panel1.Show();

        }




        //OnClick Marker
        private void gOnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            showdata.Show();
            IDData.Text = item.Tag.ToString();


            SqlConnection conn = new SqlConnection("Data Source=ZAKARAI\\SQLEXPRESS;Initial Catalog=donnés;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("Select matricule, wilaya from show where id=@ID", conn);
            command.Parameters.AddWithValue("@ID", item.Tag);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                { 
                    MatriculeData.Text = reader["matricule"].ToString();
                    WilayaData.Text = reader["wilaya"].ToString();
                }
            }

            conn.Close();   


        }


        //Create point
        private void button1_Click(object sender, EventArgs e)
        {
            bool latitude = String.IsNullOrEmpty(textlat.Text);
            bool longtitude = string.IsNullOrEmpty(textlongt.Text);
            if (!latitude && !longtitude)
            {
                double x = Convert.ToDouble(textlat.Text);
                double y = Convert.ToDouble(textlongt.Text);
                map.Position = new PointLatLng(x, y);
                GMarkerGoogleType type = GMarkerGoogleType.blue;
               
                createPoint(x, y, IDb, type);
                IDG = IDb;
                map.Zoom = map.Zoom + 0.001;
            }
            else
            {
                MessageBox.Show("insert DATA");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            bool latitude = String.IsNullOrEmpty(textlat.Text);
            bool longtitude = string.IsNullOrEmpty(textlongt.Text);
            if (!latitude && !longtitude)
            {
                double x = Convert.ToDouble(textlat.Text);
                double y = Convert.ToDouble(textlongt.Text);
                map.Position = new PointLatLng(x, y);
                GMarkerGoogleType type = GMarkerGoogleType.green;

                
                createPoint(x, y,IDv, type);
                IDv--;
                IDG = IDv;

                map.Zoom = map.Zoom + 0.001;
            }
            else
            {
                MessageBox.Show("Insert DATA");
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textlat.Text);
            double y = Convert.ToDouble(textlongt.Text);
            bool matricule = String.IsNullOrEmpty(textm.Text);
            bool wilaya = string.IsNullOrEmpty(textw.Text);

            if (!matricule && !wilaya)
            {
                int mat = int.Parse(textm.Text);
                string wil = textw.Text;
                SqlConnection con = new SqlConnection("Data Source=ZAKARAI\\SQLEXPRESS;Initial Catalog=donnés;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into show(id, lat, longt, matricule, wilaya) values(@ID,@LAT, @LONGT, @MAT, @WIL)", con);
                cmd.Parameters.AddWithValue("@ID", IDG);
                cmd.Parameters.AddWithValue("@LAT", x); 
                cmd.Parameters.AddWithValue("@LONGT", y);
                cmd.Parameters.AddWithValue("@MAT", mat);
                cmd.Parameters.AddWithValue("@WIL", wil);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DATA ADDED");
                panel1.Hide();
                IDb++;
               
            }
            else
            {
                MessageBox.Show("Insert Data");
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            showdata.Hide();
        }

    }
}