
// artik yil veren kod

Console.Write("Enter year: ");
    int year = Int32.Parse(Console.ReadLine());
    if ((((year % 4) == 0) && ((year % 100) != 0) || ((year % 400) == 0)))
        Console.WriteLine("{0} is leap year.", year);
    else
        Console.WriteLine("{0} isn't a leap year.", year);


        // 200 le 100 arası 10 random

 Random r = new Random();
    for (int i = 0; i < 10; i++)
        Console.WriteLine(r.Next(100, 201));

        // girilen tarihe göre haftanın gününü veren program

    Console.Write("Enter year: ");
    int year = Int32.Parse(Console.ReadLine());
    Console.Write("Enter month: ");
    int month = Int32.Parse(Console.ReadLine());
    Console.Write("Enter day: ");
    int day = Int32.Parse(Console.ReadLine());
    
    DateTime dateValue = new DateTime(year, month, day);
    Console.WriteLine(dateValue.ToString("ddd"));


    //Verilen iki kenarı verilen bir dik üçgenin hipotenüsünü bulan bir program

    Console.Write("First side: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Second side: ");
    int b = Int32.Parse(Console.ReadLine());
    
    Console.Write("Hypotenuse is: " + Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)));

// Aşağıdaki verilen bir üçgenin alanını hesaplayan bir program yazın: a. Üç taraf; B. yan ve rakım; C. iki kenar ve aralarındaki açı derece cinsinden.


    public static void byThreeSides()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            float c = float.Parse(Console.ReadLine());
            float p = (a + b + c) / 2;
            Console.WriteLine("S is: {0}", (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
            Console.ReadLine();
        }

        public static void bySideAltitude()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter h(a): ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b) / 2);
            Console.ReadLine();
        }

        public static void byTwoSidesAngle()
        {
            Console.Write("\nEnter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter sine: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b * Math.Sin(c)) / 2);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculate the area of a triangle by given:");
                Console.WriteLine("1.Three side lengths.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine("4.Exit.");
                Console.Write("Enter choice from 1 to 4: ");
                choice = System.Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1: byThreeSides(); break;
                    case 2: bySideAltitude(); break;
                    case 3: byTwoSidesAngle(); break;
                }

            } while (choice != 4);
        }


// Geçerli tarih ile geçerli tarihten (dahil) sonraki belirli bir tarih arasındaki iş günü sayısını hesaplayan bir program yazın. İş günlerinin, Cumartesi'nin iş günü olduğu durumlar dışında, resmi tatil olmayan Pazartesi'den Cuma'ya kadar tüm günler olduğunu düşünün. Program, önceden tanımlanmış resmi tatillerin bir listesinin yanı sıra önceden tanımlanmış cumartesi günlerinin bir listesini tutmalıdır.

DateTime[] holidays = new DateTime[]
            {
                new DateTime(2014, 12, 24),
                new DateTime(2014, 12, 25),
                new DateTime(2015, 01, 01),
                new DateTime(2015, 01, 02),
                new DateTime(2015, 03, 02),
                new DateTime(2015, 03, 03),
                new DateTime(2015, 04, 10),
                new DateTime(2015, 04, 13),
                new DateTime(2015, 05, 01),
                new DateTime(2015, 05, 06),
                new DateTime(2015, 09, 21),
                new DateTime(2015, 09, 22),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25),
            };

            DateTime[] workSaturdays = new DateTime[]
            {
                new DateTime(2015, 01, 24),
                new DateTime(2015, 03, 21),
                new DateTime(2015, 09, 12),
                new DateTime(2015, 12, 12),
            };

            int workingDays = 0;

            Console.Write("Enter end date (YYYY/MM/DD): ");
            DateTime endDate = System.Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;

            do
            {
                now = now.AddDays(1);

                if((now.DayOfWeek >= DayOfWeek.Monday) && (now.DayOfWeek <= DayOfWeek.Friday))
                    workingDays++;

                foreach (var i in holidays)
                    if (i.Date == now.Date)
                        workingDays--;

                foreach (var i in workSaturdays)
                    if (i.Date == now.Date)
                        workingDays++;

            } while (now.Date != endDate.Date);

            Console.WriteLine("{0} working days.", workingDays);
        }


