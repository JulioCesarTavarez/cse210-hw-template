class Cirlce 
{
    private double _radius;

    public Cirlce(double r) {_radius = r;}
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}