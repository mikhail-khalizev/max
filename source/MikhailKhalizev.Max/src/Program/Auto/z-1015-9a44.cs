using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9a44-1e12f71b")]
        public void Method_1015_9a44()
        {
            ii(0x1015_9a44, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_9a49, 5); call(Definitions.sys_check_available_stack_size, 0xc304); /* call 0x10165d52 */
            ii(0x1015_9a4e, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9a4f, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9a50, 1); push(esi);                              /* push esi */
            ii(0x1015_9a51, 1); push(edi);                              /* push edi */
            ii(0x1015_9a52, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9a53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9a55, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1015_9a5b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_9a5e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_9a61, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9a64, 4); cmp(memb[ds, eax + 0x3d], 8);           /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9a68, 2); if(jnz(0x1015_9a86, 0x1c)) goto l_0x1015_9a86; /* jnz 0x10159a86 */
            ii(0x1015_9a6a, 5); mov(eax, 0x1015_9680);                  /* mov eax, 0x10159680 */
            ii(0x1015_9a6f, 1); push(eax);                              /* push eax */
            ii(0x1015_9a70, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1015_9a75, 5); mov(ebx, StringDefinitions.Start3);     /* mov ebx, 0x101b2657 */
            ii(0x1015_9a7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9a7c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9a7f, 5); call(0x1015_7ccf, -0x1db5);             /* call 0x10157ccf */
            ii(0x1015_9a84, 2); jmp(0x1015_9aa0, 0x1a); goto l_0x1015_9aa0; /* jmp 0x10159aa0 */
        l_0x1015_9a86:
            ii(0x1015_9a86, 5); mov(eax, 0x1015_9712);                  /* mov eax, 0x10159712 */
            ii(0x1015_9a8b, 1); push(eax);                              /* push eax */
            ii(0x1015_9a8c, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_9a91, 5); mov(ebx, StringDefinitions.Stop5);      /* mov ebx, 0x101b265d */
            ii(0x1015_9a96, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9a98, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9a9b, 5); call(0x1015_7ccf, -0x1dd1);             /* call 0x10157ccf */
        l_0x1015_9aa0:
            ii(0x1015_9aa0, 5); mov(eax, 0x1015_99cc);                  /* mov eax, 0x101599cc */
            ii(0x1015_9aa5, 1); push(eax);                              /* push eax */
            ii(0x1015_9aa6, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_9aab, 5); mov(ebx, StringDefinitions.BuyUpg);     /* mov ebx, 0x101b2662 */
            ii(0x1015_9ab0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9ab2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9ab5, 5); call(0x1015_7ccf, -0x1deb);             /* call 0x10157ccf */
            ii(0x1015_9aba, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_9abd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9ac0, 5); call(0x1015_8bbb, -0xf0a);              /* call 0x10158bbb */
            ii(0x1015_9ac5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9ac7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9ac8, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9ac9, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9aca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9acb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9acc, 1); ret();                                  /* ret */
        }
    }
}
