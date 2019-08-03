using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d84af2e-4571-4169-b09b-a66ab5340b17")]
        public void Method_1010_f23d()
        {
            ii(0x1010_f23d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_f242, 5); calld(Definitions.sys_check_available_stack_size, 0x56b0b); /* call 0x10165d52 */
            ii(0x1010_f247, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f248, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f249, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f24a, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f24b, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f24c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f24d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f24f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_f255, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f258, 7); mov(memd_a32[ss, ebp - 0x8], 0xa);      /* mov dword [ebp-0x8], 0xa */
        l_0x1010_f25f:
            ii(0x1010_f25f, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_f262, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_f267, 2); if(jzd(0x1010_f2c6, 0x5d)) goto l_0x1010_f2c6; /* jz 0x1010f2c6 */
            ii(0x1010_f269, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f26d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f270, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f273, 7); cmp(memd_a32[ds, eax + 0x1d9], 0);      /* cmp dword [eax+0x1d9], 0x0 */
            ii(0x1010_f27a, 2); if(jzd(0x1010_f2c4, 0x48)) goto l_0x1010_f2c4; /* jz 0x1010f2c4 */
            ii(0x1010_f27c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f280, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f283, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f286, 6); mov(eax, memd_a32[ds, eax + 0x1d9]);    /* mov eax, [eax+0x1d9] */
            ii(0x1010_f28c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_f28f, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_f293, 2); if(jzd(0x1010_f2a9, 0x14)) goto l_0x1010_f2a9; /* jz 0x1010f2a9 */
            ii(0x1010_f295, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f297, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_f29a, 5); calld(Definitions.my_dtor_d2, -0x40d67); /* call 0x100ce538 */
            ii(0x1010_f29f, 5); calld(Definitions.sys_delete, 0x56cc0); /* call 0x10165f64 */
            ii(0x1010_f2a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_f2a7, 2); jmpd(0x1010_f2b0, 0x7); goto l_0x1010_f2b0; /* jmp 0x1010f2b0 */
        l_0x1010_f2a9:
            ii(0x1010_f2a9, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_f2b0:
            ii(0x1010_f2b0, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_f2b4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_f2b7, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_f2ba, 10); mov(memd_a32[ds, eax + 0x1d9], 0);     /* mov dword [eax+0x1d9], 0x0 */
        l_0x1010_f2c4:
            ii(0x1010_f2c4, 2); jmpd(0x1010_f25f, -0x67); goto l_0x1010_f25f; /* jmp 0x1010f25f */
        l_0x1010_f2c6:
            ii(0x1010_f2c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f2c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f2c9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f2ca, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f2cb, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f2cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f2cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f2ce, 1); retd(); return;                         /* ret */
        }
    }
}
