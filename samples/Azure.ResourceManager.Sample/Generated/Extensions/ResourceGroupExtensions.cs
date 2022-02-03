// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of AvailabilitySets in the AvailabilitySet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AvailabilitySets and their operations over a AvailabilitySet. </returns>
        public static AvailabilitySetCollection GetAvailabilitySets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetAvailabilitySets();
        }

        /// <summary> Gets a collection of ProximityPlacementGroups in the ProximityPlacementGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ProximityPlacementGroups and their operations over a ProximityPlacementGroup. </returns>
        public static ProximityPlacementGroupCollection GetProximityPlacementGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetProximityPlacementGroups();
        }

        /// <summary> Gets a collection of DedicatedHostGroups in the DedicatedHostGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DedicatedHostGroups and their operations over a DedicatedHostGroup. </returns>
        public static DedicatedHostGroupCollection GetDedicatedHostGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDedicatedHostGroups();
        }

        /// <summary> Gets a collection of SshPublicKeys in the SshPublicKey. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SshPublicKeys and their operations over a SshPublicKey. </returns>
        public static SshPublicKeyCollection GetSshPublicKeys(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetSshPublicKeys();
        }

        /// <summary> Gets a collection of VirtualMachines in the VirtualMachine. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachines and their operations over a VirtualMachine. </returns>
        public static VirtualMachineCollection GetVirtualMachines(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachines();
        }

        /// <summary> Gets a collection of Images in the Image. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Images and their operations over a Image. </returns>
        public static ImageCollection GetImages(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetImages();
        }

        /// <summary> Gets a collection of VirtualMachineScaleSets in the VirtualMachineScaleSet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineScaleSets and their operations over a VirtualMachineScaleSet. </returns>
        public static VirtualMachineScaleSetCollection GetVirtualMachineScaleSets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachineScaleSets();
        }
    }
}
