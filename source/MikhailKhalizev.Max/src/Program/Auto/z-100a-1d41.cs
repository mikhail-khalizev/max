using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_1d41-ca11eb96")]
        public void Method_100a_1d41()
        {
            ii(0x100a_1d41, 5); pushd(0x158);                           /* push 0x158 */
            ii(0x100a_1d46, 5); calld(Definitions.sys_check_available_stack_size, 0xc_4007); /* call 0x10165d52 */
            ii(0x100a_1d4b, 1); pushd(esi);                             /* push esi */
            ii(0x100a_1d4c, 1); pushd(edi);                             /* push edi */
            ii(0x100a_1d4d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_1d4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1d50, 6); sub(esp, 0x13c);                        /* sub esp, 0x13c */
            ii(0x100a_1d56, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_1d59, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_1d5c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_1d5f, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100a_1d62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1d65, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100a_1d69, 2); if(jged(0x100a_1d93, 0x28)) goto l_0x100a_1d93; /* jge 0x100a1d93 */
            ii(0x100a_1d6b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_1d6f, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1d70, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_1d73, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1d74, 6); lea(eax, ebp - 0x13c);                  /* lea eax, [ebp-0x13c] */
            ii(0x100a_1d7a, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1d7b, 5); calld(Definitions.sys_sprintf, 0xc_4181); /* call 0x10165f01 */
            ii(0x100a_1d80, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100a_1d83, 6); lea(edx, ebp - 0x13c);                  /* lea edx, [ebp-0x13c] */
            ii(0x100a_1d89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_1d8c, 5); calld(Definitions.sys_strcat, 0xc_41a0); /* call 0x10165f31 */
            ii(0x100a_1d91, 2); jmpd(0x100a_1dc2, 0x2f); goto l_0x100a_1dc2; /* jmp 0x100a1dc2 */
        l_0x100a_1d93:
            ii(0x100a_1d93, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1d96, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100a_1d9a, 2); if(jled(0x100a_1dc2, 0x26)) goto l_0x100a_1dc2; /* jle 0x100a1dc2 */
            ii(0x100a_1d9c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100a_1da0, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1da1, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100a_1da4, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1da5, 6); lea(eax, ebp - 0x13c);                  /* lea eax, [ebp-0x13c] */
            ii(0x100a_1dab, 1); pushd(eax);                             /* push eax */
            ii(0x100a_1dac, 5); calld(Definitions.sys_sprintf, 0xc_4150); /* call 0x10165f01 */
            ii(0x100a_1db1, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100a_1db4, 6); lea(edx, ebp - 0x13c);                  /* lea edx, [ebp-0x13c] */
            ii(0x100a_1dba, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_1dbd, 5); calld(Definitions.sys_strcat, 0xc_416f); /* call 0x10165f31 */
        l_0x100a_1dc2:
            ii(0x100a_1dc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1dc4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_1dc5, 1); popd(edi);                              /* pop edi */
            ii(0x100a_1dc6, 1); popd(esi);                              /* pop esi */
            ii(0x100a_1dc7, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
