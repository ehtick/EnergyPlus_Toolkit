////using BH.oM.Base;
////using System.Collections.Generic;
////using System.ComponentModel;
////
////namespace BH.oM.EnergyPlus
////{
////public class Coil:Heating:Gas:MultiStage : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("Availability schedule name for this system. Schedule value > 0 means the system is available.")]
////public virtual object-list AvailabilityScheduleName { get; set; } = new object-list;
////[Description("No description available")]
////public virtual node AirInletNodeName { get; set; } = new node;
////[Description("No description available")]
////public virtual node AirOutletNodeName { get; set; } = new node;
////[Description("optional, used if coil is temperature control and not load-base")]
////public virtual node TemperatureSetpointNodeName { get; set; } = new node;
////[Description("quadratic curve, PLF = a + b*PLR + c*PLR**2")]
////public virtual object-list PartLoadFractionCorrelationCurveName { get; set; } = new object-list;
////[Description("parasitic gas load associated with the gas coil operation (i.e.,")]
////public virtual null ParasiticGasLoad { get; set; } = new null;
////[Description("Enter the number of the following sets of data for coil")]
////public virtual integer NumberOfStages { get; set; } = new integer;
////[Description("No description available")]
////public virtual real Stage1GasBurnerEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage1NominalCapacity { get; set; } = new real;
////[Description("Stage 1 parasitic electric load associated with the gas coil operation")]
////public virtual null Stage1ParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual real Stage2GasBurnerEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage2NominalCapacity { get; set; } = new real;
////[Description("Stage 2 parasitic electric load associated with the gas coil operation")]
////public virtual null Stage2ParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual real Stage3GasBurnerEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage3NominalCapacity { get; set; } = new real;
////[Description("Stage 3 parasitic electric load associated with the gas coil operation")]
////public virtual null Stage3ParasiticElectricLoad { get; set; } = new null;
////[Description("No description available")]
////public virtual real Stage4GasBurnerEfficiency { get; set; } = new real;
////[Description("No description available")]
////public virtual real Stage4NominalCapacity { get; set; } = new real;
////[Description("Stage 4 parasitic electric load associated with the gas coil operation")]
////public virtual null Stage4ParasiticElectricLoad { get; set; } = new null;
////}
////}
