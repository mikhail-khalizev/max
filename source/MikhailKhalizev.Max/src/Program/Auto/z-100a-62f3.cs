using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_62f3-47c9351f")]
        public void Method_100a_62f3()
        {
            ii(0x100a_62f3, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_62f8, 5); call(Definitions.sys_check_available_stack_size, 0xb_fa55); /* call 0x10165d52 */
            ii(0x100a_62fd, 1); push(ebx);                              /* push ebx */
            ii(0x100a_62fe, 1); push(ecx);                              /* push ecx */
            ii(0x100a_62ff, 1); push(edx);                              /* push edx */
            ii(0x100a_6300, 1); push(esi);                              /* push esi */
            ii(0x100a_6301, 1); push(edi);                              /* push edi */
            ii(0x100a_6302, 1); push(ebp);                              /* push ebp */
            ii(0x100a_6303, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6305, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_630b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_630e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6310, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_6313, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6316, 5); call(0x1013_ad71, 0x9_4a56);            /* call 0x1013ad71 */
            ii(0x100a_631b, 2); test(al, al);                           /* test al, al */
            ii(0x100a_631d, 2); if(jz(0x100a_633e, 0x1f)) goto l_0x100a_633e; /* jz 0x100a633e */
            ii(0x100a_631f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_6322, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6325, 5); call(0x1008_af28, -0x1_b402);           /* call 0x1008af28 */
            ii(0x100a_632a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_632d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_6330, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_6333, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_6336, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100a_6339, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_633c, 2); jmp(0x100a_6345, 0x7); goto l_0x100a_6345; /* jmp 0x100a6345 */
        l_0x100a_633e:
            ii(0x100a_633e, 7); mov(memd[ss, ebp - 0x8], 0x2900);       /* mov dword [ebp-0x8], 0x2900 */
        l_0x100a_6345:
            ii(0x100a_6345, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6348, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_634a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_634b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_634c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_634d, 1); pop(edx);                               /* pop edx */
            ii(0x100a_634e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_634f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_6350, 1); ret();                                  /* ret */
        }
    }
}
