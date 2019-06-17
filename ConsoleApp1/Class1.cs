using ConsoleApp1.Models2;
using System;

public class Class1
{
    public static void Main()
    {
        Random random = new Random();
        DateTime startdate = new DateTime(2018,6,1);
        int m = 6,year=2018;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    using (EVCSContext db = new EVCSContext())
                    {
                        Records info = new Records();
                        info.Sn = "HYDH20180320000020";
                        info.CarNo = random.Next(2020, 2023);
                        info.Volume = Convert.ToDecimal(random.Next(10, 17) + random.NextDouble());
                        info.LoadingRate = Convert.ToInt32(Convert.ToDouble(info.Volume) * 100 / 17.1510);
                        switch (j)
                        {
                            case 0:
                                info.Remark = "一频（昨日17:00-7:00）";
                                if (i == 1)
                                {
                                    info.StartDate = new DateTime(year, m - 1, 31, 17, 00, 00);
                                    info.EndDate = new DateTime(year, m, i, 7, 00, 00);
                                    info.CreateDate = info.EndDate; break;
                                }
                                info.StartDate = new DateTime(year, m, i, 17, 00, 00); info.EndDate = new DateTime(year, m, i, 7, 00, 00); info.CreateDate = info.EndDate; break;
                            case 1:
                                info.Remark = "二频（7:30 - 13:00）";
                                info.StartDate = new DateTime(year, m, i, 7, 30, 00); info.EndDate = new DateTime(year, m, i, 13, 00, 00); info.CreateDate = info.EndDate; break;
                            case 2:
                                info.Remark = "三频（13:01-16:59）";
                                info.StartDate = new DateTime(year, m, i, 13, 01, 00); info.EndDate = new DateTime(year, m, i, 16, 59, 00); info.CreateDate = info.EndDate;
                                info.Volume = Convert.ToDecimal(random.Next(10, 17) + random.NextDouble());
                                info.LoadingRate = Convert.ToInt32(Convert.ToDouble(info.Volume) * 100 / 17.1510); break;
                        }
                        db.Records.Add(info);
                        db.SaveChanges();
                    }
                }
        }
        Console.WriteLine("完成");
    }
}
