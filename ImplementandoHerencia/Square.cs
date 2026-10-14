public class Square : Rectangle
{
    public Square() : base(){}

    public Square(double side) : base(side, side){}

    public Square(double side, string color, bool filled) : base(side, side, color, filled){}

    public double GetSide(){
        return GetWidth(); 
    }

    public void SetSide(double side){
        SetWidth(side);
        SetLength(side);
    }

    public override void SetWidth(double side){
        SetSide(side);
    }

    public override void SetLength(double side){
        SetSide(side);
    }

    public override string ToString(){
        return $"A Square with side = {GetWidth()}, which is a subclass of {base.ToString()}";
    }
}