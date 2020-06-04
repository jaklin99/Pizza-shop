namespace CashDeskIP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.pendingOrdersPnl = new System.Windows.Forms.Panel();
            this.orderCompletedBtn = new System.Windows.Forms.Button();
            this.pendingOrdersLbl = new System.Windows.Forms.Label();
            this.pendingOrdersLb = new System.Windows.Forms.ListBox();
            this.newOrderPnl = new System.Windows.Forms.Panel();
            this.ordersLb = new System.Windows.Forms.ListBox();
            this.pizzaTwoPb = new System.Windows.Forms.PictureBox();
            this.pizzaEightPb = new System.Windows.Forms.PictureBox();
            this.pizzaSevenPb = new System.Windows.Forms.PictureBox();
            this.pizzaSixPb = new System.Windows.Forms.PictureBox();
            this.pizzaFivePb = new System.Windows.Forms.PictureBox();
            this.pizzaFourPb = new System.Windows.Forms.PictureBox();
            this.pizzaThreePb = new System.Windows.Forms.PictureBox();
            this.pizzaOnePb = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.remarksRTb = new System.Windows.Forms.RichTextBox();
            this.remarksLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.pendingOrdersPnl.SuspendLayout();
            this.newOrderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaTwoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaEightPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSevenPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSixPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaFivePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaFourPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThreePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaOnePb)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLbl.Location = new System.Drawing.Point(75, 25);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(654, 72);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Capo Supremo Pizzeria";
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quitBtn.Location = new System.Drawing.Point(697, 144);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 39);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.newOrderBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newOrderBtn.Location = new System.Drawing.Point(174, 25);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(75, 39);
            this.newOrderBtn.TabIndex = 4;
            this.newOrderBtn.Text = "New Order";
            this.newOrderBtn.UseVisualStyleBackColor = false;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // pendingOrdersPnl
            // 
            this.pendingOrdersPnl.BackColor = System.Drawing.Color.Transparent;
            this.pendingOrdersPnl.Controls.Add(this.orderCompletedBtn);
            this.pendingOrdersPnl.Controls.Add(this.pendingOrdersLbl);
            this.pendingOrdersPnl.Controls.Add(this.newOrderBtn);
            this.pendingOrdersPnl.Controls.Add(this.pendingOrdersLb);
            this.pendingOrdersPnl.Location = new System.Drawing.Point(453, 209);
            this.pendingOrdersPnl.Name = "pendingOrdersPnl";
            this.pendingOrdersPnl.Size = new System.Drawing.Size(276, 206);
            this.pendingOrdersPnl.TabIndex = 5;
            // 
            // orderCompletedBtn
            // 
            this.orderCompletedBtn.BackColor = System.Drawing.Color.Transparent;
            this.orderCompletedBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCompletedBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderCompletedBtn.Location = new System.Drawing.Point(101, 84);
            this.orderCompletedBtn.Name = "orderCompletedBtn";
            this.orderCompletedBtn.Size = new System.Drawing.Size(75, 39);
            this.orderCompletedBtn.TabIndex = 4;
            this.orderCompletedBtn.Text = "Order Completed";
            this.orderCompletedBtn.UseVisualStyleBackColor = false;
            this.orderCompletedBtn.Click += new System.EventHandler(this.orderCompletedBtn_Click);
            // 
            // pendingOrdersLbl
            // 
            this.pendingOrdersLbl.AutoSize = true;
            this.pendingOrdersLbl.BackColor = System.Drawing.Color.Transparent;
            this.pendingOrdersLbl.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingOrdersLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pendingOrdersLbl.Location = new System.Drawing.Point(-189, 67);
            this.pendingOrdersLbl.Name = "pendingOrdersLbl";
            this.pendingOrdersLbl.Size = new System.Drawing.Size(441, 72);
            this.pendingOrdersLbl.TabIndex = 3;
            this.pendingOrdersLbl.Text = "Pending Orders";
            // 
            // pendingOrdersLb
            // 
            this.pendingOrdersLb.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingOrdersLb.FormattingEnabled = true;
            this.pendingOrdersLb.ItemHeight = 29;
            this.pendingOrdersLb.Location = new System.Drawing.Point(48, 54);
            this.pendingOrdersLb.Name = "pendingOrdersLb";
            this.pendingOrdersLb.Size = new System.Drawing.Size(120, 62);
            this.pendingOrdersLb.TabIndex = 0;
            // 
            // newOrderPnl
            // 
            this.newOrderPnl.BackColor = System.Drawing.Color.Transparent;
            this.newOrderPnl.Controls.Add(this.nameLbl);
            this.newOrderPnl.Controls.Add(this.nameTb);
            this.newOrderPnl.Controls.Add(this.remarksLbl);
            this.newOrderPnl.Controls.Add(this.remarksRTb);
            this.newOrderPnl.Controls.Add(this.ordersLb);
            this.newOrderPnl.Controls.Add(this.pizzaTwoPb);
            this.newOrderPnl.Controls.Add(this.pizzaEightPb);
            this.newOrderPnl.Controls.Add(this.pizzaSevenPb);
            this.newOrderPnl.Controls.Add(this.pizzaSixPb);
            this.newOrderPnl.Controls.Add(this.pizzaFivePb);
            this.newOrderPnl.Controls.Add(this.pizzaFourPb);
            this.newOrderPnl.Controls.Add(this.pizzaThreePb);
            this.newOrderPnl.Controls.Add(this.pizzaOnePb);
            this.newOrderPnl.Controls.Add(this.cancelBtn);
            this.newOrderPnl.Controls.Add(this.confirmBtn);
            this.newOrderPnl.Location = new System.Drawing.Point(178, 222);
            this.newOrderPnl.Name = "newOrderPnl";
            this.newOrderPnl.Size = new System.Drawing.Size(242, 193);
            this.newOrderPnl.TabIndex = 6;
            // 
            // ordersLb
            // 
            this.ordersLb.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersLb.FormattingEnabled = true;
            this.ordersLb.ItemHeight = 48;
            this.ordersLb.Location = new System.Drawing.Point(122, 9);
            this.ordersLb.Name = "ordersLb";
            this.ordersLb.Size = new System.Drawing.Size(120, 52);
            this.ordersLb.TabIndex = 16;
            // 
            // pizzaTwoPb
            // 
            this.pizzaTwoPb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaTwoPb.BackgroundImage = global::CashDeskIP.Properties.Resources.veggie;
            this.pizzaTwoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaTwoPb.Location = new System.Drawing.Point(119, 119);
            this.pizzaTwoPb.Name = "pizzaTwoPb";
            this.pizzaTwoPb.Size = new System.Drawing.Size(100, 50);
            this.pizzaTwoPb.TabIndex = 15;
            this.pizzaTwoPb.TabStop = false;
            this.pizzaTwoPb.Click += new System.EventHandler(this.pizzaTwoPb_Click);
            // 
            // pizzaEightPb
            // 
            this.pizzaEightPb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaEightPb.BackgroundImage = global::CashDeskIP.Properties.Resources.peperoni;
            this.pizzaEightPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaEightPb.Location = new System.Drawing.Point(111, 111);
            this.pizzaEightPb.Name = "pizzaEightPb";
            this.pizzaEightPb.Size = new System.Drawing.Size(100, 50);
            this.pizzaEightPb.TabIndex = 14;
            this.pizzaEightPb.TabStop = false;
            this.pizzaEightPb.Click += new System.EventHandler(this.pizzaEightPb_Click);
            // 
            // pizzaSevenPb
            // 
            this.pizzaSevenPb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaSevenPb.BackgroundImage = global::CashDeskIP.Properties.Resources.quattro_formaghi;
            this.pizzaSevenPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaSevenPb.Location = new System.Drawing.Point(103, 103);
            this.pizzaSevenPb.Name = "pizzaSevenPb";
            this.pizzaSevenPb.Size = new System.Drawing.Size(100, 50);
            this.pizzaSevenPb.TabIndex = 13;
            this.pizzaSevenPb.TabStop = false;
            this.pizzaSevenPb.Click += new System.EventHandler(this.pizzaSevenPb_Click);
            // 
            // pizzaSixPb
            // 
            this.pizzaSixPb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaSixPb.BackgroundImage = global::CashDeskIP.Properties.Resources.supreme;
            this.pizzaSixPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaSixPb.Location = new System.Drawing.Point(95, 95);
            this.pizzaSixPb.Name = "pizzaSixPb";
            this.pizzaSixPb.Size = new System.Drawing.Size(100, 50);
            this.pizzaSixPb.TabIndex = 12;
            this.pizzaSixPb.TabStop = false;
            this.pizzaSixPb.Click += new System.EventHandler(this.pizzaSixPb_Click);
            // 
            // pizzaFivePb
            // 
            this.pizzaFivePb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaFivePb.BackgroundImage = global::CashDeskIP.Properties.Resources.caprichosa;
            this.pizzaFivePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaFivePb.Location = new System.Drawing.Point(87, 87);
            this.pizzaFivePb.Name = "pizzaFivePb";
            this.pizzaFivePb.Size = new System.Drawing.Size(100, 50);
            this.pizzaFivePb.TabIndex = 11;
            this.pizzaFivePb.TabStop = false;
            this.pizzaFivePb.Click += new System.EventHandler(this.pizzaFivePb_Click);
            // 
            // pizzaFourPb
            // 
            this.pizzaFourPb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaFourPb.BackgroundImage = global::CashDeskIP.Properties.Resources.hawaii;
            this.pizzaFourPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaFourPb.Location = new System.Drawing.Point(79, 79);
            this.pizzaFourPb.Name = "pizzaFourPb";
            this.pizzaFourPb.Size = new System.Drawing.Size(100, 50);
            this.pizzaFourPb.TabIndex = 10;
            this.pizzaFourPb.TabStop = false;
            this.pizzaFourPb.Click += new System.EventHandler(this.pizzaFourPb_Click);
            // 
            // pizzaThreePb
            // 
            this.pizzaThreePb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaThreePb.BackgroundImage = global::CashDeskIP.Properties.Resources.margherita;
            this.pizzaThreePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaThreePb.Location = new System.Drawing.Point(71, 71);
            this.pizzaThreePb.Name = "pizzaThreePb";
            this.pizzaThreePb.Size = new System.Drawing.Size(100, 50);
            this.pizzaThreePb.TabIndex = 9;
            this.pizzaThreePb.TabStop = false;
            this.pizzaThreePb.Click += new System.EventHandler(this.pizzaThreePb_Click);
            // 
            // pizzaOnePb
            // 
            this.pizzaOnePb.BackColor = System.Drawing.Color.Transparent;
            this.pizzaOnePb.BackgroundImage = global::CashDeskIP.Properties.Resources.calzone;
            this.pizzaOnePb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizzaOnePb.Location = new System.Drawing.Point(28, 83);
            this.pizzaOnePb.Name = "pizzaOnePb";
            this.pizzaOnePb.Size = new System.Drawing.Size(100, 50);
            this.pizzaOnePb.TabIndex = 8;
            this.pizzaOnePb.TabStop = false;
            this.pizzaOnePb.Click += new System.EventHandler(this.pizzaOnePb_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelBtn.Location = new System.Drawing.Point(10, 26);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 39);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmBtn.Location = new System.Drawing.Point(91, 26);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 39);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // remarksRTb
            // 
            this.remarksRTb.Location = new System.Drawing.Point(57, 156);
            this.remarksRTb.Name = "remarksRTb";
            this.remarksRTb.Size = new System.Drawing.Size(100, 96);
            this.remarksRTb.TabIndex = 17;
            this.remarksRTb.Text = "";
            // 
            // remarksLbl
            // 
            this.remarksLbl.AutoSize = true;
            this.remarksLbl.BackColor = System.Drawing.Color.Transparent;
            this.remarksLbl.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remarksLbl.Location = new System.Drawing.Point(-206, 60);
            this.remarksLbl.Name = "remarksLbl";
            this.remarksLbl.Size = new System.Drawing.Size(188, 48);
            this.remarksLbl.TabIndex = 18;
            this.remarksLbl.Text = "Remarks:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(110, 55);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 27);
            this.nameTb.TabIndex = 19;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLbl.Location = new System.Drawing.Point(-206, 60);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(154, 48);
            this.nameLbl.TabIndex = 20;
            this.nameLbl.Text = "Name:*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CashDeskIP.Properties.Resources._75588239_574488233367148_6902869144618663936_n;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.newOrderPnl);
            this.Controls.Add(this.pendingOrdersPnl);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cash Desk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pendingOrdersPnl.ResumeLayout(false);
            this.pendingOrdersPnl.PerformLayout();
            this.newOrderPnl.ResumeLayout(false);
            this.newOrderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaTwoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaEightPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSevenPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSixPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaFivePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaFourPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaThreePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaOnePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Panel pendingOrdersPnl;
        private System.Windows.Forms.Button orderCompletedBtn;
        private System.Windows.Forms.Label pendingOrdersLbl;
        private System.Windows.Forms.ListBox pendingOrdersLb;
        private System.Windows.Forms.Panel newOrderPnl;
        private System.Windows.Forms.PictureBox pizzaTwoPb;
        private System.Windows.Forms.PictureBox pizzaEightPb;
        private System.Windows.Forms.PictureBox pizzaSevenPb;
        private System.Windows.Forms.PictureBox pizzaSixPb;
        private System.Windows.Forms.PictureBox pizzaFivePb;
        private System.Windows.Forms.PictureBox pizzaFourPb;
        private System.Windows.Forms.PictureBox pizzaThreePb;
        private System.Windows.Forms.PictureBox pizzaOnePb;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ListBox ordersLb;
        private System.Windows.Forms.RichTextBox remarksRTb;
        private System.Windows.Forms.Label remarksLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
    }
}

