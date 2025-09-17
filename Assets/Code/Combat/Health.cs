using _01.Script.Entity;
using UnityEngine;

namespace _01.Script.Combat
{
    public class Health : MonoBehaviour, IEntityComponent
    {
        private Entity.Entity _entity;
        public int MaxHP { get; private set; } = 100;
        public int CurrentHP { get; private set; }

        public void Initialize(Entity.Entity entity)
        {
            _entity = entity;
            CurrentHP = MaxHP;
        }

        public void TakeDamage(int amount)
        {
            CurrentHP -= amount;
            if (CurrentHP <= 0) Die();
        }

        private void Die()
        {
            Debug.Log($"{_entity.name} 사망!");
            // _entity.SetDead(true); // 필요하면 Entity 쪽과 연동
        }
    }
}