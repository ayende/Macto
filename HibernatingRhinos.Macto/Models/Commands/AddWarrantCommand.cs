using System;
using System.Linq;
using HibernatingRhinos.Macto.Models.Processes;
using HibernatingRhinos.Macto.Models.Processes.Messages;
using Raven.Client;
using Raven.Client.Linq;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AddWarrantCommand : ICommand
    {
        private readonly string _inmateId;
        private readonly WarrantType _warrantType;
        private readonly DateTime _issueAt;
        private readonly DateTime _effectiveFrom;
        private readonly string _issuerId;
        private readonly string _scanLocationUrl;
        private readonly TimeSpan _duration;

        public IDocumentSession Session { get; set; }

        public AddWarrantCommand(
            string inmateId,
            WarrantType warrantType,
            DateTime issueAt,
            DateTime effectiveFrom,
            string issuerId,
            string scanLocationUrl,
            TimeSpan duration)
        {
            _inmateId = inmateId;
            _warrantType = warrantType;
            _issueAt = issueAt;
            _effectiveFrom = effectiveFrom;
            _issuerId = issuerId;
            _scanLocationUrl = scanLocationUrl;
            _duration = duration;
        }

        public void Execute()
        {
            var dossier = Session.Query<Dossier>()
               .Where(d => d.InmateId == _inmateId)
               .SingleOrDefault();

            var warrant = new Warrant()
                              {
                                  Type = _warrantType,
                                  Duration = _duration,
                                  EffectiveFrom = _effectiveFrom,
                                  IssueAt = _issueAt,
                                  IssuerId = _issuerId,
                                  ScanLocationUrl = _scanLocationUrl
                              };

            dossier.AddWarrant(warrant);

            var acceptInmateProcess = new AcceptInmateProcess();
            acceptInmateProcess.Consume(new WarrantsReceived() { Warrants = new [] { warrant } });
        }

        
    }
}