﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataProvider.Models
{
    public class Etablissement
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string siren { get; set; }
        public string nic { get; set; }
        public string l1_normalisee { get; set; }
        public string l2_normalisee { get; set; }
        public string l3_normalisee { get; set; }
        public string l4_normalisee { get; set; }
        public string l5_normalisee { get; set; }
        public string l6_normalisee { get; set; }
        public string l7_normalisee { get; set; }
        public string l1_declaree { get; set; }
        public string l2_declaree { get; set; }
        public string l3_declaree { get; set; }
        public string l4_declaree { get; set; }
        public string l5_declaree { get; set; }
        public string l6_declaree { get; set; }
        public string l7_declaree { get; set; }
        public string numvoie { get; set; }
        public string indrep { get; set; }
        public string typvoie { get; set; }
        public string libvoie { get; set; }
        public string codpos { get; set; }
        public string cedex { get; set; }
        public string rpet { get; set; }
        public string libreg { get; set; }
        public string depet { get; set; }
        public string arronet { get; set; }
        public string ctonet { get; set; }
        public string comet { get; set; }
        public string libcom { get; set; }
        public string du { get; set; }
        public string tu { get; set; }
        public string uu { get; set; }
        public string epci { get; set; }
        public string tcd { get; set; }
        public string zemet { get; set; }
        public string siege { get; set; }
        public string enseigne { get; set; }
        public string ind_publipo { get; set; }
        public string diffcom { get; set; }
        public string amintret { get; set; }
        public string natetab { get; set; }
        public string libnatetab { get; set; }
        public string apet700 { get; set; }
        public string libapet { get; set; }
        public string dapet { get; set; }
        public string tefet { get; set; }
        public string libtefet { get; set; }
        public string efetcent { get; set; }
        public string defet { get; set; }
        public string origine { get; set; }
        public string dcret { get; set; }
        public string ddebact { get; set; }
        public string activnat { get; set; }
        public string lieuact { get; set; }
        public string actisurf { get; set; }
        public string saisonat { get; set; }
        public string modet { get; set; }
        public string prodet { get; set; }
        public string prodpart { get; set; }
        public string auxilt { get; set; }
        public string nomen_long { get; set; }
        public string sigle { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string civilite { get; set; }
        public string rna { get; set; }
        public string nicsiege { get; set; }
        public string rpen { get; set; }
        public string depcomen { get; set; }
        public string adr_mail { get; set; }
        public string nj { get; set; }
        public string libnj { get; set; }
        public string apen700 { get; set; }
        public string libapen { get; set; }
        public string dapen { get; set; }
        public string aprm { get; set; }
        public string ess { get; set; }
        public string dateess { get; set; }
        public string tefen { get; set; }
        public string libtefen { get; set; }
        public string efencent { get; set; }
        public string defen { get; set; }
        public string categorie { get; set; }
        public string dcren { get; set; }
        public string amintren { get; set; }
        public string monoact { get; set; }
        public string moden { get; set; }
        public string proden { get; set; }
        public string esaann { get; set; }
        public string tca { get; set; }
        public string esaapen { get; set; }
        public string esasec1n { get; set; }
        public string esasec2n { get; set; }
        public string esasec3n { get; set; }
        public string esasec4n { get; set; }
        public string vmaj { get; set; }
        public string vmaj1 { get; set; }
        public string vmaj2 { get; set; }
        public string vmaj3 { get; set; }
        public string datemaj { get; set; }
    }
}
