using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */
            int birdsOnABranch = 4;
            int birdsThatFlewAway = 1;
            int birdsLeft = birdsOnABranch - birdsThatFlewAway;
            Console.WriteLine("There are " + birdsLeft + " birds remaining.");
            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */
            int birds = 6;
            int nests = 3;
            int nestsBirdsDifference = birds - nests;
            Console.WriteLine("There are " + nestsBirdsDifference + " more birds than there are nests.");
            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int sylvanRaccoons = 3;
            int leavingRaccoons = 2;
            int remainingSylvanRaccoons = sylvanRaccoons - leavingRaccoons;
            Console.WriteLine("There is " + remainingSylvanRaccoons + " raccoon left in the forest.");
            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int flowers = 5;
            int bees = 3;
            int flowersBeesDifference = flowers - bees;
            Console.WriteLine("There are " + flowersBeesDifference + " more flowers than there are bees.");
            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int initPigeons = 1;
            int newPigeons = 1;
            int pigeons = initPigeons + newPigeons;
            Console.WriteLine("There are " + pigeons + " pigeons eating breadcrumbs.");
            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int initOwls = 3;
            int newOwls = 2;
            int owls = initOwls + newOwls;
            Console.WriteLine("There are " + owls + " owls sitting on the fence.");
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int initBeavers = 2;
            int leavingBeavers = 1;
            int beaversRemaining = initBeavers - leavingBeavers;

            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int initToucans = 2;
            int newToucans = 1;
            int toucans = initToucans + newToucans;
            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelsNutsDifference = squirrels - nuts;
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            int quarterTotal = 25;
            int dimeTotal = 10;
            int nickelTotal = 10;
            int moneyTotal = quarterTotal + dimeTotal + nickelTotal;
            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int brierMuffins = 18;
            int macadamsMuffins = 20;
            int flanneryMuffins = 17;
            int totalMuffins = brierMuffins + macadamsMuffins + flanneryMuffins;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            int yoyoPrice = 24;
            int whistlePrice = 14;
            int moneySpent = yoyoPrice + whistlePrice;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int smallMarshmallows = 10;
            int totalMarhmallows = largeMarshmallows + smallMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltSnow = 29;
            int brecknockSnow = 17;
            int snowDifference = hiltSnow - brecknockSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltMoney = 10;
            int truckPrice = 3;
            int casePrice = 2;
            int hiltMoneyRemaining = hiltMoney - (truckPrice + casePrice);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbles = 16;
            int marbleLoss = 7;
            int currentMarbles = joshMarbles - marbleLoss;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int currentSeashells = 19;
            int desiredSeashells = 25;
            int neededSeashells = desiredSeashells - currentSeashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentBooks = 38;
            int newBooks = 10;
            int totalBooks = currentBooks + newBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int beeAmount = 8;
            int beeLegAmount = beeAmount * beeLegs;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal coneCost = .99M;
            int coneAmount = 2;
            decimal totalConeCost = coneAmount * coneCost;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currentRocks = 64;
            int requiredRocks = 125;
            int neededRocks = requiredRocks - currentRocks;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int initHiltMarbles = 38;
            int hiltMarblesLost = 15;
            int currentHiltMarbles = initHiltMarbles - hiltMarblesLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesTotal = 78;
            int milesBeforeGas = 32;
            int milesAfterGas = milesTotal - milesBeforeGas;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int morningTimeShoveling = 90;
            int afternoonTimeShoveling = 45;
            int totalTimeShovelingInMinutes = morningTimeShoveling + afternoonTimeShoveling;
            int hoursShoveling = (totalTimeShovelingInMinutes / 60);
            decimal minutesShoveling = (decimal)(totalTimeShovelingInMinutes % 60) / (100);
            decimal totalTimeShoveling = hoursShoveling + minutesShoveling;
            Console.WriteLine(totalTimeShoveling);
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal hotDogPrice = .50M;
            int hotDogAmount = 6;
            decimal hotDogTotal = hotDogAmount * hotDogPrice;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal hiltCash = .50M;
            decimal pencilPrice = .07M;
            int possiblePencilAmount = (int)(hiltCash / pencilPrice);
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int hiltButterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = hiltButterfliesSeen - orangeButterflies;
            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal katePaid = 1.00M;
            decimal candyPrice = .54M;
            decimal kateChange = katePaid - candyPrice;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int markCurrentTrees = 13;
            int markNewTrees = 12;
            int markTotalTrees = markCurrentTrees + markNewTrees;
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */


        }
    }
}
