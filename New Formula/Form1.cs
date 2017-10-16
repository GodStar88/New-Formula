using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                for (int j = 0; j < breakdown[h1 + m1].Length; j++)
                {
                    count += exactSame(breakdown[h1 + m1][j], DateList[i], 1);
                }
                for (int j = 0; j < breakdown[h2 + m2].Length; j++)
                {
                    count += exactSame(breakdown[h2 + m2][j], DateList[i], 1);
                }
            }
            for (int i = 0; i < TimeList.Count; i++)
            {
                for (int j = 0; j < breakdown[h1 + m1].Length; j++)
                {
                    count += exactSame(breakdown[h1 + m1][j], TimeList[i], 1);
                }
                for (int j = 0; j < breakdown[h2 + m2].Length; j++)
                {
                    count += exactSame(breakdown[h2 + m2][j], TimeList[i], 1);
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
            message += result + Environment.NewLine + Environment.NewLine;

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
                    count += exactSame(stepList4[i], DateList[j], 1);
                }
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
            message = "";
            message += "======================================" + Environment.NewLine;
            List<int> lastStep1 = new List<int>();
            lastStep1.Add(newStep1[0]);
            lastStep1.Add(newStep1[4]);
            lastStep1.Add(totalCount);
            totalCount = 0;
            count = 0;
            message += "We use " + messageAdd(lastStep1) + Environment.NewLine;
            for (int i = 0; i < lastStep1.Count; i++)
            {
                count += breakdown_Same(9, lastStep1[i]);
                count += breakdown_Same(2, lastStep1[i]);
            }
            totalCount += count;
            message += "STEP1) Check " + messageAdd(lastStep1) + " for 9 and 2 same is " + count.ToString() + Environment.NewLine;
            count = 0;

            for (int i = 0; i < lastStep1.Count - 1; i++)
            {
                for (int j = i + 1; j < lastStep1.Count; j++)
                {
                    count += lastStepBreakdown(lastStep1[i], lastStep1[j]);
                }
            }

            message += "             Check exact same 12=12 with " + messageAdd(lastStep1) + " include breakdown same is " + count.ToString() + Environment.NewLine;
            int partOne = count;


            int number = Math.Abs(lastStep1[1] + lastStep1[0] + lastStep1[2]);
            count = breakdown_Same(number, 9);
            message += "             Check " + number.ToString() + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            // last step part one
            message += "====================PART ONE==================" + Environment.NewLine;
            totalCount = 0;
            count = 0;
            var temp = more100(number);
            int stepNumber1 = number;
            if (temp.Count == 3) stepNumber1 = temp[2];
            else stepNumber1 = temp[0];
            count = breakdown_Same(stepNumber1, 9);
            message += "STEP1) Check " + stepNumber1.ToString() + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            var partOneList1 = addMore100(number, 9 + 5);
            partOneList1.AddRange(addMore100(number, 1 + 9 + 5));
            partOneList1.AddRange(addMore100(number, 2 + 9 + 5));
            for (int i = 0; i < partOneList1.Count; i++)
            {
                count += breakdown_Same(partOneList1[i], 9);
            }
            message += "STEP2) Check " + messageAdd(partOneList1) + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            var partOneList2 = more100(number - 9 - 5);
            partOneList2.AddRange(more100(number - 10 - 5));
            partOneList2.AddRange(more100(number - 11 - 5));
            for (int i = 0; i < partOneList2.Count; i++)
            {
                count += breakdown_Same(partOneList2[i], 9);
            }
            message += "STEP3) Check " + messageAdd(partOneList2) + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            for (int i = 0; i < partOneList1.Count; i++)
            {
                count += exactSame(partOneList1[i], 13, 1);
                count += exactSame(partOneList1[i], 33, 1);
            }
            for (int i = 0; i < partOneList2.Count; i++)
            {
                count += exactSame(partOneList2[i], 13, 1);
                count += exactSame(partOneList2[i], 33, 1);
            }
            message += "STEP4) Check 33,13 exactsame with " + messageAdd(partOneList1) + " and " + messageAdd(partOneList2) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            for (int i = 0; i < partOneList1.Count; i++)
            {
                for (int j = 0; j < partOneList2.Count; j++)
                {
                    count += exactSame(partOneList1[i], partOneList2[j], 1);
                }
            }
            message += "STEP5) Check exactsame " + messageAdd(partOneList1) + " with " + messageAdd(partOneList2) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            message += "STEP6) Add all the same count is " + totalCount.ToString() + Environment.NewLine;

            List<int> partThreeList = new List<int>();
            partThreeList.Add(totalCount);

            message += "====================PART TWO==================" + Environment.NewLine;

            count = 0;
            partOneList1.Clear();
            partOneList2.Clear();
            int partonetotal = totalCount;
            totalCount = 0;
            partOneList1 = addMore100(number, 9 + 5 + partonetotal);
            partOneList1.AddRange(addMore100(number, 1 + 9 + 5 + partonetotal));
            partOneList1.AddRange(addMore100(number, 2 + 9 + 5 + partonetotal));
            for (int i = 0; i < partOneList1.Count; i++)
            {
                count += breakdown_Same(partOneList1[i], 9);
            }
            message += "STEP1) Check " + messageAdd(partOneList1) + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            partOneList2 = more100(number - 9 - 5);
            partOneList2.AddRange(more100(number - 10 - 5 - partonetotal));
            partOneList2.AddRange(more100(number - 11 - 5 - partonetotal));
            for (int i = 0; i < partOneList2.Count; i++)
            {
                count += breakdown_Same(partOneList2[i], 9);
            }
            message += "STEP2) Check " + messageAdd(partOneList2) + " for 9 same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            for (int i = 0; i < partOneList1.Count; i++)
            {
                count += exactSame(partOneList1[i], 13, 1);
                count += exactSame(partOneList1[i], 33, 1);
            }
            for (int i = 0; i < partOneList2.Count; i++)
            {
                count += exactSame(partOneList2[i], 13, 1);
                count += exactSame(partOneList2[i], 33, 1);
            }
            message += "STEP3) Check 33,13 exactsame with " + messageAdd(partOneList1) + " and " + messageAdd(partOneList2) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            for (int i = 0; i < partOneList1.Count; i++)
            {
                for (int j = 0; j < partOneList2.Count; j++)
                {
                    count += exactSame(partOneList1[i], partOneList2[j], 1);
                }
            }
            message += "STEP4) Check exactsame " + messageAdd(partOneList1) + " with " + messageAdd(partOneList2) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;
            partThreeList.Add(totalCount);
            message += "STEP5) Add all the same count is " + totalCount.ToString();

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
            message += Environment.NewLine + "Result is " + result + Environment.NewLine;

            message += "====================PART THREE==================" + Environment.NewLine;

            message += "Here we use " + messageAdd(partThreeList) + Environment.NewLine;
            count = 0;
            totalCount = 0;
            List<int> partThree1 = new List<int>();
            List<int> lastpart2 = new List<int>();
            partThree1.AddRange(need01(h1 + m1));
            for (int i = 0; i < partThree1.Count; i++)
            {
                for (int j = 0; j < partThreeList.Count; j++)
                {
                    count += exactSame(partThree1[i], partThreeList[j], 2);
                }
            }
            message += "STEP1) Add time " + messageAdd(partThree1) + " Check for " + messageAdd(partThreeList) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;
            lastpart2.Add(10);
            lastpart2.Add(11);
            lastpart2.AddRange(partThree1);

            count = 0;
            List<int> partThree2 = new List<int>();
            partThree2.AddRange(need01(h2 + m2));
            for (int i = 0; i < partThree2.Count; i++)
            {
                for (int j = 0; j < partThreeList.Count; j++)
                {
                    count += exactSame(partThree2[i], partThreeList[j], 2);
                }
            }
            lastpart2.AddRange(partThree2);
            message += "STEP2) Add time " + messageAdd(partThree2) + " Check for " + messageAdd(partThreeList) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;

            count = 0;
            int partThree3 = 9 - partThreeList[0] - partThreeList[1];
            if (partThree3 % 2 == 0) count = 0;
            else count = 1;
            message += "STEP3) " + 9.ToString() + "-" + partThreeList[0].ToString() + "-" + partThreeList[1].ToString() + "=" + partThree3.ToString() + ", so same is " + count.ToString() + Environment.NewLine;
            totalCount = count;

            count = 0;
            for (int i = 0; i < partThreeList.Count; i++)
            {
                count += exactSame(partThreeList[i], totalCount, 2);
            }
            message += "STEP4) Here total is " + totalCount.ToString() + " same, so check with " + messageAdd(partThreeList) + " same is " + count.ToString() + Environment.NewLine;
            int partThree4 = totalCount + partThreeList[0] + partThreeList[1];
            totalCount += count;

            count = 0;
            partThree1.Add(h1);
            partThree1.Add(m1);
            partThree1.Add(h2);
            partThree1.Add(m2);
            partThree1.AddRange(partThree2);

            for (int i = 0; i < partThree1.Count; i++)
            {
                count += breakdown_Same(partThree4, partThree1[i]);
            }
            message += "STEP5) " + partThree4.ToString() + " include breakdown with " + messageAdd(partThree1) + " same is " + count.ToString() + Environment.NewLine;
            totalCount += count;
            List<int> lastpart1 = new List<int>();
            lastpart1.Add(5);
            lastpart1.Add(4);
            lastpart1.Add(partThree4);
            message += "STEP6) " + totalCount.ToString();

            int lartpartnum = totalCount;
            lastpart1.Add(totalCount);
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
            message += Environment.NewLine + "Result is " + result + Environment.NewLine;

            message = "";
            message += "====================LAST PART==================" + Environment.NewLine;
            count = 0;
            totalCount = 0;

            List<int> lastpartDate = new List<int>();
            List<int> lastpartTime = new List<int>();

            List<int> lastStepNumber = new List<int>();
            lastpartTime.AddRange(need01(h1 + m1));
            int countnumber = lastpartTime.Count;
            for (int i = 0; i < countnumber; i++)
            {
                lastpartTime.Add(lastpartTime[i] + lartpartnum);
            }
            lastpartDate.AddRange(dataAdd2(date));

            message += "Date add is " + messageAdd(lastpartDate) + Environment.NewLine;


            for (int i = 0; i < lastpartTime.Count; i++)
            {
                count += breakdown_Same(9, lastpartTime[i]);
                for (int j = 0; j < lastpartDate.Count; j++)
                {
                    count += breakdown_Same(lastpartTime[i], lastpartDate[j]);
                    count += exactSame(lastpartTime[i], lastpartDate[j], 2);
                }
            }

            message += "STEP1) we add " + lartpartnum.ToString() + " to time, so we have " + messageAdd(lastpartTime) + " check for 9 and with date same is " + count.ToString() + Environment.NewLine;
            lastStepNumber.Add(count);
            int lastpartnum2 = lastpartTime[lastpartTime.Count - 1] - 1 + count + lartpartnum;
            count = 0;
            for (int i = 0; i < lastpartTime.Count; i++)
            {
                count += breakdown_Same(lastpartnum2, lastpartTime[i]);
                count += exactSame(lastpartnum2, lastpartTime[i], 2);
            }
            for (int i = 0; i < lastpartDate.Count; i++)
            {
                count += breakdown_Same(lastpartnum2, lastpartDate[i]);
                count += exactSame(lastpartnum2, lastpartDate[i], 2);
            }
            message += "STEP2) Check " + lastpartnum2.ToString() + " brekdownsame and exactsame with time and date same is " + count.ToString() + Environment.NewLine;
            lastStepNumber.Add(count);
            int lastpartnum3 = lastpartnum2 + count;
            count = 0;
            for (int i = 0; i < lastpartTime.Count; i++)
            {
                count += breakdown_Same(lastpartnum3, lastpartTime[i]);
                count += exactSame(lastpartnum3, lastpartTime[i], 2);
            }
            for (int i = 0; i < lastpartDate.Count; i++)
            {
                count += breakdown_Same(lastpartnum3, lastpartDate[i]);
                count += exactSame(lastpartnum3, lastpartDate[i], 2);
            }
            message += "STEP3) Check " + lastpartnum3.ToString() + " same is " + count.ToString();
            lastStepNumber.Add(count);
            lastpartnum3 += count;
            count += breakdown_Same(9, lastpartnum3);
            message += " and then " + lastpartnum3.ToString() + " check 9 so total is " + count.ToString() + Environment.NewLine;

            message += count.ToString();



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
            message += Environment.NewLine + "Result is " + result + Environment.NewLine;


            totalCount = lastSTEP(lastStepNumber);
            FORMULA1 = totalCount;
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
            message += Environment.NewLine + "Result is " + result + Environment.NewLine;

            return result;


        }


        private int lastSTEP(List<int> list)
        {
            int totalcount = 0;
            int count = 0;

            message += "=================================================================" + Environment.NewLine;
            message += "Here we use " + messageAdd(list) + Environment.NewLine;

            List<int> list_Step1 = new List<int>();
            list_Step1.AddRange(need011(list[0] * 10 + list[1]));
            list_Step1.AddRange(need011(list[0] * 10 + list[2]));
            list_Step1.AddRange(need011(list[1] * 10 + list[2]));

            message += "STEP1) We have " + messageAdd(list_Step1) + Environment.NewLine;

            List<int> list_Step2 = new List<int>();
            int x = 0;
            int y = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0) y += 1;
                else
                {
                    x += list[i];
                    y += list[i];
                }

            }
            list_Step2.AddRange(need01(x + y));
            message += "STEP2) We have " + messageAdd(list_Step2) + Environment.NewLine;

            list_Step1.AddRange(list_Step2);

            for (int i = 0; i < list_Step1.Count; i++)
            {
                count += breakdown_Same(9, list_Step1[i]);
            }

            for (int i = 0; i < list_Step1.Count - 1; i++)
            {
                for (int j = i + 1; i < list_Step1.Count; i++)
                {
                    count += exactSame(list_Step1[i], list_Step1[j], 1);
                }
            }
            message += "STEP3) Check " + messageAdd(list_Step1) + " with exactsame and 9 same is " + count.ToString() + Environment.NewLine;
            totalcount = count;
            x = count;
            count = 0;

            for (int i = 0; i < list_Step1.Count; i++)
            {
                count += breakdown_Same(x, list_Step1[i]);
            }
            message += "STEP4) Check " + x.ToString() + " in " + messageAdd(list_Step1) + " same is " + count.ToString() + Environment.NewLine;
            totalcount += count;

            

            message += totalcount.ToString();
            return totalcount;
        }

        private int lastStepBreakdown(int a, int b)
        {
            int count = 0;
            if (a > 99) a = a / 10 + a % 10;
            if (b > 99) a = b / 10 + b % 10;
            for (int i = 0; i < breakdown[a].Length; i++)
            {
                for (int j = 0; j < breakdown[b].Length; j++)
                {
                    count += exactSame(breakdown[a][i], breakdown[b][j], 3);
                }
            }
            return count;
        }

        private int lastSteps(int x, List<int> list)
        {
            int count = 0;

            count += breakdown_Same(2, x);
            count += breakdown_Same(9, x);

            for (int i = 0; i < list.Count; i++)
            {
                count += lastStepBreakdown(x, list[i]);
            }
            message += " and check for 2 and 9 and exactsame with " + messageAdd(list) + " include breakdown same is " + count.ToString() + Environment.NewLine;
            return count;
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
        public List<int> addMore100(int number1, int number2)
        {
            List<int> list = new List<int>();
            int number = number1 + number2;
            if (number > 99 && (number1 % 10 == 0 || number1 / 10 % 10 == 0))
            {
                int x = number / 10 + number % 10;
                list.Add(x);
                list.Add(x + 1);
                list.Add(2 * x + 1);
                return list;
            }


            if (number1 + number2 < 100)
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
            list.AddRange(more100(number));
            if (number % 10 == 0)
            {
                list.AddRange(more100(number + 1));
                list.AddRange(more100(2 * number + 1));
            }
            return list;
        }
        public List<int> need011(int number)
        {
            List<int> list = new List<int>();

            if (number == 0)
            {
                list.Add(11);
                return list;
            }

            if (number < 10)
            {
                number = number * 10;
            }

            list.AddRange(more100(number));
            if (number % 10 == 0)
            {
                list.AddRange(more100(number + 1));
                list.AddRange(more100(2 * number + 1));
            }
            return list;
        }
        public List<int> need01more100(int number1, int number2)
        {
            List<int> list = new List<int>();
            list.AddRange(more100(number1 + number2));
            if (number1 % 10 == 0 || number2 % 10 == 0)
            {
                int x = number1 + number2;
                int y = x;
                if (number1 % 10 == 0) y++;
                if (number2 % 10 == 0) y++;
                list.AddRange(more100(y));
                list.AddRange(more100(x + y));
            }
            return list;
        }

        public List<int> need01more1001(int number1, int number2)
        {
            List<int> list = new List<int>();
            list.AddRange(need01(number1 + number2));
            if (number1 % 10 == 0 || number2 % 10 == 0)
            {
                int x = number1 + number2;
                int y = x;
                if (number1 % 10 == 0) y++;
                if (number2 % 10 == 0) y++;
                list.AddRange(need01(y));
                list.AddRange(need01(x + y));
            }
            return list;
        }


        public List<int> need01more1003(int number1, int number2, int number3)
        {
            List<int> list = new List<int>();
            list.AddRange(need01(number1 + number2 + number3));
            if (number1 % 10 == 0 || number2 % 10 == 0)
            {
                int x = number1 + number2 + number3;
                int y = x;
                if (number1 % 10 == 0) y++;
                if (number2 % 10 == 0) y++;
                if (number3 % 10 == 0) y++;
                list.AddRange(need01(y));
                list.AddRange(need01(x + y));
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

        private List<int> dataAdd2(string date)
        {
            List<int> list = new List<int>();
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
            list.Add(x);
            list.Add(y);
            list.Add(x + y);
            return list;
        }
        private List<int> dataAdd3(string date)
        {
            List<int> list = new List<int>();
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
            list.AddRange(need01(x));
            list.AddRange(need01(y));
            list.AddRange(need01(x + y));
            return list;
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
            for (int i = num + 1; i < 100; i++)
            {
                for (int j = 0; j < breakdown[i].Length; j++)
                {
                    if (breakdown[i][j] == check) return i;
                }
            }
            return 0;
        }

        public int exactSame(int a, int b, int type)
        {
            switch (type)
            {
                case 1:
                    if (a > 9 && b > 9)
                    {
                        if (a == b) return 1;
                        else if (a / 10 + a % 10 * 10 == b) return 1;
                        else return 0;
                    }
                    else return 0;
                case 2:
                    if (a == b) return 1;
                    else if (a / 10 + a % 10 * 10 == b) return 1;
                    else return 0;
                case 3:
                    if (a > 9 && b > 9)
                    {
                        if (a == b) return 1;
                        else return 0;
                    }
                    else return 0;
                case 4:
                    if (a > 9 && b > 9)
                    {
                        if (a / 10 + a % 10 * 10 == b) return 1;
                        return 0;
                    }
                    else
                    {
                        if (a == b) return 1;
                        else return 0;
                    }
                default: return 0;
            }
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
                for (index = 2; index <= lastRow; index++)
                {
                    try { this.Text = index.ToString(); this.Refresh(); } catch (Exception) { }

                    try
                    {
                        System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "T" + index.ToString()).Cells.Value;

                        string date = MyValues.GetValue(1, 2).ToString().Replace(".", "");
                        string time1 = MyValues.GetValue(1, 4).ToString();
                        string realdata1 = MyValues.GetValue(1, 5).ToString();
                        MyValues = (System.Array)MySheet.get_Range("A" + (index + 5).ToString(), "I" + (index + 1).ToString()).Cells.Value;
                        string time2 = MyValues.GetValue(1, 4).ToString();
                        string realdata2 = MyValues.GetValue(1, 5).ToString();
                        try
                        {
                            Date_Text.Text = date;
                            Time1_Text.Text = time1;
                            Time2_Text.Text = time2;
                        }
                        catch (System.Exception)
                        {
                        }
                        Check_Text.Text = "4";
                        string str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 12] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 13] = "UP";
                        else MySheet.Cells[index, 13] = "DOWN";


                        Check_Text.Text = "9";
                        str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 14] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 15] = "UP";
                        else MySheet.Cells[index, 15] = "DOWN";

                        Check_Text.Text = "7";
                        str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 16] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 17] = "UP";
                        else MySheet.Cells[index, 17] = "DOWN";

                        Check_Text.Text = "2";
                        str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 18] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 19] = "UP";
                        else MySheet.Cells[index, 19] = "DOWN";

                        Check_Text.Text = "8";
                        str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 20] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 21] = "UP";
                        else MySheet.Cells[index, 21] = "DOWN";

                        Check_Text.Text = "5";
                        str = step1(time1, time2, date);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 22] = str;

                        if (double.Parse(realdata1) < double.Parse(realdata2)) MySheet.Cells[index, 23] = "UP";
                        else MySheet.Cells[index, 23] = "DOWN";
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

        private void button4_Click(object sender, EventArgs e)
        {

            excelThread = new ThreadStart(excelThreadStart1);
            excelThread_Thread = new Thread(excelThread);
            excelThread_Thread.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] excel = new string[6];
            string  date = Date_Text.Text;
            string time1 = Time1_Text.Text;
            string time2 = Time2_Text.Text;

            Check_Text.Text = "4";
            string str = step1(time1, time2, date);
            excel[0] = str;
            Check_Text.Text = "9";
            str = step1(time1, time2, date);
            excel[1] = str;
            Check_Text.Text = "7";
            str = step1(time1, time2, date);
            excel[2] = str;
            Check_Text.Text = "2";
            str = step1(time1, time2, date);
            excel[3] = str;
            Check_Text.Text = "8";
            str = step1(time1, time2, date);
            excel[4] = str;
            Check_Text.Text = "5";
            str = step1(time1, time2, date);
            excel[5] = str;
            finalStep(date, int.Parse(Time1_Text.Text.Split(':')[0].ToLower()), excel);
            log.Text = message;
        }

        private void excelThreadStart1()
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
                for (index = 2; index <= lastRow; index++)
                {
                    try { this.Text = index.ToString(); this.Refresh(); } catch (Exception) { }

                    try
                    {
                        System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "Y" + index.ToString()).Cells.Value;
                        int time = int.Parse(MyValues.GetValue(1, 4).ToString().Split(':')[0]);
                        string date = MyValues.GetValue(1, 2).ToString().Replace(".", "");
                        string[] excel = new string[6];
                        excel[0] = MyValues.GetValue(1, 12).ToString();
                        excel[1] = MyValues.GetValue(1, 14).ToString();
                        excel[2] = MyValues.GetValue(1, 16).ToString();
                        excel[3] = MyValues.GetValue(1, 18).ToString();
                        excel[4] = MyValues.GetValue(1, 20).ToString();
                        excel[5] = MyValues.GetValue(1, 22).ToString();
                        string str = finalStep(date,time, excel);

                        MySheet.Cells[index, 25] = str;
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

        private string  finalStep(string date, int time, string[] excel)
        {
            //int time = 3;
            int[] result = new[] { 1, 1, 1, 1, 2, 1 };

            for (int i = 0; i < excel.Length; i++)
            {
                if (excel[i].Contains("up")) result[i] = 2;
                else result[i] = 1;
            }
            message = "";
            int total = 0;
            int res1 = result[0] * 100 + result[1] * 10 + result[2];
            int res2 = result[3] * 100 + result[4] * 10 + result[5];
            int sum = res1 + res2 + time;
           
            if (sum > 99) sum = sum / 10 + sum % 10;
            total = sum;
            message += date + "  " + time.ToString() + Environment.NewLine;

            message += "STEP1) " + res1.ToString() + ", " + res2.ToString() + " and time " + time.ToString() + ", so " + sum.ToString() + Environment.NewLine;

            List<int> checknum = new List<int>();
            checknum.Add(3);
            checknum.Add(result[0] + result[1] + result[2]);
            checknum.Add(result[3] + result[4] + result[5]);
            checknum.Add(checknum[1] + checknum[2]);
            int count = 0;
            for (int i = 0; i < checknum.Count; i++)
            {
                count += breakdown_Same(checknum[i], sum);
            }
            message += "STEP2) Check " + sum.ToString() + " for " + messageAdd(checknum) + " same is " + count.ToString() + Environment.NewLine;

            
            sum += count;
            total += sum;
            count = 0;
            for (int i = 0; i < checknum.Count; i++)
            {
                count += breakdown_Same(checknum[i], sum);
            }
            message += "STEP3) Check " + sum.ToString() + " for " + messageAdd(checknum) + " same is " + count.ToString();
            sum += count;
            total += sum;
            message += ". So final is " + sum.ToString() + Environment.NewLine;

            message += "STEP4) Finally " + total.ToString();
            if (total > 99) total = total / 100 + total % 100;
            count = breakdown_Same(9, total);
            message += " = " + total.ToString() + " check for 9 same is " + count.ToString() + Environment.NewLine;
            sum += count;

            int result1 = updown(updown(result[0], result[1]), result[2]);
            int result2 = updown(updown(result[3], result[3]), result[5]);
            int final = updown(result1, result2);

            string laststep = finalResult(final, sum);
            message += "STEP5) " + final.ToString() + ", " + sum.ToString() + " so is " + laststep + Environment.NewLine;

            count = 0;
            total = 0;
            List<int> list6 = new List<int>();
            list6.Add(final);
            list6.Add(sum);
            list6.Add(time);
            for (int i = 0; i < list6.Count; i++)
            {
                count += breakdown_Same(9, list6[i]);
            }
            count += exactsameList(list6);
            total += count;
            message += "STEP6) Check " + messageAdd(list6) + " for 9 and exact same is " + count.ToString() + Environment.NewLine;


            count = 0;
            List<int> list7 = new List<int>();
            list7.Add(list6[0] + list6[1]);
            list7.Add(list6[0] + list6[2]);
            list7.Add(list6[1] + list6[2]);
            for (int i = 0; i < list7.Count; i++)
            {
                count += breakdown_Same(9, list7[i]);
            }
            count += exactsameList(list7);
            total += count;
            message += "STEP7) Check " + messageAdd(list7) + " for 9 and exact same is " + count.ToString() + Environment.NewLine;


            count = 0;
            for (int i = 0; i < list6.Count - 1; i++)
            {
                for (int j = i + 1; j < list6.Count; j++)
                {
                    count += breakdown_Same(list6[i], list6[j]);
                }
            }
            total += count;
            message += "STEP8) Check " + messageAdd(list6) + " breakdown same is " + count.ToString() + Environment.NewLine;

            count = 0;
            List<int> list9 = new List<int>();
            list9.Add(sum - final);
            list9.Add(sum + final);

            for (int i = 0; i < list9.Count; i++)
            {
                count += breakdown_Same(9, list9[i]);
                count += breakdown_Same(1, list9[i]);
            }
            total += count;
            message += "STEP9) Check " + messageAdd(list9) + " for 9, 1 same is " + count.ToString() + Environment.NewLine;

            count = 0;
            List<int> list10 = new List<int>();
            list10.AddRange(need011(sum + final + time + total));
            list10.AddRange(need011(sum - final - time - total));

            for (int i = 0; i < list10.Count; i++)
            {
                count += breakdown_Same(9, list10[i]);
                count += breakdown_Same(3, list10[i]);
            }
            total += count;
            message += "STEP10) Check " + messageAdd(list10) + "  for 9, 13 same is " + count.ToString() + Environment.NewLine;

            list10.Clear();
            count = 0;
            list10.AddRange(need011(sum + total));
            list10.AddRange(need011(sum - total));
            for (int i = 0; i < list10.Count; i++)
            {
                count += breakdown_Same(9, list10[i]);
                count += breakdown_Same(3, list10[i]);
            }
            total += count;
            message += "STEP11) Check " + messageAdd(list10) + "  for 9, 13 same is " + count.ToString() + Environment.NewLine;

            count = 0;
            List<int> list11 = new List<int>();
            list11.Add(sum + total);
            list11.Add(time + total);
            int number11 = final + total;
            for (int i = 0; i < list11.Count; i++)
            {
                count += breakdown_Same(number11, list11[i]);
            }
            message += "STEP12) Check " + messageAdd(list11) + " for " + number11.ToString() + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            message += "So total is " + total.ToString() + ", ";

            if (total % 2 != 0)
            {
                if (laststep == "UP") laststep = "DOWN";
                else laststep = "UP";
            }
            message += laststep + Environment.NewLine;
            List<int> list20 = new List<int>();
            list20.AddRange(need01(total));

            //          STEP1) Check 16,7, 16 + 7 = 23 and time like here 16,17,33 for 9 same or exact 12 = 12 = 21 same
            //          STEP2) Compare 16 include breakdown with date
            //          STEP3) Compare 7 include breakdown with date
            //          STEP4) If let say we have 2 counts, then add 2 to 16,7,23,17,33 here will be 16 + 2 = 18 and 7 + 2 = 9 so two more same
            //          STEP5) Then If last count is odd so opposite of down is up
            //          If total count is even then here is down

            List<int> list13 = new List<int>();

            List<int> temp = new List<int>();
            temp.AddRange(need011(time));
            temp.AddRange(need011(total));
            temp.AddRange(need011(time + total));
            temp.AddRange(need011(time));
            temp.AddRange(need011(time + 1));
            temp.AddRange(need011(2 * time + 1));

            for (int i = 0; i < temp.Count; i++)
            {
                if (list13.IndexOf(temp[i]) == -1) list13.Add(temp[i]);
            }

            int lasttotal = total;
            count = 0;
            total = 0;
            for (int i = 0; i < list13.Count; i++)
            {
                count += breakdown_Same(9, list13[i]);
            }
            for (int i = 0; i < list13.Count - 1; i++)
            {
                for (int j = i + 1; j < list13.Count; j++)
                {
                    count += exactSame(list13[i], list13[j], 4);
                }
            }

            message += "STEP13) Check " + messageAdd(list13) + " for 9 and exact same is " + count.ToString() + Environment.NewLine;
            total += count;
            
            DateList.Clear();
            dateAdd(date);
            dataAdd1(date);
            message += "Date : " + messageAdd(DateList) + Environment.NewLine;
            count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                count += breakdown_Same(time, DateList[i]);
            }
            message += "STEP14) Check " + time.ToString() + " breakdown same with date same is " + count.ToString() + Environment.NewLine;
            total += count;

            

            count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                count += breakdown_Same(lasttotal, DateList[i]);
            }
            message += "STEP14) Check " + lasttotal.ToString() + " breakdown same with date same is " + count.ToString() + Environment.NewLine;
            total += count;

            count = 0;
            for (int i = 0; i < list13.Count; i++)
            {
                list13[i] = list13[i] + total;
            }
            for (int i = 0; i < list13.Count; i++)
            {
                count += breakdown_Same(list13[i], 9);
            }

            total += count;
            message += "STEP15) Check " + messageAdd(list13) + " for 9 same is " + count.ToString() + Environment.NewLine;

            message += "So total is " + total.ToString() + ", ";
            
            list20.AddRange(need01(total));
            List<int> list17 = new List<int>();
            list17.Add(total);
            list17.Add(count);            
            if (total % 2 != 0)
            {
                list17.Add(2);
                if (laststep == "UP") laststep = "DOWN";
                else laststep = "UP";
            }
            else list17.Add(1);
            message += laststep + Environment.NewLine;

            List<int> list16 = new List<int>();
            
            list16.Add(time);
            list16.Add(time + 1);
            list16.Add(2 * time + 1);

            //Here 3) Down is 1 and Up is 2
            //Here we see time 1) 15,16,31
            //And we use 2) 16 and 3) down
            //STEP1) Check time 15,16,31 and 16 for exact same 12 = 12 = 21, so we check time2 16 and 16 is one same
            //STEP2) Check 15,16,31 and 2)16 for 9 same, here no
            //STEP3) Check 16 and Down = 1 for breakdown same here no
            //STEP4) Then find the nearest 9 for here 2) 16 we see the nearest 9 is 18 so 18 - 16 = 2 here check 2 with down and time 15,16,31 for exact 2 = 2 or 12 = 12 = 21 same and also 2 can  check with nearest 18 for  breakdown same for this part so here no same, here also take note 2 is even is no count but if here is odd like 5 is one count
            //STEP5) Then we see 16 + 1 = 17 and 16 - 1 = 15 and check 17,15 for 9 same and for exact 12 = 12 = 21 with 2) 16 and time 1)15,16,31
            //STEP6) Then we count the total count is 1 same so odd so opposite of 3) down is up

            count = 0;
            total = 0;
            List<int> tem = new List<int>();
            tem.AddRange(list16);
            tem.Add(list17[0]);

            for (int i = 0; i < tem.Count - 1; i++)
            {
                for (int j = i + 1; j < tem.Count; j++)
                {
                    count += exactSame(tem[i], tem[j], 1);
                }
            }
            total += count;
            message += "STEP1) Check " + messageAdd(tem) + " for exact same, so same is  " + count.ToString() + Environment.NewLine;

            count = 0;
            for (int i = 0; i < tem.Count; i++)
            {
                count += breakdown_Same(tem[i], 9);
            }
            total += count;
            message += "STEP2) Check " + messageAdd(tem) + " for 9, so same is  " + count.ToString() + Environment.NewLine;

            count = breakdown_Same(list17[0], list17[2]);
            total += count;
            message += "STEP3) Check " + list17[0].ToString() + " and " + list17[2].ToString() + " for breakdown same, so same is " + count.ToString() + Environment.NewLine;

            int near = nearest(list17[0], 9);
            message += "STEP4) " + list17[0].ToString() + " nearest 9 is " + near.ToString();
            if (near % 2 == 0)
            {
                count = 0;
            }
            else count = 1;

            message += ", so same is " + count.ToString() + Environment.NewLine; 


            message += "So total is " + total.ToString() + ", " + laststep + Environment.NewLine;

            list20.AddRange(need01more100(list20[0],list20[1]));
            list20.Add(list20[0] + list20[1] + total);
            list20.AddRange(need01more100(list20[0], total));
            list20.AddRange(need01more100(list20[1], total));
            count = 0;
            for (int i = 0; i < list20.Count; i++)
            {
                count += breakdown_Same(9, list20[i]);
            }
            for (int i = 0; i < list20.Count - 1; i++)
            {
                for (int j = i + 1; j < list20.Count; j++)
                {
                    count += exactSame(list20[i], list20[j], 1);
                }
            }
            message += "Check " + messageAdd(list20) + " for 9 same and exactsame, so same is " + count.ToString() + Environment.NewLine;
            total += count;
            message  = date + "  " + time.ToString() + Environment.NewLine;
            message += "So total is " + total.ToString() + ", ";


           
            if (total % 2 != 0)
            {
                if (laststep == "UP")
                {
                    laststep = "DOWN";
                }
                else
                {
                    laststep = "UP";
                }
            }
            message += laststep + Environment.NewLine;


            message += "******** NEW LAST STEPS **********" + Environment.NewLine;

            List<int> laststep1 = new List<int>();
            // List<int> laststep6 = new List<int>();
            laststep1.Add(total);
            if (laststep == "UP")
            {
                laststep1.Add(2);
            }
            else laststep1.Add(1);
            count = 0;
            total = 0;
            for (int i = 0; i < laststep1.Count; i++)
            {
                for (int j = 0; j < list16.Count; j++)
                {
                    count += breakdown_Same(laststep1[i], list16[j]);
                }
            }
            total += count;
            message += "STEP1) Check " + messageAdd(laststep1) + " with " + messageAdd(list16) + " for breakdown same, so same is " + count.ToString() + Environment.NewLine;
            count = exactSame(laststep1[0], laststep1[1], 4);
            total += count;
            message += "STEP2) Check " + messageAdd(laststep1) + " for exactsame, so same is " + count.ToString() + Environment.NewLine;


            List<int> lastlist3 = new List<int>();
            for (int i = 0; i < 10; i = i + 2)
            {
                if (laststep1[0] % 2 == 0)
                {
                    if (laststep1[0] != i + 2)
                       lastlist3.AddRange(need01more100 (i + 2, laststep1[0]));
                }
                else
                {
                    if (laststep1[0] != i + 1)
                        lastlist3.AddRange(need01more100(i + 1, laststep1[0]));
                }
            }
            List<int> lastlist4 = new List<int>();
            for (int i = 0; i < lastlist3.Count; i++)
            {
                lastlist4.AddRange(need01(lastlist3[i]));
            }
            lastlist3.Clear();
            for (int i = 0; i < 10; i = i + 2)
            {
                if (laststep1[0] % 2 == 0)
                {
                    if (laststep1[0] != i + 2)
                        lastlist3.Add(i + 2);
                }
                else
                {
                    if (laststep1[0] != i + 1)
                        lastlist3.Add(i + 1);
                }
            }

            count = 0;
            for (int i = 0; i < list16.Count; i++)
            {
                for (int j = 0; j < lastlist3.Count; j++)
                {
                    count += breakdown_Same(list16[i], lastlist3[j]);
                }
                for (int j = 0; j < lastlist4.Count; j++)
                {
                    count += breakdown_Same(list16[i], lastlist4[j]);
                }
            }
            total += count;
            message += "STEP3) Check " + messageAdd(lastlist4) + " and " + messageAdd(lastlist3) + " with time " + messageAdd(list16) + " for breakdown same, so same is " + count.ToString() +  Environment.NewLine;

            count = 0;
            for (int i = 0; i < list16.Count; i++)
            {
                count += exactSame(list16[i], total,1);
            }
            message += "STEP4) Check Total is " + total.ToString() + ", so check " + total.ToString() + " with " + messageAdd(list16) + " for exact same, so same is " + count.ToString() + Environment.NewLine;
            total += count;

            message += "STEP5) Total is " + total.ToString() + ", ";

            laststep1.Add(total);

            if (total % 2 != 0)
            {
                if (laststep == "UP")
                {
                    laststep = "DOWN";
                }
                else
                {
                    laststep = "UP";
                }
            }
            if (laststep == "UP")
            {
                laststep1.Add(2);
            }
            else laststep1.Add(1);
            message += laststep + Environment.NewLine;

            count = 0;
            total = 0;
            count += breakdown_Same(9, laststep1[0]);
            count += breakdown_Same(9, laststep1[2]);
            message += "STEP6) Check " + laststep1[0].ToString() + ", " + laststep1[2].ToString() + " for 9, so same is " + count.ToString() + Environment.NewLine;
            total += count;

            count = 0;
            count += breakdown_Same(laststep1[0] + laststep1[2], laststep1[0]);
            count += breakdown_Same(laststep1[0] + laststep1[2], laststep1[2]);
            message += "STEP7) Check " + (laststep1[0] + laststep1[2]).ToString() + " with " + laststep1[0].ToString() + ", " + laststep1[2].ToString() + " for breakdown same is " + count.ToString() + Environment.NewLine;
            total += count;

            count = 0;
            for (int i = 0; i < list16.Count; i++)
            {
                count += exactSame(list16[i], laststep1[0] + laststep1[2], 1);
            }
            message += "STEP8) Check " + (laststep1[0] + laststep1[2]).ToString() + " with " + messageAdd(list16) + " for exactsame is " + count.ToString() + Environment.NewLine;
           
            total += count;

            count = 0;
            sum = 0;
            for (int i = 0; i < laststep1.Count; i++)
            {
                sum += laststep1[i];
            }
            for (int i = 0; i < DateList.Count; i++)
            {
                count += breakdown_Same(sum, DateList[i]);
                count += exactSame(sum, DateList[i], 3);
            }
            message += "STEP9) Check " + sum.ToString() + " with " +  messageAdd(DateList) + " for exactsame and breakdown is " + count.ToString() + Environment.NewLine;
            total += count;

            List<int> laststep10 = new List<int>();
            laststep10.Add(laststep1[0]);
            laststep10.Add(laststep1[2]);
            laststep10.Add(laststep1[0] + laststep1[2]);
            laststep10.Add(sum);
            laststep10.AddRange(list16);
            laststep10.AddRange(DateList);
            count = 0;
            for (int i = 0; i < laststep10.Count - 1; i++)
            {
                for (int j = i + 1; j < laststep10.Count; j++)
                {
                    count += exactSame(laststep10[i], laststep10[j], 1);
                }
            }
            message += "STEP10) Check " + messageAdd(laststep10) + " for exactsame is " + count.ToString() + Environment.NewLine;
            total += count;

            message += "STEP11) Total is " + total.ToString() + ", ";
            FORMULA2 = total;
            if (total % 2 != 0)
            {
                if (laststep == "UP")
                {
                    laststep = "DOWN";
                }
                else
                {
                    laststep = "UP";
                }
            }
            message += laststep + Environment.NewLine;

            message += "==============================";
            File.AppendAllText("log.txt", message);

            return laststep;
        }

        private int updown(int num1, int num2)
        {
            if (num1 == num2) return 2;
            else return 1;
        }


        private int exactsameList(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    count += exactSame(list[i], list[j], 2);
                }
            }
            return count;
        }

        private string  finalResult(int final, int sum)
        {
            if (sum % 2 == 0)
            {
                if (final == 1) return "DOWN";
                else return "UP";
            }
            else
            {
                if (final == 1) return "UP";
                else return "DOWN";
            }
        }



        int FORMULA1 = 0;
        int FORMULA2 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            string time1 = Time1_Text.Text;
            string time2 = Time2_Text.Text;
            string date = Date_Text.Text;
            step1(time1, time2, date);



            string[] excel = new string[6];

            Check_Text.Text = "4";
            string str = step1(time1, time2, date);
            excel[0] = str;
            Check_Text.Text = "9";
            str = step1(time1, time2, date);
            excel[1] = str;
            Check_Text.Text = "7";
            str = step1(time1, time2, date);
            excel[2] = str;
            Check_Text.Text = "2";
            str = step1(time1, time2, date);
            excel[3] = str;
            Check_Text.Text = "8";
            str = step1(time1, time2, date);
            excel[4] = str;
            Check_Text.Text = "5";
            str = step1(time1, time2, date);
            excel[5] = str;
            finalStep(date, int.Parse(Time1_Text.Text.Split(':')[0].ToLower()), excel);


            message = "★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★" + Environment.NewLine;
            message += "FORMULA ONE : " + FORMULA1.ToString() + "           ";
            message += "FORMULA TWO : " + FORMULA2.ToString() + Environment.NewLine;


            // STEP1) We add 7+3=10,11,21, then we check 10,11,21 with 7,3 is two same with breakdown
            List<int> list1 = new List<int>();
            list1.AddRange(need01(FORMULA1 + FORMULA2));
            int count = 0;
            int total = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                count += breakdown_Same(list1[i], FORMULA1);
                count += breakdown_Same(list1[i], FORMULA2);
            }
            total += count;
            message += "STEP1) We check " + messageAdd(list1) + " with " + FORMULA1.ToString() + ", " + FORMULA2.ToString() + " for breakdown same, so same is " + count.ToString() + Environment.NewLine;


            // STEP2) Then we check 6,7,13 and date 20010104 and 8,12,20,21,41 for breakdown same is 4 same

            int time = int.Parse(Time1_Text.Text.Split(':')[0].ToLower());
            List<int> list2 = new List<int>();
            list2.Add(time);
            list2.Add(time + 1);
            list2.Add(2 * time + 1);
            DateList.Clear();
            dateAdd(date);
            list2.AddRange(DateList);
            list2.AddRange(dataAdd3(date));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 3; j < list2.Count; j++)
                {
                    count += breakdown_Same(list2[i], list2[j]);
                }
            }
            total += count;
            message += "STEP2) We check " + messageAdd(list2) + " for breakdown same is " + count.ToString() + Environment.NewLine;

            // STEP3) Need to check like here 7,3,10,11,21 with date and time for exact 7 = 7 or 12 = 12 = 21 same
            count = 0;
            // list1.Add(FORMULA1);
            // list1.Add(FORMULA2);
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    count += exactSame(list1[i], list2[j], 4);
                }
            }
            message += "STEP3) We check " + messageAdd(list1) + " with date and time for exact same, so same is " + count.ToString() + Environment.NewLine;
            total += count;

            // STEP4) We need to check 7,3,10,11,21 for 9 same like here is 7,11,18 is one same for 9 and 18 and 7 one more same, no need to check time for 9 same
            count = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                count += breakdown_Same(list1[i], 9);
            }
            message += "STEP4) We Check " + messageAdd(list1) + " for 9, so same is " + count.ToString() + Environment.NewLine;
            total += count;

            // STEP5) Check i) 7 with time2 7 is one same, so now we have 2+4+1=7 same here no need to check 7 same and time2 for same and no need to check with 7
            // count = exactSame(list2[1], FORMULA1, 4);
            // total += count;
            // message += "STEP5) We check " + FORMULA1.ToString() + " with " + list2[1].ToString() + " is " + count.ToString() + ", total is " + total.ToString() + Environment.NewLine;

            // STEP6) Need to check 7 for exact same with date no same
            count = 0;
            for (int i = 3; i < list2.Count; i++)
            {
                count += exactSame(total, list2[i], 1);
            }
            message += "STEP6) We Check " + total.ToString() + " for exact same with date " + count.ToString() + Environment.NewLine;
            total += count;

            List<int> fewstep1 = new List<int>();
            fewstep1.Add(total);
            fewstep1.Add(FORMULA1);
            fewstep1.Add(FORMULA2);

            int fewstep0 = 0;

            string result = "";
            if (updown(FORMULA1 % 2, FORMULA2 % 2) % 2 == 0)
            {
                result = "up";
                fewstep0 += 2;
            }
            else
            {
                result = "down";
                fewstep0 += 1;
            }


            
            message += "So total is " + total.ToString() + " and FORMULA ONE , FORMULA TWO is " + FORMULA1.ToString() + ", " + FORMULA2.ToString() + " is " + result + ", So result is ";
            if (total % 2 != 0)
            {
                if (result == "up")
                {
                    result = "down";
                }
                else
                {
                    result = "up";
                }
            }
            if (result == "up") fewstep0 += 2;
            else fewstep0 += 1;
            message += result + Environment.NewLine;


            message += "====================LAST FEW STEPS======================" + Environment.NewLine;

            // Date is 20010108 Time is 10,11,21
            // STEP1) Check 35,22,14 for 4 same
            count = 0;
            total = 0;
            for (int i = 0; i < fewstep1.Count; i++)
            {
                count += breakdown_Same(fewstep1[i], fewstep0);
            }
            message += "STEP1) Check " + messageAdd(fewstep1) + " for " + fewstep0.ToString() + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            // STEP2) Check i)22+ii)14 for 9 and 4 same
            count = breakdown_Same(fewstep1[1] + fewstep1[2], 9);
            count += breakdown_Same(fewstep1[1] + fewstep1[2], fewstep0);
            message += "STEP2) Check " + (fewstep1[1] + fewstep1[2]).ToString() + " for 9 and " + fewstep0.ToString() + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            // STEP3) Add 4 to third number here ii)14
            count = breakdown_Same(4 + fewstep1[2], 9);
            count += breakdown_Same(4 + fewstep1[2], fewstep0);
            message += "STEP3) Check " + (4 + fewstep1[2]).ToString() + " for 9 and " + fewstep0.ToString() + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            // STEP4) Add 8 to third number here ii)14
            count = breakdown_Same(8 + fewstep1[2], 9);
            count += breakdown_Same(8 + fewstep1[2], fewstep0);
            message += "STEP4) Check " + (8 + fewstep1[2]).ToString() + " for 9 and " + fewstep0.ToString() + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            // STEP5) Check for total same and check like here 35, 22, 14 for breakdown same
            count = 0;
            for (int i = 0; i < fewstep1.Count; i++)
            {
                count += breakdown_Same(total, fewstep0);
            }
            message += "STEP5) Check " + total.ToString() + " for " + messageAdd(fewstep1) + " same is " + count.ToString() + Environment.NewLine;
            total += count;
            message += "So total is " + total.ToString() + ", result is ";
            if (total % 2 != 0)
            {
                if (result == "up")
                {
                    result = "down";
                }
                else
                {
                    result = "up";
                }
            }
            message += result + Environment.NewLine;


            message += "====================================================================" + Environment.NewLine;
            List<int> additions2 = new List<int>();
            List<int> additions3 = new List<int>();
            count = 0;
            int lasttotal = total;
            total = 0;
            for (int i = 0; i < fewstep1.Count; i++)
            {
                count += exactSame(lasttotal, fewstep1[i], 1);
                count += breakdown_Same(lasttotal, fewstep1[i]);
            }
            total += count;
            message += "STEP1) Check " + lasttotal.ToString() + " with " + messageAdd(fewstep1) + " for exactsame and breakdown, so same is " + count.ToString() + Environment.NewLine;
            additions2.AddRange(fewstep1);

            count = 0;
            List<int> lastfewstep = new List<int>();
            lastfewstep.AddRange(need01more1001(fewstep1[0], fewstep1[1]));
            for (int i = 0; i < lastfewstep.Count; i++)
            {
                count += exactSame(lasttotal, lastfewstep[i], 1);
                count += breakdown_Same(lasttotal, lastfewstep[i]);
            }
            total += count;
            message += "STEP2) Check " + lasttotal.ToString() + " with " + messageAdd(lastfewstep) + " for exactsame and breakdown, so same is " + count.ToString() + Environment.NewLine;
            additions2.AddRange(lastfewstep);
            additions3.AddRange(lastfewstep);

            count = 0;
            lastfewstep.Clear();
            lastfewstep.AddRange(need01more1001(fewstep1[2], fewstep1[1]));
            for (int i = 0; i < lastfewstep.Count; i++)
            {
                count += exactSame(lasttotal, lastfewstep[i], 1);
                count += breakdown_Same(lasttotal, lastfewstep[i]);
            }
            total += count;
            message += "STEP3) Check " + lasttotal.ToString() + " with " + messageAdd(lastfewstep) + " for exactsame and breakdown, so same is " + count.ToString() + Environment.NewLine;
            additions2.AddRange(lastfewstep);
            additions3.AddRange(lastfewstep);

            lastfewstep.Clear();
            lastfewstep.AddRange(need01more1003(fewstep1[2], fewstep1[1], fewstep1[0]));
            for (int i = 0; i < lastfewstep.Count; i++)
            {
                count += exactSame(lasttotal, lastfewstep[i], 1);
                count += breakdown_Same(lasttotal, lastfewstep[i]);
            }
            total += count;
            message += "STEP4) Check " + lasttotal.ToString() + " with " + messageAdd(lastfewstep) + " for exactsame and breakdown, so same is " + count.ToString() + Environment.NewLine;
            additions2.AddRange(lastfewstep);
            additions3.AddRange(lastfewstep);

            int additionsTemp = count;
            count = 0;
            List<int> additions1 = new List<int>();

            // additions1
            // Next Step) Add 14 + 8 + 12 = 34 + 0 = 34,35,69, check for 9 same and 0 same

            //             for (int i = 0; i < lastfewstep.Count; i++)
            //             {
            //                 additions1.AddRange(need01(lastfewstep[i] + additionsTemp));
            //             }
            //             for (int i = 0; i < additions1.Count; i++)
            //             {
            //                 count += breakdown_Same(additions1[i], 9);
            //             }
            //             message += "STEP5) Check " + messageAdd(additions1) + " for 9 same is " + count.ToString() + Environment.NewLine;

            // additions2
            // Check for 9 also in STEP1 to STEP4 so here 28 and 39 is two more same

            // for (int i = 0; i < additions2.Count; i++)
            // {
            //    count += breakdown_Same(additions2[i], 9);
            // }
            // message += "STEP5) Check for 9 in (STEP1 to STEP4) " + messageAdd(additions2) + ", so same is " + count.ToString() + Environment.NewLine;


            // additions3
            // Check for 2 also in STEP2 to STEP4 so here 28 and 39 is two more same

            // for (int i = 0; i < additions3.Count; i++)
            // {
            //     count += breakdown_Same(additions3[i], 2);
            // }
            // message += "STEP5) Check for 2 in (STEP2 to STEP4) " + messageAdd(additions3) + ", so same is " + count.ToString() + Environment.NewLine;

            // additions4
            // Check 6 with 25,6,11,31,17,42   6 is lasttotal

            // for (int i = 0; i < additions2.Count; i++)
            // {
            //     count += breakdown_Same(total, additions2[i]);
            // }
            // message += "STEP5) Check for " + total.ToString() + " with " + messageAdd(additions2) + ", So same is " + count.ToString() + Environment.NewLine;

            // Add 6 to 25,6,11,31,17,42 like 25 + 6 = 31 …. To check for 9 same

            List<int> additions5 = new List<int>();
            if (total == 0)
            {
                additions5.AddRange(additions2);
            }
            else
            {
                for (int i = 0; i < additions2.Count; i++)
                {
                    additions5.AddRange(need01more1001(additions2[i], total));
                }
            }
            for (int i = 0; i < additions5.Count; i++)
            {
                count += breakdown_Same(9, additions5[i]);
            }
            message += "STEP5) Check for 9 with " + messageAdd(additions5) + ", so same is " + count.ToString() + Environment.NewLine;
            total += count;
            message += "So total is " + total.ToString() + ", result is ";
            if (total % 2 != 0)
            {
                if (result == "up")
                {
                    result = "down";
                }
                else
                {
                    result = "up";
                }
            }
            message += result + Environment.NewLine;


            log.Text = message;
        }
    }
}
