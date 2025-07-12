// See https://aka.ms/new-console-template for more information
using EFCoreDemo.Data;
using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var context = new BlogContext();

var articles = context.Articles
                        .Include(a => a.Author)
                        .Include(a => a.Category)
                        .ToList();

foreach (var article in articles)
{
    Console.WriteLine($"Title: {article.Title}, Content: {article.Content}, " +
        $"Category: {article.Category?.Name}, Author: {article.Author?.Name}");
}

var author = context.Authors
                        .Include(a => a.Articles)
                        .Where(a => a.Id == 1)
                        .ToList();

Console.WriteLine("Article added successfully!");
