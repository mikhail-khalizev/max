using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6fa3bf3b-0e5a-41b0-9e64-3f8fe0fb19ce")]
        public void Method_1015_7c2b()
        {
            ii(0x1015_7c2b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_7c30, 5); calld(Definitions.sys_check_available_stack_size, 0xe11d); /* call 0x10165d52 */
            ii(0x1015_7c35, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_7c36, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_7c37, 1); pushd(edx);                             /* push edx */
            ii(0x1015_7c38, 1); pushd(esi);                             /* push esi */
            ii(0x1015_7c39, 1); pushd(edi);                             /* push edi */
            ii(0x1015_7c3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_7c3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_7c3d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_7c43, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_7c46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_7c49, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_7c4d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_7c50, 4); cmp(ax, memw_a32[ds, edx + 0x8]);       /* cmp ax, [edx+0x8] */
            ii(0x1015_7c54, 2); if(jzd(0x1015_7c5c, 0x6)) goto l_0x1015_7c5c; /* jz 0x10157c5c */
            ii(0x1015_7c56, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_7c5a, 2); jmpd(0x1015_7c60, 0x4); goto l_0x1015_7c60; /* jmp 0x10157c60 */
        l_0x1015_7c5c:
            ii(0x1015_7c5c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_7c60:
            ii(0x1015_7c60, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_7c63, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_7c66, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_7c69, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_7c6b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_7c6c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_7c6d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_7c6e, 1); popd(edx);                              /* pop edx */
            ii(0x1015_7c6f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_7c70, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_7c71, 1); retd(); return;                         /* ret */
        }
    }
}
