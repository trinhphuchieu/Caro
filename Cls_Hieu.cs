using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Caro_TrinhPhucHieu
{
    class Cls_Hieu
    {
        
        public static Button[,] QL_OVuong = new Button[13, 13];
        public static Boolean count = true;
        public static string ketqua = "";
        public static Stack<string> noibat = new Stack<string>();
        public static int hieu = 5;

        
        
        
        public static string Check_XO()
        {
            
            if(count == true)
            {
                hieu += 1;
                count = false;
                return "X";
            }
            count = true;
            return "O";
        }
        // kiểm tra đường thẳng 
        public static bool Check_DuongThang(Button ovuong)
        {
            string[] vitri = ovuong.Tag.ToString().Split(' ');
            int cs1 = int.Parse(vitri[0]);
          
            int dem = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (dem == 5)
                {
                    for (int y = i; y <= 12; y++)
                    {
                        if (ovuong.Text == QL_OVuong[cs1, y].Text) noibat.Push(cs1.ToString() + " " + y.ToString());
                        else return true;
                    }
                    return true;
                }
                if (QL_OVuong[cs1, i].Text == ovuong.Text)
                {
                    noibat.Push(cs1.ToString() + " " + i.ToString());
                    dem += 1;
                }
                else
                {
                    while (dem > 0)
                    {
                        if(noibat.Count>0) noibat.Pop();
                        dem -= 1;
                    }
                    dem = 0;
                }


            }
            if (dem >= 5) return true;
            while (dem> 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem -= 1;
            }
           

            return false;
        }
        // Kiểm tra đường dọc
        public static bool Check_Doc(Button ovuong)
        {
            string[] vitri = ovuong.Tag.ToString().Split(' ');
            int cs2 = int.Parse(vitri[1]);
            int dem1 = 0;
            for (int i = 1; i <= 12; i++)
            {

                if (dem1 == 5)
                {
                    for (int y = i; y <= 12; y++)
                    {
                        if (ovuong.Text == QL_OVuong[y, cs2].Text) noibat.Push(y.ToString() + " " + cs2.ToString());
                        else return true;
                    }
                    return true;
                }
                if (ovuong.Text == QL_OVuong[i, cs2].Text)
                {
                    dem1 += 1;
                    noibat.Push(i.ToString() +" "+ cs2.ToString());
                }
                else
                {
                    while (dem1 > 0)
                    {
                        if (noibat.Count > 0) noibat.Pop();
                        dem1 -= 1;
                    }
                    dem1 = 0;
                }

            }
            if (dem1 >= 5) return true;
            while (dem1 > 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem1 -= 1;
            }
            return false;
        }
        // kiểm tra chéo chính
        public static bool Check_CheoChinh(Button ovuong)
        {
            string[] vitri = ovuong.Tag.ToString().Split(' ');
            int cs1 = int.Parse(vitri[0]);
            int cs2 = int.Parse(vitri[1]);

            int so = cs1 - (cs2 - 1);
            int so1 = cs2 - (cs1 - 1);
            if (cs1 > cs2)
            {
                return Check_CotChinhduoi(ovuong, so);
            }
            else
            {
                return Check_CotChinhTren(ovuong, so1);
            }
            

        }
        // kiểm tra chéo chính cột dưới
        public static bool Check_CotChinhduoi(Button ovuong, int so)
        {
            int dem1 = 0;
            if (so >= 9) return false;
            for (int i = 1; i <= 12; i++)
            {
                if (so > 12) break;
                if (dem1 == 5)
                {
                    for (int y = i; y <= 12; y++)
                    {
                        if (so > 12) break;
                        if (ovuong.Text == QL_OVuong[so, y].Text)
                        {
                            noibat.Push(so.ToString() + " " + y.ToString());
                            so += 1;
                        }
                        else return true;
                    }
                    return true;
                }

                if (ovuong.Text == QL_OVuong[so, i].Text)
                {
                    dem1 += 1;
                    noibat.Push(so.ToString() + " " + i.ToString());
                }
                else
                {
                    while (dem1 > 0)
                    {
                        if (noibat.Count > 0) noibat.Pop();
                        dem1 -= 1;
                    }
                    
                    dem1 = 0;
                }
                so += 1;

            }
            if (dem1 >= 5) return true;
            while (dem1 > 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem1 -= 1;
            }
            return false;
        }
        // kiểm tra chéo chính cột trên
        public static bool Check_CotChinhTren(Button ovuong, int so1)
        {
            if (so1 >= 9) return false;
            int dem1 = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (so1 > 12) break;
                if (dem1 == 5)
                {
                    for (int y = i; y <= 12; y++) { 

                        if (so1 > 12) break;
                    if (ovuong.Text == QL_OVuong[y, so1].Text)
                        {

                            noibat.Push(y.ToString() + " " + so1.ToString());
                            so1 += 1;
                        }else return true;
                    }
                    return true;
                }
                   
                    
          

                if (ovuong.Text == QL_OVuong[i, so1].Text)
                {
                    dem1 += 1;
                    noibat.Push(i.ToString() +" "+ so1.ToString());
                }
                else
                {
                    while (dem1 > 0)
                    {
                        if (noibat.Count > 0) noibat.Pop();
                        dem1 -= 1;
                    }
                    dem1 = 0;
                   
                }
                so1 += 1;

            }
            if (dem1 >= 5) return true;
            while (dem1 > 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem1 -= 1;
            }
            return false;
        }
        // kiểm tra chéo phụ
        public static bool Check_CheoPhu(Button ovuong)
        {
            string[] vitri = ovuong.Tag.ToString().Split(' ');
            // công thức 
            // vị trí [5,10] so = 14 so1 = 3 như vậy thì nằm ở vị trí chéo phụ dưới 
            int cs1 = int.Parse(vitri[0]);
            int cs2 = int.Parse(vitri[1]);

            int so = cs2 + (cs1 - 1); // lấy vị trí chéo trên
            int so1 = cs1 - (12- cs2);
            
            if (so<13)
            {
                return Check_CotPhuTren(ovuong,so);
            }
            else
            {
                return Check_CotPhuDuoi(ovuong,so1);
            }

        }
        // kiểm tra cột dưới chéo phụ
        public static bool Check_CotPhuDuoi(Button ovuong, int so1)
        {
            
            int dem1 = 0;
            for (int i = 12; i >= 1; i--)
            {
                if (so1 > 12) break;
                if (dem1 == 5)
                {
                    for (int y = i; y >=1 ; y--)
                    {
                        if (so1 > 12) break;
                        if (ovuong.Text == QL_OVuong[so1, y].Text)
                        {
                            noibat.Push(so1.ToString() + " " + y.ToString());
                            so1 += 1;
                        }
                        else return true;
                    }
                    return true;
                }
                
                if (ovuong.Text == QL_OVuong[so1,i].Text)
                {
                    dem1 += 1;
                    noibat.Push(so1.ToString() + " " + i.ToString());
                }
                else
                {
                    while (dem1 > 0)
                    {
                        if (noibat.Count > 0) noibat.Pop();
                        dem1 -= 1;
                    }
              
                    dem1 = 0;
                }
                so1 += 1;

            }
            if (dem1 >= 5) return true;
            while (dem1 > 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem1 -= 1;
            }
            return false;
        }
        // kiểm tra cột trên chéo phụ
        public static bool Check_CotPhuTren(Button ovuong, int so)
        {
            if (so <= 4) return false;
            int dem1 = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (so == 0) break;
                if (dem1 == 5)
                {
                    for (int y = i; y <= 12; y++)
                    {
                        if (so == 0) break;
                        if (ovuong.Text == QL_OVuong[y, so].Text)
                        {
                            noibat.Push(y.ToString() + " " + so.ToString());
                            so -= 1;
                        }
                        else return true;
                    }
                    return true;
                }
                
                if (ovuong.Text == QL_OVuong[i, so].Text)
                {
                    dem1 += 1;
                    noibat.Push(i.ToString() +" "+ so.ToString());
                }
                else
                {
                    while (dem1 > 0)
                    {
                        if (noibat.Count > 0) noibat.Pop();
                        dem1 -= 1;
                    }
                  
                    dem1 = 0;
                }
                so -= 1;

            }
            if (dem1 >= 5) return true;
            while (dem1 > 0)
            {
                if (noibat.Count > 0) noibat.Pop();
                dem1 -= 1;
            }
            return false;
        }
        // hiển thị nổi bật
        public static void HienThi_NoiBat(Button b)
        {
            noibat.Clear();
            Cls_Hieu.Check_DuongThang(b);
            Cls_Hieu.Check_CheoChinh(b);
            Cls_Hieu.Check_Doc(b);
            Cls_Hieu.Check_CheoPhu(b);
            
            while (noibat.Count > 0)
            {
                string[] s = noibat.Pop().Split(' ');
                if (b.Text == "X") { 
                QL_OVuong[int.Parse(s[0]), int.Parse(s[1])].BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    QL_OVuong[int.Parse(s[0]), int.Parse(s[1])].BackColor = System.Drawing.Color.Blue;
                }
            }
        }
    }
    }
