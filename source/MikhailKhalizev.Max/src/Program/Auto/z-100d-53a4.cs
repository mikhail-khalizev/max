using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_53a4-dc89651e")]
        public void Method_100d_53a4()
        {
            ii(0x100d_53a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_53a9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_09a4); /* call 0x10165d52 */
            ii(0x100d_53ae, 1); pushd(esi);                             /* push esi */
            ii(0x100d_53af, 1); pushd(edi);                             /* push edi */
            ii(0x100d_53b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_53b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_53b3, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_53b9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_53bc, 3); mov(memb_a32[ss, ebp - 0xc], dl);       /* mov [ebp-0xc], dl */
            ii(0x100d_53bf, 3); mov(memb_a32[ss, ebp - 0x8], bl);       /* mov [ebp-0x8], bl */
            ii(0x100d_53c2, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x100d_53c5, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_53c8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_53cb, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100d_53cd, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100d_53d0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_53d3, 3); mov(memb_a32[ds, edx + 0x1], al);       /* mov [edx+0x1], al */
            ii(0x100d_53d6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_53d9, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_53dc, 3); mov(memb_a32[ds, edx + 0x2], al);       /* mov [edx+0x2], al */
            ii(0x100d_53df, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_53e2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_53e5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_53e8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_53ea, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_53eb, 1); popd(edi);                              /* pop edi */
            ii(0x100d_53ec, 1); popd(esi);                              /* pop esi */
            ii(0x100d_53ed, 1); retd();                                 /* ret */
        }
    }
}
