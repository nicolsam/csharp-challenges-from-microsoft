int warriorLifePoints = 10;
int monsterLifePoints = 10;

Random randomNumber = new Random();

do
{
    if(warriorLifePoints > 0)
    {
        int warriorRoundDamage = randomNumber.Next(1, 11);
        monsterLifePoints = monsterLifePoints - warriorRoundDamage;

        Console.WriteLine($"O monstro levou uma porrada de {warriorRoundDamage} e agora possui {monsterLifePoints} pontos de vida!");
    }

    if(monsterLifePoints > 0)
    {
        int monsterRoundDamage = randomNumber.Next(1, 11);
        warriorLifePoints = warriorLifePoints - monsterRoundDamage;

        Console.WriteLine($"O nosso herói levou uma porrada de {monsterRoundDamage} e agora possui {warriorLifePoints} pontos de vida!");
    } 


} while (
    warriorLifePoints > 0 &&
    monsterLifePoints > 0
);

if(warriorLifePoints == 0)
{
    Console.WriteLine("Nosso guerreiro foi de F.");
    Console.WriteLine($"O monstro ganhou com {monsterLifePoints} pontos de vida restantes.");
}

if(monsterLifePoints == 0)
{
    Console.WriteLine("O monstro morreu. O guerreiro salvou o reino das garras sujas e impiedosas do monstro censurador.");
    Console.WriteLine($"O guerreiro ganhou com {warriorLifePoints} pontos de vida restantes.");
}