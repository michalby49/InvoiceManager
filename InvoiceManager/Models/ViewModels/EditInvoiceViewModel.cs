﻿using InvoiceManager.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceManager.Models.ViewModels
{
    public class EditInvoiceViewModel
    {

        public Invoice Invoice { get; set; }
        public List<Client> Clients { get; set; }
        public List<MethodOfPaymant> MethodOfPaymants { get; set; }
        public string Heading { get; set; }
    }
}