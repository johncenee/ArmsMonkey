using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace ArmsMonkey
{
    internal class ArmsMonkeyMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Military;

        public override string BaseTower => TowerType.SniperMonkey;

        public override int Cost => 4050;

        public override string Description => "gun monkey";

        public override string DisplayName => "Arms Monkey";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
           var attackModel = towerModel.GetAttackModel();
           var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;
            towerModel.range = 50;
            attackModel.range = 50;
            weaponModel.rate = 0.27F;
            projectileModel.pierce = 1;
            projectileModel.GetDamageModel().damage = 4;
        }
    }
}
