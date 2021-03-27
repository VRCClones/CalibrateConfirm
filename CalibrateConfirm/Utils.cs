using System;
using UnityEngine;

namespace CalibrateConfirm
{
    internal static class Utils
    {
        // stolen from loukylor cuz i can't do math
        public static Vector3 ConvertToUnityUnits(Vector3 menuPosition)
        {
            menuPosition.y *= -1;
            return RoundTens(new Vector3(-1050, 1470) + menuPosition * 420);
        }

        public static int RoundTens(double i)
        {
            return ((int)Math.Round(i / 10.0)) * 10;
        }

        public static Vector3 RoundTens(Vector3 i)
        {
            return new Vector3(RoundTens(i.x), RoundTens(i.y), RoundTens(i.z));
        }
    }
}