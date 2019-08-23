using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_735d-530559ab")]
        public void Method_100c_735d()
        {
            ii(0x100c_735d, 5); push(0x30);                             /* push 0x30 */
            ii(0x100c_7362, 5); call(Definitions.sys_check_available_stack_size, 0x9_e9eb); /* call 0x10165d52 */
            ii(0x100c_7367, 1); push(ebx);                              /* push ebx */
            ii(0x100c_7368, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7369, 1); push(esi);                              /* push esi */
            ii(0x100c_736a, 1); push(edi);                              /* push edi */
            ii(0x100c_736b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_736c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_736e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_7374, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_7377, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_737a, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_737e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7381, 5); call(0x100c_9fb4, 0x2c2e);              /* call 0x100c9fb4 */
            ii(0x100c_7386, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_7389, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_738d, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7392, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x100c_7397, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_739a, 5); call(0x100c_64f5, -0xeaa);              /* call 0x100c64f5 */
            ii(0x100c_739f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_73a4, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x100c_73a9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_73ac, 5); call(0x100c_64f5, -0xebc);              /* call 0x100c64f5 */
            ii(0x100c_73b1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_73b6, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x100c_73bb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_73be, 5); call(0x100c_64f5, -0xece);              /* call 0x100c64f5 */
            ii(0x100c_73c3, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_73c8, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100c_73cd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_73d0, 5); call(0x100c_64f5, -0xee0);              /* call 0x100c64f5 */
            ii(0x100c_73d5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_73da, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100c_73df, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_73e2, 5); call(0x100c_64f5, -0xef2);              /* call 0x100c64f5 */
            ii(0x100c_73e7, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_73ec, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100c_73f1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_73f4, 5); call(0x100c_64f5, -0xf04);              /* call 0x100c64f5 */
            ii(0x100c_73f9, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100c_73fe, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100c_7403, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7406, 5); call(0x100c_64f5, -0xf16);              /* call 0x100c64f5 */
            ii(0x100c_740b, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100c_7410, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100c_7415, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7418, 5); call(0x100c_64f5, -0xf28);              /* call 0x100c64f5 */
            ii(0x100c_741d, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7422, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x100c_7427, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_742a, 5); call(0x100c_64f5, -0xf3a);              /* call 0x100c64f5 */
            ii(0x100c_742f, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_7434, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x100c_7439, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_743c, 5); call(0x100c_64f5, -0xf4c);              /* call 0x100c64f5 */
            ii(0x100c_7441, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7446, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x100c_744b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_744e, 5); call(0x100c_64f5, -0xf5e);              /* call 0x100c64f5 */
            ii(0x100c_7453, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_7458, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x100c_745d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7460, 5); call(0x100c_64f5, -0xf70);              /* call 0x100c64f5 */
            ii(0x100c_7465, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_746a, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_746f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7472, 5); call(0x100c_64f5, -0xf82);              /* call 0x100c64f5 */
            ii(0x100c_7477, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_747c, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_7481, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7484, 5); call(0x100c_64f5, -0xf94);              /* call 0x100c64f5 */
            ii(0x100c_7489, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_748e, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x100c_7493, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7496, 5); call(0x100c_64f5, -0xfa6);              /* call 0x100c64f5 */
            ii(0x100c_749b, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_74a0, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x100c_74a5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_74a8, 5); call(0x100c_64f5, -0xfb8);              /* call 0x100c64f5 */
            ii(0x100c_74ad, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_74b2, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_74b7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_74ba, 5); call(0x100c_64f5, -0xfca);              /* call 0x100c64f5 */
            ii(0x100c_74bf, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_74c4, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_74c9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_74cc, 5); call(0x100c_64f5, -0xfdc);              /* call 0x100c64f5 */
            ii(0x100c_74d1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_74d6, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x100c_74db, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_74de, 5); call(0x100c_64f5, -0xfee);              /* call 0x100c64f5 */
            ii(0x100c_74e3, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_74e8, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_74ed, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_74f0, 5); call(0x100c_64f5, -0x1000);             /* call 0x100c64f5 */
            ii(0x100c_74f5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_74fa, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_74ff, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7502, 5); call(0x100c_64f5, -0x1012);             /* call 0x100c64f5 */
            ii(0x100c_7507, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_750c, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_7511, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7514, 5); call(0x100c_64f5, -0x1024);             /* call 0x100c64f5 */
            ii(0x100c_7519, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_751e, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_7523, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7526, 5); call(0x100c_64f5, -0x1036);             /* call 0x100c64f5 */
            ii(0x100c_752b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_7530, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100c_7535, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7538, 5); call(0x100c_64f5, -0x1048);             /* call 0x100c64f5 */
            ii(0x100c_753d, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_7542, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100c_7547, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_754a, 5); call(0x100c_64f5, -0x105a);             /* call 0x100c64f5 */
            ii(0x100c_754f, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7554, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100c_7559, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_755c, 5); call(0x100c_64f5, -0x106c);             /* call 0x100c64f5 */
            ii(0x100c_7561, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100c_7566, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100c_756b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_756e, 5); call(0x100c_64f5, -0x107e);             /* call 0x100c64f5 */
            ii(0x100c_7573, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100c_7578, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100c_757d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7580, 5); call(0x100c_64f5, -0x1090);             /* call 0x100c64f5 */
            ii(0x100c_7585, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_758a, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100c_758f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7592, 5); call(0x100c_64f5, -0x10a2);             /* call 0x100c64f5 */
            ii(0x100c_7597, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_759c, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100c_75a1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75a4, 5); call(0x100c_64f5, -0x10b4);             /* call 0x100c64f5 */
            ii(0x100c_75a9, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100c_75ae, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100c_75b3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75b6, 5); call(0x100c_64f5, -0x10c6);             /* call 0x100c64f5 */
            ii(0x100c_75bb, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100c_75c0, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100c_75c5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75c8, 5); call(0x100c_64f5, -0x10d8);             /* call 0x100c64f5 */
            ii(0x100c_75cd, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_75d2, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x100c_75d7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75da, 5); call(0x100c_64f5, -0x10ea);             /* call 0x100c64f5 */
            ii(0x100c_75df, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_75e4, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100c_75e9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75ec, 5); call(0x100c_64f5, -0x10fc);             /* call 0x100c64f5 */
            ii(0x100c_75f1, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100c_75f6, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100c_75fb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_75fe, 5); call(0x100c_64f5, -0x110e);             /* call 0x100c64f5 */
            ii(0x100c_7603, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7608, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100c_760d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7610, 5); call(0x100c_64f5, -0x1120);             /* call 0x100c64f5 */
            ii(0x100c_7615, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100c_761a, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100c_761f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7622, 5); call(0x100c_64f5, -0x1132);             /* call 0x100c64f5 */
            ii(0x100c_7627, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_762c, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x100c_7631, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7634, 5); call(0x100c_64f5, -0x1144);             /* call 0x100c64f5 */
            ii(0x100c_7639, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_763e, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_7643, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7646, 5); call(0x100c_64f5, -0x1156);             /* call 0x100c64f5 */
            ii(0x100c_764b, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_7650, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_7655, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7658, 5); call(0x100c_64f5, -0x1168);             /* call 0x100c64f5 */
            ii(0x100c_765d, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_7662, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x100c_7667, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_766a, 5); call(0x100c_64f5, -0x117a);             /* call 0x100c64f5 */
            ii(0x100c_766f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_7674, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_7679, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_767c, 5); call(0x100c_64f5, -0x118c);             /* call 0x100c64f5 */
            ii(0x100c_7681, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_7686, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_768b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_768e, 5); call(0x100c_64f5, -0x119e);             /* call 0x100c64f5 */
            ii(0x100c_7693, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_7698, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_769d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76a0, 5); call(0x100c_64f5, -0x11b0);             /* call 0x100c64f5 */
            ii(0x100c_76a5, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_76aa, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_76af, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76b2, 5); call(0x100c_64f5, -0x11c2);             /* call 0x100c64f5 */
            ii(0x100c_76b7, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_76bc, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_76c1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76c4, 5); call(0x100c_64f5, -0x11d4);             /* call 0x100c64f5 */
            ii(0x100c_76c9, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_76ce, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_76d3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76d6, 5); call(0x100c_64f5, -0x11e6);             /* call 0x100c64f5 */
            ii(0x100c_76db, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_76e0, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_76e5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76e8, 5); call(0x100c_64f5, -0x11f8);             /* call 0x100c64f5 */
            ii(0x100c_76ed, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_76f2, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_76f7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_76fa, 5); call(0x100c_64f5, -0x120a);             /* call 0x100c64f5 */
            ii(0x100c_76ff, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x100c_7704, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_7709, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_770c, 5); call(0x100c_64f5, -0x121c);             /* call 0x100c64f5 */
            ii(0x100c_7711, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100c_7716, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x100c_771b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_771e, 5); call(0x100c_64f5, -0x122e);             /* call 0x100c64f5 */
            ii(0x100c_7723, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_7728, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_772d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7730, 5); call(0x100c_64f5, -0x1240);             /* call 0x100c64f5 */
            ii(0x100c_7735, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_773a, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_773f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7742, 5); call(0x100c_64f5, -0x1252);             /* call 0x100c64f5 */
            ii(0x100c_7747, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_774c, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_7751, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7754, 5); call(0x100c_64f5, -0x1264);             /* call 0x100c64f5 */
            ii(0x100c_7759, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_775e, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_7763, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7766, 5); call(0x100c_64f5, -0x1276);             /* call 0x100c64f5 */
            ii(0x100c_776b, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_7770, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_7775, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7778, 5); call(0x100c_64f5, -0x1288);             /* call 0x100c64f5 */
            ii(0x100c_777d, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_7782, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_7787, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_778a, 5); call(0x100c_64f5, -0x129a);             /* call 0x100c64f5 */
            ii(0x100c_778f, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_7794, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_7799, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_779c, 5); call(0x100c_64f5, -0x12ac);             /* call 0x100c64f5 */
            ii(0x100c_77a1, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_77a6, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_77ab, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_77ae, 5); call(0x100c_64f5, -0x12be);             /* call 0x100c64f5 */
            ii(0x100c_77b3, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_77b8, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x100c_77bd, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_77c0, 5); call(0x100c_64f5, -0x12d0);             /* call 0x100c64f5 */
            ii(0x100c_77c5, 5); call(0x100c_aef4, 0x372a);              /* call 0x100caef4 */
            ii(0x100c_77ca, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_77cc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_77ce, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_77d1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_77d4, 5); call(0x100c_ae64, 0x368b);              /* call 0x100cae64 */
            ii(0x100c_77d9, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100c_77dc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_77de, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_77e0, 5); call(0x100c_7177, -0x66e);              /* call 0x100c7177 */
            ii(0x100c_77e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_77e7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_77ea, 5); call(0x100c_a6a0, 0x2eb1);              /* call 0x100ca6a0 */
            ii(0x100c_77ef, 5); call(0x100c_aef4, 0x3700);              /* call 0x100caef4 */
            ii(0x100c_77f4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_77f6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_77f8, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_77fb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_77fe, 5); call(0x100c_ae64, 0x3661);              /* call 0x100cae64 */
            ii(0x100c_7803, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7805, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_7808, 5); call(0x100c_a6a0, 0x2e93);              /* call 0x100ca6a0 */
            ii(0x100c_780d, 2); jmp(0x100c_7819, 0xa); goto l_0x100c_7819; /* jmp 0x100c7819 */
        //  ii(0x100c_780f, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_7811, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //  ii(0x100c_7814, 5); call(0x100c_a6a0, 0x2e87);              /* call 0x100ca6a0 */
        l_0x100c_7819:
            ii(0x100c_7819, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_781c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_781e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_781f, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7820, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7821, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7822, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_7823, 1); ret();                                  /* ret */
        }
    }
}
