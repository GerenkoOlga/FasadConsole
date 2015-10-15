using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amf = new Amplifier("Amplifier");
            Tuner tun = new Tuner("Tuner",amf);
            DvdPlayer dvd=new DvdPlayer("DVD",amf);
            CdPlayer cd =new CdPlayer("CD",amf);
            Projector projector=new Projector("Projector",dvd);
            TheaterLights lights=new TheaterLights("TheaterLights");
            Screen screen=new Screen("Screen");
            PopcornPopper popper=new PopcornPopper("PopcornPopper");
            HomeTheaterFacade homeTheatre = new HomeTheaterFacade(amf,tun,dvd,cd, projector, screen,lights, popper);
            Console.WriteLine(homeTheatre.ListenToRadio(4.5));
            Console.WriteLine(homeTheatre.ListenToCd("Bony M"));
            Console.WriteLine(homeTheatre.EndRadio());
            Console.WriteLine(homeTheatre.EndCd());
            Console.WriteLine(homeTheatre.WatchMovie("Animate"));
            Console.WriteLine(homeTheatre.EndMovie());
            Console.ReadKey();

        }
}
}
