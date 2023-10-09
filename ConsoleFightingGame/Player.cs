namespace PlayerLogic
{
    public class Player
    {
        int health = 0;
        int maxHealth = 100;

        int mana = 0;
        int MaxMana = 80;

        int xp = 0;
        int level = 0;
        int levelPoints = 0;

        char characterType;
        char elementAffiliation;

        int healthPotions = 0;
        int maxHealthPotions = 5;
        int manaPotions = 0;
        int maxManaPotions = 5;

        List<String> spells = new();

        public Player()
        {
            health = maxHealth;
            mana = MaxMana;
        }

        
        //Takes the players action with a char
        public void Action(char playerInput)
        {
            if(playerInput == '1')
            {
                UsePhysical(Console.ReadKey().KeyChar);
            }else if(playerInput == '2')
            {
                UseSpells(Console.ReadKey().KeyChar);
            }else if(playerInput == '3')
            {
                Console.WriteLine("1. Health Potion\n2. Mana Potion");
                UsePotions(Console.ReadKey().KeyChar);
            }else if(playerInput == '4')
            {
                Console.WriteLine("1. Perks"); 
            }
        }


        //Player decide which spell they would like to use
        public void UseSpells(char spellSelect)
        {

        }


        //Player can either attack, use spells or get a higher dodge chance
        public void UsePhysical(char physicalSelect)
        {

        }


        //Uses healthpotions or manapotions
        public void UsePotions(char potionSelect)
        {

        }


        //Takes in a enemys damage in a parameter and puts takes away from health
        public int TakeDamage(int damage)
        {

            return health;
        }


        //Shows the player perks and if they can get them
        public void Perks()
        {

        }


        //Takes in the base xp from enemies killed and adds it to player xp (multipliers)
        public int GetXp(int baseXp)
        {
            return xp;
        }
    }
}