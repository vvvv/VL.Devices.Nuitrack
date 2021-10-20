# VL.Devices.Nuitrack
Set of nodes to use the [Nuitrack API](https://nuitrack.com) in VL.

Try it with vvvv, the visual live-programming environment for .NET  
Download: http://visualprogramming.net

## Using the library
Ensure you've a recent VL version installed (>= 2020.1).

### Nuget installation
In order to use this library with VL you have to install the nuget that is available via nuget.org. For information on how to use nugets with VL, see [Managing Nugets](https://thegraybook.vvvv.org/reference/libraries/dependencies.html#manage-nugets) in the VL documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.Nuitrack

### Nuitrack SDK Installation

In order for Nuitrack to work in your system you will need to install the Nuitrack SDK.

Head to (https://nuitrack.com/#api), scroll down to "Plans" and get a license that suits you, after completing the license form, you will get download links, download and install the Windows version compatible with your system (32 or 64 bits). The free trial will allow you to use the SDK 3 minutes at a time before needing to restart your application/patch.

Once downloaded install the Nuitrack SDK following on-screen instructions.

### Activate Nuitrack

After the intallation process is done you will need to activate your Nuitrack installation. 

- Make sure you have a compatible sensor connected to your system and that any required drivers or software are installed
- Open the newly installed "Nuitrack App"
- Select your sensor from the dropdown list
- Enter your activation code (you should have received an email with this code after getting your license)
- Select Face Tracking and AI: Skeletal Tracking (Object Detection is not yet supported)
- Click "Try Nuitrack!". After a few seconds your device should turn on and you should be able to see a video feed with skeleton tracking and a few other features.

### Using Nuitrack in VL

Once you have gone through the steps above and the VL.Devices.Nuitrack nuget is installed and referenced in your VL document you'll see the category "Nuitrack" under "Devices" in the nodebrowser.

Help Patches are available via the Help Browser! Search for "Nuitrack".

## Contributing to the development
If you want to contribute to this repository, clone it into a directory like:
 
    X:\vl-libs\VL.Devices.Nuitrack

### Build the C# Project
Open

    X:\vl-libs\VL.Devices.Nuitrack\src\VL.Devices.Nuitrack
    
in VisualStudio and build it. This is necessary for a few things that cannot yet be expressed in vl directly, like inheritance.

### Reference VL.Devices.Nuitrack.vl

In the VL document where you want to have access to the Kinect2 nodeset, add a dependency to:

	X:\vl-libs\VL.Devices.Nuitrack\VL.Devices.Nuitrack.vl

The available Nuitrack nodes should appear in the nodebrowser under Devices->Nuitrack.
