using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertReceiptToText.Model
{
    public class Receipt
    {
        public string? locale { get; set; }
        public string description { get; set; }
        public BoundingPoly? boundingPoly { get; set; }
    }
    public class BoundingPoly
    {
        public List<Vertices> vertices { get; set; }
    }
    public class Vertices
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
