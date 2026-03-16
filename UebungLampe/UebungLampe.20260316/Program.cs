using UebungLampe._20260316;


// In diesem Beispiel erstellen wir eine Klasse namens "Lampe", die Eigenschaften wie "Farbe" und "IstEingeschaltet" hat.   
Lampe lampe1 = new Lampe(); 

lampe1.Farbe = "Rote";  
lampe1.Einschalten();
lampe1.StatusAnzeigen();


// Hier erstellen wir eine zweite Lampe, die grün ist und ausgeschaltet bleibt. Wir rufen die Methode "StatusAnzeigen" auf, um den aktuellen Zustand der Lampe anzuzeigen.
Lampe lampe2 = new Lampe();
lampe2.Farbe = "Grüne";
lampe2.Ausschalten();
lampe2.StatusAnzeigen();