// Bir boşlukla ayrılmış sayılar dizisi olarak verilen bir pozitif tamsayı sayıları dizisi verilir. Toplamlarını hesaplayan bir program yazın. Örnek: "43 68 9 23 318" = 461.

int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');            

            for (int i = 0; i < splitNumbers.Length; i++)
                result += Convert.ToInt32(splitNumbers[i]);

            Console.WriteLine("Result is: {0}", result);

            // Bazı ürünler için rastgele reklam mesajı üreten bir program yazın. Mesaj, övücü bir cümle, ardından övücü bir hikaye, ardından yazar (adı ve soyadı) ve önceden tanımlanmış listelerden seçilen şehirden oluşmalıdır. Örneğin, aşağıdaki listelere sahip olalım: - Övgü cümleleri: {"Ürün mükemmel.", "Bu harika bir ürün.", "Bu ürünü sürekli kullanıyorum.", "Bu kategorideki en iyi ürün."}. - Övgü hikayeleri: {"Artık daha iyi hissediyorum.", "Değişmeyi başardım.", "Bir mucize yarattı.", "İnanamıyorum ama şimdi harika hissediyorum.", "Denemelisiniz. ben de çok memnunum."}. - Yazarın adı: {"Dayan", "Stella", "Hellen", "Kate"}. - Yazarın soyadı: {"Johnson", "Peterson", "Charls"}. - Şehirler: {"Londra", "Paris", "Berlin", "New York", "Madrid"}.

            Random rnd = new Random();
            string[] firstNames = new string[] { "Diana", "Petia", "Stela", "Elena", "Katia" };
            string[] secondNames = new string[] { "Ivanova", "Petrova", "Kirova", "Popova" };
            string[] cities = new string[] { "Sofia", "Plovdiv", "Varna", "Ruse", "Dolno konare" };
            string[] reviews1 = new string[] { "This product is excelent.", "This is a great product.", "I use this product all the time.", "This is the best product of this category." };
            string[] reviews2 = new string[] { "Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feel better.", "Try it yourself. I'm very greatful." };

            Console.WriteLine("{0} {1}\n-- {2} {3}, {4}.", reviews1[rnd.Next(4)], reviews2[rnd.Next(5)], firstNames[rnd.Next(5)], secondNames[rnd.Next(4)], cities[rnd.Next(5)]);
        

        // Bir dize olarak verilen belirli bir sayısal ifadenin değerini hesaplayan bir program yazın. Sayısal ifade şunlardan oluşur: - gerçek sayılar, örneğin 5, 18.33, 3.14159, 12.6; - aritmetik işlemler: +, -, *, / (standart öncelikleriyle birlikte); - matematiksel fonksiyonlar: ln(x), sqrt(x), pow(x, y); - operasyonların önceliklerini değiştirmek için parantezler: ( ve ). Sayısal ifadelerin öncelikleri olduğuna dikkat edin, örneğin -1 + 2 + 3 * 4 - 0,5 = (-1) + 2 + (3 * 4) - 0,5 = 12,5 ifadesi. Yönergeler: Sayısal bir ifadeyi hesaplamak oldukça zordur ve yeni başlayan bir programcının dışarıdan yardım almadan doğru şekilde çözmesi pek olası değildir. Başlangıç ​​olarak, bir ifadenin postfix notasyonundan (ters Polonya notasyonu) nasıl dönüştürüleceğini açıklayan "Shunting-yard algoritması" hakkındaki Wikipedia makalesine ve bir postfix ifadesinin hesaplanmasına ilişkin makaleye göz atın. Gerçekten çok özel durumlar var, bu yüzden çözümünüzü dikkatlice test ettiğinizden emin olun.

        public static string equation;
        public static string[] equationArr = new string[50];
        public static string[] actions = new string[50];
        public static string[] numbers = new string[50];
        public static bool change = false;
        public static double result = 0;
        public static double temp = 0;
        public static byte depth = 0;
        public static byte brakets = 0;

        public static void removeNulls()
        {
            numbers = numbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            actions = actions.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        static void Main(string[] args)
        {            
            Console.WriteLine("Enter equation: ");
            equation = Console.ReadLine();
            equationArr = equation.Split(' ');            

            for(int i = 0; i < equationArr.Length; i++)
            {
                if (change) actions[i] = equationArr[i];
                else numbers[i] = equationArr[i];
                change = change ? false : true;                
            }
            removeNulls();

            do
            {
                for (int i = 0; i < actions.Length; i++)
                    if (i == 0)
                        if (actions[i] == "*" || actions[i] == "/")
                        {
                            if (actions[i] == "*") 
                                temp = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
                            else temp += Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);

                            numbers[0] = temp.ToString();
                            actions[i] = numbers[1] = null;
                            temp = 0;
                            removeNulls();
                        }
                    else
                        do
                        {
                            if (actions[i] == "*" || actions[i] == "/")
                            {
                                if (actions[i] == "*") temp = Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);
                                else temp += Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);
                                numbers[i] = temp.ToString();
                                actions[i] = numbers[i + 1] = null;
                                temp = 0;
                                removeNulls();
                                if (depth > 0) depth--;
                            }
                            foreach (var s in actions)
                                if (s == "*" || s == "/") depth++;
                        } while (depth != 0);

                for (int i = 0; i < actions.Length; i++)
                    Console.WriteLine(actions[i]);

                for (int i = 0; i < numbers.Length; i++)
                    Console.WriteLine(numbers[i]);

                Console.WriteLine("Continue {0} to +-", result);
                Console.ReadLine();

                for (int i = 0; i < actions.Length; i++)
                    if (i == 0)
                        if (actions[i] == "+" || actions[i] == "-")
                        {
                            if (actions[i] == "+") 
                                numbers[0] = (Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1])).ToString();
                            else numbers[0] = (Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1])).ToString();

                            actions[i] = numbers[1] = null;
                            removeNulls();
                            i--;
                        }                    
                    else
                        do
                        {
                            if (actions[i] == "+" || actions[i] == "-")
                            {
                                if (actions[i] == "+") 
                                    numbers[i] = (Convert.ToDouble(numbers[i]) + Convert.ToDouble(numbers[i + 1])).ToString();
                                else numbers[i] = (Convert.ToDouble(numbers[i]) - Convert.ToDouble(numbers[i + 1])).ToString();

                                actions[i] = numbers[i + 1] = null;
                                removeNulls();
                                if (depth > 0) depth--;
                            }
                            foreach (var s in actions)
                                if (s == "+" || s == "-") depth++;
                        } while (depth != 0);

                for (int i = 0; i < actions.Length; i++)
                    Console.WriteLine("actions {0}",actions[i]);

                for (int i = 0; i < numbers.Length; i++)
                    Console.WriteLine("numbers {0}", numbers[i]);
            } while (numbers.Length > 1);

            Console.WriteLine("Result is {0}", numbers);

            // Konsoldan pozitif bir tamsayı alan ve bu tamsayının karekökünü yazdıran bir program yazın. Giriş negatif veya geçersizse konsolda \"Geçersiz Numara\" yazdırın. Her durumda \"Hoşçakal\" yazdırın.

            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
            }
            finally
            {
                if (n < 0)
                {
                    if (!invalidNumber) Console.WriteLine("Invalid number!");
                }
                else Console.WriteLine(Math.Sqrt(n));
            }

            Console.WriteLine("Good Bye");

            // [start…end] aralığında konsoldan bir tamsayı okuyan ReadNumber(int start, int end) yöntemini yazın. Giriş tamsayısının geçerli olmaması veya gerekli aralıkta olmaması durumunda uygun istisnayı atın. Bu yöntemi kullanarak, 10 a1, a2, …, a10 tamsayısını 1 < a1 < … < a10 < 100 olacak şekilde bir program yazın.

            int count = 1, number;

            do
            {
                Console.Write("Number{0}: ", count);
                number = Int32.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine("Wrong input!");
                    break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
        }

        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = Int32.Parse(Console.ReadLine());
            
            if (end <= start + 10)
                Console.WriteLine("Wrong input");
            else
                ReadNumber(start, end);

                // Bir metin dosyasının adını parametre olarak alan, dosyayı okuyan ve içeriğini dize olarak döndüren bir yöntem yazın. İstisna atılırsa yöntem ne yapmalıdır?

                try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

                // Kullanıcıdan bir dosyanın tam yolunu (örneğin C:\\Windows\\win.ini) alan, dosyanın içeriğini okuyan ve konsola yazdıran bir program yazın. System.IO.File.ReadAllText(…) yöntemini nasıl kullanacağınızı MSDN'de bulun. Tüm olası istisnaların

                try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Ivan\Desktop\text.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Invalid syntax!");

                // Verilen URL ile İnternetten dosya indiren bir program yazın, ör. (http://www.devbg.org/img/Logo-BASD.jpg).

                WebClient Client = new WebClient();

            try 
            {
                Client.DownloadFile("http://3.bp.blogspot.com/-qXtmJRAlJcA/U413iy_YzKI/AAAAAAAAOn8/Ajr4B8h9TcE/s1600/google-logo-high-res.png", @"D:\OneDrive\Masaüstü\ppler\image.png");            
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address or fileName parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }


