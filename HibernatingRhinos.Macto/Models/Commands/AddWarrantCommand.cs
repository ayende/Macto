using System;
using System.Linq;
using HibernatingRhinos.Macto.Models.Processes.Messages;
using Raven.Client;
using Raven.Client.Linq;
using Rhino.ServiceBus;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AddWarrantCommand : ICommand
    {
        private readonly string _inmateId;
        private readonly WarrantType _warrantType;
        private readonly DateTime _issueAt;
        private readonly DateTime _effectiveFrom;
        private readonly string _issuerId;
        private readonly string _scanAttachmentId;
        private readonly TimeSpan _duration;

        public IDocumentSession Session { get; set; }
        public IServiceBus Bus { get; set; }

        public AddWarrantCommand(
            string inmateId,
            WarrantType warrantType,
            DateTime issueAt,
            DateTime effectiveFrom,
            string issuerId,
            string scanAttachmentId,
            TimeSpan duration)
        {
            _inmateId = inmateId;
            _warrantType = warrantType;
            _issueAt = issueAt;
            _effectiveFrom = effectiveFrom;
            _issuerId = issuerId;
            _scanAttachmentId = scanAttachmentId;
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
                                  WarrantScan = _scanAttachmentId
                              };

            dossier.AddWarrant(warrant);

            Bus.Reply(new WarrantsReceived() { Warrants = new [] { warrant } });
        }
    }
}