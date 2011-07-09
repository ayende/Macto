﻿using System;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AddWarrantCommand : ICommand
    {
        public AddWarrantCommand(
            string inmateId,
            WarrantType warrantType,
            DateTime effectiveDate,
            IIssuingAuthority issuingAuthority

            )
        {
            
        }

        public bool CanExecute()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public enum WarrantType
        {
            Arrest,
            Detention,
            Remand,
            Sentencing
        }
    }
}