// yazilanı tersine cevir

Console.Write("Enter text to reverse: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            input = sb.ToString();

            Console.WriteLine("Reversed: \"{0}\"", input);
            Console.ReadLine();

            // Parantezlerin yerleştirilip yerleştirilmediğini kontrol eden bir program yazınaritmetik bir ifadede doğru. ile ifade örneği doğru yerleştirilmiş parantezler: ((a+b)/5-d). Yanlış bir örnekifade: )(a+b))).

            Console.Write("Enter equation: ");
            string input = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') counter++;
                if (input[i] == ')') counter--;
                if (counter < 0) break;                
            }

            if (counter == 0) Console.WriteLine("Correct equation.");
            else Console.WriteLine("Wrong equation!");

            Console.ReadLine();

            // Yönteme argüman olarak kaç tane ters eğik çizgi belirtmeniz gerekir Metni ters eğik çizgi ile bölmek için Böl(…)?

            string s = @"one\two\three";
            string[] sArr = s.Split('\\');
            foreach (string word in sArr) Console.WriteLine(word);            
            Console.ReadLine();

// Bir alt dizenin kaç kez içerdiğini algılayan bir program yazın. Metin. Örneğin, metinde "in" alt dizesini arayalım:

 Console.WriteLine("Aramak istediginiz kelimeyi girin");
            string aranacak = Console.ReadLine();
						string metin= "mustafa";
            Regex r = new Regex(aranacak);
            int count = r.Matches(metin).Count;
            Console.WriteLine(count); 
            // dieri altta 
            int counter = 0;
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(str);
            str = str.ToLower();
            Console.Write("\nEnter substring to search: ");
            string substr = Console.ReadLine().ToLower();

            int i = str.IndexOf(substr);

            if (i != -1)
            {
                counter++;

                while (i != -1 && counter >= 1)
                {
                    i = str.IndexOf(substr, i + substr.Length);
                    counter++;
                }

                counter--;
            }

            Console.WriteLine("'{0}' is found {1} times in the text.", substr, counter);
            Console.ReadLine();

            // Bir metin verilir. Harflerin büyük/küçük harflerini şu şekilde değiştiren bir program yazın.<upcase> ile çevrili metindeki tüm yerlerde büyük harf ve </upcase> etiketleri. Etiketler yuvalanamaz.

            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.", insideTag;
            int startUpCase, endUpCase;

            Console.WriteLine("Original text: \n{0}\n", text);

            do
            {
                startUpCase = text.IndexOf("<upcase>", 0) + 8;
                endUpCase = text.IndexOf("</upcase>", startUpCase);
                insideTag = text.Substring(startUpCase, endUpCase - startUpCase).ToUpper();
                text = text.Remove(startUpCase, endUpCase - startUpCase);
                text = text.Insert(startUpCase, insideTag);
                text = text.Remove(startUpCase - 8, 8);
                text = text.Remove(endUpCase - 8, 9);
            } while (text.Contains("<upcase>") && text.Contains("</upcase>"));

            Console.WriteLine("Modified text: \n{0}\n", text);
            Console.ReadLine();


