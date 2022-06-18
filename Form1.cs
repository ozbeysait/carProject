namespace PeceOtomotiv
{
    public partial class Form1 : Form
    {
        int selectedCar = 0;

        // IMAGES
        static Image yan_araba = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_araba.png");
        static Image on_araba = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_araba.png");
        static Image arka_araba = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_araba.png");
        
        static Image dodikler_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_dodikler.png");
        static Image dodikler_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_dodikler.png");
        static Image dodikler_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_dodikler.png");
        static Image faceliftTampon_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_facelift_tampon.png");
        static Image faceliftTampon_1 = null;
        static Image faceliftTampon_2 = null;
        static Image rollbar_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_rollbar.png");
        static Image rollbar_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_rollbar.png");
        static Image rollbar_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_rollbar.png");
        static Image mercekliFarlar_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_mercekli_farlar.png");
        static Image mercekliFarlar_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_mercekli_farlar.png");
        static Image mercekliFarlar_2 = null;
        static Image premiumCamliKabin_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_premium_camli_kabin.png");
        static Image premiumCamliKabin_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_premium_camli_kabin.png");
        static Image premiumCamliKabin_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_premium_camli_kabin.png");
        static Image arkaTampon_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_arka_tampon.png");
        static Image arkaTampon_1 = null;
        static Image arkaTampon_2 = null;
        static Image basamakAydinlatma_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_basamak_aydinlatma.png");
        static Image basamakAydinlatma_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_basamak_aydinlatma.png");
        static Image basamakAydinlatma_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_basamak_aydinlatma.png");
        static Image blacklineBoyama_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_blackline_boyama.png");
        static Image blacklineBoyama_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_blackline_boyama.png");
        static Image blacklineBoyama_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_blackline_boyama.png");
        static Image cargoCarrier_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_cargo_carrier.png");
        static Image cargoCarrier_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_cargo_carrier.png");
        static Image cargoCarrier_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_cargo_carrier.png");
        static Image cekiDemiri_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_ceki_demiri.png");
        static Image cekiDemiri_1 = null;
        static Image cekiDemiri_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_ceki_demiri.png");
        static Image lastikJantYukseltme_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_lastik_jant_yukseltme.png");
        static Image lastikJantYukseltme_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_lastik_jant_yukseltme.png");
        static Image lastikJantYukseltme_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_lastik_jant_yukseltme.png");
        static Image stoplar_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_stoplar.png");
        static Image stoplar_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_stoplar.png");
        static Image stoplar_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_stoplar.png");
        static Image surguluKapak_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_surgulu_kapak.png");
        static Image surguluKapak_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_surgulu_kapak.png");
        static Image surguluKapak_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_surgulu_kapak.png");
        static Image tStepBasamak_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_tstep_basamak.png");
        static Image tStepBasamak_1 = null;
        static Image tStepBasamak_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_tstep_basamak.png");
        static Image yanGovdeKaplama_0 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_yan_govde_kaplama.png");
        static Image yanGovdeKaplama_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_yan_govde_kaplama.png");
        static Image yanGovdeKaplama_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_yan_govde_kaplama.png");
        static Image maximusVinc_0 = null;
        static Image maximusVinc_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_maximus_vinc.png");
        static Image maximusVinc_2 = null;
        static Image moonvisor_0 = null;
        static Image moonvisor_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_moonvisor.png");
        static Image moonvisor_2 = null;
        static Image onIsiklandirma_0 = null;
        static Image onIsiklandirma_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_on_isiklandirma.png");
        static Image onIsiklandirma_2 = null;
        static Image onTamponSeti_0 = null;
        static Image onTamponSeti_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_on_tampon_seti.png");
        static Image onTamponSeti_2 = null;
        static Image rivalAltKoruma_0 = null;
        static Image rivalAltKoruma_1 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_rival_alt_koruma.png");
        static Image rivalAltKoruma_2 = null;
        static Image arkaIsiklandirma_0 = null;
        static Image arkaIsiklandirma_1 = null;
        static Image arkaIsiklandirma_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_arka_isiklandirma.png");
        static Image parkSensoru_0 = null;
        static Image parkSensoru_1 = null;
        static Image parkSensoru_2 = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_park_sensoru.png");



        // LISTS
        string[] list0 = new string[15] { "arkaTamponBtn",
                                        "basamakAydinlatmaBtn",
                                        "blacklineBoyamaBtn",
                                        "cargoCarrierBtn",
                                        "cekiDemiriBtn",
                                        "dodiklerBtn",
                                        "faceliftTamponBtn",
                                        "lastikJantYukseltmeBtn",
                                        "mercekliFarlarBtn",
                                        "premiumCamliKabinBtn",
                                        "rollbarBtn",
                                        "stoplarBtn",
                                        "surguluKapakBtn",
                                        "tStepBasamakBtn",
                                        "yanGovdeKaplamaBtn"};
        List<Image> selectedList0 = new List<Image>();

        string[] list1 = new string[16] {"mercekliFarlarBtn",
                                        "basamakAydinlatmaBtn",
                                        "blacklineBoyamaBtn",
                                        "cargoCarrierBtn",
                                        "dodiklerBtn",
                                        "lastikJantYukseltmeBtn",
                                        "maximusVincBtn",
                                        "moonvisorBtn",
                                        "onIsiklandirmaBtn",
                                        "onTamponSetiBtn",
                                        "premiumCamliKabinBtn",
                                        "rivalAltKorumaBtn",
                                        "rollbarBtn",
                                        "stoplarBtn",
                                        "surguluKapakBtn",
                                        "yanGovdeKaplamaBtn"};
        List<Image> selectedList1 = new List<Image>();

        string[] list2 = new string[14] { "arkaIsiklandirmaBtn",
                                        "basamakAydinlatmaBtn",
                                        "blacklineBoyamaBtn",
                                        "cargoCarrierBtn",
                                        "cekiDemiriBtn",
                                        "dodiklerBtn",
                                        "lastikJantYukseltmeBtn",
                                        "parkSensoruBtn",
                                        "premiumCamliKabinBtn",
                                        "rollbarBtn",
                                        "stoplarBtn",
                                        "surguluKapakBtn",
                                        "tStepBasamakBtn",
                                        "yanGovdeKaplamaBtn"};
        List<Image> selectedList2 = new List<Image>();

        static Image image = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_dodikler.png");
        static Graphics g = Graphics.FromImage(image);

        private void ciz(List<Image> images)
        {
            if(selectedCar == 0)
            {
                image = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\0_araba.png");
            }
            if (selectedCar == 1)
            {
                image = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\1_araba.png");
            }
            if (selectedCar == 2)
            {
                image = Image.FromFile("C:\\Users\\Sait\\source\\repos\\PeceOtomotiv\\Resources\\navaraImages\\2_araba.png");
            }

            g = Graphics.FromImage(image);

            foreach (Image image in images)
            {
                g.DrawImage(image, 0, 0);
            }

            carPictureBox.Image = image;
        }

        public Form1()
        {
            InitializeComponent();
            NavaraHideMenu();
        }

        bool navaraShowStatus = true;
        private void NavaraHideMenu()
        {
            dodiklerBtn.Visible = false;
            faceliftTamponBtn.Visible = false;
            rollbarBtn.Visible = false;
            mercekliFarlarBtn.Visible = false;
            premiumCamliKabinBtn.Visible = false;
            arkaTamponBtn.Visible = false;
            basamakAydinlatmaBtn.Visible = false;
            blacklineBoyamaBtn.Visible = false;
            cargoCarrierBtn.Visible = false;
            cekiDemiriBtn.Visible = false;
            lastikJantYukseltmeBtn.Visible = false;
            stoplarBtn.Visible = false;
            surguluKapakBtn.Visible = false;
            tStepBasamakBtn.Visible = false;
            yanGovdeKaplamaBtn.Visible = false;
            maximusVincBtn.Visible = false;
            moonvisorBtn.Visible = false;
            onIsiklandirmaBtn.Visible = false;
            onTamponSetiBtn.Visible = false;
            rivalAltKorumaBtn.Visible = false;
            arkaIsiklandirmaBtn.Visible = false;
            parkSensoruBtn.Visible = false;

            navaraShowStatus = false;
        }
        private void NavaraShowMenu()
        {

            if (selectedCar == 0)
            {
                dodiklerBtn.Visible = true;
                faceliftTamponBtn.Visible = true;
                rollbarBtn.Visible = true;
                mercekliFarlarBtn.Visible = true;
                premiumCamliKabinBtn.Visible = true;
                arkaTamponBtn.Visible = true;
                basamakAydinlatmaBtn.Visible = true;
                blacklineBoyamaBtn.Visible = true;
                cargoCarrierBtn.Visible = true;
                cekiDemiriBtn.Visible = true;
                lastikJantYukseltmeBtn.Visible = true;
                stoplarBtn.Visible = true;
                surguluKapakBtn.Visible = true;
                tStepBasamakBtn.Visible = true;
                yanGovdeKaplamaBtn.Visible = true;
                maximusVincBtn.Visible = false;
                moonvisorBtn.Visible = false;
                onIsiklandirmaBtn.Visible = false;
                onTamponSetiBtn.Visible = false;
                rivalAltKorumaBtn.Visible = false;
                arkaIsiklandirmaBtn.Visible = false;
                parkSensoruBtn.Visible = false;
            }
            if (selectedCar == 1)
            {
                dodiklerBtn.Visible = true;
                faceliftTamponBtn.Visible = false;
                rollbarBtn.Visible = true;
                mercekliFarlarBtn.Visible = true;
                premiumCamliKabinBtn.Visible = true;
                arkaTamponBtn.Visible = false;
                basamakAydinlatmaBtn.Visible = true;
                blacklineBoyamaBtn.Visible = true;
                cargoCarrierBtn.Visible = true;
                cekiDemiriBtn.Visible = false;
                lastikJantYukseltmeBtn.Visible = true;
                stoplarBtn.Visible = true;
                surguluKapakBtn.Visible = true;
                tStepBasamakBtn.Visible = false;
                yanGovdeKaplamaBtn.Visible = true;
                maximusVincBtn.Visible = true;
                moonvisorBtn.Visible = true;
                onIsiklandirmaBtn.Visible = true;
                onTamponSetiBtn.Visible = true;
                rivalAltKorumaBtn.Visible = true;
                arkaIsiklandirmaBtn.Visible = false;
                parkSensoruBtn.Visible = false;
            }
            if (selectedCar == 2)
            {
                dodiklerBtn.Visible = true;
                faceliftTamponBtn.Visible = false;
                rollbarBtn.Visible = true;
                mercekliFarlarBtn.Visible = false;
                premiumCamliKabinBtn.Visible = true;
                arkaTamponBtn.Visible = false;
                basamakAydinlatmaBtn.Visible = true;
                blacklineBoyamaBtn.Visible = true;
                cargoCarrierBtn.Visible = true;
                cekiDemiriBtn.Visible = true;
                lastikJantYukseltmeBtn.Visible = true;
                stoplarBtn.Visible = true;
                surguluKapakBtn.Visible = true;
                tStepBasamakBtn.Visible = true;
                yanGovdeKaplamaBtn.Visible = true;
                maximusVincBtn.Visible = false;
                moonvisorBtn.Visible = false;
                onIsiklandirmaBtn.Visible = false;
                onTamponSetiBtn.Visible = false;
                rivalAltKorumaBtn.Visible = false;
                arkaIsiklandirmaBtn.Visible = true;
                parkSensoruBtn.Visible = true;
            }

            navaraShowStatus = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (selectedCar != 0)
            {
                selectedCar = 0;
                ciz(selectedList0);
            }
            NavaraShowMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (selectedCar != 1)
            {
                selectedCar = 1;
                ciz(selectedList1);
            }
            NavaraShowMenu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (selectedCar != 2)
            {
                selectedCar = 2;
                ciz(selectedList2);
            }
            NavaraShowMenu();
        }

        private void ekle(String btnName, Button btn, Image img0, Image img1, Image img2)
        {
            if (list0.Contains(btnName))
            {
                if (!selectedList0.Contains(img0))
                {
                    selectedList0.Add(img0);
                    btn.BackColor = Color.LightGreen;
                }
                else
                {
                    selectedList0.Remove(img0);
                    btn.BackColor = DefaultBackColor;
                }
            }
            if (list1.Contains(btnName))
            {
                if (!selectedList1.Contains(img1))
                {
                    selectedList1.Add(img1);
                    btn.BackColor = Color.LightGreen;
                }
                else
                {
                    selectedList1.Remove(img1);
                    btn.BackColor = DefaultBackColor;
                }
            }
            if (list2.Contains(btnName))
            {
                if (!selectedList2.Contains(img2))
                {
                    selectedList2.Add(img2);
                    btn.BackColor = Color.LightGreen;
                }
                else
                {
                    selectedList2.Remove(img2);
                    btn.BackColor = DefaultBackColor;
                }
            }

            if (selectedCar == 0)
                ciz(selectedList0);
            if (selectedCar == 1)
                ciz(selectedList1);
            if (selectedCar == 2)
                ciz(selectedList2);
        }

        private void navaraBtn_Click(object sender, EventArgs e)
        {
            if (navaraShowStatus)
            {
                NavaraHideMenu();
            }
            else
            {
                NavaraShowMenu();
            }
        }


        /* ***** BUTTON CLICKS ***** */
        private void dodiklerBtn_Click(object sender, EventArgs e)
        {
            ekle("dodiklerBtn", dodiklerBtn, dodikler_0, dodikler_1, dodikler_2);
        }

        private void faceliftTamponBtn_Click(object sender, EventArgs e)
        {
            ekle("faceliftTamponBtn", faceliftTamponBtn, faceliftTampon_0, faceliftTampon_1, faceliftTampon_2);
        }

        private void premiumCamliKabinBtn_Click(object sender, EventArgs e)
        {
            ekle("premiumCamliKabinBtn", premiumCamliKabinBtn, premiumCamliKabin_0, premiumCamliKabin_1, premiumCamliKabin_2);
        }

        private void arkaTamponBtn_Click(object sender, EventArgs e)
        {
            ekle("arkaTamponBtn", arkaTamponBtn, arkaTampon_0, arkaTampon_1, arkaTampon_2);
        }

        private void basamakAydinlatmaBtn_Click(object sender, EventArgs e)
        {
            ekle("basamakAydinlatmaBtn", basamakAydinlatmaBtn, basamakAydinlatma_0, basamakAydinlatma_1, basamakAydinlatma_2);
        }

        private void blacklineBoyamaBtn_Click(object sender, EventArgs e)
        {
            ekle("blacklineBoyamaBtn", blacklineBoyamaBtn, blacklineBoyama_0, blacklineBoyama_1, blacklineBoyama_2);
        }

        private void cargoCarrierBtn_Click(object sender, EventArgs e)
        {
            ekle("cargoCarrierBtn", cargoCarrierBtn, cargoCarrier_0, cargoCarrier_1, cargoCarrier_2);
        }

        private void cekiDemiriBtn_Click(object sender, EventArgs e)
        {
            ekle("cekiDemiriBtn", cekiDemiriBtn, cekiDemiri_0, cekiDemiri_1, cekiDemiri_2);
        }

        private void lastikJantYukseltmeBtn_Click(object sender, EventArgs e)
        {
            ekle("lastikJantYukseltmeBtn", lastikJantYukseltmeBtn, lastikJantYukseltme_0, lastikJantYukseltme_1, lastikJantYukseltme_2);
        }

        private void stoplarBtn_Click(object sender, EventArgs e)
        {
            ekle("stoplarBtn", stoplarBtn, stoplar_0, stoplar_1, stoplar_2);
        }

        private void surguluKapakBtn_Click(object sender, EventArgs e)
        {
            ekle("surguluKapakBtn", surguluKapakBtn, surguluKapak_0, surguluKapak_1, surguluKapak_2);
        }

        private void tStepBasamakBtn_Click(object sender, EventArgs e)
        {
            ekle("tStepBasamakBtn", tStepBasamakBtn, tStepBasamak_0, tStepBasamak_1, tStepBasamak_2);
        }

        private void yanGovdeKaplamaBtn_Click(object sender, EventArgs e)
        {
            ekle("yanGovdeKaplamaBtn", yanGovdeKaplamaBtn, yanGovdeKaplama_0, yanGovdeKaplama_1, yanGovdeKaplama_2);
        }

        private void rollbarBtn_Click(object sender, EventArgs e)
        {
            ekle("rollbarBtn", rollbarBtn, rollbar_0, rollbar_1, rollbar_2);
        }

        private void mercekliFarlarBtn_Click(object sender, EventArgs e)
        {
            ekle("mercekliFarlarBtn", mercekliFarlarBtn, mercekliFarlar_0, mercekliFarlar_1, mercekliFarlar_2);
        }

        private void maximusVincBtn_Click(object sender, EventArgs e)
        {
            ekle("maximusVincBtn", maximusVincBtn, maximusVinc_0, maximusVinc_1, maximusVinc_2);
        }

        private void moonvisorBtn_Click(object sender, EventArgs e)
        {
            ekle("moonvisorBtn", moonvisorBtn, moonvisor_0, moonvisor_1, moonvisor_2);
        }

        private void onIsiklandirmaBtn_Click(object sender, EventArgs e)
        {
            ekle("onIsiklandirmaBtn", onIsiklandirmaBtn, onIsiklandirma_0, onIsiklandirma_1, onIsiklandirma_2);
        }

        private void onTamponSetiBtn_Click(object sender, EventArgs e)
        {
            ekle("onTamponSetiBtn", onTamponSetiBtn, onTamponSeti_0, onTamponSeti_1, onTamponSeti_2);
        }

        private void rivalAltKorumaBtn_Click(object sender, EventArgs e)
        {
            ekle("rivalAltKorumaBtn", rivalAltKorumaBtn, rivalAltKoruma_0, rivalAltKoruma_1, rivalAltKoruma_2);
        }

        private void arkaIsiklandirmaBtn_Click(object sender, EventArgs e)
        {
            ekle("arkaIsiklandirmaBtn", arkaIsiklandirmaBtn, arkaIsiklandirma_0, arkaIsiklandirma_1, arkaIsiklandirma_2);
        }

        private void parkSensoruBtn_Click(object sender, EventArgs e)
        {
            ekle("parkSensoruBtn", parkSensoruBtn, parkSensoru_0, parkSensoru_1, parkSensoru_2);
        }
    }
}