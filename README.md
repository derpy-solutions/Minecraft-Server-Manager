# Minecraft-Server-Manager
A derpy solution to manager multiple local java minecraft servers.

Designed for local networks in youth centers, schools etc. 

Enjoy!


## Prerequisites
In order to use the **Minecraft Server Manager** you will need to install **.NET Desktop Runtime 5.0.14** which you can download [here](https://dotnet.microsoft.com/en-us/download/dotnet/5.0).
1. You will need the [server.jar](https://www.minecraft.net/en-us/download/server).
2. Create a Folder you want to store all your Servers in, e.g. 'C:\Users\YOUR USER NAME\Documents\Minecraft Server Manager\Servers\'.
3. Inside that folder create another folder which is named **'MSM Source'**, this is our source folder you need to create new servers from.
4. Place the server.jar inside that folder and execute it. Wait a moment until you can see the 'eula.txt'.
5. Open the file and change 'eula=false' to 'eula=true'
6. execute the server.jar file again
7. once you see the server UI you can close it again
8. now there is a new 'world' folder inside the **'MSM Source'** folder, delete this one! Otherwise every new server would have the exact same world which you most likely don't want!

Now it depends if you want to use mods or not. If you want to use mods, you would use forge (or smth similar, just adjust the following steps)

**No mods**
Start the **Minecraft Server Manager** and go to settings and change the CMD Command line to `-jar server.jar` (default `@libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %*` and you are ready to go!

**Mods**
1. get the [forge.jar](https://files.minecraftforge.net/net/minecraftforge/forge/) files you want to use
2. install forge to the **'MSM Source'** server
3. open **Minecraft Server Manager** go to settings and adjust the CMD Command line. How exactly depends on the version of forge you are using and how that one want to get started.
  - Version 1.18 or newer
    1. inside the folder you would now have a 'run.bat' file, rightclick and edit it
    2. you will see a line like this `java -Xmx4G @libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %*` from this line we only need this part `@libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %*` the rest is passed by the **MSM** already as it sets the RAM amount you want to assign to the server
    3. grab that line and put it in the **CMD Command** Textbox
    
  - Version older than 1.18
    1. You should see a file named similar to `forge-1.15.2-31.1.18.jar` in your **'MSM Source'** folder go to the **CMD Command** Textbox and put `-jar forge-1.15.2-31.1.18.jar` in it
 
 Thats it, make sure to have the path to your servers folder set up in the settings, now you can start create, delete and manage your servers with the **Minecraft Server Manager**.

## Preview
![PreviewServers](https://user-images.githubusercontent.com/99297851/153873081-1da6f202-c484-4e37-8282-441dab4bd23f.png)
![PreviewSettings](https://user-images.githubusercontent.com/99297851/153873150-9b6a82f2-234d-4768-87d1-b42c064f75f8.png)
![PreviewSideMenu](https://user-images.githubusercontent.com/99297851/153873204-82b1f774-25a1-440b-b649-eaf998f22e11.png)
![PreviewFavorites](https://user-images.githubusercontent.com/99297851/153873367-72c37764-b75c-4c87-8bea-87f654a1f014.png)

## To Do - Planned Features
- [x] #1 add International Support for UI elements
- [x] #2 add Option for Automatic Version checks
- [ ] #3 add a way to switch between multiple Java/Minecraft Versions more easily
- [x] #4 add a startup per server
