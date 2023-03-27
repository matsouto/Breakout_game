namespace Breakout;

struct Vector2{
    public float X {get; set;} 
    public float Y {get; set;}
    private float length => (float)Math.Sqrt(X * X + Y * Y);

    //Constructor
    public Vector2(float X_coord, float Y_coord) {
        X = X_coord;
        Y = Y_coord;
    }

    //Operators
    public static Vector2 operator +(Vector2 v1, Vector2 v2) => new Vector2( v1.X + v2.X, v1.Y + v2.Y);
    public static Vector2 operator -(Vector2 v1, Vector2 v2) => new Vector2( v1.X - v2.X, v1.Y - v2.Y); 
    public static Vector2 operator *(Vector2 v1, float scalar) => new Vector2( v1.X * scalar, v1.Y * scalar);
    public static Vector2 operator /(Vector2 v1, float scalar) => new Vector2( v1.X / scalar, v1.Y / scalar);

    //Methods
    public static Vector2 normalize(Vector2 v1){
        return new Vector2(v1.X / Math.Abs(v1.length), v1.Y / Math.Abs(v1.length));
    } 

    public static float dot(Vector2 v1, Vector2 v2){
        return v1.X * v2.X + v1.Y * v2.Y; 
    }

}