using GamesSystem.Controller;
using GamesSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesSystem.View
{
    public partial class MainView : Form
    {
        MainController mainController = new MainController();

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            dgvGames.DataSource = mainController.ShowAllGames();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Name = txtName.Text;
            game.Price = double.Parse(txtPrice.Text);
            mainController.CreateGame(game);
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGames.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            mainController.DeleteGame(id);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGames.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Game game = new Game();
            game.Name = txtName.Text;
            game.Price = double.Parse(txtPrice.Text);
            mainController.UpdateGame(id, game);
            RefreshTable();
        }
    }
}
