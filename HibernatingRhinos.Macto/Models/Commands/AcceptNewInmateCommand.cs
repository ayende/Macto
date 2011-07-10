using System;
using System.Collections.Generic;
using HibernatingRhinos.Macto.Models.Processes;
using HibernatingRhinos.Macto.Models.Warrants;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AcceptNewInmateCommand : ICommand
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly DateTime _dateOfBirth;
        private readonly string _locationId;
        private readonly ICollection<Warrant> _warrants;

        public AcceptNewInmateCommand(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string locationId,
            ICollection<Warrant> warrants)
        {
            _firstName = firstName;
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
                                                   FirstName = _firstName,
                                                   LastName = _lastName,
                                                   DateOfBirth = _dateOfBirth,
                                                   LocationId = _locationId
                                               });
            acceptNewInmateProcess.Consume(new WarrantsReceived() { Warrants = _warrants });
        }
    }
}