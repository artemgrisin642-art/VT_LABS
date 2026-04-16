using System.Globalization;

namespace LAB05;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private bool TryGetNumbers(out double number1, out double number2)
    {
        number1 = 0;
        number2 = 0;

        try
        {
            if (string.IsNullOrWhiteSpace(txtNumber1.Text) || string.IsNullOrWhiteSpace(txtNumber2.Text))
            {
                throw new Exception("Заполните оба поля.");
            }

            if (!double.TryParse(txtNumber1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out number1) ||
                !double.TryParse(txtNumber2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out number2))
            {
                throw new Exception("Ошибка: вводите только числа.");
            }

            return true;
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
            return false;
        }
    }

    private void ShowResult(double result)
    {
        lblResultValue.ForeColor = Color.Green;
        lblResultValue.Text = result.ToString("0.##");
    }

    private void ShowError(string message)
    {
        lblResultValue.ForeColor = Color.Red;
        lblResultValue.Text = message;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out double number1, out double number2))
            return;

        ShowResult(number1 + number2);
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out double number1, out double number2))
            return;

        ShowResult(number1 - number2);
    }

    private void btnMul_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out double number1, out double number2))
            return;

        ShowResult(number1 * number2);
    }

    private void btnDiv_Click(object sender, EventArgs e)
    {
        if (!TryGetNumbers(out double number1, out double number2))
            return;

        try
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль.");
            }

            ShowResult(number1 / number2);
        }
        catch (DivideByZeroException ex)
        {
            ShowError(ex.Message);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtNumber1.Clear();
        txtNumber2.Clear();
        lblResultValue.Text = string.Empty;
        lblResultValue.ForeColor = Color.Black;
        txtNumber1.Focus();
    }
}
