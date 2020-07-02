using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
namespace Packt.Shared
{   
    /// <summary>
    /// 
    /// </summary>
    public class ThingsOfDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;
        /// <summary>
        /// 
        /// </summary>
        public ThingsOfDefaults()
        {
            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
} 