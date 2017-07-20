using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Formula
{
    public partial class Form1 : Form
    {


        int[][] breakdown =
{
            new int[] { 0 },
            new int[] { 1 },
            new int[] { 2 },
            new int[] { 3 },
            new int[] { 4 },
            new int[] { 5 },
            new int[] { 6 },
            new int[] { 7 },
            new int[] { 8 },
            new int[] { 9 },
            new int[] { 10, 1 },
            new int[] { 11, 0,2,3,5 },
            new int[] { 12, 1, 3 },
            new int[] { 13, 2, 4 },
            new int[] { 14, 3, 5 },
            new int[] { 15, 4, 6 },
            new int[] { 16, 5, 7 },
            new int[] { 17, 6, 8 },
            new int[] { 18, 7, 9 },
            new int[] { 19, 8, 10, 1, 20, 2 },
            new int[] { 20, 2},
            new int[] { 21, 1, 3},
            new int[] { 22, 0, 4, 5, 9},
            new int[] { 23, 1, 5},
            new int[] { 24, 2, 6},
            new int[] { 25, 3, 7},
            new int[] { 26, 4, 8},
            new int[] { 27, 5, 9},
            new int[] { 28, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8},
            new int[] { 29, 7, 11, 0, 2, 20, 2, 21, 1, 3, 41, 3, 5},
            new int[] { 30, 3},
            new int[] { 31, 2, 4},
            new int[] { 32, 1, 5},
            new int[] { 33, 0, 6, 7, 13, 2, 4},
            new int[] { 34, 1, 7},
            new int[] { 35, 2, 8},
            new int[] { 36, 3, 9},
            new int[] { 37, 4, 10, 1, 15, 4, 6, 16, 5, 7, 31, 2, 4},
            new int[] { 38, 5, 11, 0, 2, 18, 7, 9, 19, 8, 10, 1, 20, 2 , 37, 4, 10, 1, 15, 4, 6, 16, 5, 7, 31, 2, 4},
            new int[] { 39, 6, 12, 1, 3, 22, 0, 4, 5, 9},
            new int[] { 40, 4},
            new int[] { 41, 3, 5},
            new int[] { 42, 2, 6},
            new int[] { 43, 1, 7},
            new int[] { 44, 0, 8, 9, 17},
            new int[] { 45, 1, 9},
            new int[] { 46, 2, 10, 1, 13, 2, 4, 14, 3, 5, 27, 5, 9 },
            new int[] { 47, 3, 11, 0, 2, 16, 5, 7, 17, 6, 8, 33, 0, 6, 7, 13, 2, 4},
            new int[] { 48, 4, 12, 1, 3, 20, 2},
            new int[] { 49, 5, 13, 2, 4, 24, 2, 6 },
            new int[] { 50, 5},
            new int[] { 51, 4, 6},
            new int[] { 52, 3, 7},
            new int[] { 53, 2, 8},
            new int[] { 54, 1, 9},
            new int[] { 55, 0, 10, 1, 11, 0, 2, 3, 5, 13, 2, 4, 24, 2, 6},
            new int[] { 56, 1, 11, 0, 2, 14, 3, 5, 15, 4, 6, 29, 7, 11, 0, 2, 20, 2, 21, 1, 3, 41, 3, 5},
            new int[] { 57, 2, 12, 1, 3, 18, 7, 9},
            new int[] { 58, 3, 13, 2, 4, 22, 0, 4, 5, 9},
            new int[] { 59, 4, 14, 3, 5, 26, 4, 8},
            new int[] { 60, 6},
            new int[] { 61, 5, 7},
            new int[] { 62, 4, 8},
            new int[] { 63, 3, 9},
            new int[] { 64, 2, 10, 1, 13, 2, 4, 14, 3, 5, 27, 5, 9},
            new int[] { 65, 1, 11, 0, 2, 14, 3, 5, 15, 4, 6, 29, 7, 11, 0, 2, 20, 2, 21, 1, 3, 41, 3, 5},
            new int[] { 66, 0, 12, 1, 3, 16, 5, 7, 17, 6, 8, 33, 0, 6, 7, 13, 2, 4},
            new int[] { 67, 1, 13, 2, 4, 20, 2},
            new int[] { 68, 2, 14, 3, 5, 24, 24, 2, 6 },
            new int[] { 69, 3, 15, 4, 6, 28, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8},
            new int[] { 70, 7},
            new int[] { 71, 6, 8},
            new int[] { 72, 5, 9},
            new int[] { 73, 4, 10, 1, 15, 4, 6, 16, 5, 7, 31, 2, 4 },
            new int[] { 74, 3, 11, 0, 2, 16, 5, 7, 17, 6, 8, 33, 0, 6, 7, 13, 2, 4 },
            new int[] { 75, 2, 12, 1, 3, 18, 7, 9 },
            new int[] { 76, 1, 13, 2, 4, 20, 2 },
            new int[] { 77, 0, 14, 3, 5, 22, 0, 4, 5, 9, 23, 1, 5, 45, 1, 9 },
            new int[] { 78, 1, 15, 4, 6, 26, 26, 4, 8 },
            new int[] { 79, 2, 16, 5, 7, 30, 3},
            new int[] { 80, 8},
            new int[] { 81, 7, 9},
            new int[] { 82, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8 },
            new int[] { 83, 5, 11, 0, 2, 18, 7, 9, 19, 8, 10, 1, 20, 2, 37, 4, 10, 1, 15, 4, 6, 16, 5, 7, 31, 2, 4 },
            new int[] { 84, 4, 12, 1, 3, 20, 2 },
            new int[] { 85, 3, 13, 2, 4, 22, 0, 4, 5, 9 },
            new int[] { 86, 2, 14, 3, 5, 24, 2, 6 },
            new int[] { 87, 1, 15, 4, 6, 26, 4, 8 },
            new int[] { 88, 0, 16, 5, 7, 28, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8, 29, 7, 11, 0, 2, 20, 2, 21, 1, 3, 41, 3, 5, 57, 2, 12, 1, 3, 18, 7, 9 },
            new int[] { 89, 1, 17, 6, 8, 32, 1, 5},
            new int[] { 90, 9},
            new int[] { 91, 8, 10, 1, 20, 2 },
            new int[] { 92, 7, 11, 0, 2, 20, 2, 21, 1, 3, 41, 3, 5 },
            new int[] { 93, 6, 12, 1, 3, 22, 0, 4, 5, 9 },
            new int[] { 94, 5, 13, 2, 4, 24, 2, 6 },
            new int[] { 95, 4, 14, 3, 5, 26, 4, 8 },
            new int[] { 96, 69, 3, 15, 4, 6, 28, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8 },
            new int[] { 97, 2, 16, 5, 7, 30, 3 },
            new int[] { 98, 1, 17, 6, 8, 32, 1, 5 },
            new int[] { 99, 0, 18, 7, 9, 34, 1, 7, 35, 2, 8, 69, 3, 15, 4, 6, 28, 6, 10, 1, 17, 6, 8, 18, 7, 9, 35, 2, 8},
        };

        List<int> DateList = new List<int>();
        List<int> TimeList = new List<int>();
        int sameCount = 0;
        int TIME = 0;
        string up_down = "";
        string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string time1 = Time1_Text.Text;
            string time2 = Time2_Text.Text;
            string date = Date_Text.Text;
            step1(time1, time2, date);
            log.Text = message;
        }

        private void clearFormula()
        {
            up_down = "";
            message = "";
            DateList.Clear();
            TimeList.Clear();
            sameCount = 0;
        }

        private string step1(string time1, string time2, string date)
        {
            // STEP1) If we use 9
            // Then 9 + 12 = 21 next nearest 9 same is 27, so 27 - 21 = 6
            // Then 9 + 16 = 25 next nearest 9 same is 27, so 27 - 25 = 2
            // So here we have 6 + 2 = 8
            clearFormula();
            int h1 = int.Parse(time1.Split(':')[0]);
            int m1 = int.Parse(time1.Split(':')[1]);
            int h2 = int.Parse(time2.Split(':')[0]);
            int m2 = int.Parse(time2.Split(':')[1]);
            int check = int.Parse(Check_Text.Text);
            message += "STEP1) If we use " + h1.ToString() + Environment.NewLine;
            message += "Then " + h1.ToString() + " + " + m1.ToString() + " = " + (h1 + m1).ToString() + " next nearest " + check.ToString() + " same is " + nearest(h1 + m1, check) + ", ";
            int same1 = nearest(h1 + m1, check) - (h1 + m1);
            if (nearest(h1 + m1, check) == 0) same1 = 0;
            message += " So" + same1.ToString() + Environment.NewLine;

            message += "Then " + h2.ToString() + " + " + m2.ToString() + " = " + (h2 + m2).ToString() + " next nearest " + check.ToString() + " same is " + nearest(h2 + m2, check) + ", ";
            int same2 = nearest(h2 + m2, check) - (h2 + m2);
            if (nearest(h2 + m2, check) == 0) same2 = 0;
            message += " So" + same2.ToString() + Environment.NewLine;

            message += "So here we have " + same1.ToString() + " + " + same2.ToString() + " = " + (same1 + same2).ToString() + Environment.NewLine + Environment.NewLine;
            int setp1Count = same1 + same2;
            // STEP2) Compare time and date
            // So time is 9,12,9,16 and date 20,21,17,07,11 compare is 4 same
            message += "STEP2) Compare time and date" + Environment.NewLine;
            dateAdd(date);
            message += "So time " + h1.ToString() + ", " + m1.ToString() + ", " + h2.ToString() + ", " + m2.ToString() + " and date " + messageAdd(DateList) + " compare is ";

            int count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                count += breakdown_Same(h1, DateList[i]);
                count += breakdown_Same(h2, DateList[i]);
                count += breakdown_Same(m1, DateList[i]);
                count += breakdown_Same(m2, DateList[i]);
            }
            message += count.ToString() + " same" + Environment.NewLine;

            int totalCount = count;

            // Take note middle 91 can check with date for 12=12=21 exact same
            int middle1 = h1 % 10 * 10 + m1 / 10;
            int middle2 = h2 % 10 * 10 + m2 / 10;
            message += "Check " + middle1.ToString() + ", " + middle2.ToString() + " with date for exactsame ";
            count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {

                    count += breakdown_Same(middle1, DateList[i]);
                
            }
            for (int i = 0; i < DateList.Count; i++)
            {

                    count += breakdown_Same(middle2, DateList[i]);
                
            }
            message += count.ToString() + " same" + Environment.NewLine;
            // So here is 20 same
            totalCount += count;
            message += "So here is " + totalCount.ToString() + " same" + Environment.NewLine;

            // And also 14+36=50 14+42=56 check with date and time for 12=12=21 exact same and here no need 0=1
            message += "And also " + (h1 + m1).ToString() + ", " + (h2 + m2) + " check with date and time for 12=12=21 exact same is ";
            count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                for (int j = 0; j < breakdown[h1+m1].Length; j++)
                {
                    count += exactSame(breakdown[h1 + m1][j], DateList[i]);
                }
                for (int j = 0; j < breakdown[h2+ m2].Length; j++)
                {
                    count += exactSame(breakdown[h2 + m2][j], DateList[i]);
                }
            }
            for (int i = 0; i < TimeList.Count; i++)
            {
                for (int j = 0; j < breakdown[h1 + m1].Length; j++)
                {
                    count += exactSame(breakdown[h1 + m1][j], TimeList[i]);
                }
                for (int j = 0; j < breakdown[h2 + m2].Length; j++)
                {
                    count += exactSame(breakdown[h2 + m2][j], TimeList[i]);
                }
            }
            message += count.ToString() + Environment.NewLine;
            totalCount += count;
            // So total is 20 + 6 = 26, here no exact same
            message += "So total is " + totalCount.ToString() + Environment.NewLine + Environment.NewLine;

            // STEP3) Now final same 26+5=31 so no more exact same so is odd is down
            totalCount += setp1Count;

            List<int> newStep1 = new List<int>();
            newStep1.Add(totalCount);
            message += "STEP3) Now final same " + totalCount.ToString() + " so is ";
            string result = "down";
            if (totalCount % 2 == 0) result = "up";
            else result = "down";
            message += result + Environment.NewLine+ Environment.NewLine;

            message += "STEP4) " + (h1 * 100 + m1).ToString() + " + " + (h2 * 100 + m2).ToString() + " = " + (h1 * 100 + m1 + h2 * 100 + m2).ToString() + " is ";
            newStep1.Add(h1 * 100 + m1);
            newStep1.Add(h2 * 100 + m2);
            newStep1.Add(h1 * 100 + m1 + h2 * 100 + m2);
            int sum = h1 * 100 + m1 + h2 * 100 + m2;
            int sum1 = sum / 100;
            int sum2 = sum % 100;
            sum = sum1 + sum2;
            List<int> stepList4 = new List<int>();
            if (sum < 100)
            {
                stepList4.Add(sum);
            }
            else
            {
                sum1 = sum / 10;
                sum2 = sum % 10;
                if (sum1 % 10 != 0 && sum2 != 0)
                {
                    stepList4.Add(sum1 + sum2);
                }
                else
                {
                    int x = sum1 + sum2;
                    stepList4.Add(x);
                    int y = x;
                    if (sum1 % 10 == 0) y++;
                    if (sum2 == 0) y++;
                    stepList4.Add(y);
                    stepList4.Add(x + y);
                }
            }

            message += messageAdd(stepList4) + " with date same is ";
            count = 0;
            for (int i = 0; i < stepList4.Count; i++)
            {
                for (int j = 0; j < DateList.Count; j++)
                {
                    count += exactSame(stepList4[i], DateList[j]);
                }
//                 for (int j = 0; j < TimeList.Count; j++)
//                 {
//                     count += exactSame(stepList4[i], TimeList[j]);
//                 }
            }
            message += count.ToString();

            if (count % 2 == 0)
            {
                message += " no opposite";
            }
            else
            {
                message += " opposite";
                if (result == "down") result = "up";
                else result = "down";
            }
            newStep1.Add(stepList4[0]);
            message += Environment.NewLine + "Result is " + result + Environment.NewLine;

            message += "=============================================" + Environment.NewLine;
            totalCount = 0;
            message += "Here we use " + messageAdd(newStep1) + Environment.NewLine;
            int step1count = newStep1[0] + newStep1[4];
            message += "STEP1) " + newStep1[0].ToString() + " + " + newStep1[4].ToString() + " = " + step1count.ToString() + Environment.NewLine;
            message += "STEP2) " + step1count.ToString() + ", " + newStep1[0].ToString() + ", " + newStep1[4].ToString() + " for breakdown same ";
            count = 0;
            count += breakdown_Same(step1count, newStep1[0]);
            count += breakdown_Same(step1count, newStep1[4]);
            message += count.ToString() + " same " + Environment.NewLine;
            totalCount += count;
            message += "STEP3) ";

            List<int> newStep3 = new List<int>();
            newStep3.Add(newStep1[1] / 100);
            newStep3.Add(newStep1[1] % 100 / 10);
            newStep3.Add(newStep1[1] % 10);

            newStep3.Add(newStep1[2] / 100);
            newStep3.Add(newStep1[2] % 100 / 10);
            newStep3.Add(newStep1[2] % 10);

            newStep3.Add(newStep1[3] / 100);
            newStep3.Add(newStep1[3] % 100 / 10);
            newStep3.Add(newStep1[3] % 10);

            message += messageAdd(newStep3) + " compare  with breakdown " + step1count.ToString() + " same is ";
            count = 0;
            for (int i = 0; i < newStep3.Count; i++)
            {
                 count += breakdown_Same(newStep3[i], step1count);                
            }
            message += count.ToString() + Environment.NewLine;

            totalCount += count;
            message += "STEP4) All smae count " + totalCount.ToString() + " same is ";
            count = 0;
            for (int i = 0; i < newStep3.Count; i++)
            {
                count += breakdown_Same(newStep3[i], totalCount + step1count);
            }
            message += messageAdd(newStep3) + " compare  with breakdown " + (totalCount + step1count).ToString() + " same is " + count.ToString() + Environment.NewLine;
            List<int> newStep6 = new List<int>();
            totalCount += count;
            message += "STEP5) All smae count " + totalCount.ToString() + " same is ";
            count = 0;
            for (int i = 0; i < newStep3.Count; i++)
            {
                count += breakdown_Same(newStep3[i], totalCount + step1count);
            }
            message += messageAdd(newStep3) + " compare  with breakdown " + (totalCount + step1count).ToString() + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;
            newStep6.Add(totalCount + step1count);
            newStep6.Add(count);
            message += "STEP6) " + totalCount.ToString();
            newStep6.Add(totalCount);
            if (count % 2 == 0)
            {
                message += " no opposite";
            }
            else
            {
                message += " opposite";
                if (result == "down") result = "up";
                else result = "down";
            }
            message += Environment.NewLine;
            count = 0;
            message += "Result is " + result;
            return result;
            //
