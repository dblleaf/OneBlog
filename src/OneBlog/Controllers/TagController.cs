﻿using Microsoft.AspNetCore.Mvc;
using One.Data;
using One.Data.Contracts;

namespace One.Controllers
{
  [Route("[controller]")]
  public class TagController : Controller
  {
    private IPostsRepository _repo;
    readonly int _pageSize = 25;

    public TagController(IPostsRepository repo)
    {
      _repo = repo;
    }

    [HttpGet("{tag}")]
    public IActionResult Index(string tag)
    {
      return Pager(tag, 1);
    }

    [HttpGet("{tag}/{page}")]
    public IActionResult Pager(string tag, int page)
    {
      return View("Index", _repo.GetPostsByTag(tag, _pageSize, page));
    }
  }
}