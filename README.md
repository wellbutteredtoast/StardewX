# StardewX

![Static Badge](https://img.shields.io/badge/Built_with-C%23-green)
![Static Badge](https://img.shields.io/badge/License-GPL-white)


> [!IMPORTANT]
> All images referenced in this repository come from the [Stardew Valley Wiki](https://stardewvalleywiki.com/) and are *not* my personal property unless otherwise stated!

<img src="https://stardewvalleywiki.com/mediawiki/images/6/67/Void_Chicken.png" style="padding-left: 20px;" alt="Void Chicken"><br>StardewX -- a **massive** expansion to Stardew Valley 1.6. StardewX is a comprehensive mod that adds a large amount of *new* content while making edits to pre-existing vanilla content. For a **comprehensive** overview into what was changed from the vanilla games -- I will direct you to the `docs` directory which is effectively a wiki for this project. It covers everything that is changed, what is added, all that important stuff.

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