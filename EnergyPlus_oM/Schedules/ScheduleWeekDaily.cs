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

using BH.oM.Base;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection;

namespace BH.oM.Adapters.EnergyPlus
{
    public class ScheduleWeekDaily : BHoMObject, IEnergyPlusClass
    {
        [Description("The EnergyPlus Class name for the object - serialised to the IDF string. DO NOT CHANGE THIS VALUE.")]
        public virtual string ClassName { get; set; } = "Schedule:Week:Daily";
        [Order]
        [Description("No description available")]
        public override string Name { get; set; } = "DefaultWeeklySchedule";
        [Order]
        [Description("No description available")]
        public virtual string SundayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string MondayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string TuesdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string WednesdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string ThursdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string FridayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string SaturdayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string HolidayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string SummerDesignDayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string WinterDesignDayScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CustomDay1ScheduleDayName { get; set; } = "";
        [Order]
        [Description("No description available")]
        public virtual string CustomDay2ScheduleDayName { get; set; } = "";
    }
}



