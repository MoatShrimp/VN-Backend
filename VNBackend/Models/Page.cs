using System.ComponentModel.DataAnnotations;

namespace VNBackend.Models;

class Page
{
  [Key]
  public int id { get; init; }
  public required string Name { get; init; }
  public required string Title { get; init; }
  public required string Text { get; init; }
}