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
        public Form1()
        {
            InitializeComponent();
        }

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

        int[][] combine = {
            new int[] { 0, 0}, //0
            new int[] { 1, 3}, //1
            new int[] { 1, 5}, //2
            new int[] { 1, 7}, //3
            new int[] { 1, 9}, //4
            new int[] { 4, 1}, //5
            new int[] { 2, 0}, //6
            new int[] { 2, 6}, //7
            new int[] { 3, 2}, //8
            new int[] { 9, 1}, //9
            new int[] { 1, 5}, //10
            new int[] { 1, 8}, //11
            new int[] { 3, 7}, //12
            new int[] { 5, 9}, //13
            new int[] { 8, 1}, //14
            new int[] { 1, 3}, //15
            new int[] { 1, 7}, //16
            new int[] { 2, 1}, //17
            new int[] { 9, 9}, //18
            new int[] { 2, 2}, //19
            new int[] { 1, 5}, //20
            new int[] { 2, 2}, //21
            new int[] { 2, 4}, //22
            new int[] { 0, 0}, //23
        };
        string message = "";
        List<int> DateList = new List<int>();
        List<int> TimeList = new List<int>();
        int sameCount = 0;
        int TIME = 0;
        string up_down = "";
        private void testBtn_Click(object sender, EventArgs e)
        {

            string date = textBox1.Text;
            string time = textBox2.Text;
            formula(date, time);
            textBox3.Text = message;
        }

        private void clearFormula()
        {
            up_down = "";
            message = "";
            DateList.Clear();
            TimeList.Clear();
            sameCount = 0;
        }

        private string formula(string date, string time)
        {
            clearFormula();
            
            up_down = "";
            int t = int.Parse(time);
            if (t < 1 || t > 22)
            {
                return "";
            }
            message += "💥 💥 💥 💥 💥 " + date + "   " + time + " 💥 💥 💥 💥 💥" + Environment.NewLine;
            dateAdd1(date);
            dateAdd2(date);
            timeAdd(time);
            message += "✔ Date Add : " + messageAdd(DateList) + Environment.NewLine;
            message += "✔ Time Add : " + messageAdd(TimeList) + Environment.NewLine;
            message += "🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 🚗 " + Environment.NewLine;
            message += "Step1) Combine Find : " + combine[TIME][0].ToString() + ", " + combine[TIME][1].ToString();
            int same = check_combine_DT();
            up_down = step1(same);
            message += "🚗 🚗 🚗 🚗 🚗 " + up_down + " 🚗 🚗 🚗 🚗 🚗" + Environment.NewLine;
            try
            {
                File.AppendAllText("log.txt", message);
            }
            catch (Exception)
            {
            }
            return up_down;
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
        private string messageAdd1(int num)
        {
            string msg = "";
            if (num > 99) num = num / 10 + num % 10;
            for (int i = 0; i < breakdown[num].Length - 1; i++)
            {
                msg += breakdown[num][i].ToString() + ", ";
            }
            msg += breakdown[num][breakdown[num].Length - 1].ToString();
            return msg;
        }
        private void dateAdd1(string date)
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
        private void dateAdd2(string date)
        {
            int x = 0, y = 0;

            char[] myArray = date.ToCharArray();
            List<int> dateArray = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                x = x + Int32.Parse(myArray[i].ToString());
                if (Int32.Parse(myArray[i].ToString()) == 0)
                {
                    y++;
                }
                else
                {
                    y = y + Int32.Parse(myArray[i].ToString());
                }
            }
            dateArray.Add(x);
            dateArray.Add(y);
            dateArray.Add(x + y);
            if ((x + y) % 10 == 0 && sameCount != 0)
            {
                dateArray.Add(x + y + 1);
                dateArray.Add(2 * (x + y) + 1);
            }
            for (int i = 0; i < dateArray.Count; i++)
            {
                DateList.Add(dateArray[i]);
            }
        }
        private void timeAdd(string time)
        {
            List<int> timeArray = new List<int>();
            int x = Int32.Parse(time);
            TIME = x;
            timeArray.Add(x);
            timeArray.Add(x + 1);
            timeArray.Add(2 * x + 1);
            for (int i = 0; i < timeArray.Count; i++)
            {
                TimeList.Add(timeArray[i]);
            }
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
                    int index = Array.IndexOf(breakdown[t], 2);
                    if (index != -1)
                    {
                        return 2;
                    }
                }
                if (d == 12 || d == 21 || d == 19 || d == 91)
                {
                    int index = Array.IndexOf(breakdown[t], 1);
                    if (index != -1)
                    {
                        return 2;
                    }
                }
                if (d == 36 || d == 63)
                {
                    int index = Array.IndexOf(breakdown[t], 3);
                    if (index != -1)
                    {
                        return 2;
                    }
                }

                if (t == 24 || t == 42)
                {
                    int index = Array.IndexOf(breakdown[d], 2);
                    if (index != -1)
                    {
                        return 2;
                    }
                }
                if (t == 12 || t == 21 || t == 19 || t == 91)
                {
                    int index = Array.IndexOf(breakdown[d], 1);
                    if (index != -1)
                    {
                        return 2;
                    }
                }
                if (t == 36 || t == 63)
                {
                    int index = Array.IndexOf(breakdown[d], 3);
                    if (index != -1)
                    {
                        return 2;
                    }
                }
            }

            // 13 = 13 is 3 same
            if (t == d && t > 9)
            {
                return 3;
            }
            // 13 = 31 is 3 same
            int x = Int32.Parse(Reverse(d.ToString()));
            if (t == x && t > 9)
            {
                return 1;
            }
            count = 0;

            if (t > 99) t = t / 10 + t % 10;
            if (d > 99) d = d / 10 + d % 10;
            for (int i = 0; i < breakdown[t].Length; i++)
            {
                for (int j = 0; j < breakdown[d].Length; j++)
                {
                    if (breakdown[t][i] == breakdown[d][j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private int check_combine_DT()
        {
            int count = 0;
            for (int i = 0; i < combine[TIME].Length; i++)
            {
                for (int j = 0; j < DateList.Count; j++)
                {
                    count += breakdown_Same(DateList[j], combine[TIME][i]);
                }
                for (int j = 0; j < TimeList.Count; j++)
                {
                    count += breakdown_Same(TimeList[j], combine[TIME][i]);
                }
            }
            message += "   ✔ Check combine with Date and Time is " + count.ToString() + " same" + Environment.NewLine;
            return count;
        }

        private string step1(int smae)
        {
            int check = combine[TIME][0] * 10 + combine[TIME][1];
            int sum = check + smae;
            message += "Step2) " + check.ToString() + " + " + smae.ToString() + " = " + sum.ToString() + " Check for exact same in Date and Time and " + messageAdd1(sum) + " with " + messageAdd(TimeList);
            int count = 0;
            for (int i = 0; i < DateList.Count; i++)
            {
                count += exactSame(sum, DateList[i]);
            }
            for (int i = 0; i < TimeList.Count; i++)
            {
                count += exactSame(sum, TimeList[i]);
                count += breakdown_Same(sum, TimeList[i]);
            }
            message += " is " + count.ToString() + " same" + Environment.NewLine;

            message += "Step3) " + (sum + count).ToString() + " and " + TimeList[1].ToString() + " is " + even_odd(sum + count) + " " + even_odd(TimeList[1]) + " is ";
            string str = getResult(even_odd(sum + count), even_odd(TimeList[1]));
            message += str + Environment.NewLine;
            return str;
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
            if (a > 9 && b > 9)
            {
                if (a == b) return 1;
                else return 0;
            }
            else return 0;
        }

        private string even_odd(int num)
        {
            if (num % 2 == 0) return "even";
            return "odd";
        }
        private string getResult(string s1, string s2)
        {
            if (s1 == s2) return "Up";
            return "Down";
        }
        string path = "";
        private void openBtn_Click(object sender, EventArgs e)
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
                formulaBtn.Enabled = true;
            }
        }
        Microsoft.Office.Interop.Excel.Workbook MyBook = null;
        Microsoft.Office.Interop.Excel.Application MyApp = null;
        Microsoft.Office.Interop.Excel.Worksheet MySheet = null;
        ThreadStart excelThread;
        Thread excelThread_Thread;
        private void formulaBtn_Click(object sender, EventArgs e)
        {
            excelThread = new ThreadStart(excelThreadStart);
            excelThread_Thread = new Thread(excelThread);
            excelThread_Thread.Start();
        }
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
                for (index = 2; index <= lastRow; index++)
                {
                    try
                    {
                        System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "I" + index.ToString()).Cells.Value;

                        String date = MyValues.GetValue(1, 2).ToString();
                        double d = double.Parse(MyValues.GetValue(1, 3).ToString()) * 24;
                        String time = Math.Round(d).ToString();
                        textBox1.Text = date;
                        textBox2.Text = time;
                        string str = formula(date, time);
                        lastRow = MySheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row;
                        MySheet.Cells[index, 9] = str;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
            }
            MyBook.Close(true);
            MyApp.Quit();
            MessageBox.Show("Done");
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            try { MyBook.Close(true); } catch (Exception) { }
            try { MyApp.Quit(); } catch (Exception) { }
            try { excelThread_Thread.Abort(); } catch (Exception) { }
        }
    }
}
