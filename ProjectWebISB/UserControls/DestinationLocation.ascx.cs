using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebISB.UserControls
{
    public partial class DestinationLocation : System.Web.UI.UserControl
    {
        double[] pelKlang = { 0 };
        double[] jlnKastam = { 1.50, 0 };
        double[] kgRajaUda = { 1.90, 1.30, 0 };
        double[] telukGadong = { 1.90, 1.90, 1.60, 0 };
        double[] telukPulai = { 1.90, 1.90, 1.80, 1.20, 0 };
        double[] klang = { 2.30, 2.00, 1.80, 1.80, 1.60, 0 };
        double[] bukitBadak = { 2.80, 2.30, 2.20, 1.90, 1.90, 1.70, 0 };
        double[] padangJawa = { 2.80, 2.60, 2.40, 2.40, 2.30, 2.00, 2.00, 0 };
        double[] shahAlam = { 3.30, 3.00, 2.90, 2.60, 2.50, 2.50, 2.10, 2.00, 0 };
        double[] batuTiga = { 3.90, 3.60, 3.50, 3.20, 3.10, 2, 80, 2.40, 2.20, 2.20, 0 };
        double[] subangJaya = { 4.30, 4.10, 3.90, 3.60, 3.50, 3.20, 2.90, 2.40, 2.20, 1.90, 0 };
        double[] setiaJaya = { 4.70, 4.40, 4.30, 4.00, 3.80, 3.50, 3.20, 2.70, 2.30, 1.90, 1.70 };
        double[] seriSetia = { 4.80, 4.60, 4.40, 4.10, 4.00, 3.70, 3.40, 2.90, 2.40, 2.10, 2.10, 1.30, 0 };
        double[] kgDatoHarun = { 4.90, 4.60, 4.50, 4.20, 4.10, 3.80, 3.40, 3.00, 2.50, 2.20, 2.10, 1.50, 1.10, 0 };
        double[] jlnTemper = { 5.30, 5.00, 4.90, 4.60, 4.50, 4.20, 3.80, 3.40, 2.90, 2.30, 2.10, 1.90, 1.90, 1.80 };
        double[] petaling = { 5.40, 5.20, 5.00, 4.70, 4.60, 4.30, 4.00, 3.50, 3.00, 2.40, 2.30, 1.90, 1.90, 1.80, 1.20, 0 };
        double[] pantaiDalam = { 5.60, 5.30, 5.20, 4.90, 4.80, 4.50, 4.10, 3.70, 3.20, 2.60, 2.40, 2.10, 2.10, 1.80, 1.60, 1.30, 0 };
        double[] angkasapuri = { 5.90, 5.60, 5.40, 5.20, 5.00, 4.70, 4.40, 3.90, 3.50, 2.90, 2.40, 2.40, 2.20, 2.10, 2.10, 2.00, 1.50, 0 };
        double[] klSentral = { 6.40, 6.10, 6.00, 5.70, 5.50, 5.20, 4.90, 4.40, 4.00, 3.40, 2.90, 2.60, 2.40, 2.40, 2.30, 2.10, 1.90, 1.90, 0 };
        double[] kualaLumpur = { 6.50, 6.20, 6.10, 5.80, 5.70, 5.40, 5.00, 4.60, 4.10, 3.50, 3.10, 2.70, 2.60, 2.50, 2.30, 2.30, 2.10, 2.00, 1.20, 0 };
        double[] bankNegara = { 6.70, 6.50, 6.30, 6.00, 5.90, 5.60, 5.30, 4.80, 4.30, 3.70, 3.30, 3.00, 2.80, 2.70, 2.30, 2.30, 2.30, 2.00, 1.80, 1.50, 0 };
        double[] putra = { 6.90, 6.60, 6.50, 6.20, 6.10, 5.80, 5.40, 4.90, 4.50, 3.90, 3.50, 3.10, 3.00, 2.90, 2.50, 2.40, 2.40, 2.20, 2.00, 1.80, 1.30, 0 };
        double[] sentul = { 7.10, 6.90, 6.80, 6.50, 6.40, 6.10, 5.70, 5.20, 4.80, 4.20, 3.80, 3.40, 3.30, 3.20, 2.80, 2.70, 2.50, 2.20, 2.00, 1.80, 1.80, 1.60, 0 };
        double[] batuKentonmen = { 7.10, 7.00, 7.00, 6.80, 6.60, 6.30, 6.00, 5.50, 5.00, 4.50, 4.00, 3.70, 3.50, 3.40, 3.10, 2.90, 2.80, 2.50, 2.30, 2.10, 1.80, 1.80, 1.60, 0 };
        double[] kgBatu = { 7.20, 7.00, 7.00, 6.90, 6.80, 6.50, 6.10, 5.60, 5.20, 4.60, 4.10, 3.80, 3.70, 3.60, 3.20, 3.10, 2.90, 2.60, 2.30, 2.30, 2.00, 2.00, 1.80, 1.20, 0 };
        double[] tamanWahyu = { 7.40, 7.20, 7.00, 7.00, 6.90, 6.60, 6.30, 5.80, 5.30, 4.70, 4.30, 4.00, 3.80, 3.70, 3.30, 3.20, 3.00, 2.80, 2.30, 2.30, 2.00, 2.00, 2.00, 1.60, 1.30, 0 };
        double[] batuCaves = { 7.70, 7.50, 7.40, 7.10, 7.00, 7.00, 6.60, 6.20, 5.70, 5.10, 4.70, 4.30, 4.20, 4.10, 3.70, 3.60, 3.40, 3.10, 2.60, 2.50, 2.30, 2.30, 2.30, 2.30, 2.20, 1.80, 0 };
        double[] tanjungMalim = { 15.10, 14.90, 14.70, 14.50, 14.40, 14.10, 13.80, 13.40, 13.00, 12.50, 12.20, 11.90, 11.70, 11.70, 11.30, 11.20, 11.10, 10.80, 10.40, 10.30, 10.10, 10.00, 10.20, 10.40, 10.60, 10.70, 11.00, 0 };
        double[] kualaKubu = { 12.70, 12.50, 12.30, 12.10, 12.00, 11.70, 11.50, 11.00, 10.60, 10.10, 9.80, 9.50, 9.30, 9.30, 8.90, 8.80, 8.70, 8.70, 8.70, 8.70, 8.50, 8.30, 8.60, 8.60, 8.60, 8.60, 8.60, 3.70, 0 };
        double[] rasa = { 11.90, 11.60, 11.50, 11.30, 11.20, 10.90, 10.60, 10.20, 9.80, 9.30, 8.90, 8.60, 8.60, 8.60, 8.60, 8.60, 8.60, 8.40, 7.90, 7.80, 7.50, 7.40, 7.70, 7.90, 8.00, 8.20, 8.50, 4.70, 2.20, 0 };
        double[] batangKali = { 11.50, 11.30, 11.20, 11.00, 10.80, 10.60, 10.30, 9.90, 9.50, 9.00, 8.60, 8.60, 8.60, 8.60, 8.50, 8.40, 8.30, 8.00, 7.50, 7.40, 7.20, 7.00, 7.30, 7.60, 7.70, 7.80, 8.20, 5.00, 2.20, 1.80, 0 };
        double[] serendah = { 10.00, 9.80, 9.70, 9.50, 9.40, 9.10, 8.80, 9.20, 8.80, 8.20, 7.80, 7.50, 7.30, 7.30, 7.20, 7.10, 6.90, 6.60, 6.10, 6.00, 5.80, 5.60, 5.90, 6.20, 6.30, 6.40, 6.80, 6.80, 4.00, 3.00, 2.60, 0 };
        double[] rawang = { 9.10, 8.90, 8.80, 8.60, 8.60, 8.60, 8.60, 8.20, 7.80, 7.20, 7.10, 6.80, 6.60, 6.50, 6.10, 6.00, 5.80, 5.60, 5.10, 4.90, 4.70, 4.50, 4.80, 5.10, 5.20, 5.40, 5.80, 7.50, 5.00, 4.10, 3.70, 2.30, 0 };
        double[] kuang = { 9.10, 8.90, 8.80, 8.50, 8.40, 8.10, 7.80, 7.30, 7.20, 6.60, 6.20, 5.80, 5.70, 5.60, 5.20, 5.10, 4.90, 4.60, 4.10, 4.00, 3.80, 3.60, 3.90, 4.20, 4.30, 4.50, 4.80, 8.40, 6.00, 5.00, 4.60, 2.90, 2.10, 0 };
        double[] sungaiBuloh = { 8.30, 8.10, 8.00, 7.70, 7.60, 7.30, 7.00, 6.80, 6.30, 5.70, 5.30, 5.00, 4.80, 4.70, 4.30, 4.20, 4.00, 3.80, 3.30, 3.10, 2.90, 2.70, 3.00, 3.30, 3.40, 3.60, 4.00, 9.00, 6.80, 5.90, 5.50, 3.80, 2.70, 2.00, 0 };
        double[] kepongSentral = { 7.60, 7.40, 7.20, 7.00, 7.00, 6.90, 6.50, 6.00, 5.60, 5.00, 4.50, 4.20, 4.10, 4.00, 3.60, 3.50, 3.30, 3.00, 2.50, 2.40, 2.40, 2.30, 2.30, 2.60, 2.70, 2.80, 3.20, 9.00, 7.30, 6.60, 6.20, 4.50, 3.50, 2.50, 1.90, 0 };
        double[] kepong = { 7.50, 7.20, 7.10, 7.00, 7.00, 6.70, 6.40, 5.90, 5.40, 4.80, 4.40, 4.10, 3.90, 3.80, 3.40, 3.30, 3.10, 2.90, 2.40, 2.20, 2.20, 2.10, 2.30, 2.40, 2.50, 2.70, 3.10, 9.20, 7.40, 6.80, 6.40, 4.70, 3.60, 2.70, 2.10, 1.30, 0 };
        double[] segambut = { 7.10, 7.10, 7.00, 6.70, 6.60, 6.30, 5.90, 5.40, 5.00, 4.40, 4.00, 3.60, 3.50, 3.40, 3.00, 2.90, 2.70, 2.40, 2.20, 2.10, 2.10, 1.90, 1.90, 2.30, 2.30, 2.30, 2.60, 9.50, 7.80, 7.20, 6.80, 5.10, 4.00, 3.10, 2.20, 2.20, 2.00, 0 };
        double[] midValley = { 6.60, 6.40, 6.20, 6.00, 5.80, 5.50, 5.20, 4.70, 4.20, 3.70, 3.20, 2.90, 2.70, 2.60, 2.30, 2.30, 2.30, 1.90, 1.60, 1.80, 1.80, 1.90, 2.30, 2.30, 2.40, 2.50, 2.90, 10.60, 8.70, 8.10, 7.80, 6.40, 5.30, 4.40, 3.50, 2.80, 2.60, 2.30, 0 };
        double[] seputeh = { 6.70, 6.50, 6.30, 6.00, 5.90, 5.60, 5.30, 4.80, 4.30, 3.70, 3.30, 3.00, 3.00, 2.70, 2.30, 2.30, 2.30, 2.00, 1.80, 1.80, 1.80, 2.00, 2.30, 2.30, 2.50, 2.60, 3.00, 10.70, 8.70, 8.20, 7.90, 6.50, 5.40, 4.50, 3.60, 2.90, 2.70, 2.30, 1.10, 0 };
        double[] salakSelatan = { 7.10, 6.90, 6.70, 6.40, 6.30, 6.00, 5.70, 5.20, 4.70, 4.10, 3.70, 3.40, 3.20, 3.10, 2.70, 2.60, 2.40, 2.40, 1.90, 2.00, 2.30, 2.50, 2.50, 2.70, 2.90, 3.00, 3.40, 11.10, 8.70, 8.60, 8.20, 6.90, 5.80, 4.90, 4.00, 3.30, 3.10, 2.70, 1.90, 1.90, 0 };
        double[] btSelatan = { 7.20, 7.00, 7.00, 6.80, 6.70, 6.40, 6.10, 5.60, 5.10, 4.50, 4.10, 3.80, 3.60, 3.50, 3.10, 3.00, 2.80, 2.60, 2.40, 2.40, 2.40, 2.60, 2.90, 3.10, 3.30, 3.40, 3.80, 11.40, 9.00, 8.90, 8.50, 7.00, 6.20, 5.30, 4.40, 3.70, 3.50, 3.10, 2.00, 1.90, 1.90, 0 };
        double[] serdang = { 8.00, 7.70, 7.60, 7.30, 7.20, 7.20, 6.90, 6.40, 5.90, 5.30, 4.90, 4.60, 4.40, 4.30, 3.90, 3.80, 3.60, 3.40, 2.90, 3.00, 3.20, 3.40, 3.70, 4.00, 4.10, 4.20, 4.60, 12.10, 9.70, 8.90, 8.50, 7.70, 7.00, 6.10, 5.20, 4.50, 4.30, 3.90, 2.60, 2.50, 2.50, 1.90, 0 };
        double[] kajang = { 9.00, 8.70, 8.60, 8.60, 8.50, 8.20, 7.90, 7.40, 7.00, 6.70, 6.20, 5.90, 5.80, 5.70, 5.30, 5.10, 5.00, 4.70, 4.20, 4.30, 4.60, 4.70, 5.00, 5.30, 5.40, 5.60, 5.90, 13.20, 10.80, 10.00, 9.70, 8.80, 8.00, 7.10, 6.60, 5.80, 5.70, 5.20, 3.90, 3.80, 3.40, 3.00, 2.20, 0 };
        double[] ukm = { 9.00, 8.70, 8.60, 8.60, 8.60, 8.50, 8.50, 8.00, 7.60, 7.00, 6.90, 6.50, 6.40, 6.30, 5.90, 5.80, 5.60, 5.30, 4.80, 5.00, 5.20, 5.40, 5.70, 5.90, 6.10, 6.20, 6.60, 13.80, 11.40, 10.60, 10.20, 8.80, 8.60, 7.70, 7.20, 6.50, 6.30, 5.90, 4.60, 4.50, 4.10, 3.70, 2.90, 2.50, 0 };
        double[] bangi = { 9.50, 9.30, 9.20, 8.90, 8.80, 8.50, 8.50, 8.50, 8.20, 7.60, 7.20, 7.20, 7.00, 6.90, 6.50, 6.40, 6.20, 6.00, 5.50, 5.60, 5.80, 6.00, 6.30, 6.60, 6.70, 6.80, 7.20, 14.30, 11.90, 11.10, 10.80, 9.30, 9.20, 8.30, 7.50, 7.10, 6.90, 6.50, 5.20, 5.10, 4.70, 4.30, 3.50, 2.50, 2.40, 0 };
        double[] batangBenar = { 10.60, 10.40, 10.30, 10.00, 9.90, 9.70, 9.40, 9.00, 8.60, 8.60, 8.40, 8.10, 8.00, 7.90, 7.50, 7.40, 7.20, 7.00, 6.80, 6.90, 7.00, 7.00, 7.30, 7.50, 7.60, 7.80, 8.10, 15.40, 13.10, 12.20, 11.90, 10.40, 9.50, 8.70, 8.70, 8.00, 7.90, 7.50, 6.50, 6.40, 6.00, 5.60, 4.80, 3.50, 2.80, 2.60, 0 };
        double[] nilai = { 11.10, 10.90, 10.80, 10.50, 10.40, 10.20, 9.90, 9.50, 9.10, 8.60, 8.60, 8.60, 8.50, 8.40, 8.10, 7.90, 7.80, 7.50, 7.00, 7.20, 7.40, 7.50, 7.80, 8.10, 8.20, 8.30, 8.70, 15.90, 13.50, 12.70, 12.40, 10.90, 10.00, 9.20, 9.20, 8.60, 8.40, 8.00, 7.00, 7.00, 6.60, 6.20, 5.40, 4.10, 3.40, 2.80, 2.30, 0 };
        double[] labu = { 11.90, 11.60, 11.50, 11.30, 11.20, 10.90, 10.60, 10.20, 9.80, 9.30, 8.90, 8.60, 8.50, 8.50, 8.50, 8.50, 8.50, 8.40, 7.90, 8.00, 8.20, 8.40, 8.70, 8.70, 8.70, 8.70, 8.70, 16.70, 14.30, 13.50, 13.10, 11.70, 10.70, 10.00, 9.20, 8.60, 8.60, 8.60, 7.60, 7.50, 7.20, 7.10, 6.30, 4.90, 4.30, 3.70, 2.40, 2.00, 0 };
        double[] tiroi = { 12.40, 12.20, 12.10, 11.90, 11.70, 11.50, 11.20, 10.80, 10.40, 9.90, 9.50, 9.20, 9.10, 9.00, 8.70, 8.60, 8.60, 8.60, 8.50, 8.60, 8.60, 8.60, 8.70, 8.70, 8.80, 8.90, 9.20, 17.30, 14.90, 14.00, 13.70, 12.20, 11.30, 10.50, 9.80, 9.10, 9.00, 8.60, 8.30, 8.20, 7.80, 7.40, 6.90, 5.60, 5.00, 4.30, 3.00, 2.40, 2.40, 0 };
        double[] seremban = { 13.40, 13.20, 13.00, 12.80, 12.70, 12.40, 12.10, 11.70, 11.30, 10.80, 10.50, 10.20, 10.00, 10.00, 9.60, 9.50, 9.40, 9.10, 8.70, 8.80, 9.00, 9.10, 9.40, 9.60, 9.70, 9.90, 10.20, 18.20, 15.80, 15.00, 14.70, 13.20, 12.30, 11.50, 10.70, 10.10, 10.00, 9.60, 8.70, 8.70, 8.60, 8.50, 7.70, 6.70, 6.10, 5.40, 4.10, 3.60, 2.70, 2.30, 0 };
        double[] senawang = { 13.90, 13.70, 13.60, 13.30, 13.20, 13.00, 12.70, 12.30, 11.90, 11.40, 11.00, 10.70, 10.60, 10.50, 10.20, 10.10, 9.90, 9.70, 9.20, 9.40, 9.50, 9.70, 9.90, 10.20, 10.30, 10.40, 10.70, 18.70, 16.40, 15.50, 15.20, 13.70, 12.80, 12.00, 11.30, 10.60, 10.50, 10.10, 9.00, 8.90, 8.60, 8.60, 8.30, 7.00, 6.70, 6.10, 4.80, 4.20, 3.30, 2.60, 2.40, 0 };
        double[] sungaiGadut = { 14.40, 14.20, 14.00, 13.80, 13.70, 13.40, 13.10, 12.70, 12.30, 11.80, 11.50, 11.20, 11.00, 11.00, 10.60, 10.50, 10.40, 10.10, 9.70, 9.80, 10.00, 10.10, 10.40, 10.60, 10.70, 10.90, 11.20, 19.20, 16.80, 16.00, 15.70, 14.20, 13.30, 12.50, 11.70, 11.10, 11.00, 10.60, 9.50, 9.40, 9.10, 8.70, 8.70, 7.50, 7.20, 6.60, 5.30, 4.70, 3.80, 3.20, 2.40, 2.20, 0 };
        double[] rembau = { 16.00, 15.80, 15.60, 15.40, 15.30, 15.00, 14.70, 14.30, 13.90, 13.40, 13.10, 12.80, 12.60, 12.60, 12.20, 12.10, 12.00, 11.70, 11.30, 11.40, 11.60, 11.70, 12.00, 12.20, 12.30, 12.50, 12.80, 20.80, 18.40, 17.60, 17.30, 15.80, 14.90, 14.10, 13.30, 12.70, 12.60, 12.20, 11.10, 11.00, 10.70, 10.30, 10.30, 9.10, 8.80, 8.20, 6.90, 6.30, 5.40, 4.80, 4.00, 3.80, 1.60, 0 };
        double[] tampin = { 18.40, 18.20, 18.00, 17.80, 17.70, 17.40, 17.10, 16.70, 16.30, 15.80, 15.50, 15.20, 15.00, 15.00, 14.60, 14.50, 14.40, 14.10, 13.70, 13.80, 14.00, 14.10, 14.40, 14.60, 14.70, 14.90, 15.20, 23.20, 20.80, 20.00, 19.70, 18.20, 17.30, 16.50, 15.70, 15.10, 15.00, 14.60, 13.50, 13.40, 13.10, 12.70, 12.70, 11.50, 11.20, 10.60, 9.30, 8.70, 7.80, 7.20, 6.40, 6.20, 4.00, 2.80, 0 };
        double[] btgMelaka = { 20.00, 19.80, 19.60, 19.40, 19.30, 19.00, 18.70, 18.30, 17.90, 17.40, 17.10, 16.80, 16.60, 16.60, 16.20, 16.10, 16.00, 15.70, 15.30, 15.40, 15.60, 15.70, 16.00, 16.20, 16.30, 16.50, 16.80, 24.80, 22.40, 21.60, 21.30, 19.80, 18.90, 18.10, 17.30, 16.70, 16.60, 16.20, 15.10, 15.00, 14.70, 14.30, 14.30, 13.10, 12.80, 12.20, 10.90, 10.30, 9.40, 8.80, 8.00, 7.80, 5.60, 5.00, 2.80, 0 };
        double[] gemas = { 21.70, 21.50, 21.30, 21.10, 21.00, 20.70, 20.40, 20.00, 19.60, 19.10, 18.80, 18.50, 18.30, 18.30, 17.90, 17.80, 17.70, 17.40, 17.00, 17.10, 17.30, 17.40, 17.70, 17.90, 18.00, 18.20, 18.50, 26.50, 24.10, 23.30, 23.00, 21.50, 20.60, 19.80, 19.00, 18.40, 18.30, 17.90, 16.80, 16.70, 16.40, 16.00, 16.00, 14.80, 14.50, 13.90, 12.60, 12.00, 11.10, 10.50, 9.70, 9.50, 7.30, 6.40, 4.70, 2.90, 0 };

        double total, grandSuperTotal, grandTotal, totalPrice, totalprices;
        int from, to, category, passenger, returnDate;


        protected void lnkpickdate_Clink(object sender, EventArgs e)
        {
            datePicker.Visible = false;
            CalculateDistance();
        }

        protected void datePicker_SelectionChanged(object sender, EventArgs e)
        {
            lbldateONGoing.Text = datePicker.SelectedDate.ToLongDateString();
            datePicker.Visible = false;
            CalculateDistance();
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            CalculateDistance();
        }

        protected void ddlReturnYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        protected void ddlTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        protected void ddlFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }
  
        private void CalculateDistance()
        {



            from = ddlFrom.SelectedIndex;
            to = ddlTo.SelectedIndex;


           
            lblPrice.Text = totalprices.ToString("0.00");
            lblTicketFrom.Text = ddlFrom.SelectedValue;
            lblTicketTo.Text = ddlTo.SelectedValue;

            lblForPeople.Text = ddlHowMany.SelectedValue;

            category = ddlCategory.SelectedIndex;
            passenger = ddlHowMany.SelectedIndex;
            returnDate = ddlonetwoticket.SelectedIndex;

            /////////Calculation Category//////////////////////
            ///
            


            //pelklang//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (from == 0)
            {
                if (to == 1)
                {
                    total = jlnKastam[0];


                }
                else if (to == 2)
                {
                    total = kgRajaUda[0];
                }
                else if (to == 3)
                {
                    total = telukGadong[0];


                }
                else if (to == 4)
                {
                    total = telukPulai[0];

                }
                else if (to == 5)
                {
                    total = klang[0];

                }
                else if (to == 6)
                {
                    total = bukitBadak[0];

                }
                else if (to == 7)
                {
                    total = padangJawa[0];
                }
                else if (to == 8)
                {
                    total = shahAlam[0];
                }
                else if (to == 9)
                {
                    total = batuTiga[0];
                }
                else if (to == 10)
                {
                    total = subangJaya[0];
                }
                else if (to == 11)
                {
                    total = setiaJaya[0];
                }
                else if (to == 12)
                {
                    total = seriSetia[0];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[0];
                }
                else if (to == 14)
                {
                    total = jlnTemper[0];
                }
                else if (to == 15)
                {
                    total = petaling[0];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[0];

                }
                else if (to == 17)
                {
                    total = angkasapuri[0];
                }
                else if (to == 18)
                {
                    total = klSentral[0];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[0];
                }
                else if (to == 20)
                {
                    total = bankNegara[0];
                }
                else if (to == 21)
                {
                    total = putra[0];
                }
                else if (to == 22)
                {
                    total = sentul[0];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[0];
                }
                else if (to == 24)
                {
                    total = kgBatu[0];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[0];
                }
                else if (to == 26)
                {
                    total = batuCaves[0];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[0];

                }
                else if (to == 28)
                {
                    total = kualaKubu[0];
                }
                else if (to == 29)
                {
                    total = rasa[0];
                }
                else if (to == 30)
                {
                    total = batangKali[0];
                }
                else if (to == 31)
                {
                    total = serendah[0];
                }
                else if (to == 32)
                {
                    total = rawang[0];
                }
                else if (to == 34)
                {
                    total = kuang[0];

                }
                else if (to == 35)
                {
                    total = sungaiBuloh[0];
                }
                else if (to == 36)
                {
                    total = kepongSentral[0];

                }
                else if (to == 37)
                {
                    total = kepong[0];
                }
                else if (to == 38)
                {
                    total = segambut[0];
                }
                else if (to == 39)
                {
                    total = midValley[0];
                }
                else if (to == 40)
                {
                    total = seputeh[0];
                }
                else if (to == 41)
                {
                    total = salakSelatan[0];
                }
                else if (to == 42)
                {
                    total = btSelatan[0];
                }
                else if (to == 43)
                {
                    total = serdang[0];
                }
                else if (to == 43)
                {
                    total = kajang[0];
                }
                else if (to == 44)
                {
                    total = ukm[0];
                }

                else if (to == 45)
                {
                    total = bangi[0];
                }
                else if (to == 46)
                {
                    total = batangBenar[0];
                }
                else if (to == 47)
                {
                    total = nilai[0];
                }
                else if (to == 48)
                {
                    total = labu[0];
                }
                else if (to == 49)
                {
                    total = tiroi[0];
                }
                else if (to == 50)
                {
                    total = seremban[0];
                }
                else if (to == 51)
                {
                    total = senawang[0];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[0];
                }
                else if (to == 53)
                {
                    total = rembau[0];
                }
                else if (to == 54)
                {
                    total = tampin[0];
                }
                else if (to == 55)
                {
                    total = btgMelaka[0];
                }
                else if (to == 56)
                {
                    total = gemas[0];
                }
                //jlnKastam//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else if (from == 1)
            {
                if (to == 0)
                {
                    total = pelKlang[0];
                }
                else if (to == 2)
                {
                    total = kgRajaUda[1];
                }
                else if (to == 3)
                {
                    total = telukGadong[1];
                }
                else if (to == 4)
                {
                    total = telukPulai[1];
                }
                else if (to == 5)
                {
                    total = klang[1];
                }
                else if (to == 6)
                {
                    total = bukitBadak[1];
                }
                else if (to == 7)
                {
                    total = padangJawa[1];
                }
                else if (to == 8)
                {
                    total = shahAlam[1];
                }
                else if (to == 9)
                {
                    total = batuTiga[1];
                }
                else if (to == 10)
                {
                    total = subangJaya[1];
                }
                else if (to == 11)
                {
                    total = setiaJaya[1];
                }
                else if (to == 12)
                {
                    total = seriSetia[1];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[1];
                }
                else if (to == 14)
                {
                    total = jlnTemper[1];
                }
                else if (to == 15)
                {
                    total = petaling[1];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[1];

                }
                else if (to == 17)
                {
                    total = angkasapuri[1];
                }
                else if (to == 18)
                {
                    total = klSentral[1];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[1];
                }
                else if (to == 20)
                {
                    total = bankNegara[1];
                }
                else if (to == 21)
                {
                    total = putra[1];
                }
                else if (to == 22)
                {
                    total = sentul[1];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[1];
                }
                else if (to == 24)
                {
                    total = kgBatu[1];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[1];
                }
                else if (to == 26)
                {
                    total = batuCaves[1];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[1];

                }
                else if (to == 28)
                {
                    total = kualaKubu[1];
                }
                else if (to == 29)
                {
                    total = rasa[1];
                }
                else if (to == 30)
                {
                    total = batangKali[1];
                }
                else if (to == 31)
                {
                    total = serendah[1];
                }
                else if (to == 32)
                {
                    total = rawang[1];
                }
                else if (to == 33)
                {
                    total = kuang[1];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[1];
                }
                else if (to == 35)
                {
                    total = kepongSentral[01];

                }
                else if (to == 36)
                {
                    total = kepong[1];
                }
                else if (to == 37)
                {
                    total = segambut[1];
                }
                else if (to == 38)
                {
                    total = midValley[1];
                }
                else if (to == 39)
                {
                    total = seputeh[1];
                }
                else if (to == 40)
                {
                    total = salakSelatan[1];
                }
                else if (to == 41)
                {
                    total = btSelatan[1];
                }
                else if (to == 42)
                {
                    total = serdang[1];
                }
                else if (to == 43)
                {
                    total = kajang[1];
                }
                else if (to == 44)
                {
                    total = ukm[1];
                }

                else if (to == 45)
                {
                    total = bangi[1];
                }
                else if (to == 46)
                {
                    total = batangBenar[1];
                }
                else if (to == 47)
                {
                    total = nilai[1];
                }
                else if (to == 48)
                {
                    total = labu[1];
                }
                else if (to == 49)
                {
                    total = tiroi[1];
                }
                else if (to == 50)
                {
                    total = seremban[1];
                }
                else if (to == 51)
                {
                    total = senawang[1];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[1];
                }
                else if (to == 53)
                {
                    total = rembau[1];
                }
                else if (to == 54)
                {
                    total = tampin[1];
                }
                else if (to == 55)
                {
                    total = btgMelaka[1];
                }
                else if (to == 56)
                {
                    total = gemas[1];
                }
                ////////////////////kgrajauda/////////////////////////////////////////////////////////////////////////////
            }
            else if (from == 2)
            {
                if (to == 0)
                {
                    total = kgRajaUda[0];
                }
                else if (to == 1)
                {
                    total = kgRajaUda[1];
                }
                else if (to == 3)
                {
                    total = telukGadong[2];
                }
                else if (to == 4)
                {
                    total = telukPulai[2];
                }
                else if (to == 5)
                {
                    total = klang[2];
                }
                else if (to == 6)
                {
                    total = bukitBadak[2];
                }
                else if (to == 7)
                {
                    total = padangJawa[2];
                }
                else if (to == 8)
                {
                    total = shahAlam[2];
                }
                else if (to == 9)
                {
                    total = batuTiga[2];
                }
                else if (to == 10)
                {
                    total = subangJaya[2];
                }
                else if (to == 11)
                {
                    total = setiaJaya[2];
                }
                else if (to == 12)
                {
                    total = seriSetia[2];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[2];
                }
                else if (to == 14)
                {
                    total = jlnTemper[2];
                }
                else if (to == 15)
                {
                    total = petaling[2];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[2];

                }
                else if (to == 17)
                {
                    total = angkasapuri[2];
                }
                else if (to == 18)
                {
                    total = klSentral[2];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[2];
                }
                else if (to == 20)
                {
                    total = bankNegara[2];
                }
                else if (to == 21)
                {
                    total = putra[2];
                }
                else if (to == 22)
                {
                    total = sentul[2];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[2];
                }
                else if (to == 24)
                {
                    total = kgBatu[2];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[2];
                }
                else if (to == 26)
                {
                    total = batuCaves[2];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[2];

                }
                else if (to == 28)
                {
                    total = kualaKubu[2];
                }
                else if (to == 29)
                {
                    total = rasa[2];
                }
                else if (to == 30)
                {
                    total = batangKali[2];
                }
                else if (to == 31)
                {
                    total = serendah[2];
                }
                else if (to == 32)
                {
                    total = rawang[2];
                }
                else if (to == 33)
                {
                    total = kuang[2];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[2];
                }
                else if (to == 35)
                {
                    total = kepongSentral[2];

                }
                else if (to == 36)
                {
                    total = kepong[2];
                }
                else if (to == 37)
                {
                    total = segambut[2];
                }
                else if (to == 38)
                {
                    total = midValley[2];
                }
                else if (to == 39)
                {
                    total = seputeh[2];
                }
                else if (to == 40)
                {
                    total = salakSelatan[2];
                }
                else if (to == 41)
                {
                    total = btSelatan[2];
                }
                else if (to == 42)
                {
                    total = serdang[2];
                }
                else if (to == 43)
                {
                    total = kajang[2];
                }
                else if (to == 44)
                {
                    total = ukm[2];
                }

                else if (to == 45)
                {
                    total = bangi[2];
                }
                else if (to == 46)
                {
                    total = batangBenar[2];
                }
                else if (to == 47)
                {
                    total = nilai[2];
                }
                else if (to == 48)
                {
                    total = labu[2];
                }
                else if (to == 49)
                {
                    total = tiroi[2];
                }
                else if (to == 50)
                {
                    total = seremban[2];
                }
                else if (to == 51)
                {
                    total = senawang[2];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[2];
                }
                else if (to == 53)
                {
                    total = rembau[2];
                }
                else if (to == 54)
                {
                    total = tampin[2];
                }
                else if (to == 55)
                {
                    total = btgMelaka[2];
                }
                else if (to == 56)
                {
                    total = gemas[2];
                }
            }
            //teluk gadong//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (from == 3)
            {
                if (to == 0)
                {
                    total = telukGadong[0];
                }
                else if (to == 1)
                {
                    total = telukGadong[1];
                }
                else if (to == 2)
                {
                    total = telukGadong[2];
                }
                else if (to == 4)
                {
                    total = telukPulai[3];
                }
                else if (to == 5)
                {
                    total = klang[3];
                }
                else if (to == 6)
                {
                    total = bukitBadak[3];
                }
                else if (to == 7)
                {
                    total = padangJawa[3];
                }
                else if (to == 8)
                {
                    total = shahAlam[3];
                }
                else if (to == 9)
                {
                    total = batuTiga[3];
                }
                else if (to == 10)
                {
                    total = subangJaya[3];
                }
                else if (to == 11)
                {
                    total = setiaJaya[3];
                }
                else if (to == 12)
                {
                    total = seriSetia[3];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[3];
                }
                else if (to == 14)
                {
                    total = jlnTemper[3];
                }
                else if (to == 15)
                {
                    total = petaling[3];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[3];

                }
                else if (to == 17)
                {
                    total = angkasapuri[3];
                }
                else if (to == 18)
                {
                    total = klSentral[3];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[3];
                }
                else if (to == 20)
                {
                    total = bankNegara[3];
                }
                else if (to == 21)
                {
                    total = putra[3];
                }
                else if (to == 22)
                {
                    total = sentul[3];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[3];
                }
                else if (to == 24)
                {
                    total = kgBatu[3];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[3];
                }
                else if (to == 26)
                {
                    total = batuCaves[3];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[3];

                }
                else if (to == 28)
                {
                    total = kualaKubu[3];
                }
                else if (to == 29)
                {
                    total = rasa[3];
                }
                else if (to == 30)
                {
                    total = batangKali[3];
                }
                else if (to == 31)
                {
                    total = serendah[3];
                }
                else if (to == 32)
                {
                    total = rawang[3];
                }
                else if (to == 33)
                {
                    total = kuang[3];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[3];
                }
                else if (to == 35)
                {
                    total = kepongSentral[3];

                }
                else if (to == 36)
                {
                    total = kepong[3];
                }
                else if (to == 37)
                {
                    total = segambut[3];
                }
                else if (to == 38)
                {
                    total = midValley[3];
                }
                else if (to == 39)
                {
                    total = seputeh[3];
                }
                else if (to == 40)
                {
                    total = salakSelatan[3];
                }
                else if (to == 41)
                {
                    total = btSelatan[3];
                }
                else if (to == 42)
                {
                    total = serdang[3];
                }
                else if (to == 43)
                {
                    total = kajang[3];
                }
                else if (to == 44)
                {
                    total = ukm[3];
                }

                else if (to == 45)
                {
                    total = bangi[3];
                }
                else if (to == 46)
                {
                    total = batangBenar[3];
                }
                else if (to == 47)
                {
                    total = nilai[3];
                }
                else if (to == 48)
                {
                    total = labu[3];
                }
                else if (to == 49)
                {
                    total = tiroi[3];
                }
                else if (to == 50)
                {
                    total = seremban[3];
                }
                else if (to == 51)
                {
                    total = senawang[3];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[3];
                }
                else if (to == 53)
                {
                    total = rembau[3];
                }
                else if (to == 54)
                {
                    total = tampin[3];
                }
                else if (to == 55)
                {
                    total = btgMelaka[3];
                }
                else if (to == 56)
                {
                    total = gemas[3];
                }
            }///////////////////////telukpulai/////////////////////////////////////////////
            else if (from == 4)
            {
                if (to == 0)
                {
                    total = telukPulai[0];
                }
                else if (to == 1)
                {
                    total = telukPulai[1];
                }
                else if (to == 2)
                {
                    total = telukPulai[2];
                }
                else if (to == 3)
                {
                    total = telukPulai[3];
                }
                else if (to == 5)
                {
                    total = klang[4];
                }
                else if (to == 6)
                {
                    total = bukitBadak[4];
                }
                else if (to == 7)
                {
                    total = padangJawa[4];
                }
                else if (to == 8)
                {
                    total = shahAlam[4];
                }
                else if (to == 9)
                {
                    total = batuTiga[4];
                }
                else if (to == 10)
                {
                    total = subangJaya[4];
                }
                else if (to == 11)
                {
                    total = setiaJaya[4];
                }
                else if (to == 12)
                {
                    total = seriSetia[4];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[4];
                }
                else if (to == 14)
                {
                    total = jlnTemper[4];
                }
                else if (to == 15)
                {
                    total = petaling[4];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[4];

                }
                else if (to == 17)
                {
                    total = angkasapuri[4];
                }
                else if (to == 18)
                {
                    total = klSentral[4];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[4];
                }
                else if (to == 20)
                {
                    total = bankNegara[4];
                }
                else if (to == 21)
                {
                    total = putra[4];
                }
                else if (to == 22)
                {
                    total = sentul[4];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[4];
                }
                else if (to == 24)
                {
                    total = kgBatu[4];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[4];
                }
                else if (to == 26)
                {
                    total = batuCaves[4];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[4];

                }
                else if (to == 28)
                {
                    total = kualaKubu[4];
                }
                else if (to == 29)
                {
                    total = rasa[4];
                }
                else if (to == 30)
                {
                    total = batangKali[4];
                }
                else if (to == 31)
                {
                    total = serendah[4];
                }
                else if (to == 32)
                {
                    total = rawang[4];
                }
                else if (to == 33)
                {
                    total = kuang[4];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[4];
                }
                else if (to == 35)
                {
                    total = kepongSentral[4];

                }
                else if (to == 36)
                {
                    total = kepong[4];
                }
                else if (to == 37)
                {
                    total = segambut[4];
                }
                else if (to == 38)
                {
                    total = midValley[4];
                }
                else if (to == 39)
                {
                    total = seputeh[4];
                }
                else if (to == 40)
                {
                    total = salakSelatan[4];
                }
                else if (to == 41)
                {
                    total = btSelatan[4];
                }
                else if (to == 42)
                {
                    total = serdang[4];
                }
                else if (to == 43)
                {
                    total = kajang[4];
                }
                else if (to == 44)
                {
                    total = ukm[4];
                }

                else if (to == 45)
                {
                    total = bangi[4];
                }
                else if (to == 46)
                {
                    total = batangBenar[4];
                }
                else if (to == 47)
                {
                    total = nilai[4];
                }
                else if (to == 48)
                {
                    total = labu[4];
                }
                else if (to == 49)
                {
                    total = tiroi[4];
                }
                else if (to == 50)
                {
                    total = seremban[4];
                }
                else if (to == 51)
                {
                    total = senawang[4];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[4];
                }
                else if (to == 53)
                {
                    total = rembau[4];
                }
                else if (to == 54)
                {
                    total = tampin[4];
                }
                else if (to == 55)
                {
                    total = btgMelaka[4];
                }
                else if (to == 56)
                {
                    total = gemas[4];
                }
                ///////////////////klang////////////////////////////////////
            }
            else if (from == 5)
            {
                if (to == 0)
                {
                    total = klang[0];
                }
                else if (to == 1)
                {
                    total = klang[1];
                }
                else if (to == 2)
                {
                    total = klang[2];
                }
                else if (to == 3)
                {
                    total = klang[3];
                }
                else if (to == 4)
                {
                    total = klang[4];
                }
                else if (to == 6)
                {
                    total = bukitBadak[5];
                }
                else if (to == 7)
                {
                    total = padangJawa[5];
                }
                else if (to == 8)
                {
                    total = shahAlam[5];
                }
                else if (to == 9)
                {
                    total = batuTiga[5];
                }
                else if (to == 10)
                {
                    total = subangJaya[5];
                }
                else if (to == 11)
                {
                    total = setiaJaya[5];
                }
                else if (to == 12)
                {
                    total = seriSetia[5];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[5];
                }
                else if (to == 14)
                {
                    total = jlnTemper[5];
                }
                else if (to == 15)
                {
                    total = petaling[5];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[5];

                }
                else if (to == 17)
                {
                    total = angkasapuri[5];
                }
                else if (to == 18)
                {
                    total = klSentral[5];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[5];
                }
                else if (to == 20)
                {
                    total = bankNegara[5];
                }
                else if (to == 21)
                {
                    total = putra[5];
                }
                else if (to == 22)
                {
                    total = sentul[5];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[5];
                }
                else if (to == 24)
                {
                    total = kgBatu[5];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[5];
                }
                else if (to == 26)
                {
                    total = batuCaves[5];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[5];

                }
                else if (to == 28)
                {
                    total = kualaKubu[5];
                }
                else if (to == 29)
                {
                    total = rasa[5];
                }
                else if (to == 30)
                {
                    total = batangKali[5];
                }
                else if (to == 31)
                {
                    total = serendah[5];
                }
                else if (to == 32)
                {
                    total = rawang[5];
                }
                else if (to == 33)
                {
                    total = kuang[5];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[5];
                }
                else if (to == 35)
                {
                    total = kepongSentral[5];

                }
                else if (to == 36)
                {
                    total = kepong[5];
                }
                else if (to == 37)
                {
                    total = segambut[5];
                }
                else if (to == 38)
                {
                    total = midValley[5];
                }
                else if (to == 39)
                {
                    total = seputeh[5];
                }
                else if (to == 40)
                {
                    total = salakSelatan[5];
                }
                else if (to == 41)
                {
                    total = btSelatan[5];
                }
                else if (to == 42)
                {
                    total = serdang[5];
                }
                else if (to == 43)
                {
                    total = kajang[5];
                }
                else if (to == 44)
                {
                    total = ukm[5];
                }

                else if (to == 45)
                {
                    total = bangi[5];
                }
                else if (to == 46)
                {
                    total = batangBenar[5];
                }
                else if (to == 47)
                {
                    total = nilai[5];
                }
                else if (to == 48)
                {
                    total = labu[5];
                }
                else if (to == 49)
                {
                    total = tiroi[5];
                }
                else if (to == 50)
                {
                    total = seremban[5];
                }
                else if (to == 51)
                {
                    total = senawang[5];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[5];
                }
                else if (to == 53)
                {
                    total = rembau[5];
                }
                else if (to == 54)
                {
                    total = tampin[5];
                }
                else if (to == 55)
                {
                    total = btgMelaka[5];
                }
                else if (to == 56)
                {
                    total = gemas[5];
                }
                ///////////////bukitbadak///////////////////////////////////////////////////
            }
            else if (from == 6)
            {
                if (to == 0)
                {
                    total = bukitBadak[0];
                }
                else if (to == 1)
                {
                    total = bukitBadak[1];
                }
                else if (to == 2)
                {
                    total = bukitBadak[2];
                }
                else if (to == 3)
                {
                    total = bukitBadak[3];
                }
                else if (to == 4)
                {
                    total = bukitBadak[4];
                }
                else if (to == 5)
                {
                    total = bukitBadak[5];
                }
                else if (to == 7)
                {
                    total = padangJawa[6];
                }
                else if (to == 8)
                {
                    total = shahAlam[6];
                }
                else if (to == 9)
                {
                    total = batuTiga[6];
                }
                else if (to == 10)
                {
                    total = subangJaya[6];
                }
                else if (to == 11)
                {
                    total = setiaJaya[6];
                }
                else if (to == 12)
                {
                    total = seriSetia[6];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[6];
                }
                else if (to == 14)
                {
                    total = jlnTemper[6];
                }
                else if (to == 15)
                {
                    total = petaling[6];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[6];

                }
                else if (to == 17)
                {
                    total = angkasapuri[6];
                }
                else if (to == 18)
                {
                    total = klSentral[6];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[6];
                }
                else if (to == 20)
                {
                    total = bankNegara[6];
                }
                else if (to == 21)
                {
                    total = putra[6];
                }
                else if (to == 22)
                {
                    total = sentul[6];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[6];
                }
                else if (to == 24)
                {
                    total = kgBatu[6];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[6];
                }
                else if (to == 26)
                {
                    total = batuCaves[6];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[6];

                }
                else if (to == 28)
                {
                    total = kualaKubu[6];
                }
                else if (to == 29)
                {
                    total = rasa[6];
                }
                else if (to == 30)
                {
                    total = batangKali[6];
                }
                else if (to == 31)
                {
                    total = serendah[6];
                }
                else if (to == 32)
                {
                    total = rawang[6];
                }
                else if (to == 33)
                {
                    total = kuang[6];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[6];
                }
                else if (to == 35)
                {
                    total = kepongSentral[6];

                }
                else if (to == 36)
                {
                    total = kepong[6];
                }
                else if (to == 37)
                {
                    total = segambut[6];
                }
                else if (to == 38)
                {
                    total = midValley[6];
                }
                else if (to == 39)
                {
                    total = seputeh[6];
                }
                else if (to == 40)
                {
                    total = salakSelatan[6];
                }
                else if (to == 41)
                {
                    total = btSelatan[6];
                }
                else if (to == 42)
                {
                    total = serdang[6];
                }
                else if (to == 43)
                {
                    total = kajang[6];
                }
                else if (to == 44)
                {
                    total = ukm[6];
                }

                else if (to == 45)
                {
                    total = bangi[6];
                }
                else if (to == 46)
                {
                    total = batangBenar[6];
                }
                else if (to == 47)
                {
                    total = nilai[6];
                }
                else if (to == 48)
                {
                    total = labu[6];
                }
                else if (to == 49)
                {
                    total = tiroi[6];
                }
                else if (to == 50)
                {
                    total = seremban[6];
                }
                else if (to == 51)
                {
                    total = senawang[6];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[6];
                }
                else if (to == 53)
                {
                    total = rembau[6];
                }
                else if (to == 54)
                {
                    total = tampin[6];
                }
                else if (to == 55)
                {
                    total = btgMelaka[6];
                }
                else if (to == 56)
                {
                    total = gemas[6];
                }
                ////////////////////Padang Jawa////////////////////////////////
            }
            else if (from == 7)
            {
                if (to == 0)
                {
                    total = padangJawa[1];
                }
                else if (to == 1)
                {
                    total = padangJawa[1];
                }
                else if (to == 2)
                {
                    total = padangJawa[2];
                }
                else if (to == 3)
                {
                    total = padangJawa[3];
                }
                else if (to == 4)
                {
                    total = padangJawa[4];
                }
                else if (to == 5)
                {
                    total = padangJawa[5];
                }
                else if (to == 6)
                {
                    total = padangJawa[6];
                }
                else if (to == 8)
                {
                    total = shahAlam[7];
                }
                else if (to == 9)
                {
                    total = batuTiga[7];
                }
                else if (to == 10)
                {
                    total = subangJaya[7];
                }
                else if (to == 11)
                {
                    total = setiaJaya[7];
                }
                else if (to == 12)
                {
                    total = seriSetia[7];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[7];
                }
                else if (to == 14)
                {
                    total = jlnTemper[7];
                }
                else if (to == 15)
                {
                    total = petaling[7];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[7];

                }
                else if (to == 17)
                {
                    total = angkasapuri[7];
                }
                else if (to == 18)
                {
                    total = klSentral[7];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[7];
                }
                else if (to == 20)
                {
                    total = bankNegara[7];
                }
                else if (to == 21)
                {
                    total = putra[7];
                }
                else if (to == 22)
                {
                    total = sentul[7];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[7];
                }
                else if (to == 24)
                {
                    total = kgBatu[7];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[7];
                }
                else if (to == 26)
                {
                    total = batuCaves[7];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[7];

                }
                else if (to == 28)
                {
                    total = kualaKubu[7];
                }
                else if (to == 29)
                {
                    total = rasa[7];
                }
                else if (to == 30)
                {
                    total = batangKali[7];
                }
                else if (to == 31)
                {
                    total = serendah[7];
                }
                else if (to == 32)
                {
                    total = rawang[7];
                }
                else if (to == 33)
                {
                    total = kuang[7];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[7];
                }
                else if (to == 35)
                {
                    total = kepongSentral[7];

                }
                else if (to == 36)
                {
                    total = kepong[7];
                }
                else if (to == 37)
                {
                    total = segambut[7];
                }
                else if (to == 38)
                {
                    total = midValley[7];
                }
                else if (to == 39)
                {
                    total = seputeh[7];
                }
                else if (to == 40)
                {
                    total = salakSelatan[7];
                }
                else if (to == 41)
                {
                    total = btSelatan[7];
                }
                else if (to == 42)
                {
                    total = serdang[7];
                }
                else if (to == 43)
                {
                    total = kajang[7];
                }
                else if (to == 44)
                {
                    total = ukm[7];
                }

                else if (to == 45)
                {
                    total = bangi[7];
                }
                else if (to == 46)
                {
                    total = batangBenar[7];
                }
                else if (to == 47)
                {
                    total = nilai[7];
                }
                else if (to == 48)
                {
                    total = labu[7];
                }
                else if (to == 49)
                {
                    total = tiroi[7];
                }
                else if (to == 50)
                {
                    total = seremban[7];
                }
                else if (to == 51)
                {
                    total = senawang[7];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[7];
                }
                else if (to == 53)
                {
                    total = rembau[7];
                }
                else if (to == 54)
                {
                    total = tampin[7];
                }
                else if (to == 55)
                {
                    total = btgMelaka[7];
                }
                else if (to == 56)
                {
                    total = gemas[7];
                }

            }/////////////////////////Shah Alam///////////////////////////////////////
            else if (from == 8)
            {
                if (to == 0)
                {
                    total = shahAlam[0];
                }
                else if (to == 1)
                {
                    total = shahAlam[1];
                }
                else if (to == 2)
                {
                    total = shahAlam[2];
                }
                else if (to == 3)
                {
                    total = shahAlam[3];
                }
                else if (to == 4)
                {
                    total = shahAlam[4];
                }
                else if (to == 5)
                {
                    total = shahAlam[5];
                }
                else if (to == 6)
                {
                    total = shahAlam[6];
                }
                else if (to == 7)
                {
                    total = shahAlam[7];
                }
                else if (to == 9)
                {
                    total = batuTiga[8];
                }
                else if (to == 10)
                {
                    total = subangJaya[8];
                }
                else if (to == 11)
                {
                    total = setiaJaya[8];
                }
                else if (to == 12)
                {
                    total = seriSetia[8];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[8];
                }
                else if (to == 14)
                {
                    total = jlnTemper[8];
                }
                else if (to == 15)
                {
                    total = petaling[8];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[8];

                }
                else if (to == 17)
                {
                    total = angkasapuri[8];
                }
                else if (to == 18)
                {
                    total = klSentral[8];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[8];
                }
                else if (to == 20)
                {
                    total = bankNegara[8];
                }
                else if (to == 21)
                {
                    total = putra[8];
                }
                else if (to == 22)
                {
                    total = sentul[8];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[8];
                }
                else if (to == 24)
                {
                    total = kgBatu[8];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[8];
                }
                else if (to == 26)
                {
                    total = batuCaves[8];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[8];

                }
                else if (to == 28)
                {
                    total = kualaKubu[8];
                }
                else if (to == 29)
                {
                    total = rasa[8];
                }
                else if (to == 30)
                {
                    total = batangKali[8];
                }
                else if (to == 31)
                {
                    total = serendah[8];
                }
                else if (to == 32)
                {
                    total = rawang[8];
                }
                else if (to == 33)
                {
                    total = kuang[8];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[8];
                }
                else if (to == 35)
                {
                    total = kepongSentral[8];

                }
                else if (to == 36)
                {
                    total = kepong[8];
                }
                else if (to == 37)
                {
                    total = segambut[8];
                }
                else if (to == 38)
                {
                    total = midValley[8];
                }
                else if (to == 39)
                {
                    total = seputeh[8];
                }
                else if (to == 40)
                {
                    total = salakSelatan[8];
                }
                else if (to == 41)
                {
                    total = btSelatan[8];
                }
                else if (to == 42)
                {
                    total = serdang[8];
                }
                else if (to == 43)
                {
                    total = kajang[8];
                }
                else if (to == 44)
                {
                    total = ukm[8];
                }

                else if (to == 45)
                {
                    total = bangi[8];
                }
                else if (to == 46)
                {
                    total = batangBenar[8];
                }
                else if (to == 47)
                {
                    total = nilai[8];
                }
                else if (to == 48)
                {
                    total = labu[8];
                }
                else if (to == 49)
                {
                    total = tiroi[8];
                }
                else if (to == 50)
                {
                    total = seremban[8];
                }
                else if (to == 51)
                {
                    total = senawang[8];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[8];
                }
                else if (to == 53)
                {
                    total = rembau[8];
                }
                else if (to == 54)
                {
                    total = tampin[8];
                }
                else if (to == 55)
                {
                    total = btgMelaka[8];
                }
                else if (to == 56)
                {
                    total = gemas[8];
                }
                ////////////////////batu tiga////////////////////////////////
            }
            else if (from == 9)
            {
                if (to == 0)
                {
                    total = batuTiga[0];
                }
                else if (to == 1)
                {
                    total = batuTiga[1];
                }
                else if (to == 2)
                {
                    total = batuTiga[2];
                }
                else if (to == 3)
                {
                    total = batuTiga[3];
                }
                else if (to == 4)
                {
                    total = batuTiga[4];
                }
                else if (to == 5)
                {
                    total = batuTiga[5];
                }
                else if (to == 6)
                {
                    total = batuTiga[6];
                }
                else if (to == 7)
                {
                    total = batuTiga[7];
                }
                else if (to == 8)
                {
                    total = batuTiga[8];
                }
                else if (to == 10)
                {
                    total = subangJaya[9];
                }
                else if (to == 11)
                {
                    total = setiaJaya[9];
                }
                else if (to == 12)
                {
                    total = seriSetia[9];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[9];
                }
                else if (to == 14)
                {
                    total = jlnTemper[9];
                }
                else if (to == 15)
                {
                    total = petaling[9];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[9];

                }
                else if (to == 17)
                {
                    total = angkasapuri[9];
                }
                else if (to == 18)
                {
                    total = klSentral[9];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[9];
                }
                else if (to == 20)
                {
                    total = bankNegara[9];
                }
                else if (to == 21)
                {
                    total = putra[9];
                }
                else if (to == 22)
                {
                    total = sentul[9];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[9];
                }
                else if (to == 24)
                {
                    total = kgBatu[9];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[9];
                }
                else if (to == 26)
                {
                    total = batuCaves[9];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[9];

                }
                else if (to == 28)
                {
                    total = kualaKubu[9];
                }
                else if (to == 29)
                {
                    total = rasa[9];
                }
                else if (to == 30)
                {
                    total = batangKali[9];
                }
                else if (to == 31)
                {
                    total = serendah[9];
                }
                else if (to == 32)
                {
                    total = rawang[9];
                }
                else if (to == 33)
                {
                    total = kuang[9];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[9];
                }
                else if (to == 35)
                {
                    total = kepongSentral[9];

                }
                else if (to == 36)
                {
                    total = kepong[9];
                }
                else if (to == 37)
                {
                    total = segambut[9];
                }
                else if (to == 38)
                {
                    total = midValley[9];
                }
                else if (to == 39)
                {
                    total = seputeh[9];
                }
                else if (to == 40)
                {
                    total = salakSelatan[9];
                }
                else if (to == 41)
                {
                    total = btSelatan[9];
                }
                else if (to == 42)
                {
                    total = serdang[9];
                }
                else if (to == 43)
                {
                    total = kajang[9];
                }
                else if (to == 44)
                {
                    total = ukm[9];
                }

                else if (to == 45)
                {
                    total = bangi[9];
                }
                else if (to == 46)
                {
                    total = batangBenar[9];
                }
                else if (to == 47)
                {
                    total = nilai[9];
                }
                else if (to == 48)
                {
                    total = labu[9];
                }
                else if (to == 49)
                {
                    total = tiroi[9];
                }
                else if (to == 50)
                {
                    total = seremban[9];
                }
                else if (to == 51)
                {
                    total = senawang[9];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[9];
                }
                else if (to == 53)
                {
                    total = rembau[9];
                }
                else if (to == 54)
                {
                    total = tampin[9];
                }
                else if (to == 55)
                {
                    total = btgMelaka[9];
                }
                else if (to == 56)
                {
                    total = gemas[9];
                }
            }//////////////////////Subang Jaya/////////////////////////////
            else if (from == 10)
            {
                if (to == 0)
                {
                    total = subangJaya[0];
                }
                else if (to == 1)
                {
                    total = subangJaya[1];
                }
                else if (to == 2)
                {
                    total = subangJaya[2];
                }
                else if (to == 3)
                {
                    total = subangJaya[3];
                }
                else if (to == 4)
                {
                    total = subangJaya[4];
                }
                else if (to == 5)
                {
                    total = subangJaya[5];
                }
                else if (to == 6)
                {
                    total = subangJaya[6];
                }
                else if (to == 7)
                {
                    total = subangJaya[7];
                }
                else if (to == 8)
                {
                    total = subangJaya[8];
                }
                else if (to == 9)
                {
                    total = subangJaya[9];
                }
                else if (to == 11)
                {
                    total = setiaJaya[10];
                }
                else if (to == 12)
                {
                    total = seriSetia[10];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[10];
                }
                else if (to == 14)
                {
                    total = jlnTemper[10];
                }
                else if (to == 15)
                {
                    total = petaling[10];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[10];

                }
                else if (to == 17)
                {
                    total = angkasapuri[10];
                }
                else if (to == 18)
                {
                    total = klSentral[10];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[10];
                }
                else if (to == 20)
                {
                    total = bankNegara[10];
                }
                else if (to == 21)
                {
                    total = putra[10];
                }
                else if (to == 22)
                {
                    total = sentul[10];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[10];
                }
                else if (to == 24)
                {
                    total = kgBatu[10];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[10];
                }
                else if (to == 26)
                {
                    total = batuCaves[10];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[10];

                }
                else if (to == 28)
                {
                    total = kualaKubu[10];
                }
                else if (to == 29)
                {
                    total = rasa[10];
                }
                else if (to == 30)
                {
                    total = batangKali[10];
                }
                else if (to == 31)
                {
                    total = serendah[10];
                }
                else if (to == 32)
                {
                    total = rawang[10];
                }
                else if (to == 33)
                {
                    total = kuang[10];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[10];
                }
                else if (to == 35)
                {
                    total = kepongSentral[10];

                }
                else if (to == 36)
                {
                    total = kepong[10];
                }
                else if (to == 37)
                {
                    total = segambut[10];
                }
                else if (to == 38)
                {
                    total = midValley[10];
                }
                else if (to == 39)
                {
                    total = seputeh[10];
                }
                else if (to == 40)
                {
                    total = salakSelatan[10];
                }
                else if (to == 41)
                {
                    total = btSelatan[10];
                }
                else if (to == 42)
                {
                    total = serdang[10];
                }
                else if (to == 43)
                {
                    total = kajang[10];
                }
                else if (to == 44)
                {
                    total = ukm[10];
                }

                else if (to == 45)
                {
                    total = bangi[10];
                }
                else if (to == 46)
                {
                    total = batangBenar[10];
                }
                else if (to == 47)
                {
                    total = nilai[10];
                }
                else if (to == 48)
                {
                    total = labu[10];
                }
                else if (to == 49)
                {
                    total = tiroi[10];
                }
                else if (to == 50)
                {
                    total = seremban[10];
                }
                else if (to == 51)
                {
                    total = senawang[10];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[10];
                }
                else if (to == 53)
                {
                    total = rembau[10];
                }
                else if (to == 54)
                {
                    total = tampin[10];
                }
                else if (to == 55)
                {
                    total = btgMelaka[10];
                }
                else if (to == 56)
                {
                    total = gemas[10];
                }
            }////////////////////////////////////setia jaya//////////////////////////////////////////
            else if (from == 11)
            {
                if (to == 0)
                {
                    total = setiaJaya[0];
                }
                else if (to == 1)
                {
                    total = setiaJaya[1];
                }
                else if (to == 2)
                {
                    total = setiaJaya[2];
                }
                else if (to == 3)
                {
                    total = setiaJaya[3];
                }
                else if (to == 4)
                {
                    total = setiaJaya[4];
                }
                else if (to == 5)
                {
                    total = setiaJaya[5];
                }
                else if (to == 6)
                {
                    total = setiaJaya[6];
                }
                else if (to == 7)
                {
                    total = setiaJaya[7];
                }
                else if (to == 8)
                {
                    total = setiaJaya[8];
                }
                else if (to == 9)
                {
                    total = setiaJaya[9];
                }
                else if (to == 10)
                {
                    total = setiaJaya[10];
                }
                else if (to == 12)
                {
                    total = seriSetia[11];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[11];
                }
                else if (to == 14)
                {
                    total = jlnTemper[11];
                }
                else if (to == 15)
                {
                    total = petaling[11];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[11];

                }
                else if (to == 17)
                {
                    total = angkasapuri[11];
                }
                else if (to == 18)
                {
                    total = klSentral[11];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[11];
                }
                else if (to == 20)
                {
                    total = bankNegara[11];
                }
                else if (to == 21)
                {
                    total = putra[11];
                }
                else if (to == 22)
                {
                    total = sentul[11];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[11];
                }
                else if (to == 24)
                {
                    total = kgBatu[11];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[11];
                }
                else if (to == 26)
                {
                    total = batuCaves[11];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[11];

                }
                else if (to == 28)
                {
                    total = kualaKubu[11];
                }
                else if (to == 29)
                {
                    total = rasa[11];
                }
                else if (to == 30)
                {
                    total = batangKali[11];
                }
                else if (to == 31)
                {
                    total = serendah[11];
                }
                else if (to == 32)
                {
                    total = rawang[11];
                }
                else if (to == 33)
                {
                    total = kuang[11];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[11];
                }
                else if (to == 35)
                {
                    total = kepongSentral[11];

                }
                else if (to == 36)
                {
                    total = kepong[11];
                }
                else if (to == 37)
                {
                    total = segambut[11];
                }
                else if (to == 38)
                {
                    total = midValley[11];
                }
                else if (to == 39)
                {
                    total = seputeh[11];
                }
                else if (to == 40)
                {
                    total = salakSelatan[11];
                }
                else if (to == 41)
                {
                    total = btSelatan[11];
                }
                else if (to == 42)
                {
                    total = serdang[11];
                }
                else if (to == 43)
                {
                    total = kajang[11];
                }
                else if (to == 44)
                {
                    total = ukm[11];
                }

                else if (to == 45)
                {
                    total = bangi[11];
                }
                else if (to == 46)
                {
                    total = batangBenar[11];
                }
                else if (to == 47)
                {
                    total = nilai[11];
                }
                else if (to == 48)
                {
                    total = labu[11];
                }
                else if (to == 49)
                {
                    total = tiroi[11];
                }
                else if (to == 50)
                {
                    total = seremban[11];
                }
                else if (to == 51)
                {
                    total = senawang[11];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[11];
                }
                else if (to == 53)
                {
                    total = rembau[11];
                }
                else if (to == 54)
                {
                    total = tampin[11];
                }
                else if (to == 55)
                {
                    total = btgMelaka[11];
                }
                else if (to == 56)
                {
                    total = gemas[11];
                }
            }////////////////////////seri setia///////////////////////////////////
            else if (from == 12)
            {
                if (to == 0)
                {
                    total = seriSetia[0];
                }
                else if (to == 1)
                {
                    total = seriSetia[1];
                }
                else if (to == 2)
                {
                    total = seriSetia[2];
                }
                else if (to == 3)
                {
                    total = seriSetia[3];
                }
                else if (to == 4)
                {
                    total = seriSetia[4];
                }
                else if (to == 5)
                {
                    total = seriSetia[5];
                }
                else if (to == 6)
                {
                    total = seriSetia[6];
                }
                else if (to == 7)
                {
                    total = seriSetia[7];
                }
                else if (to == 8)
                {
                    total = seriSetia[8];
                }
                else if (to == 9)
                {
                    total = seriSetia[9];
                }
                else if (to == 10)
                {
                    total = seriSetia[10];
                }
                else if (to == 11)
                {
                    total = seriSetia[11];
                }
                else if (to == 13)
                {
                    total = kgDatoHarun[12];
                }
                else if (to == 14)
                {
                    total = jlnTemper[12];
                }
                else if (to == 15)
                {
                    total = petaling[12];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[12];

                }
                else if (to == 17)
                {
                    total = angkasapuri[12];
                }
                else if (to == 18)
                {
                    total = klSentral[12];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[12];
                }
                else if (to == 20)
                {
                    total = bankNegara[12];
                }
                else if (to == 21)
                {
                    total = putra[12];
                }
                else if (to == 22)
                {
                    total = sentul[12];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[12];
                }
                else if (to == 24)
                {
                    total = kgBatu[12];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[12];
                }
                else if (to == 26)
                {
                    total = batuCaves[12];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[12];

                }
                else if (to == 28)
                {
                    total = kualaKubu[12];
                }
                else if (to == 29)
                {
                    total = rasa[12];
                }
                else if (to == 30)
                {
                    total = batangKali[12];
                }
                else if (to == 31)
                {
                    total = serendah[12];
                }
                else if (to == 32)
                {
                    total = rawang[12];
                }
                else if (to == 33)
                {
                    total = kuang[12];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[12];
                }
                else if (to == 35)
                {
                    total = kepongSentral[12];

                }
                else if (to == 36)
                {
                    total = kepong[12];
                }
                else if (to == 37)
                {
                    total = segambut[12];
                }
                else if (to == 38)
                {
                    total = midValley[12];
                }
                else if (to == 39)
                {
                    total = seputeh[12];
                }
                else if (to == 40)
                {
                    total = salakSelatan[12];
                }
                else if (to == 41)
                {
                    total = btSelatan[12];
                }
                else if (to == 42)
                {
                    total = serdang[12];
                }
                else if (to == 43)
                {
                    total = kajang[12];
                }
                else if (to == 44)
                {
                    total = ukm[12];
                }

                else if (to == 45)
                {
                    total = bangi[12];
                }
                else if (to == 46)
                {
                    total = batangBenar[12];
                }
                else if (to == 47)
                {
                    total = nilai[12];
                }
                else if (to == 48)
                {
                    total = labu[12];
                }
                else if (to == 49)
                {
                    total = tiroi[12];
                }
                else if (to == 50)
                {
                    total = seremban[12];
                }
                else if (to == 51)
                {
                    total = senawang[12];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[12];
                }
                else if (to == 53)
                {
                    total = rembau[12];
                }
                else if (to == 54)
                {
                    total = tampin[12];
                }
                else if (to == 55)
                {
                    total = btgMelaka[12];
                }
                else if (to == 56)
                {
                    total = gemas[12];
                }
            }///////////////////////KG Dato HArun
            else if (from == 13)
            {
                if (to == 0)
                {
                    total = kgDatoHarun[0];
                }
                else if (to == 1)
                {
                    total = kgDatoHarun[1];
                }
                else if (to == 2)
                {
                    total = kgDatoHarun[2];
                }
                else if (to == 3)
                {
                    total = kgDatoHarun[3];
                }
                else if (to == 4)
                {
                    total = kgDatoHarun[4];
                }
                else if (to == 5)
                {
                    total = kgDatoHarun[5];
                }
                else if (to == 6)
                {
                    total = kgDatoHarun[6];
                }
                else if (to == 7)
                {
                    total = kgDatoHarun[7];
                }
                else if (to == 8)
                {
                    total = kgDatoHarun[8];
                }
                else if (to == 9)
                {
                    total = kgDatoHarun[9];
                }
                else if (to == 10)
                {
                    total = kgDatoHarun[10];
                }
                else if (to == 11)
                {
                    total = kgDatoHarun[11];
                }
                else if (to == 12)
                {
                    total = kgDatoHarun[12];
                }
                else if (to == 14)
                {
                    total = jlnTemper[13];
                }
                else if (to == 15)
                {
                    total = petaling[13];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[13];

                }
                else if (to == 17)
                {
                    total = angkasapuri[13];
                }
                else if (to == 18)
                {
                    total = klSentral[13];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[13];
                }
                else if (to == 20)
                {
                    total = bankNegara[13];
                }
                else if (to == 21)
                {
                    total = putra[13];
                }
                else if (to == 22)
                {
                    total = sentul[13];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[13];
                }
                else if (to == 24)
                {
                    total = kgBatu[13];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[13];
                }
                else if (to == 26)
                {
                    total = batuCaves[13];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[13];

                }
                else if (to == 28)
                {
                    total = kualaKubu[13];
                }
                else if (to == 29)
                {
                    total = rasa[13];
                }
                else if (to == 30)
                {
                    total = batangKali[13];
                }
                else if (to == 31)
                {
                    total = serendah[13];
                }
                else if (to == 32)
                {
                    total = rawang[13];
                }
                else if (to == 33)
                {
                    total = kuang[13];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[13];
                }
                else if (to == 35)
                {
                    total = kepongSentral[13];

                }
                else if (to == 36)
                {
                    total = kepong[13];
                }
                else if (to == 37)
                {
                    total = segambut[13];
                }
                else if (to == 38)
                {
                    total = midValley[13];
                }
                else if (to == 39)
                {
                    total = seputeh[13];
                }
                else if (to == 40)
                {
                    total = salakSelatan[13];
                }
                else if (to == 41)
                {
                    total = btSelatan[13];
                }
                else if (to == 42)
                {
                    total = serdang[13];
                }
                else if (to == 43)
                {
                    total = kajang[13];
                }
                else if (to == 44)
                {
                    total = ukm[13];
                }

                else if (to == 45)
                {
                    total = bangi[13];
                }
                else if (to == 46)
                {
                    total = batangBenar[13];
                }
                else if (to == 47)
                {
                    total = nilai[13];
                }
                else if (to == 48)
                {
                    total = labu[13];
                }
                else if (to == 49)
                {
                    total = tiroi[13];
                }
                else if (to == 50)
                {
                    total = seremban[13];
                }
                else if (to == 51)
                {
                    total = senawang[13];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[13];
                }
                else if (to == 53)
                {
                    total = rembau[13];
                }
                else if (to == 54)
                {
                    total = tampin[13];
                }
                else if (to == 55)
                {
                    total = btgMelaka[13];
                }
                else if (to == 56)
                {
                    total = gemas[13];
                }
            }/////////////////////////////////////////////JLN TEMPER/////////////////////////////
            else if (from == 14)
            {
                if (to == 0)
                {
                    total = jlnTemper[0];
                }
                else if (to == 1)
                {
                    total = jlnTemper[1];
                }
                else if (to == 2)
                {
                    total = jlnTemper[2];
                }
                else if (to == 3)
                {
                    total = jlnTemper[3];
                }
                else if (to == 4)
                {
                    total = jlnTemper[4];
                }
                else if (to == 5)
                {
                    total = jlnTemper[5];
                }
                else if (to == 6)
                {
                    total = jlnTemper[6];
                }
                else if (to == 7)
                {
                    total = jlnTemper[7];
                }
                else if (to == 8)
                {
                    total = jlnTemper[8];
                }
                else if (to == 9)
                {
                    total = jlnTemper[9];
                }
                else if (to == 10)
                {
                    total = jlnTemper[10];
                }
                else if (to == 11)
                {
                    total = jlnTemper[11];
                }
                else if (to == 12)
                {
                    total = jlnTemper[12];
                }
                else if (to == 13)
                {
                    total = jlnTemper[13];
                }
                else if (to == 15)
                {
                    total = petaling[14];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[14];

                }
                else if (to == 17)
                {
                    total = angkasapuri[14];
                }
                else if (to == 18)
                {
                    total = klSentral[14];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[14];
                }
                else if (to == 20)
                {
                    total = bankNegara[14];
                }
                else if (to == 21)
                {
                    total = putra[14];
                }
                else if (to == 22)
                {
                    total = sentul[14];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[14];
                }
                else if (to == 24)
                {
                    total = kgBatu[14];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[14];
                }
                else if (to == 26)
                {
                    total = batuCaves[14];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[14];

                }
                else if (to == 28)
                {
                    total = kualaKubu[14];
                }
                else if (to == 29)
                {
                    total = rasa[14];
                }
                else if (to == 30)
                {
                    total = batangKali[14];
                }
                else if (to == 31)
                {
                    total = serendah[14];
                }
                else if (to == 32)
                {
                    total = rawang[14];
                }
                else if (to == 33)
                {
                    total = kuang[14];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[14];
                }
                else if (to == 35)
                {
                    total = kepongSentral[14];

                }
                else if (to == 36)
                {
                    total = kepong[14];
                }
                else if (to == 37)
                {
                    total = segambut[14];
                }
                else if (to == 38)
                {
                    total = midValley[14];
                }
                else if (to == 39)
                {
                    total = seputeh[14];
                }
                else if (to == 40)
                {
                    total = salakSelatan[14];
                }
                else if (to == 41)
                {
                    total = btSelatan[14];
                }
                else if (to == 42)
                {
                    total = serdang[14];
                }
                else if (to == 43)
                {
                    total = kajang[14];
                }
                else if (to == 44)
                {
                    total = ukm[14];
                }

                else if (to == 45)
                {
                    total = bangi[14];
                }
                else if (to == 46)
                {
                    total = batangBenar[14];
                }
                else if (to == 47)
                {
                    total = nilai[14];
                }
                else if (to == 48)
                {
                    total = labu[14];
                }
                else if (to == 49)
                {
                    total = tiroi[14];
                }
                else if (to == 50)
                {
                    total = seremban[14];
                }
                else if (to == 51)
                {
                    total = senawang[14];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[14];
                }
                else if (to == 53)
                {
                    total = rembau[14];
                }
                else if (to == 54)
                {
                    total = tampin[14];
                }
                else if (to == 55)
                {
                    total = btgMelaka[14];
                }
                else if (to == 56)
                {
                    total = gemas[14];
                }
            }////////////////////////////petaling////////////////

            else if (from == 15)
            {
                if (to == 0)
                {
                    total = petaling[0];
                }
                else if (to == 1)
                {
                    total = petaling[1];
                }
                else if (to == 2)
                {
                    total = petaling[2];
                }
                else if (to == 3)
                {
                    total = petaling[3];
                }
                else if (to == 4)
                {
                    total = petaling[4];
                }
                else if (to == 5)
                {
                    total = petaling[5];
                }
                else if (to == 6)
                {
                    total = petaling[6];
                }
                else if (to == 7)
                {
                    total = petaling[7];
                }
                else if (to == 8)
                {
                    total = petaling[8];
                }
                else if (to == 9)
                {
                    total = petaling[9];
                }
                else if (to == 10)
                {
                    total = petaling[10];
                }
                else if (to == 11)
                {
                    total = petaling[11];
                }
                else if (to == 12)
                {
                    total = petaling[12];
                }
                else if (to == 13)
                {
                    total = petaling[13];
                }
                else if (to == 14)
                {
                    total = petaling[14];
                }
                else if (to == 16)
                {
                    total = pantaiDalam[15];

                }
                else if (to == 17)
                {
                    total = angkasapuri[15];
                }
                else if (to == 18)
                {
                    total = klSentral[15];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[15];
                }
                else if (to == 20)
                {
                    total = bankNegara[15];
                }
                else if (to == 21)
                {
                    total = putra[15];
                }
                else if (to == 22)
                {
                    total = sentul[15];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[15];
                }
                else if (to == 24)
                {
                    total = kgBatu[15];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[15];
                }
                else if (to == 26)
                {
                    total = batuCaves[15];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[15];

                }
                else if (to == 28)
                {
                    total = kualaKubu[15];
                }
                else if (to == 29)
                {
                    total = rasa[15];
                }
                else if (to == 30)
                {
                    total = batangKali[15];
                }
                else if (to == 31)
                {
                    total = serendah[15];
                }
                else if (to == 32)
                {
                    total = rawang[15];
                }
                else if (to == 33)
                {
                    total = kuang[15];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[15];
                }
                else if (to == 35)
                {
                    total = kepongSentral[15];

                }
                else if (to == 36)
                {
                    total = kepong[15];
                }
                else if (to == 37)
                {
                    total = segambut[15];
                }
                else if (to == 38)
                {
                    total = midValley[15];
                }
                else if (to == 39)
                {
                    total = seputeh[15];
                }
                else if (to == 40)
                {
                    total = salakSelatan[15];
                }
                else if (to == 41)
                {
                    total = btSelatan[15];
                }
                else if (to == 42)
                {
                    total = serdang[15];
                }
                else if (to == 43)
                {
                    total = kajang[15];
                }
                else if (to == 44)
                {
                    total = ukm[15];
                }

                else if (to == 45)
                {
                    total = bangi[15];
                }
                else if (to == 46)
                {
                    total = batangBenar[15];
                }
                else if (to == 47)
                {
                    total = nilai[15];
                }
                else if (to == 48)
                {
                    total = labu[15];
                }
                else if (to == 49)
                {
                    total = tiroi[15];
                }
                else if (to == 50)
                {
                    total = seremban[15];
                }
                else if (to == 51)
                {
                    total = senawang[15];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[15];
                }
                else if (to == 53)
                {
                    total = rembau[15];
                }
                else if (to == 54)
                {
                    total = tampin[15];
                }
                else if (to == 55)
                {
                    total = btgMelaka[15];
                }
                else if (to == 56)
                {
                    total = gemas[15];
                }
            }///////////////////////////////Pantai Dalam////////////////////////////

            else if (from == 16)
            {
                if (to == 0)
                {
                    total = pantaiDalam[0];
                }
                else if (to == 1)
                {
                    total = pantaiDalam[1];
                }
                else if (to == 2)
                {
                    total = pantaiDalam[2];
                }
                else if (to == 3)
                {
                    total = pantaiDalam[3];
                }
                else if (to == 4)
                {
                    total = pantaiDalam[4];
                }
                else if (to == 5)
                {
                    total = pantaiDalam[5];
                }
                else if (to == 6)
                {
                    total = pantaiDalam[6];
                }
                else if (to == 7)
                {
                    total = pantaiDalam[7];
                }
                else if (to == 8)
                {
                    total = pantaiDalam[8];
                }
                else if (to == 9)
                {
                    total = pantaiDalam[9];
                }
                else if (to == 10)
                {
                    total = pantaiDalam[10];
                }
                else if (to == 11)
                {
                    total = pantaiDalam[11];
                }
                else if (to == 12)
                {
                    total = pantaiDalam[12];
                }
                else if (to == 13)
                {
                    total = pantaiDalam[13];
                }
                else if (to == 14)
                {
                    total = pantaiDalam[14];
                }
                else if (to == 15)
                {
                    total = pantaiDalam[15];
                }
                else if (to == 17)
                {
                    total = angkasapuri[16];
                }
                else if (to == 18)
                {
                    total = klSentral[16];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[16];
                }
                else if (to == 20)
                {
                    total = bankNegara[16];
                }
                else if (to == 21)
                {
                    total = putra[16];
                }
                else if (to == 22)
                {
                    total = sentul[16];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[16];
                }
                else if (to == 24)
                {
                    total = kgBatu[16];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[16];
                }
                else if (to == 26)
                {
                    total = batuCaves[16];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[16];

                }
                else if (to == 28)
                {
                    total = kualaKubu[16];
                }
                else if (to == 29)
                {
                    total = rasa[16];
                }
                else if (to == 30)
                {
                    total = batangKali[16];
                }
                else if (to == 31)
                {
                    total = serendah[16];
                }
                else if (to == 32)
                {
                    total = rawang[16];
                }
                else if (to == 33)
                {
                    total = kuang[16];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[16];
                }
                else if (to == 35)
                {
                    total = kepongSentral[16];

                }
                else if (to == 36)
                {
                    total = kepong[16];
                }
                else if (to == 37)
                {
                    total = segambut[16];
                }
                else if (to == 38)
                {
                    total = midValley[16];
                }
                else if (to == 39)
                {
                    total = seputeh[16];
                }
                else if (to == 40)
                {
                    total = salakSelatan[16];
                }
                else if (to == 41)
                {
                    total = btSelatan[16];
                }
                else if (to == 42)
                {
                    total = serdang[16];
                }
                else if (to == 43)
                {
                    total = kajang[16];
                }
                else if (to == 44)
                {
                    total = ukm[16];
                }

                else if (to == 45)
                {
                    total = bangi[16];
                }
                else if (to == 46)
                {
                    total = batangBenar[16];
                }
                else if (to == 47)
                {
                    total = nilai[16];
                }
                else if (to == 48)
                {
                    total = labu[16];
                }
                else if (to == 49)
                {
                    total = tiroi[16];
                }
                else if (to == 50)
                {
                    total = seremban[16];
                }
                else if (to == 51)
                {
                    total = senawang[16];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[16];
                }
                else if (to == 53)
                {
                    total = rembau[16];
                }
                else if (to == 54)
                {
                    total = tampin[16];
                }
                else if (to == 55)
                {
                    total = btgMelaka[16];
                }
                else if (to == 56)
                {
                    total = gemas[16];
                }////////////////////////////Angkasapuri//////////////////////////
            }
            else if (from == 17)
            {
                if (to == 0)
                {
                    total = angkasapuri[0];
                }
                else if (to == 1)
                {
                    total = angkasapuri[1];
                }
                else if (to == 2)
                {
                    total = angkasapuri[2];
                }
                else if (to == 3)
                {
                    total = angkasapuri[3];
                }
                else if (to == 4)
                {
                    total = angkasapuri[4];
                }
                else if (to == 5)
                {
                    total = angkasapuri[5];
                }
                else if (to == 6)
                {
                    total = angkasapuri[6];
                }
                else if (to == 7)
                {
                    total = angkasapuri[7];
                }
                else if (to == 8)
                {
                    total = angkasapuri[8];
                }
                else if (to == 9)
                {
                    total = angkasapuri[9];
                }
                else if (to == 10)
                {
                    total = angkasapuri[10];
                }
                else if (to == 11)
                {
                    total = angkasapuri[11];
                }
                else if (to == 12)
                {
                    total = angkasapuri[12];
                }
                else if (to == 13)
                {
                    total = angkasapuri[13];
                }
                else if (to == 14)
                {
                    total = angkasapuri[14];
                }
                else if (to == 15)
                {
                    total = angkasapuri[15];
                }
                else if (to == 16)
                {
                    total = angkasapuri[16];
                }
                else if (to == 18)
                {
                    total = klSentral[17];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[17];
                }
                else if (to == 20)
                {
                    total = bankNegara[17];
                }
                else if (to == 21)
                {
                    total = putra[17];
                }
                else if (to == 22)
                {
                    total = sentul[17];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[17];
                }
                else if (to == 24)
                {
                    total = kgBatu[17];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[17];
                }
                else if (to == 26)
                {
                    total = batuCaves[17];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[17];

                }
                else if (to == 28)
                {
                    total = kualaKubu[17];
                }
                else if (to == 29)
                {
                    total = rasa[17];
                }
                else if (to == 30)
                {
                    total = batangKali[17];
                }
                else if (to == 31)
                {
                    total = serendah[17];
                }
                else if (to == 32)
                {
                    total = rawang[17];
                }
                else if (to == 33)
                {
                    total = kuang[17];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[17];
                }
                else if (to == 35)
                {
                    total = kepongSentral[17];

                }
                else if (to == 36)
                {
                    total = kepong[17];
                }
                else if (to == 37)
                {
                    total = segambut[17];
                }
                else if (to == 38)
                {
                    total = midValley[17];
                }
                else if (to == 39)
                {
                    total = seputeh[17];
                }
                else if (to == 40)
                {
                    total = salakSelatan[17];
                }
                else if (to == 41)
                {
                    total = btSelatan[17];
                }
                else if (to == 42)
                {
                    total = serdang[17];
                }
                else if (to == 43)
                {
                    total = kajang[17];
                }
                else if (to == 44)
                {
                    total = ukm[17];
                }

                else if (to == 45)
                {
                    total = bangi[17];
                }
                else if (to == 46)
                {
                    total = batangBenar[17];
                }
                else if (to == 47)
                {
                    total = nilai[17];
                }
                else if (to == 48)
                {
                    total = labu[17];
                }
                else if (to == 49)
                {
                    total = tiroi[17];
                }
                else if (to == 50)
                {
                    total = seremban[17];
                }
                else if (to == 51)
                {
                    total = senawang[17];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[17];
                }
                else if (to == 53)
                {
                    total = rembau[17];
                }
                else if (to == 54)
                {
                    total = tampin[17];
                }
                else if (to == 55)
                {
                    total = btgMelaka[17];
                }
                else if (to == 56)
                {
                    total = gemas[17];

                }

            }///////////////////////////////////////////KL SENTRAL/////////////////////////////////////////////////

            else if (from == 18)
            {
                if (to == 0)
                {
                    total = klSentral[0];
                }
                else if (to == 1)
                {
                    total = klSentral[1];
                }
                else if (to == 2)
                {
                    total = klSentral[2];
                }
                else if (to == 3)
                {
                    total = klSentral[3];
                }
                else if (to == 4)
                {
                    total = klSentral[4];
                }
                else if (to == 5)
                {
                    total = klSentral[5];
                }
                else if (to == 6)
                {
                    total = klSentral[6];
                }
                else if (to == 7)
                {
                    total = klSentral[7];
                }
                else if (to == 8)
                {
                    total = klSentral[8];
                }
                else if (to == 9)
                {
                    total = klSentral[9];
                }
                else if (to == 10)
                {
                    total = klSentral[10];
                }
                else if (to == 11)
                {
                    total = klSentral[11];
                }
                else if (to == 12)
                {
                    total = klSentral[12];
                }
                else if (to == 13)
                {
                    total = klSentral[13];
                }
                else if (to == 14)
                {
                    total = klSentral[14];
                }
                else if (to == 15)
                {
                    total = klSentral[15];
                }
                else if (to == 16)
                {
                    total = klSentral[16];
                }
                else if (to == 17)
                {
                    total = klSentral[17];

                }
                else if (to == 19)
                {
                    total = kualaLumpur[18];
                }
                else if (to == 20)
                {
                    total = bankNegara[18];
                }
                else if (to == 21)
                {
                    total = putra[18];
                }
                else if (to == 22)
                {
                    total = sentul[18];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[18];
                }
                else if (to == 24)
                {
                    total = kgBatu[18];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[18];
                }
                else if (to == 26)
                {
                    total = batuCaves[18];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[18];

                }
                else if (to == 28)
                {
                    total = kualaKubu[18];
                }
                else if (to == 29)
                {
                    total = rasa[18];
                }
                else if (to == 30)
                {
                    total = batangKali[18];
                }
                else if (to == 31)
                {
                    total = serendah[18];
                }
                else if (to == 32)
                {
                    total = rawang[18];
                }
                else if (to == 33)
                {
                    total = kuang[18];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[18];
                }
                else if (to == 35)
                {
                    total = kepongSentral[18];

                }
                else if (to == 36)
                {
                    total = kepong[18];
                }
                else if (to == 37)
                {
                    total = segambut[18];
                }
                else if (to == 38)
                {
                    total = midValley[18];
                }
                else if (to == 39)
                {
                    total = seputeh[18];
                }
                else if (to == 40)
                {
                    total = salakSelatan[18];
                }
                else if (to == 41)
                {
                    total = btSelatan[18];
                }
                else if (to == 42)
                {
                    total = serdang[18];
                }
                else if (to == 43)
                {
                    total = kajang[18];
                }
                else if (to == 44)
                {
                    total = ukm[18];
                }

                else if (to == 45)
                {
                    total = bangi[18];
                }
                else if (to == 46)
                {
                    total = batangBenar[18];
                }
                else if (to == 47)
                {
                    total = nilai[18];
                }
                else if (to == 48)
                {
                    total = labu[18];
                }
                else if (to == 49)
                {
                    total = tiroi[18];
                }
                else if (to == 50)
                {
                    total = seremban[18];
                }
                else if (to == 51)
                {
                    total = senawang[18];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[18];
                }
                else if (to == 53)
                {
                    total = rembau[18];
                }
                else if (to == 54)
                {
                    total = tampin[18];
                }
                else if (to == 55)
                {
                    total = btgMelaka[18];
                }
                else if (to == 56)
                {
                    total = gemas[18];

                }

            }////////////////////////////////////////////////KUAlA LUMPUR/////////////////////////////
            else if (from == 19)
            {
                if (to == 0)
                {
                    total = kualaLumpur[0];
                }

                else if (to == 1)
                {
                    total = kualaLumpur[1];
                }
                else if (to == 2)
                {
                    total = kualaLumpur[2];
                }
                else if (to == 3)
                {
                    total = kualaLumpur[3];
                }
                else if (to == 4)
                {
                    total = kualaLumpur[4];
                }
                else if (to == 5)
                {
                    total = kualaLumpur[5];
                }
                else if (to == 6)
                {
                    total = kualaLumpur[6];
                }
                else if (to == 7)
                {
                    total = kualaLumpur[7];
                }
                else if (to == 8)
                {
                    total = kualaLumpur[8];
                }
                else if (to == 9)
                {
                    total = kualaLumpur[9];
                }
                else if (to == 10)
                {
                    total = kualaLumpur[10];
                }
                else if (to == 11)
                {
                    total = kualaLumpur[11];
                }
                else if (to == 12)
                {
                    total = kualaLumpur[12];
                }
                else if (to == 13)
                {
                    total = kualaLumpur[13];
                }
                else if (to == 14)
                {
                    total = kualaLumpur[14];
                }
                else if (to == 15)
                {
                    total = kualaLumpur[15];
                }
                else if (to == 16)
                {
                    total = kualaLumpur[16];
                }
                else if (to == 17)
                {
                    total = kualaLumpur[17];

                }
                else if (to == 18)
                {
                    total = kualaLumpur[18];
                }
                else if (to == 20)
                {
                    total = bankNegara[19];
                }
                else if (to == 21)
                {
                    total = putra[19];
                }
                else if (to == 22)
                {
                    total = sentul[19];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[19];
                }
                else if (to == 24)
                {
                    total = kgBatu[19];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[19];
                }
                else if (to == 26)
                {
                    total = batuCaves[19];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[19];

                }
                else if (to == 28)
                {
                    total = kualaKubu[19];
                }
                else if (to == 29)
                {
                    total = rasa[19];
                }
                else if (to == 30)
                {
                    total = batangKali[19];
                }
                else if (to == 31)
                {
                    total = serendah[19];
                }
                else if (to == 32)
                {
                    total = rawang[19];
                }
                else if (to == 33)
                {
                    total = kuang[19];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[19];
                }
                else if (to == 35)
                {
                    total = kepongSentral[19];

                }
                else if (to == 36)
                {
                    total = kepong[19];
                }
                else if (to == 37)
                {
                    total = segambut[19];
                }
                else if (to == 38)
                {
                    total = midValley[19];
                }
                else if (to == 39)
                {
                    total = seputeh[19];
                }
                else if (to == 40)
                {
                    total = salakSelatan[19];
                }
                else if (to == 41)
                {
                    total = btSelatan[19];
                }
                else if (to == 42)
                {
                    total = serdang[19];
                }
                else if (to == 43)
                {
                    total = kajang[19];
                }
                else if (to == 44)
                {
                    total = ukm[19];
                }

                else if (to == 45)
                {
                    total = bangi[19];
                }
                else if (to == 46)
                {
                    total = batangBenar[19];
                }
                else if (to == 47)
                {
                    total = nilai[19];
                }
                else if (to == 48)
                {
                    total = labu[19];
                }
                else if (to == 49)
                {
                    total = tiroi[19];
                }
                else if (to == 50)
                {
                    total = seremban[19];
                }
                else if (to == 51)
                {
                    total = senawang[19];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[19];
                }
                else if (to == 53)
                {
                    total = rembau[19];
                }
                else if (to == 54)
                {
                    total = tampin[19];
                }
                else if (to == 55)
                {
                    total = btgMelaka[19];
                }
                else if (to == 56)
                {
                    total = gemas[19];

                }
                ///////////////////////////////////BANK NEGARA///////////////////////////////
            }
            else if (from == 20)
            {
                if (to == 0)
                {
                    total = bankNegara[0];
                }
                else if (to == 1)
                {
                    total = bankNegara[1];
                }
                else if (to == 2)
                {
                    total = bankNegara[2];
                }
                else if (to == 3)
                {
                    total = bankNegara[3];
                }
                else if (to == 4)
                {
                    total = bankNegara[4];
                }
                else if (to == 5)
                {
                    total = bankNegara[5];
                }
                else if (to == 6)
                {
                    total = bankNegara[6];
                }
                else if (to == 7)
                {
                    total = bankNegara[7];
                }
                else if (to == 8)
                {
                    total = bankNegara[8];
                }
                else if (to == 9)
                {
                    total = bankNegara[9];
                }
                else if (to == 10)
                {
                    total = bankNegara[10];
                }
                else if (to == 11)
                {
                    total = bankNegara[11];
                }
                else if (to == 12)
                {
                    total = bankNegara[12];
                }
                else if (to == 13)
                {
                    total = bankNegara[13];
                }
                else if (to == 14)
                {
                    total = bankNegara[14];
                }
                else if (to == 15)
                {
                    total = bankNegara[15];
                }
                else if (to == 16)
                {
                    total = bankNegara[16];
                }
                else if (to == 17)
                {
                    total = bankNegara[17];

                }
                else if (to == 18)
                {
                    total = bankNegara[18];
                }
                else if (to == 19)
                {
                    total = bankNegara[19];
                }
                else if (to == 21)
                {
                    total = putra[20];
                }
                else if (to == 22)
                {
                    total = sentul[20];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[20];
                }
                else if (to == 24)
                {
                    total = kgBatu[20];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[20];
                }
                else if (to == 26)
                {
                    total = batuCaves[20];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[20];

                }
                else if (to == 28)
                {
                    total = kualaKubu[20];
                }
                else if (to == 29)
                {
                    total = rasa[20];
                }
                else if (to == 30)
                {
                    total = batangKali[20];
                }
                else if (to == 31)
                {
                    total = serendah[20];
                }
                else if (to == 32)
                {
                    total = rawang[20];
                }
                else if (to == 33)
                {
                    total = kuang[20];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[20];
                }
                else if (to == 35)
                {
                    total = kepongSentral[20];

                }
                else if (to == 36)
                {
                    total = kepong[20];
                }
                else if (to == 37)
                {
                    total = segambut[20];
                }
                else if (to == 38)
                {
                    total = midValley[20];
                }
                else if (to == 39)
                {
                    total = seputeh[20];
                }
                else if (to == 40)
                {
                    total = salakSelatan[20];
                }
                else if (to == 41)
                {
                    total = btSelatan[20];
                }
                else if (to == 42)
                {
                    total = serdang[20];
                }
                else if (to == 43)
                {
                    total = kajang[20];
                }
                else if (to == 44)
                {
                    total = ukm[20];
                }

                else if (to == 45)
                {
                    total = bangi[20];
                }
                else if (to == 46)
                {
                    total = batangBenar[20];
                }
                else if (to == 47)
                {
                    total = nilai[20];
                }
                else if (to == 48)
                {
                    total = labu[20];
                }
                else if (to == 49)
                {
                    total = tiroi[20];
                }
                else if (to == 50)
                {
                    total = seremban[20];
                }
                else if (to == 51)
                {
                    total = senawang[20];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[20];
                }
                else if (to == 53)
                {
                    total = rembau[20];
                }
                else if (to == 54)
                {
                    total = tampin[20];
                }
                else if (to == 55)
                {
                    total = btgMelaka[20];
                }
                else if (to == 56)
                {
                    total = gemas[20];

                }


            }////////////////////////PUTRA////////////////////////////
            else if (from == 21)
            {
                if (to == 0)
                {
                    total = putra[0];
                }
                else if (to == 1)
                {
                    total = putra[1];
                }
                else if (to == 2)
                {
                    total = putra[2];
                }
                else if (to == 3)
                {
                    total = putra[3];
                }
                else if (to == 4)
                {
                    total = putra[4];
                }
                else if (to == 5)
                {
                    total = putra[5];
                }
                else if (to == 6)
                {
                    total = putra[6];
                }
                else if (to == 7)
                {
                    total = putra[7];
                }
                else if (to == 8)
                {
                    total = putra[8];
                }
                else if (to == 9)
                {
                    total = putra[9];
                }
                else if (to == 10)
                {
                    total = putra[10];
                }
                else if (to == 11)
                {
                    total = putra[11];
                }
                else if (to == 12)
                {
                    total = putra[12];
                }
                else if (to == 13)
                {
                    total = putra[13];
                }
                else if (to == 14)
                {
                    total = putra[14];
                }
                else if (to == 15)
                {
                    total = putra[15];
                }
                else if (to == 16)
                {
                    total = putra[16];
                }
                else if (to == 17)
                {
                    total = putra[17];

                }
                else if (to == 18)
                {
                    total = putra[18];
                }
                else if (to == 19)
                {
                    total = putra[19];
                }
                else if (to == 20)
                {
                    total = putra[20];
                }
                else if (to == 22)
                {
                    total = sentul[21];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[21];
                }
                else if (to == 24)
                {
                    total = kgBatu[21];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[21];
                }
                else if (to == 26)
                {
                    total = batuCaves[21];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[21];

                }
                else if (to == 28)
                {
                    total = kualaKubu[21];
                }
                else if (to == 29)
                {
                    total = rasa[21];
                }
                else if (to == 30)
                {
                    total = batangKali[21];
                }
                else if (to == 31)
                {
                    total = serendah[21];
                }
                else if (to == 32)
                {
                    total = rawang[21];
                }
                else if (to == 33)
                {
                    total = kuang[21];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[21];
                }
                else if (to == 35)
                {
                    total = kepongSentral[21];

                }
                else if (to == 36)
                {
                    total = kepong[21];
                }
                else if (to == 37)
                {
                    total = segambut[21];
                }
                else if (to == 38)
                {
                    total = midValley[21];
                }
                else if (to == 39)
                {
                    total = seputeh[21];
                }
                else if (to == 40)
                {
                    total = salakSelatan[21];
                }
                else if (to == 41)
                {
                    total = btSelatan[21];
                }
                else if (to == 42)
                {
                    total = serdang[21];
                }
                else if (to == 43)
                {
                    total = kajang[21];
                }
                else if (to == 44)
                {
                    total = ukm[21];
                }

                else if (to == 45)
                {
                    total = bangi[21];
                }
                else if (to == 46)
                {
                    total = batangBenar[21];
                }
                else if (to == 47)
                {
                    total = nilai[21];
                }
                else if (to == 48)
                {
                    total = labu[21];
                }
                else if (to == 49)
                {
                    total = tiroi[21];
                }
                else if (to == 50)
                {
                    total = seremban[21];
                }
                else if (to == 51)
                {
                    total = senawang[21];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[21];
                }
                else if (to == 53)
                {
                    total = rembau[21];
                }
                else if (to == 54)
                {
                    total = tampin[21];
                }
                else if (to == 55)
                {
                    total = btgMelaka[21];
                }
                else if (to == 56)
                {
                    total = gemas[21];

                }
            }///////////////Sentul///////////////////////

            else if (from == 22)
            {
                if (to == 0)
                {
                    total = sentul[0];
                }
                else if (to == 1)
                {
                    total = sentul[1];
                }
                else if (to == 2)
                {
                    total = sentul[2];
                }
                else if (to == 3)
                {
                    total = sentul[3];
                }
                else if (to == 4)
                {
                    total = sentul[4];
                }
                else if (to == 5)
                {
                    total = sentul[5];
                }
                else if (to == 6)
                {
                    total = sentul[6];
                }
                else if (to == 7)
                {
                    total = sentul[7];
                }
                else if (to == 8)
                {
                    total = sentul[8];
                }
                else if (to == 9)
                {
                    total = sentul[9];
                }
                else if (to == 10)
                {
                    total = sentul[10];
                }
                else if (to == 11)
                {
                    total = sentul[11];
                }
                else if (to == 12)
                {
                    total = sentul[12];
                }
                else if (to == 13)
                {
                    total = sentul[13];
                }
                else if (to == 14)
                {
                    total = sentul[14];
                }
                else if (to == 15)
                {
                    total = sentul[15];
                }
                else if (to == 16)
                {
                    total = sentul[16];
                }
                else if (to == 17)
                {
                    total = sentul[17];

                }
                else if (to == 18)
                {
                    total = sentul[18];
                }
                else if (to == 19)
                {
                    total = sentul[19];
                }
                else if (to == 20)
                {
                    total = sentul[20];
                }
                else if (to == 21)
                {
                    total = sentul[21];
                }
                else if (to == 23)
                {
                    total = batuKentonmen[22];
                }
                else if (to == 24)
                {
                    total = kgBatu[22];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[22];
                }
                else if (to == 26)
                {
                    total = batuCaves[22];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[22];

                }
                else if (to == 28)
                {
                    total = kualaKubu[22];
                }
                else if (to == 29)
                {
                    total = rasa[22];
                }
                else if (to == 30)
                {
                    total = batangKali[22];
                }
                else if (to == 31)
                {
                    total = serendah[22];
                }
                else if (to == 32)
                {
                    total = rawang[22];
                }
                else if (to == 33)
                {
                    total = kuang[22];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[22];
                }
                else if (to == 35)
                {
                    total = kepongSentral[22];

                }
                else if (to == 36)
                {
                    total = kepong[22];
                }
                else if (to == 37)
                {
                    total = segambut[22];
                }
                else if (to == 38)
                {
                    total = midValley[22];
                }
                else if (to == 39)
                {
                    total = seputeh[22];
                }
                else if (to == 40)
                {
                    total = salakSelatan[22];
                }
                else if (to == 41)
                {
                    total = btSelatan[22];
                }
                else if (to == 42)
                {
                    total = serdang[22];
                }
                else if (to == 43)
                {
                    total = kajang[22];
                }
                else if (to == 44)
                {
                    total = ukm[22];
                }

                else if (to == 45)
                {
                    total = bangi[22];
                }
                else if (to == 46)
                {
                    total = batangBenar[22];
                }
                else if (to == 47)
                {
                    total = nilai[22];
                }
                else if (to == 48)
                {
                    total = labu[22];
                }
                else if (to == 49)
                {
                    total = tiroi[22];
                }
                else if (to == 50)
                {
                    total = seremban[22];
                }
                else if (to == 51)
                {
                    total = senawang[22];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[22];
                }
                else if (to == 53)
                {
                    total = rembau[22];
                }
                else if (to == 54)
                {
                    total = tampin[22];
                }
                else if (to == 55)
                {
                    total = btgMelaka[22];
                }
                else if (to == 56)
                {
                    total = gemas[22];

                }
            }//////////////////////////BATU KENTONMEN//////////////////////////

            else if (from == 23)
            {
                if (to == 0)
                {
                    total = batuKentonmen[0];
                }
                else if (to == 1)
                {
                    total = batuKentonmen[1];
                }
                else if (to == 2)
                {
                    total = batuKentonmen[2];
                }
                else if (to == 3)
                {
                    total = batuKentonmen[3];
                }
                else if (to == 4)
                {
                    total = batuKentonmen[4];
                }
                else if (to == 5)
                {
                    total = batuKentonmen[5];
                }
                else if (to == 6)
                {
                    total = batuKentonmen[6];
                }
                else if (to == 7)
                {
                    total = batuKentonmen[7];
                }
                else if (to == 8)
                {
                    total = batuKentonmen[8];
                }
                else if (to == 9)
                {
                    total = batuKentonmen[9];
                }
                else if (to == 10)
                {
                    total = batuKentonmen[10];
                }
                else if (to == 11)
                {
                    total = batuKentonmen[11];
                }
                else if (to == 12)
                {
                    total = batuKentonmen[12];
                }
                else if (to == 13)
                {
                    total = batuKentonmen[13];
                }
                else if (to == 14)
                {
                    total = batuKentonmen[14];
                }
                else if (to == 15)
                {
                    total = batuKentonmen[15];
                }
                else if (to == 16)
                {
                    total = batuKentonmen[16];
                }
                else if (to == 17)
                {
                    total = batuKentonmen[17];

                }
                else if (to == 18)
                {
                    total = batuKentonmen[18];
                }
                else if (to == 19)
                {
                    total = batuKentonmen[19];
                }
                else if (to == 20)
                {
                    total = batuKentonmen[20];
                }
                else if (to == 21)
                {
                    total = batuKentonmen[21];
                }
                else if (to == 22)
                {
                    total = batuKentonmen[22];
                }
                else if (to == 24)
                {
                    total = kgBatu[23];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[23];
                }
                else if (to == 26)
                {
                    total = batuCaves[23];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[23];

                }
                else if (to == 28)
                {
                    total = kualaKubu[23];
                }
                else if (to == 29)
                {
                    total = rasa[23];
                }
                else if (to == 30)
                {
                    total = batangKali[23];
                }
                else if (to == 31)
                {
                    total = serendah[23];
                }
                else if (to == 32)
                {
                    total = rawang[23];
                }
                else if (to == 33)
                {
                    total = kuang[23];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[23];
                }
                else if (to == 35)
                {
                    total = kepongSentral[23];

                }
                else if (to == 36)
                {
                    total = kepong[23];
                }
                else if (to == 37)
                {
                    total = segambut[23];
                }
                else if (to == 38)
                {
                    total = midValley[23];
                }
                else if (to == 39)
                {
                    total = seputeh[23];
                }
                else if (to == 40)
                {
                    total = salakSelatan[23];
                }
                else if (to == 41)
                {
                    total = btSelatan[23];
                }
                else if (to == 42)
                {
                    total = serdang[23];
                }
                else if (to == 43)
                {
                    total = kajang[23];
                }
                else if (to == 44)
                {
                    total = ukm[23];
                }

                else if (to == 45)
                {
                    total = bangi[23];
                }
                else if (to == 46)
                {
                    total = batangBenar[23];
                }
                else if (to == 47)
                {
                    total = nilai[23];
                }
                else if (to == 48)
                {
                    total = labu[23];
                }
                else if (to == 49)
                {
                    total = tiroi[23];
                }
                else if (to == 50)
                {
                    total = seremban[23];
                }
                else if (to == 51)
                {
                    total = senawang[23];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[23];
                }
                else if (to == 53)
                {
                    total = rembau[23];
                }
                else if (to == 54)
                {
                    total = tampin[23];
                }
                else if (to == 55)
                {
                    total = btgMelaka[23];
                }
                else if (to == 56)
                {
                    total = gemas[23];

                }
            }////////////////////////////KG BATU//////////////////////////////////////////

            else if (from == 24)
            {
                if (to == 0)
                {
                    total = kgBatu[0];
                }

                else if (to == 1)
                {
                    total = kgBatu[1];
                }
                else if (to == 2)
                {
                    total = kgBatu[2];
                }
                else if (to == 3)
                {
                    total = kgBatu[3];
                }
                else if (to == 4)
                {
                    total = kgBatu[4];
                }
                else if (to == 5)
                {
                    total = kgBatu[5];
                }
                else if (to == 6)
                {
                    total = kgBatu[6];
                }
                else if (to == 7)
                {
                    total = kgBatu[7];
                }
                else if (to == 8)
                {
                    total = kgBatu[8];
                }
                else if (to == 9)
                {
                    total = kgBatu[9];
                }
                else if (to == 10)
                {
                    total = kgBatu[10];
                }
                else if (to == 11)
                {
                    total = kgBatu[11];
                }
                else if (to == 12)
                {
                    total = kgBatu[12];
                }
                else if (to == 13)
                {
                    total = kgBatu[13];
                }
                else if (to == 14)
                {
                    total = kgBatu[14];
                }
                else if (to == 15)
                {
                    total = kgBatu[15];
                }
                else if (to == 16)
                {
                    total = kgBatu[16];
                }
                else if (to == 17)
                {
                    total = kgBatu[17];

                }
                else if (to == 18)
                {
                    total = kgBatu[18];
                }
                else if (to == 19)
                {
                    total = kgBatu[19];
                }
                else if (to == 20)
                {
                    total = kgBatu[20];
                }
                else if (to == 21)
                {
                    total = kgBatu[21];
                }
                else if (to == 22)
                {
                    total = kgBatu[22];
                }
                else if (to == 23)
                {
                    total = kgBatu[23];

                }
                else if (to == 25)
                {
                    total = tamanWahyu[24];
                }
                else if (to == 26)
                {
                    total = batuCaves[24];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[24];

                }
                else if (to == 28)
                {
                    total = kualaKubu[24];
                }
                else if (to == 29)
                {
                    total = rasa[24];
                }
                else if (to == 30)
                {
                    total = batangKali[24];
                }
                else if (to == 31)
                {
                    total = serendah[24];
                }
                else if (to == 32)
                {
                    total = rawang[24];
                }
                else if (to == 33)
                {
                    total = kuang[24];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[24];
                }
                else if (to == 35)
                {
                    total = kepongSentral[24];

                }
                else if (to == 36)
                {
                    total = kepong[24];
                }
                else if (to == 37)
                {
                    total = segambut[24];
                }
                else if (to == 38)
                {
                    total = midValley[24];
                }
                else if (to == 39)
                {
                    total = seputeh[24];
                }
                else if (to == 40)
                {
                    total = salakSelatan[24];
                }
                else if (to == 41)
                {
                    total = btSelatan[24];
                }
                else if (to == 42)
                {
                    total = serdang[24];
                }
                else if (to == 43)
                {
                    total = kajang[24];
                }
                else if (to == 44)
                {
                    total = ukm[24];
                }

                else if (to == 45)
                {
                    total = bangi[24];
                }
                else if (to == 46)
                {
                    total = batangBenar[24];
                }
                else if (to == 47)
                {
                    total = nilai[24];
                }
                else if (to == 48)
                {
                    total = labu[24];
                }
                else if (to == 49)
                {
                    total = tiroi[24];
                }
                else if (to == 50)
                {
                    total = seremban[24];
                }
                else if (to == 51)
                {
                    total = senawang[24];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[24];
                }
                else if (to == 53)
                {
                    total = rembau[24];
                }
                else if (to == 54)
                {
                    total = tampin[24];
                }
                else if (to == 55)
                {
                    total = btgMelaka[24];
                }
                else if (to == 56)
                {
                    total = gemas[24];

                }
                //////////////////////taman wahyu////////////////////////////
            }

            else if (from == 25)
            {
                if (to == 0)
                {
                    total = tamanWahyu[0];
                }
                else if (to == 1)
                {
                    total = tamanWahyu[1];
                }
                else if (to == 2)
                {
                    total = tamanWahyu[2];
                }
                else if (to == 3)
                {
                    total = tamanWahyu[3];
                }
                else if (to == 4)
                {
                    total = tamanWahyu[4];
                }
                else if (to == 5)
                {
                    total = tamanWahyu[5];
                }
                else if (to == 6)
                {
                    total = tamanWahyu[6];
                }
                else if (to == 7)
                {
                    total = tamanWahyu[7];
                }
                else if (to == 8)
                {
                    total = tamanWahyu[8];
                }
                else if (to == 9)
                {
                    total = tamanWahyu[9];
                }
                else if (to == 10)
                {
                    total = tamanWahyu[10];
                }
                else if (to == 11)
                {
                    total = tamanWahyu[11];
                }
                else if (to == 12)
                {
                    total = tamanWahyu[12];
                }
                else if (to == 13)
                {
                    total = tamanWahyu[13];
                }
                else if (to == 14)
                {
                    total = tamanWahyu[14];
                }
                else if (to == 15)
                {
                    total = tamanWahyu[15];
                }
                else if (to == 16)
                {
                    total = tamanWahyu[16];
                }
                else if (to == 17)
                {
                    total = tamanWahyu[17];

                }
                else if (to == 18)
                {
                    total = tamanWahyu[18];
                }
                else if (to == 19)
                {
                    total = tamanWahyu[19];
                }
                else if (to == 20)
                {
                    total = tamanWahyu[20];
                }
                else if (to == 21)
                {
                    total = tamanWahyu[21];
                }
                else if (to == 22)
                {
                    total = tamanWahyu[22];
                }
                else if (to == 23)
                {
                    total = tamanWahyu[23];

                }
                else if (to == 24)
                {
                    total = tamanWahyu[24];
                }
                else if (to == 26)
                {
                    total = batuCaves[25];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[25];

                }
                else if (to == 28)
                {
                    total = kualaKubu[25];
                }
                else if (to == 29)
                {
                    total = rasa[25];
                }
                else if (to == 30)
                {
                    total = batangKali[25];
                }
                else if (to == 31)
                {
                    total = serendah[25];
                }
                else if (to == 32)
                {
                    total = rawang[25];
                }
                else if (to == 33)
                {
                    total = kuang[25];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[25];
                }
                else if (to == 35)
                {
                    total = kepongSentral[25];

                }
                else if (to == 36)
                {
                    total = kepong[25];
                }
                else if (to == 37)
                {
                    total = segambut[25];
                }
                else if (to == 38)
                {
                    total = midValley[25];
                }
                else if (to == 39)
                {
                    total = seputeh[25];
                }
                else if (to == 40)
                {
                    total = salakSelatan[25];
                }
                else if (to == 41)
                {
                    total = btSelatan[25];
                }
                else if (to == 42)
                {
                    total = serdang[25];
                }
                else if (to == 43)
                {
                    total = kajang[25];
                }
                else if (to == 44)
                {
                    total = ukm[25];
                }

                else if (to == 45)
                {
                    total = bangi[25];
                }
                else if (to == 46)
                {
                    total = batangBenar[25];
                }
                else if (to == 47)
                {
                    total = nilai[25];
                }
                else if (to == 48)
                {
                    total = labu[25];
                }
                else if (to == 49)
                {
                    total = tiroi[25];
                }
                else if (to == 50)
                {
                    total = seremban[25];
                }
                else if (to == 51)
                {
                    total = senawang[25];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[25];
                }
                else if (to == 53)
                {
                    total = rembau[25];
                }
                else if (to == 54)
                {
                    total = tampin[25];
                }
                else if (to == 55)
                {
                    total = btgMelaka[25];
                }
                else if (to == 56)
                {
                    total = gemas[25];

                }
            }////////////////////////////////BATU CAVE////////////////////////////
            else if (from == 26)
            {
                if (to == 0)
                {
                    total = batuCaves[0];
                }
                else if (to == 1)
                {
                    total = batuCaves[1];
                }
                else if (to == 2)
                {
                    total = batuCaves[2];
                }
                else if (to == 3)
                {
                    total = batuCaves[3];
                }
                else if (to == 4)
                {
                    total = batuCaves[4];
                }
                else if (to == 5)
                {
                    total = batuCaves[5];
                }
                else if (to == 6)
                {
                    total = batuCaves[6];
                }
                else if (to == 7)
                {
                    total = batuCaves[7];
                }
                else if (to == 8)
                {
                    total = batuCaves[8];
                }
                else if (to == 9)
                {
                    total = batuCaves[9];
                }
                else if (to == 10)
                {
                    total = batuCaves[10];
                }
                else if (to == 11)
                {
                    total = batuCaves[11];
                }
                else if (to == 12)
                {
                    total = batuCaves[12];
                }
                else if (to == 13)
                {
                    total = batuCaves[13];
                }
                else if (to == 14)
                {
                    total = batuCaves[14];
                }
                else if (to == 15)
                {
                    total = batuCaves[15];
                }
                else if (to == 16)
                {
                    total = batuCaves[16];
                }
                else if (to == 17)
                {
                    total = batuCaves[17];

                }
                else if (to == 18)
                {
                    total = batuCaves[18];
                }
                else if (to == 19)
                {
                    total = batuCaves[19];
                }
                else if (to == 20)
                {
                    total = batuCaves[20];
                }
                else if (to == 21)
                {
                    total = batuCaves[21];
                }
                else if (to == 22)
                {
                    total = batuCaves[22];
                }
                else if (to == 23)
                {
                    total = batuCaves[23];

                }
                else if (to == 24)
                {
                    total = batuCaves[24];
                }
                else if (to == 25)
                {
                    total = batuCaves[25];
                }
                else if (to == 27)
                {
                    total = tanjungMalim[26];

                }
                else if (to == 28)
                {
                    total = kualaKubu[26];
                }
                else if (to == 29)
                {
                    total = rasa[26];
                }
                else if (to == 30)
                {
                    total = batangKali[26];
                }
                else if (to == 31)
                {
                    total = serendah[26];
                }
                else if (to == 32)
                {
                    total = rawang[26];
                }
                else if (to == 33)
                {
                    total = kuang[26];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[26];
                }
                else if (to == 35)
                {
                    total = kepongSentral[26];

                }
                else if (to == 36)
                {
                    total = kepong[26];
                }
                else if (to == 37)
                {
                    total = segambut[26];
                }
                else if (to == 38)
                {
                    total = midValley[26];
                }
                else if (to == 39)
                {
                    total = seputeh[26];
                }
                else if (to == 40)
                {
                    total = salakSelatan[26];
                }
                else if (to == 41)
                {
                    total = btSelatan[26];
                }
                else if (to == 42)
                {
                    total = serdang[26];
                }
                else if (to == 43)
                {
                    total = kajang[26];
                }
                else if (to == 44)
                {
                    total = ukm[26];
                }

                else if (to == 45)
                {
                    total = bangi[26];
                }
                else if (to == 46)
                {
                    total = batangBenar[26];
                }
                else if (to == 47)
                {
                    total = nilai[26];
                }
                else if (to == 48)
                {
                    total = labu[26];
                }
                else if (to == 49)
                {
                    total = tiroi[26];
                }
                else if (to == 50)
                {
                    total = seremban[26];
                }
                else if (to == 51)
                {
                    total = senawang[26];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[26];
                }
                else if (to == 53)
                {
                    total = rembau[26];
                }
                else if (to == 54)
                {
                    total = tampin[26];
                }
                else if (to == 55)
                {
                    total = btgMelaka[26];
                }
                else if (to == 56)
                {
                    total = gemas[26];

                }
            }////////////////////////////////////////TANJUNG MALIM///////////////////////////////////////
            else if (from == 27)
            {
                if (to == 0)
                {
                    total = tanjungMalim[0];
                }
                else if (to == 1)
                {
                    total = tanjungMalim[1];
                }
                else if (to == 2)
                {
                    total = tanjungMalim[2];
                }
                else if (to == 3)
                {
                    total = tanjungMalim[3];
                }
                else if (to == 4)
                {
                    total = tanjungMalim[4];
                }
                else if (to == 5)
                {
                    total = tanjungMalim[5];
                }
                else if (to == 6)
                {
                    total = tanjungMalim[6];
                }
                else if (to == 7)
                {
                    total = tanjungMalim[7];
                }
                else if (to == 8)
                {
                    total = tanjungMalim[8];
                }
                else if (to == 9)
                {
                    total = tanjungMalim[9];
                }
                else if (to == 10)
                {
                    total = tanjungMalim[10];
                }
                else if (to == 11)
                {
                    total = tanjungMalim[11];
                }
                else if (to == 12)
                {
                    total = tanjungMalim[12];
                }
                else if (to == 13)
                {
                    total = tanjungMalim[13];
                }
                else if (to == 14)
                {
                    total = tanjungMalim[14];
                }
                else if (to == 15)
                {
                    total = tanjungMalim[15];
                }
                else if (to == 16)
                {
                    total = tanjungMalim[16];
                }
                else if (to == 17)
                {
                    total = tanjungMalim[17];

                }
                else if (to == 18)
                {
                    total = tanjungMalim[18];
                }
                else if (to == 19)
                {
                    total = tanjungMalim[19];
                }
                else if (to == 20)
                {
                    total = tanjungMalim[20];
                }
                else if (to == 21)
                {
                    total = tanjungMalim[21];
                }
                else if (to == 22)
                {
                    total = tanjungMalim[22];
                }
                else if (to == 23)
                {
                    total = tanjungMalim[23];

                }
                else if (to == 24)
                {
                    total = tanjungMalim[24];
                }
                else if (to == 25)
                {
                    total = tanjungMalim[25];
                }
                else if (to == 26)
                {
                    total = tanjungMalim[26];

                }
                else if (to == 28)
                {
                    total = kualaKubu[27];
                }
                else if (to == 29)
                {
                    total = rasa[27];
                }
                else if (to == 30)
                {
                    total = batangKali[27];
                }
                else if (to == 31)
                {
                    total = serendah[27];
                }
                else if (to == 32)
                {
                    total = rawang[27];
                }
                else if (to == 33)
                {
                    total = kuang[27];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[27];
                }
                else if (to == 35)
                {
                    total = kepongSentral[27];

                }
                else if (to == 36)
                {
                    total = kepong[27];
                }
                else if (to == 37)
                {
                    total = segambut[27];
                }
                else if (to == 38)
                {
                    total = midValley[27];
                }
                else if (to == 39)
                {
                    total = seputeh[27];
                }
                else if (to == 40)
                {
                    total = salakSelatan[27];
                }
                else if (to == 41)
                {
                    total = btSelatan[27];
                }
                else if (to == 42)
                {
                    total = serdang[27];
                }
                else if (to == 43)
                {
                    total = kajang[27];
                }
                else if (to == 44)
                {
                    total = ukm[27];
                }

                else if (to == 45)
                {
                    total = bangi[27];
                }
                else if (to == 46)
                {
                    total = batangBenar[27];
                }
                else if (to == 47)
                {
                    total = nilai[27];
                }
                else if (to == 48)
                {
                    total = labu[27];
                }
                else if (to == 49)
                {
                    total = tiroi[27];
                }
                else if (to == 50)
                {
                    total = seremban[27];
                }
                else if (to == 51)
                {
                    total = senawang[27];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[27];
                }
                else if (to == 53)
                {
                    total = rembau[27];
                }
                else if (to == 54)
                {
                    total = tampin[27];
                }
                else if (to == 55)
                {
                    total = btgMelaka[27];
                }
                else if (to == 56)
                {
                    total = gemas[27];

                }
            }////////////////////////////////////Kuala KUBU/////////////////////////

            else if (from == 28)
            {
                if (to == 0)
                {
                    total = kualaKubu[0];
                }
                else if (to == 1)
                {
                    total = kualaKubu[1];
                }
                else if (to == 2)
                {
                    total = kualaKubu[2];
                }
                else if (to == 3)
                {
                    total = kualaKubu[3];
                }
                else if (to == 4)
                {
                    total = kualaKubu[4];
                }
                else if (to == 5)
                {
                    total = kualaKubu[5];
                }
                else if (to == 6)
                {
                    total = kualaKubu[6];
                }
                else if (to == 7)
                {
                    total = kualaKubu[7];
                }
                else if (to == 8)
                {
                    total = kualaKubu[8];
                }
                else if (to == 9)
                {
                    total = kualaKubu[9];
                }
                else if (to == 10)
                {
                    total = kualaKubu[10];
                }
                else if (to == 11)
                {
                    total = kualaKubu[11];
                }
                else if (to == 12)
                {
                    total = kualaKubu[12];
                }
                else if (to == 13)
                {
                    total = kualaKubu[13];
                }
                else if (to == 14)
                {
                    total = kualaKubu[14];
                }
                else if (to == 15)
                {
                    total = kualaKubu[15];
                }
                else if (to == 16)
                {
                    total = kualaKubu[16];
                }
                else if (to == 17)
                {
                    total = kualaKubu[17];

                }
                else if (to == 18)
                {
                    total = kualaKubu[18];
                }
                else if (to == 19)
                {
                    total = kualaKubu[19];
                }
                else if (to == 20)
                {
                    total = kualaKubu[20];
                }
                else if (to == 21)
                {
                    total = kualaKubu[21];
                }
                else if (to == 22)
                {
                    total = kualaKubu[22];
                }
                else if (to == 23)
                {
                    total = kualaKubu[23];

                }
                else if (to == 24)
                {
                    total = kualaKubu[24];
                }
                else if (to == 25)
                {
                    total = kualaKubu[25];
                }
                else if (to == 26)
                {
                    total = kualaKubu[26];

                }
                else if (to == 27)
                {
                    total = kualaKubu[27];
                }
                else if (to == 29)
                {
                    total = rasa[28];
                }
                else if (to == 30)
                {
                    total = batangKali[28];
                }
                else if (to == 31)
                {
                    total = serendah[28];
                }
                else if (to == 32)
                {
                    total = rawang[28];
                }
                else if (to == 33)
                {
                    total = kuang[28];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[28];
                }
                else if (to == 35)
                {
                    total = kepongSentral[28];

                }
                else if (to == 36)
                {
                    total = kepong[28];
                }
                else if (to == 37)
                {
                    total = segambut[28];
                }
                else if (to == 38)
                {
                    total = midValley[28];
                }
                else if (to == 39)
                {
                    total = seputeh[28];
                }
                else if (to == 40)
                {
                    total = salakSelatan[28];
                }
                else if (to == 41)
                {
                    total = btSelatan[28];
                }
                else if (to == 42)
                {
                    total = serdang[28];
                }
                else if (to == 43)
                {
                    total = kajang[28];
                }
                else if (to == 44)
                {
                    total = ukm[28];
                }

                else if (to == 45)
                {
                    total = bangi[28];
                }
                else if (to == 46)
                {
                    total = batangBenar[28];
                }
                else if (to == 47)
                {
                    total = nilai[28];
                }
                else if (to == 48)
                {
                    total = labu[28];
                }
                else if (to == 49)
                {
                    total = tiroi[28];
                }
                else if (to == 50)
                {
                    total = seremban[28];
                }
                else if (to == 51)
                {
                    total = senawang[28];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[28];
                }
                else if (to == 53)
                {
                    total = rembau[28];
                }
                else if (to == 54)
                {
                    total = tampin[28];
                }
                else if (to == 55)
                {
                    total = btgMelaka[28];
                }
                else if (to == 56)
                {
                    total = gemas[28];

                }
            }/////////////////////////////RASA////////////////////////////////
            else if (from == 29)
            {
                if (to == 0)
                {
                    total = rasa[0];
                }
                else if (to == 1)
                {
                    total = rasa[1];
                }
                else if (to == 2)
                {
                    total = rasa[2];
                }
                else if (to == 3)
                {
                    total = rasa[3];
                }
                else if (to == 4)
                {
                    total = rasa[4];
                }
                else if (to == 5)
                {
                    total = rasa[5];
                }
                else if (to == 6)
                {
                    total = rasa[6];
                }
                else if (to == 7)
                {
                    total = rasa[7];
                }
                else if (to == 8)
                {
                    total = rasa[8];
                }
                else if (to == 9)
                {
                    total = rasa[9];
                }
                else if (to == 10)
                {
                    total = rasa[10];
                }
                else if (to == 11)
                {
                    total = rasa[11];
                }
                else if (to == 12)
                {
                    total = rasa[12];
                }
                else if (to == 13)
                {
                    total = rasa[13];
                }
                else if (to == 14)
                {
                    total = rasa[14];
                }
                else if (to == 15)
                {
                    total = rasa[15];
                }
                else if (to == 16)
                {
                    total = rasa[16];
                }
                else if (to == 17)
                {
                    total = rasa[17];

                }
                else if (to == 18)
                {
                    total = rasa[18];
                }
                else if (to == 19)
                {
                    total = rasa[19];
                }
                else if (to == 20)
                {
                    total = rasa[20];
                }
                else if (to == 21)
                {
                    total = rasa[21];
                }
                else if (to == 22)
                {
                    total = rasa[22];
                }
                else if (to == 23)
                {
                    total = rasa[23];

                }
                else if (to == 24)
                {
                    total = rasa[24];
                }
                else if (to == 25)
                {
                    total = rasa[25];
                }
                else if (to == 26)
                {
                    total = rasa[26];

                }
                else if (to == 27)
                {
                    total = rasa[27];
                }
                else if (to == 28)
                {
                    total = rasa[28];
                }
                else if (to == 30)
                {
                    total = batangKali[29];
                }
                else if (to == 31)
                {
                    total = serendah[29];
                }
                else if (to == 32)
                {
                    total = rawang[29];
                }
                else if (to == 33)
                {
                    total = kuang[29];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[29];
                }
                else if (to == 35)
                {
                    total = kepongSentral[29];

                }
                else if (to == 36)
                {
                    total = kepong[29];
                }
                else if (to == 37)
                {
                    total = segambut[29];
                }
                else if (to == 38)
                {
                    total = midValley[29];
                }
                else if (to == 39)
                {
                    total = seputeh[29];
                }
                else if (to == 40)
                {
                    total = salakSelatan[29];
                }
                else if (to == 41)
                {
                    total = btSelatan[29];
                }
                else if (to == 42)
                {
                    total = serdang[29];
                }
                else if (to == 43)
                {
                    total = kajang[29];
                }
                else if (to == 44)
                {
                    total = ukm[29];
                }

                else if (to == 45)
                {
                    total = bangi[29];
                }
                else if (to == 46)
                {
                    total = batangBenar[29];
                }
                else if (to == 47)
                {
                    total = nilai[29];
                }
                else if (to == 48)
                {
                    total = labu[29];
                }
                else if (to == 49)
                {
                    total = tiroi[29];
                }
                else if (to == 50)
                {
                    total = seremban[29];
                }
                else if (to == 51)
                {
                    total = senawang[29];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[29];
                }
                else if (to == 53)
                {
                    total = rembau[29];
                }
                else if (to == 54)
                {
                    total = tampin[29];
                }
                else if (to == 55)
                {
                    total = btgMelaka[29];
                }
                else if (to == 56)
                {
                    total = gemas[29];

                }
            }/////////////////////////////////////BATANG KALI///////////////////////////
            else if (from == 30)
            {
                if (to == 0)
                {
                    total = batangKali[0];
                }
                else if (to == 1)
                {
                    total = batangKali[1];
                }
                else if (to == 2)
                {
                    total = batangKali[2];
                }
                else if (to == 3)
                {
                    total = batangKali[3];
                }
                else if (to == 4)
                {
                    total = batangKali[4];
                }
                else if (to == 5)
                {
                    total = batangKali[5];
                }
                else if (to == 6)
                {
                    total = batangKali[6];
                }
                else if (to == 7)
                {
                    total = batangKali[7];
                }
                else if (to == 8)
                {
                    total = batangKali[8];
                }
                else if (to == 9)
                {
                    total = batangKali[9];
                }
                else if (to == 10)
                {
                    total = batangKali[10];
                }
                else if (to == 11)
                {
                    total = batangKali[11];
                }
                else if (to == 12)
                {
                    total = batangKali[12];
                }
                else if (to == 13)
                {
                    total = batangKali[13];
                }
                else if (to == 14)
                {
                    total = batangKali[14];
                }
                else if (to == 15)
                {
                    total = batangKali[15];
                }
                else if (to == 16)
                {
                    total = batangKali[16];
                }
                else if (to == 17)
                {
                    total = batangKali[17];

                }
                else if (to == 18)
                {
                    total = batangKali[18];
                }
                else if (to == 19)
                {
                    total = batangKali[19];
                }
                else if (to == 20)
                {
                    total = batangKali[20];
                }
                else if (to == 21)
                {
                    total = batangKali[21];
                }
                else if (to == 22)
                {
                    total = batangKali[22];
                }
                else if (to == 23)
                {
                    total = batangKali[23];

                }
                else if (to == 24)
                {
                    total = batangKali[24];
                }
                else if (to == 25)
                {
                    total = batangKali[25];
                }
                else if (to == 26)
                {
                    total = batangKali[26];

                }
                else if (to == 27)
                {
                    total = batangKali[27];
                }
                else if (to == 28)
                {
                    total = batangKali[28];
                }
                else if (to == 29)
                {
                    total = batangKali[29];
                }
                else if (to == 31)
                {
                    total = serendah[30];
                }
                else if (to == 32)
                {
                    total = rawang[30];
                }
                else if (to == 33)
                {
                    total = kuang[30];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[30];
                }
                else if (to == 35)
                {
                    total = kepongSentral[30];

                }
                else if (to == 36)
                {
                    total = kepong[30];
                }
                else if (to == 37)
                {
                    total = segambut[30];
                }
                else if (to == 38)
                {
                    total = midValley[30];
                }
                else if (to == 39)
                {
                    total = seputeh[30];
                }
                else if (to == 40)
                {
                    total = salakSelatan[30];
                }
                else if (to == 41)
                {
                    total = btSelatan[30];
                }
                else if (to == 42)
                {
                    total = serdang[30];
                }
                else if (to == 43)
                {
                    total = kajang[30];
                }
                else if (to == 44)
                {
                    total = ukm[30];
                }

                else if (to == 45)
                {
                    total = bangi[30];
                }
                else if (to == 46)
                {
                    total = batangBenar[30];
                }
                else if (to == 47)
                {
                    total = nilai[30];
                }
                else if (to == 48)
                {
                    total = labu[30];
                }
                else if (to == 49)
                {
                    total = tiroi[30];
                }
                else if (to == 50)
                {
                    total = seremban[30];
                }
                else if (to == 51)
                {
                    total = senawang[30];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[30];
                }
                else if (to == 53)
                {
                    total = rembau[30];
                }
                else if (to == 54)
                {
                    total = tampin[30];
                }
                else if (to == 55)
                {
                    total = btgMelaka[30];
                }
                else if (to == 56)
                {
                    total = gemas[30];

                }
            }///////////////////////////////SERENDAH//////////////////////////
            else if (from == 31)
            {
                if (to == 0)
                {
                    total = serendah[0];
                }
                else if (to == 1)
                {
                    total = serendah[1];
                }
                else if (to == 2)
                {
                    total = serendah[2];
                }
                else if (to == 3)
                {
                    total = serendah[3];
                }
                else if (to == 4)
                {
                    total = serendah[4];
                }
                else if (to == 5)
                {
                    total = serendah[5];
                }
                else if (to == 6)
                {
                    total = serendah[6];
                }
                else if (to == 7)
                {
                    total = serendah[7];
                }
                else if (to == 8)
                {
                    total = serendah[8];
                }
                else if (to == 9)
                {
                    total = serendah[9];
                }
                else if (to == 10)
                {
                    total = serendah[10];
                }
                else if (to == 11)
                {
                    total = serendah[11];
                }
                else if (to == 12)
                {
                    total = serendah[12];
                }
                else if (to == 13)
                {
                    total = serendah[13];
                }
                else if (to == 14)
                {
                    total = serendah[14];
                }
                else if (to == 15)
                {
                    total = serendah[15];
                }
                else if (to == 16)
                {
                    total = serendah[16];
                }
                else if (to == 17)
                {
                    total = serendah[17];

                }
                else if (to == 18)
                {
                    total = serendah[18];
                }
                else if (to == 19)
                {
                    total = serendah[19];
                }
                else if (to == 20)
                {
                    total = serendah[20];
                }
                else if (to == 21)
                {
                    total = serendah[21];
                }
                else if (to == 22)
                {
                    total = serendah[22];
                }
                else if (to == 23)
                {
                    total = serendah[23];

                }
                else if (to == 24)
                {
                    total = serendah[24];
                }
                else if (to == 25)
                {
                    total = serendah[25];
                }
                else if (to == 26)
                {
                    total = serendah[26];

                }
                else if (to == 27)
                {
                    total = serendah[27];
                }
                else if (to == 28)
                {
                    total = serendah[28];
                }
                else if (to == 29)
                {
                    total = serendah[29];
                }
                else if (to == 30)
                {
                    total = serendah[30];
                }
                else if (to == 32)
                {
                    total = rawang[31];
                }
                else if (to == 33)
                {
                    total = kuang[31];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[31];
                }
                else if (to == 35)
                {
                    total = kepongSentral[31];

                }
                else if (to == 36)
                {
                    total = kepong[31];
                }
                else if (to == 37)
                {
                    total = segambut[31];
                }
                else if (to == 38)
                {
                    total = midValley[31];
                }
                else if (to == 39)
                {
                    total = seputeh[31];
                }
                else if (to == 40)
                {
                    total = salakSelatan[31];
                }
                else if (to == 41)
                {
                    total = btSelatan[31];
                }
                else if (to == 42)
                {
                    total = serdang[31];
                }
                else if (to == 43)
                {
                    total = kajang[31];
                }
                else if (to == 44)
                {
                    total = ukm[31];
                }

                else if (to == 45)
                {
                    total = bangi[31];
                }
                else if (to == 46)
                {
                    total = batangBenar[31];
                }
                else if (to == 47)
                {
                    total = nilai[31];
                }
                else if (to == 48)
                {
                    total = labu[31];
                }
                else if (to == 49)
                {
                    total = tiroi[31];
                }
                else if (to == 50)
                {
                    total = seremban[31];
                }
                else if (to == 51)
                {
                    total = senawang[31];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[31];
                }
                else if (to == 53)
                {
                    total = rembau[31];
                }
                else if (to == 54)
                {
                    total = tampin[31];
                }
                else if (to == 55)
                {
                    total = btgMelaka[31];
                }
                else if (to == 56)
                {
                    total = gemas[31];

                }
            }////////////////////////////RAWANG/////////////////////////
            else if (from == 32)
            {
                if (to == 0)
                {
                    total = rawang[0];
                }
                else if (to == 1)
                {
                    total = rawang[1];
                }
                else if (to == 2)
                {
                    total = rawang[2];
                }
                else if (to == 3)
                {
                    total = rawang[3];
                }
                else if (to == 4)
                {
                    total = rawang[4];
                }
                else if (to == 5)
                {
                    total = rawang[5];
                }
                else if (to == 6)
                {
                    total = rawang[6];
                }
                else if (to == 7)
                {
                    total = rawang[7];
                }
                else if (to == 8)
                {
                    total = rawang[8];
                }
                else if (to == 9)
                {
                    total = rawang[9];
                }
                else if (to == 10)
                {
                    total = rawang[10];
                }
                else if (to == 11)
                {
                    total = rawang[11];
                }
                else if (to == 12)
                {
                    total = rawang[12];
                }
                else if (to == 13)
                {
                    total = rawang[13];
                }
                else if (to == 14)
                {
                    total = rawang[14];
                }
                else if (to == 15)
                {
                    total = rawang[15];
                }
                else if (to == 16)
                {
                    total = rawang[16];
                }
                else if (to == 17)
                {
                    total = rawang[17];

                }
                else if (to == 18)
                {
                    total = rawang[18];
                }
                else if (to == 19)
                {
                    total = rawang[19];
                }
                else if (to == 20)
                {
                    total = rawang[20];
                }
                else if (to == 21)
                {
                    total = rawang[21];
                }
                else if (to == 22)
                {
                    total = rawang[22];
                }
                else if (to == 23)
                {
                    total = rawang[23];

                }
                else if (to == 24)
                {
                    total = rawang[24];
                }
                else if (to == 25)
                {
                    total = rawang[25];
                }
                else if (to == 26)
                {
                    total = rawang[26];

                }
                else if (to == 27)
                {
                    total = rawang[27];
                }
                else if (to == 28)
                {
                    total = rawang[28];
                }
                else if (to == 19)
                {
                    total = rawang[29];
                }
                else if (to == 30)
                {
                    total = rawang[30];
                }
                else if (to == 31)
                {
                    total = rawang[31];
                }
                else if (to == 33)
                {
                    total = kuang[32];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[32];
                }
                else if (to == 35)
                {
                    total = kepongSentral[32];

                }
                else if (to == 36)
                {
                    total = kepong[32];
                }
                else if (to == 37)
                {
                    total = segambut[32];
                }
                else if (to == 38)
                {
                    total = midValley[32];
                }
                else if (to == 39)
                {
                    total = seputeh[32];
                }
                else if (to == 40)
                {
                    total = salakSelatan[32];
                }
                else if (to == 41)
                {
                    total = btSelatan[32];
                }
                else if (to == 42)
                {
                    total = serdang[32];
                }
                else if (to == 43)
                {
                    total = kajang[32];
                }
                else if (to == 44)
                {
                    total = ukm[32];
                }

                else if (to == 45)
                {
                    total = bangi[32];
                }
                else if (to == 46)
                {
                    total = batangBenar[32];
                }
                else if (to == 47)
                {
                    total = nilai[32];
                }
                else if (to == 48)
                {
                    total = labu[32];
                }
                else if (to == 49)
                {
                    total = tiroi[32];
                }
                else if (to == 50)
                {
                    total = seremban[32];
                }
                else if (to == 51)
                {
                    total = senawang[32];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[32];
                }
                else if (to == 53)
                {
                    total = rembau[32];
                }
                else if (to == 54)
                {
                    total = tampin[32];
                }
                else if (to == 55)
                {
                    total = btgMelaka[32];
                }
                else if (to == 56)
                {
                    total = gemas[32];

                }
            }/////////////////////////////////KUANG//////////////////////////

            else if (from == 33)
            {
                if (to == 0)
                {
                    total = kuang[0];
                }
                else if (to == 1)
                {
                    total = kuang[1];
                }
                else if (to == 2)
                {
                    total = kuang[2];
                }
                else if (to == 3)
                {
                    total = kuang[3];
                }
                else if (to == 4)
                {
                    total = kuang[4];
                }
                else if (to == 5)
                {
                    total = kuang[5];
                }
                else if (to == 6)
                {
                    total = kuang[6];
                }
                else if (to == 7)
                {
                    total = kuang[7];
                }
                else if (to == 8)
                {
                    total = kuang[8];
                }
                else if (to == 9)
                {
                    total = kuang[9];
                }
                else if (to == 10)
                {
                    total = kuang[10];
                }
                else if (to == 11)
                {
                    total = kuang[11];
                }
                else if (to == 12)
                {
                    total = kuang[12];
                }
                else if (to == 13)
                {
                    total = kuang[13];
                }
                else if (to == 14)
                {
                    total = kuang[14];
                }
                else if (to == 15)
                {
                    total = kuang[15];
                }
                else if (to == 16)
                {
                    total = kuang[16];
                }
                else if (to == 17)
                {
                    total = kuang[17];

                }
                else if (to == 18)
                {
                    total = kuang[18];
                }
                else if (to == 19)
                {
                    total = kuang[19];
                }
                else if (to == 20)
                {
                    total = kuang[20];
                }
                else if (to == 21)
                {
                    total = kuang[21];
                }
                else if (to == 22)
                {
                    total = kuang[22];
                }
                else if (to == 23)
                {
                    total = kuang[23];

                }
                else if (to == 24)
                {
                    total = kuang[24];
                }
                else if (to == 25)
                {
                    total = kuang[25];
                }
                else if (to == 26)
                {
                    total = kuang[26];

                }
                else if (to == 27)
                {
                    total = kuang[27];
                }
                else if (to == 28)
                {
                    total = kuang[28];
                }
                else if (to == 29)
                {
                    total = kuang[29];
                }
                else if (to == 30)
                {
                    total = kuang[30];
                }
                else if (to == 31)
                {
                    total = kuang[31];
                }
                else if (to == 32)
                {
                    total = kuang[32];

                }
                else if (to == 34)
                {
                    total = sungaiBuloh[33];
                }
                else if (to == 35)
                {
                    total = kepongSentral[33];

                }
                else if (to == 36)
                {
                    total = kepong[33];
                }
                else if (to == 37)
                {
                    total = segambut[33];
                }
                else if (to == 38)
                {
                    total = midValley[33];
                }
                else if (to == 39)
                {
                    total = seputeh[33];
                }
                else if (to == 40)
                {
                    total = salakSelatan[33];
                }
                else if (to == 41)
                {
                    total = btSelatan[33];
                }
                else if (to == 42)
                {
                    total = serdang[33];
                }
                else if (to == 43)
                {
                    total = kajang[33];
                }
                else if (to == 44)
                {
                    total = ukm[33];
                }

                else if (to == 45)
                {
                    total = bangi[33];
                }
                else if (to == 46)
                {
                    total = batangBenar[33];
                }
                else if (to == 47)
                {
                    total = nilai[33];
                }
                else if (to == 48)
                {
                    total = labu[33];
                }
                else if (to == 49)
                {
                    total = tiroi[33];
                }
                else if (to == 50)
                {
                    total = seremban[33];
                }
                else if (to == 51)
                {
                    total = senawang[33];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[33];
                }
                else if (to == 53)
                {
                    total = rembau[33];
                }
                else if (to == 54)
                {
                    total = tampin[33];
                }
                else if (to == 55)
                {
                    total = btgMelaka[33];
                }
                else if (to == 56)
                {
                    total = gemas[33];

                }
            }/////////////////////////////////SUNGAI BULOH////////////////////

            else if (from == 34)
            {
                if (to == 0)
                {
                    total = sungaiBuloh[0];
                }
                else if (to == 1)
                {
                    total = sungaiBuloh[1];
                }
                else if (to == 2)
                {
                    total = sungaiBuloh[2];
                }
                else if (to == 3)
                {
                    total = sungaiBuloh[3];
                }
                else if (to == 4)
                {
                    total = sungaiBuloh[4];
                }
                else if (to == 5)
                {
                    total = sungaiBuloh[5];
                }
                else if (to == 6)
                {
                    total = sungaiBuloh[6];
                }
                else if (to == 7)
                {
                    total = sungaiBuloh[7];
                }
                else if (to == 8)
                {
                    total = sungaiBuloh[8];
                }
                else if (to == 9)
                {
                    total = sungaiBuloh[9];
                }
                else if (to == 10)
                {
                    total = sungaiBuloh[10];
                }
                else if (to == 11)
                {
                    total = sungaiBuloh[11];
                }
                else if (to == 12)
                {
                    total = sungaiBuloh[12];
                }
                else if (to == 13)
                {
                    total = sungaiBuloh[13];
                }
                else if (to == 14)
                {
                    total = sungaiBuloh[14];
                }
                else if (to == 15)
                {
                    total = sungaiBuloh[15];
                }
                else if (to == 16)
                {
                    total = sungaiBuloh[16];
                }
                else if (to == 17)
                {
                    total = sungaiBuloh[17];

                }
                else if (to == 18)
                {
                    total = sungaiBuloh[18];
                }
                else if (to == 19)
                {
                    total = sungaiBuloh[19];
                }
                else if (to == 20)
                {
                    total = sungaiBuloh[20];
                }
                else if (to == 21)
                {
                    total = sungaiBuloh[21];
                }
                else if (to == 22)
                {
                    total = sungaiBuloh[22];
                }
                else if (to == 23)
                {
                    total = sungaiBuloh[23];

                }
                else if (to == 24)
                {
                    total = sungaiBuloh[24];
                }
                else if (to == 25)
                {
                    total = sungaiBuloh[25];
                }
                else if (to == 26)
                {
                    total = sungaiBuloh[26];

                }
                else if (to == 27)
                {
                    total = sungaiBuloh[27];
                }
                else if (to == 28)
                {
                    total = sungaiBuloh[28];
                }
                else if (to == 29)
                {
                    total = sungaiBuloh[29];
                }
                else if (to == 30)
                {
                    total = sungaiBuloh[30];
                }
                else if (to == 31)
                {
                    total = sungaiBuloh[31];
                }
                else if (to == 32)
                {
                    total = sungaiBuloh[32];

                }
                else if (to == 33)
                {
                    total = sungaiBuloh[33];
                }
                else if (to == 35)
                {
                    total = kepongSentral[34];

                }
                else if (to == 36)
                {
                    total = kepong[34];
                }
                else if (to == 37)
                {
                    total = segambut[34];
                }
                else if (to == 38)
                {
                    total = midValley[34];
                }
                else if (to == 39)
                {
                    total = seputeh[34];
                }
                else if (to == 40)
                {
                    total = salakSelatan[34];
                }
                else if (to == 41)
                {
                    total = btSelatan[34];
                }
                else if (to == 42)
                {
                    total = serdang[34];
                }
                else if (to == 43)
                {
                    total = kajang[34];
                }
                else if (to == 44)
                {
                    total = ukm[34];
                }

                else if (to == 45)
                {
                    total = bangi[34];
                }
                else if (to == 46)
                {
                    total = batangBenar[34];
                }
                else if (to == 47)
                {
                    total = nilai[34];
                }
                else if (to == 48)
                {
                    total = labu[34];
                }
                else if (to == 49)
                {
                    total = tiroi[34];
                }
                else if (to == 50)
                {
                    total = seremban[34];
                }
                else if (to == 51)
                {
                    total = senawang[34];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[34];
                }
                else if (to == 53)
                {
                    total = rembau[34];
                }
                else if (to == 54)
                {
                    total = tampin[34];
                }
                else if (to == 55)
                {
                    total = btgMelaka[34];
                }
                else if (to == 56)
                {
                    total = gemas[34];

                }
            }///////////////////////////KEPONG SENTRAL///////////////////////

            else if (from == 35)
            {
                if (to == 0)
                {
                    total = kepongSentral[0];
                }
                else if (to == 1)
                {
                    total = kepongSentral[1];
                }
                else if (to == 2)
                {
                    total = kepongSentral[2];
                }
                else if (to == 3)
                {
                    total = kepongSentral[3];
                }
                else if (to == 4)
                {
                    total = kepongSentral[4];
                }
                else if (to == 5)
                {
                    total = kepongSentral[5];
                }
                else if (to == 6)
                {
                    total = kepongSentral[6];
                }
                else if (to == 7)
                {
                    total = kepongSentral[7];
                }
                else if (to == 8)
                {
                    total = kepongSentral[8];
                }
                else if (to == 9)
                {
                    total = kepongSentral[9];
                }
                else if (to == 10)
                {
                    total = kepongSentral[10];
                }
                else if (to == 11)
                {
                    total = kepongSentral[11];
                }
                else if (to == 12)
                {
                    total = kepongSentral[12];
                }
                else if (to == 13)
                {
                    total = kepongSentral[13];
                }
                else if (to == 14)
                {
                    total = kepongSentral[14];
                }
                else if (to == 15)
                {
                    total = kepongSentral[15];
                }
                else if (to == 16)
                {
                    total = kepongSentral[16];
                }
                else if (to == 17)
                {
                    total = kepongSentral[17];

                }
                else if (to == 18)
                {
                    total = kepongSentral[18];
                }
                else if (to == 19)
                {
                    total = kepongSentral[19];
                }
                else if (to == 20)
                {
                    total = kepongSentral[20];
                }
                else if (to == 21)
                {
                    total = kepongSentral[21];
                }
                else if (to == 22)
                {
                    total = kepongSentral[22];
                }
                else if (to == 23)
                {
                    total = kepongSentral[23];

                }
                else if (to == 24)
                {
                    total = kepongSentral[24];
                }
                else if (to == 25)
                {
                    total = kepongSentral[25];
                }
                else if (to == 26)
                {
                    total = kepongSentral[26];

                }
                else if (to == 27)
                {
                    total = kepongSentral[27];
                }
                else if (to == 28)
                {
                    total = kepongSentral[28];
                }
                else if (to == 29)
                {
                    total = kepongSentral[29];
                }
                else if (to == 30)
                {
                    total = kepongSentral[30];
                }
                else if (to == 31)
                {
                    total = kepongSentral[31];
                }
                else if (to == 32)
                {
                    total = kepongSentral[32];

                }
                else if (to == 33)
                {
                    total = kepongSentral[33];
                }
                else if (to == 34)
                {
                    total = kepongSentral[34];

                }
                else if (to == 36)
                {
                    total = kepong[35];
                }
                else if (to == 37)
                {
                    total = segambut[35];
                }
                else if (to == 38)
                {
                    total = midValley[35];
                }
                else if (to == 39)
                {
                    total = seputeh[35];
                }
                else if (to == 40)
                {
                    total = salakSelatan[35];
                }
                else if (to == 41)
                {
                    total = btSelatan[35];
                }
                else if (to == 42)
                {
                    total = serdang[35];
                }
                else if (to == 43)
                {
                    total = kajang[35];
                }
                else if (to == 44)
                {
                    total = ukm[35];
                }

                else if (to == 45)
                {
                    total = bangi[35];
                }
                else if (to == 46)
                {
                    total = batangBenar[35];
                }
                else if (to == 47)
                {
                    total = nilai[35];
                }
                else if (to == 48)
                {
                    total = labu[35];
                }
                else if (to == 49)
                {
                    total = tiroi[35];
                }
                else if (to == 50)
                {
                    total = seremban[35];
                }
                else if (to == 51)
                {
                    total = senawang[35];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[35];
                }
                else if (to == 53)
                {
                    total = rembau[35];
                }
                else if (to == 54)
                {
                    total = tampin[35];
                }
                else if (to == 55)
                {
                    total = btgMelaka[35];
                }
                else if (to == 56)
                {
                    total = gemas[35];

                }
            }//////////////////////////////////////KEPONG////////////////////////////

            else if (from == 36)
            {
                if (to == 0)
                {
                    total = kepong[0];
                }
                else if (to == 1)
                {
                    total = kepong[1];
                }
                else if (to == 2)
                {
                    total = kepong[2];
                }
                else if (to == 3)
                {
                    total = kepong[3];
                }
                else if (to == 4)
                {
                    total = kepong[4];
                }
                else if (to == 5)
                {
                    total = kepong[5];
                }
                else if (to == 6)
                {
                    total = kepong[6];
                }
                else if (to == 7)
                {
                    total = kepong[7];
                }
                else if (to == 8)
                {
                    total = kepong[8];
                }
                else if (to == 9)
                {
                    total = kepong[9];
                }
                else if (to == 10)
                {
                    total = kepong[10];
                }
                else if (to == 11)
                {
                    total = kepong[11];
                }
                else if (to == 12)
                {
                    total = kepong[12];
                }
                else if (to == 13)
                {
                    total = kepong[13];
                }
                else if (to == 14)
                {
                    total = kepong[14];
                }
                else if (to == 15)
                {
                    total = kepong[15];
                }
                else if (to == 16)
                {
                    total = kepong[16];
                }
                else if (to == 17)
                {
                    total = kepong[17];

                }
                else if (to == 18)
                {
                    total = kepong[18];
                }
                else if (to == 19)
                {
                    total = kepong[19];
                }
                else if (to == 20)
                {
                    total = kepong[20];
                }
                else if (to == 21)
                {
                    total = kepong[21];
                }
                else if (to == 22)
                {
                    total = kepong[22];
                }
                else if (to == 23)
                {
                    total = kepong[23];

                }
                else if (to == 24)
                {
                    total = kepong[24];
                }
                else if (to == 25)
                {
                    total = kepong[25];
                }
                else if (to == 26)
                {
                    total = kepong[26];

                }
                else if (to == 27)
                {
                    total = kepong[27];
                }
                else if (to == 28)
                {
                    total = kepong[28];
                }
                else if (to == 29)
                {
                    total = kepong[29];
                }
                else if (to == 30)
                {
                    total = kepong[30];
                }
                else if (to == 31)
                {
                    total = kepong[31];
                }
                else if (to == 32)
                {
                    total = kepong[32];

                }
                else if (to == 33)
                {
                    total = kepong[33];
                }
                else if (to == 34)
                {
                    total = kepong[34];

                }
                else if (to == 35)
                {
                    total = kepong[35];
                }
                else if (to == 37)
                {
                    total = segambut[38];
                }
                else if (to == 38)
                {
                    total = midValley[36];
                }
                else if (to == 39)
                {
                    total = seputeh[36];
                }
                else if (to == 40)
                {
                    total = salakSelatan[36];
                }
                else if (to == 41)
                {
                    total = btSelatan[36];
                }
                else if (to == 42)
                {
                    total = serdang[36];
                }
                else if (to == 43)
                {
                    total = kajang[36];
                }
                else if (to == 44)
                {
                    total = ukm[36];
                }

                else if (to == 45)
                {
                    total = bangi[36];
                }
                else if (to == 46)
                {
                    total = batangBenar[36];
                }
                else if (to == 47)
                {
                    total = nilai[36];
                }
                else if (to == 48)
                {
                    total = labu[36];
                }
                else if (to == 49)
                {
                    total = tiroi[36];
                }
                else if (to == 50)
                {
                    total = seremban[36];
                }
                else if (to == 51)
                {
                    total = senawang[36];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[36];
                }
                else if (to == 53)
                {
                    total = rembau[36];
                }
                else if (to == 54)
                {
                    total = tampin[36];
                }
                else if (to == 55)
                {
                    total = btgMelaka[36];
                }
                else if (to == 56)
                {
                    total = gemas[36];

                }
            }////////////////////////////////////SEGAMBUT//////////////////////

            else if (from == 37)
            {
                if (to == 0)
                {
                    total = segambut[0];
                }
                else if (to == 1)
                {
                    total = segambut[1];
                }
                else if (to == 2)
                {
                    total = segambut[2];
                }
                else if (to == 3)
                {
                    total = segambut[3];
                }
                else if (to == 4)
                {
                    total = segambut[4];
                }
                else if (to == 5)
                {
                    total = segambut[5];
                }
                else if (to == 6)
                {
                    total = segambut[6];
                }
                else if (to == 7)
                {
                    total = segambut[7];
                }
                else if (to == 8)
                {
                    total = segambut[8];
                }
                else if (to == 9)
                {
                    total = segambut[9];
                }
                else if (to == 10)
                {
                    total = segambut[10];
                }
                else if (to == 11)
                {
                    total = segambut[11];
                }
                else if (to == 12)
                {
                    total = segambut[12];
                }
                else if (to == 13)
                {
                    total = segambut[13];
                }
                else if (to == 14)
                {
                    total = segambut[14];
                }
                else if (to == 15)
                {
                    total = segambut[15];
                }
                else if (to == 16)
                {
                    total = segambut[16];
                }
                else if (to == 17)
                {
                    total = segambut[17];

                }
                else if (to == 18)
                {
                    total = segambut[18];
                }
                else if (to == 19)
                {
                    total = segambut[19];
                }
                else if (to == 20)
                {
                    total = segambut[20];
                }
                else if (to == 21)
                {
                    total = segambut[21];
                }
                else if (to == 22)
                {
                    total = segambut[22];
                }
                else if (to == 23)
                {
                    total = segambut[23];

                }
                else if (to == 24)
                {
                    total = segambut[24];
                }
                else if (to == 25)
                {
                    total = segambut[25];
                }
                else if (to == 26)
                {
                    total = segambut[26];

                }
                else if (to == 27)
                {
                    total = segambut[27];
                }
                else if (to == 28)
                {
                    total = segambut[28];
                }
                else if (to == 29)
                {
                    total = segambut[29];
                }
                else if (to == 30)
                {
                    total = segambut[30];
                }
                else if (to == 31)
                {
                    total = segambut[31];
                }
                else if (to == 32)
                {
                    total = segambut[32];

                }
                else if (to == 33)
                {
                    total = segambut[33];
                }
                else if (to == 34)
                {
                    total = segambut[34];

                }
                else if (to == 35)
                {
                    total = segambut[35];
                }
                else if (to == 36)
                {
                    total = segambut[36];
                }
                else if (to == 38)
                {
                    total = midValley[37];
                }
                else if (to == 39)
                {
                    total = seputeh[37];
                }
                else if (to == 40)
                {
                    total = salakSelatan[37];
                }
                else if (to == 41)
                {
                    total = btSelatan[37];
                }
                else if (to == 42)
                {
                    total = serdang[37];
                }
                else if (to == 43)
                {
                    total = kajang[37];
                }
                else if (to == 44)
                {
                    total = ukm[37];
                }

                else if (to == 45)
                {
                    total = bangi[37];
                }
                else if (to == 46)
                {
                    total = batangBenar[37];
                }
                else if (to == 47)
                {
                    total = nilai[37];
                }
                else if (to == 48)
                {
                    total = labu[37];
                }
                else if (to == 49)
                {
                    total = tiroi[37];
                }
                else if (to == 50)
                {
                    total = seremban[37];
                }
                else if (to == 51)
                {
                    total = senawang[37];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[37];
                }
                else if (to == 53)
                {
                    total = rembau[37];
                }
                else if (to == 54)
                {
                    total = tampin[37];
                }
                else if (to == 55)
                {
                    total = btgMelaka[37];
                }
                else if (to == 56)
                {
                    total = gemas[37];

                }
            }/////////////////////////////////MID VALLEY/////////////////////////

            else if (from == 38)
            {
                if (to == 0)
                {
                    total = midValley[0];
                }
                else if (to == 1)
                {
                    total = midValley[1];
                }
                else if (to == 2)
                {
                    total = midValley[2];
                }
                else if (to == 3)
                {
                    total = midValley[3];
                }
                else if (to == 4)
                {
                    total = midValley[4];
                }
                else if (to == 5)
                {
                    total = midValley[5];
                }
                else if (to == 6)
                {
                    total = midValley[6];
                }
                else if (to == 7)
                {
                    total = midValley[7];
                }
                else if (to == 8)
                {
                    total = midValley[8];
                }
                else if (to == 9)
                {
                    total = midValley[9];
                }
                else if (to == 10)
                {
                    total = midValley[10];
                }
                else if (to == 11)
                {
                    total = midValley[11];
                }
                else if (to == 12)
                {
                    total = midValley[12];
                }
                else if (to == 13)
                {
                    total = midValley[13];
                }
                else if (to == 14)
                {
                    total = midValley[14];
                }
                else if (to == 15)
                {
                    total = midValley[15];
                }
                else if (to == 16)
                {
                    total = midValley[16];
                }
                else if (to == 17)
                {
                    total = midValley[17];

                }
                else if (to == 18)
                {
                    total = midValley[18];
                }
                else if (to == 19)
                {
                    total = midValley[19];
                }
                else if (to == 20)
                {
                    total = midValley[20];
                }
                else if (to == 21)
                {
                    total = midValley[21];
                }
                else if (to == 22)
                {
                    total = midValley[22];
                }
                else if (to == 23)
                {
                    total = midValley[23];

                }
                else if (to == 24)
                {
                    total = midValley[24];
                }
                else if (to == 25)
                {
                    total = midValley[25];
                }
                else if (to == 26)
                {
                    total = midValley[26];

                }
                else if (to == 27)
                {
                    total = midValley[27];
                }
                else if (to == 28)
                {
                    total = midValley[28];
                }
                else if (to == 29)
                {
                    total = midValley[29];
                }
                else if (to == 30)
                {
                    total = midValley[30];
                }
                else if (to == 31)
                {
                    total = midValley[31];
                }
                else if (to == 32)
                {
                    total = midValley[32];

                }
                else if (to == 33)
                {
                    total = midValley[33];
                }
                else if (to == 34)
                {
                    total = midValley[34];

                }
                else if (to == 35)
                {
                    total = midValley[35];
                }
                else if (to == 36)
                {
                    total = midValley[36];
                }
                else if (to == 37)
                {
                    total = midValley[37];
                }
                else if (to == 39)
                {
                    total = seputeh[38];
                }
                else if (to == 40)
                {
                    total = salakSelatan[38];
                }
                else if (to == 41)
                {
                    total = btSelatan[38];
                }
                else if (to == 42)
                {
                    total = serdang[38];
                }
                else if (to == 43)
                {
                    total = kajang[38];
                }
                else if (to == 44)
                {
                    total = ukm[38];
                }

                else if (to == 45)
                {
                    total = bangi[38];
                }
                else if (to == 46)
                {
                    total = batangBenar[38];
                }
                else if (to == 47)
                {
                    total = nilai[38];
                }
                else if (to == 48)
                {
                    total = labu[38];
                }
                else if (to == 49)
                {
                    total = tiroi[38];
                }
                else if (to == 50)
                {
                    total = seremban[38];
                }
                else if (to == 51)
                {
                    total = senawang[38];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[38];
                }
                else if (to == 53)
                {
                    total = rembau[38];
                }
                else if (to == 54)
                {
                    total = tampin[38];
                }
                else if (to == 55)
                {
                    total = btgMelaka[38];
                }
                else if (to == 56)
                {
                    total = gemas[38];

                }
            }////////////////////////SEPUTEH/////////////////////////////////

            else if (from == 39)
            {
                if (to == 0)
                {
                    total = seputeh[0];
                }
                else if (to == 1)
                {
                    total = seputeh[1];
                }
                else if (to == 2)
                {
                    total = seputeh[2];
                }
                else if (to == 3)
                {
                    total = seputeh[3];
                }
                else if (to == 4)
                {
                    total = seputeh[4];
                }
                else if (to == 5)
                {
                    total = seputeh[5];
                }
                else if (to == 6)
                {
                    total = seputeh[6];
                }
                else if (to == 7)
                {
                    total = seputeh[7];
                }
                else if (to == 8)
                {
                    total = seputeh[8];
                }
                else if (to == 9)
                {
                    total = seputeh[9];
                }
                else if (to == 10)
                {
                    total = seputeh[10];
                }
                else if (to == 11)
                {
                    total = seputeh[11];
                }
                else if (to == 12)
                {
                    total = seputeh[12];
                }
                else if (to == 13)
                {
                    total = seputeh[13];
                }
                else if (to == 14)
                {
                    total = seputeh[14];
                }
                else if (to == 15)
                {
                    total = seputeh[15];
                }
                else if (to == 16)
                {
                    total = seputeh[16];
                }
                else if (to == 17)
                {
                    total = seputeh[17];

                }
                else if (to == 18)
                {
                    total = seputeh[18];
                }
                else if (to == 19)
                {
                    total = seputeh[19];
                }
                else if (to == 20)
                {
                    total = seputeh[20];
                }
                else if (to == 21)
                {
                    total = seputeh[21];
                }
                else if (to == 22)
                {
                    total = seputeh[22];
                }
                else if (to == 23)
                {
                    total = seputeh[23];

                }
                else if (to == 24)
                {
                    total = seputeh[24];
                }
                else if (to == 25)
                {
                    total = seputeh[25];
                }
                else if (to == 26)
                {
                    total = seputeh[26];

                }
                else if (to == 27)
                {
                    total = seputeh[27];
                }
                else if (to == 28)
                {
                    total = seputeh[28];
                }
                else if (to == 29)
                {
                    total = seputeh[29];
                }
                else if (to == 30)
                {
                    total = seputeh[30];
                }
                else if (to == 31)
                {
                    total = seputeh[31];
                }
                else if (to == 32)
                {
                    total = seputeh[32];

                }
                else if (to == 33)
                {
                    total = seputeh[33];
                }
                else if (to == 34)
                {
                    total = seputeh[34];

                }
                else if (to == 35)
                {
                    total = seputeh[35];
                }
                else if (to == 36)
                {
                    total = seputeh[36];
                }
                else if (to == 37)
                {
                    total = seputeh[37];
                }
                else if (to == 38)
                {
                    total = seputeh[38];
                }
                else if (to == 40)
                {
                    total = salakSelatan[39];
                }
                else if (to == 41)
                {
                    total = btSelatan[39];
                }
                else if (to == 42)
                {
                    total = serdang[39];
                }
                else if (to == 43)
                {
                    total = kajang[39];
                }
                else if (to == 44)
                {
                    total = ukm[39];
                }

                else if (to == 45)
                {
                    total = bangi[39];
                }
                else if (to == 46)
                {
                    total = batangBenar[39];
                }
                else if (to == 47)
                {
                    total = nilai[39];
                }
                else if (to == 48)
                {
                    total = labu[39];
                }
                else if (to == 49)
                {
                    total = tiroi[39];
                }
                else if (to == 50)
                {
                    total = seremban[39];
                }
                else if (to == 51)
                {
                    total = senawang[39];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[39];
                }
                else if (to == 53)
                {
                    total = rembau[39];
                }
                else if (to == 54)
                {
                    total = tampin[39];
                }
                else if (to == 55)
                {
                    total = btgMelaka[39];
                }
                else if (to == 56)
                {
                    total = gemas[39];

                }
            }//////////////////////////////SALAK SELATAN//////////////////////////

            else if (from == 40)
            {
                if (to == 0)
                {
                    total = salakSelatan[0];
                }
                else if (to == 1)
                {
                    total = salakSelatan[1];
                }
                else if (to == 2)
                {
                    total = salakSelatan[2];
                }
                else if (to == 3)
                {
                    total = salakSelatan[3];
                }
                else if (to == 4)
                {
                    total = salakSelatan[4];
                }
                else if (to == 5)
                {
                    total = salakSelatan[5];
                }
                else if (to == 6)
                {
                    total = salakSelatan[6];
                }
                else if (to == 7)
                {
                    total = salakSelatan[7];
                }
                else if (to == 8)
                {
                    total = salakSelatan[8];
                }
                else if (to == 9)
                {
                    total = salakSelatan[9];
                }
                else if (to == 10)
                {
                    total = salakSelatan[10];
                }
                else if (to == 11)
                {
                    total = salakSelatan[11];
                }
                else if (to == 12)
                {
                    total = salakSelatan[12];
                }
                else if (to == 13)
                {
                    total = salakSelatan[13];
                }
                else if (to == 14)
                {
                    total = salakSelatan[14];
                }
                else if (to == 15)
                {
                    total = salakSelatan[15];
                }
                else if (to == 16)
                {
                    total = salakSelatan[16];
                }
                else if (to == 17)
                {
                    total = salakSelatan[17];

                }
                else if (to == 18)
                {
                    total = salakSelatan[18];
                }
                else if (to == 19)
                {
                    total = salakSelatan[19];
                }
                else if (to == 20)
                {
                    total = salakSelatan[20];
                }
                else if (to == 21)
                {
                    total = salakSelatan[21];
                }
                else if (to == 22)
                {
                    total = salakSelatan[22];
                }
                else if (to == 23)
                {
                    total = salakSelatan[23];

                }
                else if (to == 24)
                {
                    total = salakSelatan[24];
                }
                else if (to == 25)
                {
                    total = salakSelatan[25];
                }
                else if (to == 26)
                {
                    total = salakSelatan[26];

                }
                else if (to == 27)
                {
                    total = salakSelatan[27];
                }
                else if (to == 28)
                {
                    total = salakSelatan[28];
                }
                else if (to == 29)
                {
                    total = salakSelatan[29];
                }
                else if (to == 30)
                {
                    total = salakSelatan[30];
                }
                else if (to == 31)
                {
                    total = salakSelatan[31];
                }
                else if (to == 32)
                {
                    total = salakSelatan[32];

                }
                else if (to == 33)
                {
                    total = salakSelatan[33];
                }
                else if (to == 34)
                {
                    total = salakSelatan[34];

                }
                else if (to == 35)
                {
                    total = salakSelatan[35];
                }
                else if (to == 36)
                {
                    total = salakSelatan[36];
                }
                else if (to == 37)
                {
                    total = salakSelatan[37];
                }
                else if (to == 38)
                {
                    total = salakSelatan[38];
                }
                else if (to == 39)
                {
                    total = salakSelatan[39];
                }
                else if (to == 41)
                {
                    total = btSelatan[40];
                }
                else if (to == 42)
                {
                    total = serdang[40];
                }
                else if (to == 43)
                {
                    total = kajang[40];
                }
                else if (to == 44)
                {
                    total = ukm[40];
                }

                else if (to == 45)
                {
                    total = bangi[40];
                }
                else if (to == 46)
                {
                    total = batangBenar[40];
                }
                else if (to == 47)
                {
                    total = nilai[40];
                }
                else if (to == 48)
                {
                    total = labu[40];
                }
                else if (to == 49)
                {
                    total = tiroi[40];
                }
                else if (to == 50)
                {
                    total = seremban[40];
                }
                else if (to == 51)
                {
                    total = senawang[40];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[40];
                }
                else if (to == 53)
                {
                    total = rembau[40];
                }
                else if (to == 54)
                {
                    total = tampin[40];
                }
                else if (to == 55)
                {
                    total = btgMelaka[40];
                }
                else if (to == 56)
                {
                    total = gemas[40];

                }
            }///////////////////////////////////BT SELATAN/////////////////////////////////
            else if (from == 41)
            {
                if (to == 0)
                {
                    total = btSelatan[0];
                }
                else if (to == 1)
                {
                    total = btSelatan[1];
                }
                else if (to == 2)
                {
                    total = btSelatan[2];
                }
                else if (to == 3)
                {
                    total = btSelatan[3];
                }
                else if (to == 4)
                {
                    total = btSelatan[4];
                }
                else if (to == 5)
                {
                    total = btSelatan[5];
                }
                else if (to == 6)
                {
                    total = btSelatan[6];
                }
                else if (to == 7)
                {
                    total = btSelatan[7];
                }
                else if (to == 8)
                {
                    total = btSelatan[8];
                }
                else if (to == 9)
                {
                    total = btSelatan[9];
                }
                else if (to == 10)
                {
                    total = btSelatan[10];
                }
                else if (to == 11)
                {
                    total = btSelatan[11];
                }
                else if (to == 12)
                {
                    total = btSelatan[12];
                }
                else if (to == 13)
                {
                    total = btSelatan[13];
                }
                else if (to == 14)
                {
                    total = btSelatan[14];
                }
                else if (to == 15)
                {
                    total = btSelatan[15];
                }
                else if (to == 16)
                {
                    total = btSelatan[16];
                }
                else if (to == 17)
                {
                    total = btSelatan[17];

                }
                else if (to == 18)
                {
                    total = btSelatan[18];
                }
                else if (to == 19)
                {
                    total = btSelatan[19];
                }
                else if (to == 20)
                {
                    total = btSelatan[20];
                }
                else if (to == 21)
                {
                    total = btSelatan[21];
                }
                else if (to == 22)
                {
                    total = btSelatan[22];
                }
                else if (to == 23)
                {
                    total = btSelatan[23];

                }
                else if (to == 24)
                {
                    total = btSelatan[24];
                }
                else if (to == 25)
                {
                    total = btSelatan[25];
                }
                else if (to == 26)
                {
                    total = btSelatan[26];

                }
                else if (to == 27)
                {
                    total = btSelatan[27];
                }
                else if (to == 28)
                {
                    total = btSelatan[28];
                }
                else if (to == 29)
                {
                    total = btSelatan[29];
                }
                else if (to == 30)
                {
                    total = btSelatan[30];
                }
                else if (to == 31)
                {
                    total = btSelatan[31];
                }
                else if (to == 32)
                {
                    total = btSelatan[32];

                }
                else if (to == 33)
                {
                    total = btSelatan[33];
                }
                else if (to == 34)
                {
                    total = btSelatan[34];

                }
                else if (to == 35)
                {
                    total = btSelatan[35];
                }
                else if (to == 36)
                {
                    total = btSelatan[36];
                }
                else if (to == 37)
                {
                    total = btSelatan[37];
                }
                else if (to == 38)
                {
                    total = btSelatan[38];
                }
                else if (to == 39)
                {
                    total = btSelatan[39];
                }
                else if (to == 40)
                {
                    total = btSelatan[40];
                }
                else if (to == 42)
                {
                    total = serdang[41];
                }
                else if (to == 43)
                {
                    total = kajang[41];
                }
                else if (to == 44)
                {
                    total = ukm[41];
                }

                else if (to == 45)
                {
                    total = bangi[41];
                }
                else if (to == 46)
                {
                    total = batangBenar[41];
                }
                else if (to == 47)
                {
                    total = nilai[41];
                }
                else if (to == 48)
                {
                    total = labu[41];
                }
                else if (to == 49)
                {
                    total = tiroi[41];
                }
                else if (to == 50)
                {
                    total = seremban[41];
                }
                else if (to == 51)
                {
                    total = senawang[41];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[41];
                }
                else if (to == 53)
                {
                    total = rembau[41];
                }
                else if (to == 54)
                {
                    total = tampin[41];
                }
                else if (to == 55)
                {
                    total = btgMelaka[41];
                }
                else if (to == 56)
                {
                    total = gemas[41];

                }
            }///////////////////////////////////SERDANG/////////////////////////////

            else if (from == 42)
            {
                if (to == 0)
                {
                    total = serdang[0];
                }
                else if (to == 1)
                {
                    total = serdang[1];
                }
                else if (to == 2)
                {
                    total = serdang[2];
                }
                else if (to == 3)
                {
                    total = serdang[3];
                }
                else if (to == 4)
                {
                    total = serdang[4];
                }
                else if (to == 5)
                {
                    total = serdang[5];
                }
                else if (to == 6)
                {
                    total = serdang[6];
                }
                else if (to == 7)
                {
                    total = serdang[7];
                }
                else if (to == 8)
                {
                    total = serdang[8];
                }
                else if (to == 9)
                {
                    total = serdang[9];
                }
                else if (to == 10)
                {
                    total = serdang[10];
                }
                else if (to == 11)
                {
                    total = serdang[11];
                }
                else if (to == 12)
                {
                    total = serdang[12];
                }
                else if (to == 13)
                {
                    total = serdang[13];
                }
                else if (to == 14)
                {
                    total = serdang[14];
                }
                else if (to == 15)
                {
                    total = serdang[15];
                }
                else if (to == 16)
                {
                    total = serdang[16];
                }
                else if (to == 17)
                {
                    total = serdang[17];

                }
                else if (to == 18)
                {
                    total = serdang[18];
                }
                else if (to == 19)
                {
                    total = serdang[19];
                }
                else if (to == 20)
                {
                    total = serdang[20];
                }
                else if (to == 21)
                {
                    total = serdang[21];
                }
                else if (to == 22)
                {
                    total = serdang[22];
                }
                else if (to == 23)
                {
                    total = serdang[23];

                }
                else if (to == 24)
                {
                    total = serdang[24];
                }
                else if (to == 25)
                {
                    total = serdang[25];
                }
                else if (to == 26)
                {
                    total = serdang[26];

                }
                else if (to == 27)
                {
                    total = serdang[27];
                }
                else if (to == 28)
                {
                    total = serdang[28];
                }
                else if (to == 29)
                {
                    total = serdang[29];
                }
                else if (to == 30)
                {
                    total = serdang[30];
                }
                else if (to == 31)
                {
                    total = serdang[31];
                }
                else if (to == 32)
                {
                    total = serdang[32];

                }
                else if (to == 33)
                {
                    total = serdang[33];
                }
                else if (to == 34)
                {
                    total = serdang[34];

                }
                else if (to == 35)
                {
                    total = serdang[35];
                }
                else if (to == 36)
                {
                    total = serdang[36];
                }
                else if (to == 37)
                {
                    total = serdang[37];
                }
                else if (to == 38)
                {
                    total = serdang[38];
                }
                else if (to == 39)
                {
                    total = serdang[39];
                }
                else if (to == 40)
                {
                    total = serdang[40];
                }
                else if (to == 41)
                {
                    total = serdang[41];
                }
                else if (to == 43)
                {
                    total = kajang[42];
                }
                else if (to == 44)
                {
                    total = ukm[42];
                }

                else if (to == 45)
                {
                    total = bangi[42];
                }
                else if (to == 46)
                {
                    total = batangBenar[42];
                }
                else if (to == 47)
                {
                    total = nilai[42];
                }
                else if (to == 48)
                {
                    total = labu[42];
                }
                else if (to == 49)
                {
                    total = tiroi[42];
                }
                else if (to == 50)
                {
                    total = seremban[42];
                }
                else if (to == 51)
                {
                    total = senawang[42];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[42];
                }
                else if (to == 53)
                {
                    total = rembau[42];
                }
                else if (to == 54)
                {
                    total = tampin[42];
                }
                else if (to == 55)
                {
                    total = btgMelaka[42];
                }
                else if (to == 56)
                {
                    total = gemas[42];

                }
            }//////////////////////////////KAJANG///////////////////////

            else if (from == 43)
            {
                if (to == 0)
                {
                    total = kajang[0];
                }
                else if (to == 1)
                {
                    total = kajang[1];
                }
                else if (to == 2)
                {
                    total = kajang[2];
                }
                else if (to == 3)
                {
                    total = kajang[3];
                }
                else if (to == 4)
                {
                    total = kajang[4];
                }
                else if (to == 5)
                {
                    total = kajang[5];
                }
                else if (to == 6)
                {
                    total = kajang[6];
                }
                else if (to == 7)
                {
                    total = kajang[7];
                }
                else if (to == 8)
                {
                    total = kajang[8];
                }
                else if (to == 9)
                {
                    total = kajang[9];
                }
                else if (to == 10)
                {
                    total = kajang[10];
                }
                else if (to == 11)
                {
                    total = kajang[11];
                }
                else if (to == 12)
                {
                    total = kajang[12];
                }
                else if (to == 13)
                {
                    total = kajang[13];
                }
                else if (to == 14)
                {
                    total = kajang[14];
                }
                else if (to == 15)
                {
                    total = kajang[15];
                }
                else if (to == 16)
                {
                    total = kajang[16];
                }
                else if (to == 17)
                {
                    total = kajang[17];

                }
                else if (to == 18)
                {
                    total = kajang[18];
                }
                else if (to == 19)
                {
                    total = kajang[19];
                }
                else if (to == 20)
                {
                    total = kajang[20];
                }
                else if (to == 21)
                {
                    total = kajang[21];
                }
                else if (to == 22)
                {
                    total = kajang[22];
                }
                else if (to == 23)
                {
                    total = kajang[23];

                }
                else if (to == 24)
                {
                    total = kajang[24];
                }
                else if (to == 25)
                {
                    total = kajang[25];
                }
                else if (to == 26)
                {
                    total = kajang[26];

                }
                else if (to == 27)
                {
                    total = kajang[27];
                }
                else if (to == 28)
                {
                    total = kajang[28];
                }
                else if (to == 29)
                {
                    total = kajang[29];
                }
                else if (to == 30)
                {
                    total = kajang[30];
                }
                else if (to == 31)
                {
                    total = kajang[31];
                }
                else if (to == 32)
                {
                    total = kajang[32];

                }
                else if (to == 33)
                {
                    total = kajang[33];
                }
                else if (to == 34)
                {
                    total = kajang[34];

                }
                else if (to == 35)
                {
                    total = kajang[35];
                }
                else if (to == 36)
                {
                    total = kajang[36];
                }
                else if (to == 37)
                {
                    total = kajang[37];
                }
                else if (to == 38)
                {
                    total = kajang[38];
                }
                else if (to == 39)
                {
                    total = kajang[39];
                }
                else if (to == 40)
                {
                    total = kajang[40];
                }
                else if (to == 41)
                {
                    total = kajang[41];
                }
                else if (to == 42)
                {
                    total = kajang[42];
                }
                else if (to == 44)
                {
                    total = ukm[43];
                }

                else if (to == 45)
                {
                    total = bangi[43];
                }
                else if (to == 46)
                {
                    total = batangBenar[43];
                }
                else if (to == 47)
                {
                    total = nilai[43];
                }
                else if (to == 48)
                {
                    total = labu[43];
                }
                else if (to == 49)
                {
                    total = tiroi[43];
                }
                else if (to == 50)
                {
                    total = seremban[43];
                }
                else if (to == 51)
                {
                    total = senawang[43];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[43];
                }
                else if (to == 53)
                {
                    total = rembau[43];
                }
                else if (to == 54)
                {
                    total = tampin[43];
                }
                else if (to == 55)
                {
                    total = btgMelaka[43];
                }
                else if (to == 56)
                {
                    total = gemas[43];

                }
            }/////////////////////////////////UKM/////////////////////////

            else if (from == 44)
            {
                if (to == 0)
                {
                    total = ukm[0];
                }
                else if (to == 1)
                {
                    total = ukm[1];
                }
                else if (to == 2)
                {
                    total = ukm[2];
                }
                else if (to == 3)
                {
                    total = ukm[3];
                }
                else if (to == 4)
                {
                    total = ukm[4];
                }
                else if (to == 5)
                {
                    total = ukm[5];
                }
                else if (to == 6)
                {
                    total = ukm[6];
                }
                else if (to == 7)
                {
                    total = ukm[7];
                }
                else if (to == 8)
                {
                    total = ukm[8];
                }
                else if (to == 9)
                {
                    total = ukm[9];
                }
                else if (to == 10)
                {
                    total = ukm[10];
                }
                else if (to == 11)
                {
                    total = ukm[11];
                }
                else if (to == 12)
                {
                    total = ukm[12];
                }
                else if (to == 13)
                {
                    total = ukm[13];
                }
                else if (to == 14)
                {
                    total = ukm[14];
                }
                else if (to == 15)
                {
                    total = ukm[15];
                }
                else if (to == 16)
                {
                    total = ukm[16];
                }
                else if (to == 17)
                {
                    total = ukm[17];

                }
                else if (to == 18)
                {
                    total = ukm[18];
                }
                else if (to == 19)
                {
                    total = ukm[19];
                }
                else if (to == 20)
                {
                    total = ukm[20];
                }
                else if (to == 21)
                {
                    total = ukm[21];
                }
                else if (to == 22)
                {
                    total = ukm[22];
                }
                else if (to == 23)
                {
                    total = ukm[23];

                }
                else if (to == 24)
                {
                    total = ukm[24];
                }
                else if (to == 25)
                {
                    total = ukm[25];
                }
                else if (to == 26)
                {
                    total = ukm[26];

                }
                else if (to == 27)
                {
                    total = ukm[27];
                }
                else if (to == 28)
                {
                    total = ukm[28];
                }
                else if (to == 29)
                {
                    total = ukm[29];
                }
                else if (to == 30)
                {
                    total = ukm[30];
                }
                else if (to == 31)
                {
                    total = ukm[31];
                }
                else if (to == 32)
                {
                    total = ukm[32];

                }
                else if (to == 33)
                {
                    total = ukm[33];
                }
                else if (to == 34)
                {
                    total = ukm[34];

                }
                else if (to == 35)
                {
                    total = ukm[35];
                }
                else if (to == 36)
                {
                    total = ukm[36];
                }
                else if (to == 37)
                {
                    total = ukm[37];
                }
                else if (to == 38)
                {
                    total = ukm[38];
                }
                else if (to == 39)
                {
                    total = ukm[39];
                }
                else if (to == 40)
                {
                    total = ukm[40];
                }
                else if (to == 41)
                {
                    total = ukm[41];
                }
                else if (to == 42)
                {
                    total = ukm[42];
                }
                else if (to == 43)
                {
                    total = ukm[43];
                }

                else if (to == 45)
                {
                    total = bangi[44];
                }
                else if (to == 46)
                {
                    total = batangBenar[44];
                }
                else if (to == 47)
                {
                    total = nilai[44];
                }
                else if (to == 48)
                {
                    total = labu[44];
                }
                else if (to == 49)
                {
                    total = tiroi[44];
                }
                else if (to == 50)
                {
                    total = seremban[44];
                }
                else if (to == 51)
                {
                    total = senawang[44];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[44];
                }
                else if (to == 53)
                {
                    total = rembau[44];
                }
                else if (to == 54)
                {
                    total = tampin[44];
                }
                else if (to == 55)
                {
                    total = btgMelaka[44];
                }
                else if (to == 56)
                {
                    total = gemas[44];

                }
            }//////////////////////////////////BANGI//////////////////

            else if (from == 45)
            {
                if (to == 0)
                {
                    total = bangi[0];
                }
                else if (to == 1)
                {
                    total = bangi[1];
                }
                else if (to == 2)
                {
                    total = bangi[2];
                }
                else if (to == 3)
                {
                    total = bangi[3];
                }
                else if (to == 4)
                {
                    total = bangi[4];
                }
                else if (to == 5)
                {
                    total = bangi[5];
                }
                else if (to == 6)
                {
                    total = bangi[6];
                }
                else if (to == 7)
                {
                    total = bangi[7];
                }
                else if (to == 8)
                {
                    total = bangi[8];
                }
                else if (to == 9)
                {
                    total = bangi[9];
                }
                else if (to == 10)
                {
                    total = bangi[10];
                }
                else if (to == 11)
                {
                    total = bangi[11];
                }
                else if (to == 12)
                {
                    total = bangi[12];
                }
                else if (to == 13)
                {
                    total = bangi[13];
                }
                else if (to == 14)
                {
                    total = bangi[14];
                }
                else if (to == 15)
                {
                    total = bangi[15];
                }
                else if (to == 16)
                {
                    total = bangi[16];
                }
                else if (to == 17)
                {
                    total = bangi[17];

                }
                else if (to == 18)
                {
                    total = bangi[18];
                }
                else if (to == 19)
                {
                    total = bangi[19];
                }
                else if (to == 20)
                {
                    total = bangi[20];
                }
                else if (to == 21)
                {
                    total = bangi[21];
                }
                else if (to == 22)
                {
                    total = bangi[22];
                }
                else if (to == 23)
                {
                    total = bangi[23];

                }
                else if (to == 24)
                {
                    total = bangi[24];
                }
                else if (to == 25)
                {
                    total = bangi[25];
                }
                else if (to == 26)
                {
                    total = bangi[26];

                }
                else if (to == 27)
                {
                    total = bangi[27];
                }
                else if (to == 28)
                {
                    total = bangi[28];
                }
                else if (to == 29)
                {
                    total = bangi[29];
                }
                else if (to == 30)
                {
                    total = bangi[30];
                }
                else if (to == 31)
                {
                    total = bangi[31];
                }
                else if (to == 32)
                {
                    total = bangi[32];

                }
                else if (to == 33)
                {
                    total = bangi[33];
                }
                else if (to == 34)
                {
                    total = bangi[34];

                }
                else if (to == 35)
                {
                    total = bangi[35];
                }
                else if (to == 36)
                {
                    total = bangi[36];
                }
                else if (to == 37)
                {
                    total = bangi[37];
                }
                else if (to == 38)
                {
                    total = bangi[38];
                }
                else if (to == 39)
                {
                    total = bangi[39];
                }
                else if (to == 40)
                {
                    total = bangi[40];
                }
                else if (to == 41)
                {
                    total = bangi[41];
                }
                else if (to == 42)
                {
                    total = bangi[42];
                }
                else if (to == 43)
                {
                    total = bangi[43];
                }

                else if (to == 44)
                {
                    total = bangi[44];
                }
                else if (to == 46)
                {
                    total = batangBenar[45];
                }
                else if (to == 47)
                {
                    total = nilai[45];
                }
                else if (to == 48)
                {
                    total = labu[45];
                }
                else if (to == 49)
                {
                    total = tiroi[45];
                }
                else if (to == 50)
                {
                    total = seremban[45];
                }
                else if (to == 51)
                {
                    total = senawang[45];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[45];
                }
                else if (to == 53)
                {
                    total = rembau[45];
                }
                else if (to == 54)
                {
                    total = tampin[45];
                }
                else if (to == 55)
                {
                    total = btgMelaka[45];
                }
                else if (to == 56)
                {
                    total = gemas[45];

                }
            }///////////////////////////////BATANG BENAR//////////////////////////////

            else if (from == 46)
            {
                if (to == 0)
                {
                    total = batangBenar[0];
                }
                else if (to == 1)
                {
                    total = batangBenar[1];
                }
                else if (to == 2)
                {
                    total = batangBenar[2];
                }
                else if (to == 3)
                {
                    total = batangBenar[3];
                }
                else if (to == 4)
                {
                    total = batangBenar[4];
                }
                else if (to == 5)
                {
                    total = batangBenar[5];
                }
                else if (to == 6)
                {
                    total = batangBenar[6];
                }
                else if (to == 7)
                {
                    total = batangBenar[7];
                }
                else if (to == 8)
                {
                    total = batangBenar[8];
                }
                else if (to == 9)
                {
                    total = batangBenar[9];
                }
                else if (to == 10)
                {
                    total = batangBenar[10];
                }
                else if (to == 11)
                {
                    total = batangBenar[11];
                }
                else if (to == 12)
                {
                    total = batangBenar[12];
                }
                else if (to == 13)
                {
                    total = batangBenar[13];
                }
                else if (to == 14)
                {
                    total = batangBenar[14];
                }
                else if (to == 15)
                {
                    total = batangBenar[15];
                }
                else if (to == 16)
                {
                    total = batangBenar[16];
                }
                else if (to == 17)
                {
                    total = batangBenar[17];

                }
                else if (to == 18)
                {
                    total = batangBenar[18];
                }
                else if (to == 19)
                {
                    total = batangBenar[19];
                }
                else if (to == 20)
                {
                    total = batangBenar[20];
                }
                else if (to == 21)
                {
                    total = batangBenar[21];
                }
                else if (to == 22)
                {
                    total = batangBenar[22];
                }
                else if (to == 23)
                {
                    total = batangBenar[23];

                }
                else if (to == 24)
                {
                    total = batangBenar[24];
                }
                else if (to == 25)
                {
                    total = batangBenar[25];
                }
                else if (to == 26)
                {
                    total = batangBenar[26];

                }
                else if (to == 27)
                {
                    total = batangBenar[27];
                }
                else if (to == 28)
                {
                    total = batangBenar[28];
                }
                else if (to == 29)
                {
                    total = batangBenar[29];
                }
                else if (to == 30)
                {
                    total = batangBenar[30];
                }
                else if (to == 31)
                {
                    total = batangBenar[31];
                }
                else if (to == 32)
                {
                    total = batangBenar[32];

                }
                else if (to == 33)
                {
                    total = batangBenar[33];
                }
                else if (to == 34)
                {
                    total = batangBenar[34];

                }
                else if (to == 35)
                {
                    total = batangBenar[35];
                }
                else if (to == 36)
                {
                    total = batangBenar[36];
                }
                else if (to == 37)
                {
                    total = batangBenar[37];
                }
                else if (to == 38)
                {
                    total = batangBenar[38];
                }
                else if (to == 39)
                {
                    total = batangBenar[39];
                }
                else if (to == 40)
                {
                    total = batangBenar[40];
                }
                else if (to == 41)
                {
                    total = batangBenar[41];
                }
                else if (to == 42)
                {
                    total = batangBenar[42];
                }
                else if (to == 43)
                {
                    total = batangBenar[43];
                }

                else if (to == 44)
                {
                    total = batangBenar[44];
                }
                else if (to == 45)
                {
                    total = batangBenar[45];
                }
                else if (to == 47)
                {
                    total = nilai[46];
                }
                else if (to == 48)
                {
                    total = labu[46];
                }
                else if (to == 49)
                {
                    total = tiroi[46];
                }
                else if (to == 50)
                {
                    total = seremban[46];
                }
                else if (to == 51)
                {
                    total = senawang[46];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[46];
                }
                else if (to == 53)
                {
                    total = rembau[46];
                }
                else if (to == 54)
                {
                    total = tampin[46];
                }
                else if (to == 55)
                {
                    total = btgMelaka[46];
                }
                else if (to == 56)
                {
                    total = gemas[46];

                }
            }//////////////////////////////////NILAI//////////////////////////////

            else if (from == 47)
            {
                if (to == 0)
                {
                    total = nilai[0];
                }
                else if (to == 1)
                {
                    total = nilai[1];
                }
                else if (to == 2)
                {
                    total = nilai[2];
                }
                else if (to == 3)
                {
                    total = nilai[3];
                }
                else if (to == 4)
                {
                    total = nilai[4];
                }
                else if (to == 5)
                {
                    total = nilai[5];
                }
                else if (to == 6)
                {
                    total = nilai[6];
                }
                else if (to == 7)
                {
                    total = nilai[7];
                }
                else if (to == 8)
                {
                    total = nilai[8];
                }
                else if (to == 9)
                {
                    total = nilai[9];
                }
                else if (to == 10)
                {
                    total = nilai[10];
                }
                else if (to == 11)
                {
                    total = nilai[11];
                }
                else if (to == 12)
                {
                    total = nilai[12];
                }
                else if (to == 13)
                {
                    total = nilai[13];
                }
                else if (to == 14)
                {
                    total = nilai[14];
                }
                else if (to == 15)
                {
                    total = nilai[15];
                }
                else if (to == 16)
                {
                    total = nilai[16];
                }
                else if (to == 17)
                {
                    total = nilai[17];

                }
                else if (to == 18)
                {
                    total = nilai[18];
                }
                else if (to == 19)
                {
                    total = nilai[19];
                }
                else if (to == 20)
                {
                    total = nilai[20];
                }
                else if (to == 21)
                {
                    total = nilai[21];
                }
                else if (to == 22)
                {
                    total = nilai[22];
                }
                else if (to == 23)
                {
                    total = nilai[23];

                }
                else if (to == 24)
                {
                    total = nilai[24];
                }
                else if (to == 25)
                {
                    total = nilai[25];
                }
                else if (to == 26)
                {
                    total = nilai[26];

                }
                else if (to == 27)
                {
                    total = nilai[27];
                }
                else if (to == 28)
                {
                    total = nilai[28];
                }
                else if (to == 29)
                {
                    total = nilai[29];
                }
                else if (to == 30)
                {
                    total = nilai[30];
                }
                else if (to == 31)
                {
                    total = nilai[31];
                }
                else if (to == 32)
                {
                    total = nilai[32];

                }
                else if (to == 33)
                {
                    total = nilai[33];
                }
                else if (to == 34)
                {
                    total = nilai[34];

                }
                else if (to == 35)
                {
                    total = nilai[35];
                }
                else if (to == 36)
                {
                    total = nilai[36];
                }
                else if (to == 37)
                {
                    total = nilai[37];
                }
                else if (to == 38)
                {
                    total = nilai[38];
                }
                else if (to == 39)
                {
                    total = nilai[39];
                }
                else if (to == 40)
                {
                    total = nilai[40];
                }
                else if (to == 41)
                {
                    total = nilai[41];
                }
                else if (to == 42)
                {
                    total = nilai[42];
                }
                else if (to == 43)
                {
                    total = nilai[43];
                }

                else if (to == 44)
                {
                    total = nilai[44];
                }
                else if (to == 45)
                {
                    total = nilai[45];
                }
                else if (to == 46)
                {
                    total = nilai[46];
                }
                else if (to == 48)
                {
                    total = labu[47];
                }
                else if (to == 49)
                {
                    total = tiroi[47];
                }
                else if (to == 50)
                {
                    total = seremban[47];
                }
                else if (to == 51)
                {
                    total = senawang[47];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[47];
                }
                else if (to == 53)
                {
                    total = rembau[47];
                }
                else if (to == 54)
                {
                    total = tampin[47];
                }
                else if (to == 55)
                {
                    total = btgMelaka[47];
                }
                else if (to == 56)
                {
                    total = gemas[47];

                }
            }//////////////////////////////////////LABU//////////////////////////////

            else if (from == 48)
            {
                if (to == 0)
                {
                    total = labu[0];
                }
                else if (to == 1)
                {
                    total = labu[1];
                }
                else if (to == 2)
                {
                    total = labu[2];
                }
                else if (to == 3)
                {
                    total = labu[3];
                }
                else if (to == 4)
                {
                    total = labu[4];
                }
                else if (to == 5)
                {
                    total = labu[5];
                }
                else if (to == 6)
                {
                    total = labu[6];
                }
                else if (to == 7)
                {
                    total = labu[7];
                }
                else if (to == 8)
                {
                    total = labu[8];
                }
                else if (to == 9)
                {
                    total = labu[9];
                }
                else if (to == 10)
                {
                    total = labu[10];
                }
                else if (to == 11)
                {
                    total = labu[11];
                }
                else if (to == 12)
                {
                    total = labu[12];
                }
                else if (to == 13)
                {
                    total = labu[13];
                }
                else if (to == 14)
                {
                    total = labu[14];
                }
                else if (to == 15)
                {
                    total = labu[15];
                }
                else if (to == 16)
                {
                    total = labu[16];
                }
                else if (to == 17)
                {
                    total = labu[17];

                }
                else if (to == 18)
                {
                    total = labu[18];
                }
                else if (to == 19)
                {
                    total = labu[19];
                }
                else if (to == 20)
                {
                    total = labu[20];
                }
                else if (to == 21)
                {
                    total = labu[21];
                }
                else if (to == 22)
                {
                    total = labu[22];
                }
                else if (to == 23)
                {
                    total = labu[23];

                }
                else if (to == 24)
                {
                    total = labu[24];
                }
                else if (to == 25)
                {
                    total = labu[25];
                }
                else if (to == 24)
                {
                    total = labu[26];

                }
                else if (to == 27)
                {
                    total = labu[27];
                }
                else if (to == 28)
                {
                    total = labu[28];
                }
                else if (to == 29)
                {
                    total = labu[29];
                }
                else if (to == 30)
                {
                    total = labu[30];
                }
                else if (to == 31)
                {
                    total = labu[31];
                }
                else if (to == 32)
                {
                    total = labu[32];

                }
                else if (to == 33)
                {
                    total = labu[33];
                }
                else if (to == 34)
                {
                    total = labu[34];

                }
                else if (to == 35)
                {
                    total = labu[35];
                }
                else if (to == 36)
                {
                    total = labu[36];
                }
                else if (to == 37)
                {
                    total = labu[37];
                }
                else if (to == 38)
                {
                    total = labu[38];
                }
                else if (to == 39)
                {
                    total = labu[39];
                }
                else if (to == 40)
                {
                    total = labu[40];
                }
                else if (to == 41)
                {
                    total = labu[41];
                }
                else if (to == 42)
                {
                    total = labu[42];
                }
                else if (to == 43)
                {
                    total = labu[43];
                }

                else if (to == 44)
                {
                    total = labu[44];
                }
                else if (to == 45)
                {
                    total = labu[45];
                }
                else if (to == 46)
                {
                    total = labu[46];
                }
                else if (to == 47)
                {
                    total = labu[47];
                }
                else if (to == 49)
                {
                    total = tiroi[48];
                }
                else if (to == 50)
                {
                    total = seremban[48];
                }
                else if (to == 51)
                {
                    total = senawang[48];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[48];
                }
                else if (to == 53)
                {
                    total = rembau[48];
                }
                else if (to == 54)
                {
                    total = tampin[48];
                }
                else if (to == 55)
                {
                    total = btgMelaka[48];
                }
                else if (to == 56)
                {
                    total = gemas[48];

                }
            }/////////////////////////////////////TIROI////////////////////

            else if (from == 49)
            {
                if (to == 0)
                {
                    total = tiroi[0];
                }
                else if (to == 1)
                {
                    total = tiroi[1];
                }
                else if (to == 2)
                {
                    total = tiroi[2];
                }
                else if (to == 3)
                {
                    total = tiroi[3];
                }
                else if (to == 4)
                {
                    total = tiroi[4];
                }
                else if (to == 5)
                {
                    total = tiroi[5];
                }
                else if (to == 6)
                {
                    total = tiroi[6];
                }
                else if (to == 7)
                {
                    total = tiroi[7];
                }
                else if (to == 8)
                {
                    total = tiroi[8];
                }
                else if (to == 9)
                {
                    total = tiroi[9];
                }
                else if (to == 10)
                {
                    total = tiroi[10];
                }
                else if (to == 11)
                {
                    total = tiroi[11];
                }
                else if (to == 12)
                {
                    total = tiroi[12];
                }
                else if (to == 13)
                {
                    total = tiroi[13];
                }
                else if (to == 14)
                {
                    total = tiroi[14];
                }
                else if (to == 15)
                {
                    total = tiroi[15];
                }
                else if (to == 16)
                {
                    total = tiroi[16];
                }
                else if (to == 17)
                {
                    total = tiroi[17];

                }
                else if (to == 18)
                {
                    total = tiroi[18];
                }
                else if (to == 19)
                {
                    total = tiroi[19];
                }
                else if (to == 20)
                {
                    total = tiroi[20];
                }
                else if (to == 21)
                {
                    total = tiroi[21];
                }
                else if (to == 22)
                {
                    total = tiroi[22];
                }
                else if (to == 23)
                {
                    total = tiroi[23];

                }
                else if (to == 24)
                {
                    total = tiroi[24];
                }
                else if (to == 25)
                {
                    total = tiroi[25];
                }
                else if (to == 26)
                {
                    total = tiroi[26];

                }
                else if (to == 27)
                {
                    total = tiroi[27];
                }
                else if (to == 28)
                {
                    total = tiroi[28];
                }
                else if (to == 29)
                {
                    total = tiroi[29];
                }
                else if (to == 30)
                {
                    total = tiroi[30];
                }
                else if (to == 31)
                {
                    total = tiroi[31];
                }
                else if (to == 32)
                {
                    total = tiroi[32];

                }
                else if (to == 33)
                {
                    total = tiroi[33];
                }
                else if (to == 34)
                {
                    total = tiroi[34];

                }
                else if (to == 35)
                {
                    total = tiroi[35];
                }
                else if (to == 36)
                {
                    total = tiroi[36];
                }
                else if (to == 37)
                {
                    total = tiroi[37];
                }
                else if (to == 38)
                {
                    total = tiroi[38];
                }
                else if (to == 39)
                {
                    total = tiroi[39];
                }
                else if (to == 40)
                {
                    total = tiroi[40];
                }
                else if (to == 41)
                {
                    total = tiroi[41];
                }
                else if (to == 42)
                {
                    total = tiroi[42];
                }
                else if (to == 43)
                {
                    total = tiroi[43];
                }

                else if (to == 44)
                {
                    total = tiroi[44];
                }
                else if (to == 45)
                {
                    total = tiroi[45];
                }
                else if (to == 46)
                {
                    total = tiroi[46];
                }
                else if (to == 47)
                {
                    total = tiroi[47];
                }
                else if (to == 48)
                {
                    total = tiroi[48];
                }
                else if (to == 50)
                {
                    total = seremban[49];
                }
                else if (to == 51)
                {
                    total = senawang[49];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[49];
                }
                else if (to == 53)
                {
                    total = rembau[49];
                }
                else if (to == 54)
                {
                    total = tampin[49];
                }
                else if (to == 55)
                {
                    total = btgMelaka[49];
                }
                else if (to == 56)
                {
                    total = gemas[49];
                }
            }///////////////////////////////SEREMBAN//////////////////////
            else if (from == 50)
            {
                if (to == 0)
                {
                    total = seremban[0];
                }
                else if (to == 1)
                {
                    total = seremban[1];
                }
                else if (to == 2)
                {
                    total = seremban[2];
                }
                else if (to == 3)
                {
                    total = seremban[3];
                }
                else if (to == 4)
                {
                    total = seremban[4];
                }
                else if (to == 5)
                {
                    total = seremban[5];
                }
                else if (to == 6)
                {
                    total = seremban[6];
                }
                else if (to == 7)
                {
                    total = seremban[7];
                }
                else if (to == 8)
                {
                    total = seremban[8];
                }
                else if (to == 9)
                {
                    total = seremban[9];
                }
                else if (to == 10)
                {
                    total = seremban[10];
                }
                else if (to == 11)
                {
                    total = seremban[11];
                }
                else if (to == 12)
                {
                    total = seremban[12];
                }
                else if (to == 13)
                {
                    total = seremban[13];
                }
                else if (to == 14)
                {
                    total = seremban[14];
                }
                else if (to == 15)
                {
                    total = seremban[15];
                }
                else if (to == 16)
                {
                    total = seremban[16];
                }
                else if (to == 17)
                {
                    total = seremban[17];

                }
                else if (to == 18)
                {
                    total = seremban[18];
                }
                else if (to == 19)
                {
                    total = seremban[19];
                }
                else if (to == 20)
                {
                    total = seremban[20];
                }
                else if (to == 21)
                {
                    total = seremban[21];
                }
                else if (to == 22)
                {
                    total = seremban[22];
                }
                else if (to == 23)
                {
                    total = seremban[23];

                }
                else if (to == 24)
                {
                    total = seremban[24];
                }
                else if (to == 25)
                {
                    total = seremban[25];
                }
                else if (to == 26)
                {
                    total = seremban[26];

                }
                else if (to == 27)
                {
                    total = seremban[27];
                }
                else if (to == 28)
                {
                    total = seremban[28];
                }
                else if (to == 29)
                {
                    total = seremban[29];
                }
                else if (to == 30)
                {
                    total = seremban[30];
                }
                else if (to == 31)
                {
                    total = seremban[31];
                }
                else if (to == 32)
                {
                    total = seremban[32];

                }
                else if (to == 33)
                {
                    total = seremban[33];
                }
                else if (to == 34)
                {
                    total = seremban[34];

                }
                else if (to == 35)
                {
                    total = seremban[35];
                }
                else if (to == 36)
                {
                    total = seremban[36];
                }
                else if (to == 37)
                {
                    total = seremban[37];
                }
                else if (to == 38)
                {
                    total = seremban[38];
                }
                else if (to == 39)
                {
                    total = seremban[39];
                }
                else if (to == 40)
                {
                    total = seremban[40];
                }
                else if (to == 41)
                {
                    total = seremban[41];
                }
                else if (to == 42)
                {
                    total = seremban[42];
                }
                else if (to == 43)
                {
                    total = seremban[43];
                }

                else if (to == 44)
                {
                    total = seremban[44];
                }
                else if (to == 45)
                {
                    total = seremban[45];
                }
                else if (to == 46)
                {
                    total = seremban[46];
                }
                else if (to == 47)
                {
                    total = seremban[47];
                }
                else if (to == 48)
                {
                    total = seremban[48];
                }
                else if (to == 49)
                {
                    total = seremban[49];
                }
                else if (to == 51)
                {
                    total = senawang[50];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[50];
                }
                else if (to == 53)
                {
                    total = rembau[50];
                }
                else if (to == 54)
                {
                    total = tampin[50];
                }
                else if (to == 55)
                {
                    total = btgMelaka[50];
                }
                else if (to == 56)
                {
                    total = gemas[50];
                }
            }/////////////////////////////////SENAWANG/////////////////
            else if (from == 51)
            {
                if (to == 0)
                {
                    total = senawang[0];
                }
                else if (to == 1)
                {
                    total = senawang[1];
                }
                else if (to == 2)
                {
                    total = senawang[2];
                }
                else if (to == 3)
                {
                    total = senawang[3];
                }
                else if (to == 4)
                {
                    total = senawang[4];
                }
                else if (to == 5)
                {
                    total = senawang[5];
                }
                else if (to == 6)
                {
                    total = senawang[6];
                }
                else if (to == 7)
                {
                    total = senawang[7];
                }
                else if (to == 8)
                {
                    total = senawang[8];
                }
                else if (to == 9)
                {
                    total = senawang[9];
                }
                else if (to == 10)
                {
                    total = senawang[10];
                }
                else if (to == 11)
                {
                    total = senawang[11];
                }
                else if (to == 12)
                {
                    total = senawang[12];
                }
                else if (to == 13)
                {
                    total = senawang[13];
                }
                else if (to == 14)
                {
                    total = senawang[14];
                }
                else if (to == 15)
                {
                    total = senawang[15];
                }
                else if (to == 16)
                {
                    total = senawang[16];
                }
                else if (to == 17)
                {
                    total = senawang[17];

                }
                else if (to == 18)
                {
                    total = senawang[18];
                }
                else if (to == 19)
                {
                    total = senawang[19];
                }
                else if (to == 20)
                {
                    total = senawang[20];
                }
                else if (to == 21)
                {
                    total = senawang[21];
                }
                else if (to == 22)
                {
                    total = senawang[22];
                }
                else if (to == 23)
                {
                    total = senawang[23];

                }
                else if (to == 24)
                {
                    total = senawang[24];
                }
                else if (to == 25)
                {
                    total = senawang[25];
                }
                else if (to == 26)
                {
                    total = senawang[26];

                }
                else if (to == 27)
                {
                    total = senawang[27];
                }
                else if (to == 28)
                {
                    total = senawang[28];
                }
                else if (to == 29)
                {
                    total = senawang[29];
                }
                else if (to == 30)
                {
                    total = senawang[30];
                }
                else if (to == 31)
                {
                    total = senawang[31];
                }
                else if (to == 32)
                {
                    total = senawang[32];

                }
                else if (to == 33)
                {
                    total = senawang[33];
                }
                else if (to == 34)
                {
                    total = senawang[34];

                }
                else if (to == 35)
                {
                    total = senawang[35];
                }
                else if (to == 36)
                {
                    total = senawang[36];
                }
                else if (to == 37)
                {
                    total = senawang[37];
                }
                else if (to == 38)
                {
                    total = senawang[38];
                }
                else if (to == 39)
                {
                    total = senawang[39];
                }
                else if (to == 40)
                {
                    total = senawang[40];
                }
                else if (to == 41)
                {
                    total = senawang[41];
                }
                else if (to == 42)
                {
                    total = senawang[42];
                }
                else if (to == 43)
                {
                    total = senawang[43];
                }

                else if (to == 44)
                {
                    total = senawang[44];
                }
                else if (to == 45)
                {
                    total = senawang[45];
                }
                else if (to == 46)
                {
                    total = senawang[46];
                }
                else if (to == 47)
                {
                    total = senawang[47];
                }
                else if (to == 48)
                {
                    total = senawang[48];
                }
                else if (to == 49)
                {
                    total = senawang[49];
                }
                else if (to == 50)
                {
                    total = senawang[50];
                }
                else if (to == 52)
                {
                    total = sungaiGadut[51];
                }
                else if (to == 53)
                {
                    total = rembau[51];
                }
                else if (to == 54)
                {
                    total = tampin[51];
                }
                else if (to == 55)
                {
                    total = btgMelaka[51];
                }
                else if (to == 56)
                {
                    total = gemas[51];
                }
            }////////////////////////SUNGAI GADUT///////////////////////////

            else if (from == 52)
            {
                if (to == 0)
                {
                    total = sungaiGadut[0];
                }
                else if (to == 1)
                {
                    total = sungaiGadut[1];
                }
                else if (to == 2)
                {
                    total = sungaiGadut[2];
                }
                else if (to == 3)
                {
                    total = sungaiGadut[3];
                }
                else if (to == 4)
                {
                    total = sungaiGadut[4];
                }
                else if (to == 5)
                {
                    total = sungaiGadut[5];
                }
                else if (to == 6)
                {
                    total = sungaiGadut[6];
                }
                else if (to == 7)
                {
                    total = sungaiGadut[7];
                }
                else if (to == 8)
                {
                    total = sungaiGadut[8];
                }
                else if (to == 9)
                {
                    total = sungaiGadut[9];
                }
                else if (to == 10)
                {
                    total = sungaiGadut[10];
                }
                else if (to == 11)
                {
                    total = sungaiGadut[11];
                }
                else if (to == 12)
                {
                    total = sungaiGadut[12];
                }
                else if (to == 13)
                {
                    total = sungaiGadut[13];
                }
                else if (to == 14)
                {
                    total = sungaiGadut[14];
                }
                else if (to == 15)
                {
                    total = sungaiGadut[15];
                }
                else if (to == 16)
                {
                    total = sungaiGadut[16];
                }
                else if (to == 17)
                {
                    total = sungaiGadut[17];

                }
                else if (to == 18)
                {
                    total = sungaiGadut[18];
                }
                else if (to == 19)
                {
                    total = sungaiGadut[19];
                }
                else if (to == 20)
                {
                    total = sungaiGadut[20];
                }
                else if (to == 21)
                {
                    total = sungaiGadut[21];
                }
                else if (to == 22)
                {
                    total = sungaiGadut[22];
                }
                else if (to == 23)
                {
                    total = sungaiGadut[23];

                }
                else if (to == 24)
                {
                    total = sungaiGadut[24];
                }
                else if (to == 25)
                {
                    total = sungaiGadut[25];
                }
                else if (to == 26)
                {
                    total = sungaiGadut[26];

                }
                else if (to == 27)
                {
                    total = sungaiGadut[27];
                }
                else if (to == 28)
                {
                    total = sungaiGadut[28];
                }
                else if (to == 29)
                {
                    total = sungaiGadut[29];
                }
                else if (to == 30)
                {
                    total = sungaiGadut[30];
                }
                else if (to == 31)
                {
                    total = sungaiGadut[31];
                }
                else if (to == 32)
                {
                    total = sungaiGadut[32];

                }
                else if (to == 33)
                {
                    total = sungaiGadut[33];
                }
                else if (to == 34)
                {
                    total = sungaiGadut[34];

                }
                else if (to == 35)
                {
                    total = sungaiGadut[35];
                }
                else if (to == 36)
                {
                    total = sungaiGadut[36];
                }
                else if (to == 37)
                {
                    total = sungaiGadut[37];
                }
                else if (to == 38)
                {
                    total = sungaiGadut[38];
                }
                else if (to == 39)
                {
                    total = sungaiGadut[39];
                }
                else if (to == 40)
                {
                    total = sungaiGadut[40];
                }
                else if (to == 41)
                {
                    total = sungaiGadut[41];
                }
                else if (to == 42)
                {
                    total = sungaiGadut[42];
                }
                else if (to == 43)
                {
                    total = sungaiGadut[43];
                }

                else if (to == 44)
                {
                    total = sungaiGadut[44];
                }
                else if (to == 45)
                {
                    total = sungaiGadut[45];
                }
                else if (to == 46)
                {
                    total = sungaiGadut[46];
                }
                else if (to == 47)
                {
                    total = sungaiGadut[47];
                }
                else if (to == 48)
                {
                    total = sungaiGadut[48];
                }
                else if (to == 49)
                {
                    total = sungaiGadut[49];
                }
                else if (to == 50)
                {
                    total = sungaiGadut[50];
                }
                else if (to == 51)
                {
                    total = sungaiGadut[51];
                }
                else if (to == 53)
                {
                    total = rembau[52];
                }
                else if (to == 54)
                {
                    total = tampin[52];
                }
                else if (to == 55)
                {
                    total = btgMelaka[52];
                }
                else if (to == 56)
                {
                    total = gemas[52];
                }
            }///////////////////////////////////////REMBAU///////////////////////////////////////

            else if (from == 53)
            {
                if (to == 0)
                {
                    total = rembau[0];
                }
                else if (to == 1)
                {
                    total = rembau[1];
                }
                else if (to == 2)
                {
                    total = rembau[2];
                }
                else if (to == 3)
                {
                    total = rembau[3];
                }
                else if (to == 4)
                {
                    total = rembau[4];
                }
                else if (to == 5)
                {
                    total = rembau[5];
                }
                else if (to == 6)
                {
                    total = rembau[6];
                }
                else if (to == 7)
                {
                    total = rembau[7];
                }
                else if (to == 8)
                {
                    total = rembau[8];
                }
                else if (to == 9)
                {
                    total = rembau[9];
                }
                else if (to == 10)
                {
                    total = rembau[10];
                }
                else if (to == 11)
                {
                    total = rembau[11];
                }
                else if (to == 12)
                {
                    total = rembau[12];
                }
                else if (to == 13)
                {
                    total = rembau[13];
                }
                else if (to == 14)
                {
                    total = rembau[14];
                }
                else if (to == 15)
                {
                    total = rembau[15];
                }
                else if (to == 16)
                {
                    total = rembau[16];
                }
                else if (to == 17)
                {
                    total = rembau[17];

                }
                else if (to == 18)
                {
                    total = rembau[18];
                }
                else if (to == 19)
                {
                    total = rembau[19];
                }
                else if (to == 20)
                {
                    total = rembau[20];
                }
                else if (to == 21)
                {
                    total = rembau[21];
                }
                else if (to == 22)
                {
                    total = rembau[22];
                }
                else if (to == 23)
                {
                    total = rembau[23];

                }
                else if (to == 24)
                {
                    total = rembau[24];
                }
                else if (to == 25)
                {
                    total = rembau[25];
                }
                else if (to == 26)
                {
                    total = rembau[26];

                }
                else if (to == 27)
                {
                    total = rembau[27];
                }
                else if (to == 28)
                {
                    total = rembau[28];
                }
                else if (to == 29)
                {
                    total = rembau[29];
                }
                else if (to == 30)
                {
                    total = rembau[30];
                }
                else if (to == 31)
                {
                    total = rembau[31];
                }
                else if (to == 32)
                {
                    total = rembau[32];

                }
                else if (to == 33)
                {
                    total = rembau[33];
                }
                else if (to == 34)
                {
                    total = rembau[34];

                }
                else if (to == 35)
                {
                    total = rembau[35];
                }
                else if (to == 36)
                {
                    total = rembau[36];
                }
                else if (to == 37)
                {
                    total = rembau[37];
                }
                else if (to == 38)
                {
                    total = rembau[38];
                }
                else if (to == 39)
                {
                    total = rembau[39];
                }
                else if (to == 40)
                {
                    total = rembau[40];
                }
                else if (to == 41)
                {
                    total = rembau[41];
                }
                else if (to == 42)
                {
                    total = rembau[42];
                }
                else if (to == 43)
                {
                    total = rembau[43];
                }

                else if (to == 44)
                {
                    total = rembau[44];
                }
                else if (to == 45)
                {
                    total = rembau[45];
                }
                else if (to == 46)
                {
                    total = rembau[46];
                }
                else if (to == 47)
                {
                    total = rembau[47];
                }
                else if (to == 48)
                {
                    total = rembau[48];
                }
                else if (to == 49)
                {
                    total = rembau[49];
                }
                else if (to == 50)
                {
                    total = rembau[50];
                }
                else if (to == 51)
                {
                    total = rembau[51];
                }
                else if (to == 52)
                {
                    total = rembau[52];
                }
                else if (to == 54)
                {
                    total = tampin[53];
                }
                else if (to == 54)
                {
                    total = btgMelaka[53];
                }
                else if (to == 56)
                {
                    total = gemas[53];
                }
            }////////////////////////TAMPIN////////////////////////

            else if (from == 54)
            {
                if (to == 0)
                {
                    total = tampin[0];
                }
                else if (to == 1)
                {
                    total = tampin[1];
                }
                else if (to == 2)
                {
                    total = tampin[2];
                }
                else if (to == 3)
                {
                    total = tampin[3];
                }
                else if (to == 4)
                {
                    total = tampin[4];
                }
                else if (to == 5)
                {
                    total = tampin[5];
                }
                else if (to == 6)
                {
                    total = tampin[6];
                }
                else if (to == 7)
                {
                    total = tampin[7];
                }
                else if (to == 8)
                {
                    total = tampin[8];
                }
                else if (to == 9)
                {
                    total = tampin[9];
                }
                else if (to == 10)
                {
                    total = tampin[10];
                }
                else if (to == 11)
                {
                    total = tampin[11];
                }
                else if (to == 12)
                {
                    total = tampin[12];
                }
                else if (to == 13)
                {
                    total = tampin[13];
                }
                else if (to == 14)
                {
                    total = tampin[14];
                }
                else if (to == 15)
                {
                    total = tampin[15];
                }
                else if (to == 16)
                {
                    total = tampin[16];
                }
                else if (to == 17)
                {
                    total = tampin[17];

                }
                else if (to == 18)
                {
                    total = tampin[18];
                }
                else if (to == 19)
                {
                    total = tampin[19];
                }
                else if (to == 20)
                {
                    total = tampin[20];
                }
                else if (to == 21)
                {
                    total = tampin[21];
                }
                else if (to == 22)
                {
                    total = tampin[22];
                }
                else if (to == 23)
                {
                    total = tampin[23];

                }
                else if (to == 24)
                {
                    total = tampin[24];
                }
                else if (to == 25)
                {
                    total = tampin[25];
                }
                else if (to == 26)
                {
                    total = tampin[26];

                }
                else if (to == 27)
                {
                    total = tampin[27];
                }
                else if (to == 28)
                {
                    total = tampin[28];
                }
                else if (to == 29)
                {
                    total = tampin[29];
                }
                else if (to == 30)
                {
                    total = tampin[30];
                }
                else if (to == 31)
                {
                    total = tampin[31];
                }
                else if (to == 32)
                {
                    total = tampin[32];

                }
                else if (to == 33)
                {
                    total = tampin[33];
                }
                else if (to == 34)
                {
                    total = tampin[34];

                }
                else if (to == 35)
                {
                    total = tampin[35];
                }
                else if (to == 36)
                {
                    total = tampin[36];
                }
                else if (to == 37)
                {
                    total = tampin[37];
                }
                else if (to == 38)
                {
                    total = tampin[38];
                }
                else if (to == 39)
                {
                    total = tampin[39];
                }
                else if (to == 40)
                {
                    total = tampin[40];
                }
                else if (to == 41)
                {
                    total = tampin[41];
                }
                else if (to == 42)
                {
                    total = tampin[42];
                }
                else if (to == 43)
                {
                    total = tampin[43];
                }

                else if (to == 44)
                {
                    total = tampin[44];
                }
                else if (to == 45)
                {
                    total = tampin[45];
                }
                else if (to == 46)
                {
                    total = tampin[46];
                }
                else if (to == 47)
                {
                    total = tampin[47];
                }
                else if (to == 48)
                {
                    total = tampin[48];
                }
                else if (to == 49)
                {
                    total = tampin[49];
                }
                else if (to == 50)
                {
                    total = tampin[50];
                }
                else if (to == 51)
                {
                    total = tampin[51];
                }
                else if (to == 52)
                {
                    total = tampin[52];
                }
                else if (to == 53)
                {
                    total = tampin[53];
                }
                else if (to == 55)
                {
                    total = btgMelaka[54];
                }
                else if (to == 56)
                {
                    total = gemas[54];
                }
            }////////////////////////////////////BTG MELAKA////////////////////
            else if (from == 55)
            {
                if (to == 0)
                {
                    total = btgMelaka[0];
                }
                else if (to == 1)
                {
                    total = btgMelaka[1];
                }
                else if (to == 2)
                {
                    total = btgMelaka[2];
                }
                else if (to == 3)
                {
                    total = btgMelaka[3];
                }
                else if (to == 4)
                {
                    total = btgMelaka[4];
                }
                else if (to == 5)
                {
                    total = btgMelaka[5];
                }
                else if (to == 6)
                {
                    total = btgMelaka[6];
                }
                else if (to == 7)
                {
                    total = btgMelaka[7];
                }
                else if (to == 8)
                {
                    total = btgMelaka[8];
                }
                else if (to == 9)
                {
                    total = btgMelaka[9];
                }
                else if (to == 10)
                {
                    total = btgMelaka[10];
                }
                else if (to == 11)
                {
                    total = btgMelaka[11];
                }
                else if (to == 12)
                {
                    total = btgMelaka[12];
                }
                else if (to == 13)
                {
                    total = btgMelaka[13];
                }
                else if (to == 14)
                {
                    total = btgMelaka[14];
                }
                else if (to == 15)
                {
                    total = btgMelaka[15];
                }
                else if (to == 16)
                {
                    total = btgMelaka[16];
                }
                else if (to == 17)
                {
                    total = btgMelaka[17];

                }
                else if (to == 18)
                {
                    total = btgMelaka[18];
                }
                else if (to == 19)
                {
                    total = btgMelaka[19];
                }
                else if (to == 20)
                {
                    total = btgMelaka[20];
                }
                else if (to == 21)
                {
                    total = btgMelaka[21];
                }
                else if (to == 22)
                {
                    total = btgMelaka[22];
                }
                else if (to == 23)
                {
                    total = btgMelaka[23];

                }
                else if (to == 24)
                {
                    total = btgMelaka[24];
                }
                else if (to == 25)
                {
                    total = btgMelaka[25];
                }
                else if (to == 26)
                {
                    total = btgMelaka[26];

                }
                else if (to == 27)
                {
                    total = btgMelaka[27];
                }
                else if (to == 28)
                {
                    total = btgMelaka[28];
                }
                else if (to == 29)
                {
                    total = btgMelaka[29];
                }
                else if (to == 30)
                {
                    total = btgMelaka[30];
                }
                else if (to == 31)
                {
                    total = btgMelaka[31];
                }
                else if (to == 32)
                {
                    total = btgMelaka[32];

                }
                else if (to == 33)
                {
                    total = btgMelaka[33];
                }
                else if (to == 34)
                {
                    total = btgMelaka[34];

                }
                else if (to == 35)
                {
                    total = btgMelaka[35];
                }
                else if (to == 36)
                {
                    total = btgMelaka[36];
                }
                else if (to == 37)
                {
                    total = btgMelaka[37];
                }
                else if (to == 38)
                {
                    total = btgMelaka[38];
                }
                else if (to == 39)
                {
                    total = btgMelaka[39];
                }
                else if (to == 40)
                {
                    total = btgMelaka[40];
                }
                else if (to == 41)
                {
                    total = btgMelaka[41];
                }
                else if (to == 42)
                {
                    total = btgMelaka[42];
                }
                else if (to == 43)
                {
                    total = btgMelaka[43];
                }

                else if (to == 44)
                {
                    total = btgMelaka[44];
                }
                else if (to == 45)
                {
                    total = btgMelaka[45];
                }
                else if (to == 46)
                {
                    total = btgMelaka[46];
                }
                else if (to == 47)
                {
                    total = btgMelaka[47];
                }
                else if (to == 48)
                {
                    total = btgMelaka[48];
                }
                else if (to == 49)
                {
                    total = btgMelaka[49];
                }
                else if (to == 50)
                {
                    total = btgMelaka[50];
                }
                else if (to == 51)
                {
                    total = btgMelaka[51];
                }
                else if (to == 52)
                {
                    total = btgMelaka[52];
                }
                else if (to == 53)
                {
                    total = btgMelaka[53];
                }
                else if (to == 54)
                {
                    total = btgMelaka[54];
                }
                else if (to == 56)
                {
                    total = gemas[55];
                }
            }//////////////////////////////GEMAS////////////////////////////////////////
            else if (from == 56)
            {
                if (to == 0)
                {
                    total = gemas[0];
                }
                else if (to == 1)
                {
                    total = gemas[1];
                }
                else if (to == 2)
                {
                    total = gemas[2];
                }
                else if (to == 3)
                {
                    total = gemas[3];
                }
                else if (to == 4)
                {
                    total = gemas[4];
                }
                else if (to == 5)
                {
                    total = gemas[5];
                }
                else if (to == 6)
                {
                    total = gemas[6];
                }
                else if (to == 7)
                {
                    total = gemas[7];
                }
                else if (to == 8)
                {
                    total = gemas[8];
                }
                else if (to == 9)
                {
                    total = gemas[9];
                }
                else if (to == 10)
                {
                    total = gemas[10];
                }
                else if (to == 11)
                {
                    total = gemas[11];
                }
                else if (to == 12)
                {
                    total = gemas[12];
                }
                else if (to == 13)
                {
                    total = gemas[13];
                }
                else if (to == 14)
                {
                    total = gemas[14];
                }
                else if (to == 15)
                {
                    total = gemas[15];
                }
                else if (to == 16)
                {
                    total = gemas[16];
                }
                else if (to == 17)
                {
                    total = gemas[17];

                }
                else if (to == 18)
                {
                    total = gemas[18];
                }
                else if (to == 19)
                {
                    total = gemas[19];
                }
                else if (to == 20)
                {
                    total = gemas[20];
                }
                else if (to == 21)
                {
                    total = gemas[21];
                }
                else if (to == 22)
                {
                    total = gemas[22];
                }
                else if (to == 23)
                {
                    total = gemas[23];

                }
                else if (to == 24)
                {
                    total = gemas[24];
                }
                else if (to == 25)
                {
                    total = gemas[25];
                }
                else if (to == 26)
                {
                    total = gemas[26];

                }
                else if (to == 27)
                {
                    total = gemas[27];
                }
                else if (to == 28)
                {
                    total = gemas[28];
                }
                else if (to == 29)
                {
                    total = gemas[29];
                }
                else if (to == 30)
                {
                    total = gemas[30];
                }
                else if (to == 31)
                {
                    total = gemas[31];
                }
                else if (to == 32)
                {
                    total = gemas[32];

                }
                else if (to == 33)
                {
                    total = gemas[33];
                }
                else if (to == 34)
                {
                    total = gemas[34];

                }
                else if (to == 35)
                {
                    total = gemas[35];
                }
                else if (to == 36)
                {
                    total = gemas[36];
                }
                else if (to == 37)
                {
                    total = gemas[37];
                }
                else if (to == 38)
                {
                    total = gemas[38];
                }
                else if (to == 39)
                {
                    total = gemas[39];
                }
                else if (to == 40)
                {
                    total = gemas[40];
                }
                else if (to == 41)
                {
                    total = gemas[41];
                }
                else if (to == 42)
                {
                    total = gemas[42];
                }
                else if (to == 43)
                {
                    total = gemas[43];
                }

                else if (to == 44)
                {
                    total = gemas[44];
                }
                else if (to == 45)
                {
                    total = gemas[45];
                }
                else if (to == 46)
                {
                    total = gemas[46];
                }
                else if (to == 47)
                {
                    total = gemas[47];
                }
                else if (to == 48)
                {
                    total = gemas[48];
                }
                else if (to == 49)
                {
                    total = gemas[49];
                }
                else if (to == 50)
                {
                    total = gemas[50];
                }
                else if (to == 51)
                {
                    total = gemas[51];
                }
                else if (to == 52)
                {
                    total = gemas[52];
                }
                else if (to == 53)
                {
                    total = gemas[53];
                }
                else if (to == 54)
                {
                    total = gemas[54];
                }
                else if (to == 55)
                {
                    total = gemas[55];

                }
            }
            

            if (category == 0)
            {
                grandTotal = total;
            }
            else if (category == 1)
            {
                grandTotal = total - (total * 0.3);
            }
            else if (category == 2)
            {
                grandTotal = total - (total * 0.4);
            }
            else if (category == 3)
            {
                grandTotal = total - (total * 0.5);
            }

            if (passenger == 0)
            {
                grandSuperTotal = grandTotal;
            }
            else if (passenger == 1)
            {
                grandSuperTotal = grandTotal * 2;
            }
            else if (passenger == 2)
            {
                grandSuperTotal = grandTotal * 3;
            }
            else if (passenger == 3)
            {
                grandSuperTotal = grandTotal * 4;
            }
            if (returnDate == 0)
            {
                totalPrice = grandSuperTotal * 1;
            }
            else
            {
                totalPrice = grandSuperTotal * 2;
            }

            totalprices = Math.Round(totalPrice / 0.05) * 0.05;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i=0;i< ddlonetwoticket.Items.Count; i++)
            {
                ddlonetwoticket.Items[i].Attributes.Add("onclick", "MutExchkList (This)");
            }
            CalculateDistance();
        }
        public string FirstLocation
        {
            get { return lblTicketFrom.Text; }
        }

        protected void ddlHowMany_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        protected void ddlonetwoticket_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        public string SecondLocation
        {
            get { return lblTicketTo.Text; }
        }
        public string DateGoing
        {
            get { return lbldateONGoing.Text; }
        }

        public string TotalPrice
        {
            get { return totalPrice.ToString("0.00"); }
        }

        public string Category
        {
            get { return ddlCategory.Text; }
        }
        public string HowManyPerson
        {
            get { return lblForPeople.Text; }
        }
        public string OneorTwoway
        {
            get { return ddlonetwoticket.Text; }
        }
        public string PriceBeforeDiscount
        {
            get { return grandSuperTotal.ToString(); }
        }
    }
}
