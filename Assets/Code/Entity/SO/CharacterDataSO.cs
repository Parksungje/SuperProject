using UnityEngine;
using UnityEngine.Serialization;

namespace _01.Script.Entity.SO
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "SO/Combat/Character Data", order = 0)]
    public class CharacterDataSO : ScriptableObject
    {
        public string characterName;
        public int maxHp;
        public int attack;
        public int defense;
        public int extraAttack; //속공
    }
}