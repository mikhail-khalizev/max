using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3d10-7c3392f6")]
        public void Method_100f_3d10()
        {
            ii(0x100f_3d10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3d13, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_3d16, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_3d19, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_3d1c, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x100f_3d22, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3d25, 4); cmp(memb_a32[ds, eax + 0x4d], 0);       /* cmp byte [eax+0x4d], 0x0 */
            ii(0x100f_3d29, 2); if(jzd(0x100f_3d37, 0xc)) goto l_0x100f_3d37; /* jz 0x100f3d37 */
            ii(0x100f_3d2b, 10); mov(memd_a32[ss, ebp - 0x150], StringDefinitions.SUnderAttack); /* mov dword [ebp-0x150], 0x101a2484 */
            ii(0x100f_3d35, 2); jmpd(0x100f_3d41, 0xa); goto l_0x100f_3d41; /* jmp 0x100f3d41 */
        l_0x100f_3d37:
            ii(0x100f_3d37, 10); mov(memd_a32[ss, ebp - 0x150], StringDefinitions.SHasBeenDestroyed); /* mov dword [ebp-0x150], 0x101a2495 */
        l_0x100f_3d41:
            ii(0x100f_3d41, 6); pushd(memd_a32[ss, ebp - 0x150]);       /* push dword [ebp-0x150] */
            ii(0x100f_3d47, 6); lea(eax, ebp - 0x148);                  /* lea eax, [ebp-0x148] */
            ii(0x100f_3d4d, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3d4e, 5); calld(Definitions.sys_sprintf, 0x7_21ae); /* call 0x10165f01 */
            ii(0x100f_3d53, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_3d56, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3d59, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100f_3d5c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3d61, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_3d63, 2); if(jnzd(0x100f_3d91, 0x2c)) goto l_0x100f_3d91; /* jnz 0x100f3d91 */
            ii(0x100f_3d65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3d68, 5); calld(0x1010_1103, 0xd396);             /* call 0x10101103 */
            ii(0x100f_3d6d, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100f_3d70, 2); if(jnzd(0x100f_3d8f, 0x1d)) goto l_0x100f_3d8f; /* jnz 0x100f3d8f */
            ii(0x100f_3d72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3d74, 5); mov(eax, 0x101c_38b4);                  /* mov eax, 0x101c38b4 */
            ii(0x100f_3d79, 5); calld(0x1007_6630, -0x7_d74e);          /* call 0x10076630 */
            ii(0x100f_3d7e, 7); mov(memd_a32[ss, ebp - 0x10], 0x402);   /* mov dword [ebp-0x10], 0x402 */
            ii(0x100f_3d85, 10); mov(memd_a32[ss, ebp - 0x14c], 0x405); /* mov dword [ebp-0x14c], 0x405 */
        l_0x100f_3d8f:
            ii(0x100f_3d8f, 2); jmpd(0x100f_3daf, 0x1e); goto l_0x100f_3daf; /* jmp 0x100f3daf */
        l_0x100f_3d91:
            ii(0x100f_3d91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_3d94, 5); calld(0x1010_1103, 0xd36a);             /* call 0x10101103 */
            ii(0x100f_3d99, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100f_3d9c, 2); if(jnzd(0x100f_3daf, 0x11)) goto l_0x100f_3daf; /* jnz 0x100f3daf */
            ii(0x100f_3d9e, 7); mov(memd_a32[ss, ebp - 0x10], 0x3f6);   /* mov dword [ebp-0x10], 0x3f6 */
            ii(0x100f_3da5, 10); mov(memd_a32[ss, ebp - 0x14c], 0x401); /* mov dword [ebp-0x14c], 0x401 */
        l_0x100f_3daf:
            ii(0x100f_3daf, 5); if(jmpd_func(0x100f_3ee4, 0x130)) return; /* jmp 0x100f3ee4 */
        }
    }
}
