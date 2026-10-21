using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _049_Balberan_JhonRey_MACT1
{
    public partial class frmBankTransaction : Form
    {
        double balance = 0;

        public frmBankTransaction()
        {
            InitializeComponent();
        }


        private void cmbTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransaction.SelectedIndex == 1) // deposit
            {
                txtWithdrawAmt.Enabled = false;
                txtDepositAmt.Enabled = true;
                txtWithdrawAmt.Clear();
            }
            else if (cmbTransaction.SelectedIndex == 2) // withdraw
            {
                txtWithdrawAmt.Enabled = true;
                txtDepositAmt.Enabled = false;
                txtDepositAmt.Clear();
            }
            else
            {
                txtWithdrawAmt.Enabled = false;
                txtDepositAmt.Enabled = false;
                txtDepositAmt.Clear();
                txtWithdrawAmt.Clear();
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbTransaction.SelectedIndex == 0)
            {
                MessageBox.Show($"Your current balance is {balance:C2}");
            } else if (cmbTransaction.SelectedIndex == 1) // deposit
            {
                if (double.TryParse(txtDepositAmt.Text, out double depositAmt))
                {
                    if (depositAmt >= 500 &&  depositAmt <= 10000)
                    {
                        balance += depositAmt;
                        MessageBox.Show($"Successfully deposited {depositAmt:C2}. Your new balance is {balance:C2}");
                        resetForm();
                    }
                    else
                    {
                        if (depositAmt < 500)
                        {
                            MessageBox.Show("Minimum amount is 500");
                        } else {
                            MessageBox.Show("Maximum amount is 10000.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input amount is invalid!");
                }
            }
            else if (cmbTransaction.SelectedIndex == 2) // withdraw
            {
                if (double.TryParse(txtWithdrawAmt.Text, out double withdrawAmt))
                {
                    if (withdrawAmt >= 500 && withdrawAmt <= 10000)
                    {
                        if(withdrawAmt <= balance)
                        {
                            balance -= withdrawAmt;
                            MessageBox.Show($"Successfully withdrew {withdrawAmt:C2}. Your new balance is {balance:C2}");
                            resetForm();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient funds for this withdrawal.");
                            resetForm();
                        }
                    }
                    else
                    {
                        if (withdrawAmt < 500)
                        {
                            MessageBox.Show("Minimum withdrawal amount is 500");
                        }
                        else
                        {
                            MessageBox.Show("Maximum withdrawal amount is 10000.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input amount is invalid!");
                }
            } else
            {
                MessageBox.Show("Select a transaction");
                return;
            }
        }

        void resetForm()
        {
            txtDepositAmt.Clear();
            txtWithdrawAmt.Clear();
        }
    }
}
