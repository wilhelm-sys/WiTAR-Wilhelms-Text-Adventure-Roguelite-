using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{

    class Skills
    {
        string _skillname = "Default";
        string _skilldesc = "Default skill description";
        public Skills SETskill() { return this; }
        
        public string GETskillname() {  return _skillname; }
        public string GETskilldesc() {  return _skilldesc; }
        public int CheckCrit(int critchance)
        {
            Random random = new Random();
            int randomInt = random.Next(1, 100);
            if (randomInt <= critchance) return 2;
            return 1;
        }
        public virtual int SkillEffect() {  return 0; }
        public virtual int SkillEffect(int base1) { return 0; }
        public virtual int SkillEffect(int base1, int base2 ) {  return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3) { return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3, int base4) { return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3, int base4, int base5) { return 0; }
    }
    class Do_Nothing : Skills
    {
        protected string _skillname = "Do Nothing";
        protected string _skilldesc = "Does Nothing.";
    }
    class Attack : Skills
    {
        protected string _skillname = "Attack";
        protected string _skilldesc = "Deal damage to your opponent by your strengh stat minus their vigor and block.";
        public override int SkillEffect(int strenghuser, int critchanceuser, int vigoropp, int blockopp) {
            
            return (strenghuser * CheckCrit(critchanceuser))-vigoropp-blockopp; 
        }
    }
    class Block : Skills {
        protected string _skillname = "Block";
        protected string _skilldesc = "Reduce the next strengh based attack by twice your block.";
        public override int SkillEffect(int blockuser, int attackphy)
        {
            return blockuser - attackphy;
        }
        
    }
    class Evade : Skills{
        protected string _skillname = "Evade";
        protected string _skilldesc = "Evade the next strengh based attack with a 20% chance + your agility stat.";
        public override int SkillEffect(int agilityuser, int attackphy)
        {
            if(CheckCrit(agilityuser+20)==2) return 0; return attackphy;
        }
    }
    class Flee : Skills{
        protected string _skillname = "Flee";
        protected string _skilldesc = "Flee from the battle. The chance is 50% + the difference of Level between you and the target times 10.";
        public override int SkillEffect(int leveluser, int levelopp)
        {
            if (CheckCrit(50 + ((leveluser - levelopp) * 10)) == 2) return 1; return 0;
        }

    }

}
