class Player
{
  public Rectangle Hitbox = new(360, 550, 80, 20);
  public Color Colour = Color.Black;
  public int Hitpoints = 100;
  public int HitpointsMax = 100;
  public int Level = 1;
  public int Exp = 0;
  public float Speed = 3;

  public void Update()
  {
    if (Raylib.IsKeyDown(KeyboardKey.Left)) Hitbox.X -= Speed;
    if (Raylib.IsKeyDown(KeyboardKey.Right)) Hitbox.X += Speed;
  }

  public void Draw()
  {
    Raylib.DrawRectangleRec(Hitbox, Colour);
  }
}
