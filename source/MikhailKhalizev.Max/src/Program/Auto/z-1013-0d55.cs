using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0d55-b60ffd6e")]
        public void Method_1013_0d55()
        {
            ii(0x1013_0d55, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_0d5a, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4ff3); /* call 0x10165d52 */
            ii(0x1013_0d5f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0d60, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0d61, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0d62, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0d63, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0d64, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0d66, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0d6c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0d6f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_0d72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_0d75, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_0d78, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0d7b, 4); cmp(memb_a32[ds, eax + 0x17], 0x2);     /* cmp byte [eax+0x17], 0x2 */
            ii(0x1013_0d7f, 2); if(jzd(0x1013_0d95, 0x14)) goto l_0x1013_0d95; /* jz 0x10130d95 */
            ii(0x1013_0d81, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0d84, 4); mov(memb_a32[ds, eax + 0x17], 0x2);     /* mov byte [eax+0x17], 0x2 */
            ii(0x1013_0d88, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0d8d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0d90, 5); calld(0x1013_0c16, -0x17f);             /* call 0x10130c16 */
        l_0x1013_0d95:
            ii(0x1013_0d95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0d97, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0d98, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0d99, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0d9a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0d9b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0d9c, 1); retd();                                 /* ret */
        }
    }
}
