using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d35eb25-0d09-413f-a70f-cc33ce22b569")]
        public void Method_1011_6aa4()
        {
            ii(0x1011_6aa4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_6aa9, 5); calld(Definitions.sys_check_available_stack_size, 0x4f2a4); /* call 0x10165d52 */
            ii(0x1011_6aae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_6aaf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_6ab0, 1); pushd(edx);                             /* push edx */
            ii(0x1011_6ab1, 1); pushd(esi);                             /* push esi */
            ii(0x1011_6ab2, 1); pushd(edi);                             /* push edi */
            ii(0x1011_6ab3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_6ab4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_6ab6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_6abc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_6abf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6ac2, 4); mov(memb_a32[ds, eax + 0x31], 0);       /* mov byte [eax+0x31], 0x0 */
        l_0x1011_6ac6:
            ii(0x1011_6ac6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6ac9, 4); cmp(memb_a32[ds, eax + 0x31], 0);       /* cmp byte [eax+0x31], 0x0 */
            ii(0x1011_6acd, 2); if(jnzd(0x1011_6afd, 0x2e)) goto l_0x1011_6afd; /* jnz 0x10116afd */
            ii(0x1011_6acf, 5); calld(/* sys */ 0x1016_b208, 0x54734);  /* call 0x1016b208 */
            ii(0x1011_6ad4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_6ad7, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_6ade, 2); if(jzd(0x1011_6af0, 0x10)) goto l_0x1011_6af0; /* jz 0x10116af0 */
            ii(0x1011_6ae0, 5); calld(0x1012_8659, 0x11b74);            /* call 0x10128659 */
            ii(0x1011_6ae5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_6ae7, 2); if(jzd(0x1011_6af0, 0x7)) goto l_0x1011_6af0; /* jz 0x10116af0 */
            ii(0x1011_6ae9, 7); mov(memd_a32[ss, ebp - 0x8], 0x1b);     /* mov dword [ebp-0x8], 0x1b */
        l_0x1011_6af0:
            ii(0x1011_6af0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_6af3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6af6, 5); calld(0x1011_683d, -0x2be);             /* call 0x1011683d */
            ii(0x1011_6afb, 2); jmpd(0x1011_6ac6, -0x37); goto l_0x1011_6ac6; /* jmp 0x10116ac6 */
        l_0x1011_6afd:
            ii(0x1011_6afd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6aff, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_6b00, 1); popd(edi);                              /* pop edi */
            ii(0x1011_6b01, 1); popd(esi);                              /* pop esi */
            ii(0x1011_6b02, 1); popd(edx);                              /* pop edx */
            ii(0x1011_6b03, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_6b04, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_6b05, 1); retd(); return;                         /* ret */
        }
    }
}
