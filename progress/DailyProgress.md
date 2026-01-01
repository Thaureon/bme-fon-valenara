# Daily Progress
This started out as a accomplishments for today and goals for tomorrow, but turned into a backlog style.  This was not the original intent behind daily logs.

12/29 Update:
- World Generation
    - Cleaned up backlog to make it easier for end of month preperations.
Tomorrow Goals:
- Seed Generation
    - Figure more out on seed generation by considering how minecraft generates their seed.
- World Generation
    - Figure out how Minecraft world generation works and how each layer is generated, whether it is using Perlin noise or some other algorithm.
- Github
    - Update readme on Github and create page for daily updates
- Website
    - Create Page and add initial information to website page.


12/28 Update:
- World Generation
    - Experimented with value noise generation.
    - Value Noise generation isn't great for this type of world generation.
    - Created a pseudo value noise generator that takes the values around the cell and averages them out.
Tomorrow Goals:
- Seed Generation
    - Figure more out on seed generation by considering how minecraft generates their seed.
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/27 Update:
- World Generation
    - Added cellular noise generation.
    - Updated seed to allow strings similar to how minecraft generates seeds.
    - Started looking into a value noise generation.
Tomorrow Goals:
- Seed Generation
    - Figure more out on seed generation by considering how minecraft generates their seed.
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/25 Update:
- World Generation
    - Added noise generation based on classic perlin noise using noise.cnoise and noise.pnoise.
Tomorrow Goals:
- Seed Generation
    - Figure more out on seed generation by considering how minecraft generates their seed.
    - Consider moving seed value to hash and allowing words to also be used.
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/24 Update:
- World Generation
    - Had each layer generate based on a height map for that layer.
- Seed Generation
    - Researched more on minecraft seed generation. They use "asciiValue + 31 * currentValue".  This allows words to also be used as seeds.
- UI
    - Added way to determine what type of generation will be used for world
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/23 Update:
- World Generation
    - Added pure random, and random seed based generation to world generation.
    - Added initial simplex noise generation method from noise.snoise.
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- UI
    - Add way to determine what type of generation will be used for world
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/22 Update:
- World Generation
    - Break generation script into its own to be able to add additional ways to generate cells.
    - Looked into other world generation types.  Initial plan for multiple other generation exists.
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
- Perlin Generation
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
- UI
    - Add way to determine what type of generation will be used for world
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/21 Update:
- Cell
    - Finished moving cell information from monobehavior to the scriptable objects.
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
    - Look into other world generation types.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/20 Update:
- Cell
    - Improved understanding of how scriptableObjects work.
    - Converted each cell data to its own ScriptableObject.
Tomorrow Goals:
- Cell
    - Move generation to pull from ScriptableObjects instead of making the data itself.
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
    - Look into other world generation types.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/18 Update:
- Cell
    - Started Research into moving Cells from MonoBehaviors to ScriptableObjects
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
    - Look into other world generation types.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/16 Update:
- World Generation
    - Optimized world generation so that entire world wouldn't be removed every time.
    - Refactored world generation logic to be the same whether it is new generation or player generation.
    - Shrunk world generation to be 20 radius instead of 50.
    - Added player vision radius of 5 as well.
- Player
    - Added a separate vision for player so exploring is based on that instead of world vision.
Tomorrow Goals:
- World Generation
    - Make it so that certain cells that are X distance away from player are removed from list to keep total objects to be small.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
    - Look into other world generation types.
- UI
    - Fix UI to better randomly generate seed instead of deleting the input field.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/14 Update:
- World
    - World is moving around as the player moves around.
    - Regenerating the world moves the player and camera back to the center of the world.
Tomorrow Goals:
- World Generation
    - World generation is extremely slow currently, needs optimization.
    - Optimize world gen so that you give it x/y/seed/genType and it will generate the world as necessary.
    - Fix World Gen so that it is not only -x/-y to +x/+y, and also able to go to +x/-y or -x/+y.
    - Fix UI to better randomly generate seed instead of deleting the input field.
    - Look into other world generation types.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/13 Update:
- Player
    - Understand the movement system better.
    - Added ability for player to move left, right, up, and down on button press.
    - Camera follows player for now.
Tomorrow Goals:
- World
    - Dynamically add new cells to the world as the player moves around.
    - Consider only having cells around the player instead of keeping everything that is near the player.
- World Generation
    - Fix UI to better randomly generate seed instead of deleting the input field.
    - Look into other world generation types.
- Player
    - Dig more into the InputSystem to better understand how it works.
- Update readme on Github and create page for daily updates


12/10 Update:
- Added user to world
- Started adding scripts for the user to move around.
Tomorrow Goals:
- Finish figuring out InputSystem to allow easy way to move around as the player.
- Dynamically add new cells to the world.
- Fix UI to better randomly generate seed instead of deleting the input field.
- Look into other world generation types.
- Update readme on Github and create page for daily updates


12/9 Update:
- Updated world generation for some issues with Perlin Noise.
- Added UI to see what seed for generation is and update seed as necessary.
Tomorrow Goals:
- Fix UI to better randomly generate seed instead of deleting the input field.
- Create "player" to move around the world 1 cell at a time.
- Dynamically add new cells to the world.
- Look into other world generation types.
- Update readme on Github and create page for daily updates


12/8 Update:
- Looked into Perlin Noise world generation.
- World generation is using Perlin Noise.
- Perlin Noise has issues with large values where the Perlin Noise value goes to 0.5.
- Perlin Noise allows the ability to dynamically add new cells while still making the world feel connected.
Tomorrow Goals:
- Create "player" to move around the world 1 cell at a time.
- Dynamically add new cells to the world.
- Look into other world generation types.
- Update readme on Github and create page for daily updates


12/7 Update:
- Created Desert Cell which is a yellow  cell to show desserts.
- Created Rocky Cell which is a gray cell to show rocky terrain.
- Created Mountain Cell which is a dark brown cell to show Mountain terrain.
- Added Desert/Rocky/Mountain cells into random generation.
- Updated some of Readme to start being a default for the BME-FON series.
Tomorrow Goals:
- Create "player" to move around the world 1 cell at a time.
- Dynamically add new cells to the world.
- Look into having world generate the same every time with both same seed and different movement.  Possibly perlin noise. 
- Update readme on Github and create page for daily updates


12/6 Update:
- Created Water Shallow Cell which is a blue cell to show grassland.
- Created Water Deep Cell which is a dark blue cell to show forest.
- Added Water cell into random generation.
Tomorrow Goals:
- Created Desert Cell which is a yellow  cell to show desserts.
- Created Rocky Cell which is a gray cell to show rocky terrain.
- Created Mountain Cell which is a dark brown cell to show Mountain terrain.
- Added Desert/Rocky/Mountain cells into random generation.
- Update readme on Github and create page for daily updates


12/4 Update:
- Updated Cell to better show differences for each position.
- Created Plains Cell which is a light green cell to show grassland.
- Created Forest Cell which is a dark green cell to show forest.
- Added Random generation to make the world generate based randomly or on given seed.
Tomorrow Goals:
- Created Shallow Water Cell which is a blue cell to show shallow ocean/other water systems.
- Created Deep Water Cell which is a dark blue cell to show deep ocean.
- Update readme on Github and create page for daily updates


12/3 Update:
- Created Unity project. 
- Created script that generates cells in the world with various sizes.
Tomorrow Goals:
- Update Cell to better show differences for each position.
- Create Plains Cell which is a light green cell to show grassland.
- Update readme on Github and create page for daily updates


12/2 Update:
- Create initial task list.
Tomorrow Goals:
- Create Unity project. Create grid that populates cells with various colors 


12/1 Update:
- Setup Github and everything and plan some initial tasks that would be needed to create this project.
Tomorrow Goals:
- Set up the base application and create some tasks on things that need to be done before procedural generation can be started.