//             message += "Here use " + messageAdd(newStep6) + Environment.NewLine;
//             message += "STEP7) Check " + messageAdd(newStep6) + " for 9 and exact same is ";
//             for (int i = 0; i < newStep6.Count; i++)
//             {
//                 count += breakdown_Same(newStep6[i], 9);
//             }
//             for (int i = 0; i < newStep6.Count - 1; i++)
//             {
//                 for (int j = i + 1; j < newStep6.Count; j++)
//                 {
//                     count += exactSame(newStep6[i], newStep6[j]);
//                 }
//             }
//             message += count.ToString();
            

        }
        private int breakdown_Same(int d, int t)
        {
            if (d > 99) d = d / 10 + d % 10;
            if (t > 99) t = t / 10 + t % 10;
            //11,22,33,44 is 5 same
            if (d == t)
            {
                if (d == 11 || d == 22 || d == 33 || d == 44)
                {
                    return 5;
                }
            }
            //55,66,77,88,99 is 3 same
            if (d == t)
            {
                if (d == 55 || d == 66 || d == 77 || d == 88 || d == 99)
                {
                    return 3;
                }
            }
            int count = 0;
            //12,21,24,42,36,63,19,91
            if (t > 9 && d > 9)
            {
                if (d == 24 || d == 42)
                {
                    if ( t == 2 )
                    {
                        return 2;
                    }
                }
                if (d == 12 || d == 21 || d == 19 || d == 91)
                {
                    if (t == 1)
                    {
                        return 2;
                    }
                }
                if (d == 36 || d == 63)
                {
                    if (t == 3)
                    {
                        return 2;
                    }
                }

                if (t == 24 || t == 42)
                {
                    if (d == 2)
                    {
                        return 2;
                    }
                }
                if (t == 12 || t == 21 || t == 19 || t == 91)
                {
                    if (d == 1)
                    {
                        return 2;
                    }
                }
                if (t == 36 || t == 63)
                {
                    if (d == 3)
                    {
                        return 2;
                    }
                }
            }

//             // 13 = 13 is 3 same
//             if (t == d && t > 9)
//             {
//                 return 3;
//             }
//             // 13 = 31 is 3 same
//             int x = Int32.Parse(Reverse(d.ToString()));
//             if (t == x && t > 9)
//             {
//                 return 1;
//             }
            count = 0;
            for (int i = 0; i < breakdown[t].Length; i++)
            {
                for (int j = 0; j < breakdown[d].Length; j++)
                {
                    count += addCount(breakdown[t][i], breakdown[d][j]);
                }
            }
            return count;
        }

        public int addCount(int d, int t)
        {
            //11,22,33,44 is 5 same
            if (d == t)
            {
                if (d == 11 || d == 22 || d == 33 || d == 44)
                {
                    return 5;
                }
            }
            //55,66,77,88,99 is 3 same
            if (d == t)
            {
                if (d == 55 || d == 66 || d == 77 || d == 88 || d == 99)
                {
                    return 3;
                }
            }
            int count = 0;
            //12,21,24,42,36,63,19,91
            if (t > 9 && d > 9)
            {
                if (d == 24 || d == 42)
                {
                    if (t == 2)
                    {
                        return 2;
                    }
                }
                if (d == 12 || d == 21 || d == 19 || d == 91)
                {
                    if (t == 1)
                    {
                        return 2;
                    }
                }
                if (d == 36 || d == 63)
                {
                    if (t == 3)
                    {
                        return 2;
                    }
                }

                if (t == 24 || t == 42)
                {
                    if (d == 2)
                    {
                        return 2;
                    }
                }
                if (t == 12 || t == 21 || t == 19 || t == 91)
                {
                    if (d == 1)
                    {
                        return 2;
                    }
                }
                if (t == 36 || t == 63)
                {
                    if (d == 3)
                    {
                        return 2;
                    }
                }
            }

            if (d == t) return 1;

            return 0;
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void dateAdd(string date)
        {
            char[] myArray = date.ToCharArray();

            List<int> dateArray = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int x = Int32.Parse(myArray[i].ToString() + myArray[i + 1].ToString());
                if (x > 10)
                {
                    dateArray.Add(x);
                }
            }
            if (myArray[1].ToString() == "0" && myArray[2].ToString() != "0")
                dateArray.Add(Int32.Parse(myArray[0].ToString() + myArray[2].ToString()));
            if (myArray[1].ToString() == "0" && myArray[2].ToString() == "0")
                dateArray.Add(Int32.Parse(myArray[0].ToString() + myArray[3].ToString()));
            dateArray.Add(Int32.Parse(myArray[4].ToString() + myArray[5].ToString()));
            dateArray.Add(Int32.Parse(myArray[6].ToString() + myArray[7].ToString()));
            for (int i = 0; i < dateArray.Count; i++)
            {
                DateList.Add(dateArray[i]);
            }
        }

        private string messageAdd(List<int> list)
        {
            string msg = "";
            for (int i = 0; i < list.Count - 1; i++)
            {
                msg += list[i].ToString() + ", ";
            }
            msg += list[list.Count - 1].ToString();
            return msg;
        }
        private int nearest(int num, int check)
        {
            for (int j = 0; j < breakdown[num].Length; j++)
            {
                if (breakdown[num][j] == check) return 0;
            }
            for (int i = num+1; i < 100; i++)
            {
                for (int j = 0; j < breakdown[i].Length; j++)
                {
                    if (breakdown[i][j] == check) return i;
                }
            }
            return 0;
        }

        public int exactSame(int a, int b)
        {
            if (a > 9 && b > 9)
            {
                if (a == b) return 1;
                else if (a / 10 + a % 10 * 10 == b) return 1;
                else return 0;
            }
            else return 0;
        }


        Microsoft.Office.Interop.Excel.Workbook MyBook = null;
        Microsoft.Office.Interop.Excel.Application MyApp = null;
        Microsoft.Office.Interop.Excel.Worksheet MySheet = null;
        ThreadStart excelThread;
        Thread excelThread_Thread;
        string path = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExcelDialog = new OpenFileDialog();

            ExcelDialog.InitialDirectory = "c:\\";
            ExcelDialog.Title = "Select your team excel";
            ExcelDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            ExcelDialog.FilterIndex = 2;
            ExcelDialog.RestoreDirectory = true;

            if (ExcelDialog.ShowDialog() == DialogResult.OK)
            {
                path = ExcelDialog.FileName;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            excelThread = new ThreadStart(excelThreadStart);
            excelThread_Thread = new Thread(excelThread);
            excelThread_Thread.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private void excelThreadStart()
        {
            MyApp = new Microsoft.Office.Interop.Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(path);
            MySheet = (Microsoft.Office.Interop.Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            int lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
            int index = 2;
            try
            {
                for (index = 1; index <= lastRow; index++)
                {
                    this.Text = index.ToString();
                    this.Refresh();
                    try
                    {
                        System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "I" + index.ToString()).Cells.Value;

                        string date = MyValues.GetValue(1, 1).ToString().Replace(".", "");
                        string time1 = MyValues.GetValue(1, 2).ToString();
                        MyValues = (System.Array)MySheet.get_Range("A" + (index+1).ToString(), "I" + (index + 1).ToString()).Cells.Value;
                        string time2 = MyValues.GetValue(1, 2).ToString();
                        try
                        {
                            Date_Text.Text = date;
                            Time1_Text.Text = time1;
                            Time2_Text.Text = time2;
                        }
                        catch (System.Exception)
                        {                        	    
                        }
                        string str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 7] = str;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception)
            {
            }
            MyBook.Close(true);
            MyApp.Quit();
            MessageBox.Show("Done");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { MyBook.Close(true); } catch (Exception) { }
            try { MyApp.Quit(); } catch (Exception) { }
            try { excelThread_Thread.Abort(); } catch (Exception) { }
        }
    }
}
