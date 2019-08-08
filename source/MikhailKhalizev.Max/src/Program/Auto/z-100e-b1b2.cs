using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a596988-b3cc-42fe-bc30-5ca1a1779c9c")]
        public void Method_100e_b1b2()
        {
            ii(0x100e_b1b2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b1b7, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ab96); /* call 0x10165d52 */
            ii(0x100e_b1bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b1bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b1be, 1); pushd(edx);                             /* push edx */
            ii(0x100e_b1bf, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b1c0, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b1c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b1c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b1c4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_b1ca, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_b1cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1d0, 4); cmp(memb_a32[ds, eax + 0x1a], 0);       /* cmp byte [eax+0x1a], 0x0 */
            ii(0x100e_b1d4, 2); if(jnzd(0x100e_b1e3, 0xd)) goto l_0x100e_b1e3; /* jnz 0x100eb1e3 */
            ii(0x100e_b1d6, 5); calld(0x1014_82f4, 0x5_d119);           /* call 0x101482f4 */
            ii(0x100e_b1db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_b1dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1e0, 3); mov(memd_a32[ds, eax + 0x36], edx);     /* mov [eax+0x36], edx */
        l_0x100e_b1e3:
            ii(0x100e_b1e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1e6, 4); mov(memb_a32[ds, eax + 0x1a], 0x1);     /* mov byte [eax+0x1a], 0x1 */
            ii(0x100e_b1ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1ed, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_b1f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1f4, 4); mov(memb_a32[ds, eax + 0x32], 0x1);     /* mov byte [eax+0x32], 0x1 */
            ii(0x100e_b1f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b1fb, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b1fe, 5); calld(Definitions.sys_strlen, 0x8_6cc4); /* call 0x10171ec7 */
            ii(0x100e_b203, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_b205, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b208, 4); mov(memw_a32[ds, eax + 0x2c], dx);      /* mov [eax+0x2c], dx */
            ii(0x100e_b20c, 5); calld(0x100d_6104, -0x1_510d);          /* call 0x100d6104 */
            ii(0x100e_b211, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_b213, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_b215, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b218, 5); calld(0x100e_b5e1, 0x3c4);              /* call 0x100eb5e1 */
            ii(0x100e_b21d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b21f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b220, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b221, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b222, 1); popd(edx);                              /* pop edx */
            ii(0x100e_b223, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b224, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b225, 1); retd(); return;                         /* ret */
        }
    }
}