// Konsoldan bir dize okuyan bir program yazın (20 karakter maksimum) ve daha kısaysa, 20 karaktere kadar "*" ile tamamlar.

Console.Write("Input text (20 char max): ");
            string text = Console.ReadLine();

            text = text.PadRight(20, '*');

            Console.WriteLine(text);
            Console.ReadLine();

            // Verilen bir dizgiyi dizi biçimine çeviren bir program yazınız.C# dilinde kullanılan biçimdeki Unicode kaçış dizileri.Örnek giriş: "Test". Sonuç: "\u0054\u0065\u0073\u0074"

            Console.Write("Input text: ");
            string text = Console.ReadLine();
            foreach (char c in text) Console.Write("\\u{0:x4}", ((int)c));
            Console.ReadLine();

            // Bir metinden aşağıdakileri içeren tüm cümleleri çıkaran bir program yazın.belirli bir kelime. Cümlelerin birbirinden ayrıldığını kabul ediyoruz."." karakteri ile birbirlerine ve kelimeler birinden ayrılırbaşka bir harf olmayan bir karakterle

string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string[] sentences = text.Split('.');

            foreach (string str in sentences)
                if (str.IndexOf(" in ") != -1 || str.IndexOf("In ") != -1) Console.WriteLine(str + '.');

            Console.ReadLine();

