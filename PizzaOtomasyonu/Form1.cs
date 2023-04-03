namespace PizzaOtomasyonu
{
    public partial class Form1 : Form
    {
        List<Ebat> _ebats;
        List<Turu> _turus;
        List<Kenar> _kenar;
        List<Malzeme> _malzemeler;
        List<Pizza> _pizzas;
        public Form1()
        {
            InitializeComponent();
            _ebats = new List<Ebat>()
            {
                new Ebat() {PizzaEbati="Küçük",Carpan=1m},
                new Ebat() {PizzaEbati="Orta",Carpan=1.25m},
                new Ebat() {PizzaEbati="Büyük",Carpan=1.75m},
                new Ebat() {PizzaEbati="Max",Carpan=2m},
            };
            _turus = new List<Turu>()
            {
                new Turu() {PizzaTuru="Klasik",Fiyat=14},
                new Turu() {PizzaTuru="Karýþýk",Fiyat=17},
                new Turu() {PizzaTuru="Turkish",Fiyat=21},
                new Turu() {PizzaTuru="Tuna",Fiyat=23},
                new Turu() {PizzaTuru="Akdeniz",Fiyat=18},
                new Turu() {PizzaTuru="Karadeniz",Fiyat=18},
            };
            _kenar = new List<Kenar>()
            {
                new Kenar() {PizzaKenari="Kalýn Kenar",Fiyat=2},
                new Kenar() {PizzaKenari="Ýnce Kenar",Fiyat=2},
            };
            _malzemeler = new List<Malzeme>()
            {
            new Malzeme (){Malzemeler="Dana Jambon"},
            new Malzeme (){Malzemeler="Sosis"},
            new Malzeme (){Malzemeler="Mýsýr"},
            new Malzeme (){Malzemeler="Ancuez"},
            new Malzeme (){Malzemeler="Zeytin"},
            new Malzeme (){Malzemeler="Salam"},
            new Malzeme (){Malzemeler="Sucuk"},
            new Malzeme (){Malzemeler="Mantar"},
            new Malzeme (){Malzemeler="Ton Balýðý"},
            new Malzeme (){Malzemeler="Peynir"},
            };

            _pizzas = new List<Pizza>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {


            textBoxTutar.Text = ((_ebats[comboEbat.SelectedIndex].Carpan * _turus[listBoxPizzalar.SelectedIndex].Fiyat + +2) * (numericUpDown1.Value)).ToString();

        }

        private void buttonSepetEkle_Click(object sender, EventArgs e)
        {
            List<string> secilenMalzemeler = new List<string>();

            for (int i = 0; i < checkedListBoxMalzemeler.Items.Count; i++)
            {
                if (checkedListBoxMalzemeler.GetItemChecked(i))
                    secilenMalzemeler.Add(checkedListBoxMalzemeler.Items[i].ToString());

            }
            string malze = "";
            foreach (var item in secilenMalzemeler)
            {
                malze = malze + item.ToString();
            }


            string kenar = "";
            if (radioButtonKalinKenar.Checked)
            {
                kenar = _kenar[0].PizzaKenari;
            }
            else
            {
                kenar = _kenar[1].PizzaKenari;
            }


            _pizzas.Add(new Pizza()
            {
                Ebat = _ebats[comboEbat.SelectedIndex].PizzaEbati,
                Turu = _turus[listBoxPizzalar.SelectedIndex].PizzaTuru,
                KenarTuru = kenar,
                MalzemeTuru = malze,
                ToplamFiyat = decimal.Parse(textBoxTutar.Text)
            });

            string listSepet =
                "Ebat: " + _ebats[comboEbat.SelectedIndex].PizzaEbati + ", " +
                "Turu : " + _turus[listBoxPizzalar.SelectedIndex].PizzaTuru + ", " +
                "KenarTuru : " + kenar + ", " +
                "MalzemeTuru :" + malze + ", " +
                "ToplamFiyat :" + decimal.Parse(textBoxTutar.Text);

            listBoxSepet.Items.Add(listSepet);


        }
    }
}