namespace org_view.Client.Models
{
    public class OrgDto
    {
        public string organisasjonsnummer { get; set; }
        public string navn { get; set; }
        public Organisasjonsform organisasjonsform { get; set; }
        public Postadresse postadresse { get; set; }
        public Forretningsadresse forretningsadresse { get; set; }
        public bool registrertIMvaregisteret { get; set; }
        public string maalform { get; set; }
        public Naeringskode1 naeringskode1 { get; set; }
        public Naeringskode2 naeringskode2 { get; set; }
        public Naeringskode3 naeringskode3 { get; set; }
        public Hjelpeenhetskode hjelpeenhetskode { get; set; }
        public bool underAvvikling { get; set; }
        public string underAvviklingDato { get; set; }
        public bool registrertIStiftelsesregisteret { get; set; }
        public bool konkurs { get; set; }
        public string konkursdato { get; set; }
        public string tvangsavvikletPgaManglendeSlettingDato { get; set; }
        public string tvangsopplostPgaManglendeDagligLederDato { get; set; }
        public string tvangsopplostPgaManglendeRevisorDato { get; set; }
        public string tvangsopplostPgaManglendeRegnskapDato { get; set; }
        public string tvangsopplostPgaMangelfulltStyreDato { get; set; }
        public string vedtektsdato { get; set; }
        public string[] vedtektsfestetFormaal { get; set; }
        public string[] aktivitet { get; set; }
        public bool registrertIFrivillighetsregisteret { get; set; }
        public string stiftelsesdato { get; set; }
        public Institusjonellsektorkode institusjonellSektorkode { get; set; }
        public bool registrertIForetaksregisteret { get; set; }
        public string registreringsdatoEnhetsregisteret { get; set; }
        public string hjemmeside { get; set; }
        public string sisteInnsendteAarsregnskap { get; set; }
        public string[] frivilligMvaRegistrertBeskrivelser { get; set; }
        public bool underTvangsavviklingEllerTvangsopplosning { get; set; }
        public int antallAnsatte { get; set; }
        public bool harRegistrertAntallAnsatte { get; set; }
        public string overordnetEnhet { get; set; }
        public string registreringsdatoAntallAnsatteNAVAaregisteret { get; set; }
        public string registreringsdatoAntallAnsatteEnhetsregisteret { get; set; }
        public string registreringsdatoMerverdiavgiftsregisteret { get; set; }
        public string registreringsdatoMerverdiavgiftsregisteretEnhetsregisteret { get; set; }
        public string registreringsdatoFrivilligMerverdiavgiftsregisteret { get; set; }
        public string registreringsdatoForetaksregisteret { get; set; }
        public string registreringsdatoFrivillighetsregisteret { get; set; }
        public bool registrertIPartiregisteret { get; set; }
        public string registreringsdatoPartiregisteret { get; set; }
        public string epostadresse { get; set; }
        public string telefon { get; set; }
        public string mobil { get; set; }
        public _Links1 _links { get; set; }
    }

    public class Organisasjonsform
    {
        public _Links _links { get; set; }
        public string kode { get; set; }
        public string utgaatt { get; set; }
        public string beskrivelse { get; set; }
    }

    public class _Links
    {
        public Self self { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Postadresse
    {
        public string kommune { get; set; }
        public string landkode { get; set; }
        public string postnummer { get; set; }
        public string[] adresse { get; set; }
        public string land { get; set; }
        public string kommunenummer { get; set; }
        public string poststed { get; set; }
    }

    public class Forretningsadresse
    {
        public string kommune { get; set; }
        public string landkode { get; set; }
        public string postnummer { get; set; }
        public string[] adresse { get; set; }
        public string land { get; set; }
        public string kommunenummer { get; set; }
        public string poststed { get; set; }
    }

    public class Naeringskode1
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }

    public class Naeringskode2
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }

    public class Naeringskode3
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }

    public class Hjelpeenhetskode
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }

    public class Institusjonellsektorkode
    {
        public string kode { get; set; }
        public string beskrivelse { get; set; }
    }

    public class _Links1
    {
        public Overordnetenhet overordnetEnhet { get; set; }
        public Self1 self { get; set; }
    }

    public class Overordnetenhet
    {
        public string href { get; set; }
    }

    public class Self1
    {
        public string href { get; set; }
    }

}