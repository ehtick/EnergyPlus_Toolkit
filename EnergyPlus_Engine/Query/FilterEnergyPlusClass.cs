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

using BH.oM.Adapters.EnergyPlus;
using BH.oM.Base.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BH.Engine.Adapters.EnergyPlus
{
    public static partial class Query
    {
        [Description("Returns a collection of EnergyPlusClass objects that match the given ClassName")]
        [Input("energyPlusClasses", "A collection of EnergyPlusClass objects")]
        [Input("className", "The class name to filter by")]
        [Output("energyPlusClasses", "A collection of EnergyPlusClass objects that match the given ClassName")]
        public static List<IEnergyPlusClass> FilterEnergyPlusClassByClassName(this List<IEnergyPlusClass> energyPlusClasses, string className)
        {
            return energyPlusClasses.Where(x => x.ClassName == className).ToList();
        }
    }
}


