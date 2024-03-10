//1. feladat: Készítsen konzolos alkalmazást a következő feladatok megoldására, melynek projektjét SuperBowl néven mentse el!  
using System.Text;

namespace SuperBowl_2022_maj_
{
    internal class Program
    {
        //2. feladat: Forráskódjában tegye elérhetővé a java.txt vagy a csharp.txt állományból a RomaiSorszam osztályt definiáló kódrészletet!
        class RomaiSorszam
        {
            public string RomaiSsz { get; private set; }

            private static Dictionary<char, int> RomaiMap = new Dictionary<char, int>()
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
            };

            public string ArabSsz
            {
                get
                {
                    int ertek = 0;
                    string romaiSzam = RomaiSsz.TrimEnd('.');
                    for (int i = 0; i < romaiSzam.Length; i++)
                    {
                        if (i + 1 < romaiSzam.Length &&
                            RomaiMap[romaiSzam[i]] < RomaiMap[romaiSzam[i + 1]])
                        {
                            ertek -= RomaiMap[romaiSzam[i]];
                        }
                        else
                        {
                            ertek += RomaiMap[romaiSzam[i]];
                        }
                    }
                    return $"{ertek}.";
                }
            }

            public RomaiSorszam(string romaiSsz)
            {
                RomaiSsz = romaiSsz.ToUpper();
            }
        }
        /*3. feladat: Olvassa be a SuperBowl.txt állományban lévő adatokat,
            és tárolja el egy olyan adatszerkezetben, ami a további feladatok megoldására alkalmas!
            Az állományban legfeljebb 100 sor lehet.
            A sorszámok tárolásánál felhasználhatja az előző feladatban  elérhetővé tett osztályt is*/
        class SuperBowlData
        {
            public RomaiSorszam Ssz { get; set; }
            public string Datum { get; set; }
            public string Gyoztes { get; set; }
            public string Eredmeny { get; set; }
            public string Vesztes { get; set; }
            public string Helyszin { get; set; }
            public string VarosAllam { get; set; }
            public int Nezoszam { get; set; }
            public int WinnerScore => int.Parse(Eredmeny.Split('-')[0]);
            public int LooserScore => int.Parse(Eredmeny.Split('-')[1]);

            public SuperBowlData(string adatSor)
            {
                string[] adatok = adatSor.Split(';');

                Ssz = new RomaiSorszam(adatok[0]);
                Datum = adatok[1];
                Gyoztes = adatok[2];
                Eredmeny = adatok[3];
                Vesztes = adatok[4];
                Helyszin = adatok[5];
                VarosAllam = adatok[6];
                Nezoszam = int.Parse(adatok[7]);
            }

        }

        static List<SuperBowlData> dataList = new List<SuperBowlData>();
        static void Main(string[] args)
        {  
            string[] input = File.ReadAllLines("SuperBowl.txt");
            for (int i = 1; i < input.Length; i++)
            {
                SuperBowlData data = new SuperBowlData(input[i]);
                dataList.Add(data);
            }

            //4. feladat: Határozza meg és írja ki a képernyőre, hogy hány döntő adatai találhatók a forrásállományban!
            Console.WriteLine($"4. feladat: Döntők száma: {dataList.Count}");

            /*5. feladat: Határozza meg és írja ki a képernyőre, hogy a döntők során mennyi volt az átlagos pontkülönbség a két csapat között!
                Az átlagot egy tizedesjegyre kerekítve jelenítse meg!*/
            double diff = 0;
            for (int i = 0; i < dataList.Count; i++)
            {
                diff += dataList[i].WinnerScore - dataList[i].LooserScore;
            }
            Console.WriteLine($"5. feladat: Az átlagos pontkülönbség: {Math.Round(diff / dataList.Count, 1)}");

            /*6. feladat: Keresse meg, hogy melyik döntőn volt a legtöbb néző! Feltételezheti, hogy nem alakult ki
                holtverseny. A döntő adatait jelenítse meg a minta szerint! A döntő sorszámát arab
                sorszámmal jelenítse meg a RomaiSorszam osztálypéldány megfelelő kódtagjának
                a felhasználásával! A csapatnevek mögött jelenjen meg a döntőben elért pontszámuk is!*/
            int max = dataList[0].Nezoszam;
            int maxIdx = 0;
            for (int i = 1; i < dataList.Count; i++)
            {
                if (max < dataList[i].Nezoszam)
                {
                    max = dataList[i].Nezoszam;
                    maxIdx = i;
                }
            }
            Console.WriteLine($"6. feladat: Legmagasabb nézőszám a döntők során:" +
                $"\n\tSorszám (dátum):{dataList[maxIdx].Ssz.ArabSsz} ({dataList[maxIdx].Datum})" +
                $"\n\tGyőztes csapat: {dataList[maxIdx].Gyoztes}, szerzett pontok: {dataList[maxIdx].WinnerScore}" +
                $"\n\tVesztes csapat: {dataList[maxIdx].Vesztes}, szerzett pontok: {dataList[maxIdx].LooserScore}" +
                $"\n\tHelyszín: {dataList[maxIdx].Helyszin}" +
                $"\n\tVáros, állam: {dataList[maxIdx].VarosAllam}" +
                $"\n\tHelyszín: {max}");

            /*7. feladat: Készítsen új UTF-8 kódolású állományt SuperBowlNew.txt néven a kiadott minta szerint!
                Az állomány első sora a mezőneveket tartalmazza! A döntők számozásánál arab
                sorszámokat használjon! A győztes és vesztes csapatok nevei után zárójelben jelenítse meg,
                hogy a csapat hányadik Super Bowl szereplése volt a mérkőzés! (Tipp a megoldáshoz:
                ezt a részfeladatot úgy is megoldhatja, hogy elsőként az állomány sorait egy szöveges típusú
                listában tárolja, és az új sor hozzáadása előtt megszámolja, hogy az új sorba írandó csapatok
                nevei hányszor szerepeltek korábban ebben a listában, majd a teljes lista elkészülte után írja
                annak tartalmát az állományba.)*/
            List<string> output = new List<string>();
            output.Add("Ssz;Dátum;Győztes;Eredmény;Vesztes;Nézőszám");
            for (int i = 0; i < dataList.Count; i++)
            {
                int winnerCount = 0;
                int looserCount = 0;
                foreach (var sor in output)
                {
                    if (sor.Contains(dataList[i].Gyoztes)) winnerCount++;
                    if (sor.Contains(dataList[i].Vesztes)) looserCount++;
                }
                string winner = $"{dataList[i].Gyoztes} ({winnerCount + 1})";
                string looser = $"{dataList[i].Vesztes} ({looserCount + 1})";

                output.Add($"{dataList[i].Ssz.ArabSsz};{dataList[i].Datum};{winner};{dataList[i].Eredmeny};{looser};{dataList[i].Nezoszam}");
            }

            File.WriteAllLines("SuperBowlNew.txt", output, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}