using DesafioPOO.Models;
Smartphone nokia = new Nokia("11997995269", "nokia", "11111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("whats");

Smartphone iphone15 = new Iphone("11997995269", "nokia", "11111", 64);
iphone15.Ligar();
iphone15.InstalarAplicativo("telegram");
nokia.InstalarAplicativo("whats");
