// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>OS configurations for HCI device.</summary>
    public partial class HciOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IHciOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IHciOSProfileInternal
    {

        /// <summary>Backing field for <see cref="AssemblyVersion" /> property.</summary>
        private string _assemblyVersion;

        /// <summary>Version of assembly present on device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string AssemblyVersion { get => this._assemblyVersion; }

        /// <summary>Backing field for <see cref="BootType" /> property.</summary>
        private string _bootType;

        /// <summary>The boot type of the device. e.g. UEFI, Legacy etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string BootType { get => this._bootType; }

        /// <summary>Internal Acessors for AssemblyVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IHciOSProfileInternal.AssemblyVersion { get => this._assemblyVersion; set { {_assemblyVersion = value;} } }

        /// <summary>Internal Acessors for BootType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IHciOSProfileInternal.BootType { get => this._bootType; set { {_bootType = value;} } }

        /// <summary>Creates an new <see cref="HciOSProfile" /> instance.</summary>
        public HciOSProfile()
        {

        }
    }
    /// OS configurations for HCI device.
    public partial interface IHciOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>Version of assembly present on device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Version of assembly present on device",
        SerializedName = @"assemblyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AssemblyVersion { get;  }
        /// <summary>The boot type of the device. e.g. UEFI, Legacy etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The boot type of the device. e.g. UEFI, Legacy etc",
        SerializedName = @"bootType",
        PossibleTypes = new [] { typeof(string) })]
        string BootType { get;  }

    }
    /// OS configurations for HCI device.
    internal partial interface IHciOSProfileInternal

    {
        /// <summary>Version of assembly present on device</summary>
        string AssemblyVersion { get; set; }
        /// <summary>The boot type of the device. e.g. UEFI, Legacy etc</summary>
        string BootType { get; set; }

    }
}