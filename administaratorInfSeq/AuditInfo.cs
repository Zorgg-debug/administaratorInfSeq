using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administaratorInfSeq
{
    /// <summary>
    /// класс для привязки к странице аудита
    /// </summary>
    public class AuditInfo
    {
        public InformationAudit rankOut { get; set; }
        public InformationAudit contr { get; set; }
        public InformationAudit institute { get; set; }
        public InformationAudit periods { get; set; }
        public InformationAudit pk { get; set; }
        public InformationAudit militarydistrict { get; set; }
        public InformationAudit pkVSkpu { get; set; }
        public InformationAudit shtat { get; set; }
        public InformationAudit bezvz { get; set; }
        
    }
}
