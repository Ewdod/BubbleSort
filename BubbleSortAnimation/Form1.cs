namespace BubbleSortAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            lstSayilar.Items.Clear();
            int adet = (int)nudAdet.Value;
            int[] liste = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Random rand = new Random();

                liste[i] = rand.Next(1, 101);

            }

            for (int i = 0; i < adet; i++)
            {
                //lstSayilar.Items.Clear();
                for (int j = 0; j < adet - 1 - i; j++)
                {
                    if (liste[j] > liste[j + 1])
                    {
                        int yedek = liste[j];
                        liste[j] = liste[j + 1];
                        liste[j + 1] = yedek;
                    }
                    Thread.Sleep(250);
                    lstSayilar.Update();
                    //lstSayilar.Refresh();
                    lstSayilar.Items.Clear();

                    for (int k = 0; k < adet; k++)
                    {
                        lstSayilar.Items.Add(liste[k]);
                    }

                }



            }




        }

        //void YerDegistir(int kaynak, int hedef)
        //{
            //object yedek = lstSayilar.Items[kaynak];
            //lstSayilar.Items[kaynak] = lstSayilar.Items[hedef];
            //lstSayilar.Items[hedef] = yedek;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
            //YerDegistir(0, 1);
        //}
    }
}
