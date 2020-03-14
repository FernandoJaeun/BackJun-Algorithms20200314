using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 회의실배정
{
    class Program
    {
        static int [,] SetTeams(int a)
        {//회의시간 설정
            int[,] TeamList = new int[a, 2]; // a= 10
            for (int i = 0; i < a; i++) {
                for (int j = 0; j < 2; j++){
                    TeamList[i, j] = Convert.ToInt32(ReadLine());
                    // WriteLine($"{i}, {j}");
                }
                    WriteLine();}
            return TeamList;
        }
        static void DistributeTeam (int [,] vs)
        {//배열의 길이만큼 최적시간 검사 반복
            int count = 1;
            int temp = vs[0,1];
            for (int i = 0; i < vs.GetLength(0); i++){
                if (vs[i,0] > temp){
                    temp = vs[i, 1];
                    count++;}}
            WriteLine(count);
        }
        static void Main(string[] args)
        {//시작 회의 팀 선언
            int Teams = Convert.ToInt32(ReadLine());
            int [,] TeamList = SetTeams(Teams);
            DistributeTeam(TeamList);
        }
    }
}
