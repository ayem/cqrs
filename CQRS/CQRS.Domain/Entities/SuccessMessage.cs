namespace CQRS.Domain.Entities
{
    public class SuccessMessage
    {
        public SuccessMessage()
        {
            
        }
        public SuccessMessage(string messageFormat, params object[] args)
        {
            this.Message = string.Format(messageFormat, args);
        }

        public string Message { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as SuccessMessage;
            return other != null && this.Message == other.Message;
        }        
    }
}
