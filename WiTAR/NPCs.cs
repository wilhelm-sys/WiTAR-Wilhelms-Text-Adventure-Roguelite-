using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{
    class NPCs
    {
        //Base template that all fightable objects are based on 

        protected string _name = "Default";
        protected int _id;
        protected int _level;
        protected int _HP;                  //current Hp Value
        protected int _base_HP;             //base Hp Value
        protected int _MP;                  //current MP value
        protected int _base_MP;             //base MP Value
        protected int _SP;                  //current Sp Value
        protected int _base_SP;             //base SP Value
        protected int _strengh;             //Current Strengh Stat
        protected int _base_strengh;        //Base Strengh Stat
        protected int _intelligence;        //Current Intelligence Stat
        protected int _base_intelligence;  //Base Intelligence Stat
        protected int _vigor;               //Current Vigor Stat
        protected int _base_vigor;          //Base Vigor Stat
        protected int _block;               //Block Value, decreases Hp loss by its Value
        protected int _wisdom;              //Current Vistom Value
        protected int _base_wisdom;         //Base Vistom Value
        protected int _barrier;             //Barrier Value, decreases MP loss by its Value
        protected int _agility;             //Current Agility
        protected int _base_agility;        //Base Agility
        protected int _critchance;          //Current Critchance
        protected int _base_critchance;     //Base Critchance
        protected List<Skills> skills = new List<Skills>();
        protected List<Items> items = new List<Items>();

        //initilizer
        public void StatInit(string name, int id, int level, int HP, int MP, int SP, int strengh, int intelligence, int vigor, int block, int wisdom, int barrier, int agility, int critchance)
        {
            _id = id;
            SETname(name);
            SETlevel(level);
            SETHP(HP);
            SETMP(MP);
            SETSP(SP);
            SETstrengh(strengh);
            SETintelligence(intelligence);
            SETvigor(vigor);
            SETblock(block);
            SETwisdom(wisdom);
            SETbarrier(barrier);
            SETagility(agility);
            SETBASEcritchance(critchance);
            BaseStatinit();
        }
        public void BaseStatinit()
        {
            _base_HP = _HP;
            _base_MP = _MP;
            _base_SP = _SP;
            _base_strengh = _strengh;
            _base_intelligence = _intelligence;
            _base_vigor = _vigor;
            _base_wisdom = _wisdom;
            _base_agility = _agility;
            _base_critchance = _critchance;
        }
        //SET befehle
        public void SETname(string name) { _name = name; }
        public void SETlevel(int level) { _level = level; }
        public void SETHP(int hp) { _HP = hp; }
        public void SETBASEHP(int hp) { _base_HP = hp; }
        public void SETMP(int mp) { _MP = mp; }
        public void SETBASEMP(int mp) { _base_MP = mp; }
        public void SETSP(int sp) { _SP = sp; }
        public void SETBASESP(int sp) { _base_SP = sp; }
        public void SETstrengh(int strengh) { _strengh = strengh; }
        public void SETBASEstrengh(int strengh) { _base_strengh = strengh; }
        public void SETintelligence(int intelligence) { _intelligence = intelligence; }
        public void SETBASEintelligence(int intelligence) { _base_intelligence = intelligence; }
        public void SETvigor(int vigor) { _vigor = vigor; }
        public void SETBASEvigor(int vigor) { _base_vigor = vigor; }
        public void SETblock(int block) { _block = block; }
        public void SETwisdom(int wisdom) { _wisdom = wisdom; }
        public void SETBASEwisdom(int wisdom) { _base_wisdom = wisdom; }
        public void SETbarrier(int barrier) { _barrier = barrier; }
        public void SETagility(int agility) { _agility = agility; }
        public void SETBASEagility(int agility) { _base_agility = agility; }
        public void SETcritchance(int critchance) {  _critchance = critchance; }
        public void SETBASEcritchance(int critchance) { _base_critchance = critchance; }
        //GET befehle
        public string GETname() { return _name; }
        public int GETlevel() { return _level; }
        public int GETHP() { return _HP; }
        public int GETBASEHP() { return _base_HP; }
        public int GETMP() { return _MP; }
        public int GETBASEMP() { return _base_MP; }
        public int GETSP() { return _SP; }
        public int GETBASESP() { return _base_SP; }
        public int GETstrengh() { return _strengh; }
        public int GETBASEstrengh() { return _base_strengh; }
        public int GETintelligence() { return _intelligence; }
        public int GETBASEintelligence() { return _base_intelligence; }
        public int GETvigor() { return _vigor; }
        public int GETBASEvigor() { return _base_vigor; }
        public int GETblock() { return _block; }
        public int GETwisdom() { return _wisdom; }
        public int GETBASEwisdom() { return _base_wisdom; }
        public int GETbarrier() { return _barrier; }
        public int GETagility() { return _agility; }
        public int GETBASEagility() { return _base_agility; }
        public int GETcritchance() {  return _critchance; }
        public int GETBASEchritchance() { return _base_critchance; }
        //Limit is here to make sure that the stats arent able to exceed their base or be less then 0
        public int LimitHP(int HP) { if (HP > _base_HP) return _base_HP; else if (HP < 0) return 0; return HP; }
        public int LimitMP(int MP) { if (MP > _base_MP) return _base_MP; else if (MP < 0) return 0; return MP; }
        public int LimitSP(int SP) { if (SP > _base_SP) return _base_SP; else if (SP < 0) return 0; return SP; }
        public int LimitSTAT(int stat) { if (stat < 0) return 0; return stat; }
        //Resets the Stat Changes, but not HP, MP and SP
        public void Resetstats()
        {
            _strengh = _base_strengh;
            _intelligence = _base_intelligence;
            _vigor = _base_vigor;
            _wisdom = _base_wisdom;
            _agility = _base_agility;
            _critchance = _base_critchance;
        }
    }
    class Player : NPCs
    {
        //This class is the player charcter
        protected List<Equipments> equipments = new List<Equipments>();
        //Increases the stat value in a range from 1 to incmax
        protected int StatUpCheck(int stat, int incmax)
        {
            Random random = new Random();
            int randomInt = random.Next(1, incmax);
            return stat + randomInt;
        }
        //sets the players default stats
        public void Player_init(string name="defaultplayer")
        {
            StatInit(name, 0,1, 20, 10, 30, 5, 5, 5, 0, 5, 0, 5, 5);
            /*ID: 0
             * Level 1
             * HP: 20
             * MP: 10
             * SP: 30
             * Strengh: 5
             * Intelligence: 5
             * Vigor: 5
             * Block: 0
             * Wisdom: 5
             * Barrier: 0
             * Agility: 5
             * Critchance: 5
             */
            skills.Add(new Attack());
            skills.Add(new Block());
            skills.Add(new Do_Nothing());
            skills.Add(new Flee());
        }
        //Allows the player to level up
        public void Level_Up()
        {
            SETlevel(_level+1);
            SETBASEHP(StatUpCheck(_base_HP, 10));
            SETBASEMP(StatUpCheck(_base_MP, 10));
            SETBASESP(StatUpCheck(_base_SP, 10));
            SETBASEstrengh(StatUpCheck(_base_strengh, 5));
            SETBASEintelligence(StatUpCheck(_base_intelligence, 5));
            SETBASEvigor(StatUpCheck(_base_vigor, 5));
            SETBASEwisdom(StatUpCheck(_base_wisdom, 5));
            SETBASEagility(StatUpCheck(_base_agility, 5));
        }
    }
    class Dummy : NPCs
    {
        public virtual void CreatureInit() {
            StatInit("Dummy", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            skills.Add(new Do_Nothing());
        } 
    }
    class Goblin : Dummy
    {
        public override void CreatureInit()
        {
            StatInit("Goblin", 1, 1, 10, 0, 10, 2, 1, 5, 0, 0, 0, 5, 10);
            skills.Add(new Attack());
            skills.Add(new Do_Nothing());
            skills.Add(new Evade());
        }
    }

}
