using MyPoolChemistry;

    GetPoolChemistry();

static void  GetPoolChemistry()
{

    // Console.WriteLine("To Quit program type quit.");
    // Need to setup a loop to give user option to quiting program or retest

     

        Console.WriteLine("What is your pool volume? (gallons) ");
        float poolVolume = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Total chlorine?(ppm) ");
        float totalChlorine = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Free chlorine?(ppm) ");
        float freeChlorine = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("pH? ");

    float phEntry = Convert.ToSingle(Console.ReadLine());

    // calculate phDelta from 7.5 if not in the ideal range

    if(phEntry > 7.4)
       
    {
        float phDelta = 0;
        Console.WriteLine("Your pH is in the ideal range.  No action for pH required.");

    }
    else
    {
        float phDelta = phEntry - 7.5f;
        if (phDelta < -.1f)
        {
            Console.WriteLine($"Add " 
        }
    }

    Console.WriteLine("Cyanuric Acid Level? ");
    var cyanuricAcid = Console.ReadLine();

    Console.WriteLine("alkalinity? ");
    var alkalinity = Console.ReadLine();

    Console.WriteLine("Calcium Hardness? ");
    var calcium = Console.ReadLine();




    //Ideal pH 7.4-7.6
    //To report required adds need to determine if values are
    //below or above ideal









}
