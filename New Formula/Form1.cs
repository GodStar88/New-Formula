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
            
            newStep6.Add(totalCount + step1count);
            totalCount += count;
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
            message += "Result is " + result + Environment.NewLine;

            // message = "";
            ///////////////////////////// RULES THREE
            totalCount = 0;
            // Here we have 93 is one same for 9,;
            List<int> step7List = more100(newStep6[0]);
            for (int i = 0; i < step7List.Count; i++)
            {
                count += breakdown_Same(9, step7List[i]);
            }
            message += "SETP7) Here we have " + newStep6[0].ToString() + " is " + messageAdd(step7List) + " for 9 is  " + count.ToString() + Environment.NewLine;
            totalCount += count;
            // then add 93+5=98 here check for exact 12=12=21 same
            

            List<int> step9List = more100(newStep6[0] + newStep6[1]);
            //message += "SETP8) " + messageAdd(step9List) + " here check for exact same ";

//             count = 0;
//             for (int i = 0; i < 3; i++)
//             {
//                 for (int j = 0; j < step9List.Count; j++)
//                 {
//                     count += exactSame(step9List[j], newStep6[i]);
//                 }
//                 
//             }
//             List<int> timeList = new List<int>();
//             timeList.Add(h1);
//             timeList.Add(h2);
//             timeList.Add(m1);
//             timeList.Add(m1);
//             timeList.Add(middle1);
//             timeList.Add(middle2);
//             for (int i = 0; i < timeList.Count; i++)
//             {
//                 for (int j = 0; j < step9List.Count; j++)
//                 {
//                     count += exactSame(step9List[j], timeList[i]);
//                 }
//             }
//             message += count.ToString() + Environment.NewLine;
//             totalCount += count;
            // Here check 04:26=30 and 4+27=31 and 61 so two same with date 20170102 and date add 13,16,29

            dataAdd1(date);
            step9List.Add(m1 + h1);
            step9List.Add(m2 + h2);
            step9List.Add(m1 + h1 + m2 + h2);
            count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                for (int j = 0; j < step9List.Count; j++)
                {
                    count += exactSame(DateList[i], step9List[j]);
                }
            }
            message += "STEP8) Here check " + messageAdd(step9List) + " with " + messageAdd(DateList) + " is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            message += "So total is " + totalCount.ToString() ;

            if (totalCount % 2 == 0)
            {
                message += " no opposite";
                result = "down";
            }
            else
            {
                message += " opposite";
                result = "up";
            }
            message += Environment.NewLine;
            count = 0;
            message += "Result is " + result + Environment.NewLine;

            message += "---------------------------------------" + Environment.NewLine;

            message += "STEP9) Here we have " + messageAdd(step7List) + ", " + messageAdd(step9List) + " is ";
            count = 0;
            sum = 0;
            for (int i = 0; i < step7List.Count; i++)
            {
                count += lastSame(step7List[i]);
                sum += step7List[i];
            }
            for (int i = 0; i < step9List.Count; i++)
            {
                count += lastSame(step9List[i]);
                sum += step9List[i];
            }
            message += count.ToString() + Environment.NewLine;
            totalCount += count;
            List<int> step11List = new List<int>();
            int xx = sum / 10 + sum % 10;
            count = 0;
            message += "STEP10) " + sum.ToString() + " = " + xx.ToString() + " exact same and breakdown same with " + messageAdd(step7List) + ", " + messageAdd(step9List) + " is ";
            step11List.Add(xx);
            for (int i = 0; i < step7List.Count; i++)
            {
                count += exactSame(xx, step7List[i]);
                count += breakdown_Same(xx, step7List[i]);
            }
            for (int i = 0; i < step9List.Count; i++)
            {
                count += exactSame(xx, step9List[i]);
                count += breakdown_Same(xx, step9List[i]);
            }
            message += count.ToString() + Environment.NewLine;

            totalCount += count;
            step11List.Add(totalCount);
            message += "So total is " + totalCount.ToString() + Environment.NewLine;

            message += "---------------------------------------" + Environment.NewLine;
            int everymin = int.Parse(Check_Text.Text);
            step11List.Add(everymin);
            count = 0;
            message += "STEP11) Check breakdown same "  + messageAdd(step11List) + " is ";
            for (int i = 0; i < step11List.Count - 1; i++)
            {
                for (int j = i + 1; j < step11List.Count; j++)
                {
                    count += breakdown_Same(step11List[i], step11List[j]);
                }                
            }
            message += count.ToString() + Environment.NewLine;
            totalCount = count;

            message += "STEP12) ";
            List<int> step12List = new List<int>();

            xx = step11List[0] + step11List[1];
            step12List.AddRange(need01(xx));
            if (step11List[0] % 10 == 0 || step11List[1] % 10 == 0)
            {
                int yy = xx;
                if (step11List[0] % 10 == 0)
                {
                    yy++;
                    step11List.AddRange(need01(step11List[0] + 1));
                    step11List.AddRange(need01(2 * step11List[0] + 1));
                }
                if (step11List[1] % 10 == 0)
                {
                    yy++;
                    step11List.AddRange(need01(step11List[1] + 1));
                    step11List.AddRange(need01(2 * step11List[1] + 1));
                } 
                step12List.AddRange(need01(yy));
                step12List.AddRange(need01(xx + yy));
            }
            step11List.Add(everymin);

            count = 0;
            message += "Check " + messageAdd(step12List) + " for 9  and exact same with  " + messageAdd(step11List);
            for (int i = 0; i < step12List.Count; i++)
            {
                count += breakdown_Same(9, step12List[i]);
                for (int j = 0; j < step11List.Count; j++)
                {
                    if (step12List[i] > 99) step12List[i] = step12List[i] / 10 + step12List[i] % 10;
                    for (int k = 0; k < breakdown[step12List[i]].Length; k++)
                    {
                        for (int p = 0; p < breakdown[step11List[j]].Length; p++)
                        {
                            count += exactSame(breakdown[step12List[i]][k], breakdown[step11List[j]][p]);
                        }
                    }
                }
            }



            message += " same is " +  count.ToString() + Environment.NewLine;
            totalCount += count;
            message += "So total is " + totalCount.ToString() + Environment.NewLine;


            message += "-------------------------------" + Environment.NewLine;
            List<int> step13List = new List<int>();
            // step13List.Add(check);
            step13List.AddRange(step12List);
            step13List.Add(totalCount);
            message += "Here we use " + check.ToString() + ", " +  messageAdd(step13List) + Environment.NewLine;
            count = 0;
            totalCount = 0;
            for (int i = 0; i < step13List.Count; i++)
            {
                count += exactSame1(step13List[i], check);
                count += breakdown_Same(step13List[i], check);
            }
            message += "STEP1) Check " + messageAdd(step13List) + " exact same and breakdown with " + check.ToString() + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            for (int i = 0; i < step13List.Count; i++)
            {
                count += breakdown_Same(step13List[i], 9);
            }
            message += "STEP2) Check " + messageAdd(step13List) + "  with 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            int step3Number = check + step13List[step13List.Count - 1];
            count = 0;
            var numberList = need01(step3Number);
            for (int i = 0; i < step13List.Count; i++)
            {
                for (int j = 0; j < numberList.Count; j++)
                {
                    for (int k = 0; k < breakdown[step13List[i]].Length; k++)
                    {
                        count += breakdown_Same(breakdown[step13List[i]][k], numberList[j]);
                    }
                    
                }                
            }

            message += "STEP3) " + messageAdd(numberList) + " Check for breakdown same with " + messageAdd(step13List) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;
            int number = step13List[0] + step13List[step13List.Count - 1];
            message += "Check " + step13List[0].ToString() + " + " + step13List[step13List.Count - 1].ToString() + " = " + number.ToString() + " same is ";
            if (number > 99) number = number / 10 + number % 10;
            for (int i = 0; i < breakdown[number].Length; i++)
            {
                for (int j = 0; j < breakdown[step13List[0]].Length; j++)
                {
                    count += exactSame(breakdown[number][i], breakdown[step13List[0]][j]);
                }
            }
            for (int i = 0; i < breakdown[number].Length; i++)
            {
                for (int j = 0; j < breakdown[step13List[step13List.Count - 1]].Length; j++)
                {
                    count += exactSame(breakdown[number][i], breakdown[step13List[step13List.Count - 1]][j]);
                }
            }
            message += count.ToString() + Environment.NewLine;
            totalCount += count;
            if (check + step13List[step13List.Count - 1] > 0)
            {
                step3Number = check - step13List[step13List.Count - 1];
                count = 0;
                numberList = need01(step3Number);
                for (int i = 0; i < step13List.Count; i++)
                {
                    for (int j = 0; j < numberList.Count; j++)
                    {
                        for (int k = 0; k < breakdown[step13List[i]].Length; k++)
                        {
                            count += breakdown_Same(breakdown[step13List[i]][k], numberList[j]);
                        }

                    }
                }
                message += "STEP4) " + messageAdd(numberList) + " Check for breakdown same with " + messageAdd(step13List) + " same is " + count.ToString() + Environment.NewLine;
                totalCount += count;
            }

            message += "So total is " + totalCount.ToString();

            if (totalCount % 2 == 0)
            {
                message += " no opposite";
            }
            else
            {
                message += " opposite";
                if (result == "up")
                {
                    result = "down";
                }
                else
                {
                    result = "up";
                }
            }
            message += Environment.NewLine +  "Result is " + result;



            return result;
            

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
            if (t > 0 && d > 0)
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

        public int lastSame(int number)
        {
            switch (number)
            {
                case 101: return 1;
                case 37: return 1;
                case 75: return 2;
                case 94: return 2;
                case 60: return 1;
                case 10: return 1;
                case 77: return 2;
                case 83: return 1;
                case 46: return 2;
                case 65: return 1;
                case 55: return 2;
                case 59: return 1;
                case 7: return 1;
                case 17: return 1;
                case 47: return 1;
                case 103: return 2;
                case 113: return 2;
                case 99: return 2;
                case 107: return 2;
                case 109: return 1;
                case 45: return 1;
                case 54: return 2;
                case 69: return 2;
                case 96: return 2;
                case 85: return 2;
                case 95: return 2;
                case 71: return 2;
                case 81: return 2;
                case 66: return 1;
                case 14: return 1;
                case 64: return 2;
                case 111: return 2;
                case 5: return 1;
                case 11: return 1;
                case 21: return 2;
                case 27: return 2;
                case 31: return 1;
                case 39: return 2;
                case 41: return 2;
                case 43: return 1;
                case 49: return 2;
                case 26: return 1;
                case 28: return 1;
                case 30: return 2;
                case 20: return 1;
                case 67: return 1;
                case 34: return 1;
                case 35: return 1;
                case 40: return 1;
                case 79: return 1;
                case 42: return 1;
                case 87: return 1;
                case 91: return 2;
                case 93: return 1;
                case 48: return 2;
                case 97: return 2;
                case 74: return 1;
                case 72: return 2;
                case 53: return 1;
                case 84: return 2;
                case 82: return 1;
                case 88: return 2;
                case 117: return 1;
                case 119: return 1;
                case 56: return 2;
                case 18: return 1;
                case 19: return 1;
                case 9: return 2;
                case 25: return 1;
                case 33: return 1;
                case 92: return 2;
                case 57: return 1;
                case 38: return 2;
                case 16: return 1;
                case 61: return 2;
                case 89: return 1;
                case 15: return 1;
                case 51: return 1;
                case 52: return 1;
                case 62: return 1;
                case 58: return 2;
                case 115: return 1;
                case 121: return 1;
                case 4: return 1;
                case 8: return 1;
                default: return 0;
            }
        }
        public List<int> more100(int number)
        {
            List<int> list = new List<int>();
            if (number < 100)
            {
                list.Add(number);
            }
            else
            {
                int x = number / 10 + number % 10;
                list.Add(x);
                if (number / 10 % 10 == 0 || number % 10 == 0)
                {
                    int y = x;
                    if (number / 10 % 10 == 0) y++;
                    if (number % 10 == 0) y++;
                    list.Add(y);
                    list.Add(x + y);
                }
            }
            return list;
        }

        public List<int> need01(int number)
        {
            List<int> list = new List<int>();
            list.Add(number);
            if (number % 10 == 0)
            {
                list.Add(number + 1);
                list.Add(2 * number + 1);
            }
            return list;
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
            //             char[] myArray = date.ToCharArray();
            // 
            //             List<int> dateArray = new List<int>();
            //             for (int i = 0; i < 3; i++)
            //             {
            //                 int x = Int32.Parse(myArray[i].ToString() + myArray[i + 1].ToString());
            //                 if (x > 10)
            //                 {
            //                     dateArray.Add(x);
            //                 }
            //             }
            //             if (myArray[1].ToString() == "0" && myArray[2].ToString() != "0")
            //                 dateArray.Add(Int32.Parse(myArray[0].ToString() + myArray[2].ToString()));
            //             if (myArray[1].ToString() == "0" && myArray[2].ToString() == "0")
            //                 dateArray.Add(Int32.Parse(myArray[0].ToString() + myArray[3].ToString()));
            //             dateArray.Add(Int32.Parse(myArray[4].ToString() + myArray[5].ToString()));
            //             dateArray.Add(Int32.Parse(myArray[6].ToString() + myArray[7].ToString()));
            //             for (int i = 0; i < dateArray.Count; i++)
            //             {
            //                 DateList.Add(dateArray[i]);
            //             }
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
            dateArray.Add(Int32.Parse(myArray[3].ToString() + myArray[4].ToString()));
            dateArray.Add(Int32.Parse(myArray[4].ToString() + myArray[5].ToString()));
            if (myArray[4].ToString() == "0")
                dateArray.Add(Int32.Parse(myArray[3].ToString() + myArray[5].ToString()));
            dateArray.Add(Int32.Parse(myArray[5].ToString() + myArray[6].ToString()));
            dateArray.Add(Int32.Parse(myArray[6].ToString() + myArray[7].ToString()));
            if (myArray[6].ToString() == "0")
                dateArray.Add(Int32.Parse(myArray[5].ToString() + myArray[7].ToString()));

            for (int i = 0; i < dateArray.Count; i++)
            {
                DateList.Add(dateArray[i]);
            }
        }

        private void dataAdd1(string date)
        {
            char[] myArray = date.ToCharArray();
            int x = 0;
            int y = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                int num = int.Parse(myArray[i].ToString());

                x += num;
                if (num == 0) y++;
                else y += num;
            }
            DateList.Add(x);
            DateList.Add(y);
            DateList.Add(x + y);
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

        public int exactSame1(int a, int b)
        {

            if (a == b) return 1;
            else if (a / 10 + a % 10 * 10 == b) return 1;
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
            int m = int.Parse(Check_Text.Text);
            int c = int.Parse(column.Text);
            MyApp = new Microsoft.Office.Interop.Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(path);
            MySheet = (Microsoft.Office.Interop.Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            int lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
            int index = 2;
            try
            {
                for (index = m; index <= lastRow; index = index + m)
                {
                    this.Text = index.ToString();
                    this.Refresh();
                    try
                    {
                        System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "I" + index.ToString()).Cells.Value;

                        string date = MyValues.GetValue(1, 1).ToString().Replace(".", "");
                        string time1 = MyValues.GetValue(1, 2).ToString();
                        string realdata1 = MyValues.GetValue(1, 3).ToString();
                        MyValues = (System.Array)MySheet.get_Range("A" + (index+5).ToString(), "I" + (index + m).ToString()).Cells.Value;
                        string time2 = MyValues.GetValue(1, 2).ToString();
                        string realdata2 = MyValues.GetValue(1, 3).ToString();
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
                        MySheet.Cells[index, c] = str;

                        if ( double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, c+1] = "UP";
                        else MySheet.Cells[index, c+1] = "DOWN";
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
