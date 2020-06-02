////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class AirTerminal:SingleDuct:VAV:Reheat : BHoMObject
////{
////[Description("No description available")]
////public virtual null Name { get; set; } = new null;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("the outlet node of the damper and the inlet node of the reheat coil")]
////public virtual node DamperAirOutletNodeName { get; set; } = new node;
////[Description("the inlet node to the terminal unit and the damper")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual null MaximumAirFlowRate { get; set; } = new null;
////[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rate)")]
////public virtual choice ZoneMinimumAirFlowInputMethod { get; set; } = new choice;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Constant")]
////public virtual real ConstantMinimumAirFlowFraction { get; set; } = new real;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate.")]
////public virtual real FixedMinimumAirFlowRate { get; set; } = new real;
////[Description("This field is used if the field Zone Minimum Air Flow Input Method is Scheduled")]
////public virtual object-list MinimumAirFlowFractionScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual choice ReheatCoilObjectType { get; set; } = new choice;
////[Description("No description available")]
////public virtual object-list ReheatCoilName { get; set; } = new object-list;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual null MaximumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("Not used when reheat coil type is gas or electric")]
////public virtual null MinimumHotWaterOrSteamFlowRate { get; set; } = new null;
////[Description("The outlet node of the terminal unit and the reheat coil.")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual real ConvergenceTolerance { get; set; } = new real;
////[Description("Normal means the damper is fixed at the minimum position in heating mode")]
////public virtual choice DamperHeatingAction { get; set; } = new choice;
////[Description("Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits")]
////public virtual real MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = new real;
////[Description("Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = ReverseWithLimits")]
////public virtual real MaximumFlowFractionDuringReheat { get; set; } = new real;
////[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil.")]
////public virtual real MaximumReheatAirTemperature { get; set; } = new real;
////[Description("When the name of a DesignSpecification:OutdoorAir object is entered, the terminal")]
////public virtual object-list DesignSpecificationOutdoorAirObjectName { get; set; } = new object-list;
////}
////}
