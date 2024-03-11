# _Best Restaurants In Town_

#### By _**Jason Falk**_

#### _A Fidgetech practice project._

## Technologies Used

* _Html_
* _C#_
* _MySql Workbench_
* _Dotnet_
* _Bootstrap_ 

## Description

_Add cuisines categories and then add different restaurants to those cuisines._

## Setup/Installation Requirements

1. _Open Git Bash/Open terminal of your choice navigate to directory of your choice and run this command `git clone https://github.com/JasoFal/HairSalon.Solution.git`_
2. _Once you have cloned the project, navigate to project folder using Git Bash/ a terminal of your choice using the cd command. Or you can use file explorer to open the project manually._
3. _Once project is opened navigate to the main project directory in this case HairSalon._
* _Run in terminal dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0_
* _and dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0_
---
* _To Create Database_
1. _Open MySqlWorkbench_
2. _In the Navigator > Administration window, select Data Import/Restore._
3. _In Import Options select Import from Self-Contained File._
4. _Navigate to the file you just created._
5. _Under Default Schema to be Imported To, select the New button._
6. _Enter the name of your database with _test appended to the end._
7. _In this case `BestRestaurants_Database.sql`._
8. _Click Ok._
9. _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window._
10. _Within the HairSalon directory create a file named appsetting.json._
11. _locate file named `appsettings.example.json` and copy code within example file to your created appsettings.json file adding your UserID and Password._
---
* _Optional Run_
1. _To run the app type `dotnet watch run` in terminal within main HairSalon directory._
2. _Then using a browser of your choice enter https://localhost:5001 into search bar._


## Known Bugs

* _No known bugs_

## License

_MIT_

Copyright (c) _3/11/24_ _Jason Falk_