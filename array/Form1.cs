using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class Form1 : Form
    {
        int[] arr;
        int[] arr2; // inv
        int[] arr3; // rol
        int[] arr4; // ror
        int shift;
        public Form1()
        {
            InitializeComponent();
        }

        private void display()
        {
            tbOutput.Clear();
            int z = 0;
            foreach (int i in arr)
            {
                z++;
                String o = ",";

                if (z == arr.Length)
                {
                    o = null;
                }
                tbOutput.Text = tbOutput.Text + i + o;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                tbOutput.Clear();
                string[] words = tbInput.Text.Split(',');
                arr = new int[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    arr[i] = Convert.ToInt32(words[i]);
                }
                display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSHL_Click(object sender, EventArgs e)
        {
            try
            {
                shift = Convert.ToInt32(tbBit.Text);
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (shift < arr.Length)
                    {
                        if (arr.Length - i == shift)
                        {
                            for (int j = 0; j < shift; j++)
                            {
                                arr[i] = 0;
                                i++;
                            }
                            break;
                        }

                        arr[i] = arr[i + shift];
                    }
                }
                arr[arr.Length - 1] = 0;

                display();
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert Bit Or Press OK");
            }
        }
        private void btnSHR_Click(object sender, EventArgs e)
        {
            try
            {
                shift = Convert.ToInt32(tbBit.Text);
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (i < shift)
                    {
                        for (int j = 0; j < shift; j++)
                        {
                            arr[i] = 0;
                            i--;
                        }
                        break;
                    }
                    arr[i] = arr[i - shift];
                }
                arr[0] = 0;
                display();
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert Bit Or Press OK");
            }
        }
        private void btnINV_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr2 = new int[arr.Length];
                
                for(int i= 0; i<= arr.Length-1; i++)
                {
                    arr2[i] = arr[i];
                }
                int[] arr1 = new int[arr2.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr2[arr.Length - 1 - i];
                }
                display();
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert Bit Or Press OK");
            }
        }
        private void btnROL_Click(object sender, EventArgs e)
        {
            try
            {
                shift = Convert.ToInt32(tbBit.Text);
                int[] arr3 = new int[arr.Length];

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    arr3[i] = arr[i];
                }

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (shift < arr.Length)
                    {
                        if (arr.Length - i == shift)
                        {
                            for (int j = 0; j < shift; j++)
                            {
                                arr[i] = arr3[j];
                                i++;
                            }
                            continue;
                        }

                        arr[i] = arr[i + shift];
                    }
                }

                display();
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert Bit Or Press OK");
            }
        }
        private void btnROR_Click(object sender, EventArgs e)
        {
            try
            {
                shift = Convert.ToInt32(tbBit.Text);
                int[] arr4 = new int[arr.Length];

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    arr4[i] = arr[i];
                }

                for (int i = arr.Length-1 ; i >= 0; i--)
                {
                    if (shift < arr.Length)
                    {
                        if (i+1 == shift)
                        {
                            for (int j = 0; j < shift; j++)
                            {
                                arr[i] = arr4[arr4.Length-1-j];
                                i--;
                            }
                            continue;
                        }

                        arr[i] = arr[i - shift];
                    }
                }

                display();
            }
            catch (Exception)
            {

                MessageBox.Show("Please insert Bit Or Press OK");
            }
        }
    }
}
