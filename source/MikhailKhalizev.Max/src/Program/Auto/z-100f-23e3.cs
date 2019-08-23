using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_23e3-ff3c4c71")]
        public void Method_100f_23e3()
        {
            ii(0x100f_23e3, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100f_23e8, 5); call(Definitions.sys_check_available_stack_size, 0x7_3965); /* call 0x10165d52 */
            ii(0x100f_23ed, 1); push(ebx);                              /* push ebx */
            ii(0x100f_23ee, 1); push(ecx);                              /* push ecx */
            ii(0x100f_23ef, 1); push(edx);                              /* push edx */
            ii(0x100f_23f0, 1); push(esi);                              /* push esi */
            ii(0x100f_23f1, 1); push(edi);                              /* push edi */
            ii(0x100f_23f2, 1); push(ebp);                              /* push ebp */
            ii(0x100f_23f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_23f5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_23fb, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_23fe, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_2402, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_2405, 5); call(Definitions.my_string_ctor, 0x4_f6de); /* call 0x10141ae8 */
            ii(0x100f_240a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_240d, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_2411, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2414, 3); mov(al, memb[ds, eax + 0x58]);          /* mov al, [eax+0x58] */
            ii(0x100f_2417, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_241c, 1); push(eax);                              /* push eax */
            ii(0x100f_241d, 5); mov(eax, StringDefinitions.TurnsToRepairUnitI); /* mov eax, 0x101a23b5 */
            ii(0x100f_2422, 1); push(eax);                              /* push eax */
            ii(0x100f_2423, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_2428, 1); push(eax);                              /* push eax */
            ii(0x100f_2429, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_242c, 1); push(eax);                              /* push eax */
            ii(0x100f_242d, 5); call(0x1014_2037, 0x4_fc05);            /* call 0x10142037 */
            ii(0x100f_2432, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_2435, 5); call(0x100c_aa00, -0x2_7a3a);           /* call 0x100caa00 */
            ii(0x100f_243a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_243f, 1); push(eax);                              /* push eax */
            ii(0x100f_2440, 5); call(0x100c_aa20, -0x2_7a25);           /* call 0x100caa20 */
            ii(0x100f_2445, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_2447, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_2449, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_244b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_244e, 5); call(Definitions.my_strobj_c_str_v2, -0x6_8c8b); /* call 0x100897c8 */
            ii(0x100f_2453, 5); call(0x1011_5d23, 0x2_38cb);            /* call 0x10115d23 */
            ii(0x100f_2458, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_245a, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100f_245d, 5); call(Definitions.my_string_dtor, 0x4_f6c8); /* call 0x10141b2a */
            ii(0x100f_2462, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_2464, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_2465, 1); pop(edi);                               /* pop edi */
            ii(0x100f_2466, 1); pop(esi);                               /* pop esi */
            ii(0x100f_2467, 1); pop(edx);                               /* pop edx */
            ii(0x100f_2468, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_2469, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_246a, 1); ret();                                  /* ret */
        }
    }
}
