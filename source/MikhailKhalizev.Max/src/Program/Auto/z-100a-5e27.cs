using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5e27-1ef9669c")]
        public void Method_100a_5e27()
        {
            ii(0x100a_5e27, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_5e2c, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ff21); /* call 0x10165d52 */
            ii(0x100a_5e31, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5e32, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5e33, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5e34, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5e35, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5e36, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5e38, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_5e3e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_5e41, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_5e44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_5e47, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_5e4a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_5e4d, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_5e50, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_5e53, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100a_5e56, 2); cmp(al, 0x19);                          /* cmp al, 0x19 */
            ii(0x100a_5e58, 2); if(jnzd(0x100a_5e68, 0xe)) goto l_0x100a_5e68; /* jnz 0x100a5e68 */
            ii(0x100a_5e5a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_5e5d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5e60, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_5e63, 5); calld(0x100a_b044, 0x51dc);             /* call 0x100ab044 */
        l_0x100a_5e68:
            ii(0x100a_5e68, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_5e6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5e6e, 5); calld(0x1009_ca08, -0x946b);            /* call 0x1009ca08 */
            ii(0x100a_5e73, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5e75, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_5e76, 1); popd(edi);                              /* pop edi */
            ii(0x100a_5e77, 1); popd(esi);                              /* pop esi */
            ii(0x100a_5e78, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_5e79, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_5e7a, 1); retd(); return;                         /* ret */
        }
    }
}
