public class Rectangle : Shape{
    private double width;
    private double length;

    public Rectangle() : base(){
        this.width = 1.0;
        this.length = 1.0;
    }

    public Rectangle(double width, double length) : base(){
        this.width = width;
        this.length = length;
    }

    public Rectangle(double width, double length, string color, bool filled) : base(color, filled){
        this.width = width;
        this.length = length;
    }

    public double GetWidth(){
        return width;
    }

    public virtual void SetWidth(double width){
        this.width = width;
    }

    public double GetLength(){
        return length;
    }

    public virtual void SetLength(double length){
        this.length = length;
    }

    public double GetArea(){
        return width * length;
    }

    public double GetPerimeter(){
        return 2 * (width + length);
    }

    public override string ToString(){
        return $"A Rectangle with width = {width} and length = {length}, which is a subclass of {base.ToString()}";
    }
}