using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NDSU_UCS_App.Classes
{
    [Serializable]
    public class MembersList
    {
        //private string serializationFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "SaveFiles", "Members.bin");
        //the above path doesn't work after publishing, but for my purposes (I will be the only one to use it on only this computer), I can use a static path
        private string serializationFile = @"D:\School\2017-2018\2018 Spring\UCS\Members.bin";
        public List<Member> MemberList { get; private set; }

        public MembersList()
        {
            MemberList = new List<Member>();
            OpenFromFile();
        }

        public void AddMember (string name)
        {
            //this should be the only place new Member is called
            //only because I can't serialize static variables
            MemberList.Add(new Member(name, getHighestID() + 1));
        }
        public void DeleteMember(int memberID)
        {
            //remove any Member that has memberID
            MemberList.RemoveAll(x => x.ID == memberID);
        }
        public Member GetMember (int memberID)
        {
            return MemberList.Find(x => x.ID == memberID);
        }
        public void AddTransaction (int memberID, int amount, string description)
        {
            GetMember(memberID).AddTransaction(amount, description);
        }
        public void Sort()
        {
            if (MemberList.Count > 1)
            {
                MemberList.Sort((x,y) => x.CompareTo(y));
            }
        }

        public void OpenFromFile()
        {
            //if file doesn't exist exists
            if (! (File.Exists(serializationFile)))
            {
                //createNewFile
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, new List<Member>());
                }
            }
            //open file
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                MemberList = (List<Member>)bformatter.Deserialize(stream);
            }
        }
        public void Save()
        {
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, MemberList);
            }
        }
        private int getHighestID()
        {
            int highestID = 0;
            foreach (Member member in MemberList)
            {
                if (member.ID >= highestID)
                {
                    highestID = member.ID;
                }
            }
            return highestID;
        }
    }
}
