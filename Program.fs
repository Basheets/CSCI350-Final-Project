// Learn more about F# at http://fsharp.org
open System
//This generetes a random number to decide the number of hunts the player will go on
let randomNumberOfHunts = 
    (new System.Random()).Next(5, 40)
//This generates a random number to decide the monster the player will hunt
let randomMonster = 
    (new System.Random()).Next(1, 5)
//This generates a random number to decide the players weapon
let randomWeaponChoice = 
    (new System.Random()).Next(1, 5)

//The purpose of this value is to have a single value that ensures the hunter will go on a specified number of hunts
let numberOfHunts =
    randomNumberOfHunts
//The purpose of this value is to have a single value that will ensure the hunted monster does not change
let monster = 
    randomMonster

//The purpose of this value is to have a single value that will ensure weapon choice does not change
let weapon =
    randomWeaponChoice

let mutable successfulHunts = 0

let mutable successfulHuntChance = 0
//This method adds the two integers and returns the result
let addToSuccess (x, y) = x + y    

//This method will modify the successful hunt chance depending of weapon match up with monster and return what weapon you are using
let weaponChoice (x) = 
    if(x = 1 && monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 1))
        "Your weapon is the Lightning Strike Bow"
    elif (x = 2 && monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Ice Long Sword"
    elif (x = 3 && monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 15))
        "Your weapon is the Water Switch Axe"
    elif (x = 4 && monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Fire Sword and Shield"
    elif (x = 5 && monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 30))
        "Your weapon is the Dragon Kinsect Glaive"
    elif(x = 1 && monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Lightning Strike Bow"
    elif (x = 2 && monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 30))
        "Your weapon is the Ice Long Sword"
    elif (x = 3 && monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Water Switch Axe"
    elif (x = 4 && monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Fire Sword and Shield"
    elif (x = 5 && monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your weapon is the Dragon Kinsect Glaive"
    elif(x = 1 && monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Lightning Strike Bow"
    elif (x = 2 && monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Ice Long Sword"
    elif (x = 3 && monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Water Switch Axe"
    elif (x = 4 && monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Fire Sword and Shield"
    elif (x = 5 && monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your weapon is the Dragon Kinsect Glaive"
    elif(x = 1 && monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your weapon is the Lightning Strike Bow"
    elif (x = 2 && monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Ice Long Sword"
    elif (x = 3 && monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Water Switch Axe"
    elif (x = 4 && monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Fire Sword and Shield"
    elif (x = 5 && monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your weapon is the Dragon Kinsect Glaive"
    elif(x = 1 && monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 40))
        "Your weapon is the Lightning Strike Bow"
    elif (x = 2 && monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Ice Long Sword"
    elif (x = 3 && monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Water Switch Axe"
    elif (x = 4 && monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your weapon is the Fire Sword and Shield"
    elif (x = 5 && monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your weapon is the Dragon Kinsect Glaive"
    else 
        "You do not have a weapon"

//This method takes an integer and returns a string for the matching monster while adjusting the successful hunt chance
let monsterName x =
    if(monster = 1) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 10))
        "Your hunt is the Thunder Horse Elder Dragon Kirin"
    elif (monster = 2) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 30))
        "Your hunt is the Ice Wyvern Legiana"
    elif (monster = 3) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 50))
        "Your hunt is the Aquatic Piscine Wyvern Jyrotodus"
    elif (monster = 4) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 20))
        "Your hunt is the Burning Blade Dragon Glavenus"
    elif (monster = 5) then
        successfulHuntChance <- (addToSuccess(successfulHuntChance, 5))
        "Your hunt is the Elder Dragon Stygian Zinogre!!!"
    else 
        "You hunt no monster"


let determineSuccessfulHunts x =
    let mutable i = 0
    let mutable continueLoop = true
    
    while continueLoop do
        if(i < numberOfHunts) then
            let result = (new System.Random()).Next(1, 100)
            if (result < x) then
                successfulHunts <- (addToSuccess(successfulHunts, 1))
                i <- (addToSuccess(i, 1))
            else
                i <- (addToSuccess(i, 1))
        else
            continueLoop <- false

    successfulHunts.ToString()
    
[<EntryPoint>]
let main argv =
    System.Console.Write("Ah, there ya are fiver, go get yer'self on a hunt\n")
    System.Console.Write(weaponChoice(weapon) + "\n")
    System.Console.Write(monsterName(monster) + "\n")
    System.Console.Write("You went on" + numberOfHunts.ToString() + " hunts and beat it " + determineSuccessfulHunts(successfulHuntChance) + " times.\n")
    System.Console.Write("Well done out there fiver go get yer'self a rest")
    0 // return an integer exit code
