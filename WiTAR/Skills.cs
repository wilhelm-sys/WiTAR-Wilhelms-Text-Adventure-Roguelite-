using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTAR
{

    class Skills
    {
        string skillname = "Default";
        
        public string GETskillname() {  return skillname; }
        public int CheckCrit(int critchance)
        {
            Random random = new Random();
            int randomInt = random.Next(1, 100);
            if (randomInt <= critchance) return 2;
            return 1;
        }
        public virtual int SkillEffect(int base1, int base2 ) {  return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3) { return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3, int base4) { return 0; }
        public virtual int SkillEffect(int base1, int base2, int base3, int base4, int base5) { return 0; }
    }
    class Attack : Skills
    {
        protected string skillname = "Attack";
        public override int SkillEffect(int strenghuser, int critchanceuser, int vigoropp, int blockopp) {
            
            return (strenghuser * CheckCrit(critchanceuser))-vigoropp-blockopp; 
        }
    }
    class Block : Skills {
        protected string skillname = "Block";
        public override int SkillEffect(int blockuser, int attack)
        {
            return blockuser - attack;
        }
        
    }
    class Evade : Skills{
        protected string skillname = "Evade";
        public override int SkillEffect(int agilityuser, int attack)
        {
            if(CheckCrit(agilityuser+20)==2) return 0; return attack;
        }
    }

}
