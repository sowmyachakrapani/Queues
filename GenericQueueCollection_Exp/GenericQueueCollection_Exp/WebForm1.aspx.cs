using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GenericQueueCollection_Exp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Queue<int> TokenQueue = (Queue<int>) Session["TokenQueue"];
            LblStatus.Text = "There are " + TokenQueue.Count.ToString()+"customers before you in the queue";
            if (Session["LastTokenNumberIssued"] == null)
            {
                Session["LastTokenNumberIssued"] = 0;
            }
            int nextTokenNumberToBeIssued =(int) Session["LastTokenNumberIssued"] + 1;
            Session["LastTokenNumberIssued"] = nextTokenNumberToBeIssued;
            TokenQueue.Enqueue(nextTokenNumberToBeIssued);
            AddTokenToListBox(TokenQueue);
        }

        private void AddTokenToListBox(Queue<int> TokenQueue)
        {
            ListTokens.Items.Clear();
            foreach (int token in TokenQueue)
            {
                ListTokens.Items.Add(token.ToString());
            }
        }

        private void ServeNextCustomer(TextBox textbox, int counterNumber)
        {
            Queue<int> TokenQueue = (Queue<int>)Session["TokenQueue"];
            if (TokenQueue.Count == 0)
            {
                textbox.Text = "no customers in the queue";
            }
            else
            {
                int tokenNumberToBeServed = TokenQueue.Dequeue();
                textbox.Text = tokenNumberToBeServed.ToString();
                TextBox4.Text = "Token number" + tokenNumberToBeServed.ToString() + "please goto the counter "+ counterNumber.ToString();
                AddTokenToListBox(TokenQueue);
            }



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TxtCounter1, 1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TxtCounter2, 2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServeNextCustomer(TxtCounter3, 3);
        }

        

       

      
    }
}