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

namespace لقمة_هنية_كلاكيت_اخر_مرة
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest; integrated security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        String[] target;
        double total1 = 0;
        ListViewItem item;
        double cost;
        double or_price;
        double temp;
        bool x = false;
        bool change = true;
        int index;
        DateTime date;
        /// /////////////////////
        /// </summary>
        //SqlCommand cmdd;
        //  SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            load_data_menu();
            load_data_sandwitch();
            total.Text = "0.00";
          //  xxx.Hide();

            hide();
            order_radioButton2.Checked = true;

        }
        public void hide()
        {
            address.Hide();
            adress_textBox3.Hide();
            client_name.Hide();
            cli_name.Hide();
            new_client.Hide();
            delver_adress.Hide();
            delever_name.Hide();
            delverphone.Hide();

            label29.Hide();
            label30.Hide();
            label28.Hide();

            phone.Hide();
            phone_textBox2.Hide();
            search_button.Hide();
            groupBox2.Hide();

            groupBox3.Hide();
        }
        //*************************
        public void show()
        {
            phone_textBox2.Show();
            phone.Show();

            address.Show();
            adress_textBox3.Show();

            client_name.Show();
            cli_name.Show();

           // new_client.Show();
            delver_adress.Show();
            delever_name.Show();
            delverphone.Show();
        }
        //******************************
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void button96_Click(object sender, EventArgs e)
        {
            new_order(c7);
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        /// //////****************************************************///////////////


        private void button6_Click(object sender, EventArgs e)
        {
            new_order(fool4);
        }


        ///////////////////////////////////*********************************** /// /////////


        private void button13_Click(object sender, EventArgs e)
        {
            new_order(r4);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            new_order(r15);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            new_order(sl3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void load_data_menu()
        {
            cn.Open();
            cmd = new SqlCommand("select * from menu", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            fool1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            fool9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();


            dr.Read();
            fool10.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();
            ////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////

            dr.Read();
            r1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r10.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r11.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r12.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r13.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r14.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r15.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            r16.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            m1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            m7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            roz1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            roz2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            roz3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            sl1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sl9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            mq1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mq10.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            t1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            t7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            f1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            f2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();

            dr.Read();
            f3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString();
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            sh1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sh2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sh3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sh4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            mw1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mw2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mw3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mw4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            mw5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            msh1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            msh8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            c1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c10.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c11.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c12.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c13.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c14.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c15.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c16.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c17.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            c18.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            sw1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sw2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sw3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            sw4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Read();
            d1.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d2.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d3.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d4.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d5.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d6.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d7.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d8.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";


            dr.Read();
            d9.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d10.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d11.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d12.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            dr.Read();
            d13.Text = dr["name"].ToString() + "-    " + dr["price"].ToString() + " جنيه";

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////
            dr.Close();
            cn.Close();

        }
        public void load_data_sandwitch()
        {
            cn.Open();

            cmd = new SqlCommand("select * from sandwitches", cn);
            dr = cmd.ExecuteReader();
            /////////////////////////////////////////////////////////

            dr.Read();
            s1.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s2.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s3.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s4.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Read();
            s5.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Read();
            s6.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Read();
            s7.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Read();
            s8.Text = dr["name"].ToString() + "-  سورى" + dr["middle"].ToString() + " / " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s9.Text = dr["name"].ToString() + "-  سورى " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s10.Text = dr["name"].ToString() + "- سورى  " + dr["middle"].ToString() + " / فرنساوى " + dr["combo"].ToString() + " جنيه";

            dr.Read();
            s11.Text = dr["name"].ToString() + "-  فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Read();
            s12.Text = dr["name"].ToString() + "-  فرنساوى " + dr["combo"].ToString() + " جنيه";


            dr.Close();
            cn.Close();


        }
        //****************************************************
        private void fool1_Click(object sender, EventArgs e)
        {
            new_order(fool1);
        }
        //*************************************************************//
        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        private void button91_Click(object sender, EventArgs e)
        {
            new_order(c6);
        }
        //********************************************************//
        private void fool7_Click(object sender, EventArgs e)
        {
            new_order(fool7);
        }
        //------------****************************-----------------------------//
        private void fool2_Click(object sender, EventArgs e)
        {
            new_order(fool2);
        }
        //**********************************************************************************//
        private void fool8_Click(object sender, EventArgs e)
        {
            new_order(fool8);
        }
        //**************************************************************//
        private void fool3_Click(object sender, EventArgs e)
        {
            new_order(fool3);
        }

        private void fool5_Click(object sender, EventArgs e)
        {
            new_order(fool5);
        }

        private void fool6_Click(object sender, EventArgs e)
        {
            new_order(fool6);
        }

        private void fool9_Click(object sender, EventArgs e)
        {
            new_order(fool9);
        }

        private void fool10_Click(object sender, EventArgs e)
        {
            new_order(fool10);
        }

        private void r1_Click(object sender, EventArgs e)
        {
            new_order(r1);
        }

        private void r2_Click(object sender, EventArgs e)
        {
            new_order(r2);
        }

        private void r3_Click(object sender, EventArgs e)
        {
            new_order(r3);
        }

        private void r5_Click(object sender, EventArgs e)
        {
            new_order(r5);
        }

        private void r6_Click(object sender, EventArgs e)
        {
            new_order(r6);
        }

        private void r7_Click(object sender, EventArgs e)
        {
            new_order(r7);
        }

        private void r8_Click(object sender, EventArgs e)
        {
            new_order(r8);
        }

        private void r9_Click(object sender, EventArgs e)
        {
            new_order(r9);
        }

        private void r10_Click(object sender, EventArgs e)
        {
            new_order(r10);
        }

        private void r11_Click(object sender, EventArgs e)
        {
            new_order(r11);
        }

        private void r12_Click(object sender, EventArgs e)
        {
            new_order(r12);
        }

        private void r13_Click(object sender, EventArgs e)
        {
            new_order(r13);
        }

        private void r14_Click(object sender, EventArgs e)
        {
            new_order(r14);
        }

        private void r16_Click(object sender, EventArgs e)
        {
            new_order(r16);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////

        public void new_order(Button b)
        {
            if (no.Text == "")
            {
                MessageBox.Show("تأكد من اخال العدد");
            }
            else
            {
                cn.Open();
                target = b.Text.Split('-');

                cmd = new SqlCommand("select price from menu where name='" + target[0] + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                or_price = Double.Parse(dr["price"].ToString());
                cost = or_price * (Double.Parse(no.Text));
                total1 += cost;

                if (listView1.Items.Count > 0)
                {

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[3].Text == target[0])
                        {

                            temp = double.Parse(listView1.Items[i].SubItems[1].Text);
                            temp += double.Parse(no.Text);
                            listView1.Items[i].SubItems[1].Text = temp.ToString();

                            ////////////////////////////////////////

                            temp = cost;
                            temp += Double.Parse(listView1.Items[i].SubItems[0].Text);
                            listView1.Items[i].SubItems[0].Text = temp.ToString();
                            x = true;
                            cn.Close();
                            no.Text = "";

                        }
                    }
                }

                /////////////////////////////////////////

                if (x == false || listView1.Items.Count <= 0)
                {

                    item = new ListViewItem(cost.ToString());
                    item.SubItems.Add(no.Text);
                    item.SubItems.Add(or_price.ToString());
                    item.SubItems.Add(target[0]);
                    listView1.Items.Add(item);

                }

                cn.Close();
                no.Text = "";
                total.Text = total1.ToString();
            }
            x = false;

        }

        private void s1_Click(object sender, EventArgs e)
        {
            sandwitches_order(s1);
        }

        private void s2_Click(object sender, EventArgs e)
        {
            sandwitches_order(s2);
        }

        private void s12_Click(object sender, EventArgs e)
        {
            sandwitches_order(s12);
        }

        private void s3_Click(object sender, EventArgs e)
        {
            sandwitches_order(s3);
        }

        private void s4_Click(object sender, EventArgs e)
        {
            sandwitches_order(s4);
        }

        private void s5_Click(object sender, EventArgs e)
        {
            sandwitches_order(s5);
        }

        private void s6_Click(object sender, EventArgs e)
        {
            sandwitches_order(s6);
        }

        private void s7_Click(object sender, EventArgs e)
        {
            sandwitches_order(s7);
        }

        private void s8_Click(object sender, EventArgs e)
        {
            sandwitches_order(s8);
        }

        private void s9_Click(object sender, EventArgs e)
        {
            sandwitches_order(s9);
        }

        private void s10_Click(object sender, EventArgs e)
        {
            sandwitches_order(s10);
        }

        private void s11_Click(object sender, EventArgs e)
        {
            sandwitches_order(s11);
        }

        //******************************************************************************//
        //*******************************************************************************//
        //******************************************************************************//
        //*******************************************************************************//function sandwitch

        public bool sandwitches_order(Button b)
        {
            // surryy

            if ((no.Text == "") || (sury_radioButton1.Checked == false && fransawe_radioButton2.Checked == false))
            {
                MessageBox.Show("تأكد من ادخال جميع البيانات");
            }
            else
            {
                target = b.Text.Split('-');
                //*************************************//

                cn.Open();
                if (sury_radioButton1.Checked == true)
                {
                    cmd = new SqlCommand("select middle from sandwitches where name='" + target[0] + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    //////***********************
                
                        if (dr["middle"] == null)
                        {
                            MessageBox.Show("لا يوجد سورى");
                            cn.Close();
                            no.Text = "1";
                            x = false;
                            return false;
                        }
                        else
                        {
                            or_price = Double.Parse(dr["middle"].ToString());
                            cost = or_price * (Double.Parse(no.Text));
                        }

                    //*********************************

                  if(  check(dr, " سورى ")==true)
                  {
                      return true;
                  }
                  else
                  {
                      add_direct(dr, " سورى ");
                  }

                    /////////////////////////////////////////

                    cn.Close();
                    no.Text = "";

                }
/////////////////////////////////////***************************** fransawe

                else
                {
                    cmd = new SqlCommand("select combo from sandwitches where name='" + target[0] + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    //////***********************

                    try
                    {

                        or_price = Double.Parse(dr["combo"].ToString());
                        cost = or_price * (Double.Parse(no.Text));
                    }
                    catch
                    {
                        MessageBox.Show("لا يوجد فرنساوى");
                        cn.Close();
                        no.Text = "";
                        x = false;
                        return false;
                    }

                    //*********************************
                    if (check(dr, " فرنساوى ") == true)
                    {
                        return true;
                    }
                    else
                    {
                        add_direct(dr,  " فرنساوى ");
                    }
                    ////////////////////////////////
                    
                    cn.Close();
                    no.Text = "";
                }

            }

            return true;
        }
        /*
         * 
         * 
         * 
         * */

        public bool check( SqlDataReader dr,String name)
        {
            if (listView1.Items.Count > 0)
            {
                dr.Read();
                //***************

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[3].Text == target[0] + name)
                    {

                        temp = double.Parse(listView1.Items[i].SubItems[1].Text);
                        temp += double.Parse(no.Text);
                        listView1.Items[i].SubItems[1].Text = temp.ToString();

                        ////////////////////////////////////////

                        temp = cost;
                        temp += Double.Parse(listView1.Items[i].SubItems[0].Text);
                        listView1.Items[i].SubItems[0].Text = temp.ToString();

                        total1 += cost;
                        total.Text = total1.ToString();
                        cn.Close();
                        no.Text = "";
                        return true;
                    }
                }
            }
            return false;
        }

        
        // ****************************************************

        public void add_direct(SqlDataReader dr,String name)
        {
            item = new ListViewItem(cost.ToString());
            item.SubItems.Add(no.Text);
            item.SubItems.Add(or_price.ToString());
            item.SubItems.Add(target[0] + name);
            listView1.Items.Add(item);
            total1 += cost;
            total.Text = total1.ToString();
        }
        
        

        private void roz1_Click(object sender, EventArgs e)
        {
            new_order(roz1);
        }

        private void roz2_Click(object sender, EventArgs e)
        {
            new_order(roz2);
        }

        private void roz3_Click(object sender, EventArgs e)
        {
            new_order(roz3);
        }

        private void m1_Click(object sender, EventArgs e)
        {
            new_order(m1);
        }

        private void m2_Click(object sender, EventArgs e)
        {
            new_order(m2);
        }

        private void m3_Click(object sender, EventArgs e)
        {
            new_order(m3);
        }

        private void m4_Click(object sender, EventArgs e)
        {
            new_order(m4);
        }

        private void m5_Click(object sender, EventArgs e)
        {
            new_order(m5);
        }

        private void m6_Click(object sender, EventArgs e)
        {
            new_order(m6);
        }

        private void m7_Click(object sender, EventArgs e)
        {
            new_order(m7);
        }

        private void sl1_Click(object sender, EventArgs e)
        {
            new_order(sl1);
        }

        private void sl2_Click(object sender, EventArgs e)
        {
            new_order(sl2);
        }

        private void sl7_Click(object sender, EventArgs e)
        {
            new_order(sl7);
        }

        private void sl8_Click(object sender, EventArgs e)
        {
            new_order(sl8);
        }

        private void sl9_Click(object sender, EventArgs e)
        {
            new_order(sl9);
        }

        private void sl4_Click(object sender, EventArgs e)
        {
            new_order(sl4);
        }

        private void sl5_Click(object sender, EventArgs e)
        {
            new_order(sl5);
        }

        private void sl6_Click(object sender, EventArgs e)
        {
            new_order(sl6);
        }

        private void mq1_Click(object sender, EventArgs e)
        {
            new_order(mq1);
        }

        private void mq2_Click(object sender, EventArgs e)
        {
            new_order(mq2);
        }

        private void mq3_Click(object sender, EventArgs e)
        {
            new_order(mq3);
        }

        private void mq4_Click(object sender, EventArgs e)
        {
            new_order(mq4);
        }

        private void mq5_Click(object sender, EventArgs e)
        {
            new_order(mq5);
        }

        private void mq6_Click(object sender, EventArgs e)
        {
            new_order(mq6);
        }

        private void mq7_Click(object sender, EventArgs e)
        {
            new_order(mq7);
        }

        private void mq8_Click(object sender, EventArgs e)
        {
            new_order(mq8);
        }

        private void mq9_Click(object sender, EventArgs e)
        {
            new_order(mq9);
        }

        private void mq10_Click(object sender, EventArgs e)
        {
            new_order(mq10);
        }

        private void t1_Click(object sender, EventArgs e)
        {
            new_order(t1);
        }

        private void t7_Click(object sender, EventArgs e)
        {
            new_order(t7);
        }

        private void t2_Click(object sender, EventArgs e)
        {
            new_order(t2);
        }

        private void t3_Click(object sender, EventArgs e)
        {
            new_order(t3);
        }

        private void t4_Click(object sender, EventArgs e)
        {
            new_order(t4);
        }

        private void t5_Click(object sender, EventArgs e)
        {
            new_order(t5);
        }

        private void t6_Click(object sender, EventArgs e)
        {
            new_order(t6);
        }

        private void f1_Click(object sender, EventArgs e)
        {
            new_order(f1);
        }

        private void f2_Click(object sender, EventArgs e)
        {
            new_order(f2);
        }

        private void f3_Click(object sender, EventArgs e)
        {
            new_order(f3);
        }

        private void sh1_Click(object sender, EventArgs e)
        {
            new_order(sh1);
        }

        private void sh2_Click(object sender, EventArgs e)
        {
            new_order(sh2);
        }

        private void sh3_Click(object sender, EventArgs e)
        {
            new_order(sh3);
        }

        private void sh4_Click(object sender, EventArgs e)
        {
            new_order(sh4);
        }

        private void mw1_Click(object sender, EventArgs e)
        {
            new_order(mw1);
        }

        private void mw2_Click(object sender, EventArgs e)
        {
            new_order(mw2);
        }

        private void mw3_Click(object sender, EventArgs e)
        {
            new_order(mw3);
        }

        private void mw4_Click(object sender, EventArgs e)
        {
            new_order(mw4);
        }

        private void mw5_Click(object sender, EventArgs e)
        {
            new_order(mw5);
        }

        private void msh1_Click(object sender, EventArgs e)
        {
            new_order(msh1);
        }

        private void msh2_Click(object sender, EventArgs e)
        {
            new_order(msh2);
        }

        private void msh3_Click(object sender, EventArgs e)
        {
            new_order(msh3);
        }

        private void msh4_Click(object sender, EventArgs e)
        {
            new_order(msh4);
        }

        private void msh5_Click(object sender, EventArgs e)
        {
            new_order(msh5);
        }

        private void msh6_Click(object sender, EventArgs e)
        {
            new_order(msh6);
        }

        private void msh7_Click(object sender, EventArgs e)
        {
            new_order(msh7);
        }

        private void msh8_Click(object sender, EventArgs e)
        {
            new_order(msh8);
        }

        private void c1_Click(object sender, EventArgs e)
        {
            new_order(c1);
        }

        private void c2_Click(object sender, EventArgs e)
        {
            new_order(c2);
        }

        private void c3_Click(object sender, EventArgs e)
        {
            new_order(c3);
        }

        private void c4_Click(object sender, EventArgs e)
        {
            new_order(c4);
        }

        private void c5_Click(object sender, EventArgs e)
        {
            new_order(c5);
        }

        private void c8_Click(object sender, EventArgs e)
        {
            new_order(c8);
        }

        private void c16_Click(object sender, EventArgs e)
        {
            new_order(c16);
        }

        private void c9_Click(object sender, EventArgs e)
        {
            new_order(c9);
        }

        private void c10_Click(object sender, EventArgs e)
        {
            new_order(c10);
        }

        private void c11_Click(object sender, EventArgs e)
        {
            new_order(c11);
        }

        private void c12_Click(object sender, EventArgs e)
        {
            new_order(c12);
        }

        private void c13_Click(object sender, EventArgs e)
        {
            new_order(c13);
        }

        private void c14_Click(object sender, EventArgs e)
        {
            new_order(c14);
        }

        private void c15_Click(object sender, EventArgs e)
        {
            new_order(c15);
        }

        private void c17_Click(object sender, EventArgs e)
        {
            new_order(c17);
        }

        private void c18_Click(object sender, EventArgs e)
        {
            new_order(c18);
        }

        private void sw1_Click(object sender, EventArgs e)
        {
            new_order(sw1);
        }

        private void sw2_Click(object sender, EventArgs e)
        {
            new_order(sw2);
        }

        private void sw3_Click(object sender, EventArgs e)
        {
            new_order(sw3);
        }

        private void sw4_Click(object sender, EventArgs e)
        {
            new_order(sw4);
        }

        private void d1_Click(object sender, EventArgs e)
        {
            new_order(d1);
        }

        private void d2_Click(object sender, EventArgs e)
        {
            new_order(d2);
        }

        private void d3_Click(object sender, EventArgs e)
        {
            new_order(d3);
        }

        private void d4_Click(object sender, EventArgs e)
        {
            new_order(d4);
        }

        private void d5_Click(object sender, EventArgs e)
        {
            new_order(d5);
        }

        private void d6_Click(object sender, EventArgs e)
        {
            new_order(d6);
        }

        private void d7_Click(object sender, EventArgs e)
        {
            new_order(d7);
        }

        private void d13_Click(object sender, EventArgs e)
        {
            new_order(d13);
        }

        private void d12_Click(object sender, EventArgs e)
        {
            new_order(d12);
        }

        private void d11_Click(object sender, EventArgs e)
        {
            new_order(d11);
        }

        private void d10_Click(object sender, EventArgs e)
        {
            new_order(d10);
        }

        private void d9_Click(object sender, EventArgs e)
        {
            new_order(d9);
        }

        private void d8_Click(object sender, EventArgs e)
        {
            new_order(d8);
        }

        private void cancel_buttoun_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            total.Text = "0.00";
            total1 = 0;
        }
        //**************
        public void add_data_base(int i,ListView list)
        {
            String[] data_1 = date.ToString().Split(' ');

            cmd = new SqlCommand("insert into fawateer1 (name,price,quantity,tprice,datatime)values('" + list.Items[i].SubItems[3].Text + "','" + list.Items[i].SubItems[2].Text + "','" + list.Items[i].SubItems[1].Text + "','" + list.Items[i].SubItems[0].Text + "','" + data_1[0] + "')", cn);
            cmd.ExecuteNonQuery();
            
        }
        //******************************
        private void new_order_button_Click(object sender, EventArgs e)
        {

            date = DateTime.Now;
            DialogResult dialogResult = MessageBox.Show("هل تريد اضافة طلب جديد", "اضافة طلب جديد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
                cn.Open();
                for (int i = 0; i < listView1.Items.Count;i++ )
                {
                    add_data_base(i, listView1);
                }
                cn.Close();
                listView1.Items.Clear();
            }
            /*  else if (dialogResult == DialogResult.No)
              {
               
              }*/
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                total1 -= double.Parse(listView1.SelectedItems[0].SubItems[0].Text.ToString());
                index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                listView1.Items.RemoveAt(index);
                total.Text = total1.ToString();
            }
            catch
            {
                MessageBox.Show("تأكد من اختيار صنف موجود فى القائمة");
            }
            
        }

        private void ta3del_numbers_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
          /*  index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
          
                label23.Text = listView1.Items[index].SubItems[3].Text;
               
                label24.Text = listView1.Items[index].SubItems[1].Text;

                xxx.Show();*/
              

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void done_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          /*  xxx.Hide();
            new_quantity.Clear();
            label23.Text = "";
            label24.Text = "";*/
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           /* xxx.Hide();
            new_quantity.Clear();
            label23.Text = "";
            label24.Text = "";*/
        }

        private void done_Click_2(object sender, EventArgs e)
        {
           /* total1 -= (double.Parse(listView1.Items[index].SubItems[0].Text.ToString()));
            xxx.Hide();
            listView1.Items[index].SubItems[1].Text = new_quantity.Text;
            listView1.Items[index].SubItems[0].Text =( double.Parse(listView1.Items[index].SubItems[2].Text.ToString()) * double.Parse(new_quantity.Text.ToString())).ToString();
            label24.Text = "";
            label23.Text = "";
            new_quantity.Clear();
            total1 += double.Parse(listView1.Items[index].SubItems[0].Text.ToString());
            total.Text = total1.ToString();*/
        }

      /*  private void search_button_Click(object sender, EventArgs e)
        {
            
        }*/

       /* private void new_client_Click(object sender, EventArgs e)
        {
           
        }*/

    /*    private void button2_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            DialogResult dialogResult = MessageBox.Show("هل تريد اضافة طلب جديد", "اضافة طلب جديد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
                cn.Open();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    add_data_base(i,listView1);
                }
                cn.Close();
                listView1.Items.Clear();
                MessageBox.Show("تم بنجاح");
                hide();
                

            }
            /*  else if (dialogResult == DialogResult.No)
              {
               
              }*/
       // }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hide();
            phone_textBox2.Hide();
            phone.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            phone_textBox2.Clear();
            phone_textBox2.Show();
            phone.Show();
            label29.Show();
            label30.Show();
            label28.Show();
            search_button.Show();
        }

        private void new_order_button_Click_1(object sender, EventArgs e)
        {
             date = DateTime.Now;
             
            DialogResult dialogResult = MessageBox.Show("هل تريد اضافة طلب جديد", "اضافة طلب جديد", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
                cn.Open();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    add_data_base(i, listView1);
                }
                cn.Close();
                listView1.Items.Clear();

                address.Hide();
                adress_textBox3.Hide();
                client_name.Hide();
                cli_name.Hide();
                new_client.Hide();
                delver_adress.Hide();
                delever_name.Hide();
                delverphone.Hide();
                phone_textBox2.Clear();
                //////****************
                total1 = 0;
                total.Text = "0.00";
                MessageBox.Show("تم بنجاح");
                
            }
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
            cn.Open();

            cmd = new SqlCommand("select * from client_data where client_phone='" + phone_textBox2.Text + "'", cn);
            dr = cmd.ExecuteReader();
            dr.Read();
            try
            {
                delever_name.Text = dr["client_nam"].ToString();

             
                delver_adress.Text = dr["client_address"].ToString();
          
                delverphone.Text = phone_textBox2.Text;

                label28.Show();
                label29.Show();
                label30.Show();
                delverphone.Show();
                delever_name.Show();
                delver_adress.Show();

            }
            catch
            {
                MessageBox.Show("اضافة كعميل جديد");
                new_client.Show();
                search_button.Hide();
                cli_name.Show();
                client_name.Show();
                adress_textBox3.Show();
                address.Show();
            }



            dr.Close();
            cn.Close();
        }

        private void new_client_Click_1(object sender, EventArgs e)
        {
            if(phone_textBox2.Text=="" || cli_name.Text=="" || adress_textBox3.Text=="")
            {
                MessageBox.Show("تأكد من ادخال جميع اليانات");
            }
            else
            {
                //SqlConnection cn = new SqlConnection(@"server=.\SQLEXPRESS;database=rest;integrated security=true");
                cn.Open();
                cmd = new SqlCommand("insert into client_data (client_nam,client_phone,client_address)values('" + cli_name.Text + "','" + phone_textBox2.Text + "','" + adress_textBox3.Text + "')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تم اضافة عميل جديد");

                new_client.Hide();

                client_name.Hide();
                delever_name.Text = cli_name.Text;
                cli_name.Clear();
                cli_name.Hide();
                address.Hide();
                delver_adress.Text = adress_textBox3.Text;
                adress_textBox3.Clear();
                adress_textBox3.Hide();
                delverphone.Text = phone_textBox2.Text;
                phone_textBox2.Clear();
                //////////////////////////////////
                delever_name.Show();
                delver_adress.Show();
                delverphone.Show();
            }
       
        }

        private void cancel_buttoun_Click_1(object sender, EventArgs e)
        {
               DialogResult dialogResult = MessageBox.Show("هل تريد الغاء الطلب ", "الغاء طلب جديد", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {
                   total1 = 0;
                   total.Text = "0.00";
                   listView1.Items.Clear();
                   order_radioButton2.Select();
                   hide();
               }
              /* else
               {

               }*/
         
        }

        private void تعديلاسمالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change = false;
            kind(false);
            groupBox2.Show();
        }
        public bool kind(bool x)
        {
            if(x==false)
            {
                def.Text = "اسم الصنف القديم";
                def1.Text = "الاسم الجديد";
                return false;
            }
            else
            {
                def.Text = "اسم الصنف ";
                def1.Text = "السعر الجديد";
                return true;
            }
        }
        public void change_new(bool x)
        {
            if (x==true)
            {
                try
           {
                cn.Open();
                cmd = new SqlCommand("update menu set price='" + new_price.Text + "' where name = '" + new_name.Text + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                groupBox2.Hide();
                new_name.Clear();
                new_price.Clear();

                load_data_menu();
                MessageBox.Show("تم التعديل");
         }    
           catch
            {
                MessageBox.Show("لايوجد منتج بهذا الاسم");

            }
            }
            else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("update menu set name='" + new_price.Text + "' where name = '" + new_name.Text + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    groupBox2.Hide();
                    new_name.Clear();
                    new_price.Clear();

                    load_data_menu();
                    MessageBox.Show("تم التعديل");
                }
                catch
                {
                    MessageBox.Show("لايوجد منتج بهذا الاسم");

                }
            }
        }

        private void menu_ta3deel_Click(object sender, EventArgs e)
        {
            if(change==true)
            {
                change_new(true);
            }
            else
            {
                change_new(false);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void تعديلسعرالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change = true;
            kind(true);
            groupBox2.Show();
        }

        private void cancel_menue_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            new_name.Clear();
            new_price.Clear();
        }

        private void تعديلسعرسندوتشسورىاوفرنساوىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            name_of_sand.Text = "اسم الصنف";
            new_sand_price.Text = "السعر الجديد";
            sur_radioButton3.Show();
            fr_radioButton2.Show();
        }

        private void تغيراسمسندوتشسورىاوفرنساوىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            name_of_sand.Text = "اسم الصنف القديم";
            new_sand_price.Text = "السعر الصنف الجديد";
            sur_radioButton3.Hide();
            sur_radioButton3.Checked = false;
            fr_radioButton2.Hide();
            fr_radioButton2.Checked = false;
        }

        private void sand_cancel_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            sand_nam_textBox1.Clear();
            sandOther.Clear();
            fr_radioButton2.Checked = false;
            sur_radioButton3.Checked = false;
        }
      

      /// //////////************************************///////////////
      
 
        public bool check_sand(bool x)
        {  
        ////////////////// end of general if //****************************
            if(x==false)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("update sandwitches set name='" + sandOther.Text + "' where name = '" + sand_nam_textBox1.Text + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    groupBox3.Hide();
                    sand_nam_textBox1.Clear();
                    sandOther.Clear();
                    sur_radioButton3.Checked = false;
                    fr_radioButton2.Checked = false;

                    cn.Close();

                    load_data_sandwitch();

                    MessageBox.Show("تم التعديل");
                }

                catch
                {
                    MessageBox.Show("لايوجد منتج بهذا الاسم");
                    return false;
                }
            }
            //*********************************************end
            else
            {
                if(sur_radioButton3.Checked==false && fr_radioButton2.Checked==false || sand_nam_textBox1.Text=="" || new_sand_price.Text=="")
                {
                    MessageBox.Show("تأكد من ادخال جميع البيانات");
                    return false;
                }
               
                else  if(sur_radioButton3.Checked==true)
                {
                    try
                    {
                           cn.Open();
                           cmd = new SqlCommand("update sandwitches set middle='" + sandOther.Text + "' where name = '" + sand_nam_textBox1.Text + "'", cn);
                           cmd.ExecuteNonQuery();
                           cn.Close();

                           groupBox3.Hide();
                           sand_nam_textBox1.Clear();
                           sandOther.Clear();
                           sur_radioButton3.Checked=false;
                           fr_radioButton2.Checked=false;
                    
                           cn.Close();

                           load_data_sandwitch();

                           MessageBox.Show("تم التعديل");
                    }
                  
                   catch
                     {
                           MessageBox.Show("لايوجد منتج بهذا الاسم");

                     }
                  }
            
               
                else
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("update sandwitches set combo='" + sandOther.Text + "' where name = '" + sand_nam_textBox1.Text + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    groupBox3.Hide();
                    sand_nam_textBox1.Clear();
                    sandOther.Clear();
                    sur_radioButton3.Checked = false;
                    fr_radioButton2.Checked = false;

                    cn.Close();

                    load_data_sandwitch();

                    MessageBox.Show("تم التعديل");
                }

                catch
                {
                    MessageBox.Show("لايوجد منتج بهذا الاسم");
                    return false;

                }
            }
        }
            //************************************************
            return true;
            
           }
        

        /// ///////////////////////////////////////////////
     

        private void sand_ok_Click(object sender, EventArgs e)
        {
            if(new_sand_price.Text ==  "السعر الجديد")
            {
                check_sand(true);
            }
            else
            {
                check_sand(false);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }

}

