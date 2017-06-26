﻿using Omise.Models;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Omise.Examples.Examples
{
    public class Links : Example
    {
        public async Task List_List()
        {
            var links = await Client.Links.GetList(order: Ordering.ReverseChronological);
            Console.WriteLine($"total links: {links.Total}");
        }

        public async Task Create_Create()
        {
            var link = await Client.Links.Create(new CreateLinkRequest
            {
                Amount = 2000,
                Currency = "thb",
                Title = "that shirt.",
                Description = "that shirt.",
            });

            Console.WriteLine($"payment link: {link.PaymentURI}");
        }

        public async Task Retrieve_Retrieve()
        {
            var link = await Client.Links.Get("link_test_56bkhnfd97h7eieu0hx");
            Console.WriteLine($"link paid?: {link.Used} {link.Charges.FirstOrDefault()?.Id})");
        }
    }
}