// global using Raylib_cs;

// Raylib.InitWindow(800, 600, "Klasstest");
// Raylib.SetTargetFPS(60);

// Player player = new();

// while(!Raylib.WindowShouldClose())
// {
//   player.Update();

//   Raylib.BeginDrawing();
//   Raylib.ClearBackground(Color.SkyBlue);

//   player.Draw();

//   Raylib.EndDrawing();
// }


Fighter f1 = new();
Fighter f2 = new();

f2.Attack(f1);

class Fighter
{
  int _hp = 100;
  int _minDamage = 2;
  int _maxDamage = 10;
  int _dafense = 2;

  public void Attack(Fighter target)
  {
    int damage = Random.Shared.Next(_minDamage, _maxDamage);
    target.Hurt(damage);
  }

  public void Hurt(int amount)
  {
    _hp -= amount - _dafense;
    if (_hp < 0)
    {
      _hp = 0;
    }
  }
}