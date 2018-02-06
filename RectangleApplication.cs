Using System;

namespace RectangleApplication
{
    class Rectangle{
        //member variables
        double length;
        double width;

        public void Acceptdetails(){
            length = 4.5;
            width = 3.5;
        }//End method Acceptdetails

        public double GetArea(){
            return length * width;
        }// End method GetArea

        public void Display(){
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }//end method Display
    } //End class Rectangle

    class ExcuteRectangle{
        static void Main(string []args){
            Rectangle rc = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        } //End Main
    } // End ExcuteRectangle
}//End namespace RectangleApplication