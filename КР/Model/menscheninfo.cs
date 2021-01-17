using System;
using System.Collections.Generic;
using System.Text;

namespace КР.Model
{
    public class menscheninfo
    {
        public List<interfacemenschen> arbeiter = new List<interfacemenschen>();
        public menscheninfo()
        {
            interfacemenschen SMF = new arbeiter("Сидоров ", "Михаил ", "Федорович ", "Главный цех ", "Рабочий");
            interfacemenschen SSV = new arbeiter("Смирнов ", "Сергей ", "Владимирович ", "Главный цех ", "Рабочий");
            interfacemenschen PLM = new arbeiter("Петров ", "Леонид ", "Михайлович ", "Главный цех ", "Рабочий");
            interfacemenschen MVP = new arbeiter("Морозов ", "Владимир ", "Петрович ", "Главный цех ", "Рабочий");

            interfacemenschen AEG = new arbeiter("Антонова ", "Елизавета ", "Григорьевна ", "Офис ", "Секретарь");
            interfacemenschen MSV = new arbeiter("Малюткин ", "Сергей ", "Викторович ", "Офис ", "Главный бухгалтер");
            interfacemenschen GSS = new arbeiter("Галкина ", "Светлана ", "Сергеевна ", "Офис ", "Помощник бухгалтера");
            interfacemenschen VVE = new arbeiter("Ветров ", "Владимир ", "Евгеньевич ", "Офис ", "Директор");

            interfacemenschen VEF = new arbeiter("Волкова ", "Екатерина ", "Федоровна ", "Главный цех ", "Уборщица");
            interfacemenschen SKP = new arbeiter("Суханова ", "Кристина ", "Петровна ", "Офис ", "Уборщица");
            interfacemenschen PAM = new arbeiter("Пирогов ", "Андрей ", "Михайлович ", "Столовая ", "Повар");
            interfacemenschen PEA = new arbeiter("Панов ", "Евгений ", "Алексеевич ", "Столовая ", "Посудомойщик");

            arbeiter.Add(SMF);
            arbeiter.Add(SSV);
            arbeiter.Add(PLM);
            arbeiter.Add(MVP);
            arbeiter.Add(AEG);
            arbeiter.Add(MSV);
            arbeiter.Add(GSS);
            arbeiter.Add(VVE);
            arbeiter.Add(VEF);
            arbeiter.Add(SKP);
            arbeiter.Add(PAM);
            arbeiter.Add(PEA);
        }
    }
}