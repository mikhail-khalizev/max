using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b0d3-82c91be3")]
        public void Method_1011_b0d3()
        {
            ii(0x1011_b0d3, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_b0d8, 5); call(Definitions.sys_check_available_stack_size, 0x4_ac75); /* call 0x10165d52 */
            ii(0x1011_b0dd, 1); push(ebx);                              /* push ebx */
            ii(0x1011_b0de, 1); push(ecx);                              /* push ecx */
            ii(0x1011_b0df, 1); push(esi);                              /* push esi */
            ii(0x1011_b0e0, 1); push(edi);                              /* push edi */
            ii(0x1011_b0e1, 1); push(ebp);                              /* push ebp */
            ii(0x1011_b0e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b0e4, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_b0ea, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_b0ed, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_b0f0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_b0f3, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1011_b0f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_b0f9, 5); call(0x1013_bb7b, 0x2_0a7d);            /* call 0x1013bb7b */
            ii(0x1011_b0fe, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_b101, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1011_b104, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_b107, 5); call(0x1013_bb7b, 0x2_0a6f);            /* call 0x1013bb7b */
            ii(0x1011_b10c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_b10f, 3); add(edx, 0x16);                         /* add edx, 0x16 */
            ii(0x1011_b112, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_b115, 5); call(0x1013_bb7b, 0x2_0a61);            /* call 0x1013bb7b */
            ii(0x1011_b11a, 3); lea(edx, memd[ss, ebp - 0xc]);          /* lea edx, [ebp-0xc] */
            ii(0x1011_b11d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_b120, 5); call(0x1013_bb7b, 0x2_0a56);            /* call 0x1013bb7b */
            ii(0x1011_b125, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_b128, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b12b, 5); call(0x1012_0b8c, 0x5a5c);              /* call 0x10120b8c */
        l_0x1011_b130:
            ii(0x1011_b130, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1011_b133, 5); cmp(memw[ss, ebp - 0xc], -1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1011_b138, 2); if(jz(0x1011_b15a, 0x20)) goto l_0x1011_b15a; /* jz 0x1011b15a */
            ii(0x1011_b13a, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1011_b13f, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_b142, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_b145, 5); call(0x1013_ba86, 0x2_093c);            /* call 0x1013ba86 */
            ii(0x1011_b14a, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_b14d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_b150, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b153, 5); call(0x1012_0b08, 0x59b0);              /* call 0x10120b08 */
            ii(0x1011_b158, 2); jmp(0x1011_b130, -0x2a); goto l_0x1011_b130; /* jmp 0x1011b130 */
        l_0x1011_b15a:
            ii(0x1011_b15a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b15c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_b15d, 1); pop(edi);                               /* pop edi */
            ii(0x1011_b15e, 1); pop(esi);                               /* pop esi */
            ii(0x1011_b15f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_b160, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_b161, 1); ret();                                  /* ret */
        }
    }
}
