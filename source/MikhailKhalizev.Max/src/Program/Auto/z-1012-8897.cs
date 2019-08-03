using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fdf677db-4e0a-4d00-8f42-9ce6efdd855c")]
        public void Method_1012_8897()
        {
            ii(0x1012_8897, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_889c, 5); calld(Definitions.sys_check_available_stack_size, 0x3d4b1); /* call 0x10165d52 */
            ii(0x1012_88a1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_88a2, 1); pushd(esi);                             /* push esi */
            ii(0x1012_88a3, 1); pushd(edi);                             /* push edi */
            ii(0x1012_88a4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_88a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_88a7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_88ad, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1012_88b0, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_88b3, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1012_88b6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1012_88b9, 5); mov(memb_a32[ds, 0x101c_5c1c], al);     /* mov [0x101c5c1c], al */
            ii(0x1012_88be, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_88c1, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_88c7, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x1);    /* mov word [0x101c5c1f], 0x1 */
            ii(0x1012_88d0, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_88d3, 5); mov(memb_a32[ds, 0x101c_5c21], al);     /* mov [0x101c5c21], al */
            ii(0x1012_88d8, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_88dd, 5); calld(0x1012_5be9, -0x2cf9);            /* call 0x10125be9 */
            ii(0x1012_88e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_88e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_88e5, 1); popd(edi);                              /* pop edi */
            ii(0x1012_88e6, 1); popd(esi);                              /* pop esi */
            ii(0x1012_88e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_88e8, 1); retd(); return;                         /* ret */
        }
    }
}