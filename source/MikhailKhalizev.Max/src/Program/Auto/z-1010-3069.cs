using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3069-457e37c5")]
        public void Method_1010_3069()
        {
            ii(0x1010_3069, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_306e, 5); call(Definitions.sys_check_available_stack_size, 0x6_2cdf); /* call 0x10165d52 */
            ii(0x1010_3073, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3074, 1); push(esi);                              /* push esi */
            ii(0x1010_3075, 1); push(edi);                              /* push edi */
            ii(0x1010_3076, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3077, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3079, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_307f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_3082, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1010_3085, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1010_3088, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_308b, 5); call(0x1013_aaa8, 0x3_7a18);            /* call 0x1013aaa8 */
            ii(0x1010_3090, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_3093, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1010_3096, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_3099, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_309c, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1010_309f, 5); call(Definitions.my_ctor_0x101b_56fc, -0x7_a428); /* call 0x10088c7c */
            ii(0x1010_30a4, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1010_30a7, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_30aa, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1010_30ad, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1010_30b0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_30b3, 7); mov(memd[ds, eax + 2], 0x101b_6428);    /* mov dword [eax+0x2], 0x101b6428 */
            ii(0x1010_30ba, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_30bd, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_30c0, 4); mov(memw[ds, edx + 16], ax);            /* mov [edx+0x10], ax */
            ii(0x1010_30c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_30c7, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_30ca, 4); mov(memw[ds, edx + 18], ax);            /* mov [edx+0x12], ax */
            ii(0x1010_30ce, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_30d1, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_30d4, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1010_30d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_30d9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_30da, 1); pop(edi);                               /* pop edi */
            ii(0x1010_30db, 1); pop(esi);                               /* pop esi */
            ii(0x1010_30dc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_30dd, 1); ret();                                  /* ret */
        }
    }
}
