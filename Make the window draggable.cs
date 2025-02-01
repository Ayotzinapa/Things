Variable:

Point lastPoint;

Mouse Move:

if (e.Button == MouseButtons.Left)
{
	this.Left += e.X - lastPoint.X;
	this.Top += e.Y - lastPoint.Y;
}

Mouse Down:

lastPoint = new Point(e.X, e.Y);