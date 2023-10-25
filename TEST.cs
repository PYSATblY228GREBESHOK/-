namespace tortiki
{
    internal class PRAK5TORTY
    {
        static void Main(string[] args)
        {
            List<Menu> Menu = new List<Menu>
            {
                new Menu
                {
                    Name = "  Форма",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  Ромбик",
                            Price = 500
                        },
                        new Menu
                        {
                            Description = "  Зонтик",
                            Price = 500
                        },
                        new Menu
                        {
                            Description = "  Квадрат",
                            Price = 500
                        },
                        new Menu
                        {
                            Description = "  Звезда",
                            Price = 700
                        }
                    }
                },
                new Menu
                {
                    Name = "  Размер",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  Маленький (Диаметр - 16 см, 6 кусков)",
                            Price = 1000
                        },
                        new Menu
                        {
                            Description = "  Большой (Диаметр - 18 см, 10 кусков)",
                            Price = 1200
                        },
                        new Menu
                        {
                            Description = "  Маленький (Диаметр - 26 см, 20 кусков)",
                            Price = 2000
                        }
                    }
                },
                new Menu
                {
                    Name = " Вкус",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  Ваниальный",
                            Price = 100
                        },
                        new Menu
                        {
                            Description = "  Шоколадный",
                            Price = 100
                        },
                        new Menu
                        {
                            Description = "  Карамельный",
                            Price = 150
                        },
                        new Menu
                        {
                            Description = "  Ягодный",
                            Price = 200
                        },
                        new Menu
                        {
                            Description = "  Кокосовый",
                            Price = 250
                        }
                    }
                },
                new Menu
                {
                    Name = "  Количество коржей",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  1 корж",
                            Price = 200
                        },
                        new Menu
                        {
                            Description = "  2 коржа",
                            Price = 400
                        },
                        new Menu
                        {
                            Description = "  3 коржа",
                            Price = 600
                        },
                        new Menu
                        {
                            Description = "  4 коржа",
                            Price = 800
                        },

                    }
                },
                new Menu
                {
                    Name = "  Глазурь",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  Шоколад",
                            Price = 100
                        },
                        new Menu
                        {
                            Description = "  Крем",
                            Price = 100
                        },
                        new Menu
                        {
                            Description = "  Бизе",
                            Price = 15
                        },
                        new Menu
                        {
                            Description = "  Драже",
                            Price = 150
                        },
                        new Menu
                        {
                            Description = "  Ягоды",
                            Price = 200
                        }
                    }
                },
                new Menu
                {
                    Name = "  Декор",
                    Item_list = new List<Menu>{
                        new Menu
                        {
                            Description = "  Шоколадная",
                            Price = 150
                        },
                        new Menu
                        {
                            Description = "  Кремовая",
                            Price = 150
                        },
                        new Menu
                        {
                            Description = "  Ягодная",
                            Price = 150
                        }
                    }
                },
            };
            Menu menu = new Menu();
            menu.Drew_Menu(Menu);
        }
    }
}