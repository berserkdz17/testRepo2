using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RPG_Simulator
{
    // GitHub testRepo2
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainPageForm MainPage = new MainPageForm();
            Application.Run(MainPage);
            
            
        }
    }
    public interface IReward
    {        
        int XPGained(int something, int somethingElse);
        int GoldGained();      
    }
    public abstract class Creature//Should include Player character, NPC characters and Monsters (monster characters)
    {
        protected string creatureType, name;        
             
        protected double str, dex, con, inte, wis, cha;
        protected int strM, dexM, conM, inteM, wisM, chaM;

        protected int fortitude, reflex, will;
        protected int bonusFortitude, bonusReflex, bonusWill;

        protected int ac, attackBonus, dmg, lvl, hitDie;
        protected double baseAttackRate;

        public int currentXp, bonusAttackBonus, bonusHP, hp, baseAttack;
        public string weaponType;

        protected int attackRoll, threatRoll, attackRolld20, threatRolld20, initiativeRolld20, initiative;
        
        //Constructor with modifier delegate
        public Creature()
        {
            ModifierDelegate modifier = new ModifierDelegate(Modify);           
        }
        
        //modifier delegate and method for fiding attribute modifier   
        public delegate int ModifierDelegate(double x);
        public int Modify(double a)
        {
            int b=(int)Math.Floor((a-10)/2);
            return b;
        }

        
        public int CalculateHP()
        {
            hp= (hitDie + conM) * lvl + bonusHP;
            return hp ;
        }
        public int CalculateAttackBonus()
        {
            attackBonus = baseAttack + strM + bonusAttackBonus;
            return attackBonus;
        }
        public virtual int CalculateDmg()
        {
            Random random = new Random();
            int r1d10 = random.Next(1, 11);
            int r1d8 = random.Next(1, 9);
            int r1d6=random.Next(1,7);
            int r1d4 = random.Next(1, 5);
            int r2d8 = random.Next(2, 17);
            int r2d6 = random.Next(2, 13);
            int r2d4 = random.Next(2, 9);


            if (weaponType == "Longsword") dmg = strM + r1d8;
            else if (weaponType == "Bastard Sword") dmg = strM + r1d10;
            else if (weaponType == "Shortsword") dmg = strM + r1d6;
            else if (weaponType == "Greatsword") dmg = strM + r2d6;

            else if (weaponType == "Dragon") dmg = strM + r2d8;
            else if (weaponType == "Ancient Dragon") dmg = strM + r2d8;
            else if (weaponType == "Wolf") dmg = strM + r1d6;
            else if (weaponType == "Fire Beetle") dmg = strM + r2d4;
            else if (weaponType == "Dire Bear") dmg = strM + r2d6;
            return dmg;
        }
        public int CalculateLvl()
        {
             for (int i = 1; i < 41; i++)
            {
                 int thisLvlXp=( ( ( (i-1) + 1) * (i-1) ) / 2) * 1000;
                 int nextLvlXp= ( ( (i + 1) * i) / 2) * 1000;
                 if (currentXp >= thisLvlXp && currentXp < nextLvlXp)
                 {
                     lvl=i;
                 }
            } 
            return lvl;
            
        }
        public int CalculateBaseAttack()
        {
            baseAttack=(int)(Math.Floor(lvl* baseAttackRate));
            return baseAttack;
        }
        public int CalculateFortitude()
        {
            fortitude = (int)strM + bonusFortitude;
            return fortitude;
        }
        public int CalculateReflex()
        {
            reflex = dexM + bonusReflex;
            return reflex;
            
        }
        public int CalculateWill()
        {
            return will = wisM + bonusWill;            
        }
        

        //properties
        #region Attributes
        public double Strength
        {
            get { return str; }
            set { str = value; }
        }
        public double Dexterity
        {
            get { return dex; }
            set { dex = value; }
        }
        public double Constitution 
        { 
            get { return con; } 
            set { con = value; }
        }
        public double Intelligence
        {
            get { return inte; }
            set { inte = value; }
        }
        public double Wisdom
        {
            get { return wis; }
            set { wis = value; }
        }
        public double Charisma
        {
            get { return cha; }
            set { cha = value; }
        }
        #endregion
        #region AttributeM
        public int StrengthM
        {
            get { return strM; }
            set { strM = value; }
        }
        public int DexterityM
        {
            get { return dexM; }
            set { dexM = value; }
        }
        public int ConstitutionM
        {
            get { return conM; }
            set { conM = value; }
        }
        public int IntelligenceM
        {
            get { return inteM; }
            set { inteM = value; }
        }
        public int WisdomM
        {
            get { return wisM; }
            set { wisM = value; }
        }
        public int CharismaM
        {
            get { return chaM; }
            set { chaM = value; }
        }
        #endregion
        
        
        public string CreatureType
        {
            get { return creatureType; }
            set { creatureType = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Fight methods
        public int AttackRolld20()
        {
            Random random = new Random();
            int d20 = random.Next(1, 21);
            attackRolld20 = d20;
            return attackRolld20;
        }
        public int ThreatRolld20()
        {
            Random random = new Random();
            int d20 = random.Next(1, 21);
            threatRolld20 = d20;
            return threatRolld20;
        }
        public int AttackRoll()
        {
            attackRoll = attackRolld20 + attackBonus;
            return attackRoll;
        }
        public int ThreatRoll()
        {
            threatRoll = attackBonus + threatRolld20;
            return threatRoll;
        }
        public virtual string Attack(int opponentAC, ref int opponentHp, string opponent)
        {
            string message = name + " attacks " + opponent + " :*";
            int critical = 2 * dmg;
#region if 20 rolled on attack roll            
            if (attackRolld20 == 20)
            {
                if (threatRoll >= (opponentAC - 20))
                {
                   //critical hit
                    opponentHp = opponentHp - critical;
                    message += "critical hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + " :Threat roll: " + attackBonus.ToString() + "+" +
                        threatRolld20.ToString() + "=" + threatRoll.ToString() + ")\r\n" + name + " damages " +
                        opponent + ": " + critical.ToString();
                }
                else 
                { 
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() +  ")\r\n" + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
#endregion            
            if (attackRoll >= opponentAC && attackRolld20!=20 && attackRolld20!=1)
            {
                if (attackRolld20 == 19)
                {
                    if (threatRoll >= (opponentAC - 20))
                    {
                        opponentHp = opponentHp - critical;
                        message += "critical hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                            "=" + attackRoll.ToString() + " :Threat roll: " + attackBonus.ToString() + "+" +
                            threatRolld20.ToString() + "=" + threatRoll.ToString() + ")\r\n"  +name + " damages " +
                            opponent + ": " + critical.ToString();
                    }
                    else
                    {
                        opponentHp = opponentHp - dmg;
                        message += "hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                            "=" + attackRoll.ToString() + ")\r\n" + name + " damages " +
                            opponent + ": " + dmg.ToString();
                    }
                }
                else
                {
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + ")\r\n" + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
            else if ((attackRoll < opponentAC || attackRolld20 == 1) &&attackRolld20 !=20)
            {
                message += "miss*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + ")";
            }
            return message;
        }
        public virtual string Attack2(int opponentAC, ref int opponentHp, string opponent, int penalty)
        {
            string message = name + " attacks " + opponent + " :*";
            int critical = 2 * dmg;
            #region if 20 rolled on attack roll
            if (attackRolld20 == 20)
            {
                if (threatRoll - penalty >= (opponentAC - 20))
                {
                    //critical hit
                    opponentHp = opponentHp - critical;
                    message += "critical hit*: (" + (attackBonus - penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll - penalty).ToString() + " :Threat roll: " + (attackBonus - penalty).ToString() + "+" +
                        threatRolld20.ToString() + "=" + (threatRoll-penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + critical.ToString();
                }
                else
                {
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + (attackBonus-penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll-penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
            #endregion
            if (attackRoll - penalty >= opponentAC && attackRolld20 != 20 && attackRolld20 != 1)
            {
                if (attackRolld20 == 19)
                {
                    if (threatRoll - penalty >= (opponentAC - 20))
                    {
                        opponentHp = opponentHp - critical;
                        message += "critical hit*: (" + (attackBonus-penalty).ToString() + "+" + attackRolld20.ToString() +
                            "=" + (attackRoll-penalty).ToString() + " :Threat roll: " + (attackBonus-penalty).ToString() + "+" +
                            threatRolld20.ToString() + "=" + (threatRoll-penalty).ToString() + ")\r\n " + name + " damages " +
                            opponent + ": " + critical.ToString();
                    }
                    else
                    {
                        opponentHp = opponentHp - dmg;
                        message += "hit*: (" + (attackBonus-penalty).ToString() + "+" + attackRolld20.ToString() +
                            "=" + (attackRoll-penalty).ToString() + ")\r\n " + name + " damages " +
                            opponent + ": " + dmg.ToString();
                    }
                }
                else
                {
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + (attackBonus-penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll-penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
            else if ((attackRoll - penalty < opponentAC || attackRolld20 == 1) && attackRolld20!=20 )
            {
                message += "miss*: (" + (attackBonus-penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll-penalty).ToString() + ")";
            }
            return message;
        }
        

        public int InitiativeRolld20()
        {
            Random random = new Random();
            int d20 = random.Next(1, 21);
            initiativeRolld20 = d20;
            return initiativeRolld20;

        }
        public int Initiative()
        {
            initiative = initiativeRolld20 + dexM;
            return initiative;
        }
        public string InitiativeMessage()
        {
            string message = name + "  :Initiative Roll: " + initiative.ToString() + " (" + 
                initiativeRolld20.ToString() +"+" + dexM.ToString() + "=" + initiative.ToString() + ")";
            return message;
        }

        //abstract methods
        public abstract int CalculateAC();
        
    }
    public class Player : Creature
    {
        string gender, race, classType, weaponDmgDisplay;
        int armor, bonusAC, dodgeAC, naturalAC, helmAC;
        int nextLvlXp;
        public int gold;

        //properties
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        public string ClassType
        {
            get { return classType; }
            set { classType = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public int DodgeAC
        {
            get { return dodgeAC; }
            set { dodgeAC = value; }
        }
        public int NaturalAC
        {
            get { return naturalAC; }
            set { naturalAC = value; }
        }
        public int HelmAC
        {
            get { return helmAC; }
            set { helmAC = value; }
        }
        
        public int BonusAC
        {
            get { return bonusAC; }
            set { bonusAC = value; }
        }

        public override int CalculateAC()
        {
            ac = dexM + armor + bonusAC +dodgeAC+naturalAC+helmAC +10;
            return ac;
        }

        public int CalculateHitDie()
        {
            switch (classType)
            {
                case "Fighter":
                    hitDie = 10;
                    break;
                case "Rogue":
                    hitDie = 6;
                    break;
                case "Wizard":
                    hitDie = 4;
                    break;
            }
            return hitDie;
        }
        public double CalculateBaseAttackRate()
        {
            switch (classType)
            {
                case "Fighter":
                    baseAttackRate = 1;
                    break;
                case "Rogue":
                    baseAttackRate = 0.75;
                    break;
                case "Wizard":
                    baseAttackRate = 0.5;
                    break;
            }
            return baseAttackRate;
        }
        public int NextLvlXp()
        {
            nextLvlXp = ((lvl+1)*lvl/ 2) * 1000;
            return nextLvlXp;
        }
        public string WeaponDmgDisplay()
        {
            if (weaponType == "Longsword") weaponDmgDisplay = "1-8";
            else if (weaponType == "Bastard Sword") weaponDmgDisplay = "1-10";
            else if (weaponType == "Shortsword") weaponDmgDisplay = "1-6";
            else if (weaponType == "Greatsword") weaponDmgDisplay = "2-12";
            return weaponDmgDisplay;
        }
    }
    public class Monster : Creature, IReward
    {
        int monsterLvl, monsterRank; 
        int xpGain,goldGain;        
        public Monster(string type, string name)
        {
            weaponType = type;
            this.name = name;
        }
        //Properties
        public int MonsterLvl
        {
            get { return monsterLvl; }
            set { monsterLvl = value; }
        }
        public int MonsterRank
        {
            get { return monsterRank; }
            set { monsterRank = value; }
        }
        public int AttackBonus
        {
            get { return attackBonus; }
            set { attackBonus = value; }
        }
        public int AC
        {
            get { return ac; }
            set { ac = value; }
        }

        //Interface methods
        public int XPGained(int playerLvl, int currentXP)
        {
            xpGain = (int)((double)monsterLvl / playerLvl * monsterRank * 100);

            int nextLvlXp = (playerLvl + 1) * playerLvl * 500;

            if (xpGain + currentXP > nextLvlXp) xpGain = nextLvlXp - currentXP;

            return xpGain;
        }
        public int GoldGained()
        {
            Random random=new Random();
            int r1=random.Next(0,49);
            int r2=random.Next(50,301);
            int r3=random.Next(2000,6001);
            int r4=random.Next(2000,5001);
            int r5=random.Next(5000,15001);
            if (monsterRank == 1) goldGain = r1;
            else if (monsterRank == 3) goldGain = r2;
            else if (monsterRank == 16) goldGain = r3;
            else if (monsterRank == 20) goldGain = r4;
            else goldGain = r5;
            return goldGain;
        }

        public override int CalculateAC()
        {
            ac = dexM;
            return ac;
        }

        //override of attack method
        public override string Attack(int opponentAC, ref int opponentHp, string opponent)
        {
            string message = name + " attacks " + opponent + " :*";
            int critical = 2 * dmg;
            #region if 20 rolled on attack roll
            if (attackRolld20 == 20)
            {
                if (threatRoll >= (opponentAC - 20))
                {
                    //critical hit
                    opponentHp = opponentHp - critical;
                    message += "critical hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + " :Threat roll: " + attackBonus.ToString() + "+" +
                        threatRolld20.ToString() + "=" + threatRoll.ToString() + ")\r\n" + name + " damages " +
                        opponent + ": " + critical.ToString();
                }
                else
                {
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + ")\r\n" + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
            #endregion
            if (attackRoll >= opponentAC && attackRolld20 != 20 && attackRolld20 != 1)
            {
                opponentHp = opponentHp - dmg;
                message += "hit*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + ")\r\n" + name + " damages " +
                        opponent + ": " + dmg.ToString();               
            }
            else if (attackRoll < opponentAC || attackRolld20 == 1)
            {
                message += "miss*: (" + attackBonus.ToString() + "+" + attackRolld20.ToString() +
                        "=" + attackRoll.ToString() + ")";
            }
            return message;
        }
        public override string Attack2(int opponentAC, ref int opponentHp, string opponent, int penalty)
        {
            string message = name + " attacks " + opponent + " :*";
            int critical = 2 * dmg;
            #region if 20 rolled on attack roll
            if (attackRolld20 == 20)
            {
                if (threatRoll - penalty >= (opponentAC - 20))
                {
                    //critical hit
                    opponentHp = opponentHp - critical;
                    message += "critical hit*: (" + (attackBonus - penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll - penalty).ToString() + " :Threat roll: " + (attackBonus - penalty).ToString() + "+" +
                        threatRolld20.ToString() + "=" + (threatRoll - penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + critical.ToString();
                }
                else
                {
                    opponentHp = opponentHp - dmg;
                    message += "hit*: (" + (attackBonus - penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll - penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + dmg.ToString();
                }
            }
            #endregion
            if (attackRoll - penalty >= opponentAC && attackRolld20 != 20 && attackRolld20 != 1)
            {
                opponentHp = opponentHp - dmg;
                message += "hit*: (" + (attackBonus - penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll - penalty).ToString() + ")\r\n " + name + " damages " +
                        opponent + ": " + dmg.ToString();
                
            }
            else if ((attackRoll - penalty < opponentAC || attackRolld20 == 1) && attackRolld20!=20 )
                
            {
                message += "miss*: (" + (attackBonus - penalty).ToString() + "+" + attackRolld20.ToString() +
                        "=" + (attackRoll - penalty).ToString() + ")";
            }
            return message;
        }
        
    }

}
