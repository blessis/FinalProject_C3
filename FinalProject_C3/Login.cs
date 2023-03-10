﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginTest;
using Org.BouncyCastle.Asn1.Ocsp;

namespace FinalProject_C3
{
    public partial class Login : Form
    {
        public static DBMySql _db = new DBMySql();

        bool On;
        Point Pos;
        TextBox[] txtList;
        Join _signUp = new Join();

        const string IdPlaceholder = "아이디";
        const string PwPlaceholder = "비밀번호";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
          int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Login()
        {
            InitializeComponent();

            //FormBorderStyle = None 일 때, Form 마우스 클릭으로 이동
            PNL_LOGIN.MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            PNL_LOGIN.MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            PNL_LOGIN.MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };


            //사용자 정보 가져오기
            LoadUserInfo();

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { TB_ID, TB_PW };
            foreach (var txt in txtList)
            {
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            {
                txt.ForeColor = Color.FromArgb(60, 30, 30);
                txt.Text = string.Empty;
                if (txt == TB_PW) TB_PW.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.ForeColor = Color.DarkGray;
                if (txt == TB_ID) txt.Text = IdPlaceholder;
                else if (txt == TB_PW) { txt.Text = PwPlaceholder; TB_PW.PasswordChar = default; }
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0X20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_MAX_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }//삭제된 버튼

        private void BT_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_JOIN_Click(object sender, EventArgs e)
        {
            _signUp.StartPosition = FormStartPosition.Manual;
            _signUp.Location = new Point(Location.X + Width, Location.Y);
            _signUp.ClearTextBox();
            _signUp.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _db.Connection();
        }

        private void BT_LOGIN_Click(object sender, EventArgs e)
        {
            LoadUserInfo();
            CheckID_PW(TB_ID.Text, TB_PW.Text);
        }

        public static void LoadUserInfo()
        {
            //데이터베이스에서 사용자 정보 가져오기
            Config.user_ds = _db.SelectAll(Config.Tables[(int)eTName._user]);
        }

        private void CheckID_PW(string id, string pw)
        {
            //사용자 정보와 비교해서 ID / Password 일치하는 지 확인
            if (Config.user_ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in Config.user_ds.Tables[0].Rows)
                {
                    if (id == row["id"].ToString())
                    {
                        if (pw == row["pw"].ToString()) { 
                            MessageBox.Show("로그인에 성공했습니다.");
                            
                            Main main = new Main();
                            main.Show();
                            this.Close();
                        }
                        else MessageBox.Show("비밀번호가 일치하지 않습니다. 확인 후 다시 입력해주세요.");
                    }
                }
            }
            else
            {
                MessageBox.Show("사용자 정보가 없습니다.");
            }
        }
    }
}


    