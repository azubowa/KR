using System;
using System.Collections.Generic;
using System.Text;

namespace КР.Model
{
    public class arbeiter : interfacemenschen
    {
        string _nachname, _name, _vatersname, _arbeitplatz, _beruf;
        public arbeiter(string nachname, string name, string vatersname, string arbeitplatz, string beruf)
        {
            _nachname = nachname;
            _name = name;
            _vatersname = vatersname;
            _arbeitplatz = arbeitplatz;
            _beruf = beruf;
        }
        public string nachname { get => _nachname; set => _nachname = value; }
        public string name { get => _name; set => _name = value; }
        public string vatersname { get => _vatersname; set => _vatersname = value; }
        public string arbeitplatz { get => _arbeitplatz; set => _arbeitplatz = value; }
        public string beruf { get => _beruf; set => _beruf = value; }
    }
}
