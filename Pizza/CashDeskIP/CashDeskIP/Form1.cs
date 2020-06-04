using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashDeskIP
{
    public partial class Form1 : Form
    {
        WebSocket ws;

        int j = 0;

        Pizza margherita;
        Pizza quattroFormaggi;
        Pizza peperoni;
        Pizza supreme;
        Pizza hawaii;
        Pizza capricciosa;
        Pizza calzone;
        Pizza veggie;

        List<Pizza> pizzas;
        List<int> counters;

        double orderPrice = 0;
        bool notify = false;
        public Form1()
        {
            InitializeComponent();
            ws = new WebSocket();


            margherita = new Pizza("Margherita", 6);
            quattroFormaggi = new Pizza("Quattro Formaggi", 8.5);
            peperoni = new Pizza("Peperoni", 8);
            supreme = new Pizza("Supreme", 10);
            hawaii = new Pizza("Hawaii", 7.5);
            capricciosa = new Pizza("Capricciosa", 8);
            calzone = new Pizza("Calzone", 7.5);
            veggie = new Pizza("Veggie", 8);

            pizzas = new List<Pizza>();
            counters = new List<int>();

            pizzas.Add(calzone);
            pizzas.Add(veggie);
            pizzas.Add(margherita);
            pizzas.Add(hawaii);
            pizzas.Add(capricciosa);
            pizzas.Add(supreme);
            pizzas.Add(quattroFormaggi);
            pizzas.Add(peperoni);

            for (int i = 0; i < 8; i++)
            {
                counters.Add(0);
            }
            counters.Add(1);

            /*Timer Event*/
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = (5000);
            timer.Enabled = true;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            List<String> msgs = ws.GetMsg();
            
            for (j=j; j < msgs.Count; j++)
            {
               
                
                    //pendingOrdersLb.Items.Add(msgs[j]);
                if (msgs[j].Contains("ready") && notify == false)
                {
                    notify = true;
                    MessageBox.Show("An order is ready! Please, collect", "Order Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                notify = false;
            }

        }
            private void Form1_Load(object sender, EventArgs e)
        {
            newOrderPnl.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            int height = this.Height;
            int width = this.Width;
            int lblH = titleLbl.Height;
            int lblW = titleLbl.Width;
            int btnH = lblH;
            int btnW = lblW / 4;
            int pnlH = height - lblH + 2 * (height / 6 - lblH) - 300;
            int pnlW = width - width / 10;
            

            /*Main Section*/
            titleLbl.SetBounds(width / 2 - lblW / 2, (height / 6 - lblH) / 2, lblW, lblH);
            quitBtn.SetBounds(width - width / 20 - btnW, (height / 6 - lblH) / 2, btnW, btnH);

            /*Panel Pending Orders*/
            pendingOrdersPnl.SetBounds(width/20, lblH + 2 * (height/6-lblH), pnlW, pnlH);
            pendingOrdersLbl.SetBounds(pnlW / 2 - lblW / 2, (pnlH / 6 - lblH) / 2, lblW, lblH);
            pendingOrdersLb.SetBounds(pnlW / 20, pnlH / 6, pnlW - 2 * pnlW / 20, pnlH - pnlH / 6 - 20);
            orderCompletedBtn.SetBounds(pnlW - pnlW / 20 - btnW, (pnlH / 6 - lblH) / 2, btnW, btnH);            
            newOrderBtn.SetBounds((pnlW - lblW) / 2 - 2 * btnW - width / 20 - 10, (pnlH / 6 - lblH) / 2, btnW, btnH);

            /*Panel New Order*/
            newOrderPnl.SetBounds(width / 20, lblH + 2 * (height / 6 - lblH), pnlW, pnlH);            
            pizzaOnePb.SetBounds(0,0, pnlW/6, pnlH/4);
            pizzaTwoPb.SetBounds(pnlW / 6, 0, pnlW/6, pnlH/4);
            pizzaThreePb.SetBounds(0, pnlH / 4, pnlW / 6, pnlH / 4);
            pizzaFourPb.SetBounds(pnlW / 6, pnlH / 4, pnlW/6, pnlH/4);
            pizzaFivePb.SetBounds(0, 2*(pnlH / 4), pnlW / 6, pnlH / 4);
            pizzaSixPb.SetBounds(pnlW / 6, 2*(pnlH / 4), pnlW/6, pnlH/4);
            pizzaSevenPb.SetBounds(0, 3*(pnlH / 4), pnlW / 6, pnlH / 4);
            pizzaEightPb.SetBounds(pnlW / 6, 3 * (pnlH / 4), pnlW/6, pnlH/4);
            ordersLb.SetBounds(pnlW / 2, lblH, (pnlW - 2 * pnlW / 20) / 2, pnlH - pnlH / 6 - 20);
            cancelBtn.SetBounds(2 * (pnlW / 6) + 10, pnlH-btnH-10, btnW +btnW/2, btnH) ;
            confirmBtn.SetBounds(2 * (pnlW / 6) + 10, pnlH - 2*btnH - 2*10, btnW + btnW / 2, btnH);
            remarksRTb.SetBounds(2 * (pnlW / 6) + 10, pnlH - 5 * btnH - 5 * 10, btnW + btnW / 2, 3*btnH);
            remarksLbl.SetBounds(2 * (pnlW / 6) + 10, pnlH - 5 * btnH - 5 * 10 - lblH, lblW, lblH);
            nameLbl.SetBounds(2 * (pnlW / 6) + 10, pnlH - 5 * btnH - 5 * 10 - 2 * lblH - btnH, lblW, lblH);
            nameTb.SetBounds(2 * (pnlW / 6) + 10, pnlH - 5 * btnH - 5 * 10 - lblH - btnH, btnW + btnW / 2, btnH);

            try
            {
                ws.connect("192.168.69.201", "56438", "192.168.69.200", "56438");
                MessageBox.Show("Connection has been established.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are technical issues with the connection to the server. Please, restart the application or call your corresponding system administrator!");

            }
            MessageBox.Show("Please, wait a few seconds!");
            System.Threading.Thread.Sleep(5000);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            pendingOrdersPnl.Visible = false;
            newOrderPnl.Visible = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (ordersLb.Items.Count == 0)
            {
                MessageBox.Show("The order is empty!");
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm the order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!string.IsNullOrWhiteSpace(nameTb.Text))
                    {
                        int sum = 0;
                        String pizzasToPrep = " ";
                        for (int i = 0; i < 8; i++)
                        {
                            sum += counters[i];
                            if(counters[i] > 0) pizzasToPrep += counters[i].ToString() + " x " + pizzas[i].GetName() + " ";
                            counters[i] = 0;
                        }
                        ws.sendMsg(sum.ToString() + "@OI:" + counters[8].ToString() + " " + pizzasToPrep + " Remarks: " +remarksRTb.Text);
                        pendingOrdersLb.Items.Add("Order ID: " + counters[8].ToString() + " | Client Name: " + nameTb.Text + " | " + pizzasToPrep + " " + orderPrice.ToString());
                        newOrderPnl.Visible = false;
                        pendingOrdersPnl.Visible = true;
                        counters[8]++;
                        orderPrice = 0;
                        ordersLb.Items.Clear();
                        nameTb.Clear();
                        remarksRTb.Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Name field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
                
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            newOrderPnl.Visible = false;
            pendingOrdersPnl.Visible = true;
        }

        private void orderCompletedBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                pendingOrdersLb.Items.RemoveAt(pendingOrdersLb.SelectedIndex);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("There is not selected order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pizzaOnePb_Click(object sender, EventArgs e)
        {
            addPizza(0);
        }

        private void pizzaTwoPb_Click(object sender, EventArgs e)
        {
            addPizza(1);
        }

        private void pizzaThreePb_Click(object sender, EventArgs e)
        {
            addPizza(2);
        }

        private void pizzaFourPb_Click(object sender, EventArgs e)
        {
            addPizza(3);
        }

        private void pizzaFivePb_Click(object sender, EventArgs e)
        {
            addPizza(4);
        }

        private void pizzaSixPb_Click(object sender, EventArgs e)
        {
            addPizza(5);
        }

        private void pizzaSevenPb_Click(object sender, EventArgs e)
        {
            addPizza(6);
        }

        private void pizzaEightPb_Click(object sender, EventArgs e)
        {
            addPizza(7);
        }

        public void addPizza(int i)
        {
            if (ordersLb.Items.Count > 0)
            {
                ordersLb.Items.Remove(counters[i] + " x " + pizzas[i].GetName() +" "+ counters[i] * pizzas[i].GetPrice() + "\u20AC");
            }
            counters[i]++;
            ordersLb.Items.Add(counters[i] + " x " + pizzas[i].GetName() + " " + counters[i] * pizzas[i].GetPrice() + "\u20AC");
            orderPrice += pizzas[i].GetPrice();
        }
    }
}
