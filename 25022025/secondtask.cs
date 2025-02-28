using System;

public class Vector3D
{
    public double X; public double Y; public double Z;

    public Vector3D(double x, double y, double z)
    {
        X = x; Y = y; Z = z;
    }

    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }

    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector3D operator -(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector3D operator /(Vector3D v1, int value)
    {
        if (value != 0)
        {
            return new Vector3D(v1.X / value, v1.Y / value, v1.Z / value);
        }
        return v1;
    }

    public static bool operator ==(Vector3D v1, Vector3D v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vector3D v1, Vector3D v2)
    {
        return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;
    }

    public override bool Equals(object obj)
    {
        if(obj is  Vector3D other)
        {
            return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Z.GetHashCode();
    }
    public static bool operator true(Vector3D vec)
    {
        if(vec.X == 0 && vec.Y == 0 && vec.Z == 0)
        {
            return false;
        }
        return true;
    }

    public static bool operator false(Vector3D vec)
    {
     if(vec.X == 0 && vec.Y == 0 && vec .Z == 0)
        {
            return false;
        }
     return true;
    }

}

class Program1
{
    static void Main()
    {
        Vector3D vector = new Vector3D(1.56, 1.89, 1.3);
        Vector3D vector1 = new Vector3D(8.45, 4.56, 3.2);
        Console.WriteLine(vector.ToString());
        Console.WriteLine(vector1.ToString());
        Console.WriteLine(vector + vector1);
        Console.WriteLine(vector - vector1);
        Console.WriteLine(vector / 0);
        Console.WriteLine(vector == vector1);
        Console.WriteLine(vector.Equals(vector1));
    }
}
