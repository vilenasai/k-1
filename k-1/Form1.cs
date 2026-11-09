using System;
using System.Drawing;
using System.Windows.Forms;

namespace k_1 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();

        txt_A.KeyPress += TextBox_KeyPress;
        txt_B.KeyPress += TextBox_KeyPress;
        txt_C.KeyPress += TextBox_KeyPress;
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '\b')
                e.Handled = true;
    }

    private void btnSolve_Click(object sender, EventArgs e) {
      if (!double.TryParse(txt_A.Text.Replace('.', ','), out double a) ||
         !double.TryParse(txt_B.Text.Replace('.', ','), out double b) ||
         !double.TryParse(txt_C.Text.Replace('.', ','), out double c)) {
         MessageBox.Show("Введите числа!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         return;
      }

      if (a == 0) {
          MessageBox.Show("Коэффициент 'a' не может быть 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
      }

       rtbDiscriminant.Clear();
       rtbVieta.Clear();

       double d = b * b - 4 * a * c;

       if (d > 0) {
         double x1 = (-b + Math.Sqrt(d)) / (2 * a);
         double x2 = (-b - Math.Sqrt(d)) / (2 * a);
         rtbDiscriminant.Text = $"D = {d:F2}\nДва корня:\nx1 = {x1:F2}\nx2 = {x2:F2}";
       } else if (d == 0) {
         double x = -b / (2 * a);
         rtbDiscriminant.Text = $"D = 0\nОдин корень:\nx = {x:F2}";
       } else {
                rtbDiscriminant.Text = $"D = {d:F2}\nКорней нет";
       }

        double sum = -b / a;
        double product = c / a;

        rtbVieta.Text = $"Сумма корней: {sum:F2}\nПроизведение: {product:F2}\n\n";

        if (d >= 0) {
          double x1 = (-b + Math.Sqrt(d)) / (2 * a);
          double x2 = (-b - Math.Sqrt(d)) / (2 * a);

        if (Math.Abs((x1 + x2) - sum) < 0.01 && Math.Abs((x1 * x2) - product) < 0.01) {
          rtbVieta.SelectionColor = Color.Green;
          rtbVieta.Text += "Корни верны!";
        } else {
            rtbVieta.SelectionColor = Color.Red;
            rtbVieta.Text += "Ошибка!";
        }
    } else {
        rtbVieta.Text += "Проверка невозможна.";
    }
  }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}