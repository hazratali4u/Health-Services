using System.Collections.Generic;

namespace CORNDataAccessLayer.Response
{
    public class SchemeExpenseBookingResponse
    {
        public List<SchemeExpenseBooking> SchemeExpenseBookingList { get; set; }
        public List<SchemeExpenseBookingDetail> SchemeExpenseBookingDetailList { get; set; }
        public List<SchemeFundReleaseDetail> SchemeFundReleaseDetailList { get; set; }
        public SchemeExpenseBooking SchemeExpenseBookingObject { get; set; }
        public List<AutoComplete> AutoCompleteList { get; set; }
        public bool Status { get; set; }
    }
}
