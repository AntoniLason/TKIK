﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKIK
{
    class Renderer
    {

        private const string _TemplatePath = "template.html";

        public void Run(MapVisitor visitor, int width, int height, bool withOpen)
        {
            var fileName = System.DateTime.Now.ToString("dd_MM_yyyy__HH_mm_ss");
            var path = fileName + ".html";

            var pointsData = visitor.getPoints();

            var normalizedPointsData = NormalizePoints(pointsData, (float)width, (float)height);

            var areasData = visitor.getAreas();
            var buildingsData = visitor.getBuildings();
            var roadsData = visitor.getRoads();
            
            var template = System.IO.File.ReadAllText(_TemplatePath);
            template = template.Replace("#FILENAME", fileName);
            template = template.Replace("#WIDTH", width.ToString());
            template = template.Replace("#HEIGHT", height.ToString());
            template = template.Replace("#POINTS", ProcessPoints(normalizedPointsData));
            template = template.Replace("#AREAS", ProcessAreas(areasData));
            template = template.Replace("#ROADS", ProcessRoads(roadsData));
            template = template.Replace("#BUILDINGS", ProcessBuildings(buildingsData));

            System.IO.File.WriteAllText(path, template);

            if (withOpen)
            {
                Open(path);
            }
        }

        private Dictionary<string, float[]> NormalizePoints(Dictionary<string, Coordinate> points, float width, float height)
        {
            var result = new Dictionary<string, float[]>();

            var minX = float.MaxValue;
            var minY = float.MaxValue;
            var maxX = float.MinValue;
            var maxY = float.MinValue;

            foreach(var point in points)
            {
                var x = (float)point.Value.getx();
                var y = (float)point.Value.gety();
                if (x < minX)
                    minX = x;
                if (x > maxX)
                    maxX = x;
                if (y < minY)
                    minY = y;
                if (y > maxY)
                    maxY = y;
            }

            var sizeX = maxX - minX;
            var sizeY = maxY - minY;

            foreach(var point in points)
            {
                var value = new float[2];
                value[0] = (int)(((((float)point.Value.getx()) - minX) / sizeX) * width);
                value[1] = (int)(((((float)point.Value.gety()) - minY) / sizeY) * height);
                result.Add(point.Key, value);
            }

            return result;
        }

        private string ProcessPoints(Dictionary<string, float[]> points)
        {
            var result = string.Empty;
            foreach(var p in points)
            {
                var r = string.Format(
                    "x:{0},y:{1}",
                    p.Value[0],
                    p.Value[1]
                    );
                result += "var " + p.Key + " = {" + r + "};";
                result += System.Environment.NewLine;
            }
            return result;
        }
        private string ProcessRoads(Dictionary<string, Road> roads)
        {
            var result = string.Empty;
            foreach(var r in roads)
            {
                result += string.Format(
                    "drawRoad({0}, {1}, 'blue');",
                    r.Value.getFrom(),
                    r.Value.getTo());
                result += System.Environment.NewLine;
            }
            return result;
        }
        private string ProcessBuildings(Dictionary<string, Building> buildings)
        {
            var result = string.Empty;
            foreach(var b in buildings)
            {
                var points = string.Empty;
                var nodes = b.Value.getNodes();
                for(var i = 0; i < nodes.Count; i++)
                {
                    var last = i == nodes.Count-1;
                    if (last)
                    {
                        points += nodes[i];
                    } else
                    {
                        points += nodes[i] + ",";
                    }
                }

                result += string.Format(
                    "drawArea([{0}], 'red');",
                    points);
                result += System.Environment.NewLine;
            }
            return result;
        }
        private string ProcessAreas(Dictionary<string, Area> areas)
        {
            var result = string.Empty;
            foreach(var a in areas)
            {
                var points = string.Empty;
                var nodes = a.Value.getNodes();
                for(var i = 0; i < nodes.Count; i++)
                {
                    var last = i == nodes.Count-1;
                    if (last)
                    {
                        points += nodes[i];
                    } else
                    {
                        points += nodes[i] + ",";
                    }
                }

                result += string.Format(
                    "drawArea([{0}], 'red');",
                    points);
                result += System.Environment.NewLine;
            }
            return result;
        }

        private void Open(string resultFilePath)
        {
            System.Diagnostics.Process.Start(resultFilePath);
        }
    }
}
