using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SQLNewCar.MVVM.Models;
public class Car
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
}