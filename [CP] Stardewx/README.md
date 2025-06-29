# StardewX Content Pack

Welcome! This is the actual *Content Pack* for StardewX. In this directory is where the majority of game assets and data actually live. JSON is the name of the game here, and there is so much of it...

It's a good thing JSON isn't a valid part of [Github Linguist](https://github.com/github-linguist/linguist) -- this repo would be about 90% JSON, 10% C#! Anyways, this is data, about 99% of it is hand written, note that depending on what IDE you use, you may see errors in the JSON when it comes to comments. Comments are OK in JSON and don't actually cause issues with SMAPI and Content Patcher. Github may flag comments in red, but that can also be safely ignored. The vast majority of this is thankfully super easy to just read and understand, otherwise!

### Handy List of Dialogue Flags

```
#$b# = line break
#$e# = ends dialogue box

$a   = angry emote
$b   = blushing
$c   = crying
$d   = distress
$h   = happy emote (:3)
$l   = love heart
$s   = sad emote
$u   = surprise!

#$q <question_id>/<quesition txt>  = create question prompt
#$r <question_id>/<response txt>   = player responses to prompt

@        = player name
%farmer  = 1:1 with @
%farm    = farm name
%pet     = pet name
%child1  = first child name
%child2  = second child name
%spouse  = name of spouse
%pronoun = he/she/they
%possessivepronoun = his/her/their
%objectivepronoun  = him/her/them

%% = %
```