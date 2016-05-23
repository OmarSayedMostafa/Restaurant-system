using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_rest
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand cmdd;
        SqlDataReader drr;
        int index;
        ListViewItem l;
        String names_temp;
        String str;
        int year = 2015;
        int days = 1;
        double temp;
        ListViewItem item;
        double total=0;
        //********************************44

        
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            load_date();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("تأكد من ادخال بيانات كاملة");
            }
            else
            {
                try
                {
                    temp = double.Parse(textBox2.Text.ToString());
                    temp *= double.Parse(textBox3.Text.ToString());

                    cn.Open();
                    cmd = new SqlCommand("insert into storage (name,quan,ppu,tp)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + temp.ToString() + "')", cn);
                    cmd.ExecuteNonQuery();
                    // listView1.Items.Clear();
                    // cn.Open();
                    //  cmd = new SqlCommand("select * from storage", cn);
                    //  dr = cmd.ExecuteReader();
                    //  while (dr.Read())
                    //  {
                    /*  l = new ListViewItem(dr["name"].ToString());
                      // l.SubItems.Add();
                      l.SubItems.Add(dr["quan"].ToString());
                      l.SubItems.Add(dr["ppu"].ToString());
                      l.SubItems.Add(dr["tp"].ToString());
                      listView1.Items.Add(l);
                  */
                    // }
                    //  dr.Close();
                    // cn.Close();
                    //***********************************

                    l = new ListViewItem(textBox1.Text);
                    // l.SubItems.Add();
                    l.SubItems.Add(textBox2.Text);
                    l.SubItems.Add(textBox3.Text);

                    l.SubItems.Add(temp.ToString());
                    listView1.Items.Add(l);
                    //*******************************

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    //*********************************
                    cn.Close();
                }
                catch
                {
                    MessageBox.Show("تأكد من ادخال بيانات صحيحة");
                }
            }
           
       
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("select * from storage", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
               // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                l.SubItems.Add(dr["tp"].ToString());
                listView1.Items.Add(l);

            }
            dr.Close();
           // cn.Close();


            cmd = new SqlCommand("select * from kit", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
              //  l.SubItems.Add(dr["tp"].ToString());
                listView2.Items.Add(l);

            }
            dr.Close();
            cn.Close();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*cn.Open();
            cmd = new SqlCommand("delete from storage where name = '" + textBox5.Text + "'", cn);
            cmd.ExecuteNonQuery();
            listView1.Items.Clear();
            cmd = new SqlCommand("select * from storage", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                l.SubItems.Add(dr["tp"].ToString());
                listView1.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
         //   cn.Close();
            cn.Close();
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
          /*  listView1.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("update storage set ppu='" + new_p.Text + "' where name = '" + textBox6.Text + "'", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from storage", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                l.SubItems.Add(dr["tp"].ToString());
                listView1.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
            cn.Close();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(prod_kit_name.Text=="")
            {
                MessageBox.Show("تأكد من ادخال البيانات كاملة");
                groupBox2.Hide();
                textBox9.Clear();

            }
            else
            {
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                //***********************************************
                cn.Open();
                cmd = new SqlCommand("select * from storage where name = '" + prod_kit_name.Text + "'", cn);
                // dr = cmd.ExecuteReader();
                //  dr.Read();
                if (float.Parse(listView1.Items[index].SubItems[1].Text) < float.Parse(textBox9.Text))
                {
                    MessageBox.Show("تأكد من نقل كمية متاحة فى المخزن");
                    // dr.Close();
                    cn.Close();
                }
                else
                {
                    

                    str = (float.Parse(listView1.Items[index].SubItems[1].Text) - float.Parse(textBox9.Text)).ToString();
                    temp = double.Parse(str) * (double.Parse(listView1.Items[index].SubItems[2].Text));
                    // dr.Close();
                    cmd = new SqlCommand("update storage set quan='" + str + "',tp='"+temp+"' where name = '" + prod_kit_name.Text + "'", cn);
                    cmd.ExecuteNonQuery();
                    //*******************************

                    listView1.Items[index].SubItems[1].Text = str;
                    listView1.Items[index].SubItems[3].Text = temp.ToString();


                    /*    cmd = new SqlCommand("select * from storage", cn);
                        dr = cmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem l = new ListViewItem(dr["name"].ToString());
                            // l.SubItems.Add();
                            l.SubItems.Add(dr["quan"].ToString());
                            l.SubItems.Add(dr["ppu"].ToString());
                            l.SubItems.Add(dr["tp"].ToString());
                            listView1.Items.Add(l);

                        }
                        dr.Close();*/

                    cn.Close();
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("select * from kit where name = '" + prod_kit_name.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        string x = (float.Parse(dr["quan"].ToString()) + float.Parse(textBox9.Text)).ToString();
                        dr.Close();
                        cmd = new SqlCommand("update kit set quan='" + x + "' where name ='" + prod_kit_name.Text + "' ", cn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("select * from kit", cn);
                        dr = cmd.ExecuteReader();
                        listView2.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem ll = new ListViewItem(dr["name"].ToString());
                            // l.SubItems.Add();
                            ll.SubItems.Add(dr["quan"].ToString());
                            ll.SubItems.Add(dr["ppu"].ToString());
                            //l.SubItems.Add(dr["tp"].ToString());
                            listView2.Items.Add(ll);

                        }
                        dr.Close();
                        //cn.Close();
                        //cmd = new SqlCommand("select * from kit", cn);
                        //dr = cmd.ExecuteReader();
                        //while(dr.Read())
                        //{
                        //    ListViewItem l = new ListViewItem(dr["name"].ToString());
                        //    l.SubItems.Add()
                        //}

                    }
                        
                    catch
                    {
                        //cn.Open();
                        dr.Close();
                        //cn.Close();
                        // cn.Open();
                        cmdd = new SqlCommand("select * from storage where name = '" + prod_kit_name.Text + "'", cn);
                        drr = cmdd.ExecuteReader();
                        drr.Read();
                        string ppu = drr["ppu"].ToString();
                        drr.Close();
                        cmdd = new SqlCommand("insert into kit (name,quan,ppu)values ('" + prod_kit_name.Text + "','" + textBox9.Text + "','" + ppu + "')", cn);
                        cmdd.ExecuteNonQuery();
                        cmd = new SqlCommand("select * from kit", cn);
                        dr = cmd.ExecuteReader();
                        listView2.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem ll = new ListViewItem(dr["name"].ToString());
                            // l.SubItems.Add();
                            ll.SubItems.Add(dr["quan"].ToString());
                            ll.SubItems.Add(dr["ppu"].ToString());
                            //l.SubItems.Add(dr["tp"].ToString());
                            listView2.Items.Add(ll);

                        }
                        //drr.Close();
                        //cn.Close();
                    }
                    dr.Close();
                    //  drr.Close();
                    // cmd=new SqlCommand("update storage set quan = ")
                    cn.Close();
                }
                groupBox2.Hide();
                textBox9.Clear();
            }
            
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
          /*  listView2.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("update kit set quan='" + textBox11.Text + "' where name = '" + textBox10.Text + "'", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from kit", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                //l.SubItems.Add(dr["tp"].ToString());
                listView2.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
            cn.Close();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            listView2.Items.Clear();
            cmd = new SqlCommand("select * from kit", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
             //   l.SubItems.Add(dr["tp"].ToString());
                listView2.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
            //   cn.Close();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //cn.Open();
            //cmd = new SqlCommand("select * from kit where name = '" + textBox13.Text + "'", cn);
            //dr = cmd.ExecuteReader();
            //dr.Read();
            //if (float.Parse(dr["quan"].ToString()) < float.Parse(textBox9.Text))
            //{
            //    MessageBox.Show("احا الشبب ضاع احا ده كان بصباع ");
            //    dr.Close();
            //    cn.Close();
            //}
            //else
            //{

            //    string temp = (float.Parse(dr["quan"].ToString()) - float.Parse(textBox14.Text)).ToString();
            //    dr.Close();
            //    cmd = new SqlCommand("update kit set quan='" + temp + "' where name = '" + textBox13.Text + "'", cn);
            //    cmd.ExecuteNonQuery();
            //    cmd = new SqlCommand("select * from kit", cn);
            //    dr = cmd.ExecuteReader();
            //    listView2.Items.Clear();
            //    while (dr.Read())
            //    {
            //        ListViewItem l = new ListViewItem(dr["name"].ToString());
            //        // l.SubItems.Add();
            //        l.SubItems.Add(dr["quan"].ToString());
            //        l.SubItems.Add(dr["ppu"].ToString());
            //       // l.SubItems.Add(dr["tp"].ToString());
            //        listView2.Items.Add(l);

            //    }
            //    dr.Close();
            //    //cn.Close();
            //    try
            //    {
            //        cmd = new SqlCommand("select * from storage where name = '" + textBox13.Text + "'", cn);
            //        dr = cmd.ExecuteReader();
            //        dr.Read();
            //        string x = (float.Parse(dr["quan"].ToString()) + float.Parse(textBox14.Text)).ToString();
            //        dr.Close();
            //        cmd = new SqlCommand("update storage set quan='" + x + "' where name ='" + textBox13.Text + "' ", cn);
            //        cmd.ExecuteNonQuery();
            //        cmd = new SqlCommand("select * from storage", cn);
            //        dr = cmd.ExecuteReader();
            //        listView1.Items.Clear();
            //        while (dr.Read())
            //        {
            //            ListViewItem ll = new ListViewItem(dr["name"].ToString());
            //            // l.SubItems.Add();
            //            ll.SubItems.Add(dr["quan"].ToString());
            //            ll.SubItems.Add(dr["ppu"].ToString());
            //            ll.SubItems.Add(dr["tp"].ToString());
            //            listView1.Items.Add(ll);

            //        }
            //        dr.Close();
            //        //cmd = new SqlCommand("select * from kit", cn);
            //        //dr = cmd.ExecuteReader();
            //        //while(dr.Read())
            //        //{
            //        //    ListViewItem l = new ListViewItem(dr["name"].ToString());
            //        //    l.SubItems.Add()
            //        //}

            //    }
            //    catch
            //    {
            //        dr.Close();
            //        //cn.Close();
            //        // cn.Open();
            //        cmdd = new SqlCommand("select * from storage where name = '" + textBox8.Text + "'", cn);
            //        drr = cmdd.ExecuteReader();
            //        drr.Read();
            //        string ppu = drr["ppu"].ToString();
            //        drr.Close();
            //        cmdd = new SqlCommand("insert into kit (name,quan,ppu)values ('" + textBox8.Text + "','" + textBox9.Text + "','" + ppu + "')", cn);
            //        cmdd.ExecuteNonQuery();
            //        cmd = new SqlCommand("select * from kit", cn);
            //        dr = cmd.ExecuteReader();
            //        listView2.Items.Clear();
            //        while (dr.Read())
            //        {
            //            ListViewItem ll = new ListViewItem(dr["name"].ToString());
            //            // l.SubItems.Add();
            //            ll.SubItems.Add(dr["quan"].ToString());
            //            ll.SubItems.Add(dr["ppu"].ToString());
            //            //l.SubItems.Add(dr["tp"].ToString());
            //            listView2.Items.Add(ll);

            //        }
            //        //drr.Close();
            //        //cn.Close();
            //    }
            //    dr.Close();
            //    //  drr.Close();
            //    // cmd=new SqlCommand("update storage set quan = ")
            //    cn.Close();
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {/*
            listView1.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("update storage set quan='" + new_q.Text + "' where name = '" + textBox6.Text + "'", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from storage", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                l.SubItems.Add(dr["tp"].ToString());
                listView1.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
            cn.Close();*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
           /* listView1.Items.Clear();
            cn.Open();
            cmd = new SqlCommand("update storage set tp='" + textBox14.Text + "' where name = '" + textBox6.Text + "'", cn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select * from storage", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem l = new ListViewItem(dr["name"].ToString());
                // l.SubItems.Add();
                l.SubItems.Add(dr["quan"].ToString());
                l.SubItems.Add(dr["ppu"].ToString());
                l.SubItems.Add(dr["tp"].ToString());
                listView1.Items.Add(l);

            }
            dr.Close();
            // cn.Close();
            cn.Close();*/
        }

        private void مسحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);

                cn.Open();
                cmd = new SqlCommand("delete from storage where name = '" + listView1.Items[index].SubItems[0].Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                
                listView1.Items.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("تأكد من اختيار صنف من القائمة");
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            textBox9.Clear();

            //*********************************
            index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            names_temp = listView1.Items[index].SubItems[0].Text;
            product_name.Text = names_temp;
            groupBox1.Show();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(new_p.Text=="" || new_q.Text=="")
            {
                MessageBox.Show("تأكد من ادخال جميع البيانات");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد اجراء تعديل الأن", "اجراء تعديل جديد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                    names_temp = listView1.Items[index].SubItems[0].Text;


                    temp = double.Parse(new_p.Text.ToString());
                    temp *= double.Parse(new_q.Text.ToString());
                    cn.Open();
                    cmd = new SqlCommand("Update storage set ppu='" + new_p.Text + "' , quan= '" + new_q.Text + "' , tp= '" + temp.ToString() + "' where name='" + names_temp + "'", cn);
                    cmd.ExecuteNonQuery();
                    //*********************************
                    listView1.Items.Clear();
                    cmd = new SqlCommand("select * from storage", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        l = new ListViewItem(dr["name"].ToString());
                        // l.SubItems.Add();
                        l.SubItems.Add(dr["quan"].ToString());
                        l.SubItems.Add(dr["ppu"].ToString());
                        l.SubItems.Add(dr["tp"].ToString());
                        listView1.Items.Add(l);

                    }
                    dr.Close();
                    cn.Close();
                    groupBox1.Hide();
                    new_p.Clear();
                    new_q.Clear();
                    product_name.Text = "";
                }
                else
                {
                    groupBox1.Hide();
                    new_p.Clear();
                    new_q.Clear();
                    product_name.Text = "";
                }
            }
            
        }

        private void new_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ارسالالىالمطبخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            new_p.Clear();
            new_q.Clear();
            product_name.Text = "";
            //*********************************
            index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            names_temp = listView1.Items[index].SubItems[0].Text;
            prod_kit_name.Text = names_temp;
            groupBox2.Show();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            new_p.Clear();
            new_q.Clear();
            product_name.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Hide();
            textBox9.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void end_year_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void load_date()
        {
            year_comboBox2.Items.Add(year.ToString());
            end_year_comboBox1.Items.Add(year.ToString());
            for (int i = 0; i < 10; i++)
            {
                year_comboBox2.Items.Add((++year).ToString());
                end_year_comboBox1.Items.Add((year).ToString());
            }
            //////////***********************//////////////////
           
            /////////////*********************/////////////////
            day_comboBox1.Items.Add(days.ToString());
            for (int i = 0; i < 30; i++)
            {
                end_day_comboBox3.Items.Add((days++).ToString());
                day_comboBox1.Items.Add(days.ToString());
            }

            end_day_comboBox3.Items.Add((days).ToString());
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            total = 0;
            listView3.Items.Clear();
            try
            {
                String substr1;
                String substr2;
                //********************************
                substr1 = day_comboBox1.Text + "-" + mon_comboBox1.Text + "-" + year_comboBox2.Text.Substring(2);

                //*********************************

                substr2 = end_day_comboBox3.Text + "-" + end_mon_comboBox2.Text + "-" + end_year_comboBox1.Text.Substring(2);
                //****============================================================////*****************===========

                cmd = new SqlCommand("select * from fawateer1 where datatime between'" + substr1 + "' and '" + substr2 + "'", cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        item = new ListViewItem(dr["tprice"].ToString());
                        item.SubItems.Add(dr["quantity"].ToString());
                        item.SubItems.Add(dr["price"].ToString());
                        item.SubItems.Add(dr["name"].ToString());
                        item.SubItems.Add(dr["datatime"].ToString());
                        listView3.Items.Add(item);

                        ///////////////////////////////////////////////////

                        temp = double.Parse(dr["tprice"].ToString());
                        total += temp;
                    }
                    total_gain.Text = total.ToString();
                   
                    cn.Close();
                    total = 0;
                }
              
            
            catch
            {
                MessageBox.Show("تأكد من ادخال البيانات كاملة");
            }
  

        }

        private void total_storage_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("select * from storage", cn);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                //************************
                while(dr.Read())
                {
                    temp = double.Parse(dr["tp"].ToString());
                    total += temp;
                }
                t_storage.Text = total.ToString();
                total = 0;
                //***************************
                dr.Close();
                cn.Close();
                
            }
            catch
            {
                MessageBox.Show("تأكد من ادخال بيانات صحيحة");
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                index = listView2.Items.IndexOf(listView2.SelectedItems[0]);
                names_temp = listView2.Items[index].SubItems[0].Text;
                listView2.Items.RemoveAt(index);
                //**************

                cn.Open();
                cmd = new SqlCommand("delete from kit where name = '" + names_temp + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            
            //********************************************************
            catch
            {
                MessageBox.Show("تأكد من اختيار صنف من القائمة");
            }
            
        }
    }
}
