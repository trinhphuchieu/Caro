using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_TrinhPhucHieu
{
    public partial class Form1 : Form
    {
        
        public int soLanUndoX = 0;
        public int soLanUndoO = 0;
        public int phutWin = 0;
        public int giayWin = 0;
        public int quaylui_X = 0;
        public int quaylui_O = 0;
        public int timer_X = 30;
        public int timer_O = 30;
        public Stack<string> quayluiX = new Stack<string>(); // 2 ngăn xếp
        public Stack<string> quayluiO = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void banco_Caro()
        {

            for (int i = 1; i <= 12; i++)
            {
                for (int y = 1; y <= 12; y++)
                {
                    Cls_Hieu.QL_OVuong[i, y] = new Button()
                    {
                        Width = 56,
                        Height = 56,
                        BackColor = Color.LightCyan,
                        Font = new Font("Microsoft Sans Serif", 28.2F),

                    };
                    //Cls_Hieu.QL_OVuong[i, y].Font = new Font("French Script MT", 10000);
                    Cls_Hieu.QL_OVuong[i, y].TabStop = false;
                    Cls_Hieu.QL_OVuong[i, y].Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    
                    BanCoCaro.Controls.Add(Cls_Hieu.QL_OVuong[i, y]);
                    Cls_Hieu.QL_OVuong[i, y].Click += OVuong_Click; // ép sự kiện cho nút button 
                    Cls_Hieu.QL_OVuong[i, y].Tag = i + " " + y; // lưu vị trí hiện tại
                    Cls_Hieu.QL_OVuong[i, y].Text = " "; // ô vuông cho " "

                }
            }
        }
        public void demUndo()
        {
            int countX = 0;
            int countO = 0;
            for(int i = 1; i<=12; i++)
            {
                for(int y = 1;y<=12;y++)
                {
                    if(Cls_Hieu.QL_OVuong[i,y].Text == "X")
                    {
                        countX += 1;
                    }
                    else if(Cls_Hieu.QL_OVuong[i, y].Text == "O") 
                    {
                        countO += 1;
                    }
                }
            }
            if (countX > countO)
            {
                Cls_Hieu.count = false;
                

            }
            else
            {
            
                Cls_Hieu.count = true;
            }
        }
        
        // sự kiện click váo nút 
        private void OVuong_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Text != " ")
            {
                return;
            }


            b.Text = Cls_Hieu.Check_XO();

            
            timer_O = 30;
            timer_X = 30;
            
            if (quaylui_X > 0)
            {
                
                b.Text = "X";
                quaylui_X -= 1;         
                undoX.Enabled = true;
                demUndo();
                
                
            }
            else if (quaylui_O > 0)
            {
                b.Text = "O";
                quaylui_O -= 1;
                 undo0.Enabled = true;
                demUndo();
                
            }
            else
            {
                undoX.Enabled = true;
                undo0.Enabled = true;
            }
            
            if (b.Text == "X")
            {
                
                quayluiX.Push(b.Tag.ToString());
                b.ForeColor = Color.Red;
                timerO.Start();
                timerX.Stop();
                thoigianX.Text = "00:00";
                if (Cls_Hieu.count == true)
                {
                    timerX.Start();
                    timerO.Stop();
                    thoigianO.Text = "00:00";
                }
            }
            else if (b.Text == "O")
            {
               
                quayluiO.Push(b.Tag.ToString());
                b.ForeColor = Color.Blue;
                timerX.Start();
                timerO.Stop();
                thoigianO.Text = "00:00";
                if(Cls_Hieu.count == false)
                {
                    timerX.Stop();
                    timerO.Start();
                    thoigianX.Text = "00:00";
                }
            }
            

            // Kiểm tra thắng thua 
            
            if (Cls_Hieu.Check_DuongThang(b) || Cls_Hieu.Check_CheoChinh(b) || Cls_Hieu.Check_Doc(b) || Cls_Hieu.Check_CheoPhu(b))
            {
                
                NguoiChoi.tran += 1;
                timerO.Stop();
                timerX.Stop();
                thoiGianThang.Stop();
                undo0.Enabled = false;
                undoX.Enabled = false;
                if (Cls_Hieu.count==false)
                {
                    
                    NguoiChoi.win_X+=1;
                    
                    Cls_Hieu.HienThi_NoiBat(b);
                    thoigianX.Text = "Thắng: " + NguoiChoi.phutWinX.ToString() + " m " + NguoiChoi.giayWinX.ToString() + " s";
                    thoigianO.Text = "Thua: " + NguoiChoi.phutWinO.ToString() + " m " + NguoiChoi.giayWinO.ToString() + " s";
                    MessageBox.Show("Bạn X đã chiến thắng."+"\n Thời gian kết thúc: " + (NguoiChoi.phutWinO+NguoiChoi.phutWinX)+" : "+(NguoiChoi.giayWinO+NguoiChoi.giayWinX),"Chúc Mừng");
                    
                }
                else
                {
                  
                    NguoiChoi.win_O += 1;
                    thoigianO.Text = "Thắng: " + NguoiChoi.phutWinO.ToString() + " m " + NguoiChoi.giayWinO.ToString() + " s";
                    thoigianX.Text = "Thua: " + NguoiChoi.phutWinX.ToString() + " m " + NguoiChoi.giayWinX.ToString() + " s";
                    Cls_Hieu.HienThi_NoiBat(b);
                    MessageBox.Show("Bạn O đã chiến thắng." + "\n Thời gian kết thúc: " + (NguoiChoi.phutWinO + NguoiChoi.phutWinX) + " : " + (NguoiChoi.giayWinO + NguoiChoi.giayWinX), "Chúc Mừng");
                    
                }
                int count = 0; 
                for(int i = 1; i<= 12; i++)
                {
                    for(int y = 1; y <= 12; y++)
                    {
                        if (Cls_Hieu.QL_OVuong[i,y].Text != " ") count += 1;
                    }
                }
                if(count == 144)
                {
                    thoiGianThang.Stop();
                    NguoiChoi.tran += 1;
                    thoigianO.Text = phutWin.ToString() + "m " + giayWin.ToString() + " s";
                    thoigianX.Text = phutWin.ToString() + "m " + giayWin.ToString() + " s";
                    MessageBox.Show("Trận đấu ngang tài ngang sức !!", "Hòa");
                    BanCoCaro.Enabled = false;
                }
                
                
                
                undoX.Text = "Số Lần Lui : " + soLanUndoX.ToString();
                undo0.Text = "Số Lần Lui : " + soLanUndoO.ToString();
                winO.Text = "Win "+NguoiChoi.win_O.ToString() + " / " + NguoiChoi.tran+" Ván";
                winX.Text = "Win " + NguoiChoi.win_X.ToString() + " / " + NguoiChoi.tran + " Ván";
                BanCoCaro.Enabled = false;
            
            }
            


        }


        private void batdau_Click(object sender, EventArgs e)
        {
            
            NguoiChoi.giayWinX = 0;
            NguoiChoi.giayWinO = 0;
            NguoiChoi.phutWinX = 0;
            NguoiChoi.phutWinO = 0;
            timer_X = 30;
            timer_O = 30;
            phutWin = 0;
            giayWin = 0;
            Cls_Hieu.count = true;
            thoigianO.Text = "00:00";
            thoigianX.Text = "00:00";
            undoX.Text = "Lui Lại";
            undo0.Text = "Lui Lại";
            BanCoCaro.Enabled = true;
            BanCoCaro.Controls.Clear();
            undoX.Enabled = false;
            undo0.Enabled = false;
            soLanUndoO = 0;
            soLanUndoX = 0;
            quayluiO.Clear();
            quayluiX.Clear();
            banco_Caro();
            timerX.Start();
            thoiGianThang.Start();
            
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            undoX.Enabled = false;
            undo0.Enabled = false;
            Cls_Hieu.count = true;
            NguoiChoi.giayWinX = 0;
            NguoiChoi.giayWinO = 0;
            NguoiChoi.phutWinX = 0;
            NguoiChoi.phutWinO = 0;
            NguoiChoi.win_O = 0;
            NguoiChoi.win_X = 0;
            winX.Text = "Win 0 / 0 Ván";
            winO.Text = "Win 0 / 0 Ván";
            
            BanCoCaro.Enabled = true;
            BanCoCaro.Controls.Clear();
            banco_Caro();
            soLanUndoO = 0;
            soLanUndoX = 0;
            quayluiO.Clear();
            quayluiX.Clear();
            quaylui_O = 0;
            quaylui_X = 0;
            Cls_Hieu.count = true;
            timerX.Stop();
            timerO.Stop();
            thoigianO.Text = "00:00";
            thoigianX.Text = "00:00";
            undoX.Text = "Lui Lại";
            undo0.Text = "Lui Lại";

        }

        private void undoX_Click(object sender, EventArgs e)
        {
            timerO.Stop();
            timerX.Start();
            if (quayluiX.Count > 0)
            {
                string[] choi = quayluiX.Peek().Split(' ');
                Cls_Hieu.QL_OVuong[int.Parse(choi[0]), int.Parse(choi[1])].Enabled = true;
                Cls_Hieu.QL_OVuong[int.Parse(choi[0]), int.Parse(choi[1])].Text = " ";
                quayluiX.Pop();
                quaylui_X += 1;
                soLanUndoX += 1;
              
            }
            
            if (quayluiX.Count <= 0 || quaylui_X == 1)
            {
                //Cls_Hieu.count = true;
                undoX.Enabled = false;
            }


            timerO.Stop();
            thoigianO.Text = "00:00";

        }

        private void undo0_Click(object sender, EventArgs e)
        {
            timerX.Stop();
            timerO.Start();
            if (quayluiO.Count > 0)
            {
                string[] choi = quayluiO.Peek().Split(' ');
                Cls_Hieu.QL_OVuong[int.Parse(choi[0]), int.Parse(choi[1])].Enabled = true;
                Cls_Hieu.QL_OVuong[int.Parse(choi[0]), int.Parse(choi[1])].Text = " ";
                quayluiO.Pop();
                quaylui_O += 1;
                soLanUndoO += 1;
                
            }
            if(quayluiO.Count <= 0|| quaylui_O == 1)
            {
                //Cls_Hieu.count = false;
                undo0.Enabled = false;
            }

            
            timerX.Stop();
            thoigianX.Text = "00:00";


        }

        private void Win0_Click(object sender, EventArgs e)
        {

        }

        

        private void timerX_Tick(object sender, EventArgs e)
        {
            
            if(NguoiChoi.giayWinX == 60)
            {
                NguoiChoi.phutWinX += 1;
                NguoiChoi.giayWinX = 0;
            }
            
            

            if (timer_X > 0)
            {
                
                timer_X = timer_X - 1;
               
                thoigianX.Text = timer_X.ToString() +" Giây";
                NguoiChoi.giayWinX += 1;
            }
            
            else
            {
                undo0.Enabled = false;
                undoX.Enabled = false;
                timerX.Stop();           
                MessageBox.Show("Chúc mừng Bạn O Chiến Thắng ", "Hết giờ!");
                thoigianO.Text = "Thắng: " + NguoiChoi.phutWinO.ToString() + " m " + NguoiChoi.giayWinO.ToString() + " s";
                thoigianX.Text = "Thua: " + NguoiChoi.phutWinX.ToString() + " m " + NguoiChoi.giayWinX.ToString() + " s";
                undoX.Text = "Số Lần Lui : " + soLanUndoX.ToString();
                undo0.Text = "Số Lần Lui : " + soLanUndoO.ToString();
                NguoiChoi.win_O += 1;
                NguoiChoi.tran += 1;
                winO.Text = "Win " + NguoiChoi.win_O.ToString() + " / " + NguoiChoi.tran + " Ván";
                winX.Text = "Win " + NguoiChoi.win_X.ToString() + " / " + NguoiChoi.tran + " Ván";
                BanCoCaro.Enabled = false;
                

            }
        }

        private void timerO_Tick(object sender, EventArgs e)
        {
            if (NguoiChoi.giayWinO == 60)
            {
                NguoiChoi.phutWinO += 1;
                NguoiChoi.giayWinO = 0;
            }

            
            if (timer_O > 0)
            {
                
                timer_O = timer_O - 1;
                thoigianO.Text = timer_O.ToString() + " Giây";

                NguoiChoi.giayWinO += 1;
            }
            else
            {
                undo0.Enabled = false;
                undoX.Enabled = false;
                timerO.Stop();
                NguoiChoi.win_X += 1;
                NguoiChoi.tran += 1;
                winX.Text = "Win " + NguoiChoi.win_X.ToString() + " / "+ NguoiChoi.tran + " Ván";
                winO.Text = "Win " + NguoiChoi.win_O.ToString() + " / " + NguoiChoi.tran+" Ván";
                undoX.Text = "Số Lần Lui : " + soLanUndoX.ToString();
                undo0.Text = "Số Lần Lui : " + soLanUndoO.ToString();
                thoigianX.Text = "Thắng: " + NguoiChoi.phutWinX.ToString() + " m " + NguoiChoi.giayWinX.ToString() + " s";
                thoigianO.Text = "Thua: " + NguoiChoi.phutWinO.ToString() + " m " + NguoiChoi.giayWinO.ToString() + " s";
                MessageBox.Show("Chúc mừng Bạn X Chiến Thắng ", "Hết giờ");
                
                BanCoCaro.Enabled = false;
            }
        }

        private void thoiGianThang_Tick(object sender, EventArgs e)
        {
            if(giayWin == 60)
            {
                giayWin = 0;
                phutWin += 1;
            }
            else
            {
                giayWin += 1;
            }
        }

        private void thoigianX_Click(object sender, EventArgs e)
        {

        }
    }
}
