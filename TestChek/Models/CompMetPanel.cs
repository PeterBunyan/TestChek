using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class CompMetPanel
    {
        public int sodium { get; set; }
        public string sodiumReferenceRange { get; set; }
        public decimal potassium { get; set; }
        public string potassiumReferenceRange { get; set; }
        public int chloride { get; set; }
        public string chlorideReferenceRange { get; set; }
        public int carbonDioxide { get; set; }
        public string carbonDioxideReferenceRange { get; set; }
        public int anionGap { get; set; }
        public string anionGapReferenceRange { get; set; }
        public int glucoseRandom { get; set; }
        public string glucoseRandomReferenceRange { get; set; }
        public int BUN { get; set; }
        public string BUNReferenceRange { get; set; }
        public decimal creatinine { get; set; }
        public string creatinineReferenceRange { get; set; }
        public decimal eGFR { get; set; }
        public string eGFRReferenceRange { get; set; }
        public decimal proteinTotal { get; set; }
        public string proteinTotalReferenceRange { get; set; }
        public decimal albumin { get; set; }
        public string albuminReferenceRange { get; set; }
        public decimal calcium { get; set; }
        public string calciumReferenceRange { get; set; }
        public decimal bilirubinTotal { get; set; }
        public string bilirubinTotalReferenceRange { get; set; }
        public int AST { get; set; }
        public string ASTReferenceRange { get; set; }
        public int ALT { get; set; }
        public string ALTReferenceRange { get; set; }
        public int alkPhosTotal { get; set; }
        public string alkPhosTotalReferenceRange { get; set; }
    }
}