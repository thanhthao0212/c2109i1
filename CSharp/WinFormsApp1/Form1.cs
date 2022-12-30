namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
       var resul= MessageBox.Show("hi", "c2109i1", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if(resul == DialogResult.Yes)
        {

        }
        else
        {

        }
    }
}
