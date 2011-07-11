using System;
using System.Collections.Generic;
using HibernatingRhinos.Macto.Models.Processes;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AcceptNewInmateCommand : ICommand
    {
        private readonly string _fullName;
        private readonly string _lastName;
        private readonly DateTime _dateOfBirth;
        private readonly string _locationId;
        private readonly ICollection<Warrant> _warrants;

        public AcceptNewInmateCommand(
            string fullName,
            string lastName,
            DateTime dateOfBirth,
            string locationId,
            ICollection<Warrant> warrants)
        {
            _fullName = fullName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _locationId = locationId;
            _warrants = warrants;
        }

        public void Execute()
        {
            var acceptNewInmateProcess = new AcceptInmateProcess();
            acceptNewInmateProcess.Consume(new NewInmateArrived()
                                               {
                                                   FullName = _fullName,
                                                   LastName = _lastName,
                                                   DateOfBirth = _dateOfBirth,
                                                   LocationId = _locationId
                                               });
            acceptNewInmateProcess.Consume(new WarrantsReceived() { Warrants = _warrants });
        }
    }
}