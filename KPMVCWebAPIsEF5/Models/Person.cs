using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Transactions;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Reflection;
using System.Xml;


namespace KPMVCWebAPIs.Models
{
    public class Person
    {
        #region "Person-Properties"
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public XmlElement Demographics { get; set; }
        public string Rowguid { get; set; }
        public SqlDateTime ModifiedDate { get; set; }
        #endregion "Person-Properties"

        #region "Person-Constructors"
        public Person()
        {        
        }

        public Person(  int businessEntityID, 
                        string personType, 
                        bool nameStyle, 
                        string title,
                        string firstName,
                        string middleName,
                        string lastName,
                        string suffix,
                        int emailPromotion,
                        string additionalContact,
                        XmlElement demographics,
                        string rowguid,
                        SqlDateTime modifiedDate)
        {
            this.BusinessEntityID = businessEntityID;
            this.PersonType = personType;
            this.NameStyle = nameStyle;
            this.Title = title;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Suffix = suffix;
            this.EmailPromotion = emailPromotion;
            this.AdditionalContactInfo = additionalContact;
            this.Demographics = demographics;
            this.Rowguid = rowguid;
            this.ModifiedDate = modifiedDate;
        }
        #endregion "Person-Constructors"
    }
}