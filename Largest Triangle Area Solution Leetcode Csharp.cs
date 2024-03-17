namespace Largest_Triangle_Area_Solution_Leetcode_Csharp
{
    internal class Program
    {
        public double LargestTriangleArea(int[][] points)
        {
            var n = points.Length; //var n is equal to the length of points
            var max = 0.0; //max is equal to 0
            for (var i = 0; i < n; i++) //create for loops for three variables which are incremented by 1
            {
                for (var j = i + 1; j < n; j++)
                {
                    for (var k = j + 1; k < n; k++)
                    {
                        var area = Area(points[i], points[j], points[k]); //we used the Area function to find the max area possible of the points
                        if (area > max)
                        {
                            max = area; //if we get a new highest area we set it as max
                        }
                    }
                }
            }
            return max;
        }

        double Area(int[] p0, int[] p1, int[] p2) //function to find triangle area
        {
            var v1x = p1[0] - p0[0]; //we find the distance between the points!
            var v1y = p1[1] - p0[1];
            var v2x = p2[0] - p0[0];
            var v2y = p2[1] - p0[1];
            return Math.Abs(v1x * v2y - v1y * v2x) / 2.0; //and use a formula to calculate area
        }
    }
}