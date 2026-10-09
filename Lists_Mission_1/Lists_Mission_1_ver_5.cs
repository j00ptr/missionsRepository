using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
static void MyMethod(List<string> fname)
{
    Console.WriteLine("Fighters" + fname);
}

static void Main(List<string>[] args)
{
    List<string> fname = ["roger", "chrysalis", "bigbone", "innajeez"];
    MyMethod(fname);
}