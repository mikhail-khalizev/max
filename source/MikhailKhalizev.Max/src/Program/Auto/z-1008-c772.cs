using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_c772-c8a09394")]
        public void Method_1008_c772()
        {
            ii(0x1008_c772, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1008_c777, 5); call(Definitions.sys_check_available_stack_size, 0xd_95d6); /* call 0x10165d52 */
            ii(0x1008_c77c, 1); push(esi);                              /* push esi */
            ii(0x1008_c77d, 1); push(edi);                              /* push edi */
            ii(0x1008_c77e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_c77f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c781, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_c787, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c78a, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1008_c78d, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1008_c790, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1008_c793, 4); movsx(ecx, memw[ss, ebp - 0x8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x1008_c797, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x1008_c79a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_c79d, 5); call(0x1008_ad90, -0x1a12);             /* call 0x1008ad90 */
            ii(0x1008_c7a2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_c7a5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c7a8, 5); call(0x100a_26d1, 0x1_5f24);            /* call 0x100a26d1 */
            ii(0x1008_c7ad, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c7b0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_c7b3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_c7b6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c7b9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c7bc, 5); call(Definitions.my_ctor_0x101b_38f8, -0x1_60d1); /* call 0x100766f0 */
            ii(0x1008_c7c1, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x1008_c7c4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_c7c7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_c7ca, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_c7cd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c7d0, 7); mov(memd[ds, eax + 0x2], 0x101b_46f4);  /* mov dword [eax+0x2], 0x101b46f4 */
            ii(0x1008_c7d7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_c7da, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1008_c7dd, 4); mov(memw[ds, edx + 0x13], ax);          /* mov [edx+0x13], ax */
            ii(0x1008_c7e1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_c7e4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_c7e7, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_c7ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c7ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_c7ed, 1); pop(edi);                               /* pop edi */
            ii(0x1008_c7ee, 1); pop(esi);                               /* pop esi */
            ii(0x1008_c7ef, 1); ret();                                  /* ret */
        }
    }
}
