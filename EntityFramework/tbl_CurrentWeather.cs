//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accuweather.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_CurrentWeather
    {
        public int LocationKey { get; set; }
        public double CelsiusTemperature { get; set; }
        public string WeatherText { get; set; }
    
        public virtual tbl_Favories tbl_Favories { get; set; }
    }
}
