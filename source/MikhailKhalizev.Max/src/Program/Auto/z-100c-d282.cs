using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d282-e3b73b9e")]
        public void Method_100c_d282()
        {
            ii(0x100c_d282, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_d287, 5); call(Definitions.sys_check_available_stack_size, 0x9_8ac6); /* call 0x10165d52 */
            ii(0x100c_d28c, 1); push(ebx);                              /* push ebx */
            ii(0x100c_d28d, 1); push(ecx);                              /* push ecx */
            ii(0x100c_d28e, 1); push(edx);                              /* push edx */
            ii(0x100c_d28f, 1); push(esi);                              /* push esi */
            ii(0x100c_d290, 1); push(edi);                              /* push edi */
            ii(0x100c_d291, 1); push(ebp);                              /* push ebp */
            ii(0x100c_d292, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d294, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d29a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_d29d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_d2a0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d2a3, 5); call(0x1007_6574, -0x5_6d34);           /* call 0x10076574 */
            ii(0x100c_d2a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d2aa, 3); mov(dl, memb[ds, eax + 0x54]);          /* mov dl, [eax+0x54] */
            ii(0x100c_d2ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_d2b0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d2b3, 5); call(0x1007_6574, -0x5_6d44);           /* call 0x10076574 */
            ii(0x100c_d2b8, 5); call(0x1007_623c, -0x5_7081);           /* call 0x1007623c */
            ii(0x100c_d2bd, 3); mov(eax, memd[ds, eax + 0x19]);         /* mov eax, [eax+0x19] */
            ii(0x100c_d2c0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d2c3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_d2c5, 2); if(jnz(0x100c_d2cd, 6)) goto l_0x100c_d2cd; /* jnz 0x100cd2cd */
            ii(0x100c_d2c7, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_d2cb, 2); jmp(0x100c_d2d1, 4); goto l_0x100c_d2d1; /* jmp 0x100cd2d1 */
        l_0x100c_d2cd:
            ii(0x100c_d2cd, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100c_d2d1:
            ii(0x100c_d2d1, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_d2d4, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100c_d2d7, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100c_d2da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d2dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_d2dd, 1); pop(edi);                               /* pop edi */
            ii(0x100c_d2de, 1); pop(esi);                               /* pop esi */
            ii(0x100c_d2df, 1); pop(edx);                               /* pop edx */
            ii(0x100c_d2e0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_d2e1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_d2e2, 1); ret();                                  /* ret */
        }
    }
}
