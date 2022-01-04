using system;

namespace Week8_Lecture1_Exercise1
{
    class Shape
    {
        public void setRadius(int r)
        {
            radius = r;
        }
        protected double radius;
    }   

    class SphereArea:ShapeDetails
    {
        public double AreaofSphere()
        {
            return (4/3) * Math.PI * (radius * radius * radius);
        }
    }

    class program
    {
       static void main(string[] args)
       {
           SphereArea Sphere = new SphereArea();
           Sphere.setRadius(4);
           console.writeline(Sphere.AreaofSphere());
       } 
    }
}