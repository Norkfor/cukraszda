using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cukraszda
{
  public partial class Form1 : Form
  {
    List<sutik> sutemeny = new List<sutik>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Beolvasas();
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("cuki.txt");
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        sutemeny.Add(new sutik(a[0], a[1], Convert.ToBoolean(a[2]), int.Parse(a[3]), a[4]));
      }
      be.Close();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Masodik();
      Harmadik();
      Negyedik();
      Otodik();
    }

    private void Otodik()
    {
    }

    private void Negyedik()
    {
      int darab = 0;
      foreach (var s in sutemeny)
      {
        if (s.Dijazott == true)
        {
          darab++;
        }
      }
      tbDijnyertes.Text = $"{darab} féle díjnyertes édességből választhat.";
    }

    private void Harmadik()
    {
      int max = 0;
      string nev = String.Empty;
      string egyseg = String.Empty;
      foreach (var s in sutemeny)
      {
        if (s.Ara > max)
        {
          nev = s.Nev;
          max = s.Ara;
          egyseg = s.Egyseg;
        }
      }
      tbLegdragabb.Text = $"{nev}";
      tbLegdragabbegyseg.Text = $"{max}/{egyseg}";

      int min = max;
      string nev1 = String.Empty;
      string egyseg1 = String.Empty;
      foreach (var s in sutemeny)
      {
        if (s.Ara < min)
        {
          nev1 = s.Nev;
          min = s.Ara;
          egyseg1 = s.Egyseg;
        }
      }
      tbLegolcsobb.Text = $"{nev1}";
      tbLegolcsobbegyseg.Text = $"{min}/{egyseg1}";
    }

    private void Masodik()
    {
      Random rnd = new Random();
      int index = rnd.Next(sutemeny.Count - 1);
      tbAjanlat.Text = $"Mai ajánlatunk: {sutemeny[index].Nev}";
    }
  }
}
