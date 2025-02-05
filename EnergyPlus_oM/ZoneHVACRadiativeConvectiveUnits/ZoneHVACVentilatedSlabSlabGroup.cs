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
////public class ZoneHVAC:VentilatedSlab:SlabGroup : BHoMObject
////{
////[Description("No description available")]
////public virtual alpha Name { get; set; } = new alpha;
////[Description("No description available")]
////public virtual object-list Zone1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface1Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface1 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface1 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface1 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface1 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface1 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface2Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface2 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface2 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface2 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface2 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface2 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface3Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface3 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface3 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface3 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface3 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface3 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface4Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface4 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface4 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface4 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface4 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface4 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface5Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface5 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface5 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface5 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface5 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface5 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface6Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface6 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface6 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface6 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface6 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface6 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface7Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface7 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface7 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface7 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface7 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface7 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface8Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface8 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface8 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface8 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface8 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface8 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface9Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface9 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface9 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface9 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface9 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface9 { get; set; } = new node;
////[Description("No description available")]
////public virtual object-list Zone10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual object-list Surface10Name { get; set; } = new object-list;
////[Description("No description available")]
////public virtual real CoreDiameterForSurface10 { get; set; } = new real;
////[Description("No description available")]
////public virtual real CoreLengthForSurface10 { get; set; } = new real;
////[Description("No description available")]
////public virtual null CoreNumbersForSurface10 { get; set; } = new null;
////[Description("No description available")]
////public virtual node SlabInletNodeNameForSurface10 { get; set; } = new node;
////[Description("No description available")]
////public virtual node SlabOutletNodeNameForSurface10 { get; set; } = new node;
////}
////}



