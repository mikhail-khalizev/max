using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7c311477-2c43-4be0-a4b4-bfb4a3df17fd")]
        public void Method_100a_681b()
        {
            ii(0x100a_681b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_6820, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f52d); /* call 0x10165d52 */
            ii(0x100a_6825, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_6826, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6827, 1); pushd(edx);                             /* push edx */
            ii(0x100a_6828, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6829, 1); pushd(edi);                             /* push edi */
            ii(0x100a_682a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_682b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_682d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_6833, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_6836, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6839, 4); cmp(memb_a32[ds, eax + 0x1c], 0);       /* cmp byte [eax+0x1c], 0x0 */
            ii(0x100a_683d, 2); if(jzd(0x100a_685a, 0x1b)) goto l_0x100a_685a; /* jz 0x100a685a */
            ii(0x100a_683f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_6844, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6847, 5); calld(0x100a_28ff, -0x3f4d);            /* call 0x100a28ff */
            ii(0x100a_684c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_684f, 4); mov(memb_a32[ds, eax + 0x1b], 0x1);     /* mov byte [eax+0x1b], 0x1 */
            ii(0x100a_6853, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6856, 4); mov(memb_a32[ds, eax + 0x1c], 0);       /* mov byte [eax+0x1c], 0x0 */
        l_0x100a_685a:
            ii(0x100a_685a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_685c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_685d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_685e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_685f, 1); popd(edx);                              /* pop edx */
            ii(0x100a_6860, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6861, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_6862, 1); retd(); return;                         /* ret */
        }
    }
}
