// Created by Crowbar 0.24.0.0

$modelname "player/items/all_class/halloween_bag_heavy_sniper.mdl"

$bodygroup "body"
{
	studio "halloween_bag_heavy_sniper_hbg_base.smd"
}
$bodygroup "hair"
{
	studio "sniper_twilight_sniper_hair.smd"
}

$cdmaterials "\models\player\sniper\"
$bodygroup "class"
{
	studio "halloween_bag_heavy_sniper_hbg_heavy_scout_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_sniper_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_soldier_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_demo_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_medic_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_heavy_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_pyro_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_spy_bodygroup.smd"
	studio "halloween_bag_heavy_sniper_hbg_heavy_engineer_bodygroup.smd"
}


$cdmaterials "\models\player\items\all_class\"
$cdmaterials ""

$surfaceprop "cloth"

$contents "solid"


// NOTE: The following commented-out $definebone lines might be needed, as is often the case for view models. When needed, simply remove the two slashes '//' from the start of each line.
// $definebone "bip_head" "" 0 0 0 -3.014559 0 0 0 0 0 0 0 0




$sequence "idle" "halloween_bag_heavy_sniper_anims\idle.smd" {
	fps 30
	loop
}

$collisionmodel "halloween_bag_heavy_sniper_physics.smd"
{
	$mass 5
	$inertia 1
	$damping 0
	$rotdamping 0

}

