using System;
using System.Linq;
using HibernatingRhinos.Macto.Models.Processes;
using HibernatingRhinos.Macto.Models.Warrants;
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

            Warrant warrant = null;

            switch (_warrantType)
            {
                case WarrantType.Arrest:
                    warrant = new ArrestWarrant()
                    {
                        Duration = _duration,
                        EffectiveFrom = _effectiveFrom,
                        IssueAt = _issueAt,
                        IssuerId = _issuerId,
                        ScanLocationUrl = _scanLocationUrl
                    };
                    break;
                case WarrantType.Detention:
                    warrant = new DetentionWarrant()
                    {
                        Duration = _duration,
                        EffectiveFrom = _effectiveFrom,
                        IssueAt = _issueAt,
                        IssuerId = _issuerId,
                        ScanLocationUrl = _scanLocationUrl
                    };
                    break;
                case WarrantType.Remand:
                    warrant = new RemandWarrant()
                    {
                        EffectiveFrom = _effectiveFrom,
                        IssueAt = _issueAt,
                        IssuerId = _issuerId,
                        ScanLocationUrl = _scanLocationUrl
                    };
                    break;
                case WarrantType.Sentencing:
                    warrant = new SentencingWarrant()
                    {
                        Duration = _duration,
                        EffectiveFrom = _effectiveFrom,
                        IssueAt = _issueAt,
                        IssuerId = _issuerId,
                        ScanLocationUrl = _scanLocationUrl
                    };
                    break;
                default:
                    throw new ArgumentOutOfRangeException("warrantType");
            }

            dossier.AddWarrant(warrant);

            var acceptInmateProcess = new AcceptInmateProcess();
            acceptInmateProcess.Consume(new WarrantsReceived() { Warrants = new [] { warrant } });
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