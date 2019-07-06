# VL.Devices.NuiTrack
Set of nodes to use the [Nuitrack API](https://nuitrack.com) in vl.

## Using the library

### Nuget installation
In order to use this library with vl you have to install the nuget that is available via nuget.org. For information on how to use nugets with vl, see [Managing Nugets](https://vvvv.gitbooks.io/the-gray-book/content/en/reference/libraries/dependencies.html#_manage_nugets) in the vl documentation. As described there you go to the commandline and then type:

    nuget install VL.Devices.Nuitrack -prerelease

### Nuitrack SDK Installation

In order for Nuitrack to work in your system you will need to install the Nuitrack SDK.

Head to (https://nuitrack.com/#api) and download the SDK, this will require opening an account with Nuitrack (if you don't already have one). The free trial will allow you to use the SDK 3 minutes at a time before needing to restart your application/patch.

Once downloaded install the Nuitrack SDK following on-screen instructions. (The subsequent steps assume you used C:\Nuitrack as your installation path)

### Setting environment variables

In some cases you will need to set some environment variables in your system before Nuitrack works correctly. For the examples below it is assumed you installed the SDK in C:\Nuitrack, change the paths accordingly to match your installation path.

(Official instructions [here](http://download.3divi.com/Nuitrack/doc/Installation_page.html) )

- Set "NUITRACK_HOME" to C:\Nuitrack\nuitrack\nuitrack
- Add "C:\Nuitrack\nuitrack\nuitrack\bin" to you "PATH" environment variable

### Activate Nuitrack

After the steps above have been done you will need to activate your Nuitrack installation. 

- Make sure you have a compatible sensor connected to your system and that any required drivers or software are installed
- Head to "C:\Nuitrack\nuitrack\nuitrack\activation_tool" 
- Run "Nuitrack.exe".
- Click on Test, after a short while you should see a window with input from your device, click to toggle between color and depth view
- Back on the main application window click on Add License and paste in the code you got during your registration (if you have registered but do not have a key at hand follow the steps in the section below)

### Getting an activation key

If you have registered on nuitrack.com but for any reason do not have a key at hand, you can head to (https://cognitive.3divi.com/app/nuitrack/dashboard/) and at the bottom click on "Generate a key". The provided key should allow you to activate your copy of Nuitrack SDK.

### Using Nuitrack in VL

Once you have gone through the steps above and the VL.Devices.Nuitrack nuget is installed and referenced in your vl document you'll see the category "Nuitrack" under "Devices" in the nodebrowser.

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
