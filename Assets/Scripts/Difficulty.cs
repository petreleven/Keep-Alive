using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty 
{
   static float timeToMaxDifficulty=60f;

   public static float GetDifficultyPercent()
   {
       
       return Mathf.Clamp01(Time.timeSinceLevelLoad/timeToMaxDifficulty);
   }
}
