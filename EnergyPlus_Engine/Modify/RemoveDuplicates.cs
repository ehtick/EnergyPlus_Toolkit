/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *
 *
 * The BHoM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3.0 of the License, or
 * (at your option) any later version.
 *
 * The BHoM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.
 */

using BH.oM.Diffing;
using BH.oM.Adapters.EnergyPlus;
using BH.oM.Base.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BH.oM.Base;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Modify
    {
        [Description("Remove duplicate IEnergyPlusClass objects")]
        [Input("energyPlusClasses", "A list of EnergyPlus classes")]
        [Output("energyPlusClasses", "A list of EnergyPlus classes with duplicates removed")]
        public static List<IEnergyPlusClass> RemoveDuplicates(this List<IEnergyPlusClass> energyPlusClasses)
        {
            ComparisonConfig config = new ComparisonConfig()
            {
                 PropertyExceptions = new List<string>
                {
                    "BHoM_Guid",
                    "CustomData",
                },
                NumericTolerance = BH.oM.Geometry.Tolerance.Distance,
            };

            List<IEnergyPlusClass> hashedList = BH.Engine.Base.Modify.SetHashFragment<IEnergyPlusClass>(energyPlusClasses, config).ToList();

            List<IEnergyPlusClass> uniqueList = Diffing.Modify.RemoveDuplicatesByHash(hashedList).ToList();

            return uniqueList;
        }
    }
}



