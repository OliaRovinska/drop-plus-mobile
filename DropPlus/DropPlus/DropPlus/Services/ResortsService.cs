﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AutoMapper;
using DropPlus.Enums;
using DropPlus.Models;
using DropPlus.ViewModels;
using Xamarin.Forms;

namespace DropPlus.Services
{
    public static class ResortsService
    {
        private static List<ResortModel> Resorts { get; set; }
        private static ResortsFilterViewModel Filter { get; set; }

        static ResortsService()
        {
            Resorts = new List<ResortModel>()
            {
                new ResortModel()
                {
                    Id = 0,
                    Image = "beregovo.jpeg",
                    Location = "Берегове",
                    IsSponsored = true, 
                    Description = "Берегове термальні води — популярний туристичний напрямок. Екскурсії в Берегове, основний центр угорської культури, знайдуться в арсеналі будь-якої туристичної агенції.  В Берегове на термальні води приїжджають відпочити, провести вихідні, оздоровитись. Термальні басейни Берегове є чудовою нагодою сумістити відпочинок в Карпатах та лікування.Що можна відвідати та побачити в Берегове:• термальні басейни Закарпаття та Жайворонок, СПА центр, термальні басейни сусіднього комплексу “Термальні води Косино”;• архітектура та колорит справжнього угорського містечка в Україні;• дегустаційні зали та винні підвали;• кав'ярні та ресторани з традиційною угорською кухнею та запашною кавою.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("серцево-судинна система"),
                        DiseasesService.Get("хвороби шкіри")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 1,
                    Image = "tryckavetch.jpg",
                    Location = "Трускавець",
                    Description = "Тисячі людей з усієї України і ближніх країн щороку приїжджають на відпочинок та оздоровлення в Трускавець - курорт, який по праву заслуговує на звання здравниці Прикарпаття. І відвідавши одного разу Трускавець, ви самі зможете переконатися в тому, скільки можливостей подарує вам курорт.Трускавець - це найкращий привід знайти в нескінченному списку справ трохи часу для себе, і чудово відпочити на лоні природи, відновлюючи життєві сили, красу і енергію.Передгірне чисте повітря, цілюща вода природних джерел, Трускавець - Життя прекрасне! Немає ніякої необхідності їхати кудись далеко, щоб відпочити і отримати нові враження - все це подарує вам відпочинок у Трускавці.Наші санаторії і комфортабельні вілли розташовані в самих мальовничих місцях, де сама природа подбає про те, щоб ви насолодилися її цілющими властивостями. У медичних центрах досвідчені лікарі курортологи, підберуть вам індивідуальну програму оздоровлення та лікування. До послуг гостей різні категорії номерів, які розраховані як на відокремлений відпочинок та оздоровлення, так і на відпочинок всією сім'єю.А безліч екскурсійних програм (українські Карпати, гора Говерла, озеро Синевир, Почаїв, Львів) дозволить зробити свій відпочинок не тільки корисним, а й цікавим.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("цукровий діабет"),
                        DiseasesService.Get("ожиріння")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 2,
                    Image = "shydnetsya.jpg",
                    Location = "Східниця",
                    IsSponsored = true,
                    Description = "Мінеральний курорт Східниця розкинувся неподалік Дрогобичу, у розлогій долині на березі ріки Східничанка. Хоча старовинне селище знаходиться у мальовничому куточку Карпат, туристів сюди приваблюють не чарівні краєвиди і не буремна історія краю. Сюди їдуть на лікування мінеральними водами – чисельні санаторії та пансіонати пропонують не лише туристичні, але й медичні послуги.Східниця має в своєму розпорядженні ціле родовище мінеральних вод, яке налічує не більш не менш як 38 джерел. Хімічний вміст води у цих джерелах різний, тому курорт приймає гостей, які страждають будь-якими хворобами, що піддаються лікуванню мінеральними водами. Тут можна покуштувати воду 4 типів. Перший — з підвищеним вмістом органічних речовин, завдяки чому має сечогінну дію. Другий — з вираженим жовчогінним ефектом. Третій тип мінеральної води — залізиста слабомінералізована, четвертий — хлоридно-натрієва. Крім того, в Східниці є джерело типу славнозвісної “Боржомі”: це гідрокарбонатно-натрієва вода, надзвичайно корисна для обміну речовин та роботи органів травлення. В якості показань до лікування в санаторіях Східниці можна розглядати хвороби нирок так сечовивідних шляхів, розлади травлення, аномалії обмінних процесів.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("цукровий діабет"),
                        DiseasesService.Get("астма")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 3,
                    Image = "Morshyn.jpg",
                    Location = "Моршин",
                    Description = "Моршин - маленьке, але затишне містечко, що приймає щороку сотні тисяч гостей, які шукають відпочинку і способу поправити здоров'я. Тут приголомшливі гірські види, ліси, цілюще повітря, приємний клімат та атмосфера умиротворення. Відпочинок і лікування в Моршині - це те, що шукають сотні туристів. Оздоровчі процедури проходять в кількох напрямках:Мінеральна вода:№1 - для хворих, які страждають важкими формами недуг шлунково-кишкового тракту. Так само ця вода покращує загальний стан, виводить токсини, має сечогінну дію;№4 - (звична столова вода «Моршинська») відповідає за систему виділення;№6 - нормалізує обмін речовин, роботу нервової системи, зміцнює імунітет, усуває запальні процеси.Торф'яні грязі - застосовуються для аплікацій, різних ванн, тампонів, електрогрязевих процедур;Озокерит - вид теплотерапії, знімає біль, запалення, нормалізує патологічні зміни тканин, покращує кровообіг, обмін речовин.Для маленьких гостей існують оздоровчі заходи, що спрямовані на зміцнення імунітету, пам'яті, правильний розвиток.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("варикоз"),
                        DiseasesService.Get("ожиріння")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 4,
                    Image = "myrgorod.jpg",
                    Location = "Миргородкурорт",
                    Description = "Сьогодні «Миргородкурорт» за всіми показниками є лідером санаторно-курортної сфери нашої держави. Всі його оздоровниці мають вищий рівень акредитації. Зручне розташування і транспортне сполучення дозволяє дістатися сюди від провідних промислових центрів країни всього за 2-3 години. А висока ефективність оздоровлення на курорті «Миргород» добре відома не тільки в Україні, а й далеко за її межами і приваблює сюди протягом усього року більше 30 тисяч відпочиваючих майже з 30 країн світу.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("хронічні хвороби шлунку"),
                        DiseasesService.Get("хронічні хвороби печінки"),
                        DiseasesService.Get("хронічні хвороби підшлункової залози")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 5,
                    Image = "shayan.jpg",
                    Location = "Шаян",
                    Description = "Завдяки цілющим джерелам маленьке село Шаян перетворилося в знаменитий курорт, куди приїжджають тисячі іноземців. Місцевий пейзаж по праву оцінять навіть ті, хто вже мали честь побувати в Угорщині, Італії та Чехії. Тут прекрасний клімат, чисте гірське повітря, а також можливість відпочити, споглядаючи плавнe течію річки Тиси. Найближчі заводи або фабрики за сотні кілометрів від цього мальовничого куточка Карпат.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("астма"),
                        DiseasesService.Get("бронхіт")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 6,
                    Image = "kosyvo.jpg",
                    Location = "Косино",
                    Description = "«Косино» – це сучасний оздоровчо-рекреаційний комплекс для всієї родини, розташований серед 200-річного дубового гаю мальовничої Берегівщини.Відчуйте ефект цілющих властивостей підземних вод у семи різних басейнах з термальними та прісними водами, відпочиньте з повноцінним комфортом у одному з номерів термал-готелю «Iváncsó Birtok», насолодіться традиційними стравами угорської, української та італійської національних кухонь у ресторані «Чарда». Також до Ваших послуг унікальні Королівські сауни, ванни Кнайпа, масажний кабінет, тренажерний комплекс та ще багато цікавого.Адже відпочинок в «Косино» – найкращий варіант поєднання приємного з корисним!",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("хвороби шкіри"),
                        DiseasesService.Get("варикоз")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 7,
                    Image = "polyana.jpg",
                    Location = "Поляна",
                    Description = "Поляна - невелике, дуже мальовниче і затишне курортне селище, розташоване в карпатській долині, оточеній гірськими шпилями і реліктовими лісами. Знаходиться вона неподалік районного центру Свалява (в 10 кілометрах). Щороку курорт Поляна приймає величезна кількість українських та іноземних туристів, охочих доторкнутися до первозданної природи і оздоровитися.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("органи травлення")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 8,
                    Image = "kvasy.jpg",
                    Location = "Кваси",
                    IsSponsored = true,
                    Description = "Санаторій Гірська Тиса славиться своєю незвичайною миш'яковистою мінеральною водою - «Гірськотисянського». Завдяки її складом і властивостями лікуються захворювання опорно-рухового апарату, патології периферичної нервової системи, а також ендокринної системи людини. Унікальні властивості цієї води полягають у збільшенні ефективності обміну речовин в організмі і виведенні продуктів обміну, шлаків, солей і радіонуклідів. Санаторій Гірська Тиса розташований в селі Кваси, біля підніжжя гірських масивів: Чорногірського і Свидовець, самому лісистому і гірському районі Закарпатської області - Рахівському.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("серцево-судинна система"),
                        DiseasesService.Get("ожиріння")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 9,
                    Image = "synak.jpg",
                    Location = "Синяк",
                    Description = "Найвідоміший санаторій «Укрпрофоздоровниці» і єдиний комплекс на Закарпатті, в якому збереглася сірководнева мінеральна вода. Санаторій Синяк розташовується недалеко від селища Чинадієво Закарпатської області. Поблизу здравниці знаходиться гора Синяк, на честь цієї гори і названий санаторій, також тут струїть свої води річка Синявка. Назва гори, річки та санаторію пов'язані з кольором мінеральної сірководневої води, яка і є головним лікувальним фактором курорту. Санаторій Синяк - відмінне місце для того, щоб оздоровити свій організм, відпочити, подихати чистим гірським повітрям, познайомитися з історією цього регіону і подивитися зачаровану і мальовничу природу Карпат.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("серцево-судинна система"),
                        DiseasesService.Get("захворювання суглобів")
                    },
                    IsSanatorium = true,
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 10,
                    Image = "hmilnik.jpg",
                    Location = "Хмільник",
                    Description = "Курорт Хмільник – це справжня перлина туристичної Вінничини. Здається, сама природа посприяла утворенню курортної зони в цьому місці – комфортний клімат, густі ліси і найбільше багатство – унікальна мінеральна вода, яка містить у своєму багатокомпонентному складі радон, калій, радій, азот, марганець, залізо, бром, натрій, йод, кобальт. Вміст мінеральних солей у одному літрі хмільницької води становить 5,3 г. Як запевняють науковці, хімічний склад цієї води дуже подібний до знаменитої грузинської Цхалтубо та російської Білокурихи.",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("серцево-судинна система"),
                        DiseasesService.Get("захворювання суглобів")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5, 
                            Text = "Прохання до адміністрації вирішити проблему з ліфтом.Багато людей приїзджає вночі.І дуже складно серед ночі(коли ліфт відключений) тягнути чемодани на 3-4 поверхи(8 корпус).",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 3,
                            Text = "Років 5-6 лікуюся в Хмільнику профсоюзному.Мене 'поставили на ноги' в прямому значенні.Обожнюю цей санаторій.Дуже люблю Юрія Юрієвича (витяжка).Весь персонал доброзичливий.Територія охайна.Все дуже класно.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                },
                new ResortModel()
                {
                    Id = 11,
                    Image = "Solotvyno.jpeg",
                    Location = "Солотвино",
                    IsSponsored = true,
                    Description = "Солотвино це лікувально – оздоровчий курорт. З 1968 тут практикують лікування астми та інших захворювань дихальних шляхів в спеціальних палатах, розташованих на глибині понад 200м. В 1976 р. було побудувано Українську республіканську алергологічну лікарню, яка успішно працює до тепер. Щорічно влітку до Солотвино приїзджає багато туристів, щоб полежати в солених озерах, куди ропа(насичена солями вода) потрапляє безпосередньо з шахти. Саме полежати, тому що вода саме виштовхує тіло на поверхню, що створює ефект невагомості. Солені озера Солотвино містять лікувальну ропу та сульфідну грязь. Навколо озер розташовані пляжі, кафе, бази відпочинку",
                    Seasons = new List<SeasonEnum>() {SeasonEnum.Autumn, SeasonEnum.Winter, SeasonEnum.Summer, SeasonEnum.Spring},
                    Diseases = new List<DiseaseModel>()
                    {
                        DiseasesService.Get("цукровий діабет"),
                        DiseasesService.Get("ожиріння")
                    },
                    Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Rating = 5,
                            Text = "Нам дуже подобається тут відпочивати. Персонал привітний, уважний, кваліфікований. Кухня як завжди на висоті! Процедури всі виконують висококваліфіковані працівники.",
                            User = UsersService.Get("olia@gmail.com")
                        },
                        new ReviewModel()
                        {
                            Rating = 4,
                            Text = "Кожний рік зустрічаю Новий рік в санаторії.Мені дуже подобається там як лікування так і відпочинок.Дуже вдячна всьому медичному персоналу за чуйність і уважність, привітність до пацієнтів.",
                            User = UsersService.Get("melnyk@gmail.com")
                        }
                    }
                }
            };
        }

        public static List<ResortModel> GetAll()
        {
            return Resorts;
        }

        public static List<ResortModel> GetSponsored()
        {
            return Resorts.Where(resort => resort.IsSponsored).ToList();
        }

        public static ResortModel Get(int id)
        {
            return Resorts.First(resort => resort.Id == id);
        }

        public static ResortsFilterViewModel GetFilter()
        {
            return Filter;
        }

        public static List<ResortModel> GetRecommended(FindTourViewModel model)
        {
            IEnumerable<ResortModel> result = Resorts;
            var checkedDiseases = Mapper.Map<List<DiseaseModel>>(model.Organs.Where(disease => disease.IsChecked));
            if (checkedDiseases.Any())
            {
                result = result.Where(resort => resort.Diseases.Select(disease => disease.Name).Intersect(checkedDiseases.Select(disease => disease.Name)).Any());
            }

            if (model.IsDateImportant)
            {
                if (model.StartDate.Month == 11 || model.StartDate.Month == 0 || model.StartDate.Month == 1)
                {
                    result = result.Where(resort => resort.Seasons.Contains(SeasonEnum.Winter));
                } else if (model.StartDate.Month == 2 || model.StartDate.Month == 3 || model.StartDate.Month == 4)
                {
                    result = result.Where(resort => resort.Seasons.Contains(SeasonEnum.Spring));
                } else if (model.StartDate.Month == 5 || model.StartDate.Month == 6 || model.StartDate.Month == 7)
                {
                    result = result.Where(resort => resort.Seasons.Contains(SeasonEnum.Summer));
                } else if (model.StartDate.Month == 8 || model.StartDate.Month == 9 || model.StartDate.Month == 10)
                {
                    result = result.Where(resort => resort.Seasons.Contains(SeasonEnum.Autumn));
                }
            }

            return result.ToList();
        }

        public static void SetFilter(ResortsFilterViewModel filter)
        {
            Filter = filter;
        }

        public static List<ResortModel> ApplyFilter()
        {
            var result = Resorts.Where(resort => resort.Rating >= Filter.MinRating && resort.Rating <= Filter.MaxRating);
            if (!string.IsNullOrEmpty(Filter.Location))
            {
                result = result.Where(resort => resort.Location == Filter.Location);
            }

            var diseases = Mapper.Map<List<DiseaseModel>>(Filter.Diseases.Where(disease => disease.IsChecked));
            if (diseases.Any())
            {
                result = result.Where(resort => resort.Diseases.Select(disease => disease.Name).Intersect(diseases.Select(disease => disease.Name)).Any());
            }

            if (Filter.IsSanatorium)
            {
                result = result.Where(resort => resort.IsSanatorium);
            }

            if (Filter.Season != SeasonEnum.Any)
            {
                result = result.Where(resort => resort.Seasons.Contains(Filter.Season));
            }

            return result.ToList();
        }
    }
}