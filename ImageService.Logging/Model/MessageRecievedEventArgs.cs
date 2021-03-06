﻿using System;

namespace ImageService.Logging.Model
{
    public class MessageRecievedEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MessageTypeEnum Status { get; set; }

        public MessageRecievedEventArgs(string msg, MessageTypeEnum st)
        {
            Message = msg;
            Status = st;
        }

		/// <summary>
		/// Converts EventLogEntryType back to MessageTypeEnum (for clients logger).
		/// </summary>
		/// <param name="t">type</param>
		/// <returns></returns>
		public static MessageTypeEnum GetTypeEnum(int t)
        {
            if (t == 0)
            {
                return MessageTypeEnum.INFO;
            }
            else if (t == 1)
            {
                return MessageTypeEnum.WARNING;
            }
            return MessageTypeEnum.FAIL;
        }
    }
}
