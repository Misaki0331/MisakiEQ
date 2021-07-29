using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpMap;
using SharpMap.Layers;
using SharpMap.Data.Providers;
using System.IO;

namespace MisakiEQ.Map
{
    public class MapDrawing
    {
        double longitude;
        double latitude;
        double zoom;
        Size ImageSize;
        SharpMap.Map _Map;
        string fileName="";
        public MapDrawing()
        {
            Init(35.6895014, 139.6917337,1);
            ImageSize = new Size(800, 600);
        }
        ~MapDrawing()
        {
            _Map.Dispose();
            this.Dispose();
            
        }
        public void Dispose()
        {
            File.Delete($"{fileName}.shp");
            File.Delete($"{fileName}.shx");
            File.Delete($"{fileName}.cpg");
            File.Delete($"{fileName}.dbf");
            File.Delete($"{fileName}.shp.sidx");
        }
        MapDrawing(double lon, double lat, double size)
        {
            Init(lon, lat, size);
        }
        void Init(double lon, double lat, double size)
        {
            longitude = lon;
            latitude = lat;
            zoom = size;
            var t = DateTime.Now.Ticks;
            fileName = $"{Path.GetTempPath()}[{t}]_Land";
            _Map = new SharpMap.Map(new Size(800, 600));
            _Map.BackColor = Color.DarkBlue;
            
            var writer = new BinaryWriter(new FileStream($"{fileName}.shp", FileMode.Create));
            writer.Write(Properties.Resources.map_land);
            writer.Close();
            writer = new BinaryWriter(new FileStream($"{fileName}.dbf", FileMode.Create));
            writer.Write(Properties.Resources.map_landd);
            writer.Close();
            writer = new BinaryWriter(new FileStream($"{fileName}.shx", FileMode.Create));
            writer.Write(Properties.Resources.map_landx);
            writer.Close();
            VectorLayer baseLayer = new VectorLayer("行政区域");
            if (!File.Exists($"{fileName}.shp")) throw new FileNotFoundException($"ファイル作成エラー {fileName}.shp");
            Console.WriteLine(fileName);
            baseLayer.DataSource = new ShapeFile($"{fileName}.shp",true);
            baseLayer.Style.Fill = Brushes.GreenYellow;
            //地図にレイヤを追加
            _Map.Layers.Add(baseLayer);
            //地図全体が表示されるようにズーム率を設定
            _Map.ZoomToExtents();
            GeoAPI.Geometries.Coordinate P1 = new GeoAPI.Geometries.Coordinate((140.0 + 6), (44.0 - 4)); //_Map.ImageToWorld(new PointF(100, 100));
            _Map.Zoom = 90;
            _Map.Center = P1;

            zoom = _Map.Zoom;

            

        }
        public void ReSize(int x,int y)
        {
            _Map.Size = new Size(x, y);
            
            _Map.ZoomToExtents();
            GeoAPI.Geometries.Coordinate P1 = new GeoAPI.Geometries.Coordinate((140.0 + 6), (44.0 - 4)); //_Map.ImageToWorld(new PointF(100, 100));
            _Map.Zoom = 90;
            _Map.Center = P1;

            zoom = _Map.Zoom;
        }
        public Image GetMapImage()
        {
            return _Map.GetMap();
            }
        public void Move(double lon, double lat) //緯度 経度
        {
            longitude = lon;
            latitude = lat;
        }
        public void Draging(Point Pos)
        {
            Pos = new Point(Pos.X * -1, Pos.Y * -1);
            _Map.Center = _Map.ImageToWorld(new Point(_Map.Size.Width / 2 + Pos.X, _Map.Size.Height / 2 + Pos.Y));
        }
        public void Zoom(double size)
        {
            zoom = size;
            _Map.Zoom = zoom;
        }
        public double GetZoom()
        {
            return zoom;
        }
    }
}
