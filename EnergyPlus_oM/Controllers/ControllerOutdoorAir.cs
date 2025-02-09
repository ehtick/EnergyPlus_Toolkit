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

////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.Adapters.EnergyPlus
////{
////public class Controller:OutdoorAir : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual node ReliefAirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node ReturnAirNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node MixedAirNodeName { get; set; } = new node;
////[Description("Outdoor air inlet node entering the first pre-treat component if any")]
////public virtual node ActuatorNodeName { get; set; } = new node;
////[Description("If there is a Mechanical Ventilation Controller (Controller:MechanicalVentilation), note")]
////public virtual real MinimumOutdoorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual real MaximumOutdoorAirFlowRate { get; set; } = new real;
////[Description("No description available")]
////public virtual choice EconomizerControlType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice EconomizerControlActionType { get; set; } = new choice;
////[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb")]
////public virtual real EconomizerMaximumLimitDry-BulbTemperature { get; set; } = new real;
////[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control type.")]
////public virtual real EconomizerMaximumLimitEnthalpy { get; set; } = new real;
////[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb")]
////public virtual real EconomizerMaximumLimitDewpointTemperature { get; set; } = new real;
////[Description("Enter the name of a quadratic or cubic curve which defines the maximum outdoor")]
////public virtual object-list ElectronicEnthalpyLimitCurveName { get; set; } = new object-list;
////[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control.")]
////public virtual real EconomizerMinimumLimitDry-BulbTemperature { get; set; } = new real;
////[Description("No description available")]
////public virtual choice LockoutType { get; set; } = new choice;
////[Description("No description available")]
////public virtual choice MinimumLimitType { get; set; } = new choice;
////[Description("Schedule values multiply the minimum outdoor air flow rate")]
////public virtual object-list MinimumOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("schedule values multiply the design/mixed air flow rate")]
////public virtual object-list MinimumFractionOfOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("schedule values multiply the design/mixed air flow rate")]
////public virtual object-list MaximumFractionOfOutdoorAirScheduleName { get; set; } = new object-list;
////[Description("Enter the name of a Controller:MechanicalVentilation object.")]
////public virtual object-list MechanicalVentilationControllerName { get; set; } = new object-list;
////[Description("Optional schedule to simulate "push-button" type economizer control.")]
////public virtual object-list TimeOfDayEconomizerControlScheduleName { get; set; } = new object-list;
////[Description("Optional field to enable modified outdoor air flow rates based on zone relative humidity.")]
////public virtual choice HighHumidityControl { get; set; } = new choice;
////[Description("Enter the name of the zone where the humidistat is located.")]
////public virtual object-list HumidistatControlZoneName { get; set; } = new object-list;
////[Description("Enter the ratio of outdoor air to the maximum outdoor air flow rate when modified air")]
////public virtual real HighHumidityOutdoorAirFlowRatio { get; set; } = new real;
////[Description("If No is selected, the outdoor air flow rate is modified any time indoor relative")]
////public virtual choice ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = new choice;
////[Description("BypassWhenWithinEconomizerLimits specifies that heat recovery")]
////public virtual choice HeatRecoveryBypassControlType { get; set; } = new choice;
////}
////}



