using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0765a2bd-d408-4b0f-b251-a7f0b893c040")]
        public void Method_100d_6fb9()
        {
            ii(0x100d_6fb9, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100d_6fbe, 5); calld(Definitions.sys_check_available_stack_size, 0x8_ed8f); /* call 0x10165d52 */
            ii(0x100d_6fc3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6fc4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6fc5, 1); pushd(edx);                             /* push edx */
            ii(0x100d_6fc6, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6fc7, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6fc8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6fc9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6fcb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100d_6fd1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_6fd4, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_6fd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6fda, 3); mov(eax, memd_a32[ds, eax + 0x20]);     /* mov eax, [eax+0x20] */
            ii(0x100d_6fdd, 5); calld(0x100d_6a11, -0x5d1);             /* call 0x100d6a11 */
            ii(0x100d_6fe2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6fe5, 4); cmp(memd_a32[ds, eax + 0xa], 0);        /* cmp dword [eax+0xa], 0x0 */
            ii(0x100d_6fe9, 2); if(jzd(0x100d_6ff9, 0xe)) goto l_0x100d_6ff9; /* jz 0x100d6ff9 */
            ii(0x100d_6feb, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_6fee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6ff1, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_6ff4, 5); calld(0x100d_7d74, 0xd7b);              /* call 0x100d7d74 */
        l_0x100d_6ff9:
            ii(0x100d_6ff9, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_6ffc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6fff, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7002, 5); calld(0x100d_7d74, 0xd6d);              /* call 0x100d7d74 */
            ii(0x100d_7007, 3); mov(edx, memd_a32[ss, ebp - 0xe]);      /* mov edx, [ebp-0xe] */
            ii(0x100d_700a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_700d, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100d_7010, 5); calld(0x100c_f85c, -0x77b9);            /* call 0x100cf85c */
            ii(0x100d_7015, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7017, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7018, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7019, 1); popd(esi);                              /* pop esi */
            ii(0x100d_701a, 1); popd(edx);                              /* pop edx */
            ii(0x100d_701b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_701c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_701d, 1); retd(); return;                         /* ret */
        }
    }
}
