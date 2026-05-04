using System;
using System.Windows;

	public partial class MainShow : Window {
		[STAThread]
		public static void Main() {
			Application app = new Application();
			app.Run(new MainShow());
		}
		public MainShow() {
			DateTime date = DateTime.Now;
			string day;

			// Массивы сообщений. num - числитель, denom - знаменатель. Дни недели от 0 - воскресенье до 4 - четверг.
			string[] num = new string[5];
			num[0] = "физика будет.\n\nА перед ней дифуры две пары.";
			num[1] = "два матана и физвос.";
			num[2] = "матан,\nдва СППО\nи ЭВМ.";
			num[3] = "философия только лекция.\n\nПеред ней будет теория вероятности\nи физвос.";
			num[4] = "к первой.\n\nБудет английский,\nСтрелков\nи теория вероятности.";

			string[] denom = new string[5];
			denom[0] = "физики не будет.\n\nБудут дифуры две пары\nи матан.";
			denom[1] = num[1];
			denom[2] = num[2];
			denom[3] = "философия лекция и практика\n\nПеред ней будет теория вероятности\nи физвос.";
			denom[4] = "ко второй.\n\nБудет Стрелков,\nанглийский\nи теория вероятности.";

			// Если сейчас позже 12 часов - показываем расписание на завтра. Иначе - на сегодня.
			if (date.TimeOfDay.Hours > 12)
				day = "Завтра ";
			else {
				day = "Сегодня ";
				date = date.AddDays(-1);
			}

			// Говнокодерский свитч на все дни. Просто использовать дни недели не позволяет чередование числитель/знаменатель.
			if (date.Month == 4 && date.Year == 2011)	// апрель
				switch (date.Day) {
					case 7:
					case 21:
						Resources.Add("Name", day + denom[4]);
						break;
					case 14:
					case 28:
						Resources.Add("Name", day + num[4]);
						break;
					case 10:
					case 24:
						Resources.Add("Name", day + num[0]);
						break;
					case 17:
						Resources.Add("Name", day + denom[0]);
						break;
					case 11:
					case 25:
						Resources.Add("Name", day + num[1]);
						break;
					case 18:
						Resources.Add("Name", day + denom[1] + "\n\nАхтунг! Колок!");
						break;
					case 12:
					case 26:
						Resources.Add("Name", day + num[2]);
						break;
					case 19:
						Resources.Add("Name", day + denom[2]);
						break;
					case 13:
					case 27:
						Resources.Add("Name", day + num[3]);
						break;
					case 20:
						Resources.Add("Name", day + denom[3]);
						break;
					default:
						Resources.Add("Name", day + "наверно и пар-то нет.");
						break;
				}
			else
				if (date.Month == 5 && date.Year == 2011)	// Май
					switch (date.Day) {
						case 5:
						case 19:
							Resources.Add("Name", day + denom[4]);
							break;
						case 12:
						case 26:
							Resources.Add("Name", day + num[4]);
							break;
						case 22:
						case 8:
							Resources.Add("Name", day + num[0]);
							break;
						case 1:
						case 15:
						case 29:
							Resources.Add("Name", day + denom[0]);
							break;
						case 9:
						case 23:
							Resources.Add("Name", day + num[1]);
							break;
						case 2:
						case 16:
						case 30:
							Resources.Add("Name", day + denom[1]);
							break;
						case 10:
						case 24:
							Resources.Add("Name", day + num[2]);
							break;
						case 3:
						case 17:
							Resources.Add("Name", day + denom[2]);
							break;
						case 11:
						case 25:
							Resources.Add("Name", day + num[3]);
							break;
						case 4:
						case 18:
							Resources.Add("Name", day + denom[3]);
							break;
						default:
							Resources.Add("Name", day + "наверно и пар-то нет.");
							break;
				}
				else
					Resources.Add("Name", "База данных исчерпана.\nОбращайтесь на новой версией к разработчику.");

			InitializeComponent();
		}
	}