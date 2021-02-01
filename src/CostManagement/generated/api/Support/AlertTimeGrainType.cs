// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>Type of timegrain cadence</summary>
    public partial struct AlertTimeGrainType :
        System.IEquatable<AlertTimeGrainType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType Annually = @"Annually";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType BillingAnnual = @"BillingAnnual";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType BillingMonth = @"BillingMonth";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType BillingQuarter = @"BillingQuarter";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType Monthly = @"Monthly";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType Quarterly = @"Quarterly";

        /// <summary>the value for an instance of the <see cref="AlertTimeGrainType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AlertTimeGrainType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AlertTimeGrainType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AlertTimeGrainType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertTimeGrainType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AlertTimeGrainType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AlertTimeGrainType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AlertTimeGrainType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AlertTimeGrainType && Equals((AlertTimeGrainType)obj);
        }

        /// <summary>Returns hashCode for enum AlertTimeGrainType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AlertTimeGrainType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AlertTimeGrainType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertTimeGrainType" />.</param>

        public static implicit operator AlertTimeGrainType(string value)
        {
            return new AlertTimeGrainType(value);
        }

        /// <summary>Implicit operator to convert AlertTimeGrainType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AlertTimeGrainType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AlertTimeGrainType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AlertTimeGrainType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType e2)
        {
            return e2.Equals(e1);
        }
    }
}