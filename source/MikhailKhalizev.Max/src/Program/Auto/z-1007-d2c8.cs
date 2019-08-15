using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b6c2319-9a4d-41b9-8193-677a7b76ac7c")]
        public void Method_1007_d2c8()
        {
            ii(0x1007_d2c8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_d2cd, 5); calld(Definitions.sys_check_available_stack_size, 0xe_8a80); /* call 0x10165d52 */
            ii(0x1007_d2d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_d2d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d2d4, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d2d5, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d2d6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d2d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d2d9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_d2df, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_d2e2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_d2e5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_d2e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d2eb, 5); calld(0x1007_d252, -0x9e);              /* call 0x1007d252 */
            ii(0x1007_d2f0, 2); test(al, al);                           /* test al, al */
            ii(0x1007_d2f2, 2); if(jnzd(0x1007_d2fa, 0x6)) goto l_0x1007_d2fa; /* jnz 0x1007d2fa */
            ii(0x1007_d2f4, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_d2f8, 2); jmpd(0x1007_d32e, 0x34); goto l_0x1007_d32e; /* jmp 0x1007d32e */
        l_0x1007_d2fa:
            ii(0x1007_d2fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d2fd, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1007_d300, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_d303, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d306, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1007_d309, 5); calld(0x1008_b32c, 0xe01e);             /* call 0x1008b32c */
            ii(0x1007_d30e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_d311, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d314, 5); calld(0x1008_ab1c, 0xd803);             /* call 0x1008ab1c */
            ii(0x1007_d319, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_d31c, 5); calld(0x1015_09a6, 0xd_3685);           /* call 0x101509a6 */
            ii(0x1007_d321, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_d323, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_d326, 4); add(memw_a32[ds, eax + 0x12], dx);      /* add [eax+0x12], dx */
            ii(0x1007_d32a, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1007_d32e:
            ii(0x1007_d32e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_d331, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d333, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d334, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d335, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d336, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d337, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_d338, 1); retd(); return;                         /* ret */
        }
    }
}
