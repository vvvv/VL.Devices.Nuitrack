# VL.Devices.NuiTrack
Set of nodes to use the [Nuitrack API](https://nuitrack.com) in vl

## Using the library
In order to use this library with vl you have to install the nuget that is available via nuget.org. For information on how to use nugets with vl, see [Managing Nugets](https://vvvv.gitbooks.io/the-gray-book/content/en/reference/libraries/dependencies.html#_manage_nugets) in the vl documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.Nuitrack -prerelease

Once the VL.Devices.Nuitrack nuget is installed and referenced in your vl document you'll see the category "Nuitrack" under "Devices" in the nodebrowser.

VL help patches can be found here:

    "VL.Devices.Nuitrack\help\"

## Contributing to the development
If you want to contribute to this repository, clone it into a directory like:
 
    X:\vl-libs\VL.Devices.Nuitrack

### Build the C# Project
Open

    X:\vl-libs\VL.Devices.Nuitrack\src\VL.Devices.Nuitrack
    
in VisualStudio and build it. This is necessary for a few things that cannot yet be expressed in vl directly, like inheritance.

### Reference VL.Devices.Nuitrack.vl

In the vl document where you want to have access to the Kinect2 nodeset, add a dependency to:

	X:\vl-libs\VL.Devices.Nuitrack\VL.Devices.Nuitrack.vl

The available Nuitrack nodes should appear in the nodebrowser under Devices->Nuitrack.
