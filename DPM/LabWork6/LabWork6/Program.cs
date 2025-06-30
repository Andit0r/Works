using System.Diagnostics;

Patient patient1 = new Patient();
Patient patient2 = new Patient("Данилов Даня Данилович", 881400, 2018);

Debug.Assert((int)patient1["policyNumber"] == 200001);
Debug.Assert(patient2[3] == 'и');
Debug.Assert(Methods.Exponentiation(3) == 9);
Debug.Assert(Methods.Exponentiation(4, 3) == 64);
Debug.Assert(Methods.GetPerimeter(4, 2) == 12);
Debug.Assert(Methods.GetPerimeter(4) == 16);
Debug.Assert(Methods.Exponentiation(4, 2) == 33);
