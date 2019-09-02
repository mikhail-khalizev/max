using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_7491-b944facd")]
        public void Method_100a_7491()
        {
            ii(0x100a_7491, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_7496, 5); call(Definitions.sys_check_available_stack_size, 0xb_e8b7); /* call 0x10165d52 */
            ii(0x100a_749b, 1); push(esi);                              /* push esi */
            ii(0x100a_749c, 1); push(edi);                              /* push edi */
            ii(0x100a_749d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_749e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_74a0, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100a_74a6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_74a9, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_74ac, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_74af, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100a_74b2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_74b5, 5); call(0x1013_aaa8, 0x9_35ee);            /* call 0x1013aaa8 */
            ii(0x100a_74ba, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_74bd, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_74c0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_74c3, 5); call(0x100a_ab28, 0x3660);              /* call 0x100aab28 */
            ii(0x100a_74c8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_74cb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_74ce, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x100a_74d1, 5); call(0x100a_aad4, 0x35fe);              /* call 0x100aaad4 */
            ii(0x100a_74d6, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x100a_74d9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_74dc, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_74df, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_74e2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_74e5, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_74e8, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3_0dfd); /* call 0x100766f0 */
            ii(0x100a_74ed, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x100a_74f0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_74f3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_74f6, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_74f9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_74fc, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_74ff, 5); call(Definitions.my_ctor_0x101b_3b58, -0x1_c460); /* call 0x1008b0a4 */
            ii(0x100a_7504, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_7507, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_750a, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_750d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_7510, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7513, 7); mov(memd[ds, eax + 2], 0x101b_4e04);    /* mov dword [eax+0x2], 0x101b4e04 */
            ii(0x100a_751a, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_751d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7520, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_7523, 5); call(0x1007_6630, -0x3_0ef8);           /* call 0x10076630 */
            ii(0x100a_7528, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_752b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_752e, 5); call(0x100a_758a, 0x57);                /* call 0x100a758a */
            ii(0x100a_7533, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_7536, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7539, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_753c, 5); call(0x1008_afe4, -0x1_c55d);           /* call 0x1008afe4 */
            ii(0x100a_7541, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_7544, 4); mov(memb[ds, eax + 0x1e], 0);           /* mov byte [eax+0x1e], 0x0 */
            ii(0x100a_7548, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_754b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100a_754e, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_7551, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7553, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_7554, 1); pop(edi);                               /* pop edi */
            ii(0x100a_7555, 1); pop(esi);                               /* pop esi */
            ii(0x100a_7556, 1); ret();                                  /* ret */
        }
    }
}
