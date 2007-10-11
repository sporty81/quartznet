﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=1.1.4322.2407.
// 
namespace Quartz.Xml {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData", IsNullable=false)]
    public class quartz {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-listener")]
        public joblistenerType[] joblistener;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calendar")]
        public calendarType[] calendar;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job")]
        public jobType[] job;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("overwrite-existing-jobs")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool overwriteexistingjobs = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="job-listenerType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class joblistenerType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("required")]
        public string name = "required";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(cronType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(simpleType))]
    public abstract class abstractTriggerType {
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string group;
        
        /// <remarks/>
        public string description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("misfire-instruction")]
        public string misfireinstruction;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("calendar-name")]
        public string calendarname;
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool @volatile = false;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool volatileSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class cronType : abstractTriggerType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-name")]
        public string jobname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-group")]
        public string jobgroup;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("start-time")]
        public System.DateTime starttime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-time")]
        public System.DateTime endtime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cron-expression")]
        public string cronexpression;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time-zone")]
        public string timezone;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class simpleType : abstractTriggerType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-name")]
        public string jobname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-group")]
        public string jobgroup;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("start-time")]
        public System.DateTime starttime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("end-time")]
        public System.DateTime endtime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endtimeSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-count", DataType="integer")]
        public string repeatcount;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeat-interval", DataType="nonNegativeInteger")]
        public string repeatinterval;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class triggerType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cron", typeof(cronType))]
        [System.Xml.Serialization.XmlElementAttribute("simple", typeof(simpleType))]
        public abstractTriggerType Item;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class entryType {
        
        /// <remarks/>
        public string key;
        
        /// <remarks/>
        public string value;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="job-data-mapType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class jobdatamapType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public entryType[] entry;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("allows-transient-data")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool allowstransientdata = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="job-detailType", Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class jobdetailType {
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string group;
        
        /// <remarks/>
        public string description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-type")]
        public string jobtype;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-listener-ref")]
        public string joblistenerref;
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool @volatile = false;
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool durable = false;
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool recover = false;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-data-map")]
        public jobdatamapType jobdatamap;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class jobType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("job-detail")]
        public jobdetailType jobdetail;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trigger")]
        public triggerType[] trigger;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://quartznet.sourceforge.net/JobSchedulingData")]
    public class calendarType {
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("base-calendar")]
        public calendarType basecalendar;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool replace = false;
    }
}
