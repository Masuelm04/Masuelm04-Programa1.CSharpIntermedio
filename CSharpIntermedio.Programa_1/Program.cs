using CSharpIntermedio.Programa_1;

Socio[] socios = new Socio[]
{
    new Socio("Margarita",4),
    new Socio("Ramón",7),
    new Socio("Carmen",1)
};

Club club1 = new("Caraballo's Club", socios);

club1.ImprimirSocioMasAntiguo();