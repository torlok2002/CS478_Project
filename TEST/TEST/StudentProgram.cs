﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    [Serializable]
    class StudentProgram
    {
        private String sFilename;
        private String sName;
        private String sLanguage;
        private List<Object> oStatements;

        public StudentProgram(String sLanguage, String sName, String sFilename)
        {
            oStatements = new List<object>();
            this.sLanguage = sLanguage;
            this.sName = sName;
            this.sFilename = sFilename;
        }
        public void AddStatement(Object oStatement)
        {
            oStatements.Add(oStatement);
        }
        public void DeleteStatement(int iIndex)
        {
            oStatements.RemoveAt(iIndex);
        }
        public void MoveStatement(int iOldIndex, int iNewIndex)
        {   
            Object oStatement = oStatements.ElementAt(iOldIndex);
            oStatements.RemoveAt(iOldIndex);
            if (iNewIndex > iOldIndex) { iNewIndex--; }
            oStatements.Insert(iNewIndex, oStatement);
        }
        public String ProgramLanguage
        {
            get
            {
                return sLanguage;
            }
        }
        public void newFileName(String sNewFileName)
        {
            this.sFilename = sNewFileName;
        }
    }
}