//////////////////////////////////////////////

Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);


// İle ayrılmış birkaç "yasak" kelimeden oluşan bir dize verilir. virgül. Ayrıca bu kelimeleri içeren bir metin verilir. Bir program yaz yasak kelimeleri yıldızlarla değiştiren

string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.", forbiddenWords = "C#,CLR,Microsoft";
            string[] forbiddenWordsArr = forbiddenWords.Split(',');
            string[] censoredForbiddenWordsArr = new string[forbiddenWordsArr.Length];

            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                censoredForbiddenWordsArr[i] = new string('*', forbiddenWordsArr[i].Length);

            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                text = text.Replace(forbiddenWordsArr[i], censoredForbiddenWordsArr[i]);

            Console.WriteLine(text);
            Console.ReadLine();


// Konsoldan bir sayı okuyan ve 15'te yazdıran bir program yazın.karakter alanı, birkaç şekilde sağa hizalanmış: ondalık sayı olarak,onaltılık sayı, yüzde, para birimi ve üstel (bilimsel)gösterim

Console.Write("Input number: ");
            int number = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0, -15} {1, 15}", "Decimal:", number);
            Console.WriteLine("{0, -15} {1, 15}", "Hexadecimal:", number.ToString("X"));
            Console.WriteLine("{0, -15} {1, 15}", "Currency:", string.Format("{0:C}", number));
            Console.WriteLine("{0, -15} {1, 15}", "Percent:", string.Format("{0:P2}", number));
            Console.WriteLine("{0, -15} {1, 15}", "Scientific:", number.ToString("\\0.#####E0"));
            Console.ReadLine();

            // Verilen bir cümledeki kelimeleri ters çeviren bir program yazınız.noktalama işaretlerini ve boşlukları değiştirme. Örneğin: "C#, C++ değildir vePHP Delphi değildir"  "Delphi PHP değildir ve C++ C# değildir

public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string text = "C# is not C++ and PHP is not Delphi";

            text = Reverse(text);

            string[] textArr = text.Split(' ');

            text = "";

            foreach (string s in textArr) text += Reverse(s) + ' ';

            Console.WriteLine(text);
            Console.ReadLine();

            // Birkaç satırlık metinden oluşan bir sözlük verilmiştir. Her çizgikısa çizgi ile ayrılmış bir sözcük ve açıklamasından oluşur

string dictionary = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes\n";
            string[] tempDictionary = new string[10];

            tempDictionary = dictionary.Split(new string[] { "\n" }, StringSplitOptions.None);

            Console.Write("Enter word: ");
            string input = Console.ReadLine() + " - ";

            foreach (string str in tempDictionary)
            {
                if (str.Contains(input)) Console.WriteLine(str.Substring(input.Length));
            }
            Console.ReadLine();

            // Bir HTML belgesindeki tüm köprüleri değiştiren bir program yazın<a href="…">…</a> ve "forum" tarzındaki köprülerden oluşan,[URL=…]…[/URL] gibi görünün


string text = "<p>Please visit <a href=\"http://softuni.bg\">our site</a> to choose a software engineering training course. Also visit<a href=\"http://softuni.bg" + "/forum\">our forum</a> to discuss the courses.</ p >";
            text = text.Replace("<a href=\"", "[URL=");
            text = text.Replace("\">", "]");
            text = text.Replace("</a>", "[/URL]");

            Console.WriteLine(text);
            Console.ReadLine();

            // Formatında girilen iki tarihi okuyan bir program yazın"gün.ay.yıl" ve aralarındaki gün sayısını hesaplar.

Console.Write("Enter first date: ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date: ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); ;

            Console.WriteLine("Distance: {0} days", endDate.Subtract(startDate).TotalDays);
            Console.ReadLine();

