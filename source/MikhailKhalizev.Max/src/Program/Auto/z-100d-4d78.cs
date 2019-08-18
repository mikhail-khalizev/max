using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ae4050c-a001-4e7f-8bfd-5762de7c8fa7")]
        public void Method_100d_4d78()
        {
            ii(0x100d_4d78, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4d7d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0fd0); /* call 0x10165d52 */
            ii(0x100d_4d82, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4d83, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4d84, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4d85, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4d86, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4d87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4d89, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_4d8f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4d92, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_4d95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4d98, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100d_4d9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4d9d, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100d_4d9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4da2, 3); mov(dl, memb_a32[ds, eax + 0x1]);       /* mov dl, [eax+0x1] */
            ii(0x100d_4da5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4da8, 3); mov(memb_a32[ds, eax + 0x1], dl);       /* mov [eax+0x1], dl */
            ii(0x100d_4dab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4dae, 3); mov(dl, memb_a32[ds, eax + 0x2]);       /* mov dl, [eax+0x2] */
            ii(0x100d_4db1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4db4, 3); mov(memb_a32[ds, eax + 0x2], dl);       /* mov [eax+0x2], dl */
            ii(0x100d_4db7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4dba, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_4dbd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_4dc0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4dc2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4dc3, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4dc4, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4dc5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4dc6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4dc7, 1); retd(); return;                         /* ret */
        }
    }
}
