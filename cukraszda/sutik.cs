using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cukraszda
{
  class sutik
  {
    private string nev;

    public string Nev
    {
      get { return nev; }
    }

    private string tipusa;

    public string Tipusa
    {
      get { return tipusa; }
    }

    private bool dijazott;

    public bool Dijazott
    {
      get { return dijazott; }
    }

    private int ara;

    public int Ara
    {
      get { return ara; }
    }

    private string egyseg;

    public string Egyseg
    {
      get { return egyseg; }
    }

    public sutik(string nev, string tipusa, bool dijazott, int ara, string egyseg)
    {
      this.nev = nev;
      this.tipusa = tipusa;
      this.dijazott = dijazott;
      this.ara = ara;
      this.egyseg = egyseg;
    }
  }
}
