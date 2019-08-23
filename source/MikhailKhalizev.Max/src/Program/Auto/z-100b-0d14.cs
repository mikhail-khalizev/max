using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0d14-c7c2590")]
        public void Method_100b_0d14()
        {
            ii(0x100b_0d14, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100b_0d19, 5); call(Definitions.sys_check_available_stack_size, 0xb_5034); /* call 0x10165d52 */
            ii(0x100b_0d1e, 1); push(ebx);                              /* push ebx */
            ii(0x100b_0d1f, 1); push(ecx);                              /* push ecx */
            ii(0x100b_0d20, 1); push(esi);                              /* push esi */
            ii(0x100b_0d21, 1); push(edi);                              /* push edi */
            ii(0x100b_0d22, 1); push(ebp);                              /* push ebp */
            ii(0x100b_0d23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0d25, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_0d2b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_0d2e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_0d31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0d33, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0d36, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0d39, 5); call(0x1013_ad71, 0x8_a033);            /* call 0x1013ad71 */
            ii(0x100b_0d3e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0d40, 2); if(jz(0x100b_0d8a, 0x48)) goto l_0x100b_0d8a; /* jz 0x100b0d8a */
            ii(0x100b_0d42, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0d45, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0d48, 5); call(0x1007_6574, -0x3_a7d9);           /* call 0x10076574 */
            ii(0x100b_0d4d, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100b_0d50, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_0d53, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0d56, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100b_0d58, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0d5b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0d5e, 5); call(0x1007_6574, -0x3_a7ef);           /* call 0x10076574 */
            ii(0x100b_0d63, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x100b_0d66, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_0d69, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0d6c, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x100b_0d6f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0d72, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_0d74, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0d75, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0d78, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x100b_0d7b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0d7e, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100b_0d81, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0d82, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0d85, 3); mov(memd[ds, edx + 0xc], eax);          /* mov [edx+0xc], eax */
            ii(0x100b_0d88, 2); jmp(0x100b_0ded, 0x63); goto l_0x100b_0ded; /* jmp 0x100b0ded */
        l_0x100b_0d8a:
            ii(0x100b_0d8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0d8c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0d8f, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0d92, 5); call(0x1013_ad71, 0x8_9fda);            /* call 0x1013ad71 */
            ii(0x100b_0d97, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0d99, 2); if(jz(0x100b_0ded, 0x52)) goto l_0x100b_0ded; /* jz 0x100b0ded */
            ii(0x100b_0d9b, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100b_0d9e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0da1, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0da4, 5); call(0x1008_a520, -0x2_6889);           /* call 0x1008a520 */
            ii(0x100b_0da9, 5); call(0x100a_ca34, -0x437a);             /* call 0x100aca34 */
            ii(0x100b_0dae, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100b_0db1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0db4, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x100b_0db6, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100b_0db9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0dbc, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0dbf, 5); call(0x1008_a520, -0x2_68a4);           /* call 0x1008a520 */
            ii(0x100b_0dc4, 5); call(0x100a_ca34, -0x4395);             /* call 0x100aca34 */
            ii(0x100b_0dc9, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100b_0dcb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_0dce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0dd1, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x100b_0dd4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0dd7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_0dd9, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0dda, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0ddd, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x100b_0de0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0de3, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100b_0de6, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0de7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0dea, 3); mov(memd[ds, edx + 0xc], eax);          /* mov [edx+0xc], eax */
        l_0x100b_0ded:
            ii(0x100b_0ded, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0df0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_0df3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0df6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0df8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0df9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0dfa, 1); pop(esi);                               /* pop esi */
            ii(0x100b_0dfb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_0dfc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_0dfd, 1); ret();                                  /* ret */
        }
    }
}
