using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_074e-f2c98903")]
        public void Method_100b_074e()
        {
            ii(0x100b_074e, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100b_0753, 5); call(Definitions.sys_check_available_stack_size, 0xb_55fa); /* call 0x10165d52 */
            ii(0x100b_0758, 1); push(ecx);                              /* push ecx */
            ii(0x100b_0759, 1); push(esi);                              /* push esi */
            ii(0x100b_075a, 1); push(edi);                              /* push edi */
            ii(0x100b_075b, 1); push(ebp);                              /* push ebp */
            ii(0x100b_075c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_075e, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_0764, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_0767, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_076a, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_076d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0770, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_0773, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100b_0776, 3); mov(edx, memd[ds, edx + 0x2]);          /* mov edx, [edx+0x2] */
            ii(0x100b_0779, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_077c, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100b_077f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100b_0782, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_0784, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0787, 5); call(0x1008_ad90, -0x2_59fc);           /* call 0x1008ad90 */
            ii(0x100b_078c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_078f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0792, 5); call(0x100a_26d1, -0xe0c6);             /* call 0x100a26d1 */
            ii(0x100b_0797, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_079a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_079d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_07a0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_07a3, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_07a6, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3_a0bb); /* call 0x100766f0 */
            ii(0x100b_07ab, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x100b_07ae, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_07b1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_07b4, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_07b7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_07ba, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_07bd, 5); call(0x100b_7cbc, 0x74fa);              /* call 0x100b7cbc */
            ii(0x100b_07c2, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_07c5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_07c8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_07cb, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_07ce, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_07d1, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_07d4, 5); call(0x1008_a634, -0x2_61a5);           /* call 0x1008a634 */
            ii(0x100b_07d9, 3); sub(eax, 0x23);                         /* sub eax, 0x23 */
            ii(0x100b_07dc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_07df, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_07e2, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_07e5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_07e8, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_07eb, 5); call(0x1008_a958, -0x2_5e98);           /* call 0x1008a958 */
            ii(0x100b_07f0, 3); sub(eax, 0x27);                         /* sub eax, 0x27 */
            ii(0x100b_07f3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_07f6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_07f9, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_07fc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_07ff, 7); mov(memd[ds, eax + 0x2], 0x101b_53b4);  /* mov dword [eax+0x2], 0x101b53b4 */
            ii(0x100b_0806, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0809, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_080c, 4); mov(memw[ds, edx + 0x13], ax);          /* mov [edx+0x13], ax */
            ii(0x100b_0810, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_0813, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0816, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0819, 5); call(0x100b_7cfc, 0x74de);              /* call 0x100b7cfc */
            ii(0x100b_081e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_0821, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0824, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_0827, 5); call(0x100b_7c14, 0x73e8);              /* call 0x100b7c14 */
            ii(0x100b_082c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_082f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0832, 5); call(0x100b_7d68, 0x7531);              /* call 0x100b7d68 */
            ii(0x100b_0837, 5); call(0x1015_2783, 0xa_1f47);            /* call 0x10152783 */
            ii(0x100b_083c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_083f, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100b_0842, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100b_0845, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0847, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0848, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0849, 1); pop(esi);                               /* pop esi */
            ii(0x100b_084a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_084b, 1); ret();                                  /* ret */
        }
    }
}
