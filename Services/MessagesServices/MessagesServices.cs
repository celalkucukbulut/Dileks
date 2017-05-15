using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domains;

namespace Services.MessagesServices
{
    public class MessagesServices : IMessagesServices
    {
        #region .ctor
        private readonly IMessagesRepository _messagesRepository;

        public MessagesServices(IMessagesRepository messagesRepository)
        {
            _messagesRepository = messagesRepository;
        }


        #endregion
        public bool InsertMessage(Messages message)
        {
            try
            {
                message.CreatedDate = DateTime.Now;
                _messagesRepository.Add(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
