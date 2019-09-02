using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_125d-fb1cb4e0")]
        public void Method_100a_125d()
        {
            ii(0x100a_125d, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_1262, 5); call(Definitions.sys_check_available_stack_size, 0xc_4aeb); /* call 0x10165d52 */
            ii(0x100a_1267, 1); push(ebx);                              /* push ebx */
            ii(0x100a_1268, 1); push(ecx);                              /* push ecx */
            ii(0x100a_1269, 1); push(esi);                              /* push esi */
            ii(0x100a_126a, 1); push(edi);                              /* push edi */
            ii(0x100a_126b, 1); push(ebp);                              /* push ebp */
            ii(0x100a_126c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_126e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_1274, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_1277, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_127a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_127d, 5); call(0x1007_6204, -0x2_b07e);           /* call 0x10076204 */
            ii(0x100a_1282, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100a_1285, 3); add(ebx, 2);                            /* add ebx, 0x2 */
            ii(0x100a_1288, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_128a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_128c, 5); call(0x1007_6e00, -0x2_a491);           /* call 0x10076e00 */
            ii(0x100a_1291, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1293, 2); if(jz(0x100a_12a8, 0x13)) goto l_0x100a_12a8; /* jz 0x100a12a8 */
            ii(0x100a_1295, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1298, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_129b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_129e, 5); call(0x1007_1ff5, -0x2_f2ae);           /* call 0x10071ff5 */
            ii(0x100a_12a3, 1); cwde();                                 /* cwde */
            ii(0x100a_12a4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_12a6, 2); if(jl(0x100a_12aa, 2)) goto l_0x100a_12aa; /* jl 0x100a12aa */
        l_0x100a_12a8:
            ii(0x100a_12a8, 2); jmp(0x100a_12b3, 9); goto l_0x100a_12b3; /* jmp 0x100a12b3 */
        l_0x100a_12aa:
            ii(0x100a_12aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_12ad, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_12b1, 2); if(jnz(0x100a_12b5, 2)) goto l_0x100a_12b5; /* jnz 0x100a12b5 */
        l_0x100a_12b3:
            ii(0x100a_12b3, 2); jmp(0x100a_12be, 9); goto l_0x100a_12be; /* jmp 0x100a12be */
        l_0x100a_12b5:
            ii(0x100a_12b5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_12b8, 4); cmp(memb[ds, eax + 0x3d], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_12bc, 2); if(jnz(0x100a_12c0, 2)) goto l_0x100a_12c0; /* jnz 0x100a12c0 */
        l_0x100a_12be:
            ii(0x100a_12be, 2); jmp(0x100a_12c9, 9); goto l_0x100a_12c9; /* jmp 0x100a12c9 */
        l_0x100a_12c0:
            ii(0x100a_12c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_12c3, 4); cmp(memb[ds, eax + 0x3e], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x100a_12c7, 2); if(jnz(0x100a_12cb, 2)) goto l_0x100a_12cb; /* jnz 0x100a12cb */
        l_0x100a_12c9:
            ii(0x100a_12c9, 2); jmp(0x100a_12e8, 0x1d); goto l_0x100a_12e8; /* jmp 0x100a12e8 */
        l_0x100a_12cb:
            ii(0x100a_12cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_12ce, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_12d1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_12d4, 5); call(0x1007_1f2e, -0x2_f3ab);           /* call 0x10071f2e */
            ii(0x100a_12d9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_12dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_12df, 5); call(0x100a_11c4, -0x120);              /* call 0x100a11c4 */
            ii(0x100a_12e4, 2); test(al, al);                           /* test al, al */
            ii(0x100a_12e6, 2); if(jnz(0x100a_12ea, 2)) goto l_0x100a_12ea; /* jnz 0x100a12ea */
        l_0x100a_12e8:
            ii(0x100a_12e8, 2); jmp(0x100a_1339, 0x4f); goto l_0x100a_1339; /* jmp 0x100a1339 */
        l_0x100a_12ea:
            ii(0x100a_12ea, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_12ed, 3); mov(eax, memd[ds, edx + 6]);            /* mov eax, [edx+0x6] */
            ii(0x100a_12f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_12f3, 5); call(0x1007_1ff5, -0x2_f303);           /* call 0x10071ff5 */
            ii(0x100a_12f8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_12fb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_12fe, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_1301, 4); sub(memw[ds, edx + 0x32], ax);          /* sub [edx+0x32], ax */
            ii(0x100a_1305, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_1308, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_130b, 4); sub(memw[ds, edx + 0x26], ax);          /* sub [edx+0x26], ax */
            ii(0x100a_130f, 5); mov(eax, StringDefinitions.Workers2);   /* mov eax, 0x101a0946 */
            ii(0x100a_1314, 1); push(eax);                              /* push eax */
            ii(0x100a_1315, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOn2); /* mov ecx, 0x101a094e */
            ii(0x100a_131a, 5); mov(ebx, StringDefinitions.CannotTurnSOffOtherBuildingsNeedS2); /* mov ebx, 0x101a096d */
            ii(0x100a_131f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_1322, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_1325, 5); call(0x100a_0f77, -0x3b3);              /* call 0x100a0f77 */
            ii(0x100a_132a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_132c, 5); mov(edx, 7);                            /* mov edx, 0x7 */
            ii(0x100a_1331, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1334, 5); call(0x1016_3053, 0xc_1d1a);            /* call 0x10163053 */
        l_0x100a_1339:
            ii(0x100a_1339, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_133b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_133c, 1); pop(edi);                               /* pop edi */
            ii(0x100a_133d, 1); pop(esi);                               /* pop esi */
            ii(0x100a_133e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_133f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_1340, 1); ret();                                  /* ret */
        }
    }
}
