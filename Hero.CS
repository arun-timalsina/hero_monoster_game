//Simple hero monoster game using while loop and random number from class Random.

int hero;
int monster;

Random random = new();
int heroHealth = 100;
int monsterHealth = 100;

while (heroHealth >= 0 && monsterHealth >= 0)
{
    hero = random.Next(0, 11);
    

    monster = random.Next(0, 11);
    
    
    heroHealth -= monster;

    Console.WriteLine($"Hero was damaged by {monster} health and now has {heroHealth} health.\n");
    // Console.WriteLine($"Monster rolls: {monster}");
    
    // Console.WriteLine($"Hero Health: {heroHealth}");
    
    monsterHealth -= hero;
    Console.WriteLine($"Monster was damaged by {hero} health and now has {monsterHealth} health.\n");

}

if (heroHealth >= 0 && monsterHealth <= 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}