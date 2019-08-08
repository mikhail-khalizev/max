using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("371062d0-a464-4b5e-aa67-b8ecedcab543")]
        public void Method_1013_d2c4()
        {
            ii(0x1013_d2c4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_d2c9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_8a84); /* call 0x10165d52 */
            ii(0x1013_d2ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_d2cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_d2d0, 1); pushd(esi);                             /* push esi */
            ii(0x1013_d2d1, 1); pushd(edi);                             /* push edi */
            ii(0x1013_d2d2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_d2d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d2d5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_d2db, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_d2de, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_d2e1, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_d2e5, 2); if(jzd(0x1013_d2ff, 0x18)) goto l_0x1013_d2ff; /* jz 0x1013d2ff */
            ii(0x1013_d2e7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d2ea, 4); mov(dx, memw_a32[ds, eax + 0xc]);       /* mov dx, [eax+0xc] */
            ii(0x1013_d2ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d2f1, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1013_d2f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d2f8, 5); calld(0x1013_d111, -0x1ec);             /* call 0x1013d111 */
            ii(0x1013_d2fd, 2); jmpd(0x1013_d31b, 0x1c); goto l_0x1013_d31b; /* jmp 0x1013d31b */
        l_0x1013_d2ff:
            ii(0x1013_d2ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d302, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_d304, 6); mov(bl, memb_a32[ds, eax + 0xdc9]);     /* mov bl, [eax+0xdc9] */
            ii(0x1013_d30a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d30d, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x1013_d310, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_d313, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_d316, 5); calld(0x1013_cf8e, -0x38d);             /* call 0x1013cf8e */
        l_0x1013_d31b:
            ii(0x1013_d31b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d31d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_d31e, 1); popd(edi);                              /* pop edi */
            ii(0x1013_d31f, 1); popd(esi);                              /* pop esi */
            ii(0x1013_d320, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_d321, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_d322, 1); retd(); return;                         /* ret */
        }
    }
}
