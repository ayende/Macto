using System;

namespace HibernatingRhinos.Macto.Models.Commands
{
    public class AcceptInmateSaga : ISaga<AcceptInmateState>
    {
        public AcceptInmateState State { get; set; }
        public bool IsCompleted { get; set; }

        public AcceptInmateSaga()
        {
            State = new AcceptInmateState();
        }

        public void Consume()
        {
            // Identify the Inmate
            // Their name

            // Create the record
            // Determine their location
            // Add notes if present
            // Add stick notes if present

            // Do we have a legal info? If yes create a dossier
            // Add their warrants
        }

        private void AcceptInmateIfDone()
        {
            
        }
    }

    public class AcceptInmateState
    {
    }

    public interface ISaga<T>
    {
    }
}