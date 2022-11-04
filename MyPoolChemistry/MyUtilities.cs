using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoolChemistry
{
    internal class MyUtilities
    {
        static float CalculatePhDelta(float phCurrent)
        {

            float phDelta = 7.5f - phCurrent;
            return phDelta;
        }

        //phAdd amount of soda ash/baking soda to add to pool
        //5.3oz of baking soda should increase pH 0.1 per 10000 gallons of water

        static float CalculatePhAdd(float phDelta, int poolVolume)

        {
            float phAdd = phDelta * 5.3f * poolVolume / 10000;
            return phAdd;
        }

        //phSub amount of Mureatic acid required to drop pH to 7.5
        //16oz of Mureatic acid required to drop pH 0.1 per 10000 gallons of water

        static float CalculatePhSub(float phDelta, int poolVolume)
        {
            float phSub = phDelta * 16 * poolVolume / 10000;
            return phSub;
        }

        //Ideal total Chlorine should be 3 ppm
        //Ideal free Chlorine should be 1 ppm

        static float CalculateChlorineDelta(float totalChlorine)
        {
            float chlorineDelta = 1 - totalChlorine;
            return chlorineDelta;
        }

        //0.00013oz chlorine per gallon required to increase 1 ppm

        static float CalculateChlorineAdd(float chlorineDelta, int poolVolume)
        {
            float chlorineAdd = chlorineDelta * 0.00013f * poolVolume / 10000;
            return chlorineAdd;
        }

        public static 

        //Total alkalinity ideal 80-120 ppm
        //lower alk with sodium Bisulphate  12.8oz/5000gal for 10ppm drop
        //Raise alk with sodium Bicarbonate 0.75lbs/5000gal for 10ppm rise
        //Calcium hardness ideal 200-400 ppm
        //Raise Hardness with Calcium Chloride 10oz/5000gal for 10ppm rise
        //Cyanuric Acid ideal 20-50 ppm
        //Shock values to 30ppm
        //Di-Chlor 56% - 2.1lbs/5000gal
        //Cal Hypo 65% - 1.8lbs/5000gal
        //Cal Hypo 73% - 1.65lbs/5000gal


    }
}
