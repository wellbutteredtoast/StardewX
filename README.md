# StardewX

![Static Badge](https://img.shields.io/badge/Built_with-C%23-green)
![Static Badge](https://img.shields.io/badge/License-GPL-white)


> [!IMPORTANT]
> All images referenced in this repository come from the [Stardew Valley Wiki](https://stardewvalleywiki.com/) and are *not* my personal property unless otherwise stated!

<img src="https://stardewvalleywiki.com/mediawiki/images/6/67/Void_Chicken.png" style="padding-left: 20px;" alt="Void Chicken"><br>StardewX -- a **massive** expansion to Stardew Valley 1.6. StardewX is a comprehensive mod that adds a large amount of *new* content while making edits to pre-existing vanilla content. For a **comprehensive** overview into what was changed from the vanilla games -- I will direct you to the `docs` directory which is effectively a wiki for this project. It covers everything that is changed, what is added, all that important stuff.

# How is the Repo Organized?

Pretty easily, which is nice. About 99% of all C# code will be inside the `src` directory. The `ModEntry.cs` file will remain here in the root of the directory alongside the manifest. The JSON for the Content Patcher will be in stored in `[CP] StardewX` - which is just all the pure JSON data and assets. The two mods depend on each other, you can't have one without the other without hard crashing. The Content Patcher portion of this repo has its own README and information on how to help out!

# Notice: Multiplayer

This mod is 100% **not compatible** with any multiplayer play. Playing with other people is **not recommended** at all, do so at your own risk.

# Notice: System Requirements

This mod is incredibly heavy. Having hundreds of assets, several massive changes to the core of the game, multiple dependencies, and an incredibly large amount of JSON data. This mod requires that users have a large amount of RAM available for use. I would recommend around 16GB of RAM as the perfect amount. 8GB is doable but you would likely experience performance losses.

# Notice: Lewd Content

Yeah, this mod features large amounts of lewd content on top of everything else. This is optional, disabled by default. If you want lewd content, enable it in the GenericModConfigMenu menu entry. By enabling lewd content, you declare that you're over 18 and are 100% okay with seeing mature and sexual content and will not get offended by such material.

## How can I build StardewX?

I recommend you don't. Usually my commits are not well tested initally. I recommend you go to the latest **[Release](https://github.com/wellbutteredtoast/stardewx/releases)** of the project and install it into your game. However if you *do* want to build this on your own, it's not too difficult.

> [!TIP]
> You will need a copy of the [.NET SDK Version 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to build this project properly.

First things first, you'll want to clone this repository or download it. Either option will result in you having a copy of the current source code. If you cloned the repository it should be ready immediately for the next step. If you downloaded via the GitHub webpage, you'll want to extract the \*.zip you got into a directory of your choice.

Next, open the project in your IDE or text editor of choice. Visual Studio users are recommended to use the \*.csproj Project File. VSCode users should just open the entire directory. Other IDEs may have different steps. If you **don't want to use an IDE, open this directory in your terminal of your choice.**

> Windows users should use either the Command Prompt or Powershell

> Linux users should use their builtin shell, such as `bash`, `zsh`, `fish`, etc.

> MacOS users should also use their builtin shell, `zsh`, or a non-standard shell like `warp`

> [!IMPORTANT]
> Before running `dotnet build` **or** `dotnet run` it is advised you change the `<GamePath>` inside the \*.csproj file to match **your** install of Stardew Valley!

Once you have the project open and ready, most IDEs will have a shortcut to build or run the project, inside a terminal you can type;

```bash
dotnet run
```
**or:**
```bash
dotnet build
```

to build the project and execute it. for users running the project, StardewValleyModdingAPI should automatically start for gameplay.