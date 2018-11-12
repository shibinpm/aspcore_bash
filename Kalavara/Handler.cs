using Kalavara.DataHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kalavara
{
    public class Handler
    {
        private static IDataHandler m_Instance;
        private static readonly Object InstantLocker = new Object();
        public static IDataHandler DataBase
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (InstantLocker)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new MongoDataHandler();
                        }
                    }
                }

                return m_Instance;
            }
        }
    }
}
