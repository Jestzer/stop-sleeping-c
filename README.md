# stop-sleeping-c
Write a file, D:\timer.txt, every minute to prevent the drive from sleeping. Runs as a Windows Service.

**IMPORTANT NOTE: It will not immediately start writing the file made. Please wait 60 seconds for it to generate/write to the file.**

To use this, you need to install it as a service. It will not run otherwise (and will tell you so.) To install it as a service, follow the steps below:

1. Open PS/CMD
2. Enter the command below. Change the filepath to this program appropriately.

  ``sc create StopSleepingService binPath= "C:\Path\To\This\Service\Stop-sleeping.exe.exe``
	
3. You can then either start the service from the Windows Service program or by running the command below.
  sc start MyService

As noted above, it will not immediately start writing the file made. Please wait 60 seconds for it to generate/write to the file.

Enjoy.
