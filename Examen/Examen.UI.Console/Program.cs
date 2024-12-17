// See https://aka.ms/new-console-template for more information
using Azure;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;
using Examen.Infrastructure;
using System.Numerics;

Console.WriteLine("Hello, World!");
Chanson chanson = new Chanson();
Artiste artiste = new Artiste();


GFContext ctx = new GFContext();

UnitOfWork uow = new UnitOfWork(ctx);

ChansonService s1 = new ChansonService(uow);
ArtisteService a1 = new ArtisteService(uow);


s1.Add(chanson);
a1.Add(artiste);
a1.Commit();
s1.Commit();
ctx.SaveChanges();

foreach (Chanson c in s1.GetMany())

    Console.WriteLine("StyleMusical: " + c.StyleMusical + "Titre :" + c.Titre + " DateSortie:" + c.DateSortie + "VuesYouTube:" + c.VuesYoutube + "Duree:" + c.Duree + "ArtisteFk:" + c.ArtisteFk);
foreach (Artiste a in a1.GetMany())

    Console.WriteLine("Nom :" + a.Nom + " DateNaissance:" + a.DateNaissance + "Contact:" + a.Contact + "Nationalite:" + a.Nationalite);



