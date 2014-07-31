namespace GSM_Homework
{
    class GSMTest
    {
        public static void TestGSM()
        {
            GSM[] array = new GSM[3];
            array[0] = new GSM("GoldFinger", "Gogotechnologies");
            array[1] = new GSM("Stinger", "BigManIndustry", 10000, "Mustafa", new Display(15.5, 120), new Battery(Battery.BatteryType.NiMH, 500, 50));
            array[2] = new GSM("Note2", "Samsung");
            foreach (var mobile in array)
            {
                System.Console.WriteLine(mobile.ToString());
            }
            System.Console.WriteLine(GSM.IPhone4S);
        }
    }
}
