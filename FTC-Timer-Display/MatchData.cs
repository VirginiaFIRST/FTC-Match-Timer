﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FTC_Timer_Display
{
    [Serializable]
    public class MatchData
    {
        private InitialData _initData = null;

        public int divID { get { return _initData.divID; } }
        public string divisionName { get { return _initData.divName; } }
        public int fieldID = 0;
        public bool displayFieldNumber = true;
        private MatchTypes _matchType = MatchTypes.Unknown;
        public MatchTypes matchType
        {
            get { return _matchType; }
            set
            {
                if (value != _matchType) log("Match Type changed from '{0}' to '{1}'.",_matchType, value);
                _matchType = value;
            }
        }
        private MatchPeriods _matchPeriod = MatchPeriods.NotStarted;
        public MatchPeriods matchPeriod
        {
            get { return _matchPeriod; }
            set
            {
                if (value != _matchPeriod) log("Match Period changed from '{0}' to '{1}'.", _matchPeriod, value);
                _matchPeriod = value;
            }
        }
        private MatchStatus _matchStatus = MatchStatus.Stopped;
        public MatchStatus matchStatus
        {
            get { return _matchStatus; }
            set
            {
                if (value != _matchStatus) log("Match Status changed from '{0}' to '{1}'.", _matchStatus, value);
                _matchStatus = value;
            }
        }
        private int _matchNumberMajor = 1;
        public int matchNumberMajor
        {
            get { return _matchNumberMajor; }
            set
            {
                if (value != _matchNumberMajor) log("Match Number Major moved from '{0}' to '{1}'.", _matchNumberMajor, value);
                _matchNumberMajor = value;
            }
        }
        private int _matchNumberMinor = 0;
        public int matchNumberMinor
        {
            get { return _matchNumberMinor; }
            set
            {
                if (value != _matchNumberMinor) log("Match Number Minor moved from '{0}' to '{1}'.", _matchNumberMinor, value);
                _matchNumberMinor = value;
            }
        }
        public int matchLength = 0;
        public string timeoutMessage = "";

        public IPEndPoint fromEndpoint = null;
        public long serverHeartbeat = -1;

        public bool noCrossActive = true;

        public SoundGenerator.SoundPackage soundPackage = null;

        public SoundLocations soundLocation = SoundLocations.Off;
        public bool useLargeActive = true;

        public TimeSpan timerValue = new TimeSpan();

        public bool isMultiDivision { get { return _initData.isMultiDivision; } }
        public bool isSelectedByServer { get; set; }

        public int ticksPassed
        {
            get
            {
                if (matchLength == 0) return 0;
                int i = matchLength - (int)timerValue.TotalSeconds;
                if (i < 0) return 0;
                return i;
            }
        }

        public int percentComplete
        {
            get
            {
                if (ticksPassed == 0) return 0;
                if (matchStatus == MatchStatus.Stopped && matchPeriod == MatchPeriods.Complete) return 100;
                double d = (double)ticksPassed / (double)matchLength;
                int i = (int)(d * 100);
                return i;
            }
        }

        public int percentRemain
        {
            get
            {
                return 100 - this.percentComplete;
            }
        }

        public MatchData() { }

        public MatchData(InitialData initData, int field)
        {
            _initData = initData;
            fieldID = field;
            this.matchNumberMajor = field;
        }

        public void SetMatchTimer(MatchTypes type, int major, int minor, TimeSpan timer, MatchPeriods period, MatchStatus status)
        {
            this.matchType = type;
            this.matchNumberMajor = major;
            this.matchNumberMinor = minor;
            this.timerValue = timer;
            this.matchPeriod = period;
            this.matchStatus = status;
        }

        public enum MatchTypes
        {
            Unknown,
            Practice,
            Qualification,
            Quarterfinals,
            Semifinals,
            Finals
        }
        public enum MatchPeriods
        {
            NotStarted = 0,
            Autonomous = 1,
            DriverControlled = 2,
            EndGame = 3,
            Complete = 4
        }

        public enum MatchStatus
        {
            Timeout,
            Stopped,
            Running,
            Paused
        }

        public enum SoundLocations
        {
            Off = 0,
            Server = 1,
            Client = 2,
            Both = 3
        }

        public enum EventTypes
        {
            Qualifier = 0,
            Meet = 1,
            Championship = 2,
            Other = 9
        }

        public bool isMinorMatchNumberSupported
        {
            get
            {
                return TypeUsesMinor(this.matchType);
            }
        }

        public static bool TypeUsesMinor(MatchTypes type)
        {
            if (type == MatchTypes.Quarterfinals) return true;
            if (type == MatchTypes.Semifinals) return true;
            return false;
        }

        public string matchNumberString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.matchNumberMajor);
                if (this.matchNumberMinor != 0)
                {
                    sb.Append("-");
                    sb.Append(this.matchNumberMinor);
                }
                return sb.ToString();
            }
        }
        public string matchTypeShort
        {
            get
            {
                switch (this.matchType)
                {
                    case MatchTypes.Quarterfinals: return "QF";
                    case MatchTypes.Semifinals: return "SF";
                    default: return this.matchType.ToString().ToCharArray()[0].ToString();
                }
            }
        }
        public string matchHeaderString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (this.isMultiDivision)
                {
                    if (this.divisionName != "")
                    {
                        sb.Append(this.divisionName);
                        sb.Append(" Division ");
                    }
                    else
                    {
                        sb.Append("Division ");
                        sb.Append(this.divID);
                        sb.Append(" ");
                    }
                }
                else if (this.divisionName != "")
                {
                    sb.Append(this.divisionName);
                    sb.Append(" ");
                    if (this._initData.eventType != EventTypes.Other)
                    {
                        sb.Append(this._initData.eventType.ToString());
                        sb.Append(" ");
                    }
                }
                if (this.displayFieldNumber)
                {
                    sb.Append("Field ");
                    sb.Append(this.fieldID);
                }
                sb.Append(Environment.NewLine);
                if (this.matchStatus != MatchStatus.Timeout)
                {
                    if (this._matchPeriod == MatchPeriods.Complete) sb.Append("Finished ");
                    else sb.Append(this.matchType);
                    sb.Append(" Match ");
                    sb.Append(this.matchNumberString);
                }
                else
                {
                    sb.Append(this.timeoutMessage);
                }
                return sb.ToString();
            }
        }

        public string matchFooterString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                switch (this.matchPeriod)
                {
                    case MatchPeriods.NotStarted: sb.Append("Not Started"); break;
                    case MatchPeriods.DriverControlled: sb.Append("Driver Controlled"); break;
                    case MatchPeriods.EndGame: sb.Append("End Game"); break;
                    default: sb.Append(this.matchPeriod.ToString()); break;
                }
                if (isActivePeriod) sb.Append(" Period");
                sb.Append(Environment.NewLine);
                sb.Append(this.matchStatus);
                return sb.ToString();
            }
        }

        /// <summary>
        /// Internal function to log data from the instance.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        private void log(string message, params object[] args)
        {
            if (!Properties.logging.Default.logMatchDataChanges) return;
            string myName = string.Format("MatchData-{0}-{1}", this.divID, this.fieldID);
            LogMgr.logger.Info(LogMgr.make(message, myName, 0, args));
        }

        /// <summary>
        /// Gets a value indicating whether this matchdata is ready to start a match.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is waiting for start; otherwise, <c>false</c>.
        /// </value>
        public bool isWaitingForStart
        {
            get
            {
                if (this.matchStatus == MatchStatus.Paused) return true;
                if (this.matchStatus == MatchStatus.Stopped && this.matchPeriod == MatchPeriods.NotStarted) return true;
                return false;
            }
        }
        /// <summary>
        /// Gets a value indicating whether the timeris running, no matter the reason.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [timer running]; otherwise, <c>false</c>.
        /// </value>
        public bool isTimerRunning
        {
            get
            {
                if (this.matchStatus == MatchStatus.Running) return true;
                if (this.matchStatus == MatchStatus.Timeout) return true;
                return false;
            }
        }
        /// <summary>
        /// Whether this matchdata is an active match.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is match active; otherwise, <c>false</c>.
        /// </value>
        public bool isMatchActive
        {
            get
            {
                if (this.matchStatus == MatchStatus.Running) return true;
                if (this.matchStatus == MatchStatus.Paused) return true;
                return false;
            }
        }

        /// <summary>
        /// Returns whether this matchdata pack has an active period type assigned.
        /// e.g. A period that is not the beginning or end of a match.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is active period; otherwise, <c>false</c>.
        /// </value>
        public bool isActivePeriod
        {
            get
            {
                switch (this.matchPeriod)
                {
                    case MatchPeriods.NotStarted: return false;
                    case MatchPeriods.Complete: return false;
                    default: return true;
                }
            }
        }
    }
}
