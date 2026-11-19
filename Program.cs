using _58_Weapon_Blueprint_Const_vs_Readonly;

Weapon sword = new Weapon("Dull Iron Sword", 15);

Console.WriteLine("Weapon Created\n");
Console.WriteLine($"Name: {sword.Name}");
Console.WriteLine($"Damage: {sword.Damage}");
Console.WriteLine($"Weapon ID: {sword.WeaponId}");
Console.WriteLine($"Created Date: {sword.CreatedDate:yyyy-MM-dd}");        

Console.WriteLine($"Max Level: {Weapon.MAX_WEAPON_LEVEL}");





//1.When should you use const?

//When a value is known at compile time and should never change, such as the maximum weapon level.

//2. When should you use readonly?

//When a field needs to be initialized when an object is created but should not be reassigned afterward, such as a weapon's ID or creation date.

//3. Why can readonly be set in a constructor but const cannot?

//Because readonly supports runtime initialization, while const requires a compile-time constant value.