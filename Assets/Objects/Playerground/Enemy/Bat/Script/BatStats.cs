﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatStats : Stats
{
    protected override void Initialize(){
        if (hp < 0){ hp = 0;}
        if (hp == 0){
            hp = 20;
        }
        if (mp < 0){ mp = 0;}
        if (mp == 0){
            mp = 10;
        }
        if (dmg < 0){ dmg = 0;}
        if (dmg == 0){
            dmg = 10;
        }
        if (spe < 0){ spe = 0;}
        if (spe == 0){
            spe = 10;
        }
    }
}
