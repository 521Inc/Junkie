using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunkieCore.models;
using JunkieCore.utils;
using JunkieGame.controllers;
using JunkieCore.interfaces;

namespace JunkieGame.controls {
    public partial class GameFieldCtrl : UserControl {

        #region Данные

        private Point? _cellUnderMouse = null;

        private GameField _gameField;

        private MainFormController _controller;

        private int _cellPadding = 2;

        #endregion
        
        public GameFieldCtrl() {
            InitializeComponent();
        }

        #region Методы

        private void drawCell(Graphics g, GameCellItem cell, Rectangle rect) {
            var brect = new Rectangle(rect.X + _cellPadding, rect.Y + _cellPadding,
                    rect.Width - _cellPadding * 2, rect.Height - _cellPadding * 2);
            switch (cell.State) {
                case CellState.Chip:
                    g.FillEllipse(Brushes.Red, brect);
                    break;
                case CellState.CrossJump:
                case CellState.Ground:
                case CellState.Jump:
                    g.FillRectangle(Brushes.RosyBrown, brect);
                    break;
                case CellState.Home:
                    g.FillRectangle(Brushes.Salmon, brect);
                    break;
            }
        }

        public async Task initialize(IPlayer player) {
            _controller = new MainFormController(player);
            await _controller.initialize();
            _controller.GameFieldCreated += onGameFieldCreated;
        }

        private Point? getCellUnderMouse(int x, int y) {
            var width = _gameField.FieldInfo.GetLength(0);
            var height = _gameField.FieldInfo.GetLength(1);
            var cellSize = Math.Min(Width / width, Height / height);
            var outerOffsetX = (Width - cellSize * width) / 2;
            var outerOffsetY = (Height - cellSize * height) / 2;
            var cellNumX = (x - outerOffsetX) / cellSize;
            var cellNumY = (y - outerOffsetY) / cellSize;
            if (cellNumX < 0 || cellNumX > width - 1) {
                return null;
            }
            if (cellNumY < 0 || cellNumY > height - 1) {
                return null;
            }
            return new Point(cellNumX, cellNumY);
        }

        #endregion

        #region Обработка событий

        protected override void OnMouseUp(MouseEventArgs e) {
            base.OnMouseUp(e);

        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            if (_cellUnderMouse.HasValue) {
                _controller.playerAction(_cellUnderMouse.Value.X, _cellUnderMouse.Value.Y);
                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            var newCellUnderMouse = getCellUnderMouse(e.X, e.Y);
            if (_cellUnderMouse != newCellUnderMouse) {
                _cellUnderMouse = newCellUnderMouse;
                Invalidate();
            }
        }

        private void onGameFieldCreated(object sender, EventArgs e) {
            _gameField = _controller.GameField;
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if (_gameField != null && _gameField.FieldInfo != null) {
                var width = _gameField.FieldInfo.GetLength(0);
                var height = _gameField.FieldInfo.GetLength(1);
                var cellSize = Math.Min(Width / width, Height / height);
                var outerOffsetX = (Width - cellSize * width) / 2;
                var outerOffsetY = (Height - cellSize * height) / 2;
                var rect = new Rectangle(0, 0, cellSize, cellSize);
                for (int i = 0; i < width; i++) {
                    for (int j = 0; j < height; j++) {
                        rect.X = outerOffsetX + cellSize * i;
                        rect.Y = outerOffsetY + cellSize * j;
                        drawCell(e.Graphics, _gameField.FieldInfo[i, j], rect);
                    }
                }
            }
        }

        #endregion
    }
}
