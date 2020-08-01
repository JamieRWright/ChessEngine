using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChessEngine
{
    public partial class ChessBoard : Form
    {
        public string conString = "Data Source=DESKTOP-MRJEJE6\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";

        public ChessBoard()
        {
            InitializeComponent();
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            ulong bitboard = Piece.makeBitboard(new Square('H', 8));
            
            label1.Text = Piece.ulongToBinary(bitboard);

        }
        private void Board_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.DarkOliveGreen, e.CellBounds);
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
            Piece thisPiece = Board.getBoard[e.Column, e.Row].Piece;
            if (thisPiece != default && thisPiece.Picture != default)
                e.Graphics.DrawImage(thisPiece.Picture, e.CellBounds);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //string q = txtID.Text.ToString();
                //SqlCommand cmd = new SqlCommand(q, con);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Made!");
            }
        }
    }
}

