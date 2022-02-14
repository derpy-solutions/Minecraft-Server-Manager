# Minecraft-Server-Manager
A derpy solution to manage multiple local java minecraft servers.

Designed for local networks in youth centers, schools etc. 

Enjoy!

![PreviewServers](https://user-images.githubusercontent.com/99297851/153873081-1da6f202-c484-4e37-8282-441dab4bd23f.png)

## Installation
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

### No Mods
Start the **Minecraft Server Manager** and go to settings and change the CMD Command line to `-jar server.jar` (default `@libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %*` and you are ready to go!

### With Mods
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

## Mods
### What are mods?
Mods is short for modifciation and describes all kinds of files which got modified to change the vanilla minecraft game.
These mods are basically **.jar** files which you can get from sites like [minecraftmods.com](https://www.minecraftmods.com/) and [curseforge.com](https://www.curseforge.com/minecraft/mc-mods). Make sure to always use the correct version as different versions require different modding frameworks. If you don't know which to choose, I would recommend to use forge.
These mods can be as small as allowing you to place torches on the ceiling, more impactful like adding minimaps or as game changing as adding a huge variety of items, monsters etc. The kids you host the servers for will want to have mods for sure!

A small warning has to be placed here for the unexperienced:***Don't install to many mods unless you have some really good PCs.*** 

***A second disclaimer has to be placed here as you will have to keep in mind that every player on the server will have to have the same mods installed as there are on the server!***

### Mods Installation on the Source server
1. Download the mods you want to use
2. open the `mods` folder in your **'MSM Source'** folder and put them in there

### Install Mods on the Players end
1. Download the mods you want to use
2. press `WIN` (![win_icon](https://user-images.githubusercontent.com/99297851/153912042-b4956d65-1f79-4bb3-8b03-63bbeae1c464.png)) + `R`
3. a small window should have popped up, type `%appdata%` in it and hit enter
4. open the `.minecraft` folder
5. open the `mods` folder
6. put the mods in there

## To Do - Planned Features
- [x] #1 add International Support for UI elements
- [x] #2 add Option for Automatic Version checks
- [ ] #3 add a way to switch between multiple Java/Minecraft Versions more easily
- [x] #4 add a startup per server

## Images
![PreviewServers](https://user-images.githubusercontent.com/99297851/153873081-1da6f202-c484-4e37-8282-441dab4bd23f.png)
![PreviewSettings](https://user-images.githubusercontent.com/99297851/153873150-9b6a82f2-234d-4768-87d1-b42c064f75f8.png)
![PreviewSideMenu](https://user-images.githubusercontent.com/99297851/153873204-82b1f774-25a1-440b-b649-eaf998f22e11.png)
![PreviewFavorites](https://user-images.githubusercontent.com/99297851/153873367-72c37764-b75c-4c87-8bea-87f654a1f014.png)
