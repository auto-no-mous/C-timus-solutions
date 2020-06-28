using System;


namespace problem1102
{
    class Program
    {
        enum States
        {
            None,
            O,
            Ou_Out,
            Out_Out,
            P_Put,
            Pu_Put,
            Put_Put,
            On_One,
            O_Fork,
            On_Fork,
            I_In,
            In_In,
            P_Puton,
            Pu_Puton,
            Put_Puton,
            Puto_Puton,
        }
        static bool flag = true;
        static States st = States.None;

        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                flag = true;
                char input;
                st = States.None;
                do 
                {
                    input = (char)Console.In.Read();
                    if (input == '\r')
                        continue;
                    if (flag)
                    {
                        if (!Next(input))
                        {
                            flag = false;
                        }
                    }

                } while (input !='\n');

                if (flag)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
        }
        }

        static bool Next (char c)
        {
            switch (st)
            {
                case States.None:
                    if (c == 'o')
                    {
                        st = States.O;
                    }
                    else if (c == 'p')
                    {
                        st = States.P_Puton;
                    }
                    else if (c == 'i')
                    {
                        st = States.I_In;
                    }
                    else if (c == '\n')
                    {
                        st = States.None;
                    }
                    else return false;
                    return true;

                case States.O:
                    if (c == 'n')
                    {
                        st = States.On_One;
                    }
                    else if (c == 'u')
                    {
                        st = States.Ou_Out;
                    }
                    else return false;
                    return true;

                case States.On_One:
                    if (c == 'e')
                    {
                        st = States.None;
                        return true;
                    }
                    else return false;

                case States.Ou_Out:
                    if (c == 't')
                    {
                        st = States.Out_Out;
                    }
                    else return false;
                    return true;

                case States.Out_Out:
                    if (c == 'p')
                    {
                        st = States.P_Put;
                        return true;
                    }
                    else
                    {
                        st = States.None;
                        return Next(c);
                    }

                case States.P_Put:
                    if (c == 'u')
                    {
                        st = States.Pu_Put;
                    }
                    else return false;
                    return true;

                case States.Pu_Put:
                    if (c == 't')
                    {
                        st = States.Put_Put;
                        return true;
                    }
                    else return false;

                case States.Put_Put:
                    if (c == 'o')
                    {
                        st = States.O_Fork;
                        return true;
                    }
                    else
                    {
                        st = States.None;
                        return Next(c);
                    }

                case States.O_Fork:
                    if (c == 'n')
                    {
                        st = States.On_Fork;
                    }
                    else if (c == 'u')
                    {
                        st = States.Ou_Out;
                    }
                    else return false;
                    return true;

                case States.On_Fork:
                    if (c == 'e')
                    {
                        st = States.None;
                        return true;
                    }
                    else
                    {
                        st = States.None;
                        return Next(c);
                    }

                case States.P_Puton:
                    if (c == 'u')
                    {
                        st = States.Pu_Puton;
                        return true;
                    }
                    else return false;

                case States.Pu_Puton:
                    if (c == 't')
                    {
                        st = States.Put_Puton;
                        return true;
                    }
                    else return false;

                case States.Put_Puton:
                    if (c == 'o')
                    {
                        st = States.Puto_Puton;
                        return true;
                    }
                    else return false;

                case States.Puto_Puton:
                    if (c == 'n')
                    {
                        st = States.None;
                        return true;
                    }
                    else return false;

                case States.I_In:
                    if (c == 'n')
                    {
                        st = States.In_In;
                        return true;
                    }
                    else return false;

                case States.In_In:
                    if (c == 'p')
                    {
                        st = States.P_Put;
                        return true;
                    }
                    else
                    {
                        st = States.None;
                        return Next(c);
                    }
            }
            return false;
        }  
    }
}